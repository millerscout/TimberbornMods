param(
    [Parameter(Mandatory)][string]$Vdf,
    [string]$User = "millerscout"
)

Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

if (-not (Test-Path $Vdf)) {
    Write-Error "metadata.vdf not found: $Vdf"
    exit 1
}

$vdfAbs  = [System.IO.Path]::GetFullPath($Vdf)
$pass    = Read-Host -AsSecureString "Steam password ($User)"
$passPlain = [System.Runtime.InteropServices.Marshal]::PtrToStringAuto(
               [System.Runtime.InteropServices.Marshal]::SecureStringToCoTaskMemUnicode($pass))

steamcmd +login $User $passPlain +workshop_build_item $vdfAbs +quit
