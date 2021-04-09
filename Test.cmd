@echo off

rem Author  Martin Dubois, P.Eng.
rem License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
rem Product C-Sharp
rem File    Test.cmd

echo Executing  Test.cmd  ...

rem ===== Execution =========================================================

call TR-CmdParser\Test.cmd Debug
if ERRORLEVEL 1 (
    echo ERROR  call TR-CmdParser\Test.cmd  failed - %ERRORLEVEL%
    pause
    exit /B 10
)

call TR-CmdParser\Test.cmd Release
if ERRORLEVEL 1 (
    echo ERROR  call TR-CmdParser\Test.cmd  failed - %ERRORLEVEL%
    pause
    exit /B 10
)

rem ===== End ===============================================================

echo OK
