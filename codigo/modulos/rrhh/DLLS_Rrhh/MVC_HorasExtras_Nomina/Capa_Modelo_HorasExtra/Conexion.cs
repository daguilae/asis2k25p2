// Nombre: Diego Andre Monterroso Rabarique
// Carné: 0901-22-1369
// Fecha de modificación: 2025-11-09
// Descripción: Lógica de negocio para CRUD de Horas_Extras.

using System.Data.Odbc;

namespace Capa_Modelo_HorasExtra
{
    public class Conexion
    {
        // USANDO TU DSN CONFIGURADO
        private string connectionString = "DSN=bd_nomina;";

        private OdbcConnection conexion;

        public OdbcConnection ConexionDB()
        {
            try
            {
                if (conexion == null)
                    conexion = new OdbcConnection(connectionString);

                if (conexion.State != System.Data.ConnectionState.Open)
                    conexion.Open();

                return conexion;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error de conexión ODBC: " + ex.Message);
                return null;
            }
        }

        public void CerrarConexion()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}