using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Diego André Monterroso Rabarique 0901-22-1369
namespace Capa_Modelo_Componente_Consultas
{
    public class Sentencias
    {
        Conexion con = new Conexion();

        // Obtiene todas las tablas de la base de datos bd_hoteleria
        public DataTable fun_ObtenerTablas()
        {
            DataTable dt = new DataTable();
            try
            {
                using (OdbcConnection conexion = con.conexion())
                {
                    string query = "SHOW TABLES;";
                    OdbcDataAdapter da = new OdbcDataAdapter(query, conexion);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener tablas: " + ex.Message);
            }
            return dt;
        }

        // Ejecuta un SELECT dinámico según la tabla y ordenamiento
        public DataTable fun_EjecutarConsulta(string stabla, string sorden = "")
        {
            DataTable dt = new DataTable();
            try
            {
                using (OdbcConnection conexion = con.conexion())
                {
                    string query = $"SELECT * FROM {stabla} {sorden};";
                    OdbcDataAdapter da = new OdbcDataAdapter(query, conexion);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar consulta: " + ex.Message);
            }
            return dt;
        }

        // Jose Pablo Medina 0901-22-22592
        // ✅ Ejecuta consulta con filtro global (busca en todas las columnas)
        public DataTable fun_EjecutarConsultaConFiltro(string stabla, string sfiltro = "", string sorden = "")
        {
            DataTable dt = new DataTable();
            try
            {
                using (OdbcConnection conexion = con.conexion())
                {
                    string query = $"SELECT * FROM {stabla}";

                    if (!string.IsNullOrWhiteSpace(sfiltro))
                    {
                        // Obtener los nombres de las columnas de la tabla
                        OdbcCommand cmdCols = new OdbcCommand($"SHOW COLUMNS FROM {stabla};", conexion);
                        OdbcDataReader reader = cmdCols.ExecuteReader();

                        List<string> columnas = new List<string>();
                        while (reader.Read())
                            columnas.Add(reader.GetString(0)); // nombre de columna

                        reader.Close();

                        // Crear condiciones tipo: col1 LIKE '%texto%' OR col2 LIKE '%texto%'
                        List<string> condiciones = new List<string>();
                        foreach (string col in columnas)
                        {
                            condiciones.Add($"{col} LIKE '%{sfiltro.Replace("'", "''")}%'");
                        }

                        query += " WHERE " + string.Join(" OR ", condiciones);
                    }

                    if (!string.IsNullOrWhiteSpace(sorden))
                        query += $" {sorden}";

                    query += ";";

                    OdbcDataAdapter da = new OdbcDataAdapter(query, conexion);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar consulta con filtro: " + ex.Message);
            }
            return dt;
        }



    }


}
