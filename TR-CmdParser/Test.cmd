@echo off

rem Author  Martin Dubois, P.Eng.
rem License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
rem Product C-Sharp
rem File    TR-CmdParser/Test.cmd

echo Executing  TR-CmdParser/Test.cmd %1  ...

rem ===== Initialisation ====================================================

set COMPONENT_FOLDER=TR-CmdParser

set BASE_TXT="%COMPONENT_FOLDER%\Tests\Base.txt"

set BASE_OUTPUT_TXT="%COMPONENT_FOLDER%\Tests\Base_Output.txt"

set OUTPUT_TXT="TestOutput.txt"

set TR_CMD_PARSER_EXE="%COMPONENT_FOLDER%\bin\%1\TR_CmdParser.Exe"

rem ===== Verification ======================================================

if ""=="%1" (
    echo USER ERROR  Invalid command line
    echo Usage  TR-CmdParser/Test.cmd {Debug|Release}
    pause
    exit /B 10
)

if not exist %TR_CMD_PARSER_EXE% (
    echo FATAL ERROR  %TR_CMD_PARSER_EXE%  does not exist
    echo Compile the project
    pause
    exit /B 20
)

rem ===== Execution =========================================================

%TR_CMD_PARSER_EXE% < %BASE_TXT% > %OUTPUT_TXT%
if ERRORLEVEL 1 (
    echo ERROR  %TR_CMD_PARSER_EXE% < %BASE_TXT% > %OUTPUT_TXT%d  failed - %ERRORLEVEL%
    pause
    exit /B 30
)

fc %BASE_OUTPUT_TXT% %OUTPUT_TXT%
if ERRORLEVEL 1 (
    echo ERROR  fc %BASE_OUTPUT_TXT% %OUTPUT_TXT%  failed - %ERRORLEVEL%
    pause
    exit /B 40
)

rem ===== End ===============================================================

echo OK
