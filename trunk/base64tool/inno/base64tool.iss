; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{411A7BF2-0AE1-4C42-842D-4172174F5CC0}
AppName=base64tool
AppVersion=1.0
;AppVerName=base64tool 1.0
AppPublisher=JPSIII
AppPublisherURL=http://base64tool.googlecode.com/
AppSupportURL=http://base64tool.googlecode.com/
AppUpdatesURL=http://base64tool.googlecode.com/
DefaultDirName={pf}\base64tool
DefaultGroupName=base64tool
AllowNoIcons=yes
LicenseFile=C:\Users\Joe\Documents\Visual Studio 2010\Projects\base64tool\base64tool\License.txt
OutputDir=C:\Users\Joe\Documents\Visual Studio 2010\Projects\base64tool\base64tool\inno
OutputBaseFilename=base64tool_setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "C:\Users\Joe\Documents\Visual Studio 2010\Projects\base64tool\base64tool\bin\Release\base64tool.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Joe\Documents\Visual Studio 2010\Projects\base64tool\base64tool\License.txt"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\base64tool"; Filename: "{app}\base64tool.exe"
Name: "{group}\{cm:ProgramOnTheWeb,base64tool}"; Filename: "http://base64tool.googlecode.com/"
Name: "{group}\{cm:UninstallProgram,base64tool}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\base64tool"; Filename: "{app}\base64tool.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\base64tool"; Filename: "{app}\base64tool.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\base64tool.exe"; Description: "{cm:LaunchProgram,base64tool}"; Flags: nowait postinstall skipifsilent

