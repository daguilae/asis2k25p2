
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Capa_Modelo_Check_In_Check_Out
{
    public class Cls_Check_In_Dao
    {

        private readonly Cls_Conexion prConexion = new Cls_Conexion();


        private static readonly string SQL_SELECT = @"
            SELECT 
                Pk_Id_Check_in, 
                Fk_Id_Huesped, 
                Fk_Id_Reserva, 
                Cmp_Fecha_Check_In, 
                Cmp_Estado
            FROM Tbl_Check_In";

        private static readonly string SQL_INSERT = @"
            INSERT INTO Tbl_Check_In 
                (Fk_Id_Huesped, Fk_Id_Reserva, Cmp_Fecha_Check_In, Cmp_Estado)
            VALUES (?, ?, ?, ?)";

        private static readonly string SQL_UPDATE = @"
            UPDATE Tbl_Check_In SET
                Fk_Id_Huesped = ?, 
                Fk_Id_Reserva = ?, 
                Cmp_Fecha_Check_In = ?, 
                Cmp_Estado = ?
            WHERE Pk_Id_Check_in = ?";

        private static readonly string SQL_DELETE =
            "DELETE FROM Tbl_Check_In WHERE Pk_Id_Check_in = ?";

        private static readonly string SQL_QUERY = @"
            SELECT 
                Pk_Id_Check_in, 
                Fk_Id_Huesped, 
                Fk_Id_Reserva, 
                Cmp_Fecha_Check_In, 
                Cmp_Estado
            FROM Tbl_Check_In 
            WHERE Pk_Id_Check_in = ?";


        public int fun_Obtener_Habitacion_Por_Reserva(int iIdReserva)
        {
            int iIdHabitacion = 0;
            string sQuery = "SELECT Fk_Id_Habitacion FROM Tbl_Reserva WHERE Pk_Id_Reserva = ?";

            using (OdbcConnection conn = prConexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                {
                    cmd.Parameters.AddWithValue("?", iIdReserva);
                    object oResultado = cmd.ExecuteScalar();

                    if (oResultado != null && oResultado != DBNull.Value)
                        iIdHabitacion = Convert.ToInt32(oResultado);
                }
            }
            return iIdHabitacion;
        }


        public DataTable fun_Obtener_Huespedes()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = @"
                SELECT 
                    Pk_Id_Huesped, 
                    CONCAT(Pk_Id_Huesped, ' - ', Cmp_Nombre, ' ', Cmp_Apellido) AS NombreCompleto
                FROM Tbl_Huesped";

            using (OdbcConnection conn = prConexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
            using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
            {
                da.Fill(dtResultado);
            }
            return dtResultado;
        }


        public DataTable fun_Obtener_Reserva_Por_Huesped(int iIdHuesped, int? iIdReservaActual = null)
        {
            DataTable dtResultado = new DataTable();

            string sQuery = @"
                SELECT 
                    Pk_Id_Reserva, 
                    CONCAT('Reserva #', Pk_Id_Reserva, ' - ',
                           DATE_FORMAT(Cmp_Fecha_Entrada, '%d/%m/%Y'),
                           ' (', Cmp_Estado_Reserva, ')') AS DescripcionReserva
                FROM Tbl_Reserva
                WHERE Fk_Id_Huesped = ?";

            if (iIdReservaActual == null)
            {
                sQuery += " AND Cmp_Estado_Reserva = 'Confirmada'";
            }
            else
            {
                sQuery += " AND (Cmp_Estado_Reserva = 'Confirmada' OR Pk_Id_Reserva = ?)";
            }

            using (OdbcConnection conn = prConexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("?", iIdHuesped);

                if (iIdReservaActual != null)
                    cmd.Parameters.AddWithValue("?", iIdReservaActual);

                using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                {
                    da.Fill(dtResultado);
                }
            }

            return dtResultado;
        }


        public bool bInsertar_CheckIn(Cls_CheckIn clsCheckIn)
        {
            using (OdbcConnection conn = prConexion.conexion())
            {
                try
                {
                    using (OdbcCommand cmd = new OdbcCommand(SQL_INSERT, conn))
                    {
                        cmd.Parameters.AddWithValue("", clsCheckIn.iFk_Id_Huesped);
                        cmd.Parameters.AddWithValue("", clsCheckIn.iFk_Id_Reserva);
                        cmd.Parameters.AddWithValue("", clsCheckIn.dCmp_Fecha_CheckIn);
                        cmd.Parameters.AddWithValue("", clsCheckIn.sCmp_Estado);

                        int iFilas = cmd.ExecuteNonQuery();
                        return iFilas > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar Check-In: " + ex.Message,
                        "Error de Inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


        public bool bActualizar_CheckIn(Cls_CheckIn clsCheckIn)
        {
            using (OdbcConnection conn = prConexion.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(SQL_UPDATE, conn))
                {
                    cmd.Parameters.AddWithValue("?", clsCheckIn.iFk_Id_Huesped);
                    cmd.Parameters.AddWithValue("?", clsCheckIn.iFk_Id_Reserva);
                    cmd.Parameters.AddWithValue("?", clsCheckIn.dCmp_Fecha_CheckIn);
                    cmd.Parameters.AddWithValue("?", clsCheckIn.sCmp_Estado);
                    cmd.Parameters.AddWithValue("?", clsCheckIn.iPk_Id_CheckIn);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


        public bool bEliminar_CheckIn(int iPk_Id_CheckIn, out string sMensajeError)
        {
            sMensajeError = "";

            try
            {
                using (OdbcConnection conn = prConexion.conexion())
                {
                    using (OdbcCommand cmd = new OdbcCommand(SQL_DELETE, conn))
                    {
                        cmd.Parameters.AddWithValue("?", iPk_Id_CheckIn);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (OdbcException ex)
            {
                if (ex.Message.Contains("a foreign key constraint fails"))
                {
                    sMensajeError = "No es posible eliminar el Check-In porque está vinculado a otras tablas (por ejemplo, Check-Out o Pagos).";
                }
                else
                {
                    sMensajeError = "Error al eliminar el Check-In: " + ex.Message;
                }
                return false;
            }
        }


        public DataTable fun_Mostrar_CheckIn()
        {
            DataTable dtResultado = new DataTable();

            string sQuery = @"
                SELECT
                    C.Pk_Id_Check_in,
                    C.Fk_Id_Huesped,
                    C.Fk_Id_Reserva,
                    H.Cmp_Nombre AS Nombre_Huesped,
                    H.Cmp_Apellido AS Apellido_Huesped,
                    R.Cmp_Fecha_Entrada AS Fecha_Reserva,
                    C.Cmp_Fecha_Check_In,
                    C.Cmp_Estado
                FROM Tbl_Check_In C
                INNER JOIN Tbl_Huesped H ON C.Fk_Id_Huesped = H.Pk_Id_Huesped
                INNER JOIN Tbl_Reserva R ON C.Fk_Id_Reserva = R.Pk_Id_Reserva;";

            using (OdbcConnection conn = prConexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
            using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
            {
                da.Fill(dtResultado);
            }

            return dtResultado;
        }

        
    }
}
