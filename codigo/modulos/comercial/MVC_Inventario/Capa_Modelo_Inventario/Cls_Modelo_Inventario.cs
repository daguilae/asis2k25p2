using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Inventario
{
    // ==================== Stevens Cambranes 01/11/2025 ====================
    // ==================== Clase Modelo Inventario ====================
    // (Esta clase ejecuta la lógica de BD. Habla con Cls_Conexion y Cls_Sentencias)
    public class Cls_Modelo_Inventario
    {
        // (Instancia de la clase de Conexión a BD)
        private Cls_Conexion cnx;
        // (Instancia de la clase de Sentencias SQL)
        private Cls_Sentencias_Inventario snt;

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Constructor ====================
        // (Inicializa las clases de conexión y sentencias)
        public Cls_Modelo_Inventario()
        {
            cnx = new Cls_Conexion();
            snt = new Cls_Sentencias_Inventario();
        }

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Obtener Histórico (Movimientos) ====================
        // (Ejecuta la consulta SQL dinámica para buscar movimientos con filtros)
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
            OdbcConnection conn = null; // Objeto de conexión

            try
            {
                // Pide a la clase de sentencias que construya el SQL
                List<object> parametros;
                string sql = snt.Snt_ConstruirSqlHistorico(
                    tipoMovimiento, idAlmacen, idEstado,
                    usarRangoFechas, fechaInicio, fechaFin,
                    ordenarPor, out parametros
                );

                // Abre la conexión
                conn = cnx.conexion();

                if (conn == null || conn.State != ConnectionState.Open)
                {
                    throw new Exception("No se pudo establecer la conexión ODBC.");
                }

                // Prepara el comando ODBC con el SQL y la conexión
                OdbcCommand cmd = new OdbcCommand(sql, conn);

                // Agrega los parámetros (ej: @fechaInicio) a la consulta
                foreach (var param in parametros)
                {
                    cmd.Parameters.Add(new OdbcParameter(null, param));
                }

                // Ejecuta la consulta y llena el DataTable
                OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                // Lanza el error para que el Controlador lo atrape
                throw new Exception("Error en Capa Modelo (Mdl_ObtenerHistorico): " + ex.Message);
            }
            finally
            {
                // Cierra la conexión, haya o no haya error
                if (conn != null)
                {
                    cnx.desconexion(conn);
                }
            }
            return dt; // Devuelve los datos
        }

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Ejecutar Consulta Simple (Privado) ====================
        // (Método reutilizable para ejecutar consultas SQL simples que no llevan parámetros)
        private DataTable Mdl_EjecutarConsultaSimple(string sql)
        {
            DataTable dt = new DataTable();
            OdbcConnection conn = null;
            try
            {
                conn = cnx.conexion();
                OdbcCommand cmd = new OdbcCommand(sql, conn);
                OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                adapter.Fill(dt); // Llena la tabla con los resultados
            }
            catch (Exception ex)
            {
                // Lanza el error para que el Controlador lo atrape
                throw new Exception("Error en Modelo al ejecutar consulta simple: " + ex.Message);
            }
            finally
            {
                // Cierra la conexión
                if (conn != null) cnx.desconexion(conn);
            }
            return dt;
        }

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Cargar ComboBox Almacenes ====================
        // (Obtiene los almacenes de la BD para el ComboBox)
        public DataTable Mdl_CargarAlmacenes()
        {
            // Pide la sentencia SQL
            string sql = snt.Snt_CargarAlmacenes();
            // Ejecuta la consulta simple
            return Mdl_EjecutarConsultaSimple(sql);
        }

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Cargar ComboBox Estados ====================
        // (Obtiene los estados de producto de la BD para el ComboBox)
        public DataTable Mdl_CargarEstadosProducto()
        {
            // Pide la sentencia SQL
            string sql = snt.Snt_CargarEstadosProducto();
            // Ejecuta la consulta simple
            return Mdl_EjecutarConsultaSimple(sql);
        }

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Cargar ComboBox Tipo Movimiento ====================
        // (Obtiene los tipos de movimiento de la BD para el ComboBox)
        public DataTable Mdl_CargarTiposMovimiento()
        {
            // Pide la sentencia SQL
            string sql = snt.Snt_CargarTiposMovimiento();
            // Ejecuta la consulta simple
            return Mdl_EjecutarConsultaSimple(sql);
        }

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Cargar DGV por Defecto ====================
        // (Obtiene los 100 movimientos más recientes para el DGV)
        public DataTable Mdl_CargarHistoricoDefault()
        {
            // Pide la sentencia SQL
            string sql = snt.Snt_CargarHistoricoDefault();
            // Ejecuta la consulta simple
            return Mdl_EjecutarConsultaSimple(sql);
        }

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Cargar Todos los Cierres ====================
        // (Obtiene TODOS los cierres (resúmenes) de la BD)
        public DataTable Mdl_CargarTodosLosCierres()
        {
            // Pide la sentencia SQL
            string sql = snt.Snt_CargarTodosLosCierres();
            // Ejecuta la consulta simple
            return Mdl_EjecutarConsultaSimple(sql);
        }

    }
}