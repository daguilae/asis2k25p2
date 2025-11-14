// =============================================================
// Capa_Modelo_Deducciones_Nomina
// Clase: Cls_Dao_Deducciones_Nomina
// Autor: Fredy Reyes Sabán
// Carné: 0901-22-9800
// Fecha: 31/10/2025
// =============================================================

using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Deducciones_Nomina
{
    public class Cls_Dao_Deducciones_Nomina
    {
        private Cls_Conexion_Deducciones_Nomina clsConexion = new Cls_Conexion_Deducciones_Nomina();

        // ==========================================================
        // MÉTODOS DE CONSULTA PARA COMBOS
        // ==========================================================
        public DataTable funObtenerNominas()
        {
            DataTable dtsNominas = new DataTable();
            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = "SELECT Cmp_iId_Nomina, CONCAT('Nómina #', Cmp_iId_Nomina) AS Nombre FROM Tbl_Nomina ORDER BY Cmp_iId_Nomina DESC";
                    OdbcDataAdapter da = new OdbcDataAdapter(sSql, cnConexion);
                    da.Fill(dtsNominas);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener nóminas: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
            return dtsNominas;
        }

        public DataTable funObtenerEmpleados()
        {
            DataTable dtsEmpleados = new DataTable();
            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = "SELECT Cmp_iId_Empleado, CONCAT(Cmp_sNombre_Empleado, ' ', Cmp_sApellido_Empleado) AS Nombre FROM Tbl_Empleados ORDER BY Nombre ASC";
                    OdbcDataAdapter da = new OdbcDataAdapter(sSql, cnConexion);
                    da.Fill(dtsEmpleados);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener empleados: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
            return dtsEmpleados;
        }

        public DataTable funObtenerConceptos()
        {
            DataTable dtsConceptos = new DataTable();
            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = "SELECT Cmp_iId_ConceptoNomina, Cmp_sNombre_ConceptoNomina " +
                                  "FROM Tbl_ConceptosNomina " +
                                  "WHERE Cmp_sTipo_ConceptoNomina = 'DEDUCCION' " +
                                  "ORDER BY Cmp_sNombre_ConceptoNomina ASC";
                    OdbcDataAdapter da = new OdbcDataAdapter(sSql, cnConexion);
                    da.Fill(dtsConceptos);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener conceptos: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
            return dtsConceptos;
        }


        // ==========================================================
        // MÉTODO: INSERTAR
        // ==========================================================
        public void proInsertarMovimientoNomina(int iIdNomina, int iIdEmpleado, int iIdConceptoNomina, decimal dMontoMovimiento)
        {
            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = @"
                INSERT INTO Tbl_MovimientosNomina 
                (Cmp_iId_Nomina, Cmp_iId_Empleado, Cmp_iId_ConceptoNomina, Cmp_deMonto_MovimientoNomina)
                VALUES (?, ?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", iIdNomina);
                        cmd.Parameters.AddWithValue("", iIdEmpleado);
                        cmd.Parameters.AddWithValue("", iIdConceptoNomina);
                        cmd.Parameters.AddWithValue("", dMontoMovimiento);
                        cmd.ExecuteNonQuery();
                    }

                    Console.WriteLine($"Movimiento insertado correctamente para empleado #{iIdEmpleado}.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar movimiento de nómina: " + ex.Message);
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
                    Console.WriteLine("Error al actualizar movimiento de nómina: " + ex.Message);
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
                    Console.WriteLine("Error al eliminar movimiento de nómina: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
        }

        // ==========================================================
        // MÉTODOS DE CONSULTA
        // ==========================================================
        public DataTable funObtenerMovimientoPorId(int iIdMovimiento)
        {
            DataTable dtsMovimiento = new DataTable();
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
                    Console.WriteLine("Error al obtener movimiento por ID: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
            return dtsMovimiento;
        }

        public DataTable funObtenerTodosMovimientos()
        {
            DataTable dtsMovimientos = new DataTable();
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
                    Console.WriteLine("Error al obtener todos los movimientos: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
            return dtsMovimientos;
        }

        public DataTable funObtenerMovimientosPorNomina(int iIdNomina)
        {
            DataTable dtsMovimientos = new DataTable();
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
                    Console.WriteLine("Error al obtener movimientos por nómina: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
            return dtsMovimientos;
        }

        public DataTable funObtenerMovimientosPorNominaYEmpleado(int iIdNomina, int iIdEmpleado)
        {
            DataTable dtsMovimientos = new DataTable();
            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = @"
                SELECT 
                    mn.Cmp_iId_MovimientoNomina,
                    mn.Cmp_iId_Nomina,
                    mn.Cmp_deMonto_MovimientoNomina,
                    c.Cmp_sNombre_ConceptoNomina AS NombreConcepto,
                    c.Cmp_sTipo_ConceptoNomina AS TipoConcepto,
                    c.Fk_Codigo_Cuenta AS CodigoCuenta,
                    e.Cmp_sNombre_Empleado AS NombreEmpleado,
                    e.Cmp_sApellido_Empleado AS ApellidoEmpleado
                FROM Tbl_MovimientosNomina mn
                LEFT JOIN Tbl_ConceptosNomina c 
                    ON mn.Cmp_iId_ConceptoNomina = c.Cmp_iId_ConceptoNomina
                INNER JOIN Tbl_Empleados e 
                    ON mn.Cmp_iId_Empleado = e.Cmp_iId_Empleado
                WHERE mn.Cmp_iId_Nomina = ? AND mn.Cmp_iId_Empleado = ?
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
                    Console.WriteLine("Error al obtener movimientos por nómina y empleado: " + ex.Message);
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
                    Console.WriteLine("Error al sumar movimientos por tipo: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
            return dTotal;
        }

        // ==========================================================
        // MÉTODO: VERIFICAR EXISTENCIA DE MOVIMIENTO
        // ==========================================================
        public int funVerificarExistenciaMovimiento(int iIdMovimiento)
        {
            int iExiste = 0;
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
                    Console.WriteLine("Error al verificar existencia del movimiento: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
            return iExiste;
        }

        public string funObtenerEstadoNomina(int iIdNomina)
        {
            string estado = string.Empty;
            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();
                    string sSql = "SELECT Cmp_sEstado_Nomina FROM Tbl_Nomina WHERE Cmp_iId_Nomina = ?";
                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", iIdNomina);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                            estado = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener estado de nómina: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
            return estado;
        }

    }
}
