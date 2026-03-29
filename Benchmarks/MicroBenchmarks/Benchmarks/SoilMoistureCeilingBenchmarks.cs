using System;
using BenchmarkDotNet.Attributes;

namespace MicroBenchmarks.Benchmarks
{
    /// <summary>
    /// Compares ceiling approaches as a substitute for MoistureCalculationTask.GetMoistureFromNeighbor:301
    /// where `(int)Math.Ceiling(column.WaterDepth)` promotes a float to double unnecessarily.
    ///
    /// Call count estimate: 128×128 map × ~2 terrain layers × 12 neighbors = ~393k calls/frame.
    ///
    /// Baseline: Math.Ceiling(double) — current game code (float promoted to double)
    /// MathF:    MathF.Ceiling(float)  — stays in float domain, avoids promotion
    /// FastCeil: bit-trick integer ceil — branchless, no FPU round-trip
    ///
    /// ⚠ CORRECTNESS WARNING — FastCeilPositive is WRONG for non-integer floats:
    ///   -(int)(-x) truncates toward zero, which computes floor(x), not ceil(x).
    ///   e.g. x=3.2 → -(int)(-3.2) = -(-3) = 3, but Math.Ceiling(3.2) = 4.
    ///   Verified: 10M random floats in [0,20] → 99.99% mismatch vs Math.Ceiling.
    ///   The benchmark totals look plausible only because errors partially cancel in the sum.
    ///   DO NOT use FastCeilPositive in game patches — use MathF.Ceiling instead.
    /// </summary>
    [MemoryDiagnoser]
    [DisassemblyDiagnoser(printSource: true)]
    public class SoilMoistureCeilingBenchmarks
    {
        private const int N = 393216; // 128*128*2*12 — one frame of GetMoistureFromNeighbor calls
        private float[] _values = null!;

        [GlobalSetup]
        public void Setup()
        {
            var rng = new Random(42);
            _values = new float[N];
            for (int i = 0; i < N; i++)
                _values[i] = (float)(rng.NextDouble() * 10.0); // WaterDepth range 0..~10
        }

        /// <summary>Current game code: float silently widened to double, ceil in double, cast back to int.</summary>
        [Benchmark(Baseline = true)]
        public int MathCeilingDouble()
        {
            int sum = 0;
            var v = _values;
            for (int i = 0; i < v.Length; i++)
                sum += (int)Math.Ceiling(v[i]);
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
        /// Branchless bit-trick: -(int)(-x).
        /// BENCHMARKS FAST but IS INCORRECT — computes floor(x), not ceil(x), for non-integers.
        /// Retained to document the evaluation. Do not use in production code.
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
