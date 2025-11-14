using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Produccion
{
    public class Cls_Sentencias_Produccion
    {
        // ✅ PROCEDIMIENTOS (void) - ROOM SERVICE
        public void pro_InsertarRoomService(int iIdHuesped, int iIdHabitacion, DateTime dFechaOrden, string sEstado)
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();

            using (OdbcConnection pCon = pCn.conexion())
            {
                string sSql = "INSERT INTO Tbl_Room_Service (FK_Id_Huesped, Fk_Id_Habitacion, Cmp_Fecha_Orden, Cmp_Estado) VALUES (?, ?, ?, ?)";

                using (OdbcCommand pCmd = new OdbcCommand(sSql, pCon))
                {
                    pCmd.Parameters.AddWithValue("@FK_Id_Huesped", iIdHuesped);
                    pCmd.Parameters.AddWithValue("@Fk_Id_Habitacion", iIdHabitacion);
                    pCmd.Parameters.AddWithValue("@Cmp_Fecha_Orden", dFechaOrden);
                    pCmd.Parameters.AddWithValue("@Cmp_Estado", sEstado);

                    pCmd.ExecuteNonQuery();
                }
            }
        }

        public void pro_EditarRoomService(int iIdRoom, int iIdHuesped, int iIdHabitacion, DateTime dFechaOrden, string sEstado)
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();

            using (OdbcConnection pCon = pCn.conexion())
            {
                string sSql = "UPDATE Tbl_Room_Service " +
                             "SET FK_Id_Huesped = ?, Fk_Id_Habitacion = ?, Cmp_Fecha_Orden = ?, Cmp_Estado = ? " +
                             "WHERE Pk_Id_Room = ?";

                using (OdbcCommand pCmd = new OdbcCommand(sSql, pCon))
                {
                    pCmd.Parameters.AddWithValue("@FK_Id_Huesped", iIdHuesped);
                    pCmd.Parameters.AddWithValue("@Fk_Id_Habitacion", iIdHabitacion);
                    pCmd.Parameters.AddWithValue("@Cmp_Fecha_Orden", dFechaOrden);
                    pCmd.Parameters.AddWithValue("@Cmp_Estado", sEstado);
                    pCmd.Parameters.AddWithValue("@Pk_Id_Room", iIdRoom);

                    pCmd.ExecuteNonQuery();
                }
            }
        }

        public void pro_EliminarRoomService(int iIdRoom)
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();

            using (OdbcConnection pCon = pCn.conexion())
            {
                string sSql = "DELETE FROM Tbl_Room_Service WHERE Pk_Id_Room = ?";

                using (OdbcCommand pCmd = new OdbcCommand(sSql, pCon))
                {
                    pCmd.Parameters.AddWithValue("@Pk_Id_Room", iIdRoom);
                    pCmd.ExecuteNonQuery();
                }
            }
        }

        // ✅ PROCEDIMIENTOS (void) - DETALLES
        public void pro_InsertarDetalle(int iIdRoom, int iIdMenu, int iCantidad)
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();
            decimal dePrecioUnitario = fun_ObtenerPrecioUnitario(iIdMenu);
            decimal deSubtotal = iCantidad * dePrecioUnitario;

            string sSql = "INSERT INTO Tbl_Room_Service_Detalle (FK_Id_Room, FK_Id_Menu, Cmp_Cantidad, Cmp_Precio_Unitario, Cmp_Subtotal) " +
                         "VALUES (?, ?, ?, ?, ?)";

            using (OdbcConnection pCon = pCn.conexion())
            {
                using (OdbcCommand pCmd = new OdbcCommand(sSql, pCon))
                {
                    pCmd.Parameters.AddWithValue("@FK_Id_Room", iIdRoom);
                    pCmd.Parameters.AddWithValue("@FK_Id_Menu", iIdMenu);
                    pCmd.Parameters.AddWithValue("@Cmp_Cantidad", iCantidad);
                    pCmd.Parameters.AddWithValue("@Cmp_Precio_Unitario", dePrecioUnitario);
                    pCmd.Parameters.AddWithValue("@Cmp_Subtotal", deSubtotal);
                    pCmd.ExecuteNonQuery();
                }
                pCn.desconexion(pCon);
            }
        }

        public void pro_EditarDetalle(int iIdDetalle, int iIdRoom, int iIdMenu, int iCantidad)
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();
            decimal dePrecioUnitario = fun_ObtenerPrecioUnitario(iIdMenu);
            decimal deSubtotal = iCantidad * dePrecioUnitario;

            string sSql = "UPDATE Tbl_Room_Service_Detalle SET FK_Id_Room=?, FK_Id_Menu=?, Cmp_Cantidad=?, " +
                         "Cmp_Precio_Unitario=?, Cmp_Subtotal=? WHERE Pk_Id_Detalle=?";

            using (OdbcConnection pCon = pCn.conexion())
            {
                using (OdbcCommand pCmd = new OdbcCommand(sSql, pCon))
                {
                    pCmd.Parameters.AddWithValue("@FK_Id_Room", iIdRoom);
                    pCmd.Parameters.AddWithValue("@FK_Id_Menu", iIdMenu);
                    pCmd.Parameters.AddWithValue("@Cmp_Cantidad", iCantidad);
                    pCmd.Parameters.AddWithValue("@Cmp_Precio_Unitario", dePrecioUnitario);
                    pCmd.Parameters.AddWithValue("@Cmp_Subtotal", deSubtotal);
                    pCmd.Parameters.AddWithValue("@Pk_Id_Detalle", iIdDetalle);
                    pCmd.ExecuteNonQuery();
                }
                pCn.desconexion(pCon);
            }
        }

        public void pro_EliminarDetalle(int iIdDetalle)
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();
            string sSql = "DELETE FROM Tbl_Room_Service_Detalle WHERE Pk_Id_Detalle=?";

            using (OdbcConnection pCon = pCn.conexion())
            {
                using (OdbcCommand pCmd = new OdbcCommand(sSql, pCon))
                {
                    pCmd.Parameters.AddWithValue("@Pk_Id_Detalle", iIdDetalle);
                    pCmd.ExecuteNonQuery();
                }
                pCn.desconexion(pCon);
            }
        }

        // ✅ PROCEDIMIENTOS (void) - RESERVAS A LA CARTA
        public void pro_InsertarReservaAlacarta(int iIdHuesped, int iIdHabitacion, int iIdSalon, DateTime dFechaReserva, TimeSpan tHoraReserva, int iNumComensales, int iEstado)
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();

            using (OdbcConnection pCon = pCn.conexion())
            {
                string sSql = "INSERT INTO Tbl_Reservas_Alacarta (Fk_Id_Huesped, Fk_Id_Habitacion, Fk_Id_Salon, Cmp_Fecha_Reserva, Cmp_Hora_reserva, Cmp_Numero_Comensales, Cmp_Estado) " +
                             "VALUES (?, ?, ?, ?, ?, ?, ?)";

                using (OdbcCommand pCmd = new OdbcCommand(sSql, pCon))
                {
                    pCmd.Parameters.AddWithValue("@Fk_Id_Huesped", iIdHuesped);
                    pCmd.Parameters.AddWithValue("@Fk_Id_Habitacion", iIdHabitacion);
                    pCmd.Parameters.AddWithValue("@Fk_Id_Salon", iIdSalon);
                    pCmd.Parameters.AddWithValue("@Cmp_Fecha_Reserva", dFechaReserva);
                    pCmd.Parameters.AddWithValue("@Cmp_Hora_reserva", tHoraReserva);
                    pCmd.Parameters.AddWithValue("@Cmp_Numero_Comensales", iNumComensales);
                    pCmd.Parameters.AddWithValue("@Cmp_Estado", iEstado);
                    pCmd.ExecuteNonQuery();
                }
            }
        }

        public void pro_EditarReservaAlacarta(int iIdReserva, int iIdHuesped, int iIdHabitacion, int iIdSalon, DateTime dFechaReserva, TimeSpan tHoraReserva, int iNumComensales, int iEstado)
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();

            using (OdbcConnection pCon = pCn.conexion())
            {
                string sSql = "UPDATE Tbl_Reservas_Alacarta SET " +
                             "Fk_Id_Huesped = ?, Fk_Id_Habitacion = ?, Fk_Id_Salon = ?, Cmp_Fecha_Reserva = ?, Cmp_Hora_reserva = ?, Cmp_Numero_Comensales = ?, Cmp_Estado = ? " +
                             "WHERE PK_Id_Reserva = ?";

                using (OdbcCommand pCmd = new OdbcCommand(sSql, pCon))
                {
                    pCmd.Parameters.AddWithValue("@Fk_Id_Huesped", iIdHuesped);
                    pCmd.Parameters.AddWithValue("@Fk_Id_Habitacion", iIdHabitacion);
                    pCmd.Parameters.AddWithValue("@Fk_Id_Salon", iIdSalon);
                    pCmd.Parameters.AddWithValue("@Cmp_Fecha_Reserva", dFechaReserva);
                    pCmd.Parameters.AddWithValue("@Cmp_Hora_reserva", tHoraReserva);
                    pCmd.Parameters.AddWithValue("@Cmp_Numero_Comensales", iNumComensales);
                    pCmd.Parameters.AddWithValue("@Cmp_Estado", iEstado);
                    pCmd.Parameters.AddWithValue("@PK_Id_Reserva", iIdReserva);
                    pCmd.ExecuteNonQuery();
                }
            }
        }

        public void pro_EliminarReservaAlacarta(int iIdReserva)
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();

            using (OdbcConnection pCon = pCn.conexion())
            {
                string sSql = "DELETE FROM Tbl_Reservas_Alacarta WHERE PK_Id_Reserva = ?";

                using (OdbcCommand pCmd = new OdbcCommand(sSql, pCon))
                {
                    pCmd.Parameters.AddWithValue("@PK_Id_Reserva", iIdReserva);
                    pCmd.ExecuteNonQuery();
                }
            }
        }

        // ✅ FUNCIONES (retornan valores) - CONSULTAS
        public DataTable fun_CargarRoomServices()
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();
            DataTable dTabla = new DataTable();

            using (OdbcConnection pCon = pCn.conexion())
            {
                string sSql = "SELECT Pk_Id_Room, FK_Id_Huesped, Fk_Id_Habitacion, Cmp_Fecha_Orden, Cmp_Estado FROM Tbl_Room_Service";

                using (OdbcDataAdapter pDa = new OdbcDataAdapter(sSql, pCon))
                {
                    pDa.Fill(dTabla);
                }
            }
            return dTabla;
        }

        public DataTable fun_CargarDetalles()
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();
            DataTable dTabla = new DataTable();
            string sSql = "SELECT d.Pk_Id_Detalle, d.FK_Id_Room, m.Cmp_Nombre_Platillo AS Plato, " +
                         "d.Cmp_Cantidad, d.Cmp_Precio_Unitario, d.Cmp_Subtotal " +
                         "FROM Tbl_Room_Service_Detalle d " +
                         "INNER JOIN Tbl_Menu m ON d.FK_Id_Menu = m.Pk_Id_Menu";

            using (OdbcConnection pCon = pCn.conexion())
            {
                using (OdbcDataAdapter pDa = new OdbcDataAdapter(sSql, pCon))
                {
                    pDa.Fill(dTabla);
                }
                pCn.desconexion(pCon);
            }
            return dTabla;
        }

        public DataTable fun_CargarDetallesPorRoom(int iIdRoom)
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();
            DataTable dTabla = new DataTable();
            string sSql = "SELECT d.Pk_Id_Detalle, m.Cmp_Nombre_Platillo, " +
             "d.Cmp_Cantidad, d.Cmp_Precio_Unitario, d.Cmp_Subtotal " +
             "FROM Tbl_Room_Service_Detalle d " +
             "INNER JOIN Tbl_Menu m ON d.FK_Id_Menu = m.Pk_Id_Menu " +
             "WHERE d.FK_Id_Room = ?";

            using (OdbcConnection pCon = pCn.conexion())
            {
                using (OdbcCommand pCmd = new OdbcCommand(sSql, pCon))
                {
                    pCmd.Parameters.AddWithValue("@FK_Id_Room", iIdRoom);
                    OdbcDataAdapter pDa = new OdbcDataAdapter(pCmd);
                    pDa.Fill(dTabla);
                }
                pCn.desconexion(pCon);
            }
            return dTabla;
        }

        public DataTable fun_CargarMenu()
        {
            DataTable dTabla = new DataTable();
            string sSql = "SELECT Pk_Id_Menu, Cmp_Nombre_Platillo " +
                          "FROM Tbl_Menu " +
                          "WHERE Fk_Id_Tipo_Menu = 1"; // ✅ Solo los platos del tipo #1

            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();
            using (OdbcConnection pCon = pCn.conexion())
            {
                using (OdbcDataAdapter pDa = new OdbcDataAdapter(sSql, pCon))
                {
                    pDa.Fill(dTabla);
                }
            }
            return dTabla;
        }


        public DataTable fun_CargarReservasAlacarta()
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();
            DataTable dTabla = new DataTable();

            using (OdbcConnection pCon = pCn.conexion())
            {
                string sSql = @"
            SELECT 
                r.PK_Id_Reserva,
                r.Fk_Id_Huesped,
                r.Fk_Id_Habitacion,
                s.Cmp_Nombre_Salon AS SalonNombre,
                r.Cmp_Fecha_Reserva,
                r.Cmp_Hora_reserva,
                r.Cmp_Numero_Comensales,
                CASE 
                    WHEN r.Cmp_Estado = 1 THEN 'Activa'
                    WHEN r.Cmp_Estado = 0 THEN 'Cancelada'
                    ELSE 'Desconocido'
                END AS Cmp_Estado
            FROM Tbl_Reservas_Alacarta r
            LEFT JOIN Tbl_Salones s ON r.Fk_Id_Salon = s.Pk_Id_Salon";

                using (OdbcDataAdapter pDa = new OdbcDataAdapter(sSql, pCon))
                {
                    pDa.Fill(dTabla);
                }
            }

            return dTabla;
        }

        public DataTable fun_CargarSalones()
        {
            DataTable dTabla = new DataTable();
            string sSql = "SELECT Pk_Id_Salon, Cmp_Nombre_Salon FROM Tbl_Salones";

            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();
            using (OdbcConnection pCon = pCn.conexion())
            {
                using (OdbcDataAdapter pDa = new OdbcDataAdapter(sSql, pCon))
                {
                    pDa.Fill(dTabla);
                }
            }
            return dTabla;
        }

        // ✅ FUNCIONES (retornan valores) - OBTENER DATOS ESPECÍFICOS
        public decimal fun_ObtenerPrecioUnitario(int iIdMenu)
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();
            decimal dePrecio = 0;
            string sSql = "SELECT Cmp_Precio FROM Tbl_Menu WHERE Pk_Id_Menu=?";

            using (OdbcConnection pCon = pCn.conexion())
            {
                using (OdbcCommand pCmd = new OdbcCommand(sSql, pCon))
                {
                    pCmd.Parameters.AddWithValue("@Pk_Id_Menu", iIdMenu);
                    object oResult = pCmd.ExecuteScalar();
                    if (oResult != null && oResult != DBNull.Value)
                        dePrecio = Convert.ToDecimal(oResult);
                }
                pCn.desconexion(pCon);
            }
            return dePrecio;
        }

        public decimal fun_ObtenerTotalPorRoom(int iIdRoom)
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();
            decimal deTotal = 0;
            string sSql = "SELECT SUM(Cmp_Subtotal) FROM Tbl_Room_Service_Detalle WHERE FK_Id_Room=?";

            using (OdbcConnection pCon = pCn.conexion())
            {
                using (OdbcCommand pCmd = new OdbcCommand(sSql, pCon))
                {
                    pCmd.Parameters.AddWithValue("@FK_Id_Room", iIdRoom);
                    object oResult = pCmd.ExecuteScalar();
                    if (oResult != null && oResult != DBNull.Value)
                        deTotal = Convert.ToDecimal(oResult);
                }
                pCn.desconexion(pCon);
            }
            return deTotal;
        }

        public int fun_ObtenerUltimoIdRoomService()
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();
            int iUltimoId = 0;

            using (OdbcConnection pCon = pCn.conexion())
            {
                string sSql = "SELECT MAX(Pk_Id_Room) AS Ultimo FROM Tbl_Room_Service";

                using (OdbcCommand pCmd = new OdbcCommand(sSql, pCon))
                {
                    object oResult = pCmd.ExecuteScalar();
                    if (oResult != null && oResult != DBNull.Value)
                        iUltimoId = Convert.ToInt32(oResult);
                }

                pCn.desconexion(pCon);
            }

            return iUltimoId;
        }

        public bool fun_ExisteHuesped(int idHuesped)
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();
            bool existe = false;
            string sSql = "SELECT COUNT(*) FROM Tbl_Huesped WHERE Pk_Id_Huesped = ?";

            using (OdbcConnection pCon = pCn.conexion())
            {
                using (OdbcCommand pCmd = new OdbcCommand(sSql, pCon))
                {
                    pCmd.Parameters.AddWithValue("@Pk_Id_Huesped", idHuesped);
                    int count = Convert.ToInt32(pCmd.ExecuteScalar());
                    existe = count > 0;
                }
                pCn.desconexion(pCon);
            }
            return existe;
        }


        public bool fun_ExisteHabitacion(int idHabitacion)
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();
            bool existe = false;
            string sSql = "SELECT COUNT(*) FROM Tbl_Habitaciones WHERE Pk_ID_Habitaciones = ?";

            using (OdbcConnection pCon = pCn.conexion())
            {
                using (OdbcCommand pCmd = new OdbcCommand(sSql, pCon))
                {
                    pCmd.Parameters.AddWithValue("@Pk_ID_Habitaciones", idHabitacion);
                    int count = Convert.ToInt32(pCmd.ExecuteScalar());
                    existe = count > 0;
                }
                pCn.desconexion(pCon);
            }

            return existe;
        }

        public bool fun_ExisteSalon(int idSalon)
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();
            bool existe = false;
            string sSql = "SELECT COUNT(*) FROM Tbl_Salon WHERE Pk_Id_Salon = ?";

            using (OdbcConnection pCon = pCn.conexion())
            {
                using (OdbcCommand pCmd = new OdbcCommand(sSql, pCon))
                {
                    pCmd.Parameters.AddWithValue("@Pk_Id_Salon", idSalon);
                    int count = Convert.ToInt32(pCmd.ExecuteScalar());
                    existe = count > 0;
                }
                pCn.desconexion(pCon);
            }

            return existe;
        }

    }
}






