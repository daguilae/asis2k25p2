using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;


namespace Capa_Modelo_Cierre
{
    public class Cls_Cierre_DiarioDAO
    {
        private Cls_Conexion conexion = new Cls_Conexion();

        // ======================================================
        //OBTENER FOLIOS CERRADOS POR FECHA (para GENERAR cierre)
        public DataTable ObtenerFoliosPorFecha(DateTime fechaCorte)
        {
            DataTable tabla = new DataTable();
            try
            {
                string query = @"
                    SELECT 
                        f.Pk_Id_Folio AS 'ID Folio',
                        f.Cmp_Total_Cargos AS 'Ingresos',
                        f.Cmp_Total_Abonos AS 'Egresos',
                        (f.Cmp_Total_Cargos - f.Cmp_Total_Abonos) AS 'Saldo'
                    FROM Tbl_Folio f
                    WHERE DATE(f.Cmp_Fecha_Cierre) = ?
                      AND f.Cmp_Estado = 'CERRADO';";

                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@fechaCorte", fechaCorte.Date);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener folios: " + ex.Message);
            }
            return tabla;
        }

        // CALCULAR TOTALES AUTOMÁTICAMENTE (INGRESOS, EGRESOS, SALDO)
        public (double ingresos, double egresos, double saldo) CalcularTotales(DateTime fechaCorte)
        {
            double ingresos = 0, egresos = 0, saldo = 0;

            try
            {
                string sql = @"
                    SELECT 
                        IFNULL(SUM(Cmp_Total_Cargos),0),
                        IFNULL(SUM(Cmp_Total_Abonos),0)
                    FROM Tbl_Folio
                    WHERE DATE(Cmp_Fecha_Cierre) = ?
                      AND Cmp_Estado = 'CERRADO';";

                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@fechaCorte", fechaCorte.Date);
                    using (OdbcDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            ingresos = dr.GetDouble(0);
                            egresos = dr.GetDouble(1);
                            saldo = ingresos - egresos;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error al calcular totales: " + ex.Message);
            }

            return (ingresos, egresos, saldo);
        }

        //INSERTAR ENCABEZADO DEL CIERRE DIARIO
        public int InsertarCierre(DateTime fechaCorte, string descripcion, double ingresos, double egresos, double saldo)
        {
            int idCierre = -1;
            try
            {
                string sql = @"
            INSERT INTO Tbl_Cierre_Diario 
            (Cmp_Fecha_Corte, Cmp_Descripcion, Cmp_Total_Ingresos, Cmp_Total_Egresos, Cmp_Saldo_Final)
            VALUES (?, ?, ?, ?, ?);";

                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@fechaCorte", fechaCorte);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@ingresos", ingresos);
                    cmd.Parameters.AddWithValue("@egresos", egresos);
                    cmd.Parameters.AddWithValue("@saldo", saldo);
                    cmd.ExecuteNonQuery();

                    // Obtener ID autogenerado
                    cmd.CommandText = "SELECT LAST_INSERT_ID();";
                    idCierre = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error al insertar cierre: " + ex.Message);
            }
            return idCierre;
        }

        //INSERTAR DETALLE DE CIERRE (folios del día)
        public void InsertarDetalle(int idCierre, int idFolio, double monto)
        {
            try
            {
                string sql = @"
                    INSERT INTO Tbl_Detalle_Cierre_Diario 
                    (Fk_Id_Cierre, Fk_Id_Folio, Cmp_Monto_Folio)
                    VALUES (?, ?, ?);";

                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idCierre", idCierre);
                    cmd.Parameters.AddWithValue("@idFolio", idFolio);
                    cmd.Parameters.AddWithValue("@monto", monto);
                    cmd.ExecuteNonQuery();
                }

                //(Opcional) Actualizar estado del folio a “ASIGNADO AL CIERRE”
                ActualizarEstadoFolio(idFolio, "ASIGNADO AL CIERRE");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error al insertar detalle: " + ex.Message);
            }
        }

        // 🔹 ACTUALIZAR ESTADO DEL FOLIO (opcional)
        private void ActualizarEstadoFolio(int idFolio, string nuevoEstado)
        {
            try
            {
                string sql = "UPDATE Tbl_Folio SET Cmp_Estado = ? WHERE Pk_Id_Folio = ?;";
                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@folio", idFolio);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ Error al actualizar estado del folio: " + ex.Message);
            }

        }

        // OBTENER LISTA DE CIERRES (para ComboBox con formato personalizado)
        public DataTable ObtenerListaCierres()
        {
            DataTable tabla = new DataTable();
            try
            {
                string sql = @"
            SELECT 
                Pk_Id_Cierre AS 'ID_Cierre',
                DATE_FORMAT(Cmp_Fecha_Corte, '%d/%m/%Y') AS 'Fecha_Corte',
                Cmp_Descripcion AS 'Descripcion',
                CONCAT(Pk_Id_Cierre, ' - ', DATE_FORMAT(Cmp_Fecha_Corte, '%d/%m/%Y')) AS 'Etiqueta'
            FROM Tbl_Cierre_Diario
            ORDER BY Cmp_Fecha_Corte DESC;";

                using (OdbcConnection conn = conexion.conexion())
                using (OdbcDataAdapter da = new OdbcDataAdapter(sql, conn))
                {
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener lista de cierres: " + ex.Message);
            }
            return tabla;
        }

        // 🔹 OBTENER DETALLE DE UN CIERRE SELECCIONADO
        public DataTable ObtenerDetalleCierre(int idCierre)
        {
            DataTable tabla = new DataTable();
            try
            {
                string sql = @"
            SELECT 
                d.Pk_Id_Detalle AS 'ID Detalle',
                f.Pk_Id_Folio AS 'ID Folio',
                f.Cmp_Total_Cargos AS 'Ingresos',
                f.Cmp_Total_Abonos AS 'Egresos',
                f.Cmp_Saldo_Final AS 'Saldo',
                d.Cmp_Monto_Folio AS 'Monto Detalle'
            FROM Tbl_Detalle_Cierre_Diario d
            INNER JOIN Tbl_Folio f ON d.Fk_Id_Folio = f.Pk_Id_Folio
            WHERE d.Fk_Id_Cierre = ?;";

                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idCierre", idCierre);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ Error al obtener detalle del cierre: " + ex.Message);
            }
            return tabla;
        }

        //OBTENER ENCABEZADO DE CIERRE (fecha y descripción)
        public (DateTime fecha, string descripcion)? ObtenerEncabezadoCierre(int idCierre)
        {
            try
            {
                string sql = @"SELECT Cmp_Fecha_Corte, Cmp_Descripcion FROM Tbl_Cierre_Diario WHERE Pk_Id_Cierre = ?;";
                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idCierre", idCierre);
                    using (OdbcDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            var fecha = dr.GetDateTime(0);
                            var descripcion = dr.IsDBNull(1) ? string.Empty : dr.GetString(1);
                            return (fecha, descripcion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠Error al obtener encabezado del cierre: " + ex.Message);
            }
            return null;
        }
    }
}