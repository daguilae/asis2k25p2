using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using Capa_Controlador_Polizas;

namespace Capa_Modelo_Poliza
{
    //========================== Kevin Natareno 0901-21-635 : DAO Poliza, 26/10/2025 ===================================================
    public class Cls_DAO_Poliza
    {
        private Cls_Conexion conexion;

        public Cls_DAO_Poliza()
        {
            conexion = new Cls_Conexion();
        }

        // Obtiene los movimientos filtrados desde Bancos
        public DataTable ObtenerMovimientos(int idBanco, string tipo, int docIni, int docFin, DateTime fechaIni, DateTime fechaFin)
        {
            DataTable dt = new DataTable();
            OdbcConnection conn = null;
            try
            {
                conn = conexion.AbrirConexion();
                string query = @"SELECT * 
                         FROM tbl_MovimientoBancarioEncabezado 
                         WHERE Fk_Id_CuentaBanco = ? 
                         AND Cmp_TipoMovimiento = ?
                         AND Pk_Id_MovimientoBancario BETWEEN ? AND ?
                         AND Cmp_Fecha BETWEEN ? AND ?";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@banco", idBanco);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@docIni", docIni);
                    cmd.Parameters.AddWithValue("@docFin", docFin);
                    cmd.Parameters.AddWithValue("@fechaIni", fechaIni);
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener movimientos: " + ex.Message);
            }
            finally
            {
                if (conn != null)
                    conexion.CerrarConexion(conn);
            }
            return dt;
        }


        // Inserta la póliza en Contabilidad
        public void GenerarPoliza(DateTime fechaPoliza, string concepto, List<(string cuenta, bool tipo, decimal valor)> detalles)
        {
            try
            {
                Cls_PolizaControlador polizaCtrl = new Cls_PolizaControlador();
                
                polizaCtrl.InsertarPoliza(fechaPoliza, concepto, detalles);
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar póliza en contabilidad: " + ex.Message);
            }
        }


        // ========== LISTA DE BANCOS ==========
        public DataTable ObtenerBancos()
        {
            DataTable dt = new DataTable();
            OdbcConnection conn = null;
            try
            {
                conn = conexion.AbrirConexion();
                string query = "SELECT Pk_Id_CuentaBancaria, Cmp_NumeroCuenta FROM tbl_CuentasBancarias";
                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener bancos: " + ex.Message);
            }
            finally
            {
                if (conn != null)
                    conexion.CerrarConexion(conn);
            }
            return dt;
        }


        // ========== LISTA DE TIPOS ==========
        public DataTable ObtenerTipos()
        {
            DataTable dt = new DataTable();
            OdbcConnection conn = null;
            try
            {
                conn = conexion.AbrirConexion();
                string query = "SELECT Pk_Id_Transaccion, Cmp_NombreTransaccion FROM tbl_TransaccionesBancarias";
                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener tipos: " + ex.Message);
            }
            finally
            {
                if (conn != null)
                    conexion.CerrarConexion(conn);
            }
            return dt;
        }


        // ========== RANGOS DE DOCUMENTOS ==========
        public (int min, int max) ObtenerRangoDocumentos(int banco, int tipo)
        {
            OdbcConnection conn = null;
            try
            {
                conn = conexion.AbrirConexion();
                string query = @"SELECT MIN(Pk_Id_Movimiento), MAX(Pk_Id_Movimiento)
                         FROM tbl_MovimientoBancarioEncabezado
                         WHERE Fk_Id_CuentaOrigen = ? AND Fk_Id_Operacion = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@banco", banco);
                    cmd.Parameters.AddWithValue("@tipo", tipo);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int min = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        int max = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                        return (min, max);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener rango de documentos: " + ex.Message);
            }
            finally
            {
                if (conn != null)
                    conexion.CerrarConexion(conn);
            }
            return (0, 0);
        }


        // ========== RANGOS DE FECHAS ==========
        public (DateTime min, DateTime max) ObtenerRangoFechas(int banco, int tipo)
        {
            OdbcConnection conn = null;
            try
            {
                conn = conexion.AbrirConexion();
                string query = @"SELECT MIN(Cmp_Fecha), MAX(Cmp_Fecha)
                         FROM tbl_MovimientoBancarioEncabezado
                         WHERE Fk_Id_CuentaOrigen = ? AND Fk_Id_Operacion = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@banco", banco);
                    cmd.Parameters.AddWithValue("@tipo", tipo);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        DateTime min = reader.IsDBNull(0) ? DateTime.Now : reader.GetDateTime(0);
                        DateTime max = reader.IsDBNull(1) ? DateTime.Now : reader.GetDateTime(1);
                        return (min, max);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener rango de fechas: " + ex.Message);
            }
            finally
            {
                if (conn != null)
                    conexion.CerrarConexion(conn);
            }
            return (DateTime.Now, DateTime.Now);
        }

    }
}
