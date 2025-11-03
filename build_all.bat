@echo off
setlocal
color 0A

echo ============================================
echo COMPILACION COMPLETA MULTIPLE - VISUAL 2019
echo ============================================

set "MSBUILD_PATH=D:\VS2019\MSBuild\Current\Bin\MSBuild.exe"
set "root=%~dp0"
cd /d "%root%"
if not exist "logs" mkdir logs

for /L %%i in (1,1,4) do (
    echo.
    echo ============================================
    echo CICLO %%i DE COMPILACION PRINCIPAL
    echo ============================================

    call :CompilarModulo REPORTEADOR
    call :CompilarModulo SEGURIDAD
    call :CompilarModulo NAVEGADOR
)

goto :verificar


:CompilarModulo
echo ============================================
echo COMPILANDO MODULO: %1
echo ============================================

if /I "%1"=="REPORTEADOR" (
    "%MSBUILD_PATH%" "codigo\componentes\reporteador\reporteador\Capa_Modelo_Reporteador\Capa_Modelo_Reporteador.csproj" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
    "%MSBUILD_PATH%" "codigo\componentes\reporteador\reporteador\Capa_Controlador_Reporteador\Capa_Controlador_Reporteador.csproj" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
    "%MSBUILD_PATH%" "codigo\componentes\reporteador\reporteador\Capa_Vista_Reporteador\Capa_Vista_Reporteador.csproj" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
)

if /I "%1"=="SEGURIDAD" (
    "%MSBUILD_PATH%" "codigo\componentes\seguridad\SeguridadMVC\SeguridadMVC\CapaModelo\Capa_Modelo_Seguridad.csproj" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
    "%MSBUILD_PATH%" "codigo\componentes\seguridad\SeguridadMVC\SeguridadMVC\CapaControlador\Capa_Controlador_Seguridad.csproj" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
    "%MSBUILD_PATH%" "codigo\componentes\seguridad\SeguridadMVC\SeguridadMVC\CapaVista\Capa_Vista_Seguridad.csproj" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
)

if /I "%1"=="NAVEGADOR" (
    "%MSBUILD_PATH%" "codigo\componentes\navegador\NavegadorMVC\CapaModeloNavegador\Capa_Modelo_Navegador.csproj" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
    "%MSBUILD_PATH%" "codigo\componentes\navegador\NavegadorMVC\CapaControladorNavegador\Capa_Controlador_Navegador.csproj" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
    "%MSBUILD_PATH%" "codigo\componentes\navegador\NavegadorMVC\CapaVistaNavegador\Capa_Vista_Navegador.csproj" /t:Rebuild /p:Configuration=Debug >> logs\build_log.txt 2>&1
)
goto :eof


:verificar
echo.
echo ============================================
echo VERIFICANDO DLLs GENERADAS
echo ============================================

set "dlls="
set "dlls=%dlls% codigo\componentes\navegador\NavegadorMVC\CapaModeloNavegador\bin\Debug\Capa_Modelo_Navegador.dll"
set "dlls=%dlls% codigo\componentes\navegador\NavegadorMVC\CapaControladorNavegador\bin\Debug\Capa_Controlador_Navegador.dll"
set "dlls=%dlls% codigo\componentes\navegador\NavegadorMVC\CapaVistaNavegador\bin\Debug\Capa_Vista_Navegador.dll"
set "dlls=%dlls% codigo\componentes\reporteador\reporteador\Capa_Modelo_Reporteador\bin\Debug\Capa_Modelo_Reporteador.dll"
set "dlls=%dlls% codigo\componentes\reporteador\reporteador\Capa_Controlador_Reporteador\bin\Debug\Capa_Controlador_Reporteador.dll"
set "dlls=%dlls% codigo\componentes\reporteador\reporteador\Capa_Vista_Reporteador\bin\Debug\Capa_Vista_Reporteador.dll"
set "dlls=%dlls% codigo\componentes\seguridad\SeguridadMVC\SeguridadMVC\CapaModelo\bin\Debug\Capa_Modelo_Seguridad.dll"
set "dlls=%dlls% codigo\componentes\seguridad\SeguridadMVC\SeguridadMVC\CapaControlador\bin\Debug\Capa_Controlador_Seguridad.dll"
set "dlls=%dlls% codigo\componentes\seguridad\SeguridadMVC\SeguridadMVC\CapaVista\bin\Debug\Capa_Vista_Seguridad.dll"

for %%d in (%dlls%) do (
    if exist "%%d" (
        echo [OK] %%d
    ) else (
        echo [FALTA] %%d
    )
)

echo.
echo ============================================
echo COMPILACION FINALIZADA
echo Revisar logs\build_log.txt para mas detalles.
echo ============================================
pause
