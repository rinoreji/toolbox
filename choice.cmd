@ECHO OFF
CLS

:MENU
SET NOMENU=0
ECHO.
ECHO 1. Fetch EOS
ECHO 2. Fetch EOS-DB
ECHO 3. Fetch EOS and DB
ECHO 4. Quit
ECHO.

CHOICE /C 1234 /M "Enter your choice: "

:: Note - list ERRORLEVELS in decreasing order
IF ERRORLEVEL 4 GOTO QUIT
IF ERRORLEVEL 3 GOTO BOTH
IF ERRORLEVEL 2 GOTO EOS_DB
IF ERRORLEVEL 1 GOTO EOS

:EOS
ECHO.
ECHO Fetching EOS...
pushd "C:\RRc\SC\EOS"
git fetch && git diff --name-only @ @{u}
IF %NOMENU% NEQ 1 GOTO MENU


:EOS_DB
ECHO.
ECHO Fetching EOS-DB...
pushd "C:\RRc\SC\EOS-DB"
git fetch && git diff --name-only @ @{u}
GOTO MENU

:BOTH
SET NOMENU=1
GOTO EOS
GOTO EOS_DB

GOTO MENU

:QUIT
exit
