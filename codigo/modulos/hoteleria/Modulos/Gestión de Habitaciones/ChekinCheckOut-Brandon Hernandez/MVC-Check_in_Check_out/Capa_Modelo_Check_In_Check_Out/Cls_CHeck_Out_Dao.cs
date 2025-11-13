using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Capa_Modelo_Check_In_Check_Out
{
    public class Cls_Check_Out_Dao
    {
        private readonly Cls_Conexion prConexion = new Cls_Conexion();

        // Obtiene los Check-In disponibles para realizar Check-Out
        public DataTable fun_Obtener_CheckIn()
        {
            DataTable dtResultado = new DataTable();
            try
            {
                using (OdbcConnection conn = prConexion.conexion())
                {
                    string sQuery = @"
                        SELECT 
                            CI.Pk_Id_Check_in,
                            H.Cmp_Nombre AS Nombre_Huesped,
                            CI.Cmp_Fecha_Check_In
                        FROM Tbl_Check_In CI
                        INNER JOIN Tbl_Huesped H ON CI.Fk_Id_Huesped = H.Pk_Id_Huesped
                        WHERE CI.Cmp_Estado IN ('Activo', 'En curso');";

                    using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(dtResultado);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener Check-Ins disponibles: " + ex.Message);
            }
            return dtResultado;
        }

        // Muestra todos los Check-Out registrados
        public DataTable fun_Mostrar_CheckOut()
        {
            DataTable dtResultado = new DataTable();
            try
            {
                using (OdbcConnection conn = prConexion.conexion())
                {
                    string sQuery = @"
                        SELECT 
                            CO.Pk_Id_Check_out,
                            CO.Fk_Id_Check_In,
                            H.Cmp_Nombre AS Nombre_Huesped,
                            CI.Cmp_Fecha_Check_In,
                            CO.Cmp_Fecha_Check_Out
                        FROM Tbl_Check_Out CO
                        INNER JOIN Tbl_Check_In CI ON CO.Fk_Id_Check_In = CI.Pk_Id_Check_in
                        INNER JOIN Tbl_Huesped H ON CI.Fk_Id_Huesped = H.Pk_Id_Huesped
                        ORDER BY CO.Pk_Id_Check_out DESC;";

                    using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(dtResultado);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar Check-Outs: " + ex.Message);
            }
            return dtResultado;
        }

        // Inserta un nuevo registro de Check-Out
        public bool bInsertar_CheckOut(Cls_Check_Out clsCheckOut)
        {
            try
            {
                using (OdbcConnection conn = prConexion.conexion())
                {
                    string sQuery = "INSERT INTO Tbl_Check_Out (Fk_Id_Check_In, Cmp_Fecha_Check_Out) VALUES (?, ?)";
                    using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", clsCheckOut.iFk_Id_CheckIn);
                        cmd.Parameters.AddWithValue("?", clsCheckOut.dCmp_Fecha_CheckOut);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar Check-Out: " + ex.Message);
                return false;
            }
        }

        // Actualiza un registro de Check-Out
        public bool bActualizar_CheckOut(Cls_Check_Out clsCheckOut)
        {
            try
            {
                using (OdbcConnection conn = prConexion.conexion())
                {
                    string sQuery = "UPDATE Tbl_Check_Out SET Fk_Id_Check_In = ?, Cmp_Fecha_Check_Out = ? WHERE Pk_Id_Check_out = ?";
                    using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", clsCheckOut.iFk_Id_CheckIn);
                        cmd.Parameters.AddWithValue("?", clsCheckOut.dCmp_Fecha_CheckOut);
                        cmd.Parameters.AddWithValue("?", clsCheckOut.iPk_Id_CheckOut);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar Check-Out: " + ex.Message);
                return false;
            }
        }

        // Elimina un registro de Check-Out
        public bool bEliminar_CheckOut(int iIdCheckOut, out string sMensajeError)
        {
            sMensajeError = "";
            try
            {
                using (OdbcConnection conn = prConexion.conexion())
                {
                    string sQuery = "DELETE FROM Tbl_Check_Out WHERE Pk_Id_Check_out = ?";
                    using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", iIdCheckOut);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                sMensajeError = "Error al eliminar Check-Out: " + ex.Message;
                return false;
            }
        }
    }
}
