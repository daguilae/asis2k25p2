using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Check_In_Check_Out
{
    public class Cls_CHeck_Out_Dao
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        public DataTable datObtenerCheckIn()
        {
            DataTable dt = new DataTable();
            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    string query = @"
                        SELECT 
                            CI.Pk_Id_Check_in,
                            H.Cmp_Nombre AS Nombre_Huesped,
                            CI.Cmp_Fecha_Check_In
                        FROM Tbl_Check_in CI
                        INNER JOIN Tbl_Huesped H ON CI.Fk_Id_Huesped = H.Pk_Id_Huesped
                        WHERE CI.Cmp_Estado IN ('Activo', 'En curso');";

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al obtener Check-Ins disponibles: " + ex.Message);
            }
            return dt;
        }

        public DataTable bMostrarCheckOut()
        {
            DataTable dt = new DataTable();
            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    string query = @"
                        SELECT 
                            CO.Pk_Id_Check_out,
                            CO.Fk_Id_Check_In,                         -- 🔹 esta columna es CLAVE
                            H.Cmp_Nombre AS Nombre_Huesped,
                            CI.Cmp_Fecha_Check_In,
                            CO.Cmp_Fecha_Check_Out
                        FROM Tbl_Check_out CO
                        INNER JOIN Tbl_Check_in CI ON CO.Fk_Id_Check_In = CI.Pk_Id_Check_in
                        INNER JOIN Tbl_Huesped H ON CI.Fk_Id_Huesped = H.Pk_Id_Huesped
                        ORDER BY CO.Pk_Id_Check_out DESC;";

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al mostrar Check-Outs: " + ex.Message);
            }
            return dt;
        }


        public bool bInsertarCheckOut(Cls_Check_Out checkOut)
        {
            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    string query = "INSERT INTO Tbl_Check_out (Fk_Id_Check_In, Cmp_Fecha_Check_Out) VALUES (?, ?)";
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", checkOut.iFk_Id_CheckIn);
                        cmd.Parameters.AddWithValue("?", checkOut.dCmp_Fecha_CheckOut);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al insertar Check-Out: " + ex.Message);
                return false;
            }
        }

        public bool bActualizarCheckOut(Cls_Check_Out checkOut)
        {
            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    string query = "UPDATE Tbl_Check_out SET Fk_Id_Check_In = ?, Cmp_Fecha_Check_Out = ? WHERE Pk_Id_Check_out = ?";
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", checkOut.iFk_Id_CheckIn);
                        cmd.Parameters.AddWithValue("?", checkOut.dCmp_Fecha_CheckOut);
                        cmd.Parameters.AddWithValue("?", checkOut.iPk_Id_CheckOut);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al actualizar Check-Out: " + ex.Message);
                return false;
            }
        }

        
        public bool bEliminarCheckOut(int idCheckOut, out string mensajeError)
        {
            mensajeError = string.Empty;
            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    string query = "DELETE FROM Tbl_Check_out WHERE Pk_Id_Check_out = ?";
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", idCheckOut);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                mensajeError = "Error al eliminar Check-Out: " + ex.Message;
                return false;
            }
        }
    }
}
