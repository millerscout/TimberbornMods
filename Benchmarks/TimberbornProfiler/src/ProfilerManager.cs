using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace TimberbornProfiler
{
    public static class ProfilerManager
    {
        // ── Water sim CPU (summed across all worker threads via Interlocked) ──
        public static long OutflowsCpuNs;
        public static long WaterParamsCpuNs;
        public static long ContaminationCpuNs;
        public static long UpdateContaminationCpuNs;
        public static long WaterChangesCpuNs;
        public static long WaterSourcesCpuNs;
        public static long ClearBuffersNs;

        // ── Soil system CPU (optional — zero if assembly absent) ──
        public static long SoilMoistureCpuNs;
        public static long SoilContaminationCpuNs;

        // ── Character movement (main thread, summed across all entities) ──
        public static long PathFollowerNs;

        // ── Tick boundaries (main thread) ──
        public static long ParallelWallNs;   // how long main thread blocked in Parallelizer.Wait()
        public static long TickAllWallNs;    // total TickableSingletonService.TickAll() duration

        // ── Runtime settings (refreshed from ProfilerSettings) ──
        public static bool Enabled;
        public static int FlushIntervalTicks = 200;
        public static bool PrintSummary = true;

        private static int _gcGen0Start;
        private static int _gcGen1Start;
        private static StreamWriter? _writer;
        private static int _tickCount;
        private static string _logPath = "";

        // ── Rolling sums for log summary — accumulated on active (odd) ticks only ──
        private static double _sumTickAllMs, _sumParallelMs;
        private static double _sumOutflowsMs, _sumWaterParMs, _sumContamMs, _sumUpdContamMs;
        private static double _sumSoilMoistureMs, _sumSoilContamMs;
        private static double _sumPathFollMs;
        private static int _sumGcGen0;
        private static int _activeTicks;

        private static readonly long _ticksPerNs = Stopwatch.Frequency / 1_000_000_000L;

        public static void RefreshSettings()
        {
            ProfilerSettings? s = ProfilerSettings.Instance;
            if (s == null) return;

            bool nowEnabled = s.EnableProfiling.Value;
            FlushIntervalTicks = s.FlushIntervalTicks.Value;
            PrintSummary = s.PrintSummaryToLog.Value;

            if (nowEnabled && !Enabled)
                OpenLog();
            else if (!nowEnabled && Enabled)
                CloseLog();

            Enabled = nowEnabled;
        }

        // Called from ParallelWaitPatch.Prefix — snapshot GC before the wait
        public static void OnBeforeWait()
        {
            if (!Enabled) return;
            _gcGen0Start = GC.CollectionCount(0);
            _gcGen1Start = GC.CollectionCount(1);
        }

        // Called from TickAllPatch.Postfix — one complete tick done, write CSV row
        public static void OnTickComplete()
        {
            if (!Enabled) return;

            long outflowsNs        = Interlocked.Exchange(ref OutflowsCpuNs, 0);
            long waterParNs        = Interlocked.Exchange(ref WaterParamsCpuNs, 0);
            long contamNs          = Interlocked.Exchange(ref ContaminationCpuNs, 0);
            long updContamNs       = Interlocked.Exchange(ref UpdateContaminationCpuNs, 0);
            long changesNs         = Interlocked.Exchange(ref WaterChangesCpuNs, 0);
            long sourcesNs         = Interlocked.Exchange(ref WaterSourcesCpuNs, 0);
            long clearNs           = Interlocked.Exchange(ref ClearBuffersNs, 0);
            long soilMoistureNs    = Interlocked.Exchange(ref SoilMoistureCpuNs, 0);
            long soilContamNs      = Interlocked.Exchange(ref SoilContaminationCpuNs, 0);
            long pathFollNs        = Interlocked.Exchange(ref PathFollowerNs, 0);
            long parallelNs        = Interlocked.Exchange(ref ParallelWallNs, 0);
            long tickAllNs         = Interlocked.Exchange(ref TickAllWallNs, 0);
            int gcGen0 = GC.CollectionCount(0) - _gcGen0Start;
            int gcGen1 = GC.CollectionCount(1) - _gcGen1Start;

            _tickCount++;

            _writer?.WriteLine(string.Format(CultureInfo.InvariantCulture,
                "{0},{1:F3},{2:F3},{3:F3},{4:F3},{5:F3},{6:F3},{7:F3},{8:F3},{9:F3},{10:F3},{11},{12},{13:F3},{14:F3}",
                _tickCount,
                NsToMs(tickAllNs),
                NsToMs(parallelNs),
                NsToMs(outflowsNs),
                NsToMs(waterParNs),
                NsToMs(contamNs),
                NsToMs(updContamNs),
                NsToMs(changesNs),
                NsToMs(sourcesNs),
                NsToMs(clearNs),
                NsToMs(pathFollNs),
                gcGen0,
                gcGen1,
                NsToMs(soilMoistureNs),
                NsToMs(soilContamNs)));

            // Accumulate rolling sums on active ticks (water sim ran this tick)
            if (outflowsNs > 0 || soilMoistureNs > 0)
            {
                _sumTickAllMs     += NsToMs(tickAllNs);
                _sumParallelMs    += NsToMs(parallelNs);
                _sumOutflowsMs    += NsToMs(outflowsNs);
                _sumWaterParMs    += NsToMs(waterParNs);
                _sumContamMs      += NsToMs(contamNs);
                _sumUpdContamMs   += NsToMs(updContamNs);
                _sumSoilMoistureMs += NsToMs(soilMoistureNs);
                _sumSoilContamMs  += NsToMs(soilContamNs);
                _sumPathFollMs    += NsToMs(pathFollNs);
                _sumGcGen0        += gcGen0;
                _activeTicks++;
            }

            if (_tickCount % FlushIntervalTicks == 0)
            {
                _writer?.Flush();
                if (PrintSummary && _activeTicks > 0)
                {
                    double n = _activeTicks;
                    Debug.Log(string.Format(CultureInfo.InvariantCulture,
                        "[TimberbornProfiler] Tick {0} (avg of {1} active ticks) | " +
                        "total={2:F1}ms parallel={3:F1}ms | " +
                        "outflows={4:F1}ms waterParams={5:F1}ms simContam={6:F1}ms updContam={7:F1}ms | " +
                        "soilMoisture={8:F1}ms soilContam={9:F1}ms | " +
                        "pathFollower={10:F1}ms | GCGen0={11}",
                        _tickCount, _activeTicks,
                        _sumTickAllMs / n, _sumParallelMs / n,
                        _sumOutflowsMs / n, _sumWaterParMs / n,
                        _sumContamMs / n, _sumUpdContamMs / n,
                        _sumSoilMoistureMs / n, _sumSoilContamMs / n,
                        _sumPathFollMs / n,
                        (int)(_sumGcGen0 / n)));
                    _sumTickAllMs = _sumParallelMs = 0;
                    _sumOutflowsMs = _sumWaterParMs = _sumContamMs = _sumUpdContamMs = 0;
                    _sumSoilMoistureMs = _sumSoilContamMs = _sumPathFollMs = 0;
                    _sumGcGen0 = _activeTicks = 0;
                }
            }
        }

        // Converts raw Stopwatch ticks → nanoseconds without division-per-call
        public static long TimestampToNs(long startTimestamp)
        {
            long elapsed = Stopwatch.GetTimestamp() - startTimestamp;
            // Frequency is ticks/sec → ns = elapsed * 1e9 / Frequency
            return elapsed * 1_000_000_000L / Stopwatch.Frequency;
        }

        private static double NsToMs(long ns) => ns / 1_000_000.0;

        private static void OpenLog()
        {
            CloseLog(); // close any previously open writer before opening a new one
            string dir = Application.persistentDataPath;
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss_fff"); // ms precision = unique per call
            _logPath = Path.Combine(dir, $"profiler_{timestamp}.csv");
            _writer = new StreamWriter(
                new System.IO.FileStream(_logPath, System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite));
            _writer.WriteLine(
                "Tick,TickAllMs,ParallelWallMs," +
                "OutflowsCpuMs,WaterParamsCpuMs,SimContaminationCpuMs,UpdContaminationCpuMs," +
                "WaterChangesCpuMs,WaterSourcesCpuMs,ClearBuffersMs," +
                "PathFollowerMs,GCGen0,GCGen1," +
                "SoilMoistureCpuMs,SoilContaminationCpuMs");
            _writer.Flush();
            Debug.Log($"[TimberbornProfiler] Logging to: {_logPath}");
        }

        private static void CloseLog()
        {
            _writer?.Flush();
            _writer?.Close();
            _writer = null;
            Debug.Log($"[TimberbornProfiler] Log closed: {_logPath}");
        }
    }
}
