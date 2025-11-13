using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using Capa_Modelo_Check_In_Check_Out;

namespace Capa_Controlador_Check_In_Check_Out
{
    public class Cls_Check_In_Controlador
    {
        private readonly Cls_Check_In_Dao prDao = new Cls_Check_In_Dao();
        private readonly Cls_Conexion prConexion = new Cls_Conexion();

        // Obtiene el id de habitación asociado a una reserva
        public int fun_Obtener_Habitacion_Por_Reserva(int iIdReserva)
        {
            return prDao.fun_Obtener_Habitacion_Por_Reserva(iIdReserva);
        }

        // Retorna los huéspedes para el combo
        public DataTable fun_Obtener_Huespedes() => prDao.fun_Obtener_Huespedes();

        // Retorna las reservas de un huésped
        public DataTable fun_Obtener_Reserva_Por_Huesped(int iIdHuesped) =>
            prDao.fun_Obtener_Reserva_Por_Huesped(iIdHuesped);

        // Retorna las reservas incluyendo la actual en edición
        public DataTable fun_Obtener_Reserva_Por_Huesped_Edicion(int iIdHuesped, int iIdReservaActual)
        {
            return prDao.fun_Obtener_Reserva_Por_Huesped(iIdHuesped, iIdReservaActual);
        }

        // Muestra todos los Check-In
        public DataTable fun_Mostrar_CheckIn() => prDao.fun_Mostrar_CheckIn();

        // Elimina un Check-In
        public bool bEliminar_CheckIn(int iIdCheckIn, out string sMensajeError) =>
            prDao.bEliminar_CheckIn(iIdCheckIn, out sMensajeError);

        // Valida datos antes de insertar o actualizar un Check-In
        public bool fun_Validar_CheckIn(int iFkHuesped, int iFkReserva, DateTime dFecha, string sEstado, out string sMensaje)
        {
            if (iFkHuesped <= 0 || iFkReserva <= 0)
            {
                sMensaje = "Debe seleccionar un huésped y una reserva válidos.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(sEstado))
            {
                sMensaje = "Debe especificar un estado para el Check-In.";
                return false;
            }

            if (dFecha == default)
            {
                sMensaje = "Debe ingresar una fecha válida para el Check-In.";
                return false;
            }

            try
            {
                using (OdbcConnection conn = prConexion.conexion())
                {
                    string sQuery = "SELECT Cmp_Fecha_Entrada, Cmp_Fecha_Salida FROM Tbl_Reserva WHERE Pk_Id_Reserva = ?";
                    using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", iFkReserva);
                        using (OdbcDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                DateTime dEntrada = Convert.ToDateTime(dr["Cmp_Fecha_Entrada"]);
                                DateTime dSalida = Convert.ToDateTime(dr["Cmp_Fecha_Salida"]);

                                if (dFecha < dEntrada)
                                {
                                    sMensaje = $"La fecha de Check-In ({dFecha:dd/MM/yyyy}) no puede ser antes de la fecha de entrada ({dEntrada:dd/MM/yyyy}).";
                                    return false;
                                }

                                if (dFecha > dSalida)
                                {
                                    sMensaje = $"La fecha de Check-In ({dFecha:dd/MM/yyyy}) no puede ser después de la fecha de salida ({dSalida:dd/MM/yyyy}).";
                                    return false;
                                }
                            }
                            else
                            {
                                sMensaje = "No se encontró la reserva seleccionada.";
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                sMensaje = "Error al validar la reserva: " + ex.Message;
                return false;
            }

            sMensaje = "";
            return true;
        }

        // Inserta un nuevo Check-In
        public bool bInsertar_CheckIn(int iFkHuesped, int iFkReserva, DateTime dFecha, string sEstado, out string sMensaje)
        {
            if (!fun_Validar_CheckIn(iFkHuesped, iFkReserva, dFecha, sEstado, out sMensaje))
                return false;

            var clsCheckIn = new Cls_CheckIn
            {
                iFk_Id_Huesped = iFkHuesped,
                iFk_Id_Reserva = iFkReserva,
                dCmp_Fecha_CheckIn = dFecha,
                sCmp_Estado = sEstado
            };

            bool bExito = prDao.bInsertar_CheckIn(clsCheckIn);
            if (!bExito) sMensaje = "Error al guardar el Check-In en la base de datos.";
            return bExito;
        }

        // Actualiza un Check-In y sincroniza la fecha en el folio si está abierto
        public bool bActualizar_CheckIn(int iIdCheckIn, int iFkHuesped, int iFkReserva, DateTime dFecha, string sEstado, out string sMensaje)
        {
            if (iIdCheckIn <= 0)
            {
                sMensaje = "El ID del Check-In no es válido.";
                return false;
            }

            if (!fun_Validar_CheckIn(iFkHuesped, iFkReserva, dFecha, sEstado, out sMensaje))
                return false;

            using (OdbcConnection conn = prConexion.conexion())
            using (OdbcTransaction tx = conn.BeginTransaction())
            {
                try
                {
                    string sUpdateCheckIn = @"
                        UPDATE Tbl_Check_In
                        SET Fk_Id_Huesped = ?, 
                            Fk_Id_Reserva = ?, 
                            Cmp_Fecha_Check_In = ?, 
                            Cmp_Estado = ?
                        WHERE Pk_Id_Check_in = ?";
                    using (OdbcCommand cmd = new OdbcCommand(sUpdateCheckIn, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("?", iFkHuesped);
                        cmd.Parameters.AddWithValue("?", iFkReserva);
                        cmd.Parameters.AddWithValue("?", dFecha);
                        cmd.Parameters.AddWithValue("?", sEstado);
                        cmd.Parameters.AddWithValue("?", iIdCheckIn);
                        cmd.ExecuteNonQuery();
                    }

                    string sUpdateFolio = @"
                        UPDATE Tbl_Folio
                        SET Cmp_Fecha_Creacion = ?
                        WHERE Fk_Id_Check_In = ? AND Cmp_Estado = 'Abierto'";
                    using (OdbcCommand cmdFolio = new OdbcCommand(sUpdateFolio, conn, tx))
                    {
                        cmdFolio.Parameters.AddWithValue("?", dFecha);
                        cmdFolio.Parameters.AddWithValue("?", iIdCheckIn);
                        cmdFolio.ExecuteNonQuery();
                    }

                    tx.Commit();
                    sMensaje = "Check-In y folio actualizados correctamente.";
                    return true;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    sMensaje = "Error al actualizar el Check-In: " + ex.Message;
                    return false;
                }
            }
        }
       
        // CAMBIA EL ESTADO DE UNA HABITACIÓN (0 = Disponible, 1 = Ocupada)
       
        public void CambiarEstadoHabitacion(int iIdHabitacion, OdbcConnection conn, OdbcTransaction tx)
        {
            try
            {
                // 1️⃣ Obtener el estado actual (0 = disponible, 1 = ocupada)
                string querySelect = "SELECT Cmp_Estado_Habitacion FROM Tbl_Habitaciones WHERE Pk_Id_Habitaciones = ?;";
                int estadoActual = 0;

                using (OdbcCommand cmdSelect = new OdbcCommand(querySelect, conn, tx))
                {
                    cmdSelect.Parameters.AddWithValue("?", iIdHabitacion);
                    object result = cmdSelect.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                    {
                        MessageBox.Show($"No se encontró la habitación con ID {iIdHabitacion}.",
                            "Habitación no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    estadoActual = Convert.ToInt32(result);
                }

                // 2️⃣ Si está disponible (0), cambiar a ocupada (1)
                if (estadoActual == 0)
                {
                    string queryUpdate = "UPDATE Tbl_Habitaciones SET Cmp_Estado_Habitacion = 1 WHERE Pk_Id_Habitaciones = ?;";
                    using (OdbcCommand cmdUpdate = new OdbcCommand(queryUpdate, conn, tx))
                    {
                        cmdUpdate.Parameters.AddWithValue("?", iIdHabitacion);
                        cmdUpdate.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show($"La habitación {iIdHabitacion} ya se encuentra ocupada.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar el estado de la habitación: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        
        public bool pro_Registrar_CheckIn_Con_Folio(int iIdHuesped, int iIdReserva, DateTime dFecha, string sEstado, int iIdHabitacion)
        {
            if (iIdHuesped <= 0 || iIdReserva <= 0 || iIdHabitacion <= 0)
            {
                MessageBox.Show("Los datos del Check-In no son válidos.");
                return false;
            }

            if (!fun_Validar_CheckIn(iIdHuesped, iIdReserva, dFecha, sEstado, out string sMensaje))
            {
                MessageBox.Show(sMensaje, "Validación de Check-In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var clsCheckIn = new Cls_CheckIn
            {
                iFk_Id_Huesped = iIdHuesped,
                iFk_Id_Reserva = iIdReserva,
                dCmp_Fecha_CheckIn = dFecha,
                sCmp_Estado = sEstado
            };

            return pro_Ejecutar_Registro_CheckIn_Con_Folio(clsCheckIn, iIdHabitacion);
        }

        // Ejecuta la transacción completa del Check-In con folio
        private bool pro_Ejecutar_Registro_CheckIn_Con_Folio(Cls_CheckIn clsCheckIn, int iIdHabitacion)
        {
            using (OdbcConnection conn = prConexion.conexion())
            using (OdbcTransaction tx = conn.BeginTransaction())
            {
                try
                {
                    // 1️ Insertar Check-In
                    string sInsertCheckIn = @"
                INSERT INTO Tbl_Check_In 
                    (Fk_Id_Huesped, Fk_Id_Reserva, Cmp_Fecha_Check_In, Cmp_Estado)
                VALUES (?, ?, ?, ?)";
                    using (OdbcCommand cmdCheckIn = new OdbcCommand(sInsertCheckIn, conn, tx))
                    {
                        cmdCheckIn.Parameters.AddWithValue("?", clsCheckIn.iFk_Id_Huesped);
                        cmdCheckIn.Parameters.AddWithValue("?", clsCheckIn.iFk_Id_Reserva);
                        cmdCheckIn.Parameters.AddWithValue("?", clsCheckIn.dCmp_Fecha_CheckIn);
                        cmdCheckIn.Parameters.AddWithValue("?", clsCheckIn.sCmp_Estado);
                        cmdCheckIn.ExecuteNonQuery();
                    }

                    // 2️ Obtener ID del nuevo Check-In
                    int iIdCheckIn;
                    using (OdbcCommand cmdId = new OdbcCommand("SELECT LAST_INSERT_ID()", conn, tx))
                    {
                        iIdCheckIn = Convert.ToInt32(cmdId.ExecuteScalar());
                    }

                    // 3️ Insertar Folio vinculado
                    string sInsertFolio = @"
                INSERT INTO Tbl_Folio
                    (Fk_Id_Check_In, Fk_Id_Habitacion, 
                     Cmp_Fecha_Creacion, Cmp_Estado,
                     Cmp_Total_Cargos, Cmp_Total_Abonos, Cmp_Saldo_Final)
                VALUES (?, ?, NOW(), 'Abierto', 0, 0, 0)";
                    using (OdbcCommand cmdFolio = new OdbcCommand(sInsertFolio, conn, tx))
                    {
                        cmdFolio.Parameters.AddWithValue("?", iIdCheckIn);
                        cmdFolio.Parameters.AddWithValue("?", iIdHabitacion);
                        cmdFolio.ExecuteNonQuery();
                    }

                    // 4️ Actualizar reserva como finalizada
                    string sUpdateReserva = @"
                UPDATE Tbl_Reserva
                SET Cmp_Estado_Reserva = 'Finalizada'
                WHERE Pk_Id_Reserva = ?";
                    using (OdbcCommand cmdUpdate = new OdbcCommand(sUpdateReserva, conn, tx))
                    {
                        cmdUpdate.Parameters.AddWithValue("?", clsCheckIn.iFk_Id_Reserva);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    // 5️ Marcar habitación como OCUPADA (usa la conexión + transacción actual)
                    CambiarEstadoHabitacion(iIdHabitacion, conn, tx);

                    // 6️ Confirmar todo
                    tx.Commit();

                    MessageBox.Show("Check-In, folio creados, habitación marcada como ocupada y reserva finalizada correctamente.",
                        "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    MessageBox.Show("Error en el proceso de Check-In con Folio: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }


        }

        public int IObtenerIdHabitacionPorReserva(int idReserva)
        {
            string query = "SELECT Fk_Id_Habitacion FROM Tbl_Reserva WHERE Pk_Id_Reserva = ?;";
            OdbcConnection conn = prConexion.conexion();

            try
            {
                conn.Open();
                OdbcCommand cmd = new OdbcCommand(query, conn);
                // En ODBC el orden de los parámetros importa
                cmd.Parameters.AddWithValue("@id", idReserva);

                object resultado = cmd.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                    return Convert.ToInt32(resultado);
                else
                    return -1; // No encontrado
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener habitación por reserva: " + ex.Message);
                return -1;
            }
            finally
            {
                prConexion.desconexion(conn);
            }
        }

        public int fun_ObtenerNumHuespedesPorReserva(int idReserva)
        {
            string query = "SELECT Cmp_Num_Huespedes FROM Tbl_Reserva WHERE Pk_Id_Reserva = ?;";
            OdbcConnection conn = prConexion.conexion();

            try
            {
                conn.Open();
                OdbcCommand cmd = new OdbcCommand(query, conn);

                // En ODBC el orden de los parámetros es lo que importa
                cmd.Parameters.AddWithValue("@id", idReserva);

                object resultado = cmd.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                    return Convert.ToInt32(resultado);
                else
                    return -1; // No existe o no tiene valor
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener número de huéspedes: " + ex.Message);
                return -1;
            }
            finally
            {
                prConexion.desconexion(conn);
            }
        }

    }
}
