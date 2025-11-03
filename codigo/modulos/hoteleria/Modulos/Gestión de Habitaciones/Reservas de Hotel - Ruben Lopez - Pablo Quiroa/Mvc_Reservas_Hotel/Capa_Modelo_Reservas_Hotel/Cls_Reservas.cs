using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Reservas_Hotel
{
    public class Cls_Reserva
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        // ==================== FORM REGISTRO ====================
        public DataTable ObtenerHabitaciones()
        {
            string sSql = @"
                SELECT 
                    PK_ID_Habitaciones AS IdHabitacion,
                    Cmp_Descripcion_Habitacion AS Descripcion,
                    Cmp_Tarifa_Noche AS Tarifa
                FROM tbl_habitaciones
                WHERE Cmp_Estado_Habitacion = 1
                ORDER BY PK_ID_Habitaciones;";

            using (var conn = conexion.conexion())
            using (var da = new OdbcDataAdapter(sSql, conn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ObtenerBuffetData()
        {
            string sSql2 = @"
                SELECT Pk_Id_Buffet, Cmp_Tipo_Buffet, Cmp_Descripcion
                FROM Tbl_Buffet
                WHERE Cmp_Incluido_En_Reserva = 1
                ORDER BY Pk_Id_Buffet
                LIMIT 1;";

            using (var conn = conexion.conexion())
            using (var da = new OdbcDataAdapter(sSql2, conn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ObtenerHuespedData(string tipoDoc, string numero)
        {
            string sSql3 = @"SELECT * 
                           FROM Tbl_Huesped 
                           WHERE Cmp_Tipo_Documento = ? AND Cmp_Numero_Documento = ?;";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql3, conn))
            using (var da = new OdbcDataAdapter(cmd))
            {
                cmd.Parameters.Add(null, OdbcType.VarChar, 20).Value = tipoDoc;
                cmd.Parameters.Add(null, OdbcType.VarChar, 25).Value = numero;

                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int ObtenerPuntosHuesped(int idHuesped)
        {
            string sSql4 = @"SELECT Cmp_Puntos_Acumulados 
                           FROM Tbl_Puntos_Huesped 
                           WHERE Fk_Id_Huesped = ?;";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql4, conn))
            {
                cmd.Parameters.Add(null, OdbcType.Int).Value = idHuesped;
                object result = cmd.ExecuteScalar();
                return (result == null || result == DBNull.Value) ? 0 : Convert.ToInt32(result);
            }
        }

        public void InsertarReserva(int iDHuesped, int iDHabitacion, int iDBuffet,
                                    DateTime dDechaEntrada, DateTime dFechaSalida,
                                    int iNumHuespedes, string sPeticiones, string sEstado, decimal dTotal)
        {
            string sSql5 = @"
                INSERT INTO Tbl_Reserva 
                (Fk_Id_Huesped, Fk_Id_Habitacion, Fk_Id_Buffet,
                 Cmp_Fecha_Reserva, Cmp_Fecha_Entrada, Cmp_Fecha_Salida,
                 Cmp_Num_Huespedes, Cmp_Peticiones_Especiales,
                 Cmp_Estado_Reserva, Cmp_Total_Reserva)
                VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?);";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql5, conn))
            {
                cmd.Parameters.Add(null, OdbcType.Int).Value = iDHuesped;
                cmd.Parameters.Add(null, OdbcType.Int).Value = iDHabitacion;
                cmd.Parameters.Add(null, OdbcType.Int).Value = iDBuffet;
                cmd.Parameters.Add(null, OdbcType.Date).Value = DateTime.Now.Date;
                cmd.Parameters.Add(null, OdbcType.Date).Value = dDechaEntrada.Date;
                cmd.Parameters.Add(null, OdbcType.Date).Value = dFechaSalida.Date;
                cmd.Parameters.Add(null, OdbcType.Int).Value = iNumHuespedes;
                cmd.Parameters.Add(null, OdbcType.VarChar, 255).Value = sPeticiones ?? string.Empty;
                cmd.Parameters.Add(null, OdbcType.VarChar, 20).Value = string.IsNullOrWhiteSpace(sEstado) ? "Pendiente" : sEstado;
                cmd.Parameters.Add(null, OdbcType.Decimal).Value = dTotal;

                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarPuntosHuesped(int iDHuesped, int iPuntosRestantes)
        {
            string sSql6 = @"UPDATE Tbl_Puntos_Huesped 
                           SET Cmp_Puntos_Acumulados = ? 
                           WHERE Fk_Id_Huesped = ?;";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql6, conn))
            {
                cmd.Parameters.Add(null, OdbcType.Int).Value = iPuntosRestantes;
                cmd.Parameters.Add(null, OdbcType.Int).Value = iDHuesped;
                cmd.ExecuteNonQuery();
            }
        }

        // ==================== FORM MODIFICAR ====================
        public DataTable BuscarReservas(string sFiltro)
        {
            string sSql7 = @"
                SELECT 
                    r.Pk_Id_Reserva,
                    h.Pk_Id_Huesped,
                    h.Cmp_Numero_Documento AS Documento,
                    CONCAT(h.Cmp_Nombre,' ',h.Cmp_Apellido) AS Huesped,
                    r.Fk_Id_Habitacion,
                    r.Cmp_Fecha_Entrada,
                    r.Cmp_Fecha_Salida,
                    r.Cmp_Num_Huespedes,
                    r.Cmp_Peticiones_Especiales,
                    r.Cmp_Estado_Reserva,
                    r.Cmp_Total_Reserva
                FROM tbl_reserva r
                JOIN tbl_huesped h ON h.Pk_Id_Huesped = r.Fk_Id_Huesped
                WHERE h.Cmp_Numero_Documento LIKE ?
                   OR CONCAT(h.Cmp_Nombre,' ',h.Cmp_Apellido) LIKE ?
                ORDER BY r.Pk_Id_Reserva DESC;";

            string patron = $"%{sFiltro?.Trim() ?? string.Empty}%";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql7, conn))
            using (var da = new OdbcDataAdapter(cmd))
            {
                cmd.Parameters.Add(null, OdbcType.VarChar, 100).Value = patron;
                cmd.Parameters.Add(null, OdbcType.VarChar, 100).Value = patron;

                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public decimal ObtenerTarifaHabitacion(int idHabitacion)
        {
            string sSql8 = @"SELECT Cmp_Tarifa_Noche 
                           FROM tbl_habitaciones
                           WHERE PK_ID_Habitaciones = ?;";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql8, conn))
            {
                cmd.Parameters.Add(null, OdbcType.Int).Value = idHabitacion;
                object val = cmd.ExecuteScalar();
                return (val == null || val == DBNull.Value) ? 0m : Convert.ToDecimal(val);
            }
        }

        public void ActualizarReserva(int iDReserva, int iDHabitacion, DateTime dFechaEntrada, DateTime dFechaSalida,
                              int iNumHuespedes, string sPeticiones, string sEstado, decimal dTotal)
        {
            string sql = @"
        UPDATE tbl_reserva
        SET Fk_Id_Habitacion = ?,
            Cmp_Fecha_Entrada = ?,
            Cmp_Fecha_Salida  = ?,
            Cmp_Num_Huespedes = ?,
            Cmp_Peticiones_Especiales = ?,
            Cmp_Estado_Reserva = ?,
            Cmp_Total_Reserva  = ?
        WHERE Pk_Id_Reserva = ?;";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sql, conn))
            {
                sPeticiones = (sPeticiones ?? "").Trim();
                if (sPeticiones.Length > 255) sPeticiones = sPeticiones.Substring(0, 255);

                if (string.IsNullOrWhiteSpace(sEstado)) sEstado = "Pendiente";

                cmd.Parameters.Add(null, OdbcType.Int).Value = iDHabitacion;
                cmd.Parameters.Add(null, OdbcType.DateTime).Value = dFechaEntrada;
                cmd.Parameters.Add(null, OdbcType.DateTime).Value = dFechaSalida;
                cmd.Parameters.Add(null, OdbcType.Int).Value = iNumHuespedes;
                cmd.Parameters.Add(null, OdbcType.VarChar, 255).Value = sPeticiones;
                cmd.Parameters.Add(null, OdbcType.VarChar, 20).Value = sEstado;
                cmd.Parameters.Add(null, OdbcType.Double).Value = Convert.ToDouble(dTotal); // ✅ CORRECCIÓN
                cmd.Parameters.Add(null, OdbcType.Int).Value = iDReserva;

                cmd.ExecuteNonQuery();
            }
        }


    }
}
