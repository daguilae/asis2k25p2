using System;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Check_In_Check_Out;

namespace Capa_Controlador_Check_In_Check_Out
{
    public class Cls_Check_Out_Controlador
    {
        private readonly Cls_CHeck_Out_Dao DAO = new Cls_CHeck_Out_Dao();
        private readonly Cls_Conexion conexion = new Cls_Conexion();


        public bool RegistrarCheckOutConFolio(int idCheckIn, DateTime fechaCheckOut)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                try
                {
                    // 1️⃣ Insertar Check-Out
                    var nuevoCheckOut = new Cls_Check_Out
                    {
                        iFk_Id_CheckIn = idCheckIn,
                        dCmp_Fecha_CheckOut = fechaCheckOut
                    };

                    bool exito = DAO.bInsertarCheckOut(nuevoCheckOut);
                    if (!exito)
                    {
                        System.Windows.Forms.MessageBox.Show("Error al registrar el Check-Out en la base de datos.");
                        return false;
                    }

                    // 2️⃣ Buscar folio del Check-In
                    int idFolio = 0;
                    string queryFolio = @"
                SELECT Pk_Id_Folio 
                FROM Tbl_Folio 
                WHERE Fk_Id_Check_In = ?
                ORDER BY Pk_Id_Folio DESC
                LIMIT 1;";
                    using (OdbcCommand cmd = new OdbcCommand(queryFolio, conn))
                    {
                        cmd.Parameters.AddWithValue("?", idCheckIn);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            idFolio = Convert.ToInt32(result);
                    }

                    if (idFolio == 0)
                    {
                        System.Windows.Forms.MessageBox.Show("⚠️ No se encontró un folio asociado a este Check-In.");
                        return false;
                    }

                    // 3️⃣ Obtener datos de Check-In y habitación
                    int idHabitacion = 0;
                    int idHuesped = 0;
                    DateTime fechaCheckIn = DateTime.Now;

                    string queryDatos = @"
                SELECT CI.Fk_Id_Reserva, R.Fk_Id_Habitacion, CI.Fk_Id_Huesped, CI.Cmp_Fecha_Check_In
                FROM Tbl_Check_in CI
                INNER JOIN Tbl_Reserva R ON CI.Fk_Id_Reserva = R.Pk_Id_Reserva
                WHERE CI.Pk_Id_Check_in = ?";
                    using (OdbcCommand cmd = new OdbcCommand(queryDatos, conn))
                    {
                        cmd.Parameters.AddWithValue("?", idCheckIn);
                        using (OdbcDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                idHabitacion = Convert.ToInt32(dr["Fk_Id_Habitacion"]);
                                idHuesped = Convert.ToInt32(dr["Fk_Id_Huesped"]);
                                fechaCheckIn = Convert.ToDateTime(dr["Cmp_Fecha_Check_In"]);
                            }
                        }
                    }

                    if (fechaCheckOut < fechaCheckIn)
                    {
                        System.Windows.Forms.MessageBox.Show(
                            $"⚠️ La fecha de Check-Out ({fechaCheckOut:dd/MM/yyyy}) no puede ser anterior al Check-In ({fechaCheckIn:dd/MM/yyyy}).",
                            "Fecha inválida",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Warning
                        );
                        return false;
                    }

                    // 4️⃣ Calcular tarifas y totales
                    double tarifaNoche = 0;
                    using (OdbcCommand cmd = new OdbcCommand("SELECT Cmp_Tarifa_Noche FROM Tbl_Habitaciones WHERE Pk_Id_Habitaciones = ?", conn))
                    {
                        cmd.Parameters.AddWithValue("?", idHabitacion);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            tarifaNoche = Convert.ToDouble(result);
                    }

                    int totalDias = (fechaCheckOut.Date - fechaCheckIn.Date).Days;
                    if (totalDias <= 0) totalDias = 1;
                    double totalEstadia = tarifaNoche * totalDias;

                    string paisHuesped = "";
                    using (OdbcCommand cmd = new OdbcCommand("SELECT Cmp_Pais FROM Tbl_Huesped WHERE Pk_Id_Huesped = ?", conn))
                    {
                        cmd.Parameters.AddWithValue("?", idHuesped);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            paisHuesped = result.ToString();
                    }

                    double impuestoTurismo = (!string.IsNullOrEmpty(paisHuesped) && !paisHuesped.Equals("Guatemala", StringComparison.OrdinalIgnoreCase))
                        ? totalEstadia * 0.10
                        : 0;

                    // 5️⃣ Cargos adicionales
                    double otrosCargos = 0;
                    using (OdbcCommand cmd = new OdbcCommand(@"
                SELECT IFNULL(SUM(Cmp_Monto), 0)
                FROM Tbl_Area
                WHERE Fk_Id_Folio = ?
                  AND LOWER(Cmp_Tipo_Movimiento) = 'cargo'
                  AND LOWER(Cmp_Nombre_Area) <> 'contabilidad';", conn))
                    {
                        cmd.Parameters.AddWithValue("?", idFolio);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            otrosCargos = Convert.ToDouble(result);
                    }

                    // ✅ 5️⃣ bis: Detectar ABONOS (restar)
                    double totalAbonos = 0;
                    using (OdbcCommand cmd = new OdbcCommand(@"
                SELECT IFNULL(SUM(Cmp_Monto), 0)
                FROM Tbl_Area
                WHERE Fk_Id_Folio = ?
                  AND LOWER(Cmp_Tipo_Movimiento) = 'abono'
                  AND LOWER(Cmp_Nombre_Area) <> 'contabilidad';", conn))
                    {
                        cmd.Parameters.AddWithValue("?", idFolio);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            totalAbonos = Convert.ToDouble(result);
                    }

                    // 6️⃣ Calcular totales finales
                    double totalHospedaje = totalEstadia + impuestoTurismo;
                    double totalFinal = (totalHospedaje + otrosCargos) - totalAbonos;

                    // 7️⃣ Actualizar área contable
                    string updateArea = @"
                UPDATE Tbl_Area
                SET Cmp_Descripcion = ?, Cmp_Monto = ?, Cmp_Fecha_Movimiento = NOW()
                WHERE Fk_Id_Folio = ? AND LOWER(Cmp_Nombre_Area) = 'contabilidad';";
                    using (OdbcCommand cmd = new OdbcCommand(updateArea, conn))
                    {
                        string descripcion = impuestoTurismo > 0 ? "Cierre de hospedaje (con impuesto turista)" : "Cierre de hospedaje";
                        cmd.Parameters.AddWithValue("?", descripcion);
                        cmd.Parameters.AddWithValue("?", totalHospedaje);
                        cmd.Parameters.AddWithValue("?", idFolio);
                        cmd.ExecuteNonQuery();
                    }

                    // 8️⃣ Actualizar folio
                    string updateFolio = @"
                UPDATE Tbl_Folio 
                SET 
                    Cmp_Total_Cargos = ?,
                    Cmp_Total_Abonos = ?,
                    Cmp_Saldo_Final = ?,
                    Cmp_Fecha_Cierre = ?,
                    Cmp_Estado = 'Cerrado'
                WHERE Pk_Id_Folio = ?";
                    using (OdbcCommand cmdFolio = new OdbcCommand(updateFolio, conn))
                    {
                        cmdFolio.Parameters.AddWithValue("?", (totalHospedaje + otrosCargos)); // total de cargos
                        cmdFolio.Parameters.AddWithValue("?", totalAbonos);
                        cmdFolio.Parameters.AddWithValue("?", totalFinal);
                        cmdFolio.Parameters.AddWithValue("?", fechaCheckOut);
                        cmdFolio.Parameters.AddWithValue("?", idFolio);
                        cmdFolio.ExecuteNonQuery();
                    }

                    // 9️⃣ Actualizar estado del Check-In a 'Finalizado'
                    string updateCheckIn = @"
                UPDATE Tbl_Check_in
                SET Cmp_Estado = 'Finalizado'
                WHERE Pk_Id_Check_in = ?";
                    using (OdbcCommand cmdUpdate = new OdbcCommand(updateCheckIn, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("?", idCheckIn);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    // 🔟 Mensaje final
                    string mensaje = $"✅ Check-Out completado y Check-In finalizado.\n\n" +
                                     $"Folio: #{idFolio}\n" +
                                     $"Tarifa/noche: Q{tarifaNoche:N2}\n" +
                                     $"Noches: {totalDias}\n" +
                                     $"Hospedaje: Q{totalEstadia:N2}\n" +
                                     (impuestoTurismo > 0 ? $"Impuesto turista: Q{impuestoTurismo:N2}\n" : "") +
                                     $"Otros cargos: Q{otrosCargos:N2}\n" +
                                     $"Abonos: -Q{totalAbonos:N2}\n" +
                                     $"Total final: Q{totalFinal:N2}";

                    System.Windows.Forms.MessageBox.Show(mensaje, "Proceso exitoso",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Information);

                    return true;
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error durante el proceso de Check-Out:\n\n" + ex.Message,
                        "Error detallado",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
            }
        }



        public DataTable datObtenerCheckIn() => DAO.datObtenerCheckIn();

        public DataTable MostrarCheckOut() => DAO.bMostrarCheckOut();


        public bool bActualizarCheckOut(int iIdCheckOut, int iFkCheckIn, DateTime dFecha, out string mensaje)
        {
            if (iIdCheckOut <= 0)
            {
                mensaje = "El ID del Check-Out no es válido.";
                return false;
            }

            var checkOutActualizado = new Cls_Check_Out
            {
                iPk_Id_CheckOut = iIdCheckOut,
                iFk_Id_CheckIn = iFkCheckIn,
                dCmp_Fecha_CheckOut = dFecha
            };

            bool exito = DAO.bActualizarCheckOut(checkOutActualizado);

            if (exito)
            {
                try
                {
                
                    using (OdbcConnection conn = conexion.conexion())
                    {
                        string query = @"
                            UPDATE Tbl_Folio
                            SET Cmp_Fecha_Cierre = ?
                            WHERE Fk_Id_Check_In = ?";
                        using (OdbcCommand cmd = new OdbcCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("?", dFecha);
                            cmd.Parameters.AddWithValue("?", iFkCheckIn);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex2)
                {
                    System.Windows.Forms.MessageBox.Show(
                        "Error al actualizar la fecha de cierre del folio: " + ex2.Message,
                        "Advertencia",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning
                    );
                }

                mensaje = "Check-Out actualizado correctamente y folio sincronizado.";
            }
            else
            {
                mensaje = "Error al modificar el Check-Out en la base de datos.";
            }

            return exito;
        }

        public bool bBorrarCheckOut(int iIdCheckOut, out string mensajeError)
        {
            return DAO.bEliminarCheckOut(iIdCheckOut, out mensajeError);
        }
    }
}
