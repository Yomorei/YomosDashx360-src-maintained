# DashX360 Decompiled Source By Yomorei

Recovered, buildable source reconstruction of DashX360 / Xbox Metro Launcher based on the DashX360 V1.1 release assembly.

## Status?? 

- Tested - Builds successfully.
- Tested - Launches successfully.
- Runtime target: .NET 8 Windows / WPF.
- Note: decompiled/recovered source, **not original clean source** since the OG Creator is a weird person.
- Current UI resources are recovered `.baml` resources. I would suggest not deleting them unless they are replaced with reconstructed `.xaml` files.

## Attribution / Notice

Original project, original branding, original assets, and original code ownership remain with their respective original authors and rights holders.

This repository does not claim original authorship of DashX360 or Xbox Metro Launcher. The purpose of this recovery is maintenance, auditing, preservation, and future development from a buildable source tree.

New modifications made in this repository are licensed under GPL-3.0-or-later unless a file explicitly states otherwise.

Third-party dependencies, bundled media, images, icons, sounds, videos, fonts, and other assets remain under their original licenses or ownership. 

## Build

Run from the repository root:

```powershell
dotnet restore
dotnet build -c Release
```

## Publish

This publishes a local framework-dependent Windows x64 build into `artifacts/publish`.

```powershell
dotnet publish -c Release -r win-x64 --self-contained false -o ".\artifacts\publish"
Copy-Item -Recurse -Force ".\Assets" ".\artifacts\publish\Assets"
Copy-Item -Recurse -Force ".\UserData" ".\artifacts\publish\UserData"
```

## Run published build

```powershell
Start-Process ".\artifacts\publish\XboxMetroLauncher.exe"
```