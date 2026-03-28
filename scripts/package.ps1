param(
    [Parameter(Mandatory)][ValidateSet("re-evaporation","profiler","patches","clean")]
    [string]$Target,
    [string]$Out = "output"
)

Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

function Copy-Mod([string]$dest, [scriptblock]$action) {
    New-Item -ItemType Directory -Force -Path $dest | Out-Null
    & $action
    Write-Host "  => $dest" -ForegroundColor Green
}

switch ($Target) {
    "re-evaporation" {
        Copy-Mod "$Out/Re-Evaporation" {
            New-Item -ItemType Directory -Force -Path "$Out/Re-Evaporation/Scripts" | Out-Null
            Copy-Item Re-Evaporation/dist/manifest.json  "$Out/Re-Evaporation/"         -Force
            Copy-Item Re-Evaporation/dist/Localizations  "$Out/Re-Evaporation/"         -Recurse -Force
            Copy-Item Re-Evaporation/dist/thumbnail.jpg  "$Out/Re-Evaporation/"         -Force
            Copy-Item Re-Evaporation/Scripts/*.dll       "$Out/Re-Evaporation/Scripts/" -Force
        }
    }
    "profiler" {
        Copy-Mod "$Out/TimberbornProfiler" {
            Copy-Item Benchmarks/TimberbornProfiler/dist/* "$Out/TimberbornProfiler/" -Recurse -Force
        }
    }
    "patches" {
        Copy-Mod "$Out/OptimizationPatches" {
            Copy-Item Benchmarks/OptimizationPatches/dist/* "$Out/OptimizationPatches/" -Recurse -Force
        }
    }
    "clean" {
        Remove-Item -Recurse -Force $Out                                            -ErrorAction SilentlyContinue
        Remove-Item -Recurse -Force Re-Evaporation/Scripts                          -ErrorAction SilentlyContinue
        Remove-Item -Recurse -Force Benchmarks/TimberbornProfiler/dist/Scripts      -ErrorAction SilentlyContinue
        Remove-Item -Recurse -Force Benchmarks/OptimizationPatches/dist/Scripts     -ErrorAction SilentlyContinue
        Write-Host "Clean done." -ForegroundColor Yellow
    }
}
