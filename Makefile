SHELL      := pwsh.exe
.SHELLFLAGS := -NoProfile -Command

RE_EVAP_PROJ  = Re-Evaporation/src/Re-Evaporation.ModCode.csproj
PROFILER_PROJ = Benchmarks/TimberbornProfiler/src/TimberbornProfiler.csproj
PATCHES_PROJ  = Benchmarks/OptimizationPatches/src/OptimizationPatches.csproj

OUT = output

.PHONY: all re-evaporation profiler patches clean

## Build all mods and assemble output/
all: re-evaporation profiler patches

## Re-Evaporation mod
re-evaporation:
	dotnet build $(RE_EVAP_PROJ) -c Release --nologo
	pwsh -NoProfile -File scripts/package.ps1 -Target re-evaporation -Out $(OUT)

## TimberbornProfiler mod
profiler:
	dotnet build $(PROFILER_PROJ) -c Release --nologo
	pwsh -NoProfile -File scripts/package.ps1 -Target profiler -Out $(OUT)

## OptimizationPatches mod
patches:
	dotnet build $(PATCHES_PROJ) -c Release --nologo
	pwsh -NoProfile -File scripts/package.ps1 -Target patches -Out $(OUT)

## Remove output/ and all built DLLs
clean:
	pwsh -NoProfile -File scripts/package.ps1 -Target clean -Out $(OUT)
