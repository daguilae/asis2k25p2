using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace Capa_Modelo_GesHab
{
    class Cls_Dao_Habitaciones
    {
        Cls_conexionMYSQL conexion = new Cls_conexionMYSQL();

        public void pro_CambiarEstadoHabitacion(int idHabitacion)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                conn.Open();

                // Primero obtenemos el estado actual
                string sQuerySelect = "SELECT Cmp_Estado_Habitacion FROM Tbl_Habitaciones WHERE PK_ID_Habitaciones = ?;";
                bool estadoActual;

                using (OdbcCommand cmdSelect = new OdbcCommand(sQuerySelect, conn))
                {
                    cmdSelect.Parameters.AddWithValue("@id", idHabitacion);
                    object result = cmdSelect.ExecuteScalar();

                    if (result == null)
                    {
                        Console.WriteLine("No se encontró la habitación con ID: " + idHabitacion);
                        return;
                    }

                    estadoActual = Convert.ToBoolean(result);
                }

                // Invertimos el estado
                bool nuevoEstado = !estadoActual;

                // Luego actualizamos el campo con el nuevo estado
                string sQueryUpdate = "UPDATE Tbl_Habitaciones SET Cmp_Estado_Habitacion = ? WHERE PK_ID_Habitaciones = ?;";
                using (OdbcCommand cmdUpdate = new OdbcCommand(sQueryUpdate, conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@estado", nuevoEstado);
                    cmdUpdate.Parameters.AddWithValue("@id", idHabitacion);

                    int filasAfectadas = cmdUpdate.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        Console.WriteLine($"Estado de la habitación {idHabitacion} cambiado a {(nuevoEstado ? "ACTIVA" : "INACTIVA")} correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se pudo actualizar el estado.");
                    }
                }

                conexion.desconexion(conn);
            }
        }

        // Método que obtiene todas las habitaciones con estado 0 y devuelve un DataTable
        public DataTable fun_ObtenerHabitacionesDisponibles()
        {
            DataTable dtHabitaciones = new DataTable();

            using (OdbcConnection conn = conexion.conexion())
            {
                conn.Open();

                string sQuery = "SELECT * FROM Tbl_Habitaciones WHERE Cmp_Estado_Habitacion = 0;";

                using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                {
                    da.Fill(dtHabitaciones);
                }

                conexion.desconexion(conn);
            }

            return dtHabitaciones;
        }
    }
}
