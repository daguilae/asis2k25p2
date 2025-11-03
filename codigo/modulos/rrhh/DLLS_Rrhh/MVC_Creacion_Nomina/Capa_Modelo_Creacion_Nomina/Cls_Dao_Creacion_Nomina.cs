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

namespace Capa_Modelo_Creacion_Nomina
{
    public class Cls_Dao_Creacion_Nomina
    {
        // ==========================================================
        // MÉTODO: INSERTAR NÓMINA
        // ==========================================================
        public void proInsertarNomina(DateTime dPeriodoInicio, DateTime dPeriodoFin, DateTime dFechaGeneracion, string sTipo, string sEstado)
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
                        cmd.Parameters.AddWithValue("", dFechaGeneracion);
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
                INNER JOIN Tbl_Nomina n ON mn.Cmp_iId_Nomina = n.Cmp_iId_Nomina
                INNER JOIN Tbl_ConceptosNomina c ON mn.Cmp_iId_ConceptoNomina = c.Cmp_iId_ConceptoNomina
                INNER JOIN Tbl_DetallesNomina dn ON n.Cmp_iId_Nomina = dn.Cmp_iId_Nomina
                INNER JOIN Tbl_Empleados e ON dn.Cmp_iId_Empleado = e.Cmp_iId_Empleado
                WHERE n.Cmp_iId_Nomina = ?
                ORDER BY c.Cmp_sTipo_ConceptoNomina ASC";

                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", iIdNomina);
                        OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                        da.Fill(dtsMovimientos);
                    }

                    Console.WriteLine($"[OK] Se obtuvieron {dtsMovimientos.Rows.Count} movimientos de la nómina #{iIdNomina}");
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

    }
}
