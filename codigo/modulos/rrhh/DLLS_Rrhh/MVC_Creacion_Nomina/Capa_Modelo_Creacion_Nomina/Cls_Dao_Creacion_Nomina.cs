// =============================================================
// Capa_Modelo_Creacion_Nomina
// Clase: Cls_Dao_Creacion_Nomina
// Autor: Fredy Reyes Sabán
// Carné: 20250000
// Fecha: 29/10/2025
// =============================================================

using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Creacion_Nomina
{
    public class Cls_Dao_Creacion_Nomina
    {
        // ==========================================================
        // MÉTODOS DE CREACIÓN
        // ==========================================================
        public void proInsertarNomina(DateTime dPeriodoInicio, DateTime dPeriodoFin, DateTime dFechaGeneracion, string sTipo, string sEstado)
        {
            Cls_Conexion_Creacion_Nomina clsConexion = new Cls_Conexion_Creacion_Nomina();
            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();

                    string sSql = "INSERT INTO Tbl_Nomina (Cmp_dPeriodoInicioNomina, Cmp_dPeriodoFinNomina, Cmp_dFechaGeneracionNomina, Cmp_vTipoNomina, Cmp_vEstadoNomina) VALUES (?, ?, ?, ?, ?)";
                    using (OdbcCommand cmdComando = new OdbcCommand(sSql, cnConexion))
                    {
                        cmdComando.Parameters.AddWithValue("", dPeriodoInicio);
                        cmdComando.Parameters.AddWithValue("", dPeriodoFin);
                        cmdComando.Parameters.AddWithValue("", dFechaGeneracion);
                        cmdComando.Parameters.AddWithValue("", sTipo);
                        cmdComando.Parameters.AddWithValue("", sEstado);
                        cmdComando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error al insertar la nómina: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
        }

        // ==========================================================
        // MÉTODOS DE MODIFICACIÓN
        // ==========================================================
        public void proActualizarNomina(int iIdNomina, DateTime dPeriodoInicio, DateTime dPeriodoFin, DateTime dFechaGeneracion, string sTipo, string sEstado)
        {
            Cls_Conexion_Creacion_Nomina clsConexion = new Cls_Conexion_Creacion_Nomina();
            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();

                    string sSql = "UPDATE Tbl_Nomina SET Cmp_dPeriodoInicioNomina=?, Cmp_dPeriodoFinNomina=?, Cmp_dFechaGeneracionNomina=?, Cmp_vTipoNomina=?, Cmp_vEstadoNomina=? WHERE Cmp_iNomina=?";
                    using (OdbcCommand cmdComando = new OdbcCommand(sSql, cnConexion))
                    {
                        cmdComando.Parameters.AddWithValue("", dPeriodoInicio);
                        cmdComando.Parameters.AddWithValue("", dPeriodoFin);
                        cmdComando.Parameters.AddWithValue("", dFechaGeneracion);
                        cmdComando.Parameters.AddWithValue("", sTipo);
                        cmdComando.Parameters.AddWithValue("", sEstado);
                        cmdComando.Parameters.AddWithValue("", iIdNomina);
                        cmdComando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error al actualizar la nómina: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
        }

        // ==========================================================
        // MÉTODOS DE ELIMINACIÓN
        // ==========================================================
        public void proEliminarNomina(int iIdNomina)
        {
            Cls_Conexion_Creacion_Nomina clsConexion = new Cls_Conexion_Creacion_Nomina();
            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open(); // ✅ Abrir conexión

                    string sSql = "DELETE FROM Tbl_Nomina WHERE Cmp_iNomina = ?";
                    using (OdbcCommand cmdComando = new OdbcCommand(sSql, cnConexion))
                    {
                        cmdComando.Parameters.AddWithValue("", iIdNomina);
                        cmdComando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error al eliminar la nómina: " + ex.Message);
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
        public DataTable funObtenerNominaPorId(int iIdNomina)
        {
            DataTable dtsNomina = new DataTable();
            Cls_Conexion_Creacion_Nomina clsConexion = new Cls_Conexion_Creacion_Nomina();
            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open();

                    string sSql = "SELECT * FROM Tbl_Nomina WHERE Cmp_iNomina = ?";
                    using (OdbcCommand cmdComando = new OdbcCommand(sSql, cnConexion))
                    {
                        cmdComando.Parameters.AddWithValue("", iIdNomina);
                        OdbcDataAdapter daAdaptador = new OdbcDataAdapter(cmdComando);
                        daAdaptador.Fill(dtsNomina);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener la nómina: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
            return dtsNomina;
        }

        public DataTable funObtenerTodasLasNominas()
        {
            DataTable dtsNominas = new DataTable();
            Cls_Conexion_Creacion_Nomina clsConexion = new Cls_Conexion_Creacion_Nomina();
            using (OdbcConnection cnConexion = clsConexion.conexion())
            {
                try
                {
                    cnConexion.Open(); // ✅ Abrir conexión

                    string sSql = "SELECT * FROM Tbl_Nomina ORDER BY Cmp_dFechaGeneracionNomina DESC";
                    OdbcDataAdapter daAdaptador = new OdbcDataAdapter(sSql, cnConexion);
                    daAdaptador.Fill(dtsNominas);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error al obtener todas las nóminas: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
            return dtsNominas;
        }

        // ==========================================================
        // MÉTODOS DE VERIFICACIÓN
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

                    string sSql = "SELECT 1 FROM Tbl_Nomina WHERE Cmp_iNomina = ? LIMIT 1";
                    using (OdbcCommand cmdComando = new OdbcCommand(sSql, cnConexion))
                    {
                        cmdComando.Parameters.AddWithValue("", iIdNomina);
                        object oResultado = cmdComando.ExecuteScalar();
                        if (oResultado != null)
                            iExiste = 1;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al verificar existencia: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
            return iExiste;
        }

        // ==========================================================
        // MÉTODO DE VERIFICACIÓN DE PERIODO DUPLICADO
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
                    // Se verifica si el nuevo rango se solapa con un rango existente
                    string sSql = @"
                SELECT COUNT(*) FROM Tbl_Nomina
                WHERE 
                    (Cmp_dPeriodoInicioNomina <= ? AND Cmp_dPeriodoFinNomina >= ?)
                    OR
                    (Cmp_dPeriodoInicioNomina <= ? AND Cmp_dPeriodoFinNomina >= ?)";
                    using (OdbcCommand cmd = new OdbcCommand(sSql, cnConexion))
                    {
                        cmd.Parameters.AddWithValue("", dPeriodoFin);
                        cmd.Parameters.AddWithValue("", dPeriodoInicio);
                        cmd.Parameters.AddWithValue("", dPeriodoInicio);
                        cmd.Parameters.AddWithValue("", dPeriodoFin);

                        int iCantidad = Convert.ToInt32(cmd.ExecuteScalar());
                        if (iCantidad > 0)
                            bExiste = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al verificar duplicidad de periodo: " + ex.Message);
                }
                finally
                {
                    clsConexion.desconexion(cnConexion);
                }
            }
            return bExiste;
        }


    }
}
