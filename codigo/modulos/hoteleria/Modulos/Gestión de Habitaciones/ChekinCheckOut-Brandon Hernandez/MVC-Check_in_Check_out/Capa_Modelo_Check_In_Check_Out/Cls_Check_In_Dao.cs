using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Capa_Modelo_Check_In_Check_Out
{
    public class Cls_Check_In_Dao
    {
       

        private static readonly string SQL_SELECT = @"
            SELECT 
                Pk_Id_Check_in, 
                Fk_Id_Huesped, 
                Fk_Id_Reserva, 
                Cmp_Fecha_Check_In, 
                Cmp_Estado
            FROM Tbl_Check_in";

        private static readonly string SQL_INSERT = @"
            INSERT INTO Tbl_Check_in 
                (Fk_Id_Huesped, Fk_Id_Reserva, Cmp_Fecha_Check_In, Cmp_Estado)
            VALUES (?, ?, ?, ?)";

        private static readonly string SQL_UPDATE = @"
        UPDATE Tbl_Check_in SET
            Fk_Id_Huesped = ?, 
            Fk_Id_Reserva = ?, 
            Cmp_Fecha_Check_In = ?, 
            Cmp_Estado = ?
        WHERE Pk_Id_Check_in = ?";

        private static readonly string SQL_DELETE =
            "DELETE FROM Tbl_Check_in WHERE Pk_Id_Check_in = ?";

        private static readonly string SQL_QUERY = @"
        SELECT 
            Pk_Id_Check_in, 
            Fk_Id_Huesped, 
            Fk_Id_Reserva, 
            Cmp_Fecha_Check_In, 
            Cmp_Estado
        FROM Tbl_Check_in 
        WHERE Pk_Id_Check_in = ?";

        private Cls_Conexion conexion = new Cls_Conexion();
        public int ObtenerHabitacionPorReserva(int idReserva)
        {
            int idHabitacion = 0;

            string query = "SELECT Fk_Id_Habitacion FROM Tbl_Reserva WHERE Pk_Id_Reserva = ?";

            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", idReserva);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                        idHabitacion = Convert.ToInt32(result);
                }
            }

            return idHabitacion;
        }

        public DataTable datObtenerHuespedes()
        {
            DataTable dt = new DataTable();
            string query = @"
        SELECT 
            Pk_Id_Huesped, 
            CONCAT(Pk_Id_Huesped, ' - ', Cmp_Nombre, ' ', Cmp_Apellido) AS NombreCompleto
        FROM Tbl_Huesped";
            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(dt); // Llena el DataTable con los datos de usuarios
                    }
                }
            }
            return dt;
        
    }
        public DataTable datObtenerReservaPorHuesped(int idHuesped)
        {
            DataTable dt = new DataTable();
            string query = @"
        SELECT 
            Pk_Id_Reserva, 
            CONCAT('Reserva #', Pk_Id_Reserva, ' - ', DATE_FORMAT(Cmp_Fecha_Entrada, '%d/%m/%Y'), ' (', Cmp_Estado_Reserva, ')') AS DescripcionReserva
        FROM Tbl_Reserva
        WHERE Fk_Id_Huesped = ? AND Cmp_Estado_Reserva = 'Confirmada'";

            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Fk_Id_Huesped", idHuesped);

                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }
     

        public bool bInsertarCheckIn(Cls_CheckIn checkIn)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                try
                {
                    OdbcCommand cmd = new OdbcCommand(SQL_INSERT, conn);
                    cmd.Parameters.AddWithValue("", checkIn.iFk_Id_Huesped);
                    cmd.Parameters.AddWithValue("", checkIn.iFk_Id_Reserva);
                    cmd.Parameters.AddWithValue("", checkIn.dCmp_Fecha_CheckIn);
                    cmd.Parameters.AddWithValue("", checkIn.sCmp_Estado);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar Check-In: " + ex.Message);
                    return false;
                }
            }
        }
                
            
        

         
            public bool bActualizarCheckIn(Cls_CheckIn checkIn)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcCommand cmd = new OdbcCommand(SQL_UPDATE, conn);
                cmd.Parameters.AddWithValue("@Fk_Id_Huesped", checkIn.iFk_Id_Huesped);
                cmd.Parameters.AddWithValue("@Fk_Id_Reserva", checkIn.iFk_Id_Reserva);
                cmd.Parameters.AddWithValue("@Cmp_Fecha_Check_In", checkIn.dCmp_Fecha_CheckIn);
                cmd.Parameters.AddWithValue("@Cmp_Estado", checkIn.sCmp_Estado);
                cmd.Parameters.AddWithValue("@Pk_Id_Check_in", checkIn.iPk_Id_CheckIn);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

       
        public bool bEliminarCheckIn(int pk_Id_CheckIn, out string mensajeError)
        {
            mensajeError = "";
            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    OdbcCommand cmd = new OdbcCommand(SQL_DELETE, conn);
                    cmd.Parameters.AddWithValue("@Pk_Id_Check_in", pk_Id_CheckIn);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (OdbcException ex)
            {
                if (ex.Message.Contains("a foreign key constraint fails"))
                {
                    mensajeError = "No es posible eliminar el Check-In porque está vinculado a otras tablas (por ejemplo, Check-Out o Pagos).";
                }
                else
                {
                    mensajeError = "Error al eliminar el Check-In: " + ex.Message;
                }
                return false;
            }
        }
        
        public DataTable bMostrarCheckIn()
        {
            DataTable dt = new DataTable();

            string SQL_SELECT = @"
     
                  SELECT
        C.Pk_Id_Check_in,
        C.Fk_Id_Huesped,
        C.Fk_Id_Reserva,
        H.Cmp_Nombre AS Nombre_Huesped,
        H.Cmp_Apellido AS Apellido_Huesped,
        R.Cmp_Fecha_Entrada AS Fecha_Reserva,
        C.Cmp_Fecha_Check_In,
        C.Cmp_Estado
    FROM Tbl_Check_in C
    INNER JOIN Tbl_Huesped H ON C.Fk_Id_Huesped = H.Pk_Id_Huesped
    INNER JOIN Tbl_Reserva R ON C.Fk_Id_Reserva = R.Pk_Id_Reserva;";


            using (OdbcConnection conn = conexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(SQL_SELECT, conn))
                {
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

    }

}

