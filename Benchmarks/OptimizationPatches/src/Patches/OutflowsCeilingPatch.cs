using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;

namespace OptimizationPatches.Patches
{
    /// <summary>
    /// Replaces Math.Ceiling(double) with MathF.Ceiling(float) in OutflowsUpdateTask.GetOutflow.
    ///
    /// Root cause: line 198 of OutflowsUpdateTask.cs does:
    ///   int waterHeight = (int)Math.Ceiling(num);
    /// where 'num' is a float local. Math.Ceiling takes double, so the compiler silently promotes
    /// float → double → int via conv.r8 + call Math.Ceiling + conv.i4. This happens for every
    /// cell in the outflow nested loop (~260k calls/frame on a 128×128 map).
    ///
    /// MicroBenchmark result: MathF.Ceiling is 29% faster than Math.Ceiling for this pattern.
    /// </summary>
    [HarmonyPatch("Timberborn.WaterSystem.OutflowsUpdateTask", "GetOutflow")]
    internal static class OutflowsCeilingPatch
    {
        private static readonly MethodInfo MathCeiling =
            typeof(Math).GetMethod("Ceiling", new[] { typeof(double) })!;

        private static readonly MethodInfo MathFCeiling =
            typeof(MathF).GetMethod("Ceiling", new[] { typeof(float) })!;

        static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            var code = new List<CodeInstruction>(instructions);
            int replacements = 0;

            for (int i = 0; i < code.Count - 1; i++)
            {
                // Pattern: conv.r8 followed immediately by call Math.Ceiling(double)
                if (code[i].opcode == OpCodes.Conv_R8 &&
                    code[i + 1].opcode == OpCodes.Call &&
                    code[i + 1].operand is MethodInfo m &&
                    m == MathCeiling)
                {
                    // Remove the float→double conversion (conv.r8 → nop)
                    code[i].opcode = OpCodes.Nop;
                    code[i].operand = null;

                    // Replace Math.Ceiling(double) with MathF.Ceiling(float)
                    code[i + 1].operand = MathFCeiling;

                    replacements++;
                    i++; // skip the instruction we just modified
                }
            }

            if (replacements == 0)
                UnityEngine.Debug.LogWarning(
                    "[OptimizationPatches] OutflowsCeilingPatch: no Math.Ceiling call found — patch may be broken.");
            else
                UnityEngine.Debug.Log(
                    $"[OptimizationPatches] OutflowsCeilingPatch: replaced {replacements} Math.Ceiling → MathF.Ceiling");

            return code;
        }
    }
}
