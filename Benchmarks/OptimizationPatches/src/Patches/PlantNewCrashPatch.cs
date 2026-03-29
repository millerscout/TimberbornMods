using HarmonyLib;
using Timberborn.BlockSystem;
using Timberborn.NaturalResources;
using Timberborn.TemplateSystem;
using UnityEngine;

namespace OptimizationPatches.Patches
{
    /// <summary>
    /// Fixes a vanilla bug: NaturalResourceFactory.PlantNew has no occupancy check before
    /// calling BlockObjectFactory.CreateFinished, unlike SpawnNew which calls CanSpawn first.
    /// If the target cell is occupied, CreateUnfinished instantiates the entity GameObject and
    /// then Reposition throws — leaving a dangling entity. The Prefix prevents instantiation
    /// entirely by mirroring the same check SpawnNew uses (ignoring moisture/field constraints
    /// since player planting should bypass those).
    /// </summary>
    [HarmonyPatch(typeof(NaturalResourceFactory), nameof(NaturalResourceFactory.PlantNew))]
    internal static class PlantNewCrashPatch
    {
        static bool Prefix(
            string resourceId,
            Vector3Int coordinates,
            SpawnValidationService ____spawnValidationService,
            TemplateNameMapper ____templateNameMapper)
        {
            BlockObjectSpec spec = ____templateNameMapper.GetTemplate(resourceId).GetSpec<BlockObjectSpec>();
            if (____spawnValidationService.CanSpawnIgnoringConstraints(coordinates, spec))
                return true;
            Debug.LogWarning(
                $"[OptimizationPatches] PlantNew skipped: cell {coordinates} is occupied for '{resourceId}'.");
            return false;
        }
    }
}
