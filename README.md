# TimberbornMods

Timberborn mod development workspace. Contains released mods, benchmark tools, and performance patches.

## Repository layout

```
TimberbornMods/
  Re-Evaporation/          — Released mod: water evaporation system
  Re-ChooChoo/             — Released mod (WIP)
  Benchmarks/
    TimberbornProfiler/    — Per-tick CSV profiler mod
    OptimizationPatches/   — Water sim performance patches
    MicroBenchmarks/       — Isolated .NET benchmarks (BenchmarkDotNet)
  ReflectionData/          — Decompiled game source for reference
```

## Building benchmark mods

```
cd Benchmarks
make              # build both TimberbornProfiler and OptimizationPatches
make profiler     # build TimberbornProfiler only
make patches      # build OptimizationPatches only
make clean        # remove built DLLs
```

Built output lands in each mod's `dist/` folder — copy the whole folder into your Timberborn Mods directory.

## Game path

`D:\SteamLibrary\steamapps\common\Timberborn`

## Mod development notes

- All mods target `netstandard2.1` (Unity Mono runtime)
- Harmony patches are used for all game code instrumentation and optimization
- Reference DLLs live in `$(GameDir)\Timberborn_Data\Managed\`
- ModSettings uses the `eMka.ModSettings` workshop mod as a dependency

## Benchmark workflow

See [Benchmarks/TimberbornProfiler/README.md](Benchmarks/TimberbornProfiler/README.md) for the full profiling workflow and CSV column reference.
