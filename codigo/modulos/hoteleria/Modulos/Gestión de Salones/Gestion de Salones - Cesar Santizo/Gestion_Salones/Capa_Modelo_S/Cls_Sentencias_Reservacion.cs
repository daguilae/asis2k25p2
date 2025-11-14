using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;



namespace Capa_Modelo_S
{
    public class Cls_Sentencias_Reservacion
    {

        public void InsertarReservaSalon(int iIdHuesped, int iIdSalon, DateTime dFecha, TimeSpan dHoraInicio, TimeSpan dHoraFin, int iCantidadPersonas, decimal deMontoTotal)
        {
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();
            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {
                string sSql = @"INSERT INTO Tbl_Reservas_Salones 
                            (Fk_Id_Huesped, Fk_Id_Salon, Cmp_Fecha_Reserva, Cmp_Hora_Inicio, Cmp_Hora_Fin, Cmp_Cantidad_Personas, Cmp_Monto_Total)
                            VALUES (?,?,?,?,?,?,?)";

                using (OdbcCommand cCmd = new OdbcCommand(sSql, cConexionODBC))
                {
                    cCmd.Parameters.Add(new OdbcParameter("", iIdHuesped));
                    cCmd.Parameters.Add(new OdbcParameter("", iIdSalon));
                    cCmd.Parameters.Add(new OdbcParameter("", dFecha));
                    cCmd.Parameters.Add(new OdbcParameter("", dHoraInicio));
                    cCmd.Parameters.Add(new OdbcParameter("", dHoraFin));
                    cCmd.Parameters.Add(new OdbcParameter("", iCantidadPersonas));
                    cCmd.Parameters.Add(new OdbcParameter("", deMontoTotal));
                    cCmd.ExecuteNonQuery();
                }
            }
        }


        public void ModificarReservaSalon(int iIdReserva, int iIdHuesped, int iIdSalon, DateTime dFecha, TimeSpan dHoraInicio, TimeSpan dHoraFin, int iCantidadPersonas, decimal deMontoTotal)
        {
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();
            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {
                string sSql = @"UPDATE Tbl_Reservas_Salones 
                            SET Fk_Id_Huesped=?, Fk_Id_Salon=?, Cmp_Fecha_Reserva=?, Cmp_Hora_Inicio=?, Cmp_Hora_Fin=?, 
                                Cmp_Cantidad_Personas=?, Cmp_Monto_Total=? 
                            WHERE Pk_Id_Reserva_Salon=?";

                using (OdbcCommand cCmd = new OdbcCommand(sSql, cConexionODBC))
                {
                    cCmd.Parameters.Add(new OdbcParameter("", iIdHuesped));
                    cCmd.Parameters.Add(new OdbcParameter("", iIdSalon));
                    cCmd.Parameters.Add(new OdbcParameter("", dFecha));
                    cCmd.Parameters.Add(new OdbcParameter("", dHoraInicio));
                    cCmd.Parameters.Add(new OdbcParameter("", dHoraFin));
                    cCmd.Parameters.Add(new OdbcParameter("", iCantidadPersonas));
                    cCmd.Parameters.Add(new OdbcParameter("", deMontoTotal));
                    cCmd.Parameters.Add(new OdbcParameter("", iIdReserva));
                    cCmd.ExecuteNonQuery();
                }
            }
        }
        public void ModificarFolioSalon(int idFolio, DateTime fechaPago, decimal pagoTotal, string estado, string metodoPago)
        {
            Cls_Conexion_Hoteleria cn = new Cls_Conexion_Hoteleria();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = @"UPDATE Tbl_Folio_Salones 
                       SET Cmp_Fecha_Pago=?, Cmp_Pago_Total=?, Cmp_Estado=?, Cmp_Metodo_Pago=?
                       WHERE Pk_Id_Folio_Salones=?";

                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.Add(new OdbcParameter("", fechaPago));
                    cmd.Parameters.Add(new OdbcParameter("", pagoTotal));
                    cmd.Parameters.Add(new OdbcParameter("", estado));
                    cmd.Parameters.Add(new OdbcParameter("", metodoPago));
                    cmd.Parameters.Add(new OdbcParameter("", idFolio));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarReservaSalon(int iIdReserva)
        {
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();
            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {

                string sSqlFolio = "DELETE FROM Tbl_Folio_Salones WHERE Fk_Id_Reserva_Salon=?";
                using (OdbcCommand cCmdFolio = new OdbcCommand(sSqlFolio, cConexionODBC))
                {
                    cCmdFolio.Parameters.Add(new OdbcParameter("", iIdReserva));
                    cCmdFolio.ExecuteNonQuery();
                }


                string sSqlReserva = "DELETE FROM Tbl_Reservas_Salones WHERE Pk_Id_Reserva_Salon=?";
                using (OdbcCommand cCmd = new OdbcCommand(sSqlReserva, cConexionODBC))
                {
                    cCmd.Parameters.Add(new OdbcParameter("", iIdReserva));
                    cCmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ObtenerReservasSalones()
        {
            DataTable tabla = new DataTable();
            Cls_Conexion_Hoteleria cn = new Cls_Conexion_Hoteleria();

            using (OdbcConnection con = cn.conexion())
            {
                string sql = @"
    SELECT 
        r.Pk_Id_Reserva_Salon,
        r.Fk_Id_Huesped,
        r.Fk_Id_Salon,
        h.Cmp_Nombre AS Cmp_Huesped,
        s.Cmp_Nombre_Salon AS Cmp_Salon,
        r.Cmp_Fecha_Reserva,
        r.Cmp_Hora_Inicio,
        r.Cmp_Hora_Fin,
        r.Cmp_Cantidad_Personas,
        r.Cmp_Monto_Total,
        p.Cmp_Nombre_Promocion AS Cmp_Promocion,
        m.Cmp_Nombre_Platillo AS Cmp_Menu,
        pm.Cmp_Cantidad_Platillos
    FROM Tbl_Reservas_Salones r
    INNER JOIN Tbl_Huesped h ON r.Fk_Id_Huesped = h.Pk_Id_Huesped
    INNER JOIN Tbl_Salones s ON r.Fk_Id_Salon = s.Pk_Id_Salon
    LEFT JOIN Tbl_Promociones p ON r.Fk_Id_Promociones = p.Pk_Id_Promociones
    LEFT JOIN Tbl_Pedidos_Menu pm ON r.Pk_Id_Reserva_Salon = pm.Fk_Id_Reserva_Salon
    LEFT JOIN Tbl_Menu m ON pm.Fk_Id_Menu = m.Pk_Id_Menu";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, con);
                da.Fill(tabla);
            }
            return tabla;
        }



        public DataTable ObtenerHuespedes()
        {
            DataTable dTabla = new DataTable();
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();
            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {
                string sQuery = "SELECT Pk_Id_Huesped, CONCAT(Cmp_Nombre, ' ', Cmp_Apellido) AS Cmp_Nombre FROM Tbl_Huesped";
                OdbcDataAdapter cAdapter = new OdbcDataAdapter(sQuery, cConexionODBC);
                cAdapter.Fill(dTabla);
            }
            return dTabla;
        }


        public DataTable ObtenerSalonesDisponibles()
        {
            DataTable dTabla = new DataTable();
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();
            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {
                string sSql = "SELECT Pk_Id_Salon, Cmp_Nombre_Salon FROM Tbl_Salones WHERE Cmp_Disponibilidad = 1";
                OdbcDataAdapter cAdapter = new OdbcDataAdapter(sSql, cConexionODBC);
                cAdapter.Fill(dTabla);
            }
            return dTabla;
        }


        public DataTable ObtenerPromociones()
        {
            DataTable dTabla = new DataTable();
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();
            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {
                string sQuery = "SELECT Pk_Id_Promociones, Cmp_Nombre_Promocion FROM Tbl_Promociones";
                OdbcDataAdapter cAdapter = new OdbcDataAdapter(sQuery, cConexionODBC);
                cAdapter.Fill(dTabla);
            }
            return dTabla;
        }


        public void InsertarFolioSalon(int iIdReserva, DateTime dFechaPago, decimal dePagoTotal, string sEstado, string sMetodoPago)
        {
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();
            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {
                string sSql = @"INSERT INTO Tbl_Folio_Salones 
                      (Fk_Id_Reserva_Salon, Cmp_Fecha_Pago, Cmp_Pago_Total, Cmp_Estado, Cmp_Metodo_Pago)
                      VALUES (?,?,?,?,?)";

                using (OdbcCommand cCmd = new OdbcCommand(sSql, cConexionODBC))
                {
                    cCmd.Parameters.Add(new OdbcParameter("", iIdReserva));
                    cCmd.Parameters.Add(new OdbcParameter("", dFechaPago));
                    cCmd.Parameters.Add(new OdbcParameter("", dePagoTotal));
                    cCmd.Parameters.Add(new OdbcParameter("", sEstado));
                    cCmd.Parameters.Add(new OdbcParameter("", sMetodoPago));
                    cCmd.ExecuteNonQuery();
                }
            }
        }

        public int InsertarReservaSalonYObtenerID(int iIdHuesped, int iIdSalon, DateTime dFecha, TimeSpan dHoraInicio, TimeSpan dHoraFin, int iCantidadPersonas, decimal deMontoTotal)
        {
            int iNuevoId = 0;
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();
            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {
                string sSql = @"INSERT INTO Tbl_Reservas_Salones 
                    (Fk_Id_Huesped, Fk_Id_Salon, Cmp_Fecha_Reserva, Cmp_Hora_Inicio, Cmp_Hora_Fin, Cmp_Cantidad_Personas, Cmp_Monto_Total)
                    VALUES (?,?,?,?,?,?,?)";

                using (OdbcCommand cCmd = new OdbcCommand(sSql, cConexionODBC))
                {
                    cCmd.Parameters.Add(new OdbcParameter("", iIdHuesped));
                    cCmd.Parameters.Add(new OdbcParameter("", iIdSalon));
                    cCmd.Parameters.Add(new OdbcParameter("", dFecha));
                    cCmd.Parameters.Add(new OdbcParameter("", dHoraInicio));
                    cCmd.Parameters.Add(new OdbcParameter("", dHoraFin));
                    cCmd.Parameters.Add(new OdbcParameter("", iCantidadPersonas));
                    cCmd.Parameters.Add(new OdbcParameter("", deMontoTotal));
                    cCmd.ExecuteNonQuery();
                }

                // Obtener el último ID insertado
                string sSqlId = "SELECT LAST_INSERT_ID()";
                using (OdbcCommand cCmdId = new OdbcCommand(sSqlId, cConexionODBC))
                {
                    object oResult = cCmdId.ExecuteScalar();
                    if (oResult != null)
                        iNuevoId = Convert.ToInt32(oResult);
                }
            }
            return iNuevoId;
        }

        //folio
        public DataTable ObtenerFoliosSalones()
        {
            DataTable dTabla = new DataTable();
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();
            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {
                string sSql = @"SELECT 
                            f.Pk_Id_Folio_Salones,
                            f.Fk_Id_Reserva_Salon,
                            r.Cmp_Monto_Total AS Cmp_Reserva_Monto,
                            f.Cmp_Fecha_Pago,
                            f.Cmp_Pago_Total,
                            f.Cmp_Estado,
                            f.Cmp_Metodo_Pago
                        FROM Tbl_Folio_Salones f
                        INNER JOIN Tbl_Reservas_Salones r 
                        ON f.Fk_Id_Reserva_Salon = r.Pk_Id_Reserva_Salon";
                OdbcDataAdapter cAdapter = new OdbcDataAdapter(sSql, cConexionODBC);
                cAdapter.Fill(dTabla);
            }
            return dTabla;
        }

  
        public void EliminarFolioSalon(int iIdFolio)
        {
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();
            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {
                string sSql = "DELETE FROM Tbl_Folio_Salones WHERE Pk_Id_Folio_Salones=?";
                using (OdbcCommand cCmd = new OdbcCommand(sSql, cConexionODBC))
                {
                    cCmd.Parameters.Add(new OdbcParameter("", iIdFolio));
                    cCmd.ExecuteNonQuery();
                }
            }
        }

      
        public decimal ObtenerMontoReserva(int iIdReserva)
        {
            decimal deMonto = 0;
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();
            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {
                string sSql = "SELECT Cmp_Monto_Total FROM Tbl_Reservas_Salones WHERE Pk_Id_Reserva_Salon=?";
                using (OdbcCommand cCmd = new OdbcCommand(sSql, cConexionODBC))
                {
                    cCmd.Parameters.Add(new OdbcParameter("", iIdReserva));
                    object oResult = cCmd.ExecuteScalar();
                    if (oResult != null)
                        deMonto = Convert.ToDecimal(oResult);
                }
            }
            return deMonto;
        }
        public void InsertarPedidoMenu(int iIdReserva, int iIdMenu, int iCantidadPlatillos)
        {
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();
            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {
                string sSql = @"INSERT INTO Tbl_Pedidos_Menu 
                        (Fk_Id_Reserva_Salon, Fk_Id_Menu, Cmp_Cantidad_Platillos)
                        VALUES (?,?,?)";

                using (OdbcCommand cCmd = new OdbcCommand(sSql, cConexionODBC))
                {
                    cCmd.Parameters.Add(new OdbcParameter("", iIdReserva));
                    cCmd.Parameters.Add(new OdbcParameter("", iIdMenu));
                    cCmd.Parameters.Add(new OdbcParameter("", iCantidadPlatillos));
                    cCmd.ExecuteNonQuery();
                }
            }
        }

        public void ModificarPedidoMenu(int iIdReserva, int iIdMenu, int iCantidadPlatillos)
        {
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();
            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {
                string sSql = @"UPDATE Tbl_Pedidos_Menu 
                        SET Fk_Id_Menu=?, Cmp_Cantidad_Platillos=? 
                        WHERE Fk_Id_Reserva_Salon=?";

                using (OdbcCommand cCmd = new OdbcCommand(sSql, cConexionODBC))
                {
                    cCmd.Parameters.Add(new OdbcParameter("", iIdMenu));
                    cCmd.Parameters.Add(new OdbcParameter("", iCantidadPlatillos));
                    cCmd.Parameters.Add(new OdbcParameter("", iIdReserva));
                    cCmd.ExecuteNonQuery();
                }
            }
        }
        public void EliminarPedidoMenu(int iIdReserva)
        {
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();
            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {
                string sSql = "DELETE FROM Tbl_Pedidos_Menu WHERE Fk_Id_Reserva_Salon=?";
                using (OdbcCommand cCmd = new OdbcCommand(sSql, cConexionODBC))
                {
                    cCmd.Parameters.Add(new OdbcParameter("", iIdReserva));
                    cCmd.ExecuteNonQuery();
                }
            }
        }


        public DataTable ObtenerMenusDisponibles()
        {
            DataTable dTabla = new DataTable();
            Cls_Conexion_Hoteleria cConexion = new Cls_Conexion_Hoteleria();
            using (OdbcConnection cConexionODBC = cConexion.conexion())
            {
                string sQuery = "SELECT Pk_Id_Menu, Cmp_Nombre_Platillo FROM Tbl_Menu";
                OdbcDataAdapter cAdapter = new OdbcDataAdapter(sQuery, cConexionODBC);
                cAdapter.Fill(dTabla);
            }
            return dTabla;
        }


     
    

    }
}
