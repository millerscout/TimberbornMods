using System.Reflection;
using HarmonyLib;
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

            var patched = harmony.GetPatchedMethods();
            foreach (var m in patched)
                Debug.Log($"[OptimizationPatches] Patched: {m.DeclaringType?.FullName}.{m.Name}");

            Debug.Log("[OptimizationPatches] Loaded. Water sim optimizations active.");
        }
    }
}
