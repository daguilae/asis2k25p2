using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_CxP
{
    public class Cls_Sentencias_CxP_Pagos
    {
        Cls_Conexion cn = new Cls_Conexion();

        // =====================================================
        // 1) FACTURAS PENDIENTES PARA EL FORMULARIO DE PAGOS
        // =====================================================
        public DataTable FacturasPendientes_Listar()
        {
            DataTable tabla = new DataTable();
            OdbcConnection conn = cn.conexion();

            string sql = @"
                SELECT 
                    d.Cmp_Id_CxP_Documento,
                    d.Cmp_Id_Proveedor,
                    p.Cmp_Nombre_Proveedor,
                    d.Cmp_Serie,
                    d.Cmp_Numero,
                    d.Cmp_Total_Documento,
                    d.Cmp_Saldo_Pendiente,
                    CONCAT(
                        p.Cmp_Nombre_Proveedor, ' | ',
                        d.Cmp_Serie, '-', d.Cmp_Numero,
                        ' | Saldo: Q', FORMAT(d.Cmp_Saldo_Pendiente, 2)
                    ) AS FacturaTexto
                FROM Tbl_CxP_Documento d
                INNER JOIN Tbl_Proveedor p
                    ON p.Cmp_Id_Proveedor = d.Cmp_Id_Proveedor
                WHERE d.Cmp_Saldo_Pendiente > 0
                ORDER BY d.Cmp_Fecha_Vencimiento;";

            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }
            catch (Exception)
            {
            }
            finally
            {
                cn.desconexion(conn);
            }

            return tabla;
        }

        // =====================================================
        // 2) REGISTRAR UN PAGO SIMPLE
        // =====================================================
        public void Pago_RegistrarSimple(
            int idDocumento,
            int idProveedor,
            decimal monto,
            DateTime fechaPago,
            int idUsuario,
            int idMetodoPago
        )
        {
            OdbcConnection conn = cn.conexion();
            OdbcTransaction tx = conn.BeginTransaction();

            try
            {
                int idPago = 0;

                // 2.1 Encabezado del pago
                string sqlPago = @"
                    INSERT INTO Tbl_Pago_Proveedor
                        (Cmp_Id_Proveedor, Cmp_Fecha_Pago, Cmp_Total_Pago, Cmp_Observaciones, Cmp_Id_Usuario)
                    VALUES
                        (?,?,?,?,?);";

                using (OdbcCommand cmd = new OdbcCommand(sqlPago, conn, tx))
                {
                    cmd.Parameters.AddWithValue("@p1", idProveedor);
                    cmd.Parameters.AddWithValue("@p2", fechaPago);
                    cmd.Parameters.AddWithValue("@p3", monto);
                    cmd.Parameters.AddWithValue("@p4", "Pago desde sistema CxP");
                    cmd.Parameters.AddWithValue("@p5", idUsuario);
                    cmd.ExecuteNonQuery();
                }

                // 2.2 Obtener ID del pago
                using (OdbcCommand cmdId = new OdbcCommand("SELECT LAST_INSERT_ID();", conn, tx))
                {
                    idPago = Convert.ToInt32(cmdId.ExecuteScalar());
                }

                // 2.3 Método de pago
                string sqlDet = @"
                    INSERT INTO Tbl_Pago_Proveedor_Det
                        (Cmp_Id_Pago_Proveedor, Cmp_Id_Metodo_Pago, Cmp_Monto)
                    VALUES
                        (?,?,?);";

                using (OdbcCommand cmdDet = new OdbcCommand(sqlDet, conn, tx))
                {
                    cmdDet.Parameters.AddWithValue("@p1", idPago);
                    cmdDet.Parameters.AddWithValue("@p2", idMetodoPago);
                    cmdDet.Parameters.AddWithValue("@p3", monto);
                    cmdDet.ExecuteNonQuery();
                }

                // 2.4 Aplicación a la factura
                string sqlApl = @"
                    INSERT INTO Tbl_Pago_Proveedor_Aplicacion
                        (Cmp_Id_Pago_Proveedor, Cmp_Id_CxP_Documento, Cmp_Monto_Aplicado)
                    VALUES
                        (?,?,?);";

                using (OdbcCommand cmdApl = new OdbcCommand(sqlApl, conn, tx))
                {
                    cmdApl.Parameters.AddWithValue("@p1", idPago);
                    cmdApl.Parameters.AddWithValue("@p2", idDocumento);
                    cmdApl.Parameters.AddWithValue("@p3", monto);
                    cmdApl.ExecuteNonQuery();
                }

                // 2.5 Actualizar saldo del documento
                string sqlUpd = @"
                    UPDATE Tbl_CxP_Documento
                    SET 
                        Cmp_Saldo_Pendiente = Cmp_Saldo_Pendiente - ?,
                        Cmp_Estado = CASE 
                            WHEN Cmp_Saldo_Pendiente - ? <= 0 THEN 'Pagado'
                            ELSE 'Parcial'
                        END
                    WHERE Cmp_Id_CxP_Documento = ?;";

                using (OdbcCommand cmdUpd = new OdbcCommand(sqlUpd, conn, tx))
                {
                    cmdUpd.Parameters.AddWithValue("@p1", monto);
                    cmdUpd.Parameters.AddWithValue("@p2", monto);
                    cmdUpd.Parameters.AddWithValue("@p3", idDocumento);
                    cmdUpd.ExecuteNonQuery();
                }

                tx.Commit();
            }
            catch (Exception)
            {
                tx.Rollback();
                throw;
            }
            finally
            {
                cn.desconexion(conn);
            }
        }

        // =====================================================
        // 3) HISTORIAL DE PAGOS (PARA Frm_CxP_Pagos_Historial)
        // =====================================================
        public DataTable Pagos_Historial(DateTime? desde, DateTime? hasta, string orden)
        {
            DataTable tabla = new DataTable();
            OdbcConnection conn = cn.conexion();

            string sql = @"
        SELECT 
            p.Cmp_Id_Pago_Proveedor   AS IdPago,
            p.Cmp_Fecha_Pago          AS FechaPago,
            pr.Cmp_Nombre_Proveedor   AS Proveedor,
            p.Cmp_Total_Pago          AS TotalPago,
            p.Cmp_Observaciones       AS Observaciones,
            u.Cmp_NombreUsuario       AS Usuario
        FROM Tbl_Pago_Proveedor p
        INNER JOIN Tbl_Proveedor pr
            ON pr.Cmp_Id_Proveedor = p.Cmp_Id_Proveedor
        INNER JOIN Tbl_Usuario u
            ON u.Cmp_IdUsuario = p.Cmp_Id_Usuario
        WHERE 1 = 1
    ";

            OdbcCommand cmd = new OdbcCommand();
            cmd.Connection = conn;

            // Filtros de fecha
            if (desde.HasValue)
            {
                sql += " AND p.Cmp_Fecha_Pago >= ? ";
                cmd.Parameters.AddWithValue("@pDesde", desde.Value);
            }

            if (hasta.HasValue)
            {
                sql += " AND p.Cmp_Fecha_Pago <= ? ";
                cmd.Parameters.AddWithValue("@pHasta", hasta.Value);
            }

            // Orden
            switch (orden)
            {
                case "FechaAsc":
                    sql += " ORDER BY p.Cmp_Fecha_Pago ASC";
                    break;
                case "MontoDesc":
                    sql += " ORDER BY p.Cmp_Total_Pago DESC";
                    break;
                case "MontoAsc":
                    sql += " ORDER BY p.Cmp_Total_Pago ASC";
                    break;
                default:            // "FechaDesc" o vacío
                    sql += " ORDER BY p.Cmp_Fecha_Pago DESC";
                    break;
            }

            cmd.CommandText = sql;

            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(tabla);
            }
            catch (Exception)
            {
                // Puedes poner un MessageBox aquí si quieres ver el error
                // MessageBox.Show("Error al cargar historial: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }

            return tabla;
        }

    }
}
