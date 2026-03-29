using System;
using System.Reflection;
using HarmonyLib;
using OptimizationPatches.Patches;
using Timberborn.ModManagerScene;
using UnityEngine;

namespace OptimizationPatches
{
    public class ModEntry : IModStarter
    {
        public void StartMod(IModEnvironment modEnvironment)
        {
            var harmony = new Harmony(ModInfo.HarmonyID);
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            PatchOptionalSoilMoisture(harmony);
            PatchOptionalSoilContamination(harmony);

            var patched = harmony.GetPatchedMethods();
            foreach (var m in patched)
                Debug.Log($"[OptimizationPatches] Patched: {m.DeclaringType?.FullName}.{m.Name}");

            Debug.Log("[OptimizationPatches] Loaded. Water sim optimizations active.");
        }

        static void PatchOptionalSoilContamination(Harmony harmony)
        {
            var taskType = AccessTools.TypeByName(
                "Timberborn.SoilContaminationSystem.ContaminationCandidatesCountingTask");
            if (taskType == null)
            {
                Debug.Log("[OptimizationPatches] SoilContaminationSystem not found — neighbor early-exit patch skipped.");
                return;
            }
            var method = AccessTools.Method(taskType, "GetContaminationFromNeighbor",
                new[] { typeof(int), typeof(int), typeof(int), typeof(float), typeof(float) });
            if (method == null)
            {
                Debug.LogWarning("[OptimizationPatches] GetContaminationFromNeighbor(int,int,int,float,float) not found — patch skipped.");
                return;
            }
            harmony.Patch(method,
                transpiler: new HarmonyMethod(
                    AccessTools.Method(typeof(Patches.ContaminationNeighborEarlyExitPatch), "Transpiler")));
        }

        static void PatchOptionalSoilMoisture(Harmony harmony)
        {
            var taskType = AccessTools.TypeByName(
                "Timberborn.SoilMoistureSystem.MoistureCalculationTask");
            if (taskType == null)
            {
                Debug.Log("[OptimizationPatches] SoilMoistureSystem not found — ceiling patch skipped.");
                return;
            }
            var method = AccessTools.Method(taskType, "GetMoistureFromNeighbor",
                new[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(float) });
            if (method == null)
            {
                Debug.LogWarning("[OptimizationPatches] GetMoistureFromNeighbor(int,int,int,int,float) not found — patch skipped.");
                return;
            }
            harmony.Patch(method,
                transpiler: new HarmonyMethod(
                    AccessTools.Method(typeof(SoilMoistureCeilingPatch), "Transpiler")));
        }
    }
}
