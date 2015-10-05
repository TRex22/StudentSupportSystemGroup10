@echo off
echo This will delete all bin and obj folders
echo Beware!!
echo
echo First MSBUILD CLEAN will be activated.
pause
echo msbuild /t:clean
echo not implemented yet
pause
for /d /r . %%d in (bin,obj) do @if exist "%%d" rd /s/q "%%d"
