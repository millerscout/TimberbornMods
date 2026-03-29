using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;

namespace OptimizationPatches.Patches
{
    /// <summary>
    /// Replaces Math.Ceiling(double) with MathF.Ceiling(float) in
    /// MoistureCalculationTask.GetMoistureFromNeighbor (the 5-param overload).
    ///
    /// Root cause: line 301 of MoistureCalculationTask.cs does:
    ///   int num3 = (int)Math.Ceiling(column.WaterDepth);
    /// where WaterDepth is a float. Math.Ceiling takes double, so the compiler silently
    /// promotes float → double via conv.r8. Estimated ~393k calls/frame on a 128×128 map.
    ///
    /// No [HarmonyPatch] attribute — applied manually in ModEntry only when
    /// Timberborn.SoilMoistureSystem assembly is present at runtime.
    ///
    /// MicroBenchmark prediction: MathF.Ceiling ~29% faster (see SoilMoistureCeilingBenchmarks).
    /// </summary>
    internal static class SoilMoistureCeilingPatch
    {
        private static readonly MethodInfo MathCeiling =
            typeof(Math).GetMethod("Ceiling", new[] { typeof(double) })!;

        private static readonly MethodInfo MathFCeiling =
            typeof(MathF).GetMethod("Ceiling", new[] { typeof(float) })!;

        internal static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
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
                    code[i].opcode = OpCodes.Nop;
                    code[i].operand = null;
                    code[i + 1].operand = MathFCeiling;
                    replacements++;
                    i++;
                }
            }

            if (replacements == 0)
                UnityEngine.Debug.LogWarning(
                    "[OptimizationPatches] SoilMoistureCeilingPatch: no Math.Ceiling call found — patch may be broken.");
            else
                UnityEngine.Debug.Log(
                    $"[OptimizationPatches] SoilMoistureCeilingPatch: replaced {replacements} Math.Ceiling → MathF.Ceiling");

            return code;
        }
    }
}
