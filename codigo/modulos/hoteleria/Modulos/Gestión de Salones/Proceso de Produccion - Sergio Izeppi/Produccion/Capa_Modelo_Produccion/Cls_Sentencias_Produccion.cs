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
        public void InsertarRoomService(int idHuesped, int idHabitacion, DateTime fechaOrden, string estado)
        {
            Cls_Conexion_Produccion cn = new Cls_Conexion_Produccion();

            using (OdbcConnection con = cn.conexion())
            {
                string sql = "INSERT INTO Tbl_Room_Service (FK_Id_Huesped, Fk_Id_Habitacion, Cmp_Fecha_Orden, Cmp_Estado) VALUES (?, ?, ?, ?)";

                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@FK_Id_Huesped", idHuesped);
                    cmd.Parameters.AddWithValue("@Fk_Id_Habitacion", idHabitacion);
                    cmd.Parameters.AddWithValue("@Cmp_Fecha_Orden", fechaOrden);
                    cmd.Parameters.AddWithValue("@Cmp_Estado", estado);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Editar un Room Service existente
        public void EditarRoomService(int idRoom, int idHuesped, int idHabitacion, DateTime fechaOrden, string estado)
        {
            Cls_Conexion_Produccion cn = new Cls_Conexion_Produccion();

            using (OdbcConnection con = cn.conexion())
            {
                string sql = "UPDATE Tbl_Room_Service " +
                             "SET FK_Id_Huesped = ?, Fk_Id_Habitacion = ?, Cmp_Fecha_Orden = ?, Cmp_Estado = ? " +
                             "WHERE Pk_Id_Room = ?";

                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@FK_Id_Huesped", idHuesped);
                    cmd.Parameters.AddWithValue("@Fk_Id_Habitacion", idHabitacion);
                    cmd.Parameters.AddWithValue("@Cmp_Fecha_Orden", fechaOrden);
                    cmd.Parameters.AddWithValue("@Cmp_Estado", estado);
                    cmd.Parameters.AddWithValue("@Pk_Id_Room", idRoom);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Eliminar un Room Service
        public void EliminarRoomService(int idRoom)
        {
            Cls_Conexion_Produccion cn = new Cls_Conexion_Produccion();

            using (OdbcConnection con = cn.conexion())
            {
                string sql = "DELETE FROM Tbl_Room_Service WHERE Pk_Id_Room = ?";

                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Pk_Id_Room", idRoom);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Consultar todos los Room Services
        public DataTable CargarRoomServices()
        {
            Cls_Conexion_Produccion cn = new Cls_Conexion_Produccion();
            DataTable tabla = new DataTable();

            using (OdbcConnection con = cn.conexion())
            {
                string sql = "SELECT Pk_Id_Room, FK_Id_Huesped, Fk_Id_Habitacion, Cmp_Fecha_Orden, Cmp_Estado FROM Tbl_Room_Service";

                using (OdbcDataAdapter da = new OdbcDataAdapter(sql, con))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        // ✅ Insertar detalle
        public void InsertarDetalle(int idRoom, int idMenu, int cantidad)
        {
            Cls_Conexion_Produccion cn = new Cls_Conexion_Produccion();
            decimal precioUnitario = ObtenerPrecioUnitario(idMenu);
            decimal subtotal = cantidad * precioUnitario;

            string sql = "INSERT INTO Tbl_Room_Service_Detalle (FK_Id_Room, FK_Id_Menu, Cmp_Cantidad, Cmp_Precio_Unitario, Cmp_Subtotal) " +
                         "VALUES (?, ?, ?, ?, ?)";

            using (OdbcConnection con = cn.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@FK_Id_Room", idRoom);
                    cmd.Parameters.AddWithValue("@FK_Id_Menu", idMenu);
                    cmd.Parameters.AddWithValue("@Cmp_Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@Cmp_Precio_Unitario", precioUnitario);
                    cmd.Parameters.AddWithValue("@Cmp_Subtotal", subtotal);
                    cmd.ExecuteNonQuery();
                }
                cn.desconexion(con);
            }
        }

        // ✅ Actualizar detalle
        public void EditarDetalle(int idDetalle, int idRoom, int idMenu, int cantidad)
        {
            Cls_Conexion_Produccion cn = new Cls_Conexion_Produccion();
            decimal precioUnitario = ObtenerPrecioUnitario(idMenu);
            decimal subtotal = cantidad * precioUnitario;

            string sql = "UPDATE Tbl_Room_Service_Detalle SET FK_Id_Room=?, FK_Id_Menu=?, Cmp_Cantidad=?, " +
                         "Cmp_Precio_Unitario=?, Cmp_Subtotal=? WHERE Pk_Id_Detalle=?";

            using (OdbcConnection con = cn.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@FK_Id_Room", idRoom);
                    cmd.Parameters.AddWithValue("@FK_Id_Menu", idMenu);
                    cmd.Parameters.AddWithValue("@Cmp_Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@Cmp_Precio_Unitario", precioUnitario);
                    cmd.Parameters.AddWithValue("@Cmp_Subtotal", subtotal);
                    cmd.Parameters.AddWithValue("@Pk_Id_Detalle", idDetalle);
                    cmd.ExecuteNonQuery();
                }
                cn.desconexion(con);
            }
        }

        // ✅ Eliminar detalle
        public void EliminarDetalle(int idDetalle)
        {
            Cls_Conexion_Produccion cn = new Cls_Conexion_Produccion();
            string sql = "DELETE FROM Tbl_Room_Service_Detalle WHERE Pk_Id_Detalle=?";

            using (OdbcConnection con = cn.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Pk_Id_Detalle", idDetalle);
                    cmd.ExecuteNonQuery();
                }
                cn.desconexion(con);
            }
        }

        // ✅ Obtener detalles (con nombre del plato)
        public DataTable CargarDetalles()
        {
            Cls_Conexion_Produccion cn = new Cls_Conexion_Produccion();
            DataTable dt = new DataTable();
            string sql = "SELECT d.Pk_Id_Detalle, d.FK_Id_Room, m.Cmp_Nombre_Platillo AS Plato, " +
                         "d.Cmp_Cantidad, d.Cmp_Precio_Unitario, d.Cmp_Subtotal " +
                         "FROM Tbl_Room_Service_Detalle d " +
                         "INNER JOIN Tbl_Menu m ON d.FK_Id_Menu = m.Pk_Id_Menu";

            using (OdbcConnection con = cn.conexion())
            {
                using (OdbcDataAdapter da = new OdbcDataAdapter(sql, con))
                {
                    da.Fill(dt);
                }
                cn.desconexion(con);
            }
            return dt;
        }

        // ✅ Obtener detalles filtrados por un Room específico
        public DataTable CargarDetallesPorRoom(int idRoom)
        {
            Cls_Conexion_Produccion cn = new Cls_Conexion_Produccion();
            DataTable dt = new DataTable();
            string sql = "SELECT d.Pk_Id_Detalle, m.Cmp_Nombre_Platillo, " +
             "d.Cmp_Cantidad, d.Cmp_Precio_Unitario, d.Cmp_Subtotal " +
             "FROM Tbl_Room_Service_Detalle d " +
             "INNER JOIN Tbl_Menu m ON d.FK_Id_Menu = m.Pk_Id_Menu " +
             "WHERE d.FK_Id_Room = ?";


            using (OdbcConnection con = cn.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@FK_Id_Room", idRoom);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(dt);
                }
                cn.desconexion(con);
            }
            return dt;
        }

        // ✅ Obtener precio de un menú
        public decimal ObtenerPrecioUnitario(int idMenu)
        {
            Cls_Conexion_Produccion cn = new Cls_Conexion_Produccion();
            decimal precio = 0;
            string sql = "SELECT Cmp_Precio FROM Tbl_Menu WHERE Pk_Id_Menu=?";

            using (OdbcConnection con = cn.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Pk_Id_Menu", idMenu);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        precio = Convert.ToDecimal(result);
                }
                cn.desconexion(con);
            }
            return precio;
        }

        // ✅ Obtener total general por Room
        public decimal ObtenerTotalPorRoom(int idRoom)
        {
            Cls_Conexion_Produccion cn = new Cls_Conexion_Produccion();
            decimal total = 0;
            string sql = "SELECT SUM(Cmp_Subtotal) FROM Tbl_Room_Service_Detalle WHERE FK_Id_Room=?";

            using (OdbcConnection con = cn.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@FK_Id_Room", idRoom);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        total = Convert.ToDecimal(result);
                }
                cn.desconexion(con);
            }
            return total;
        }

        public DataTable CargarMenu()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT Pk_Id_Menu, Cmp_Nombre_Platillo FROM Tbl_Menu"; // Ajusta el nombre de columna exacto

            Cls_Conexion_Produccion cn = new Cls_Conexion_Produccion();
            using (OdbcConnection con = cn.conexion())
            {
                using (OdbcDataAdapter da = new OdbcDataAdapter(sql, con))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        public int ObtenerUltimoIdRoomService()
        {
            Cls_Conexion_Produccion cn = new Cls_Conexion_Produccion();
            int ultimoId = 0;

            using (OdbcConnection con = cn.conexion())
            {
                string sql = "SELECT MAX(Pk_Id_Room) AS Ultimo FROM Tbl_Room_Service";

                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        ultimoId = Convert.ToInt32(result);
                }

                cn.desconexion(con);
            }

            return ultimoId;
        }

        // INSERTAR nueva reserva
        public void InsertarReservaAlacarta(int idHuesped, int idHabitacion, int idSalon, DateTime fechaReserva, TimeSpan horaReserva, int numComensales, int estado)
        {
            Cls_Conexion_Produccion cn = new Cls_Conexion_Produccion();

            using (OdbcConnection con = cn.conexion())
            {
                string sql = "INSERT INTO Tbl_Reservas_Alacarta (Fk_Id_Huessed, Fk_Id_Habitacion, Fk_Id_Salon, Cmp_Fecha_Reserva, Cmp_Hora_reserva, Cmp_Numero_Comensales, Cmp_Estado) " +
                             "VALUES (?, ?, ?, ?, ?, ?, ?)";

                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Fk_Id_Huessed", idHuesped);
                    cmd.Parameters.AddWithValue("@Fk_Id_Habitacion", idHabitacion);
                    cmd.Parameters.AddWithValue("@Fk_Id_Salon", idSalon);
                    cmd.Parameters.AddWithValue("@Cmp_Fecha_Reserva", fechaReserva);
                    cmd.Parameters.AddWithValue("@Cmp_Hora_reserva", horaReserva);
                    cmd.Parameters.AddWithValue("@Cmp_Numero_Comensales", numComensales);
                    cmd.Parameters.AddWithValue("@Cmp_Estado", estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // EDITAR reserva existente
        public void EditarReservaAlacarta(int idReserva, int idHuesped, int idHabitacion, int idSalon, DateTime fechaReserva, TimeSpan horaReserva, int numComensales, int estado)
        {
            Cls_Conexion_Produccion cn = new Cls_Conexion_Produccion();

            using (OdbcConnection con = cn.conexion())
            {
                string sql = "UPDATE Tbl_Reservas_Alacarta SET " +
                             "Fk_Id_Huessed = ?, Fk_Id_Habitacion = ?, Fk_Id_Salon = ?, Cmp_Fecha_Reserva = ?, Cmp_Hora_reserva = ?, Cmp_Numero_Comensales = ?, Cmp_Estado = ? " +
                             "WHERE PK_Id_Reserva = ?";

                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Fk_Id_Huessed", idHuesped);
                    cmd.Parameters.AddWithValue("@Fk_Id_Habitacion", idHabitacion);
                    cmd.Parameters.AddWithValue("@Fk_Id_Salon", idSalon);
                    cmd.Parameters.AddWithValue("@Cmp_Fecha_Reserva", fechaReserva);
                    cmd.Parameters.AddWithValue("@Cmp_Hora_reserva", horaReserva);
                    cmd.Parameters.AddWithValue("@Cmp_Numero_Comensales", numComensales);
                    cmd.Parameters.AddWithValue("@Cmp_Estado", estado);
                    cmd.Parameters.AddWithValue("@PK_Id_Reserva", idReserva);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ELIMINAR reserva
        public void EliminarReservaAlacarta(int idReserva)
        {
            Cls_Conexion_Produccion cn = new Cls_Conexion_Produccion();

            using (OdbcConnection con = cn.conexion())
            {
                string sql = "DELETE FROM Tbl_Reservas_Alacarta WHERE PK_Id_Reserva = ?";

                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@PK_Id_Reserva", idReserva);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // CARGAR todas las reservas
        public DataTable CargarReservasAlacarta()
        {
            Cls_Conexion_Produccion cn = new Cls_Conexion_Produccion();
            DataTable tabla = new DataTable();

            using (OdbcConnection con = cn.conexion())
            {
                string sql = "SELECT PK_Id_Reserva, Fk_Id_Huessed, Fk_Id_Habitacion, Fk_Id_Salon, Cmp_Fecha_Reserva, Cmp_Hora_reserva, Cmp_Numero_Comensales, Cmp_Estado FROM Tbl_Reservas_Alacarta";

                using (OdbcDataAdapter da = new OdbcDataAdapter(sql, con))
                {
                    da.Fill(tabla);
                }
            }

            return tabla;
        }
    }


    }






