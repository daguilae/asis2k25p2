using System;
using System.Data;
using System.Data.Odbc;
using System.Collections.Generic;

namespace Capa_Modelo_Reservas_Hotel
{
    public class Cls_Reserva
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        private const int PUNTOS_POR_RESERVA = 15;

        // =========================================================
        // ===============   FORM RESERVA (REGISTRO)   =============
        // =========================================================

        public DataTable ObtenerHabitaciones()
        {
            string sSql = @"
                SELECT 
                    PK_ID_Habitaciones AS IdHabitacion,
                    Cmp_Descripcion_Habitacion AS Descripcion,
                    Cmp_Tarifa_Noche AS Tarifa,
                    Cmp_Capacidad_Habitacion AS Capacidad
                FROM `Tbl_Habitaciones`
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
            string sSql = @"
                SELECT Pk_Id_Buffet, Cmp_Tipo_Buffet, Cmp_Descripcion
                FROM `Tbl_Buffet`
                WHERE Cmp_Incluido_En_Reserva = 1
                ORDER BY Pk_Id_Buffet
                LIMIT 1;";

            using (var conn = conexion.conexion())
            using (var da = new OdbcDataAdapter(sSql, conn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ObtenerHuespedData(string tipoDoc, string numero)
        {
            string sSql = @"
                SELECT * 
                FROM `Tbl_Huesped`
                WHERE Cmp_Tipo_Documento = ? AND Cmp_Numero_Documento = ?;";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql, conn))
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
            string sSql = @"
                SELECT Cmp_Puntos_Acumulados 
                FROM `Tbl_Puntos_Huesped`
                WHERE Fk_Id_Huesped = ?;";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql, conn))
            {
                cmd.Parameters.Add(null, OdbcType.Int).Value = idHuesped;
                object result = cmd.ExecuteScalar();
                return (result == null || result == DBNull.Value) ? 0 : Convert.ToInt32(result);
            }
        }

        public int ObtenerCapacidadHabitacion(int idHabitacion)
        {
            string sql = @"SELECT Cmp_Capacidad_Habitacion FROM Tbl_Habitaciones WHERE PK_ID_Habitaciones = ?;";
            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add(null, OdbcType.Int).Value = idHabitacion;
                object result = cmd.ExecuteScalar();
                return (result == null || result == DBNull.Value) ? 0 : Convert.ToInt32(result);
            }
        }

        /// <summary>
        /// Inserta una reserva. Por requerimiento actual:
        /// - Fk_Id_Promociones se envía SIEMPRE NULL
        /// - Si el estado inicial es Confirmada, se acreditan +15 puntos
        /// </summary>
        public void InsertarReserva(int iDHuesped, int iDHabitacion, int iDBuffet, int iNumHuespedes,
                                    DateTime dFechaEntrada, DateTime dFechaSalida,
                                    string sPeticiones, string sEstado, decimal dTotal)
        {
            string sSql = @"
                INSERT INTO `Tbl_Reserva`
                (Fk_Id_Huesped, Fk_Id_Habitacion, Fk_Id_Promociones, Fk_Id_Buffet,
                 Cmp_Fecha_Reserva, Cmp_Fecha_Entrada, Cmp_Fecha_Salida,
                 Cmp_Num_Huespedes, Cmp_Peticiones_Especiales,
                 Cmp_Estado_Reserva, Cmp_Total_Reserva)
                VALUES (?, ?, NULL, ?, ?, ?, ?, ?, ?, ?, ?);";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql, conn))
            {
                // IMPORTANTE: el orden de parámetros debe coincidir EXACTO con los ? del INSERT
                cmd.Parameters.Add(null, OdbcType.Int).Value = iDHuesped;                    // 1
                cmd.Parameters.Add(null, OdbcType.Int).Value = iDHabitacion;                 // 2
                // 3 => NULL (Fk_Id_Promociones)
                cmd.Parameters.Add(null, OdbcType.Int).Value = iDBuffet;                     // 4
                cmd.Parameters.Add(null, OdbcType.Date).Value = DateTime.Now.Date;           // 5 Cmp_Fecha_Reserva
                cmd.Parameters.Add(null, OdbcType.Date).Value = dFechaEntrada.Date;          // 6
                cmd.Parameters.Add(null, OdbcType.Date).Value = dFechaSalida.Date;           // 7
                cmd.Parameters.Add(null, OdbcType.Int).Value = iNumHuespedes;                // 8
                cmd.Parameters.Add(null, OdbcType.VarChar, 255).Value = sPeticiones ?? "";   // 9
                cmd.Parameters.Add(null, OdbcType.VarChar, 20).Value =
                    string.IsNullOrWhiteSpace(sEstado) ? "Pendiente" : sEstado;              // 10

                // Con ODBC: usar Double para DECIMAL/NUMERIC evita errores de conversión
                cmd.Parameters.Add(null, OdbcType.Double).Value = Convert.ToDouble(dTotal);  // 11

                cmd.ExecuteNonQuery();
            }

            // Si se insertó como Confirmada → sumar +15 puntos
            if (sEstado.Equals("Confirmada", StringComparison.OrdinalIgnoreCase))
            {
                AgregarPuntosHuesped(iDHuesped);
            }
        }

        public void ActualizarPuntosHuesped(int iDHuesped, int iPuntosRestantes)
        {
            string sSql = @"
                UPDATE `Tbl_Puntos_Huesped`
                SET Cmp_Puntos_Acumulados = ?,
                    Cmp_Fecha_Ultima_Actualizacion = ?
                WHERE Fk_Id_Huesped = ?;";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql, conn))
            {
                cmd.Parameters.Add(null, OdbcType.Int).Value = iPuntosRestantes;
                cmd.Parameters.Add(null, OdbcType.Date).Value = DateTime.Today;
                cmd.Parameters.Add(null, OdbcType.Int).Value = iDHuesped;
                cmd.ExecuteNonQuery();
            }
        }

        // =========================================================
        // ===============   FORM MODIFICAR RESERVA   ==============
        // =========================================================

        public DataTable BuscarReservas(string sFiltro)
        {
            string sSql = @"
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
                FROM `Tbl_Reserva` r
                JOIN `Tbl_Huesped` h ON h.Pk_Id_Huesped = r.Fk_Id_Huesped
                WHERE h.Cmp_Numero_Documento LIKE ?
                   OR CONCAT(h.Cmp_Nombre,' ',h.Cmp_Apellido) LIKE ?
                ORDER BY r.Pk_Id_Reserva DESC;";

            string patron = $"%{sFiltro?.Trim() ?? ""}%";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql, conn))
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
            string sSql = @"
                SELECT Cmp_Tarifa_Noche
                FROM `Tbl_Habitaciones`
                WHERE PK_ID_Habitaciones = ?;";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sSql, conn))
            {
                cmd.Parameters.Add(null, OdbcType.Int).Value = idHabitacion;
                object val = cmd.ExecuteScalar();
                return (val == null || val == DBNull.Value) ? 0m : Convert.ToDecimal(val);
            }
        }

        /// <summary>
        /// Actualiza la reserva. Si el estado cambia:
        /// - De Confirmada → (Pendiente/Cancelada): resta 15
        /// - De (Pendiente/Cancelada) → Confirmada: suma 15
        /// </summary>
        public void ActualizarReserva(int iDReserva, int iDHabitacion, DateTime dEntrada, DateTime dSalida,
                                      string sPeticiones, string sEstado, decimal dTotal,
                                      string estadoAnterior, int idHuesped)
        {
            string sql = @"
                UPDATE `Tbl_Reserva`
                SET Fk_Id_Habitacion = ?,
                    Cmp_Fecha_Entrada = ?,
                    Cmp_Fecha_Salida  = ?,
                    Cmp_Peticiones_Especiales = ?,
                    Cmp_Estado_Reserva = ?,
                    Cmp_Total_Reserva  = ?
                WHERE Pk_Id_Reserva = ?;";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add(null, OdbcType.Int).Value = iDHabitacion;
                cmd.Parameters.Add(null, OdbcType.Date).Value = dEntrada.Date;
                cmd.Parameters.Add(null, OdbcType.Date).Value = dSalida.Date;
                cmd.Parameters.Add(null, OdbcType.VarChar, 255).Value = sPeticiones ?? "";
                cmd.Parameters.Add(null, OdbcType.VarChar, 20).Value = sEstado;

                // Igual que en INSERT: usar Double para DECIMAL
                cmd.Parameters.Add(null, OdbcType.Double).Value = Convert.ToDouble(dTotal);

                cmd.Parameters.Add(null, OdbcType.Int).Value = iDReserva;
                cmd.ExecuteNonQuery();
            }

            // ==== CONTROL DE PUNTOS POR CAMBIO DE ESTADO ====
            if (!estadoAnterior.Equals(sEstado, StringComparison.OrdinalIgnoreCase))
            {
                if (estadoAnterior == "Confirmada" && sEstado != "Confirmada")
                    RestarPuntosHuesped(idHuesped);
                else if (estadoAnterior != "Confirmada" && sEstado == "Confirmada")
                    AgregarPuntosHuesped(idHuesped);
            }
        }

        // =========================================================
        // ==================   SISTEMA DE PUNTOS   =================
        // =========================================================

        /// <summary>
        /// Suma +15 puntos al huésped.
        /// Requiere que Tbl_Puntos_Huesped tenga UNIQUE(Fk_Id_Huesped).
        /// </summary>
        public void AgregarPuntosHuesped(int idHuesped)
        {
            int puntosActuales = ObtenerPuntosHuesped(idHuesped);
            int nuevos = puntosActuales + PUNTOS_POR_RESERVA;

            string sql = @"
                INSERT INTO Tbl_Puntos_Huesped 
                    (Fk_Id_Huesped, Cmp_Puntos_Acumulados, Cmp_Puntos_Obtenidos, Cmp_Fecha_Ultima_Actualizacion)
                VALUES (?, ?, ?, ?)
                ON DUPLICATE KEY UPDATE 
                    Cmp_Puntos_Acumulados       = VALUES(Cmp_Puntos_Acumulados),
                    Cmp_Puntos_Obtenidos        = Cmp_Puntos_Obtenidos + VALUES(Cmp_Puntos_Obtenidos),
                    Cmp_Fecha_Ultima_Actualizacion = VALUES(Cmp_Fecha_Ultima_Actualizacion);";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add(null, OdbcType.Int).Value = idHuesped;
                cmd.Parameters.Add(null, OdbcType.Int).Value = nuevos;                 // Acumulados (nuevo total)
                cmd.Parameters.Add(null, OdbcType.Int).Value = PUNTOS_POR_RESERVA;     // Obtenidos (+15)
                cmd.Parameters.Add(null, OdbcType.Date).Value = DateTime.Today;
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Resta 15 puntos al huésped, sin bajar de 0, y suma a "Canjeados".
        /// </summary>
        public void RestarPuntosHuesped(int idHuesped)
        {
            int puntosActuales = ObtenerPuntosHuesped(idHuesped);
            int nuevos = Math.Max(0, puntosActuales - PUNTOS_POR_RESERVA);

            string sql = @"
                UPDATE Tbl_Puntos_Huesped
                SET Cmp_Puntos_Acumulados = ?, 
                    Cmp_Puntos_Canjeados = Cmp_Puntos_Canjeados + ?,
                    Cmp_Fecha_Ultima_Actualizacion = ?
                WHERE Fk_Id_Huesped = ?;";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add(null, OdbcType.Int).Value = nuevos;
                cmd.Parameters.Add(null, OdbcType.Int).Value = PUNTOS_POR_RESERVA;
                cmd.Parameters.Add(null, OdbcType.Date).Value = DateTime.Today;
                cmd.Parameters.Add(null, OdbcType.Int).Value = idHuesped;
                cmd.ExecuteNonQuery();
            }
        }

        // =========================================================
        // =======   RANGOS CONFIRMADOS / FECHAS OCUPADAS   ========
        // =========================================================

        public DataTable ObtenerRangosReservadosConfirmados(int idHabitacion)
        {
            string sql = @"
                SELECT Cmp_Fecha_Entrada, Cmp_Fecha_Salida
                FROM `Tbl_Reserva`
                WHERE Fk_Id_Habitacion = ?
                  AND Cmp_Estado_Reserva = 'Confirmada'
                ORDER BY Cmp_Fecha_Entrada;";

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sql, conn))
            using (var da = new OdbcDataAdapter(cmd))
            {
                cmd.Parameters.Add(null, OdbcType.Int).Value = idHabitacion;

                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public HashSet<DateTime> ExpandirFechasOcupadas(int idHabitacion)
        {
            string sql = @"
                SELECT Cmp_Fecha_Entrada, Cmp_Fecha_Salida
                FROM Tbl_Reserva
                WHERE Fk_Id_Habitacion = ?
                  AND Cmp_Estado_Reserva IN ('Pendiente','Confirmada');";

            var set = new HashSet<DateTime>();

            using (var conn = conexion.conexion())
            using (var cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add(null, OdbcType.Int).Value = idHabitacion;

                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        DateTime ini = rd.GetDateTime(0).Date;
                        DateTime fin = rd.GetDateTime(1).Date;

                        // Ocupamos [ini, fin) por noche (de entrada a la víspera de salida)
                        for (DateTime d = ini; d < fin; d = d.AddDays(1))
                            set.Add(d);
                    }
                }
            }
            return set;
        }
    }
}
