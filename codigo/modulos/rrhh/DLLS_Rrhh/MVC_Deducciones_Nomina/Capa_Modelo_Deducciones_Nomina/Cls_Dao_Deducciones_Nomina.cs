// =============================================================
// Capa_Modelo_Creacion_Nomina
// Clase: Cls_Dao_Movimientos_Nomina
// Autor: Fredy Reyes Sabán
// Carné: 20250000
// Fecha: 31/10/2025
// =============================================================

using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Deducciones_Nomina
{
    public class Cls_Dao_Deducciones_Nomina
    {
        // ==========================================================
        // MÉTODO: INSERTAR
        // ==========================================================
        public void proInsertarMovimientoNomina(int iIdNomina, int iIdConceptoNomina, decimal dMontoMovimiento)
        {
            Cls_Conexion_Deducciones_Nomina clsConexion = new Cls_Conexion_Deducciones_Nomina();
            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = "INSERT INTO Tbl_MovimientosNomina (Cmp_iId_Nomina, Cmp_iId_ConceptoNomina, Cmp_deMonto_MovimientoNomina) VALUES (?, ?, ?)";
                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", iIdNomina);
                        cmd.Parameters.AddWithValue("", iIdConceptoNomina);
                        cmd.Parameters.AddWithValue("", dMontoMovimiento);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error al insertar movimiento de nómina: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
        }

        // ==========================================================
        // MÉTODO: ACTUALIZAR
        // ==========================================================
        public void proActualizarMovimientoNomina(int iIdMovimiento, int iIdNomina, int iIdConceptoNomina, decimal dMontoMovimiento)
        {
            Cls_Conexion_Deducciones_Nomina clsConexion = new Cls_Conexion_Deducciones_Nomina();
            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = "UPDATE Tbl_MovimientosNomina SET Cmp_iId_Nomina=?, Cmp_iId_ConceptoNomina=?, Cmp_deMonto_MovimientoNomina=? WHERE Cmp_iId_MovimientoNomina=?";
                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", iIdNomina);
                        cmd.Parameters.AddWithValue("", iIdConceptoNomina);
                        cmd.Parameters.AddWithValue("", dMontoMovimiento);
                        cmd.Parameters.AddWithValue("", iIdMovimiento);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error al actualizar movimiento de nómina: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
        }

        // ==========================================================
        // MÉTODO: ELIMINAR
        // ==========================================================
        public void proEliminarMovimientoNomina(int iIdMovimiento)
        {
            Cls_Conexion_Deducciones_Nomina clsConexion = new Cls_Conexion_Deducciones_Nomina();
            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = "DELETE FROM Tbl_MovimientosNomina WHERE Cmp_iId_MovimientoNomina=?";
                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", iIdMovimiento);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error al eliminar movimiento de nómina: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
        }

        // ==========================================================
        // MÉTODO: OBTENER POR ID
        // ==========================================================
        public DataTable funObtenerMovimientoPorId(int iIdMovimiento)
        {
            DataTable dtsMovimiento = new DataTable();
            Cls_Conexion_Deducciones_Nomina clsConexion = new Cls_Conexion_Deducciones_Nomina();

            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = "SELECT * FROM Tbl_MovimientosNomina WHERE Cmp_iId_MovimientoNomina=?";
                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", iIdMovimiento);
                        OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                        da.Fill(dtsMovimiento);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error al obtener movimiento por ID: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }

            return dtsMovimiento;
        }

        // ==========================================================
        // MÉTODO: OBTENER TODOS
        // ==========================================================
        public DataTable funObtenerTodosMovimientos()
        {
            DataTable dtsMovimientos = new DataTable();
            Cls_Conexion_Deducciones_Nomina clsConexion = new Cls_Conexion_Deducciones_Nomina();

            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = "SELECT * FROM Tbl_MovimientosNomina";
                    OdbcDataAdapter da = new OdbcDataAdapter(sSql, cnConexion);
                    da.Fill(dtsMovimientos);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error al obtener todos los movimientos: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }

            return dtsMovimientos;
        }

        // ==========================================================
        // MÉTODO: OBTENER POR NÓMINA ID
        // ==========================================================
        public DataTable funObtenerMovimientosPorNomina(int iIdNomina)
        {
            DataTable dtsMovimientos = new DataTable();
            Cls_Conexion_Deducciones_Nomina clsConexion = new Cls_Conexion_Deducciones_Nomina();

            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = @"
                        SELECT mn.*, c.Cmp_sNombre_ConceptoNomina AS NombreConcepto
                        FROM Tbl_MovimientosNomina mn
                        INNER JOIN Tbl_ConceptosNomina c ON mn.Cmp_iId_ConceptoNomina = c.Cmp_iId_ConceptoNomina
                        WHERE mn.Cmp_iId_Nomina=?";
                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", iIdNomina);
                        OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                        da.Fill(dtsMovimientos);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error al obtener movimientos por nómina ID: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }

            return dtsMovimientos;
        }

        // ==========================================================
        // MÉTODO: SUMAR MOVIMIENTOS POR TIPO DE CONCEPTO
        // ==========================================================
        public decimal funSumarMovimientosPorTipo(int iIdNomina, string sTipoConcepto)
        {
            decimal dTotal = 0;
            Cls_Conexion_Deducciones_Nomina clsConexion = new Cls_Conexion_Deducciones_Nomina();

            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = @"
                        SELECT COALESCE(SUM(mn.Cmp_deMonto_MovimientoNomina), 0) AS Total
                        FROM Tbl_MovimientosNomina mn
                        INNER JOIN Tbl_ConceptosNomina c ON mn.Cmp_iId_ConceptoNomina = c.Cmp_iId_ConceptoNomina
                        WHERE mn.Cmp_iId_Nomina = ? AND c.Cmp_sTipo_ConceptoNomina = ?";
                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", iIdNomina);
                        cmd.Parameters.AddWithValue("", sTipoConcepto);
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                            dTotal = Convert.ToDecimal(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error al sumar movimientos por tipo: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }

            return dTotal;
        }

        // ==========================================================
        // MÉTODO: VERIFICAR EXISTENCIA
        // ==========================================================
        public int funVerificarExistenciaMovimiento(int iIdMovimiento)
        {
            int iExiste = 0;
            Cls_Conexion_Deducciones_Nomina clsConexion = new Cls_Conexion_Deducciones_Nomina();

            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = "SELECT 1 FROM Tbl_MovimientosNomina WHERE Cmp_iId_MovimientoNomina=? LIMIT 1";
                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", iIdMovimiento);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                            iExiste = 1;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error al verificar existencia del movimiento: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }

            return iExiste;
        }

        // ==========================================================
        // MÉTODO: OBTENER MOVIMIENTOS POR NÓMINA Y EMPLEADO
        // ==========================================================
        public DataTable funObtenerMovimientosPorNominaYEmpleado(int iIdNomina, int iIdEmpleado)
        {
            DataTable dtsMovimientos = new DataTable();
            Cls_Conexion_Deducciones_Nomina clsConexion = new Cls_Conexion_Deducciones_Nomina();

            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = @"
                        SELECT mn.Cmp_iId_MovimientoNomina,
                               mn.Cmp_deMonto_MovimientoNomina,
                               c.Cmp_sNombre_ConceptoNomina AS NombreConcepto,
                               c.Cmp_sTipo_ConceptoNomina AS TipoConcepto,
                               e.Cmp_sNombre_Empleado AS NombreEmpleado,
                               e.Cmp_sApellido_Empleado AS ApellidoEmpleado
                        FROM Tbl_MovimientosNomina mn
                        INNER JOIN Tbl_DetallesNomina dn ON mn.Cmp_iId_Nomina = dn.Cmp_iId_Nomina
                        INNER JOIN Tbl_ConceptosNomina c ON mn.Cmp_iId_ConceptoNomina = c.Cmp_iId_ConceptoNomina
                        INNER JOIN Tbl_Empleados e ON dn.Cmp_iId_Empleado = e.Cmp_iId_Empleado
                        WHERE mn.Cmp_iId_Nomina = ? AND dn.Cmp_iId_Empleado = ?
                        ORDER BY c.Cmp_sTipo_ConceptoNomina ASC";
                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", iIdNomina);
                        cmd.Parameters.AddWithValue("", iIdEmpleado);
                        OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                        da.Fill(dtsMovimientos);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error al obtener movimientos por nómina y empleado: " + ex.Message);
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
