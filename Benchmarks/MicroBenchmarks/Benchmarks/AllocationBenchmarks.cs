using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace MicroBenchmarks.Benchmarks
{
    /// <summary>
    /// Models the WaterParametersUpdateTask.ProcessWaterDepthChanges lazy-List pattern:
    /// each row allocates a List&lt;TargetedFlow&gt; on demand, used within the row, then discarded.
    ///
    /// Strategies:
    ///   NewEachTime     — current game pattern: `new List&lt;T&gt;()` per invocation, GC pressure
    ///   ThreadLocalPool — reuse a [ThreadStatic] list via Clear(), zero allocations
    ///   StackSpan       — stackalloc Span&lt;T&gt; (only valid for unmanaged structs)
    /// </summary>
    [MemoryDiagnoser]
    public class AllocationBenchmarks
    {
        private const int Rows = 128;
        private const int MaxFlowsPerRow = 4; // up to 4 neighbours per cell, 128 cells wide

        [ThreadStatic]
        private static List<TargetedFlow>? _pooledList;

        /// <summary>Current game pattern: allocate a fresh List per row.</summary>
        [Benchmark(Baseline = true)]
        public int NewListEachRow()
        {
            int total = 0;
            for (int row = 0; row < Rows; row++)
            {
                var list = new List<TargetedFlow>(MaxFlowsPerRow);
                FillFlows(list, row);
                total += ConsumeFlows(list);
            }
            return total;
        }

        /// <summary>Reuse a thread-local List, clear it each row. Zero allocations after warm-up.</summary>
        [Benchmark]
        public int ThreadLocalPooledList()
        {
            int total = 0;
            for (int row = 0; row < Rows; row++)
            {
                _pooledList ??= new List<TargetedFlow>(MaxFlowsPerRow);
                _pooledList.Clear();
                FillFlows(_pooledList, row);
                total += ConsumeFlows(_pooledList);
            }
            return total;
        }

        /// <summary>stackalloc Span — stays on stack, zero GC, zero heap. Only works for unmanaged structs.</summary>
        [Benchmark]
        public int StackAllocSpan()
        {
            int total = 0;
            for (int row = 0; row < Rows; row++)
            {
                Span<TargetedFlow> flows = stackalloc TargetedFlow[MaxFlowsPerRow];
                int count = FillFlowsSpan(flows, row);
                total += ConsumeFlowsSpan(flows, count);
            }
            return total;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void FillFlows(List<TargetedFlow> list, int row)
        {
            for (int i = 0; i < MaxFlowsPerRow; i++)
                list.Add(new TargetedFlow(row * MaxFlowsPerRow + i, 0.5f));
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static int FillFlowsSpan(Span<TargetedFlow> span, int row)
        {
            for (int i = 0; i < MaxFlowsPerRow; i++)
                span[i] = new TargetedFlow(row * MaxFlowsPerRow + i, 0.5f);
            return MaxFlowsPerRow;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static int ConsumeFlows(List<TargetedFlow> list)
        {
            int sum = 0;
            foreach (var f in list) sum += f.TargetIndex;
            return sum;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static int ConsumeFlowsSpan(Span<TargetedFlow> span, int count)
        {
            int sum = 0;
            for (int i = 0; i < count; i++) sum += span[i].TargetIndex;
            return sum;
        }

        /// <summary>Minimal stand-in for Timberborn's TargetedFlow struct (unmanaged).</summary>
        public readonly struct TargetedFlow
        {
            public readonly int TargetIndex;
            public readonly float Amount;
            public TargetedFlow(int targetIndex, float amount) { TargetIndex = targetIndex; Amount = amount; }
        }
    }
}
