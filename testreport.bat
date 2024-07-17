@echo off
rd /s /q .coverage
mkdir .coverage

dotnet test --collect:"XPlat Code Coverage" --results-directory .\.coverage

set folderPath=.\.coverage

set newFolderName=report

for /d %%i in ("%folderPath%\*") do (
    if exist "%%i" (
        echo Renaming "%%i" to "%folderPath%\%newFolderName%"
        ren "%%i" "%newFolderName%"
        goto end
    )
)

:end

ReportGenerator -reports:.\.coverage\report\coverage.cobertura.xml -targetdir:.coverage\html-coverage-report -reporttypes:Html

python -m http.server 8000 -d .coverage/html-coverage-report

endlocal
