cd /d "%~dp0"
pushd ..\..\

git pull
if not %errorlevel% == 0 (
    pause
    echo Git pull error.
    exit /b 1
)

popd

python.exe .\ConfigMkDocs.py
