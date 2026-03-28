SHELL      := pwsh.exe
.SHELLFLAGS := -NoProfile -Command

STEAM_USER ?= millerscout

PROJ       = src/Re-Evaporation.ModCode.csproj
SCRIPTS_DIR = Scripts
DIST_DIR   = dist/Scripts
VDF_REL    = dist/metadata.vdf

.PHONY: all build dist push clean

all: push

build:
	dotnet build $(PROJ) -c Release --nologo

dist: build
	New-Item -ItemType Directory -Force -Path $(DIST_DIR) | Out-Null
	Get-ChildItem $(SCRIPTS_DIR) -Filter *.dll      | Copy-Item -Destination $(DIST_DIR) -Force
	Get-ChildItem $(SCRIPTS_DIR) -Filter *.pdb      | Copy-Item -Destination $(DIST_DIR) -Force
	Get-ChildItem $(SCRIPTS_DIR) -Filter *.deps.json | Copy-Item -Destination $(DIST_DIR) -Force

push: dist
	$$pass = Read-Host -AsSecureString "Steam password ($(STEAM_USER))"; $$passPlain = [System.Runtime.InteropServices.Marshal]::PtrToStringAuto([System.Runtime.InteropServices.Marshal]::SecureStringToCoTaskMemUnicode($$pass)); $$vdfAbs = [System.IO.Path]::GetFullPath('$(VDF_REL)'); steamcmd +login $(STEAM_USER) "$$passPlain" +workshop_build_item "$$vdfAbs" +quit

clean:
	Remove-Item -Recurse -Force $(DIST_DIR) -ErrorAction SilentlyContinue
