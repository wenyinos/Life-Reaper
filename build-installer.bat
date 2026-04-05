@echo off
chcp 65001 >nul
echo ========================================
echo  续命 Life Reaper - 安装包构建脚本
echo ========================================
echo.

echo [1/3] 清理旧的发布文件...
if exist "publish" rmdir /s /q "publish"
if exist "installer\output" rmdir /s /q "installer\output"
echo 完成!
echo.

echo [2/3] 发布自包含应用程序...
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -p:PublishReadyToRun=true --output publish
if errorlevel 1 (
    echo 发布失败!
    pause
    exit /b 1
)
echo 完成!
echo.

echo [3/3] 检查 Inno Setup...
set "ISCC_PATH="
if exist "C:\Program Files (x86)\Inno Setup 6\ISCC.exe" (
    set "ISCC_PATH=C:\Program Files (x86)\Inno Setup 6\ISCC.exe"
) else if exist "C:\Program Files\Inno Setup 6\ISCC.exe" (
    set "ISCC_PATH=C:\Program Files\Inno Setup 6\ISCC.exe"
) else (
    echo 未找到 Inno Setup 6!
    echo.
    echo 请从以下地址下载并安装 Inno Setup 6:
    echo https://jrsoftware.org/isdl.php
    echo.
    echo 安装后重新运行此脚本。
    echo.
    echo 或者，你可以直接使用 publish 文件夹中的 Life Reaper.exe 作为便携版运行。
    echo.
    pause
    exit /b 1
)

echo 找到 Inno Setup: %ISCC_PATH%
echo.
echo 开始构建安装包...
"%ISCC_PATH%" "installer\setup.iss"
if errorlevel 1 (
    echo 安装包构建失败!
    pause
    exit /b 1
)
echo.
echo ========================================
echo  安装包构建成功!
echo  输出位置: installer\LifeReaper-Setup.exe
echo ========================================
echo.
pause
