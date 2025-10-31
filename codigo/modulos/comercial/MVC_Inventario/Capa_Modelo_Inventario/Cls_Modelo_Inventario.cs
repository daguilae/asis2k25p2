using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Inventario
{
    public class Cls_Modelo_Inventario
    {
        private Cls_Conexion cnx;
        private Cls_Sentencias_Inventario snt;

        public Cls_Modelo_Inventario()
        {
            cnx = new Cls_Conexion();
            snt = new Cls_Sentencias_Inventario();
        }

        public DataTable Mdl_ObtenerHistorico(
            string tipoMovimiento,
            int? idAlmacen,
            int? idEstado,
            bool usarRangoFechas,
            DateTime fechaInicio,
            DateTime fechaFin,
            string ordenarPor)
        {
            DataTable dt = new DataTable();
            OdbcConnection conn = null;

            try
            {
                List<object> parametros;
                string sql = snt.Snt_ConstruirSqlHistorico(
                    tipoMovimiento, idAlmacen, idEstado,
                    usarRangoFechas, fechaInicio, fechaFin,
                    ordenarPor, out parametros
                );

                conn = cnx.conexion();

                if (conn == null || conn.State != ConnectionState.Open)
                {
                    throw new Exception("No se pudo establecer la conexión ODBC.");
                }

                OdbcCommand cmd = new OdbcCommand(sql, conn);

                foreach (var param in parametros)
                {
                    cmd.Parameters.Add(new OdbcParameter(null, param));
                }

                OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                // Tirar el error para que el Controlador lo atrape.
                throw new Exception("Error en Capa Modelo: " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    cnx.desconexion(conn);
                }
            }
            return dt;
        }

        private DataTable Mdl_EjecutarConsultaSimple(string sql)
        {
            DataTable dt = new DataTable();
            OdbcConnection conn = null;
            try
            {
                conn = cnx.conexion();
                OdbcCommand cmd = new OdbcCommand(sql, conn);
                OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                // Lanza el error para que el Controlador lo atrape
                throw new Exception("Error en Modelo al ejecutar consulta: " + ex.Message);
            }
            finally
            {
                if (conn != null) cnx.desconexion(conn);
            }
            return dt;
        }

        // --- MÉTODOS PÚBLICOS PARA CARGAR COMBOS ---

        public DataTable Mdl_CargarAlmacenes()
        {
            // Llama a la sentencia que creamos en el paso 1
            string sql = snt.Snt_CargarAlmacenes();
            return Mdl_EjecutarConsultaSimple(sql);
        }

        public DataTable Mdl_CargarEstadosProducto()
        {
            // Llama a la sentencia que creamos en el paso 1
            string sql = snt.Snt_CargarEstadosProducto();
            return Mdl_EjecutarConsultaSimple(sql);
        }

        // (Agrega estos métodos DENTRO de tu clase Cls_Modelo_Inventario)

        // Para el ComboBox (Error 1)
        public DataTable Mdl_CargarTiposMovimiento()
        {
            string sql = snt.Snt_CargarTiposMovimiento();
            // Reutilizamos el método de consulta simple que ya tenías
            return Mdl_EjecutarConsultaSimple(sql);
        }

        // Para el DGV al inicio (Error 2)
        public DataTable Mdl_CargarHistoricoDefault()
        {
            string sql = snt.Snt_CargarHistoricoDefault();
            return Mdl_EjecutarConsultaSimple(sql);
        }

        public DataTable Mdl_CargarTodosLosCierres()
        {
            string sql = snt.Snt_CargarTodosLosCierres();
            return Mdl_EjecutarConsultaSimple(sql);
        }

    }
}