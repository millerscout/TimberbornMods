using System;
using BenchmarkDotNet.Attributes;

namespace MicroBenchmarks.Benchmarks
{
    /// <summary>
    /// Measures the cost of implicit float→double promotions in tight loops.
    ///
    /// Timberborn's SimulateContaminationTask.CanDiffuse contains comparisons like:
    ///   `contaminationLevel * (double)someFloat > threshold`
    /// which promote both operands to double each iteration.
    ///
    /// This benchmark isolates the promotion overhead to guide whether rewriting
    /// those comparisons to stay in float is worth the patch complexity.
    /// </summary>
    [MemoryDiagnoser]
    public class FloatDoubleBenchmarks
    {
        private const int N = 1 << 17; // 131072
        private float[] _a = null!;
        private float[] _b = null!;

        [GlobalSetup]
        public void Setup()
        {
            var rng = new Random(42);
            _a = new float[N];
            _b = new float[N];
            for (int i = 0; i < N; i++)
            {
                _a[i] = (float)rng.NextDouble();
                _b[i] = (float)rng.NextDouble();
            }
        }

        /// <summary>Pure float multiply-compare: no promotion.</summary>
        [Benchmark(Baseline = true)]
        public int FloatOnlyCompare()
        {
            int count = 0;
            var a = _a;
            var b = _b;
            for (int i = 0; i < a.Length; i++)
                if (a[i] * b[i] > 0.25f) count++;
            return count;
        }

        /// <summary>Implicit float→double promotion on every comparison (models game code).</summary>
        [Benchmark]
        public int FloatToDoublePromotion()
        {
            int count = 0;
            var a = _a;
            var b = _b;
            for (int i = 0; i < a.Length; i++)
                if (a[i] * (double)b[i] > 0.25) count++; // double comparison forces promotion
            return count;
        }

        /// <summary>Explicit double arrays: everything stays in double from the start (no per-op conversion).</summary>
        [Benchmark]
        public int PureDoubleCompare()
        {
            int count = 0;
            var a = _a;
            var b = _b;
            for (int i = 0; i < a.Length; i++)
                if ((double)a[i] * (double)b[i] > 0.25) count++;
            return count;
        }
    }
}
