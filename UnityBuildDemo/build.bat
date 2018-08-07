rem echo off
SET APPLICATION_NAME=mySwingPro
if not "%1" == "" (
set APPLICATION_NAME=%1
)
echo %APPLICATION_NAME%
REM unity location
set UNITY=D:\Program Files\Unity5_3_1f1\Editor\Unity.exe

REM unity build script in assets
set BUILD_CMD=CommandBuild.BuildWindowsStandalone

REM project path
set PROJECT_PATH=%~dp0

REM log file
set LOG=RunUnity.log

REM output
set UNITY_OUTPUT=D:\OUTPUT\%APPLICATION_NAME%.exe

"%UNITY%"  -quit -batchmode -executeMethod %BUILD_CMD% -buildTarget win32 -projectPath "%PROJECT_PATH%" -logFile %LOG% -buildWindowsPlayer  "%UNITY_OUTPUT%"

exit