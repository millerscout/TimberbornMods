using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;

namespace OptimizationPatches.Patches
{
    /// <summary>
    /// Adds a fast-path early-exit in ContaminationCandidatesCountingTask.GetContaminationFromNeighbor
    /// (the 5-param outer overload).
    ///
    /// Root cause: called 8× per terrain cell per tick (4 cardinal + 4 diagonal neighbors).
    /// Each call iterates terrain layers and invokes the 4-param inner overload. The inner overload
    /// returns at most: _lastTickContaminationCandidates[num] - spreadCost
    /// (because verticalCostMod * max(0, height-ceiling) >= 0).
    ///
    /// Therefore if candidates[num] <= currentContamination + cost, the inner call cannot improve
    /// currentContamination and can be skipped entirely.
    ///
    /// On maps with mostly uncontaminated soil (common), candidates[num] = 0 and
    /// currentContamination = 0, so (0 <= 0 + cost) → skip fires ~100% of the time.
    ///
    /// No [HarmonyPatch] attribute — applied manually in ModEntry via PatchOptionalSoilContamination.
    /// </summary>
    internal static class ContaminationNeighborEarlyExitPatch
    {
        internal static IEnumerable<CodeInstruction> Transpiler(
            IEnumerable<CodeInstruction> instructions,
            ILGenerator generator)
        {
            var code = new List<CodeInstruction>(instructions);

            var taskType = AccessTools.TypeByName(
                "Timberborn.SoilContaminationSystem.ContaminationCandidatesCountingTask");
            if (taskType == null)
            {
                UnityEngine.Debug.LogWarning(
                    "[OptimizationPatches] ContaminationNeighborEarlyExitPatch: taskType not found.");
                return code;
            }

            var candidatesField = AccessTools.Field(taskType, "_lastTickContaminationCandidates");
            if (candidatesField == null)
            {
                UnityEngine.Debug.LogWarning(
                    "[OptimizationPatches] ContaminationNeighborEarlyExitPatch: _lastTickContaminationCandidates not found.");
                return code;
            }

            var arrayField = AccessTools.Field(candidatesField.FieldType, "_array");
            if (arrayField == null)
            {
                UnityEngine.Debug.LogWarning(
                    "[OptimizationPatches] ContaminationNeighborEarlyExitPatch: ReadOnlyArray._array not found.");
                return code;
            }

            // Find the call to the 4-param inner overload
            int callIdx = -1;
            for (int i = 0; i < code.Count; i++)
            {
                if (code[i].opcode == OpCodes.Call
                    && code[i].operand is MethodBase mb
                    && mb.DeclaringType == taskType
                    && mb.Name == "GetContaminationFromNeighbor"
                    && mb.GetParameters().Length == 4)
                {
                    callIdx = i;
                    break;
                }
            }
            if (callIdx == -1)
            {
                UnityEngine.Debug.LogWarning(
                    "[OptimizationPatches] ContaminationNeighborEarlyExitPatch: inner 4-param call not found.");
                return code;
            }

            // Validate: instruction 5 before the call should be Ldarg_0 (receiver for the inner call)
            if (callIdx < 5 || code[callIdx - 5].opcode != OpCodes.Ldarg_0)
            {
                UnityEngine.Debug.LogWarning(
                    "[OptimizationPatches] ContaminationNeighborEarlyExitPatch: unexpected IL before inner call " +
                    $"(expected Ldarg_0 at callIdx-5={callIdx - 5}, found {code[callIdx - 5].opcode}).");
                return code;
            }

            // Find the first ble/ble.un/brfalse AFTER the inner call — this is the branch that
            // skips the `currentContamination = contaminationFromNeighbor` update when result <= current.
            // Its target label is exactly where we want to jump on early-exit.
            int skipBranchIdx = -1;
            for (int i = callIdx + 1; i < Math.Min(callIdx + 10, code.Count); i++)
            {
                var op = code[i].opcode;
                if (op == OpCodes.Ble || op == OpCodes.Ble_S
                    || op == OpCodes.Ble_Un || op == OpCodes.Ble_Un_S
                    || op == OpCodes.Brfalse || op == OpCodes.Brfalse_S)
                {
                    skipBranchIdx = i;
                    break;
                }
            }
            if (skipBranchIdx == -1)
            {
                UnityEngine.Debug.LogWarning(
                    "[OptimizationPatches] ContaminationNeighborEarlyExitPatch: skip-update branch not found after inner call.");
                return code;
            }

            var skipLabel = (Label)code[skipBranchIdx].operand;

            // ldloc <num> is at callIdx - 4 (the first real argument of the inner call, after ldarg.0)
            var numLoadInstr = code[callIdx - 4];

            // Insert the guard before the 5-instruction setup for the inner call (callIdx - 5)
            int insertIdx = callIdx - 5;

            // Guard: if candidates[num] <= currentContamination + cost → skip to skipLabel
            // This mirrors what the inner overload would have done (result <= candidates[num] - cost <= current),
            // so skipping it produces the same result for currentContamination.
            var guard = new List<CodeInstruction>
            {
                new CodeInstruction(OpCodes.Ldarg_0),              // this
                new CodeInstruction(OpCodes.Ldflda, candidatesField), // ref ReadOnlyArray<float>
                new CodeInstruction(OpCodes.Ldfld, arrayField),    // float[]
                numLoadInstr.Clone(),                              // ldloc <num> (neighborIndex3D)
                new CodeInstruction(OpCodes.Ldelem_R4),            // candidates[num]
                new CodeInstruction(OpCodes.Ldarg_S, (byte)4),    // currentContamination
                new CodeInstruction(OpCodes.Ldarg_S, (byte)5),    // cost
                new CodeInstruction(OpCodes.Add),                  // currentContamination + cost
                new CodeInstruction(OpCodes.Ble_Un, skipLabel),   // skip if candidates[num] <= current+cost
            };

            code.InsertRange(insertIdx, guard);

            UnityEngine.Debug.Log(
                "[OptimizationPatches] ContaminationNeighborEarlyExitPatch: injected 9-instruction early-exit guard.");
            return code;
        }
    }
}
