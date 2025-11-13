using System;
using System.Data;
using System.Data.Odbc;
using System.Text;
using System.Windows.Forms;

namespace Capa_Modelo_Check_In_Check_Out
{
    public class Cls_AreaDAO
    {
        private readonly Cls_Conexion prConexion = new Cls_Conexion();

        // CONSULTAS BASE SQL
      
        private const string SQL_SELECT_ALL = @"
            SELECT 
                Pk_Id_Area,
                Fk_Id_Folio,
                Cmp_Nombre_Area,
                Cmp_Descripcion,
                Cmp_Tipo_Movimiento,
                Cmp_Monto,
                Cmp_Fecha_Movimiento
            FROM Tbl_Area
            ORDER BY Pk_Id_Area DESC;";

        private const string SQL_INSERT = @"
            INSERT INTO Tbl_Area 
                (Fk_Id_Folio, Cmp_Nombre_Area, Cmp_Descripcion, Cmp_Tipo_Movimiento, Cmp_Monto, Cmp_Fecha_Movimiento)
            VALUES (?, ?, ?, ?, ?, ?);";

        private const string SQL_UPDATE = @"
            UPDATE Tbl_Area SET
                Fk_Id_Folio = ?,
                Cmp_Nombre_Area = ?,
                Cmp_Descripcion = ?,
                Cmp_Tipo_Movimiento = ?,
                Cmp_Monto = ?,
                Cmp_Fecha_Movimiento = ?
            WHERE Pk_Id_Area = ?;";

        private const string SQL_DELETE = "DELETE FROM Tbl_Area WHERE Pk_Id_Area = ?;";

        // OBTENER DATOS
        
        public DataTable fun_Obtener_Folios()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = @"
                SELECT 
                    F.Pk_Id_Folio,
                    CONCAT(
                        'Folio: ', F.Pk_Id_Folio,
                        ' | Huésped: ', H.Cmp_Nombre, ' ', H.Cmp_Apellido,
                        ' | Habitación: ', HA.Pk_Id_Habitaciones,
                        ' | Fecha Check-In: ', I.Cmp_Fecha_Check_In
                    ) AS DescripcionFolio
                FROM Tbl_Folio F
                INNER JOIN Tbl_Check_In I ON F.Fk_Id_Check_In = I.Pk_Id_Check_in
                INNER JOIN Tbl_Huesped H ON I.Fk_Id_Huesped = H.Pk_Id_Huesped
                INNER JOIN Tbl_Habitaciones HA ON F.Fk_Id_Habitacion = HA.Pk_Id_Habitaciones
                ORDER BY F.Pk_Id_Folio DESC;";

            try
            {
                using (OdbcConnection conn = prConexion.conexion())
                using (OdbcDataAdapter da = new OdbcDataAdapter(sQuery, conn))
                {
                    da.Fill(dtResultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener folios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtResultado;
        }

        public DataTable fun_Obtener_Areas()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = @"
                SELECT 
                    Pk_Id_Area,
                    Cmp_Nombre_Area,
                    Cmp_Descripcion,
                    Cmp_Tipo_Movimiento,
                    Cmp_Monto,
                    Cmp_Fecha_Movimiento,
                    CONCAT(
                        'ID: ', Pk_Id_Area,
                        ' | Nombre: ', Cmp_Nombre_Area,
                        ' | Tipo: ', Cmp_Tipo_Movimiento,
                        ' | Monto: ', Cmp_Monto
                    ) AS DescripcionArea
                FROM Tbl_Area
                ORDER BY Pk_Id_Area DESC;";

            try
            {
                using (OdbcConnection conn = prConexion.conexion())
                using (OdbcDataAdapter da = new OdbcDataAdapter(sQuery, conn))
                {
                    da.Fill(dtResultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener áreas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtResultado;
        }

        public DataTable fun_Mostrar_Areas()
        {
            DataTable dtResultado = new DataTable();
            try
            {
                using (OdbcConnection conn = prConexion.conexion())
                using (OdbcDataAdapter da = new OdbcDataAdapter(SQL_SELECT_ALL, conn))
                {
                    da.Fill(dtResultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar áreas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtResultado;
        }



        public bool bInsertar_Area(Cls_Area clsArea)
        {
            using (OdbcConnection conn = prConexion.conexion())
            {
                try
                {
                    using (OdbcCommand cmd = new OdbcCommand(SQL_INSERT, conn))
                    {
                        cmd.Parameters.Add("Fk_Id_Folio", OdbcType.Int).Value = clsArea.iFk_Id_Folio;
                        cmd.Parameters.Add("Cmp_Nombre_Area", OdbcType.VarChar, 50).Value = clsArea.sCmp_Nombre_Area;
                        cmd.Parameters.Add("Cmp_Descripcion", OdbcType.VarChar, 50).Value = clsArea.sCmp_Descripcion;
                        cmd.Parameters.Add("Cmp_Tipo_Movimiento", OdbcType.VarChar, 50).Value = clsArea.sCmp_Tipo_Movimiento;
                        cmd.Parameters.Add("Cmp_Monto", OdbcType.Double).Value = clsArea.dCmp_Monto;
                        cmd.Parameters.Add("Cmp_Fecha_Movimiento", OdbcType.VarChar).Value = clsArea.dCmp_Fecha_Movimiento.ToString("yyyy-MM-dd HH:mm:ss");

                        int iFilas = cmd.ExecuteNonQuery();
                        return iFilas > 0;
                    }
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(fun_Formatear_Error("INSERT", ex), "Error INSERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool bActualizar_Area(Cls_Area clsArea)
        {
            using (OdbcConnection conn = prConexion.conexion())
            {
                try
                {
                    using (OdbcCommand cmd = new OdbcCommand(SQL_UPDATE, conn))
                    {
                        cmd.Parameters.Add("Fk_Id_Folio", OdbcType.Int).Value = clsArea.iFk_Id_Folio;
                        cmd.Parameters.Add("Cmp_Nombre_Area", OdbcType.VarChar, 50).Value = clsArea.sCmp_Nombre_Area ?? "";
                        cmd.Parameters.Add("Cmp_Descripcion", OdbcType.VarChar, 50).Value = clsArea.sCmp_Descripcion ?? "";
                        cmd.Parameters.Add("Cmp_Tipo_Movimiento", OdbcType.VarChar, 50).Value = clsArea.sCmp_Tipo_Movimiento ?? "";
                        cmd.Parameters.Add("Cmp_Monto", OdbcType.Double).Value = clsArea.dCmp_Monto;
                        cmd.Parameters.Add("Cmp_Fecha_Movimiento", OdbcType.VarChar).Value = clsArea.dCmp_Fecha_Movimiento.ToString("yyyy-MM-dd HH:mm:ss");
                        cmd.Parameters.Add("Pk_Id_Area", OdbcType.Int).Value = clsArea.iPk_Id_Area;

                        int iFilas = cmd.ExecuteNonQuery();
                        return iFilas > 0;
                    }
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(fun_Formatear_Error("UPDATE", ex), "Error UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool bEliminar_Area(int iIdArea, out string sMensajeError)
        {
            sMensajeError = "";
            using (OdbcConnection conn = prConexion.conexion())
            {
                try
                {
                    using (OdbcCommand cmd = new OdbcCommand(SQL_DELETE, conn))
                    {
                        cmd.Parameters.Add("Pk_Id_Area", OdbcType.Int).Value = iIdArea;
                        int iFilas = cmd.ExecuteNonQuery();
                        return iFilas > 0;
                    }
                }
                catch (OdbcException ex)
                {
                    sMensajeError = ex.Message;
                    MessageBox.Show(fun_Formatear_Error("DELETE", ex), "Error DELETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private string fun_Formatear_Error(string sOperacion, OdbcException ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Error {sOperacion} en Tbl_Area:");
            sb.AppendLine("Mensaje: " + ex.Message);
            if (ex.Errors.Count > 0)
            {
                sb.AppendLine("Estado SQL: " + ex.Errors[0].SQLState);
                sb.AppendLine("Número: " + ex.Errors[0].NativeError);
            }
            sb.AppendLine("Origen: " + ex.Source);
            return sb.ToString();
        }
    }
}
