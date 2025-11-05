// =============================================================
// Capa_Modelo_Creacion_Nomina
// Clase: Cls_Dao_Creacion_Nomina
// Autor: Fredy Reyes Sabán
// Carné: 0901-22-9800
// Fecha: 29/10/2025
// Descripción: Acceso a datos para la tabla Tbl_Nomina
// =============================================================

using System;
using System.Data;
using System.Data.Odbc;
using System.Linq;


namespace Capa_Modelo_Creacion_Nomina
{
    public class Cls_Dao_Creacion_Nomina
    {
        // ==========================================================
        // MÉTODO: INSERTAR NÓMINA
        // ==========================================================
        public void proInsertarNomina(DateTime dPeriodoInicio, DateTime dPeriodoFin, string sTipo, string sEstado)
        {
            Cls_Conexion_Creacion_Nomina clsConexion = new Cls_Conexion_Creacion_Nomina();

            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = @"
                INSERT INTO Tbl_Nomina
                (Cmp_dPeriodoInicio_Nomina, Cmp_dPeriodoFin_Nomina, Cmp_dFechaGeneracion_Nomina, Cmp_sTipo_Nomina, Cmp_sEstado_Nomina)
                VALUES (?, ?, ?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", dPeriodoInicio);
                        cmd.Parameters.AddWithValue("", dPeriodoFin);
                        cmd.Parameters.AddWithValue("", DBNull.Value); 
                        cmd.Parameters.AddWithValue("", sTipo);
                        cmd.Parameters.AddWithValue("", sEstado);

                        cmd.ExecuteNonQuery();
                    }

                    Console.WriteLine($"[OK] Nómina insertada correctamente: {dPeriodoInicio:yyyy-MM-dd} - {dPeriodoFin:yyyy-MM-dd}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] al insertar nómina: {ex.Message}");
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
        }

        // ==========================================================
        // MÉTODO: ACTUALIZAR NÓMINA
        // ==========================================================
        public void proActualizarNomina(int iIdNomina, DateTime dPeriodoInicio, DateTime dPeriodoFin, DateTime dFechaGeneracion, string sTipo, string sEstado)
        {
            Cls_Conexion_Creacion_Nomina clsConexion = new Cls_Conexion_Creacion_Nomina();

            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = @"
                        UPDATE Tbl_Nomina
                        SET 
                            Cmp_dPeriodoInicio_Nomina = ?, 
                            Cmp_dPeriodoFin_Nomina = ?, 
                            Cmp_dFechaGeneracion_Nomina = ?, 
                            Cmp_sTipo_Nomina = ?, 
                            Cmp_sEstado_Nomina = ?
                        WHERE Cmp_iId_Nomina = ?";

                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", dPeriodoInicio);
                        cmd.Parameters.AddWithValue("", dPeriodoFin);
                        cmd.Parameters.AddWithValue("", dFechaGeneracion);
                        cmd.Parameters.AddWithValue("", sTipo);
                        cmd.Parameters.AddWithValue("", sEstado);
                        cmd.Parameters.AddWithValue("", iIdNomina);
                        cmd.ExecuteNonQuery();
                    }

                    Console.WriteLine($"[OK] Nómina actualizada (ID: {iIdNomina})");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] al actualizar nómina (ID: {iIdNomina}): {ex.Message}");
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
        }

        // ==========================================================
        // MÉTODO: ELIMINAR NÓMINA
        // ==========================================================
        public void proEliminarNomina(int iIdNomina)
        {
            Cls_Conexion_Creacion_Nomina clsConexion = new Cls_Conexion_Creacion_Nomina();

            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = "DELETE FROM Tbl_Nomina WHERE Cmp_iId_Nomina = ?";

                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", iIdNomina);
                        cmd.ExecuteNonQuery();
                    }

                    Console.WriteLine($"[OK] Nómina eliminada (ID: {iIdNomina})");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] al eliminar nómina (ID: {iIdNomina}): {ex.Message}");
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
        }

        // ==========================================================
        // MÉTODO: OBTENER NÓMINA POR ID
        // ==========================================================
        public DataTable funObtenerNominaPorId(int iIdNomina)
        {
            DataTable dtsNomina = new DataTable();
            Cls_Conexion_Creacion_Nomina clsConexion = new Cls_Conexion_Creacion_Nomina();

            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = "SELECT * FROM Tbl_Nomina WHERE Cmp_iId_Nomina = ?";

                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", iIdNomina);
                        OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                        da.Fill(dtsNomina);
                    }

                    Console.WriteLine($"[OK] Nómina obtenida por ID: {iIdNomina}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] al obtener nómina por ID: {ex.Message}");
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }

            return dtsNomina;
        }

        // ==========================================================
        // MÉTODO: OBTENER TODAS LAS NÓMINAS
        // ==========================================================
        public DataTable funObtenerTodasLasNominas()
        {
            DataTable dtsNominas = new DataTable();
            Cls_Conexion_Creacion_Nomina clsConexion = new Cls_Conexion_Creacion_Nomina();

            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = "SELECT * FROM Tbl_Nomina ORDER BY Cmp_dFechaGeneracion_Nomina DESC";

                    OdbcDataAdapter da = new OdbcDataAdapter(sSql, cnConexion);
                    da.Fill(dtsNominas);

                    Console.WriteLine($"[OK] Se obtuvieron {dtsNominas.Rows.Count} nóminas.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] al obtener todas las nóminas: {ex.Message}");
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }

            return dtsNominas;
        }

        // ==========================================================
        // MÉTODO: VERIFICAR EXISTENCIA POR ID
        // ==========================================================
        public int funVerificarExistenciaNomina(int iIdNomina)
        {
            int iExiste = 0;
            Cls_Conexion_Creacion_Nomina clsConexion = new Cls_Conexion_Creacion_Nomina();

            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = "SELECT 1 FROM Tbl_Nomina WHERE Cmp_iId_Nomina = ? LIMIT 1";

                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", iIdNomina);
                        object result = cmd.ExecuteScalar();
                        if (result != null) iExiste = 1;
                    }

                    Console.WriteLine($"[OK] Verificación de existencia completada (ID: {iIdNomina}, Existe: {iExiste == 1})");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] al verificar existencia de nómina: {ex.Message}");
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }

            return iExiste;
        }

        // ==========================================================
        // MÉTODO: VERIFICAR DUPLICIDAD DE PERIODO
        // ==========================================================
        public bool funExistePeriodoNomina(DateTime dPeriodoInicio, DateTime dPeriodoFin)
        {
            bool bExiste = false;
            Cls_Conexion_Creacion_Nomina clsConexion = new Cls_Conexion_Creacion_Nomina();

            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();

                    string sSql = @"
                        SELECT COUNT(*) FROM Tbl_Nomina
                        WHERE 
                            (Cmp_dPeriodoInicio_Nomina <= ? AND Cmp_dPeriodoFin_Nomina >= ?)
                            OR
                            (Cmp_dPeriodoInicio_Nomina <= ? AND Cmp_dPeriodoFin_Nomina >= ?)";

                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", dPeriodoFin);
                        cmd.Parameters.AddWithValue("", dPeriodoInicio);
                        cmd.Parameters.AddWithValue("", dPeriodoInicio);
                        cmd.Parameters.AddWithValue("", dPeriodoFin);

                        int iCantidad = Convert.ToInt32(cmd.ExecuteScalar());
                        bExiste = iCantidad > 0;
                    }

                    Console.WriteLine($"[OK] Verificación de duplicidad de periodo ({dPeriodoInicio:yyyy-MM-dd} - {dPeriodoFin:yyyy-MM-dd}): {(bExiste ? "Duplicado" : "Libre")}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] al verificar duplicidad de periodo: {ex.Message}");
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }

            return bExiste;
        }

        // ==========================================================
        // MÉTODO: OBTENER MOVIMIENTOS POR ID DE NÓMINA
        // ==========================================================
        public DataTable funObtenerMovimientosPorIdNomina(int iIdNomina)
        {
            DataTable dtsMovimientos = new DataTable();
            Cls_Conexion_Creacion_Nomina clsConexion = new Cls_Conexion_Creacion_Nomina();

            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();

                    string sSql = @"
                SELECT 
                    mn.Cmp_iId_MovimientoNomina AS IdMovimiento,
                    n.Cmp_iId_Nomina AS IdNomina,
                    e.Cmp_iId_Empleado AS IdEmpleado,
                    CONCAT(e.Cmp_sNombre_Empleado, ' ', e.Cmp_sApellido_Empleado) AS Empleado,
                    c.Cmp_sNombre_ConceptoNomina AS Concepto,
                    c.Cmp_sTipo_ConceptoNomina AS TipoConcepto,
                    mn.Cmp_deMonto_MovimientoNomina AS Monto
                FROM Tbl_MovimientosNomina mn
                INNER JOIN Tbl_Nomina n 
                    ON mn.Cmp_iId_Nomina = n.Cmp_iId_Nomina
                INNER JOIN Tbl_ConceptosNomina c 
                    ON mn.Cmp_iId_ConceptoNomina = c.Cmp_iId_ConceptoNomina
                LEFT JOIN Tbl_DetallesNomina dn 
                    ON dn.Cmp_iId_Nomina = n.Cmp_iId_Nomina
                LEFT JOIN Tbl_Empleados e 
                    ON e.Cmp_iId_Empleado = dn.Cmp_iId_Empleado
                WHERE n.Cmp_iId_Nomina = ?
                ORDER BY c.Cmp_sTipo_ConceptoNomina ASC";

                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", iIdNomina);
                        OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                        da.Fill(dtsMovimientos);
                    }

                    Console.WriteLine($"[OK] Se obtuvieron {dtsMovimientos.Rows.Count} movimientos únicos de la nómina #{iIdNomina}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] al obtener movimientos por ID de nómina: {ex.Message}");
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }

            return dtsMovimientos;
        }


        // ==========================================================
        // MÉTODO: CALCULAR NÓMINA COMPLETA
        // ==========================================================
        public void proCalcularNomina(int iIdNomina, DateTime dPeriodoInicio, DateTime dPeriodoFin)
        {
            Cls_Conexion_Creacion_Nomina clsConexion = new Cls_Conexion_Creacion_Nomina();

            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();

                    // 1. Obtener empleados activos
                    string sSqlEmpleados = @"SELECT Cmp_iId_Empleado, Cmp_deSalario_Empleado 
                                     FROM Tbl_Empleados WHERE Cmp_bEstado_Empleado = 1";
                    DataTable dtEmpleados = new DataTable();
                    new OdbcDataAdapter(sSqlEmpleados, cnConexion).Fill(dtEmpleados);

                    // 2. Obtener conceptos automáticos de nómina
                    string sSqlConceptos = @"
                SELECT 
                    Cmp_iId_ConceptoNomina,
                    TRIM(UPPER(Cmp_sNombre_ConceptoNomina)) AS Nombre,
                    Cmp_sTipo_ConceptoNomina,
                    UPPER(Cmp_sTipoCalculo_ConceptoNomina) AS TipoCalculo,
                    IFNULL(Cmp_deValor_ConceptoNomina, 0) AS Valor
                FROM Tbl_ConceptosNomina
                WHERE Cmp_bAplicaAutomatico_ConceptoNomina = 1";

                    DataTable dtConceptos = new DataTable();
                    new OdbcDataAdapter(sSqlConceptos, cnConexion).Fill(dtConceptos);

                    Console.WriteLine($"[INFO] Conceptos automáticos cargados: {dtConceptos.Rows.Count}");

                    // 3. Procesar cada empleado activo
                    foreach (DataRow fila in dtEmpleados.Rows)
                    {
                        int iIdEmpleado = Convert.ToInt32(fila["Cmp_iId_Empleado"]);
                        double dSalarioMensual = Convert.ToDouble(fila["Cmp_deSalario_Empleado"]);
                        int iDiasDelPeriodo = (dPeriodoFin - dPeriodoInicio).Days + 1;

                        // ---- Calcular días y valores base ----
                        int iDiasLaborados = funContarDiasAsistidos(cnConexion, iIdEmpleado, dPeriodoInicio, dPeriodoFin);
                        int iDiasVacaciones = funObtenerVacacionesAprobadas(cnConexion, iIdEmpleado, dPeriodoInicio, dPeriodoFin);
                        int iAusencias = Math.Max(0, iDiasDelPeriodo - iDiasLaborados - iDiasVacaciones);

                        (int iHorasExtra, double dPagoHorasExtra) = funObtenerHorasExtra(cnConexion, iIdEmpleado, dSalarioMensual, dPeriodoInicio, dPeriodoFin);
                        double dTotalAnticipos = funObtenerAnticipos(cnConexion, iIdEmpleado, dPeriodoInicio, dPeriodoFin);

                        double dSueldoBase = (dSalarioMensual / iDiasDelPeriodo) * (iDiasLaborados + iDiasVacaciones);
                        double dDeduccionAusencias = (dSalarioMensual / iDiasDelPeriodo) * iAusencias;

                        // ==========================================================
                        // Calcular percepciones y deducciones (base + movimientos manuales)
                        // ==========================================================
                        double dPercepciones = dSueldoBase + dPagoHorasExtra;
                        double dDeducciones = dDeduccionAusencias + dTotalAnticipos;

                        // Sumar movimientos manuales existentes
                        dPercepciones += funSumarMovimientosPorTipoEmpleado(cnConexion, iIdNomina, iIdEmpleado, "PERCEPCION");
                        dDeducciones += funSumarMovimientosPorTipoEmpleado(cnConexion, iIdNomina, iIdEmpleado, "DEDUCCION");

                        double dSueldoLiquido = dPercepciones - dDeducciones;

                        // ============================================================== 
                        // Insertar DETALLE INICIAL DE NÓMINA (se actualizará al final)
                        // ==============================================================
                        string sSqlInsertDetalle = @"
                    INSERT INTO Tbl_DetallesNomina 
                    (Cmp_iId_Nomina, Cmp_iId_Empleado, Cmp_iAusencias_DetalleNomina, 
                     Cmp_iDiasLaborados_DetalleNomina, Cmp_dePercepciones_DetalleNomina, 
                     Cmp_deDeducciones_DetalleNomina, Cmp_deSueldoLiquido_DetalleNomina)
                    VALUES (?, ?, ?, ?, ?, ?, ?)";
                        using (OdbcCommand cmdInsert = new OdbcCommand(sSqlInsertDetalle, cnConexion))
                        {
                            cmdInsert.Parameters.AddWithValue("", iIdNomina);
                            cmdInsert.Parameters.AddWithValue("", iIdEmpleado);
                            cmdInsert.Parameters.AddWithValue("", iAusencias);
                            cmdInsert.Parameters.AddWithValue("", iDiasLaborados + iDiasVacaciones);
                            cmdInsert.Parameters.AddWithValue("", dPercepciones);
                            cmdInsert.Parameters.AddWithValue("", dDeducciones);
                            cmdInsert.Parameters.AddWithValue("", dSueldoLiquido);
                            cmdInsert.ExecuteNonQuery();
                        }

                        // ==============================================================
                        // Registrar MOVIMIENTOS AUTOMÁTICOS según configuración
                        // ==============================================================
                        foreach (DataRow concepto in dtConceptos.Rows)
                        {
                            string nombre = concepto["Nombre"].ToString().Trim().ToUpper();
                            string tipo = concepto["Cmp_sTipo_ConceptoNomina"].ToString().ToUpper();
                            string tipoCalculo = concepto["TipoCalculo"].ToString().ToUpper();
                            int idConcepto = Convert.ToInt32(concepto["Cmp_iId_ConceptoNomina"]);
                            double valor = Convert.ToDouble(concepto["Valor"]);
                            double monto = 0.0;

                            switch (tipoCalculo)
                            {
                                case "FIJO":
                                    monto = valor;
                                    break;
                                case "MULTIPLICACION":
                                    if (tipo == "PERCEPCION")
                                        monto = (dSalarioMensual / iDiasDelPeriodo) * (iDiasLaborados + iDiasVacaciones) * valor;
                                    else if (tipo == "DEDUCCION")
                                        monto = dPercepciones * valor;
                                    break;
                            }

                            // Casos especiales
                            if (nombre == "AUSENCIAS") monto = (dSalarioMensual / iDiasDelPeriodo) * iAusencias;
                            if (nombre == "VACACIONES") monto = (dSalarioMensual / iDiasDelPeriodo) * iDiasVacaciones;
                            if (nombre == "HORAS EXTRA") monto = dPagoHorasExtra;
                            if (nombre == "SUELDO BASE") monto = dSueldoBase;
                            if (nombre == "ANTICIPOS") monto = dTotalAnticipos;

                            // Insertar movimiento
                            string sSqlInsertMov = @"
                        INSERT INTO Tbl_MovimientosNomina 
                        (Cmp_iId_Nomina, Cmp_iId_Empleado, Cmp_iId_ConceptoNomina, Cmp_deMonto_MovimientoNomina)
                        VALUES (?, ?, ?, ?)";
                            using (OdbcCommand cmdMov = new OdbcCommand(sSqlInsertMov, cnConexion))
                            {
                                cmdMov.Parameters.AddWithValue("", iIdNomina);
                                cmdMov.Parameters.AddWithValue("", iIdEmpleado);
                                cmdMov.Parameters.AddWithValue("", idConcepto);
                                cmdMov.Parameters.AddWithValue("", monto);
                                cmdMov.ExecuteNonQuery();
                            }

                            Console.WriteLine($"[OK] Movimiento automático: {nombre} | {tipoCalculo} | {tipo} | Monto={monto:N2}");
                        }

                        // ==============================================================
                        // Recalcular totales REALES desde Tbl_MovimientosNomina
                        // ==============================================================
                        string sSqlTotales = @"
                    SELECT 
                        IFNULL(SUM(CASE WHEN c.Cmp_sTipo_ConceptoNomina = 'PERCEPCION' THEN m.Cmp_deMonto_MovimientoNomina ELSE 0 END), 0) AS TotalPercepciones,
                        IFNULL(SUM(CASE WHEN c.Cmp_sTipo_ConceptoNomina = 'DEDUCCION' THEN m.Cmp_deMonto_MovimientoNomina ELSE 0 END), 0) AS TotalDeducciones
                    FROM Tbl_MovimientosNomina m
                    INNER JOIN Tbl_ConceptosNomina c ON m.Cmp_iId_ConceptoNomina = c.Cmp_iId_ConceptoNomina
                    WHERE m.Cmp_iId_Nomina = ? AND m.Cmp_iId_Empleado = ?";

                        using (OdbcCommand cmdTotales = new OdbcCommand(sSqlTotales, cnConexion))
                        {
                            cmdTotales.Parameters.AddWithValue("", iIdNomina);
                            cmdTotales.Parameters.AddWithValue("", iIdEmpleado);

                            using (OdbcDataReader dr = cmdTotales.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    double dTotPer = Convert.ToDouble(dr["TotalPercepciones"]);
                                    double dTotDed = Convert.ToDouble(dr["TotalDeducciones"]);
                                    double dSueldoLiquidoFinal = dTotPer - dTotDed;

                                    // Actualizar el detalle con los totales finales
                                    string sSqlUpdateDetalle = @"
                                UPDATE Tbl_DetallesNomina
                                SET Cmp_dePercepciones_DetalleNomina = ?, 
                                    Cmp_deDeducciones_DetalleNomina = ?, 
                                    Cmp_deSueldoLiquido_DetalleNomina = ?
                                WHERE Cmp_iId_Nomina = ? AND Cmp_iId_Empleado = ?";

                                    using (OdbcCommand cmdUpdDet = new OdbcCommand(sSqlUpdateDetalle, cnConexion))
                                    {
                                        cmdUpdDet.Parameters.AddWithValue("", dTotPer);
                                        cmdUpdDet.Parameters.AddWithValue("", dTotDed);
                                        cmdUpdDet.Parameters.AddWithValue("", dSueldoLiquidoFinal);
                                        cmdUpdDet.Parameters.AddWithValue("", iIdNomina);
                                        cmdUpdDet.Parameters.AddWithValue("", iIdEmpleado);
                                        cmdUpdDet.ExecuteNonQuery();
                                    }

                                    Console.WriteLine($"[UPDATE] Totales recalculados -> Percepciones: {dTotPer:N2}, Deducciones: {dTotDed:N2}, Líquido: {dSueldoLiquidoFinal:N2}");
                                }
                            }
                        }

                        Console.WriteLine($"[INFO] Empleado {iIdEmpleado} procesado correctamente con totales actualizados.");
                    }

                    // Actualizar estado y fecha de generación
                    string sSqlUpdateNomina = @"
                UPDATE Tbl_Nomina 
                SET Cmp_sEstado_Nomina = 'GENERADA',
                    Cmp_dFechaGeneracion_Nomina = NOW()
                WHERE Cmp_iId_Nomina = ?";

                    using (OdbcCommand cmdUpdateNomina = new OdbcCommand(sSqlUpdateNomina, cnConexion))
                    {
                        cmdUpdateNomina.Parameters.AddWithValue("", iIdNomina);
                        cmdUpdateNomina.ExecuteNonQuery();
                    }

                    Console.WriteLine($"[OK] Nómina #{iIdNomina} actualizada a estado GENERADA con fecha {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] al calcular nómina: {ex.Message}");
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
        }


        // ==========================================================
        // FUNCIONES AUXILIARES PRIVADAS
        // ==========================================================

        private int funContarDiasAsistidos(OdbcConnection cn, int iIdEmpleado, DateTime dInicio, DateTime dFin)
        {
            string sSql = @"SELECT COUNT(*) 
                    FROM Tbl_Asistencias 
                    WHERE Cmp_iId_Empleado = ? 
                    AND Cmp_dFecha_Asistencia BETWEEN ? AND ?";
            using (OdbcCommand cmd = new OdbcCommand(sSql, cn))
            {
                cmd.Parameters.AddWithValue("", iIdEmpleado);
                cmd.Parameters.AddWithValue("", dInicio);
                cmd.Parameters.AddWithValue("", dFin);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private int funObtenerVacacionesAprobadas(OdbcConnection cn, int iIdEmpleado, DateTime dInicio, DateTime dFin)
        {
            string sSql = @"SELECT IFNULL(SUM(Cmp_iDias_Vacacion), 0) 
                    FROM Tbl_Vacaciones 
                    WHERE Cmp_iId_Empleado = ? 
                    AND Cmp_bAprobada_Vacacion = 1
                    AND Cmp_dFechaInicio_Vacacion BETWEEN ? AND ?";
            using (OdbcCommand cmd = new OdbcCommand(sSql, cn))
            {
                cmd.Parameters.AddWithValue("", iIdEmpleado);
                cmd.Parameters.AddWithValue("", dInicio);
                cmd.Parameters.AddWithValue("", dFin);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private (int, double) funObtenerHorasExtra(OdbcConnection cn, int iIdEmpleado, double dSalarioMensual, DateTime dInicio, DateTime dFin)
        {
            string sSql = @"SELECT IFNULL(SUM(Cmp_iCantidad_HoraExtra), 0) 
                    FROM Tbl_HorasExtra 
                    WHERE Cmp_iId_Empleado = ? 
                    AND Cmp_bAprobado_HoraExtra = 1
                    AND Cmp_dFecha_HoraExtra BETWEEN ? AND ?";
            using (OdbcCommand cmd = new OdbcCommand(sSql, cn))
            {
                cmd.Parameters.AddWithValue("", iIdEmpleado);
                cmd.Parameters.AddWithValue("", dInicio);
                cmd.Parameters.AddWithValue("", dFin);
                int iHorasExtra = Convert.ToInt32(cmd.ExecuteScalar());
                double dValorHora = (dSalarioMensual / 30.0 / 8.0) * 1.5;
                double dPagoHorasExtra = iHorasExtra * dValorHora;
                return (iHorasExtra, dPagoHorasExtra);
            }
        }

        private double funObtenerAnticipos(OdbcConnection cn, int iIdEmpleado, DateTime dInicio, DateTime dFin)
        {
            string sSql = @"SELECT IFNULL(SUM(Cmp_deMonto_Anticipo), 0) 
                    FROM Tbl_Anticipos 
                    WHERE Cmp_iId_Empleado = ? 
                    AND Cmp_dFecha_Anticipo BETWEEN ? AND ?";
            using (OdbcCommand cmd = new OdbcCommand(sSql, cn))
            {
                cmd.Parameters.AddWithValue("", iIdEmpleado);
                cmd.Parameters.AddWithValue("", dInicio);
                cmd.Parameters.AddWithValue("", dFin);
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
        }

        private double funSumarMovimientosPorTipo(OdbcConnection cn, int iIdNomina, string sTipo)
        {
            string sSql = @"SELECT IFNULL(SUM(mn.Cmp_deMonto_MovimientoNomina), 0)
                    FROM Tbl_MovimientosNomina mn
                    INNER JOIN Tbl_ConceptosNomina c ON mn.Cmp_iId_ConceptoNomina = c.Cmp_iId_ConceptoNomina
                    WHERE mn.Cmp_iId_Nomina = ? AND c.Cmp_sTipo_ConceptoNomina = ?";
            using (OdbcCommand cmd = new OdbcCommand(sSql, cn))
            {
                cmd.Parameters.AddWithValue("", iIdNomina);
                cmd.Parameters.AddWithValue("", sTipo);
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
        }

        // ==========================================================
        // FUNCIÓN: SUMAR MOVIMIENTOS POR TIPO Y EMPLEADO
        // ==========================================================
        private double funSumarMovimientosPorTipoEmpleado(OdbcConnection cn, int iIdNomina, int iIdEmpleado, string sTipo)
        {
            string sSql = @"
        SELECT IFNULL(SUM(mn.Cmp_deMonto_MovimientoNomina), 0)
        FROM Tbl_MovimientosNomina mn
        INNER JOIN Tbl_ConceptosNomina c 
            ON mn.Cmp_iId_ConceptoNomina = c.Cmp_iId_ConceptoNomina
        WHERE mn.Cmp_iId_Nomina = ? 
          AND mn.Cmp_iId_Empleado = ?
          AND c.Cmp_sTipo_ConceptoNomina = ?";

            using (OdbcCommand cmd = new OdbcCommand(sSql, cn))
            {
                cmd.Parameters.AddWithValue("", iIdNomina);
                cmd.Parameters.AddWithValue("", iIdEmpleado);
                cmd.Parameters.AddWithValue("", sTipo);
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDouble(result) : 0;
            }
        }


        // ==========================================================
        // MÉTODO: OBTENER DETALLE DE NÓMINA
        // ==========================================================
        public DataTable funObtenerDetalleNomina(int iIdNomina)
        {
            DataTable dtsDetalles = new DataTable();
            Cls_Conexion_Creacion_Nomina clsConexion = new Cls_Conexion_Creacion_Nomina();

            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();

                    string sSql = @"
                SELECT 
                    dn.Cmp_iId_Nomina AS Nomina,
                    e.Cmp_iId_Empleado AS IdEmpleado,
                    CONCAT(e.Cmp_sNombre_Empleado, ' ', e.Cmp_sApellido_Empleado) AS Empleado,
                    dn.Cmp_iAusencias_DetalleNomina AS Ausencias,
                    dn.Cmp_iDiasLaborados_DetalleNomina AS DiasLaborados,
                    dn.Cmp_dePercepciones_DetalleNomina AS Percepciones,
                    dn.Cmp_deDeducciones_DetalleNomina AS Deducciones,
                    dn.Cmp_deSueldoLiquido_DetalleNomina AS SueldoLiquido
                FROM Tbl_DetallesNomina dn
                INNER JOIN Tbl_Empleados e ON dn.Cmp_iId_Empleado = e.Cmp_iId_Empleado
                WHERE dn.Cmp_iId_Nomina = ?";

                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", iIdNomina);
                        OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                        da.Fill(dtsDetalles);
                    }

                    Console.WriteLine($"[OK] Se obtuvieron {dtsDetalles.Rows.Count} registros del detalle de la nómina #{iIdNomina}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] al obtener detalle de nómina: {ex.Message}");
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }

            return dtsDetalles;
        }


        // ==========================================================
        // MÉTODO: OBTENER MOVIMIENTOS POR EMPLEADO Y NÓMINA
        // ==========================================================
        public DataTable funObtenerMovimientosPorEmpleado(int iIdNomina, int iIdEmpleado)
        {
            DataTable dtsMovimientos = new DataTable();
            Cls_Conexion_Creacion_Nomina clsConexion = new Cls_Conexion_Creacion_Nomina();

            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();

                    string sSql = @"
                SELECT 
                    mn.Cmp_iId_MovimientoNomina AS IdMovimiento,
                    n.Cmp_iId_Nomina AS IdNomina,
                    e.Cmp_iId_Empleado AS IdEmpleado,
                    CONCAT(e.Cmp_sNombre_Empleado, ' ', e.Cmp_sApellido_Empleado) AS Empleado,
                    c.Cmp_sNombre_ConceptoNomina AS Concepto,
                    c.Cmp_sTipo_ConceptoNomina AS TipoConcepto,
                    mn.Cmp_deMonto_MovimientoNomina AS Monto
                FROM Tbl_MovimientosNomina mn
                INNER JOIN Tbl_Nomina n 
                    ON mn.Cmp_iId_Nomina = n.Cmp_iId_Nomina
                INNER JOIN Tbl_ConceptosNomina c 
                    ON mn.Cmp_iId_ConceptoNomina = c.Cmp_iId_ConceptoNomina
                INNER JOIN Tbl_Empleados e 
                    ON e.Cmp_iId_Empleado = ?
                WHERE mn.Cmp_iId_Nomina = ?
                ORDER BY c.Cmp_sTipo_ConceptoNomina ASC";

                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", iIdEmpleado);
                        cmd.Parameters.AddWithValue("", iIdNomina);

                        OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                        da.Fill(dtsMovimientos);
                    }

                    Console.WriteLine($"[OK] Se obtuvieron {dtsMovimientos.Rows.Count} movimientos del empleado #{iIdEmpleado} en la nómina #{iIdNomina}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR] al obtener movimientos del empleado: {ex.Message}");
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }

            return dtsMovimientos;
        }

    }
}
