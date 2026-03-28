# TimberbornProfiler

Harmony mod for Timberborn that writes per-tick timing data to a CSV file. Used to identify hot code paths and measure before/after impact of optimization patches.

## Installation

Copy the contents of `dist/` into a folder named `TimberbornProfiler` inside your Timberborn Mods directory.

**Required dependencies (from Steam Workshop):**
- [Harmony](https://steamcommunity.com/sharedfiles/filedetails/?id=3284904751)
- [eMka.ModSettings](https://steamcommunity.com/sharedfiles/filedetails/?id=3283831040)

## Building

```
cd Benchmarks
make profiler
```

Output: `dist/Scripts/TimberbornProfiler.dll`

## Usage

1. Install the mod
2. In-game → Mod Settings → TimberbornProfiler → **Enable Profiling** = on
3. Play at speed 5 on a water-heavy map
4. CSV is written to `%APPDATA%\..\LocalLow\Mechanistry\Timberborn\profiler_YYYYMMDD_HHmmss_fff.csv`

Settings are live — toggling Enable Profiling opens/closes the file without restarting.

## CSV columns

| Column | Description |
|---|---|
| `Tick` | Game tick number |
| `TickAllMs` | Total wall time for `TickableSingletonService.TickAll()` |
| `ParallelWallMs` | Time main thread spent blocked in `Parallelizer.Wait()` |
| `OutflowsCpuMs` | Summed CPU time across all worker threads for `OutflowsUpdateTask` |
| `WaterParamsCpuMs` | Summed CPU time for `WaterParametersUpdateTask` |
| `SimContaminationCpuMs` | Summed CPU time for `SimulateContaminationTask` |
| `UpdContaminationCpuMs` | Summed CPU time for `UpdateContaminationTask` |
| `WaterChangesCpuMs` | Summed CPU time for `UpdateWaterChangesTask` |
| `WaterSourcesCpuMs` | Summed CPU time for `UpdateWaterSourcesTask` |
| `ClearBuffersMs` | Summed CPU time for `ClearBuffersTask` |
| `PathFollowerMs` | Time for `PathFollower.MoveAlongPath` (main thread, summed across all beavers) |
| `GCGen0` | GC Gen0 collections this tick |
| `GCGen1` | GC Gen1 collections this tick |

**Note:** CPU columns (OutflowsCpuMs etc.) are summed across all worker threads, so they can exceed TickAllMs. On a 6-core machine, 10ms wall time × 6 workers = 60ms CPU time.

**Even/odd tick pattern:** Water sim tasks run on alternating ticks. Odd ticks show CPU data; even ticks are all zeros. This is expected — `StartParallelTick` queues work and `FinishParallelTick` collects results on the next tick.

## Interpreting results

- `TickAllMs - ParallelWallMs` ≈ main-thread-only work per tick
- `GCGen1 > 0` in a tick means a full Gen1 collection occurred — expect that tick's `TickAllMs` to be 100–1200ms
- `PathFollowerMs` grows with beaver population; near-zero early game is normal

## Mod settings

| Setting | Default | Description |
|---|---|---|
| Enable Profiling | off | Write CSV. Zero overhead when off. |
| Flush Interval (ticks) | 200 | How often to flush to disk. Lower = more responsive, higher = less I/O. |
| Print Summary to Log | on | Also print a one-liner to Player.log every flush interval. |
