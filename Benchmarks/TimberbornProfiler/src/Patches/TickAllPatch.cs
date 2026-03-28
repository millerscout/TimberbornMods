using System.Diagnostics;
using System.Threading;
using HarmonyLib;

namespace TimberbornProfiler.Patches
{
    /// <summary>
    /// Times the total wall duration of TickableSingletonService.TickAll().
    /// This covers: Wait() for parallel work + TickSingletons() + StartParallelTick().
    /// </summary>
    [HarmonyPatch("Timberborn.TickSystem.TickableSingletonService", "TickAll")]
    internal static class TickAllPatch
    {
        static void Prefix(out long __state)
        {
            __state = Stopwatch.GetTimestamp();
        }

        static void Postfix(long __state)
        {
            if (!ProfilerManager.Enabled) return;
            long ns = ProfilerManager.TimestampToNs(__state);
            Interlocked.Add(ref ProfilerManager.TickAllWallNs, ns);
            ProfilerManager.OnTickComplete();
        }
    }
}
