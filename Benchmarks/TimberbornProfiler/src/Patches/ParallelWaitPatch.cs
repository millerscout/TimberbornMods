using System.Diagnostics;
using System.Threading;
using HarmonyLib;

namespace TimberbornProfiler.Patches
{
    /// <summary>
    /// Times Parallelizer.Wait() — the duration the main thread is blocked waiting for
    /// parallel water simulation workers to finish. This is the parallel phase wall time
    /// and the primary bottleneck when the water map is large.
    /// </summary>
    [HarmonyPatch("Timberborn.Multithreading.Parallelizer", "Wait")]
    internal static class ParallelWaitPatch
    {
        static void Prefix(out long __state)
        {
            ProfilerManager.OnBeforeWait();
            __state = Stopwatch.GetTimestamp();
        }

        static void Postfix(long __state)
        {
            if (!ProfilerManager.Enabled) return;
            long ns = ProfilerManager.TimestampToNs(__state);
            Interlocked.Add(ref ProfilerManager.ParallelWallNs, ns);
        }
    }
}
