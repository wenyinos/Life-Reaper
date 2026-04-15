# Repository Guidelines

## Project Structure & Module Organization

This repository is a Windows Forms app targeting `.NET` (`net10.0-windows`).

- Entry point: `Program.cs` (starts `Form1`).
- Main UI: `Form1.cs`, generated layout in `Form1.Designer.cs`, resources in `Form1.resx`.
- Dialogs/helpers: `WarningForm.cs`, `CustomMessageBox.cs`.
- Installer: `installer/setup.iss` (Inno Setup script), `build-installer.bat` (local packaging helper).
- CI/CD: `.github/workflows/build-and-release.yml` (build, package, tag-based release).
- Build outputs (do not commit): `bin/`, `obj/`, `publish/`, `installer/output/`.

## Build, Test, and Development Commands

Run locally on Windows with the .NET SDK installed:

```powershell
dotnet restore
dotnet run
dotnet build -c Release
dotnet publish -c Release -r win-x64 --self-contained true --output publish `
  -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -p:PublishReadyToRun=true
```

Build an installer (requires Inno Setup 6):

```powershell
.\build-installer.bat
# or: & "C:\Program Files (x86)\Inno Setup 6\ISCC.exe" "installer\setup.iss"
```

## Coding Style & Naming Conventions

- Indentation: 4 spaces; C# braces on new lines (match existing files).
- Nullability: keep `Nullable` annotations (`object? sender`) and address warnings instead of suppressing.
- Naming: `PascalCase` for types/methods; `camelCase` for private fields; keep WinForms control prefixes (`lblX`, `btnX`, `panelX`) consistent with the designer.
- Avoid manual edits to `Form1.Designer.cs` unless necessary; prefer the WinForms designer to prevent drift.

## Testing Guidelines

There is no dedicated test project currently; CI runs `dotnet test` but continues if none exist.
If adding tests, create a `tests/` folder and a `*.Tests` project (xUnit/MSTest), and keep test names readable (e.g., `TimerCountdown_Tick_StopsAtZero`).

## Commit & Pull Request Guidelines

- Commit messages follow a Conventional Commits-like pattern: `feat(ui): ...`, `fix(ci): ...`, `docs: ...`, `chore(workflow): ...`, `refactor(...): ...`.
- PRs should include: a short description, linked issue (if any), and screenshots/GIFs for UI changes.
- Releases: update `AppVersion` in `installer/setup.iss` when shipping, and tag `vX.Y.Z` to trigger the GitHub Actions release workflow.
