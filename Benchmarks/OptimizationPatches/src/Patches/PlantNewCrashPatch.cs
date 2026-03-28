using System;
using HarmonyLib;
using UnityEngine;

namespace OptimizationPatches.Patches
{
    /// <summary>
    /// Fixes a vanilla bug: NaturalResourceFactory.PlantNew has no occupancy check
    /// before calling BlockObjectFactory.CreateFinished, unlike SpawnNew which calls
    /// CanSpawn() first. If the target cell becomes occupied between task assignment
    /// and beaver execution, PlantNew throws ArgumentException and crashes the entity.
    /// The finalizer catches the block-conflict and silently discards it.
    /// </summary>
    [HarmonyPatch("Timberborn.NaturalResources.NaturalResourceFactory", "PlantNew")]
    internal static class PlantNewCrashPatch
    {
        static Exception? Finalizer(Exception? __exception, string resourceId, Vector3Int coordinates)
        {
            if (__exception is ArgumentException)
            {
                Debug.LogWarning(
                    $"[OptimizationPatches] PlantNew suppressed: cell {coordinates} was already occupied " +
                    $"when '{resourceId}' tried to spawn. ({__exception.Message})");
                return null;
            }
            return __exception;
        }
    }
}
