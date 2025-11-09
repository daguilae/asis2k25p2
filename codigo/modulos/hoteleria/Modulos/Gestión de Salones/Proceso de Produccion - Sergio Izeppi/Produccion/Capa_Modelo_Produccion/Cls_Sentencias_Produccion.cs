using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace CapaModeloProduccion
{
    public class Cls_Sentencias_Produccion
    {
        // Insertar un Room Service usando el Cmp_Numero_Documento del huésped
        public void InsertarRoomService(int iIdHuesped, int iIdHabitacion, DateTime dFechaOrden, string sEstado)
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

        // Editar un Room Service existente
        public void EditarRoomService(int iIdRoom, int iIdHuesped, int iIdHabitacion, DateTime dFechaOrden, string sEstado)
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

        // Eliminar un Room Service
        public void EliminarRoomService(int iIdRoom)
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

        // Consultar todos los Room Services
        public DataTable CargarRoomServices()
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

        // ✅ Insertar detalle
        public void InsertarDetalle(int iIdRoom, int iIdMenu, int iCantidad)
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();
            decimal dePrecioUnitario = ObtenerPrecioUnitario(iIdMenu);
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

        // ✅ Actualizar detalle
        public void EditarDetalle(int iIdDetalle, int iIdRoom, int iIdMenu, int iCantidad)
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();
            decimal dePrecioUnitario = ObtenerPrecioUnitario(iIdMenu);
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

        // ✅ Eliminar detalle
        public void EliminarDetalle(int iIdDetalle)
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

        // ✅ Obtener detalles (con nombre del plato)
        public DataTable CargarDetalles()
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

        // ✅ Obtener detalles filtrados por un Room específico
        public DataTable CargarDetallesPorRoom(int iIdRoom)
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

        // ✅ Obtener precio de un menú
        public decimal ObtenerPrecioUnitario(int iIdMenu)
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

        // ✅ Obtener total general por Room
        public decimal ObtenerTotalPorRoom(int iIdRoom)
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

        public DataTable CargarMenu()
        {
            DataTable dTabla = new DataTable();
            string sSql = "SELECT Pk_Id_Menu, Cmp_Nombre_Platillo FROM Tbl_Menu";

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

        public int ObtenerUltimoIdRoomService()
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

        // INSERTAR nueva reserva
        public void InsertarReservaAlacarta(int iIdHuesped, int iIdHabitacion, int iIdSalon, DateTime dFechaReserva, TimeSpan tHoraReserva, int iNumComensales, int iEstado)
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();

            using (OdbcConnection pCon = pCn.conexion())
            {
                string sSql = "INSERT INTO Tbl_Reservas_Alacarta (Fk_Id_Huessed, Fk_Id_Habitacion, Fk_Id_Salon, Cmp_Fecha_Reserva, Cmp_Hora_reserva, Cmp_Numero_Comensales, Cmp_Estado) " +
                             "VALUES (?, ?, ?, ?, ?, ?, ?)";

                using (OdbcCommand pCmd = new OdbcCommand(sSql, pCon))
                {
                    pCmd.Parameters.AddWithValue("@Fk_Id_Huessed", iIdHuesped);
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

        // EDITAR reserva existente
        public void EditarReservaAlacarta(int iIdReserva, int iIdHuesped, int iIdHabitacion, int iIdSalon, DateTime dFechaReserva, TimeSpan tHoraReserva, int iNumComensales, int iEstado)
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();

            using (OdbcConnection pCon = pCn.conexion())
            {
                string sSql = "UPDATE Tbl_Reservas_Alacarta SET " +
                             "Fk_Id_Huessed = ?, Fk_Id_Habitacion = ?, Fk_Id_Salon = ?, Cmp_Fecha_Reserva = ?, Cmp_Hora_reserva = ?, Cmp_Numero_Comensales = ?, Cmp_Estado = ? " +
                             "WHERE PK_Id_Reserva = ?";

                using (OdbcCommand pCmd = new OdbcCommand(sSql, pCon))
                {
                    pCmd.Parameters.AddWithValue("@Fk_Id_Huessed", iIdHuesped);
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

        // ELIMINAR reserva
        public void EliminarReservaAlacarta(int iIdReserva)
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

        // CARGAR todas las reservas
        public DataTable CargarReservasAlacarta()
        {
            Cls_Conexion_Produccion pCn = new Cls_Conexion_Produccion();
            DataTable dTabla = new DataTable();

            using (OdbcConnection pCon = pCn.conexion())
            {
                string sSql = @"
            SELECT 
                r.PK_Id_Reserva,
                r.Fk_Id_Huessed,
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

        public DataTable CargarSalones()
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


    }


}






