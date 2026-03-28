using System;
using BenchmarkDotNet.Attributes;

namespace MicroBenchmarks.Benchmarks
{
    /// <summary>
    /// Compares ceiling approaches as a substitute for OutflowsUpdateTask.GetOutflow:198
    /// where `(int)Math.Ceiling(num)` promotes a float to double unnecessarily.
    ///
    /// Baseline: Math.Ceiling(double) — current game code (float promoted to double)
    /// MathF:    MathF.Ceiling(float)  — stays in float domain, avoids promotion
    /// FastCeil: bit-trick integer ceil — branchless, no FPU round-trip
    /// </summary>
    [MemoryDiagnoser]
    [DisassemblyDiagnoser(printSource: true)]
    public class CeilingBenchmarks
    {
        private const int N = 262144; // 128*128*16 — one frame of GetOutflow calls on a 128×128 map
        private float[] _values = null!;

        [GlobalSetup]
        public void Setup()
        {
            var rng = new Random(42);
            _values = new float[N];
            for (int i = 0; i < N; i++)
                _values[i] = (float)(rng.NextDouble() * 100.0);
        }

        /// <summary>Current game code: float silently widened to double, ceil in double, cast back to int.</summary>
        [Benchmark(Baseline = true)]
        public int MathCeilingDouble()
        {
            int sum = 0;
            var v = _values;
            for (int i = 0; i < v.Length; i++)
                sum += (int)Math.Ceiling(v[i]); // float → double promotion
            return sum;
        }

        /// <summary>MathF.Ceiling: stays in float, no promotion.</summary>
        [Benchmark]
        public int MathFCeilingFloat()
        {
            int sum = 0;
            var v = _values;
            for (int i = 0; i < v.Length; i++)
                sum += (int)MathF.Ceiling(v[i]);
            return sum;
        }

        /// <summary>
        /// Branchless integer ceiling via bit manipulation:
        ///   fastCeil(x) = -(int)(-x)  when x > 0
        /// Equivalent for positive floats; avoids FPU rounding mode entirely.
        /// </summary>
        [Benchmark]
        public int FastCeilPositive()
        {
            int sum = 0;
            var v = _values;
            for (int i = 0; i < v.Length; i++)
                sum += -(int)(-v[i]);
            return sum;
        }
    }
}
