using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using Capa_Modelo_Check_In_Check_Out;

namespace Capa_Controlador_Check_In_Check_Out
{
    public class Cls_Check_In_Controlador
    {
        private readonly Cls_Check_In_Dao DAO = new Cls_Check_In_Dao();
        private readonly Cls_Conexion conexion = new Cls_Conexion();


        public int ObtenerHabitacionPorReserva(int idReserva)
        {
            return DAO.ObtenerHabitacionPorReserva(idReserva);
        }

        public DataTable datObtenerHuespedes() => DAO.datObtenerHuespedes();
        public DataTable datObtenerReservaPorHuesped(int idHuesped) => DAO.datObtenerReservaPorHuesped(idHuesped);
        public DataTable MostrarCheckIn() => DAO.bMostrarCheckIn();
        public bool bBorrarCheckIn(int iIdCheckIn, out string sMensajeError) => DAO.bEliminarCheckIn(iIdCheckIn, out sMensajeError);

        public bool ValidarCheckIn(int iFkHuesped, int iFkReserva, DateTime dFecha, string sEstado, out string mensaje)
        {
            if (iFkHuesped <= 0 || iFkReserva <= 0)
            {
                mensaje = "Debe seleccionar un huésped y una reserva válidos.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(sEstado))
            {
                mensaje = "Debe especificar un estado para el Check-In.";
                return false;
            }

            if (dFecha == default(DateTime))
            {
                mensaje = "Debe ingresar una fecha válida para el Check-In.";
                return false;
            }

            try
            {
                using (OdbcConnection conn = conexion.conexion())
                {
                    // 🔹 Traer las fechas de entrada y salida desde la reserva
                    string query = "SELECT Cmp_Fecha_Entrada, Cmp_Fecha_Salida FROM Tbl_Reserva WHERE Pk_Id_Reserva = ?";
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", iFkReserva);
                        using (OdbcDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                DateTime fechaEntrada = Convert.ToDateTime(dr["Cmp_Fecha_Entrada"]);
                                DateTime fechaSalida = Convert.ToDateTime(dr["Cmp_Fecha_Salida"]);

                                if (dFecha < fechaEntrada)
                                {
                                    mensaje = $"La fecha de Check-In ({dFecha:dd/MM/yyyy}) no puede ser antes de la fecha de entrada reservada ({fechaEntrada:dd/MM/yyyy}).";
                                    return false;
                                }

                                if (dFecha > fechaSalida)
                                {
                                    mensaje = $"La fecha de Check-In ({dFecha:dd/MM/yyyy}) no puede ser después de la fecha de salida reservada ({fechaSalida:dd/MM/yyyy}).";
                                    return false;
                                }
                            }
                            else
                            {
                                mensaje = "No se encontró la reserva seleccionada.";
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al validar la reserva: " + ex.Message;
                return false;
            }

            mensaje = "";
            return true;
        }


        public bool bInsertarCheckIn(int iFkHuesped, int iFkReserva, DateTime dFecha, string sEstado, out string mensaje)
        {
            if (!ValidarCheckIn(iFkHuesped, iFkReserva, dFecha, sEstado, out mensaje))
                return false;

            var nuevoCheckIn = new Cls_CheckIn
            {
                iFk_Id_Huesped = iFkHuesped,
                iFk_Id_Reserva = iFkReserva,
                dCmp_Fecha_CheckIn = dFecha,
                sCmp_Estado = sEstado
            };

            bool exito = DAO.bInsertarCheckIn(nuevoCheckIn);
            if (!exito) mensaje = "Error al guardar el Check-In en la base de datos.";
            return exito;
        }


        public bool bActualizarCheckIn(int iIdCheckIn, int iFkHuesped, int iFkReserva, DateTime dFecha, string sEstado, out string mensaje)
        {
            if (iIdCheckIn <= 0)
            {
                mensaje = "El ID del Check-In no es válido.";
                return false;
            }

            if (!ValidarCheckIn(iFkHuesped, iFkReserva, dFecha, sEstado, out mensaje))
                return false;

            using (OdbcConnection conn = conexion.conexion())
            using (OdbcTransaction tx = conn.BeginTransaction())
            {
                try
                {
                    // 1️ Actualizar Check-In
                    string updateCheckIn = @"
                UPDATE Tbl_Check_in
                SET Fk_Id_Huesped = ?, 
                    Fk_Id_Reserva = ?, 
                    Cmp_Fecha_Check_In = ?, 
                    Cmp_Estado = ?
                WHERE Pk_Id_Check_in = ?";
                    using (OdbcCommand cmd = new OdbcCommand(updateCheckIn, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("?", iFkHuesped);
                        cmd.Parameters.AddWithValue("?", iFkReserva);
                        cmd.Parameters.AddWithValue("?", dFecha);
                        cmd.Parameters.AddWithValue("?", sEstado);
                        cmd.Parameters.AddWithValue("?", iIdCheckIn);
                        cmd.ExecuteNonQuery();
                    }

                    // 2️ Sincronizar la fecha en el folio (solo si sigue abierto)
                    string updateFolio = @"
                UPDATE Tbl_Folio
                SET Cmp_Fecha_Creacion = ?
                WHERE Fk_Id_Check_In = ? 
                  AND Cmp_Estado = 'Abierto'";
                    using (OdbcCommand cmdFolio = new OdbcCommand(updateFolio, conn, tx))
                    {
                        cmdFolio.Parameters.AddWithValue("?", dFecha);
                        cmdFolio.Parameters.AddWithValue("?", iIdCheckIn);
                        cmdFolio.ExecuteNonQuery();
                    }

                    // 3️ Confirmar cambios
                    tx.Commit();

                    mensaje = "Check-In y fecha del folio actualizados correctamente.";
                    return true;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    mensaje = "Error al actualizar el Check-In: " + ex.Message;
                    return false;
                }
            }
        }

 
        public bool RegistrarCheckInConFolio(int idHuesped, int idReserva, DateTime fecha, string estado, int idHabitacion)
        {
         
            if (idHuesped <= 0 || idReserva <= 0 || idHabitacion <= 0)
            {
                MessageBox.Show("Los datos del Check-In no son válidos.");
                return false;
            }

         
            if (!ValidarCheckIn(idHuesped, idReserva, fecha, estado, out string mensaje))
            {
                MessageBox.Show(mensaje, "Validación de Check-In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

          
            var checkIn = new Cls_CheckIn
            {
                iFk_Id_Huesped = idHuesped,
                iFk_Id_Reserva = idReserva,
                dCmp_Fecha_CheckIn = fecha,
                sCmp_Estado = estado
            };

            return EjecutarRegistroCheckInConFolio(checkIn, idHabitacion);
        }

        private bool EjecutarRegistroCheckInConFolio(Cls_CheckIn checkIn, int idHabitacion)
        {
            using (OdbcConnection conn = conexion.conexion())
            using (OdbcTransaction tx = conn.BeginTransaction())
            {
                try
                {
                    // 1️⃣ Insertar nuevo Check-In
                    string insertCheckIn = @"
                INSERT INTO Tbl_Check_in 
                    (Fk_Id_Huesped, Fk_Id_Reserva, Cmp_Fecha_Check_In, Cmp_Estado)
                VALUES (?, ?, ?, ?)";
                    using (OdbcCommand cmdCheckIn = new OdbcCommand(insertCheckIn, conn, tx))
                    {
                        cmdCheckIn.Parameters.AddWithValue("?", checkIn.iFk_Id_Huesped);
                        cmdCheckIn.Parameters.AddWithValue("?", checkIn.iFk_Id_Reserva);
                        cmdCheckIn.Parameters.AddWithValue("?", checkIn.dCmp_Fecha_CheckIn);
                        cmdCheckIn.Parameters.AddWithValue("?", checkIn.sCmp_Estado);
                        cmdCheckIn.ExecuteNonQuery();
                    }

                    // 2️⃣ Obtener ID del nuevo Check-In
                    int idCheckIn;
                    using (OdbcCommand cmdId = new OdbcCommand("SELECT LAST_INSERT_ID()", conn, tx))
                    {
                        idCheckIn = Convert.ToInt32(cmdId.ExecuteScalar());
                    }

                    // 3️⃣ Crear Folio vinculado al Check-In y la Habitación
                    string insertFolio = @"
                INSERT INTO Tbl_Folio
                    (Fk_Id_Check_In, Fk_Id_Habitacion, 
                     Cmp_Fecha_Creacion, Cmp_Estado,
                     Cmp_Total_Cargos, Cmp_Total_Abonos, Cmp_Saldo_Final)
                VALUES (?, ?, NOW(), 'Abierto', 0, 0, 0)";
                    using (OdbcCommand cmdFolio = new OdbcCommand(insertFolio, conn, tx))
                    {
                        cmdFolio.Parameters.AddWithValue("?", idCheckIn);
                        cmdFolio.Parameters.AddWithValue("?", idHabitacion);
                        cmdFolio.ExecuteNonQuery();
                    }

                    // 4️⃣ Actualizar el estado de la reserva asociada a "Finalizada"
                    string updateReserva = @"
                UPDATE Tbl_Reserva
                SET Cmp_Estado_Reserva = 'Finalizada'
                WHERE Pk_Id_Reserva = ?";
                    using (OdbcCommand cmdUpdate = new OdbcCommand(updateReserva, conn, tx))
                    {
                        cmdUpdate.Parameters.AddWithValue("?", checkIn.iFk_Id_Reserva);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    // 5️⃣ Confirmar la transacción
                    tx.Commit();

                    MessageBox.Show("✅ Check-In, Folio creados y Reserva finalizada correctamente.",
                                    "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    MessageBox.Show("❌ Error en el proceso de Check-In con Folio: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


    }
}
