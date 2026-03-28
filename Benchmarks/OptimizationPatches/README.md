# OptimizationPatches

Performance patches for Timberborn's water simulation. All patches are always active — no settings required.

## What it does

Three Harmony patches targeting the three highest-CPU water sim methods, identified from 711 ticks of profiler CSV data:

| Patch | Target | Type | Expected gain |
|---|---|---|---|
| `OutflowsCeilingPatch` | `OutflowsUpdateTask.GetOutflow` | Transpiler | −29% OutflowsCpuMs |
| `WaterParamsListPatch` | `WaterSimulator.Load` / `Resize` | Postfix | −53% WaterParamsCpuMs, eliminates Gen1 GC |
| `ContaminationDoublePatch` | `SimulateContaminationTask.CanDiffuse` | Transpiler | −22% SimContaminationCpuMs |

## Compatibility

### Harmony patch types and conflict risk

Harmony chains multiple **Prefix** and **Postfix** patches on the same method safely — they all run in sequence. **Transpilers** are more fragile: each transpiler receives the CodeInstruction list output of the previous one. Two transpilers targeting the same method can conflict if either assumes a specific IL layout that the other has already modified.

### Per-patch compatibility

#### `OutflowsCeilingPatch` — transpiler on `OutflowsUpdateTask.GetOutflow`

**Risk: medium.** Scans for the specific IL sequence `conv.r8 → call Math.Ceiling(float64)` and replaces it. Any other transpiler on `GetOutflow` that:
- runs **before** this one and removes or moves `conv.r8`: our scan finds nothing → patch logs a warning and is a no-op (safe)
- runs **after** this one: sees the modified IL with `call MathF.Ceiling(float32)` instead — should be fine unless it explicitly matches `Math.Ceiling`

**Known conflicts:** none identified. No public Timberborn mods are known to transpile `GetOutflow`.

#### `WaterParamsListPatch` — postfix on `WaterSimulator.Load` and `WaterSimulator.Resize`

**Risk: low.** Postfixes always run and don't modify IL. Runs after the original method returns. Any other mod adding a postfix to `Load` or `Resize` coexists safely.

The only risk is a mod that **deletes or replaces** `ColumnOutflows.Outflows` lists after our postfix runs (e.g., a mod that resets the outflows array). In that case, the deleted lists won't be replaced and the original `new List<TargetedFlow>()` allocation path fires again — restoring original behavior, not causing a crash.

#### `ContaminationDoublePatch` — transpiler on `SimulateContaminationTask.CanDiffuse`

**Risk: medium.** Scans for `conv.r8` instructions near `ldfld _diffusionOutflowLimit` / `ldfld _diffusionDepthLimit`. Any other transpiler on `CanDiffuse` that:
- runs **before** and removes `conv.r8`: our scan finds nothing → warning + no-op (safe)
- runs **before** and modifies the field loads or surrounding comparisons: our lookahead scan may miss the pattern → warning + no-op (safe)
- runs **after**: sees the modified IL without `conv.r8`; if it expects the original IL shape, it may misbehave

**Known conflicts:** none identified. No public mods are known to patch `CanDiffuse`.

### Mods that patch the same general area (water sim)

| Mod | Affected methods | Compatible? |
|---|---|---|
| Re-Evaporation (this repo) | `WaterParametersUpdateTask` via `WaterParametersUpdateJob_ProcessWaterDepthChanges_Patch` | Yes — patches a different method |
| TimberbornProfiler (this repo) | `OutflowsUpdateTask.Run`, `WaterParametersUpdateTask.Run`, `SimulateContaminationTask.Run` — all Prefix+Postfix only | Yes — no transpilers, no shared target methods |
| Any mod patching `WaterSimulator.Load` | Same target as `WaterParamsListPatch` | Likely compatible — postfix ordering doesn't matter for pre-allocation |

### If you see `[OptimizationPatches] ... patch may be broken` in Player.log

The transpiler found no matching IL. This happens when:
- The game updated and changed the compiled IL layout of the target method
- Another mod's transpiler ran first and modified the IL

The patch is silently disabled in that case — no crash, no behavior change, just no speedup for that specific optimization.

## Measuring impact

Use [TimberbornProfiler](../TimberbornProfiler/) to collect before/after CSVs:

```
Before (baseline): profiler CSV from game without this mod
After:             profiler CSV from game with this mod installed
```

Compare these columns:
- `OutflowsCpuMs` — expect −29% (Priority 2)
- `WaterParamsCpuMs` — expect −5–15% (Priority 1)
- `SimContaminationCpuMs` — expect −22% (Priority 3)
- `GCGen1` — should remain 0 after Priority 1 eliminates Gen1 promotions
