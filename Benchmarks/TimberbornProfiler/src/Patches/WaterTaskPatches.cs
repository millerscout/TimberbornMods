using System.Diagnostics;
using System.Threading;
using HarmonyLib;

namespace TimberbornProfiler.Patches
{
    // ─────────────────────────────────────────────────────────────────────────────
    // Loop tasks (IParallelizerLoopTask) — Run(int y), called once per map row
    // on worker threads. CPU time is summed across all rows and all threads.
    // ─────────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Calculates outflow between adjacent water cells.
    /// Innermost loop: calls GetOutflow 4× per cell. Highest expected CPU cost.
    /// </summary>
    [HarmonyPatch("Timberborn.WaterSystem.OutflowsUpdateTask", "Run")]
    internal static class OutflowsUpdateTaskPatch
    {
        static void Prefix(out long __state) => __state = Stopwatch.GetTimestamp();
        static void Postfix(long __state)
        {
            if (!ProfilerManager.Enabled) return;
            Interlocked.Add(ref ProfilerManager.OutflowsCpuNs, ProfilerManager.TimestampToNs(__state));
        }
    }

    /// <summary>
    /// Applies outflow results to update water depth per cell. Also handles evaporation.
    /// </summary>
    [HarmonyPatch("Timberborn.WaterSystem.WaterParametersUpdateTask", "Run")]
    internal static class WaterParametersUpdateTaskPatch
    {
        static void Prefix(out long __state) => __state = Stopwatch.GetTimestamp();
        static void Postfix(long __state)
        {
            if (!ProfilerManager.Enabled) return;
            Interlocked.Add(ref ProfilerManager.WaterParamsCpuNs, ProfilerManager.TimestampToNs(__state));
        }
    }

    /// <summary>
    /// Calculates contamination diffusion between adjacent cells.
    /// </summary>
    [HarmonyPatch("Timberborn.WaterSystem.SimulateContaminationTask", "Run")]
    internal static class SimulateContaminationTaskPatch
    {
        static void Prefix(out long __state) => __state = Stopwatch.GetTimestamp();
        static void Postfix(long __state)
        {
            if (!ProfilerManager.Enabled) return;
            Interlocked.Add(ref ProfilerManager.ContaminationCpuNs, ProfilerManager.TimestampToNs(__state));
        }
    }

    /// <summary>
    /// Applies contamination diffusion results computed by SimulateContaminationTask.
    /// </summary>
    [HarmonyPatch("Timberborn.WaterSystem.UpdateContaminationTask", "Run")]
    internal static class UpdateContaminationTaskPatch
    {
        static void Prefix(out long __state) => __state = Stopwatch.GetTimestamp();
        static void Postfix(long __state)
        {
            if (!ProfilerManager.Enabled) return;
            Interlocked.Add(ref ProfilerManager.UpdateContaminationCpuNs, ProfilerManager.TimestampToNs(__state));
        }
    }

    // ─────────────────────────────────────────────────────────────────────────────
    // Single tasks (IParallelizerSingleTask) — Run(), called once per tick
    // on a worker thread. No loop — single invocation per tick.
    // ─────────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Zeroes the contamination buffer and diffusion counters before each sim step.
    /// Should be very fast; if not, memory bandwidth is the bottleneck.
    /// </summary>
    [HarmonyPatch("Timberborn.WaterSystem.ClearBuffersTask", "Run")]
    internal static class ClearBuffersTaskPatch
    {
        static void Prefix(out long __state) => __state = Stopwatch.GetTimestamp();
        static void Postfix(long __state)
        {
            if (!ProfilerManager.Enabled) return;
            Interlocked.Add(ref ProfilerManager.ClearBuffersNs, ProfilerManager.TimestampToNs(__state));
        }
    }

    /// <summary>
    /// Applies queued WaterChange events (mod/building water manipulation).
    /// Expected to be near-zero on maps without active water sources/drains.
    /// </summary>
    [HarmonyPatch("Timberborn.WaterSystem.UpdateWaterChangesTask", "Run")]
    internal static class UpdateWaterChangesTaskPatch
    {
        static void Prefix(out long __state) => __state = Stopwatch.GetTimestamp();
        static void Postfix(long __state)
        {
            if (!ProfilerManager.Enabled) return;
            Interlocked.Add(ref ProfilerManager.WaterChangesCpuNs, ProfilerManager.TimestampToNs(__state));
        }
    }

    /// <summary>
    /// Adds water from active water sources (springs, pumps) each tick.
    /// Cost scales with number of active sources on the map.
    /// </summary>
    [HarmonyPatch("Timberborn.WaterSystem.UpdateWaterSourcesTask", "Run")]
    internal static class UpdateWaterSourcesTaskPatch
    {
        static void Prefix(out long __state) => __state = Stopwatch.GetTimestamp();
        static void Postfix(long __state)
        {
            if (!ProfilerManager.Enabled) return;
            Interlocked.Add(ref ProfilerManager.WaterSourcesCpuNs, ProfilerManager.TimestampToNs(__state));
        }
    }

    // ─────────────────────────────────────────────────────────────────────────────
    // Soil Moisture tasks (Timberborn.SoilMoistureSystem)
    // No [HarmonyPatch] attribute — applied manually in ModEntry via AccessTools
    // so missing assemblies are handled gracefully without crashing PatchAll().
    // CPU time across all tasks is aggregated into SoilMoistureCpuNs.
    // ─────────────────────────────────────────────────────────────────────────────

    internal static class MoistureDataPreparationTaskPatch
    {
        internal static void Prefix(out long __state) => __state = Stopwatch.GetTimestamp();
        internal static void Postfix(long __state)
        {
            if (!ProfilerManager.Enabled) return;
            Interlocked.Add(ref ProfilerManager.SoilMoistureCpuNs, ProfilerManager.TimestampToNs(__state));
        }
    }

    internal static class WateredNeighborsCountingTaskPatch
    {
        internal static void Prefix(out long __state) => __state = Stopwatch.GetTimestamp();
        internal static void Postfix(long __state)
        {
            if (!ProfilerManager.Enabled) return;
            Interlocked.Add(ref ProfilerManager.SoilMoistureCpuNs, ProfilerManager.TimestampToNs(__state));
        }
    }

    internal static class ClusterSaturationCalculationTaskPatch
    {
        internal static void Prefix(out long __state) => __state = Stopwatch.GetTimestamp();
        internal static void Postfix(long __state)
        {
            if (!ProfilerManager.Enabled) return;
            Interlocked.Add(ref ProfilerManager.SoilMoistureCpuNs, ProfilerManager.TimestampToNs(__state));
        }
    }

    internal static class WaterEvaporationCalculationTaskPatch
    {
        internal static void Prefix(out long __state) => __state = Stopwatch.GetTimestamp();
        internal static void Postfix(long __state)
        {
            if (!ProfilerManager.Enabled) return;
            Interlocked.Add(ref ProfilerManager.SoilMoistureCpuNs, ProfilerManager.TimestampToNs(__state));
        }
    }

    internal static class MoistureCalculationTaskPatch
    {
        internal static void Prefix(out long __state) => __state = Stopwatch.GetTimestamp();
        internal static void Postfix(long __state)
        {
            if (!ProfilerManager.Enabled) return;
            Interlocked.Add(ref ProfilerManager.SoilMoistureCpuNs, ProfilerManager.TimestampToNs(__state));
        }
    }

    // ─────────────────────────────────────────────────────────────────────────────
    // Soil Contamination tasks (Timberborn.SoilContaminationSystem)
    // No [HarmonyPatch] attribute — applied manually in ModEntry via AccessTools.
    // CPU time across all tasks is aggregated into SoilContaminationCpuNs.
    // ─────────────────────────────────────────────────────────────────────────────

    internal static class ContaminationDataPreparationTaskPatch
    {
        internal static void Prefix(out long __state) => __state = Stopwatch.GetTimestamp();
        internal static void Postfix(long __state)
        {
            if (!ProfilerManager.Enabled) return;
            Interlocked.Add(ref ProfilerManager.SoilContaminationCpuNs, ProfilerManager.TimestampToNs(__state));
        }
    }

    internal static class ContaminationCandidatesCountingTaskPatch
    {
        internal static void Prefix(out long __state) => __state = Stopwatch.GetTimestamp();
        internal static void Postfix(long __state)
        {
            if (!ProfilerManager.Enabled) return;
            Interlocked.Add(ref ProfilerManager.SoilContaminationCpuNs, ProfilerManager.TimestampToNs(__state));
        }
    }

    internal static class ContaminationsUpdateTaskPatch
    {
        internal static void Prefix(out long __state) => __state = Stopwatch.GetTimestamp();
        internal static void Postfix(long __state)
        {
            if (!ProfilerManager.Enabled) return;
            Interlocked.Add(ref ProfilerManager.SoilContaminationCpuNs, ProfilerManager.TimestampToNs(__state));
        }
    }
}
