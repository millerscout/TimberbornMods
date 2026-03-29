SHELL      := pwsh.exe
.SHELLFLAGS := -NoProfile -Command

STEAM_USER ?= millerscout

RE_EVAP_PROJ  = Re-Evaporation/src/Re-Evaporation.ModCode.csproj
PROFILER_PROJ = Benchmarks/TimberbornProfiler/src/TimberbornProfiler.csproj
PATCHES_PROJ  = Benchmarks/OptimizationPatches/src/OptimizationPatches.csproj

OUT = output

.PHONY: all clean \
        re-evaporation re-evaporation-build re-evaporation-push \
        profiler       profiler-build       profiler-push \
        patches        patches-build        patches-push

## Build and package all mods
all: re-evaporation profiler patches

# ── Re-Evaporation ────────────────────────────────────────────────────────────

## Compile only
re-evaporation-build:
	dotnet build $(RE_EVAP_PROJ) -c Release --nologo

## Compile + package into output/
re-evaporation: re-evaporation-build
	pwsh -NoProfile -File scripts/package.ps1 -Target re-evaporation -Out $(OUT)

## Compile + package + push to Steam Workshop
re-evaporation-push: re-evaporation
	pwsh -NoProfile -File scripts/push.ps1 -Vdf Re-Evaporation/dist/metadata.vdf -User $(STEAM_USER)

# ── TimberbornProfiler ────────────────────────────────────────────────────────

## Compile only
profiler-build:
	dotnet build $(PROFILER_PROJ) -c Release --nologo

## Compile + package into output/
profiler: profiler-build
	pwsh -NoProfile -File scripts/package.ps1 -Target profiler -Out $(OUT)

## Compile + package + push to Steam Workshop
profiler-push: profiler
	pwsh -NoProfile -File scripts/push.ps1 -Vdf Benchmarks/TimberbornProfiler/dist/metadata.vdf -User $(STEAM_USER)

# ── OptimizationPatches ───────────────────────────────────────────────────────

## Compile only
patches-build:
	dotnet build $(PATCHES_PROJ) -c Release --nologo

## Compile + package into output/
patches: patches-build
	pwsh -NoProfile -File scripts/package.ps1 -Target patches -Out $(OUT)

## Compile + package + push to Steam Workshop
patches-push: patches
	pwsh -NoProfile -File scripts/push.ps1 -Vdf Benchmarks/OptimizationPatches/dist/metadata.vdf -User $(STEAM_USER)

# ── Shared ────────────────────────────────────────────────────────────────────

## Remove output/ and all built DLLs
clean:
	pwsh -NoProfile -File scripts/package.ps1 -Target clean -Out $(OUT)
