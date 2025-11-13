using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using Capa_Modelo_Check_In_Check_Out;
using Capa_Controlador_GesHab;

namespace Capa_Controlador_Check_In_Check_Out
{
    public class Cls_Check_Out_Controlador
    {
        private readonly Cls_Check_Out_Dao prDao = new Cls_Check_Out_Dao();
        private readonly Cls_Conexion prConexion = new Cls_Conexion();
        private readonly Cls_Controlador_GesHab Ctrl_Estadia = new Cls_Controlador_GesHab();

        private void CambiarEstadoHabitacion(int iIdHabitacion, OdbcConnection conn)
        {
            try
            {
                string querySelect = "SELECT Cmp_Estado_Habitacion FROM Tbl_Habitaciones WHERE Pk_Id_Habitaciones = ?;";
                int estadoActual = 0;

                using (OdbcCommand cmdSelect = new OdbcCommand(querySelect, conn))
                {
                    cmdSelect.Parameters.AddWithValue("?", iIdHabitacion);
                    object result = cmdSelect.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                        return;

                    estadoActual = Convert.ToInt32(result);
                }

                // Si está ocupada (1), la dejamos disponible (0)
                if (estadoActual == 1)
                {
                    using (OdbcCommand cmdUpdate = new OdbcCommand(
                        "UPDATE Tbl_Habitaciones SET Cmp_Estado_Habitacion = 0 WHERE Pk_Id_Habitaciones = ?;", conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("?", iIdHabitacion);
                        cmdUpdate.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado de la habitación: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // VALIDACIÓN DE CHECK-OUT COMPLETO
      
        public bool fun_Validar_CheckOutCompleto(
            int iIdCheckIn,
            DateTime dFechaCheckOut,
            out string sMensaje,
            out DateTime dFechaCheckIn,
            out int iIdFolio,
            out int iIdHabitacion,
            out int iIdHuesped)
        {
            sMensaje = "";
            dFechaCheckIn = DateTime.MinValue;
            iIdFolio = 0;
            iIdHabitacion = 0;
            iIdHuesped = 0;

            try
            {
                using (OdbcConnection conn = prConexion.conexion())
                {
                    string sQueryCheckIn = @"
                        SELECT CI.Cmp_Fecha_Check_In, CI.Fk_Id_Huesped, R.Fk_Id_Habitacion
                        FROM Tbl_Check_In CI
                        INNER JOIN Tbl_Reserva R ON CI.Fk_Id_Reserva = R.Pk_Id_Reserva
                        WHERE CI.Pk_Id_Check_In = ?";
                    using (OdbcCommand cmd = new OdbcCommand(sQueryCheckIn, conn))
                    {
                        cmd.Parameters.AddWithValue("?", iIdCheckIn);
                        using (OdbcDataReader dr = cmd.ExecuteReader())
                        {
                            if (!dr.Read())
                            {
                                sMensaje = "El Check-In especificado no existe.";
                                return false;
                            }

                            dFechaCheckIn = Convert.ToDateTime(dr["Cmp_Fecha_Check_In"]);
                            iIdHabitacion = Convert.ToInt32(dr["Fk_Id_Habitacion"]);
                            iIdHuesped = Convert.ToInt32(dr["Fk_Id_Huesped"]);
                        }
                    }

                    // Buscar folio abierto
                    string sQueryFolio = @"
                        SELECT Pk_Id_Folio
                        FROM Tbl_Folio
                        WHERE Fk_Id_Check_In = ? AND Cmp_Estado = 'Abierto'
                        ORDER BY Pk_Id_Folio DESC
                        LIMIT 1;";
                    using (OdbcCommand cmdFolio = new OdbcCommand(sQueryFolio, conn))
                    {
                        cmdFolio.Parameters.AddWithValue("?", iIdCheckIn);
                        object oResultado = cmdFolio.ExecuteScalar();
                        if (oResultado == null || oResultado == DBNull.Value)
                        {
                            sMensaje = "No se encontró un folio abierto asociado a este Check-In.";
                            return false;
                        }
                        iIdFolio = Convert.ToInt32(oResultado);
                    }

                    // Validaciones de fecha
                    if (dFechaCheckOut == default)
                    {
                        sMensaje = "Debe ingresar una fecha válida para el Check-Out.";
                        return false;
                    }
                    if (dFechaCheckOut < dFechaCheckIn)
                    {
                        sMensaje = $"La fecha de Check-Out ({dFechaCheckOut:dd/MM/yyyy}) no puede ser anterior al Check-In ({dFechaCheckIn:dd/MM/yyyy}).";
                        return false;
                    }
                    if (iIdHabitacion <= 0)
                    {
                        sMensaje = "No se encontró una habitación asociada al Check-In.";
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                sMensaje = "Error durante la validación del Check-Out: " + ex.Message;
                return false;
            }

            return true;
        }


        public bool pro_Registrar_CheckOut_Con_Folio(int iIdCheckIn, DateTime dFechaCheckOut)
        {
            if (!fun_Validar_CheckOutCompleto(iIdCheckIn, dFechaCheckOut, out string sMensajeValidacion,
                                              out DateTime dFechaCheckIn, out int iIdFolio,
                                              out int iIdHabitacion, out int iIdHuesped))
            {
                MessageBox.Show(sMensajeValidacion, "Validación de Check-Out",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            using (OdbcConnection conn = prConexion.conexion())
            {
                try
                {
                    
                    // 1️ Registrar Check-Out
                 
                    var clsCheckOut = new Cls_Check_Out
                    {
                        iFk_Id_CheckIn = iIdCheckIn,
                        dCmp_Fecha_CheckOut = dFechaCheckOut
                    };

                    bool bExito = prDao.bInsertar_CheckOut(clsCheckOut);
                    if (!bExito)
                    {
                        MessageBox.Show("Error al registrar el Check-Out en la base de datos.");
                        return false;
                    }

                    // 
                    // 2️ Calcular tarifas por noche

                    double dTarifaNoche = 0;

                    // Obtener tarifa por noche
                    using (OdbcCommand cmd = new OdbcCommand(
                        "SELECT Cmp_Tarifa_Noche FROM Tbl_Habitaciones WHERE Pk_Id_Habitaciones = ?", conn))
                    {
                        cmd.Parameters.AddWithValue("?", iIdHabitacion);
                        object oResultado = cmd.ExecuteScalar();

                        if (oResultado != null && oResultado != DBNull.Value)
                            dTarifaNoche = Convert.ToDouble(oResultado);
                    }

                    // Calcular días
                    int iTotalDias = (dFechaCheckOut.Date - dFechaCheckIn.Date).Days;
                    if (iTotalDias <= 0) iTotalDias = 1;

                    // Calcular tarifa con promoción
                    decimal descuento = Ctrl_Estadia.fun_ObtenerDescuentoPorPromocion(dFechaCheckIn, dFechaCheckOut);

                    double dTarifaFinalPorNoche = dTarifaNoche; // valor por defecto

                    if (descuento > 0)
                    {
                        double porcentaje = (double)descuento / 100.0;
                        dTarifaFinalPorNoche = dTarifaNoche - (dTarifaNoche * porcentaje);
                    }

                    // Calcular total de estadía
                    double dTotalEstadia = dTarifaFinalPorNoche * iTotalDias;


                    // 3️ Verificar impuesto turístico

                    string sPaisHuesped = "";
                    using (OdbcCommand cmd = new OdbcCommand(
                        "SELECT Cmp_Pais FROM Tbl_Huesped WHERE Pk_Id_Huesped = ?", conn))
                    {
                        cmd.Parameters.AddWithValue("?", iIdHuesped);
                        object oResultado = cmd.ExecuteScalar();
                        if (oResultado != null && oResultado != DBNull.Value)
                            sPaisHuesped = oResultado.ToString();
                    }

                    double dImpuestoTurismo = (!string.IsNullOrEmpty(sPaisHuesped) &&
                        !sPaisHuesped.Equals("Guatemala", StringComparison.OrdinalIgnoreCase))
                        ? dTotalEstadia * 0.10 : 0;

             
                    // 4️ Registrar cargos de estadía por noche
              
                    for (int i = 0; i < iTotalDias; i++)
                    {
                        DateTime dFechaNoche = dFechaCheckIn.AddDays(i);

                        // Insertar en Tbl_Area
                        string sInsertArea = @"
                    INSERT INTO Tbl_Area 
                        (Fk_Id_Folio, Cmp_Nombre_Area, Cmp_Descripcion, Cmp_Tipo_Movimiento, Cmp_Monto, Cmp_Fecha_Movimiento)
                    VALUES (?, 'Gestión de habitaciones', ?, 'Cargo', ?, ?);";

                        using (OdbcCommand cmdInsert = new OdbcCommand(sInsertArea, conn))
                        {
                            cmdInsert.Parameters.AddWithValue("?", iIdFolio);
                            cmdInsert.Parameters.AddWithValue("?", $"Cobro de estadía - Noche {i + 1}");
                            cmdInsert.Parameters.AddWithValue("?", dTarifaFinalPorNoche);
                            cmdInsert.Parameters.AddWithValue("?", dFechaNoche.ToString("yyyy-MM-dd"));
                            cmdInsert.ExecuteNonQuery();
                        }

                        // Insertar en Tbl_Detalle_Folio
                        int idAreaNuevo = fun_ObtenerUltimoIdArea(conn);
                        string sInsertDetalle = @"
                    INSERT INTO Tbl_Detalle_Folio (Fk_Id_Folio, Fk_Id_Area, Cmp_Descripciones, Cmp_Estado)
                    VALUES (?, ?, ?, 'Activo');";

                        using (OdbcCommand cmdDetalle = new OdbcCommand(sInsertDetalle, conn))
                        {
                            cmdDetalle.Parameters.AddWithValue("?", iIdFolio);
                            cmdDetalle.Parameters.AddWithValue("?", idAreaNuevo);
                            cmdDetalle.Parameters.AddWithValue("?", $"Cobro de estadía - Noche {i + 1}");
                            cmdDetalle.ExecuteNonQuery();
                        }
                    }

                   
                    // 5️ Registrar impuesto turístico (si aplica)
                   
                    if (dImpuestoTurismo > 0)
                    {
                        string sInsertImpuesto = @"
                    INSERT INTO Tbl_Area 
                        (Fk_Id_Folio, Cmp_Nombre_Area, Cmp_Descripcion, Cmp_Tipo_Movimiento, Cmp_Monto, Cmp_Fecha_Movimiento)
                    VALUES (?, 'Impuesto de turismo', 'Cargo por visitante extranjero', 'Cargo', ?, NOW());";
                        using (OdbcCommand cmdImp = new OdbcCommand(sInsertImpuesto, conn))
                        {
                            cmdImp.Parameters.AddWithValue("?", iIdFolio);
                            cmdImp.Parameters.AddWithValue("?", dImpuestoTurismo);
                            cmdImp.ExecuteNonQuery();
                        }

                        int idAreaImpuesto = fun_ObtenerUltimoIdArea(conn);
                        string sInsertDetImp = @"
                    INSERT INTO Tbl_Detalle_Folio (Fk_Id_Folio, Fk_Id_Area, Cmp_Descripciones, Cmp_Estado)
                    VALUES (?, ?, 'Impuesto de turismo', 'Activo');";
                        using (OdbcCommand cmdDetImp = new OdbcCommand(sInsertDetImp, conn))
                        {
                            cmdDetImp.Parameters.AddWithValue("?", iIdFolio);
                            cmdDetImp.Parameters.AddWithValue("?", idAreaImpuesto);
                            cmdDetImp.ExecuteNonQuery();
                        }
                    }

                   
                    // 6️ Calcular totales REALES desde Tbl_Area
               
                    double dTotalCargos = 0, dTotalAbonos = 0;
                    using (OdbcCommand cmd = new OdbcCommand(@"
                SELECT 
                    SUM(CASE WHEN LOWER(Cmp_Tipo_Movimiento) = 'cargo' THEN Cmp_Monto ELSE 0 END) AS TotalCargos,
                    SUM(CASE WHEN LOWER(Cmp_Tipo_Movimiento) = 'abono' THEN Cmp_Monto ELSE 0 END) AS TotalAbonos
                FROM Tbl_Area
                WHERE Fk_Id_Folio = ?;", conn))
                    {
                        cmd.Parameters.AddWithValue("?", iIdFolio);
                        using (OdbcDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                dTotalCargos = dr["TotalCargos"] != DBNull.Value ? Convert.ToDouble(dr["TotalCargos"]) : 0;
                                dTotalAbonos = dr["TotalAbonos"] != DBNull.Value ? Convert.ToDouble(dr["TotalAbonos"]) : 0;
                            }
                        }
                    }

                    double dTotalFinal = dTotalCargos - dTotalAbonos;

                  
                    // 7️ Actualizar folio 
                   
                    string sUpdateFolio = @"
                UPDATE Tbl_Folio 
                SET 
                    Cmp_Total_Cargos = ?,
                    Cmp_Total_Abonos = ?,
                    Cmp_Saldo_Final = ?,
                    Cmp_Fecha_Cierre = ?,
                    Cmp_Estado = 'Cerrado'
                WHERE Pk_Id_Folio = ?";
                    using (OdbcCommand cmdFolio = new OdbcCommand(sUpdateFolio, conn))
                    {
                        cmdFolio.Parameters.AddWithValue("?", dTotalCargos);
                        cmdFolio.Parameters.AddWithValue("?", dTotalAbonos);
                        cmdFolio.Parameters.AddWithValue("?", dTotalFinal);
                        cmdFolio.Parameters.AddWithValue("?", dFechaCheckOut);
                        cmdFolio.Parameters.AddWithValue("?", iIdFolio);
                        cmdFolio.ExecuteNonQuery();
                    }

                   
                    // 8️ Finalizar Check-In
                
                    string sUpdateCheckIn = @"
                UPDATE Tbl_Check_In
                SET Cmp_Estado = 'Finalizado'
                WHERE Pk_Id_Check_In = ?";
                    using (OdbcCommand cmdUpdate = new OdbcCommand(sUpdateCheckIn, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("?", iIdCheckIn);
                        cmdUpdate.ExecuteNonQuery();
                    }

                   
                    // 9️ Cambiar estado de la habitación a DISPONIBLE (0)
               
                    CambiarEstadoHabitacion(iIdHabitacion, conn);

                    // 10 Mostrar resumen final
                  
                    string sMensajeFinal = $"Check-Out completado y Check-In finalizado.\n\n" +
                                           $"Folio: #{iIdFolio}\n" +
                                           $"Tarifa/noche: Q{dTarifaFinalPorNoche:N2}\n" +
                                           $"Noches: {iTotalDias}\n" +
                                           $"Hospedaje total: Q{dTotalEstadia:N2}\n" +
                                           (dImpuestoTurismo > 0 ? $"Impuesto turista: Q{dImpuestoTurismo:N2}\n" : "") +
                                           $"Cargos totales: Q{dTotalCargos:N2}\n" +
                                           $"Abonos: -Q{dTotalAbonos:N2}\n" +
                                           $"Saldo final: Q{dTotalFinal:N2}";

                    MessageBox.Show(sMensajeFinal, "Proceso exitoso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error durante el proceso de Check-Out:\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


        
        // MÉTODO AUXILIAR PARA OBTENER ÚLTIMO ID DE ÁREA
        
        private int fun_ObtenerUltimoIdArea(OdbcConnection conn)
        {
            using (OdbcCommand cmd = new OdbcCommand("SELECT MAX(Pk_Id_Area) FROM Tbl_Area;", conn))
            {
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToInt32(result) : 0;
            }
        }

        public DataTable fun_Obtener_CheckIn() => prDao.fun_Obtener_CheckIn();
        public DataTable fun_Mostrar_CheckOut() => prDao.fun_Mostrar_CheckOut();

        public bool bActualizar_CheckOut(int iIdCheckOut, int iFkCheckIn, DateTime dFecha, out string sMensaje)
        {
            if (iIdCheckOut <= 0)
            {
                sMensaje = "El ID del Check-Out no es válido.";
                return false;
            }

            var clsCheckOut = new Cls_Check_Out
            {
                iPk_Id_CheckOut = iIdCheckOut,
                iFk_Id_CheckIn = iFkCheckIn,
                dCmp_Fecha_CheckOut = dFecha
            };

            bool bExito = prDao.bActualizar_CheckOut(clsCheckOut);

            if (bExito)
            {
                try
                {
                    using (OdbcConnection conn = prConexion.conexion())
                    {
                        string sQuery = @"
                            UPDATE Tbl_Folio
                            SET Cmp_Fecha_Cierre = ?
                            WHERE Fk_Id_Check_In = ?";
                        using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("?", dFecha);
                            cmd.Parameters.AddWithValue("?", iFkCheckIn);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("Error al actualizar la fecha de cierre del folio: " + ex2.Message,
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                sMensaje = "Check-Out actualizado correctamente y folio sincronizado.";
            }
            else
            {
                sMensaje = "Error al modificar el Check-Out en la base de datos.";
            }

            return bExito;
        }

        public bool bEliminar_CheckOut(int iIdCheckOut, out string sMensajeError)
        {
            return prDao.bEliminar_CheckOut(iIdCheckOut, out sMensajeError);
        }
    }
}
