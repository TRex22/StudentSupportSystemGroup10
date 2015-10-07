@echo off
echo This will delete all bin and obj folders
echo Beware!!
echo
echo First MSBUILD CLEAN will be activated.
pause
"C:\Program Files (x86)\MSBuild\14.0\Bin\msbuild.exe" /t:clean
echo not implemented yet
pause
for /d /r . %%d in (bin,obj) do @if exist "%%d" rd /s/q "%%d"
