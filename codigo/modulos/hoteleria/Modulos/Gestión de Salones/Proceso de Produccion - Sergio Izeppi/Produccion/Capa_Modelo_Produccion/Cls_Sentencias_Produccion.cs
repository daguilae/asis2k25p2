using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Produccion
{
    public class Cls_Modelo_Produccion
    {
        Cls_Conexion_Produccion cn = new Cls_Conexion_Produccion();

        // Obtener todos los platos (para ComboBox)
        public DataTable ObtenerPlatos()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT Pk_Id_Menu, Cmp_Nombre_Platillo FROM Tbl_Menu";

            using (OdbcConnection con = cn.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(consulta, con))
                {
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(dt);
                }
                cn.desconexion(con);
            }
            return dt;
        }

        // Obtener precio de un plato por id
        public decimal ObtenerPrecioPlato(int idMenu)
        {
            decimal precio = 0;
            string consulta = "SELECT Cmp_Precio FROM Tbl_Menu WHERE Pk_Id_Menu = ?";

            using (OdbcConnection con = cn.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(consulta, con))
                {
                    cmd.Parameters.AddWithValue("@Pk_Id_Menu", idMenu);
                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                        precio = Convert.ToDecimal(resultado);
                }
                cn.desconexion(con);
            }
            return precio;
        }

        // Insertar Room Service y devolver ID generado
        public int InsertarRoomService(int idHuesped, int idHabitacion, DateTime fecha, string estado)
        {
            int idGenerado = 0;

            using (OdbcConnection con = cn.conexion())
            {
                // Insertar Room Service
                string insert = "INSERT INTO Tbl_Room_Service (FK_Id_Huesped, Fk_Id_Habitacion, Cmp_Fecha_Orden, Cmp_Estado) " +
                                "VALUES (?, ?, ?, ?)";

                using (OdbcCommand cmd = new OdbcCommand(insert, con))
                {
                    cmd.Parameters.AddWithValue("@FK_Id_Huesped", idHuesped);
                    cmd.Parameters.AddWithValue("@Fk_Id_Habitacion", idHabitacion);
                    cmd.Parameters.AddWithValue("@Cmp_Fecha_Orden", fecha);
                    cmd.Parameters.AddWithValue("@Cmp_Estado", estado);

                    cmd.ExecuteNonQuery();
                }

                // Obtener ID generado
                string getId = "SELECT MAX(Pk_Id_Room) FROM Tbl_Room_Service";
                using (OdbcCommand cmd = new OdbcCommand(getId, con))
                {
                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                        idGenerado = Convert.ToInt32(resultado);
                }

                cn.desconexion(con);
            }

            return idGenerado;
        }





        // Insertar detalle de Room Service
        public void InsertarDetalle(int idRoomService, int idMenu, int cantidad, decimal precioUnitario, decimal subtotal)
        {
            string consulta = "INSERT INTO Tbl_Room_Service_Detalle (FK_Id_Room, FK_Id_Menu, Cmp_Cantidad, Cmp_Precio_Unitario, Cmp_Subtotal) " +
                              "VALUES (?, ?, ?, ?, ?)";

            using (OdbcConnection con = cn.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(consulta, con))
                {
                    cmd.Parameters.AddWithValue("@FK_Id_Room", idRoomService);
                    cmd.Parameters.AddWithValue("@FK_Id_Menu", idMenu);
                    cmd.Parameters.AddWithValue("@Cmp_Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@Cmp_Precio_Unitario", precioUnitario);
                    cmd.Parameters.AddWithValue("@Cmp_Subtotal", subtotal);

                    cmd.ExecuteNonQuery();
                }
                cn.desconexion(con);
            }
        }

        // Obtener detalles por idRoomService
        public DataTable ObtenerDetallePorRoomService(int idRoomService)
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT d.Pk_Id_Detalle, m.Cmp_Nombre_Platillo AS Plato, d.Cmp_Cantidad, d.Cmp_Precio_Unitario, d.Cmp_Subtotal " +
                              "FROM Tbl_Room_Service_Detalle d INNER JOIN Tbl_Menu m ON d.FK_Id_Menu = m.Pk_Id_Menu " +
                              "WHERE d.FK_Id_Room = ?";

            using (OdbcConnection con = cn.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(consulta, con))
                {
                    cmd.Parameters.AddWithValue("@FK_Id_Room", idRoomService);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(dt);
                }
                cn.desconexion(con);
            }
            return dt;
        }

        // Eliminar detalles de un RoomService
        public void EliminarDetallesRoomService(int idRoomService)
        {
            string consulta = "DELETE FROM Tbl_Room_Service_Detalle WHERE FK_Id_Room = ?";

            using (OdbcConnection con = cn.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(consulta, con))
                {
                    cmd.Parameters.AddWithValue("@FK_Id_Room", idRoomService);
                    cmd.ExecuteNonQuery();
                }
                cn.desconexion(con);
            }
        }

        // Eliminar RoomService
        public void EliminarRoomService(int idRoomService)
        {
            string consulta = "DELETE FROM Tbl_Room_Service WHERE Pk_Id_Room = ?";

            using (OdbcConnection con = cn.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(consulta, con))
                {
                    cmd.Parameters.AddWithValue("@Pk_Id_Room", idRoomService);
                    cmd.ExecuteNonQuery();
                }
                cn.desconexion(con);
            }
        }

        // Modificar RoomService
        public void ModificarRoomService(int idRoomService, int idHuesped, int idHabitacion, DateTime fecha, string estado)
        {
            string consulta = "UPDATE Tbl_Room_Service SET FK_Id_Huesped = ?, Fk_Id_Habitacion = ?, Cmp_Fecha_Orden = ?, Cmp_Estado = ? " +
                              "WHERE Pk_Id_Room = ?";

            using (OdbcConnection con = cn.conexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(consulta, con))
                {
                    cmd.Parameters.AddWithValue("@FK_Id_Huesped", idHuesped);
                    cmd.Parameters.AddWithValue("@Fk_Id_Habitacion", idHabitacion);
                    cmd.Parameters.AddWithValue("@Cmp_Fecha_Orden", fecha);
                    cmd.Parameters.AddWithValue("@Cmp_Estado", estado);
                    cmd.Parameters.AddWithValue("@Pk_Id_Room", idRoomService);

                    cmd.ExecuteNonQuery();
                }
                cn.desconexion(con);
            }
        }
    }
}





