[Setup]
AppName=续命 Life Reaper
AppVersion=1.1.0
AppPublisher=wenyinos
DefaultDirName={autopf}\LifeReaper
DefaultGroupName=续命 Life Reaper
OutputDir=output
OutputBaseFilename=LifeReaper-Setup-x86
SetupIconFile=..\favicon.ico
Compression=lzma2
SolidCompression=yes
PrivilegesRequired=admin
ArchitecturesAllowed=x86
UninstallDisplayIcon={app}\LifeReaper.exe
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "..\publish\x86\Life Reaper.exe"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\续命 Life Reaper"; Filename: "{app}\Life Reaper.exe"
Name: "{group}\{cm:UninstallProgram,续命 Life Reaper}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\续命 Life Reaper"; Filename: "{app}\Life Reaper.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\Life Reaper.exe"; Description: "{cm:LaunchProgram,续命 Life Reaper}"; Flags: nowait postinstall skipifsilent
