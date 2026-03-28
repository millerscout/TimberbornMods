using System;
using System.Reflection;
using HarmonyLib;
using TimberbornProfiler.Patches;
using Timberborn.ModManagerScene;
using UnityEngine;

namespace TimberbornProfiler
{
    public class ModEntry : IModStarter
    {
        public void StartMod(IModEnvironment modEnvironment)
        {
            var harmony = new Harmony(ModInfo.HarmonyID);
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            PatchOptionalSoilSystem(harmony,
                "Timberborn.SoilMoistureSystem",
                new[] {
                    ("Timberborn.SoilMoistureSystem.MoistureDataPreparationTask",    typeof(MoistureDataPreparationTaskPatch)),
                    ("Timberborn.SoilMoistureSystem.WateredNeighborsCountingTask",   typeof(WateredNeighborsCountingTaskPatch)),
                    ("Timberborn.SoilMoistureSystem.ClusterSaturationCalculationTask", typeof(ClusterSaturationCalculationTaskPatch)),
                    ("Timberborn.SoilMoistureSystem.WaterEvaporationCalculationTask",  typeof(WaterEvaporationCalculationTaskPatch)),
                    ("Timberborn.SoilMoistureSystem.MoistureCalculationTask",          typeof(MoistureCalculationTaskPatch)),
                });

            PatchOptionalSoilSystem(harmony,
                "Timberborn.SoilContaminationSystem",
                new[] {
                    ("Timberborn.SoilContaminationSystem.ContaminationDataPreparationTask",    typeof(ContaminationDataPreparationTaskPatch)),
                    ("Timberborn.SoilContaminationSystem.ContaminationCandidatesCountingTask", typeof(ContaminationCandidatesCountingTaskPatch)),
                    ("Timberborn.SoilContaminationSystem.ContaminationsUpdateTask",            typeof(ContaminationsUpdateTaskPatch)),
                });

            // Log which patches actually applied so we can diagnose zeroed metrics
            var patched = harmony.GetPatchedMethods();
            foreach (var m in patched)
                Debug.Log($"[TimberbornProfiler] Patched: {m.DeclaringType?.FullName}.{m.Name}");

            Debug.Log("[TimberbornProfiler] Loaded. Enable profiling in Mod Settings to start collecting.");
        }

        static void PatchOptionalSoilSystem(Harmony harmony, string assemblyName, (string typeName, Type patchClass)[] tasks)
        {
            // Check the first task type as a proxy for the whole assembly being present
            if (AccessTools.TypeByName(tasks[0].typeName) == null)
            {
                Debug.Log($"[TimberbornProfiler] {assemblyName} not found — metrics disabled.");
                return;
            }

            foreach (var (typeName, patchClass) in tasks)
            {
                var target = AccessTools.TypeByName(typeName);
                if (target == null) continue;
                var run = AccessTools.Method(target, "Run");
                if (run == null) continue;
                harmony.Patch(run,
                    prefix:  new HarmonyMethod(AccessTools.Method(patchClass, "Prefix")),
                    postfix: new HarmonyMethod(AccessTools.Method(patchClass, "Postfix")));
            }
        }
    }
}
