# Life Reaper - Agent Guidelines

## Quick Start

**Run app**: `dotnet run` (Windows Forms app)
**Build portable**: `dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true --output publish`
**Build installer**: `.\build-installer.bat` (requires Inno Setup 6)

## Critical Architecture Notes

- **Entry point**: `Program.cs:14` → `Application.Run(new Form1())`
- **Main logic**: `Form1.cs` contains all countdown, UI, and drag behavior
- **UI components**: All controls created programmatically (no designer usage)
- **Custom dialogs**: `CustomMessageBox.cs`, `WarningForm.cs` - both draggable, red-themed

## Key Implementation Details

- **9:59 countdown**: Starts immediately on form load, stops at zero showing warning message
- **Window shaking**: Every 59 seconds during countdown (async shake animation)
- **Font emphasis**: Increases font size and changes color during shake periods
- **Drag behavior**: Only from title bar panels (`panelTitleBar`, `lblTitle`)
- **Close prevention**: Standard close buttons show `WarningForm` instead of closing
- **Always-on-top**: Both main form and dialogs set `TopMost = true`

## Build & Deployment Quirks

- **Self-contained**: Must target `win-x64` for single-file deployment
- **Inno Setup path**: Script checks both `Program Files (x86)` and `Program Files`
- **CI/CD**: Automated builds on `main` branch pushes, releases only on version tags
- **No tests**: Project has no test framework - avoid adding unless explicitly requested

## Style Conventions

- **Null safety**: Enabled (`<Nullable>enable</Nullable>`)
- **Naming**: PascalCase for public members, camelCase for private fields
- **Braces**: New line for all blocks
- **Resources**: All UI created in code, no designer files used
- **Disposal**: Proper cleanup in `OnFormClosed` with null checks

## Important Gotchas

- **Font disposal**: `countdownNormalFont`/`countdownEmphasizeFont` must be disposed
- **Shake cancellation**: `shakeCts` cancels ongoing animations during drag operations
- **Async operations**: `EmphasizeCountdown()` uses async `ShakeWindow()` method
- **Memory leaks**: Ensure timer and font resources are properly disposed

## Release Process

1. Update version in `installer/setup.iss` 
2. Create tag: `git tag vX.Y.Z`
3. Push tag: `git push origin vX.Y.Z`
4. CI auto-releases portable + installer to GitHub Releases
