using System;
using System.Data.Odbc;
using System.Data;
namespace Capa_Modelo_Check_In_Check_Out
{
    public class Cls_Detalle_Folio_DAO
    {
        private readonly Cls_Conexion prConexion = new Cls_Conexion();
        public DataTable datObtenerFolios()
        {
            string sQuery = @"
        SELECT
            f.Pk_Id_Folio,
            CONCAT(
                'Folio #', f.Pk_Id_Folio,
                ' - Habitación ', f.Fk_Id_Habitacion,
                ' (', f.Cmp_Estado, ')'
            ) AS DescripcionFolio
        FROM Tbl_Folio f
        ORDER BY f.Pk_Id_Folio DESC;";

            using (OdbcConnection conn = prConexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
            using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        public DataTable datObtenerDatosCliente(int iIdFolio)
        {
            // LEFT JOIN por si en algún caso faltara algún vínculo, pero si todo es obligatorio puedes usar INNER JOIN
            string sQuery = @"
                SELECT 
                    f.Pk_Id_Folio,
                    CONCAT(h.Cmp_Nombre, ' ', h.Cmp_Apellido)            AS NombreCompleto,
                    h.Cmp_Numero_Documento                               AS NumeroDocumento,
                    COALESCE(r.Fk_Id_Habitacion, f.Fk_Id_Habitacion)     AS NumeroHabitacion,
                    f.Cmp_Fecha_Creacion                                 AS FechaCreacion,
                    f.Cmp_Estado
                FROM Tbl_Folio f
                LEFT JOIN Tbl_Check_In ci   ON f.Fk_Id_Check_In = ci.Pk_Id_Check_in
                LEFT JOIN Tbl_Reserva  r    ON ci.Fk_Id_Reserva = r.Pk_Id_Reserva
                LEFT JOIN Tbl_Huesped  h    ON r.Fk_Id_Huesped = h.Pk_Id_Huesped
                WHERE f.Pk_Id_Folio = ?;";

            using (OdbcConnection conn = prConexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("?", iIdFolio);

                using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable datObtenerMovimientos(int iIdFolio)
        {
            string sQuery = @"
                SELECT
                    a.Cmp_Nombre_Area      AS Area,
                    a.Cmp_Descripcion      AS Descripcion,
                    a.Cmp_Tipo_Movimiento  AS TipoMovimiento,   -- 'Cargo' o 'Abono'
                    a.Cmp_Monto            AS Monto,
                    a.Cmp_Fecha_Movimiento AS Fecha
                FROM Tbl_Detalle_Folio df
                INNER JOIN Tbl_Area a ON df.Fk_Id_Area = a.Pk_Id_Area
                WHERE df.Fk_Id_Folio = ? 
                  AND df.Cmp_Estado = 'Activo'
                ORDER BY a.Cmp_Fecha_Movimiento ASC, a.Pk_Id_Area ASC;";

            using (OdbcConnection conn = prConexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("?", iIdFolio);

                using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable datObtenerTotales(int iIdFolio)
        {
            string sQuery = @"
                SELECT
                    COALESCE(SUM(CASE WHEN a.Cmp_Tipo_Movimiento = 'Cargo' THEN a.Cmp_Monto END), 0) AS TotalCargos,
                    COALESCE(SUM(CASE WHEN a.Cmp_Tipo_Movimiento = 'Abono' THEN a.Cmp_Monto END), 0) AS TotalAbonos,
                    COALESCE(
                        SUM(CASE WHEN a.Cmp_Tipo_Movimiento = 'Cargo' THEN a.Cmp_Monto END), 0
                    ) - COALESCE(
                        SUM(CASE WHEN a.Cmp_Tipo_Movimiento = 'Abono' THEN a.Cmp_Monto END), 0
                    ) AS Saldo
                FROM Tbl_Detalle_Folio df
                INNER JOIN Tbl_Area a ON df.Fk_Id_Area = a.Pk_Id_Area
                WHERE df.Fk_Id_Folio = ?
                  AND df.Cmp_Estado = 'Activo';";

            using (OdbcConnection conn = prConexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("?", iIdFolio);

                using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // (Opcional) Si deseas sincronizar los totales en Tbl_Folio
        public void funActualizarTotalesEnFolio(int iIdFolio)
        {
            // Calculamos primero
            DataTable tots = datObtenerTotales(iIdFolio);
            decimal cargos = 0, abonos = 0, saldo = 0;

            if (tots.Rows.Count > 0)
            {
                cargos = Convert.ToDecimal(tots.Rows[0]["TotalCargos"]);
                abonos = Convert.ToDecimal(tots.Rows[0]["TotalAbonos"]);
                saldo = Convert.ToDecimal(tots.Rows[0]["Saldo"]);
            }

            string sUpdate = @"
                UPDATE Tbl_Folio
                SET Cmp_Total_Cargos = ?, 
                    Cmp_Total_Abonos = ?, 
                    Cmp_Saldo_Final  = ?
                WHERE Pk_Id_Folio = ?;";

            using (OdbcConnection conn = prConexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sUpdate, conn))
            {
                cmd.Parameters.AddWithValue("?", cargos);
                cmd.Parameters.AddWithValue("?", abonos);
                cmd.Parameters.AddWithValue("?", saldo);
                cmd.Parameters.AddWithValue("?", iIdFolio);
                cmd.ExecuteNonQuery();
            }
        }
    }
}


