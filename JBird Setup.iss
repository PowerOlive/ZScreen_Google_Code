; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "JBird"     
#define ExePath "JBird\bin\Release\JBird.exe"
#define MyAppVersion GetStringFileInfo(ExePath, "Assembly Version")
#define MyAppPublisher "ZApps Developers"
#define MyAppURL "http://code.google.com/p/zscreen"

[Setup]
AllowNoIcons=true
AppMutex=Global\0167D1A0-6054-42f5-BA2A-243648899A6B
AppId={#MyAppName}
AppName={#MyAppName}
AppPublisher={#MyAppName}
AppPublisherURL=http://code.google.com/p/zscreen
AppSupportURL=http://code.google.com/p/zscreen/issues/list
AppUpdatesURL=http://code.google.com/p/zscreen/downloads/list
AppVerName={#MyAppName} {#MyAppVersion}
AppVersion={#MyAppVersion}
ArchitecturesAllowed=x86 x64 ia64
ArchitecturesInstallIn64BitMode=x64 ia64
Compression=lzma/ultra64
CreateAppDir=true
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
DirExistsWarning=no
InfoAfterFile=ZScreenLib\Documents\license.txt
InfoBeforeFile=JBird\VersionHistory.txt
InternalCompressLevel=ultra64
LanguageDetectionMethod=uilanguage
MinVersion=4.90.3000,5.0.2195sp3
OutputBaseFilename={#MyAppName}-{#MyAppVersion}-setup
OutputDir=..\Output\
PrivilegesRequired=none
;SetupIconFile=JBird\Resources\zss-main.ico
ShowLanguageDialog=auto
ShowUndisplayableLanguages=false
SignedUninstaller=false
SolidCompression=true
Uninstallable=true
UninstallDisplayIcon={app}\{#MyAppName}.exe
UsePreviousAppDir=yes
UsePreviousGroup=yes
VersionInfoCompany={#MyAppName}
VersionInfoTextVersion={#MyAppVersion}
VersionInfoVersion={#MyAppVersion}

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: JBird\bin\Release\*.exe; Excludes: *.vshost.exe; DestDir: {app}; Flags: ignoreversion
Source: JBird\bin\Release\*.dll; DestDir: {app}; Flags: ignoreversion
Source: JBird\bin\Release\*.xml; DestDir: {app}; Flags: ignoreversion recursesubdirs
Source: ZUploader\bin\Release\*.exe; Excludes: *.vshost.exe; DestDir: {app}; Flags: ignoreversion
Source: ZUploader\bin\Release\*.dll; DestDir: {app}; Flags: ignoreversion recursesubdirs

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppName}.exe"
Name: "{group}\ZUploader"; Filename: "{app}\ZUploader.exe"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppName}.exe"; Tasks: desktopicon

[Run]
Filename: {app}\{#MyAppName}.exe.; Description: {cm:LaunchProgram,JBird}; Flags: nowait postinstall skipifsilent
Filename: {app}\ZScreen.exe.; Description: {cm:LaunchProgram,ZUploader}; Flags: nowait postinstall skipifsilent unchecked
Filename: {app}\ZUploader.exe.; Description: {cm:LaunchProgram,ZUploader}; Flags: nowait postinstall skipifsilent unchecked

