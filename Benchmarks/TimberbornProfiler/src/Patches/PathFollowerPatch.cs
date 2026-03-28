using System.Diagnostics;
using HarmonyLib;

namespace TimberbornProfiler.Patches
{
    /// <summary>
    /// Times PathFollower.MoveAlongPath() — called once per character per tick on the main thread.
    /// Cost scales linearly with population. High population maps may spend significant time here.
    /// </summary>
    [HarmonyPatch("Timberborn.CharacterMovementSystem.PathFollower", "MoveAlongPath")]
    internal static class PathFollowerPatch
    {
        static void Prefix(out long __state) => __state = Stopwatch.GetTimestamp();
        static void Postfix(long __state)
        {
            if (!ProfilerManager.Enabled) return;
            ProfilerManager.PathFollowerNs += ProfilerManager.TimestampToNs(__state);
        }
    }
}
