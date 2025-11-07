using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Cierre
{
    public class Cls_Cierre_DiarioDAO
    {
        private Cls_Conexion conexion = new Cls_Conexion();

        // OBTENER FOLIOS (Habitaciones y Salones) por fecha
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
                (f.Cmp_Total_Cargos - f.Cmp_Total_Abonos) AS 'Saldo',
                'Habitación' AS 'Tipo_Folio'
            FROM Tbl_Folio f
            WHERE DATE(f.Cmp_Fecha_Cierre) = ?
              AND UPPER(f.Cmp_Estado) = 'CERRADO'
            
            UNION ALL
            
            SELECT 
                fs.Pk_Id_Folio_Salones AS 'ID Folio',
                fs.Cmp_Pago_Total AS 'Ingresos',
                0.00 AS 'Egresos',
                fs.Cmp_Pago_Total AS 'Saldo',
                'Salón' AS 'Tipo_Folio'
            FROM Tbl_Folio_Salones fs
            WHERE DATE(fs.Cmp_Fecha_Pago) = ?
              AND UPPER(fs.Cmp_Estado) = 'PAGADO';
        ";

                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@fecha1", fechaCorte.Date);
                    cmd.Parameters.AddWithValue("@fecha2", fechaCorte.Date);

                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error al obtener folios: " + ex.Message);
            }

            return tabla;
        }

        // 🔹 CALCULAR TOTALES AUTOMÁTICAMENTE (Habitaciones + Salones)
        public (double ingresos, double egresos, double saldo) CalcularTotales(DateTime fechaCorte)
        {
            double ingresosHabitaciones = 0, egresosHabitaciones = 0, ingresosSalones = 0;
            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    // Folios de habitaciones
                    string sqlHabitaciones = @"SELECT IFNULL(SUM(Cmp_Total_Cargos),0), IFNULL(SUM(Cmp_Total_Abonos),0)
                                              FROM Tbl_Folio
                                              WHERE DATE(Cmp_Fecha_Cierre) = ? AND UPPER(Cmp_Estado) = 'CERRADO';";
                    using (OdbcCommand cmdHab = new OdbcCommand(sqlHabitaciones, conn))
                    {
                        cmdHab.Parameters.AddWithValue("@fechaH", fechaCorte.Date);
                        using (var dr = cmdHab.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                ingresosHabitaciones = dr.IsDBNull(0) ? 0 : dr.GetDouble(0);
                                egresosHabitaciones = dr.IsDBNull(1) ? 0 : dr.GetDouble(1);
                            }
                        }
                    }

                    // Folios de salones
                    string sqlSalones = @"SELECT IFNULL(SUM(Cmp_Pago_Total),0)
                                          FROM Tbl_Folio_Salones
                                          WHERE DATE(Cmp_Fecha_Pago) = ? AND UPPER(Cmp_Estado) = 'PAGADO';";
                    using (OdbcCommand cmdSal = new OdbcCommand(sqlSalones, conn))
                    {
                        cmdSal.Parameters.AddWithValue("@fechaS", fechaCorte.Date);
                        using (var dr = cmdSal.ExecuteReader())
                        {
                            if (dr.Read())
                                ingresosSalones = dr.IsDBNull(0) ? 0 : dr.GetDouble(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error al calcular totales: " + ex.Message);
            }

            double ingresos = ingresosHabitaciones + ingresosSalones;
            double egresos = egresosHabitaciones;
            double saldo = ingresos - egresos;
            return (ingresos, egresos, saldo);
        }

        // INSERTAR ENCABEZADO DEL CIERRE
        public int InsertarCierre(DateTime fechaCorte, string descripcion, double ingresos, double egresos, double saldo)
        {
            int idCierre = -1;

            try
            {
                string sqlInsert = @"
            INSERT INTO Tbl_Cierre_Diario 
            (Cmp_Fecha_Corte, Cmp_Descripcion, Cmp_Total_Ingresos, Cmp_Total_Egresos, Cmp_Saldo_Final)
            VALUES (?, ?, ?, ?, ?);";

                string sqlLastId = "SELECT LAST_INSERT_ID();";

                using (OdbcConnection conn = conexion.conexion())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@fechaCorte", fechaCorte);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@ingresos", ingresos);
                        cmd.Parameters.AddWithValue("@egresos", egresos);
                        cmd.Parameters.AddWithValue("@saldo", saldo);
                        cmd.ExecuteNonQuery();
                    }

                    // Recuperar el ID generado
                    using (OdbcCommand cmdLast = new OdbcCommand(sqlLastId, conn))
                    {
                        object result = cmdLast.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                            idCierre = id;
                    }
                }

                Console.WriteLine($"✅ Cierre insertado correctamente: ID={idCierre}, Ingresos={ingresos}, Egresos={egresos}, Saldo={saldo}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error al insertar cierre: " + ex.Message);
            }

            return idCierre;
        }

        // INSERTAR DETALLE (Habitaciones y Salones)
        public void InsertarDetalle(int idCierre, int idFolio, string tipoFolio)
        {
            try
            {
                string tablaDestino = tipoFolio == "Salón" ? "Tbl_Detalle_Cierre_Salones" : "Tbl_Detalle_Cierre_Diario";
                string campoFolio = tipoFolio == "Salón" ? "Fk_Id_Folio_Salon" : "Fk_Id_Folio";

                string sql = $@"
                    INSERT INTO {tablaDestino} (Fk_Id_Cierre, {campoFolio})
                    VALUES (?, ?);
                ";

                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idCierre", idCierre);
                    cmd.Parameters.AddWithValue("@idFolio", idFolio);
                    cmd.ExecuteNonQuery();
                }

                // Actualizar estado según tipo
                if (tipoFolio == "Habitación")
                    ActualizarEstadoFolio(idFolio, "ASIGNADO AL CIERRE");
                else if (tipoFolio == "Salón")
                    ActualizarEstadoFolioSalon(idFolio, "ASIGNADO AL CIERRE");
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ Error al insertar detalle de cierre: " + ex.Message);
            }
        }

        //ACTUALIZAR ESTADO DE FOLIOS
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
                Console.WriteLine("⚠️ Error al actualizar folio habitación: " + ex.Message);
            }
        }

        private void ActualizarEstadoFolioSalon(int idFolioSalon, string nuevoEstado)
        {
            try
            {
                string sql = "UPDATE Tbl_Folio_Salones SET Cmp_Estado = ? WHERE Pk_Id_Folio_Salones = ?;";
                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@folio", idFolioSalon);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ Error al actualizar folio salón: " + ex.Message);
            }
        }

        // OBTENER LISTA DE CIERRES
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
                    ORDER BY Cmp_Fecha_Corte ASC;
                ";

                using (OdbcConnection conn = conexion.conexion())
                using (OdbcDataAdapter da = new OdbcDataAdapter(sql, conn))
                {
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ Error al obtener lista de cierres: " + ex.Message);
            }
            return tabla;
        }

        //OBTENER DETALLE COMPLETO (Habitaciones + Salones)
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
                        'Habitación' AS 'Tipo_Folio',
                        cd.Pk_Id_Cierre AS 'ID_Cierre',
                        DATE_FORMAT(cd.Cmp_Fecha_Corte, '%d/%m/%Y') AS 'Fecha_Cierre'
                    FROM Tbl_Detalle_Cierre_Diario d
                    INNER JOIN Tbl_Folio f ON d.Fk_Id_Folio = f.Pk_Id_Folio
                    INNER JOIN Tbl_Cierre_Diario cd ON d.Fk_Id_Cierre = cd.Pk_Id_Cierre
                    WHERE d.Fk_Id_Cierre = ?
                    
                    UNION ALL
                    
                    SELECT 
                        ds.Pk_Id_Detalle_Salon AS 'ID Detalle',
                        fs.Pk_Id_Folio_Salones AS 'ID Folio',
                        fs.Cmp_Pago_Total AS 'Ingresos',
                        0 AS 'Egresos',
                        fs.Cmp_Pago_Total AS 'Saldo',
                        'Salón' AS 'Tipo_Folio',
                        cd.Pk_Id_Cierre AS 'ID_Cierre',
                        DATE_FORMAT(cd.Cmp_Fecha_Corte, '%d/%m/%Y') AS 'Fecha_Cierre'
                    FROM Tbl_Detalle_Cierre_Salones ds
                    INNER JOIN Tbl_Folio_Salones fs ON ds.Fk_Id_Folio_Salon = fs.Pk_Id_Folio_Salones
                    INNER JOIN Tbl_Cierre_Diario cd ON ds.Fk_Id_Cierre = cd.Pk_Id_Cierre
                    WHERE ds.Fk_Id_Cierre = ?;
                ";

                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idCierre1", idCierre);
                    cmd.Parameters.AddWithValue("@idCierre2", idCierre);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ Error al obtener detalle completo del cierre: " + ex.Message);
            }
            return tabla;
        }

        // OBTENER ENCABEZADO DEL CIERRE
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
                Console.WriteLine("⚠️ Error al obtener encabezado del cierre: " + ex.Message);
            }
            return null;
        }


        // ELIMINAR CIERRE (y sus detalles en cascada)
        public bool EliminarCierre(int idCierre)
        {
            try
            {
                string sql = "DELETE FROM Tbl_Cierre_Diario WHERE Pk_Id_Cierre = ?;";

                using (OdbcConnection conn = conexion.conexion())
                using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idCierre", idCierre);
                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        Console.WriteLine($"✅ Cierre ID {idCierre} eliminado correctamente (con detalles).");
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error al eliminar cierre: " + ex.Message);
            }

            return false;
        }

    }
}