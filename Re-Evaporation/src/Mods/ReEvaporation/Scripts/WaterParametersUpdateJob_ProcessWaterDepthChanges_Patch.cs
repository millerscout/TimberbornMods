using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;
using UnityEngine;

namespace Mods.ReEvaporation.Scripts
{
    [HarmonyPatch("Timberborn.WaterSystem.WaterParametersUpdateTask", "ProcessWaterDepthChanges")]
    public static class WaterParametersUpdateTask_ProcessWaterDepthChanges_Patch
    {
        private static IEnumerable<CodeInstruction> Transpiler(
            IEnumerable<CodeInstruction> instructions,
            ILGenerator generator)
        {
            var list = new List<CodeInstruction>(instructions);

            var taskType = AccessTools.TypeByName("Timberborn.WaterSystem.WaterParametersUpdateTask");
            FieldInfo? evaporationModifiersField = taskType != null
                ? AccessTools.Field(taskType, "_evaporationModifiers")
                : null;

            if (evaporationModifiersField == null)
            {
                Debug.LogError("[Re-Evaporation] Transpiler critical field lookup failed: _evaporationModifiers in WaterParametersUpdateTask.");
                return instructions;
            }

            for (int i = 0; i < list.Count - 4; i++)
            {
                if (list[i].opcode == OpCodes.Ldflda
                    && list[i].operand as FieldInfo == evaporationModifiersField
                    && list[i + 1].opcode == OpCodes.Ldarg_3
                    && list[i + 2].opcode == OpCodes.Call
                    && list[i + 3].opcode == OpCodes.Ldind_R4)
                {
                    Debug.Log($"[Re-Evaporation] Found evaporation pattern at IL[{i}].");

                    var injection = new List<CodeInstruction>
                    {
                        new CodeInstruction(OpCodes.Ldarg_3),
                        new CodeInstruction(OpCodes.Call,
                            AccessTools.Method(
                                typeof(WaterParametersUpdateTask_ProcessWaterDepthChanges_Patch),
                                nameof(GetModifiedEvaporationRate)))
                    };

                    list.InsertRange(i + 4, injection);
                    Debug.Log("[Re-Evaporation] Transpiler applied successfully.");
                    return list;
                }
            }

            Debug.LogWarning("[Re-Evaporation] Transpiler did not find the target IL pattern. The evaporation patch was not applied.");
            return list;
        }

        public static float GetModifiedEvaporationRate(float originalRate, int index3D)
        {
            EvaporationManager? manager = EvaporationManager.Instance;
            if (manager == null) return originalRate;
            return originalRate * manager.GetEvaporationMultiplier(index3D);
        }
    }
}
