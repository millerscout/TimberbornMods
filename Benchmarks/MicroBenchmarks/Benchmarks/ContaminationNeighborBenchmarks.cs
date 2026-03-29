using System;
using BenchmarkDotNet.Attributes;

namespace MicroBenchmarks.Benchmarks
{
    /// <summary>
    /// Validates the ContaminationNeighborEarlyExitPatch optimization.
    ///
    /// Target: ContaminationCandidatesCountingTask.GetContaminationFromNeighbor (5-param outer overload).
    /// Called 8× per terrain cell per tick (4 cardinal + 4 diagonal neighbors).
    ///
    /// Call count estimate: 128×128 map × ~2 terrain layers × 8 neighbors = ~262k calls/frame.
    /// Using N = 393216 (same as SoilMoistureCeilingBenchmarks) to match existing benchmark scale.
    ///
    /// The early-exit condition:
    ///   if (candidates[i] <= currentContamination + cost) skip the inner computation
    ///
    /// This is provably correct because the inner overload returns at most candidates[i] - cost,
    /// so if candidates[i] - cost <= currentContamination the result cannot improve currentContamination.
    ///
    /// Three scenarios model different contamination levels:
    ///   AllZero  — clean map (most common): skip fires 100% of the time
    ///   Random   — mid-game partial contamination: skip fires ~50% of the time
    ///   AllMax   — fully contaminated map: skip rarely fires (worst case for this optimization)
    /// </summary>
    [MemoryDiagnoser]
    [DisassemblyDiagnoser(printSource: true)]
    public class ContaminationNeighborBenchmarks
    {
        private const int N = 393216; // 128*128*2*8 — one frame worth of neighbor calls (rounded up to match SoilMoistureCeilingBenchmarks)

        // Simulated _lastTickContaminationCandidates values for neighbors
        private float[] _candidates = null!;

        // Simulated terrain structure: height difference between origin and neighbor (0 = same level)
        private int[] _heightDiffs = null!;

        private const float Cost = 0.1f;              // typical _regularSpreadCost
        private const float VerticalCostMod = 0.05f;  // typical _verticalCostModifier

        public enum Scenario { AllZero, Random, AllMax }

        [Params(Scenario.AllZero, Scenario.Random, Scenario.AllMax)]
        public Scenario ContaminationLevel { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            var rng = new Random(42);
            _candidates = new float[N];
            _heightDiffs = new int[N];

            for (int i = 0; i < N; i++)
            {
                _candidates[i] = ContaminationLevel switch
                {
                    Scenario.AllZero => 0f,
                    Scenario.Random  => (float)rng.NextDouble(),
                    Scenario.AllMax  => 1f,
                    _                => 0f
                };
                _heightDiffs[i] = rng.Next(0, 4); // 0–3 height difference, models typical terrain variation
            }
        }

        /// <summary>
        /// Baseline: always evaluate the full inner computation.
        /// Models the unpatched GetContaminationFromNeighbor inner call for every terrain layer.
        /// </summary>
        [Benchmark(Baseline = true)]
        public float NoEarlyExit()
        {
            var candidates = _candidates;
            var heightDiffs = _heightDiffs;
            float currentContamination = 0f;

            for (int i = 0; i < N; i++)
            {
                // Inner overload logic: candidates[i] - max(0, heightDiff) * verticalCostMod - cost
                int diff = heightDiffs[i];
                float verticalPenalty = diff * VerticalCostMod;
                float result = candidates[i] - verticalPenalty - Cost;
                if (result > currentContamination)
                    currentContamination = result;
            }

            return currentContamination;
        }

        /// <summary>
        /// Optimized: skip inner computation when candidates[i] <= currentContamination + cost.
        /// Models the patched behavior — identical results, fewer computations.
        /// </summary>
        [Benchmark]
        public float WithEarlyExit()
        {
            var candidates = _candidates;
            var heightDiffs = _heightDiffs;
            float currentContamination = 0f;

            for (int i = 0; i < N; i++)
            {
                // Early-exit guard (injected by ContaminationNeighborEarlyExitPatch)
                if (candidates[i] <= currentContamination + Cost)
                    continue;

                // Inner overload logic: candidates[i] - max(0, heightDiff) * verticalCostMod - cost
                int diff = heightDiffs[i];
                float verticalPenalty = diff * VerticalCostMod;
                float result = candidates[i] - verticalPenalty - Cost;
                if (result > currentContamination)
                    currentContamination = result;
            }

            return currentContamination;
        }
    }
}
