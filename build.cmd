@set msbuild="%ProgramFiles%\msbuild\14.0\Bin\MSBuild.exe"
@if not exist %msbuild% @set msbuild="%ProgramFiles%\MSBuild\14.0\Bin\MSBuild.exe"
@if not exist %msbuild% @set msbuild="%ProgramFiles(x86)%\MSBuild\12.0\Bin\MSBuild.exe"
@if not exist %msbuild% @set msbuild="%ProgramFiles%\MSBuild\12.0\Bin\MSBuild.exe"

@REM linq2db.sln
nuget restore linq2db.4.5.sln
@REM cd src\
@REM dotnet restore
@REM cd ..\

%msbuild% linq2db.4.5.sln /v:m /m

@PAUSE