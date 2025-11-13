using System;
using System.Data;
using System.Data.Odbc;

namespace CapaModeloOP
{
    public class Cls_Sentencias_OP
    {
        // -----------------------------------------------------------
        // ORDENES DE PRODUCCIÓN
        // -----------------------------------------------------------

        public void InsertarOP(DateTime fecha_solicitud, DateTime fecha_registro)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "INSERT INTO Tbl_Ordenes_Produccion (Cmp_Fecha_Solicitud, Cmp_Fecha_Registro) VALUES (?, ?)";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("fecha_solicitud", fecha_solicitud);
                    cmd.Parameters.AddWithValue("fecha_registro", fecha_registro);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditarOP(int id, DateTime fecha_solicitud, DateTime fecha_registro)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "UPDATE Tbl_Ordenes_Produccion SET Cmp_Fecha_Solicitud=?, Cmp_Fecha_Registro=? WHERE Pk_Id_Orden_Produccion=?";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("fecha_solicitud", fecha_solicitud);
                    cmd.Parameters.AddWithValue("fecha_registro", fecha_registro);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable CargarMenu()
        {
            throw new NotImplementedException();
        }

        public void EliminarMenu(int id)
        {
            throw new NotImplementedException();
        }

        public void EditarMenu(int id, string nombre, string descripcion, decimal precio, int idTipoMenu)
        {
            throw new NotImplementedException();
        }

        public void InsertarMenu(string nombre, string descripcion, decimal precio, int idTipoMenu)
        {
            throw new NotImplementedException();
        }

        public void EliminarOP(int id)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "DELETE FROM Tbl_Ordenes_Produccion WHERE Pk_Id_Orden_Produccion=?";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable CargarOrdenesProduccion()
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            DataTable tabla = new DataTable();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "SELECT * FROM Tbl_Ordenes_Produccion";
                using (OdbcDataAdapter da = new OdbcDataAdapter(sql, con))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        public bool TieneRelaciones(int idOrden)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = @"
            SELECT COUNT(*) 
            FROM (
                SELECT Fk_Id_Orden_Produccion FROM Tbl_Detalle_Ordenes_Menu WHERE Fk_Id_Orden_Produccion=?
                UNION ALL
                SELECT Fk_Id_Orden_Produccion FROM Tbl_Detalle_Ordenes_Mobiliario WHERE Fk_Id_Orden_Produccion=?
            ) AS relaciones";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("id1", idOrden);
                    cmd.Parameters.AddWithValue("id2", idOrden);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }


        // -----------------------------------------------------------
        // MOBILIARIO
        // -----------------------------------------------------------

        public void InsertarMobiliario(string mobiliario)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "INSERT INTO Tbl_Mobiliario (Cmp_Mobiliario) VALUES (?)";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("mobiliario", mobiliario);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditarMobiliario(int id, string mobiliario)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "UPDATE Tbl_Mobiliario SET Cmp_Mobiliario=? WHERE Pk_Id_Mobiliario=?";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("mobiliario", mobiliario);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarMobiliario(int id)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "DELETE FROM Tbl_Mobiliario WHERE Pk_Id_Mobiliario=?";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable CargarMobiliario()
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            DataTable tabla = new DataTable();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "SELECT * FROM Tbl_Mobiliario";
                using (OdbcDataAdapter da = new OdbcDataAdapter(sql, con))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        // -----------------------------------------------------------
        // DETALLE ORDEN MENÚ
        // -----------------------------------------------------------

        public void InsertarDetalleOrdenMenu(int idOrdenProduccion, int idMenu, int cantidad)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "INSERT INTO Tbl_Detalle_Ordenes_Menu (Fk_Id_Orden_Produccion, Fk_Id_Menu, Cmp_Cantidad_Platillos) VALUES (?, ?, ?)";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("idOrdenProduccion", idOrdenProduccion);
                    cmd.Parameters.AddWithValue("idMenu", idMenu);
                    cmd.Parameters.AddWithValue("cantidad", cantidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditarDetalleOrdenMenu(int idDetalle, int idOrdenProduccion, int idMenu, int cantidad)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "UPDATE Tbl_Detalle_Ordenes_Menu SET Fk_Id_Orden_Produccion=?, Fk_Id_Menu=?, Cmp_Cantidad_Platillos=? WHERE Pk_Id_Detalle_Orden=?";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("idOrdenProduccion", idOrdenProduccion);
                    cmd.Parameters.AddWithValue("idMenu", idMenu);
                    cmd.Parameters.AddWithValue("cantidad", cantidad);
                    cmd.Parameters.AddWithValue("idDetalle", idDetalle);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarDetalleOrdenMenu(int idDetalle)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "DELETE FROM Tbl_Detalle_Ordenes_Menu WHERE Pk_Id_Detalle_Orden=?";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("idDetalle", idDetalle);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable CargarDetalleOrdenMenu()
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            DataTable tabla = new DataTable();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = @"SELECT d.Pk_Id_Detalle_Orden,
                                      d.Fk_Id_Orden_Produccion,
                                      d.Fk_Id_Menu,
                                      m.Cmp_Nombre_Platillo,
                                      d.Cmp_Cantidad_Platillos
                               FROM Tbl_Detalle_Ordenes_Menu d
                               INNER JOIN Tbl_Menu m ON d.Fk_Id_Menu = m.Pk_Id_Menu";
                using (OdbcDataAdapter da = new OdbcDataAdapter(sql, con))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        // -----------------------------------------------------------
        // COMBOS
        // -----------------------------------------------------------

        public DataTable CargarComboOrdenesProduccion()
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            DataTable tabla = new DataTable();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "SELECT Pk_Id_Orden_Produccion FROM Tbl_Ordenes_Produccion";
                using (OdbcDataAdapter da = new OdbcDataAdapter(sql, con))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        public DataTable CargarComboMenu()
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            DataTable tabla = new DataTable();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "SELECT Pk_Id_Menu, Cmp_Nombre_Platillo FROM Tbl_Menu";
                using (OdbcDataAdapter da = new OdbcDataAdapter(sql, con))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        // -----------------------------------------------------------
        // DETALLE ORDEN MOBILIARIO
        // -----------------------------------------------------------

        public void InsertarDetalleOrdenMobiliario(int idOrden, int idMobiliario, int cantidad)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "INSERT INTO Tbl_Detalle_Ordenes_Mobiliario (Fk_Id_Orden_Produccion, Fk_Id_Mobiliario, Cmp_Cantidad_Mobiliario) VALUES (?, ?, ?)";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("idOrden", idOrden);
                    cmd.Parameters.AddWithValue("idMobiliario", idMobiliario);
                    cmd.Parameters.AddWithValue("cantidad", cantidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditarDetalleOrdenMobiliario(int idDetalle, int idOrden, int idMobiliario, int cantidad)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "UPDATE Tbl_Detalle_Ordenes_Mobiliario SET Fk_Id_Orden_Produccion=?, Fk_Id_Mobiliario=?, Cmp_Cantidad_Mobiliario=? WHERE Pk_Id_Detalle_Orden_Mobiliario=?";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("idOrden", idOrden);
                    cmd.Parameters.AddWithValue("idMobiliario", idMobiliario);
                    cmd.Parameters.AddWithValue("cantidad", cantidad);
                    cmd.Parameters.AddWithValue("idDetalle", idDetalle);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarDetalleOrdenMobiliario(int idDetalle)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "DELETE FROM Tbl_Detalle_Ordenes_Mobiliario WHERE Pk_Id_Detalle_Orden_Mobiliario=?";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("idDetalle", idDetalle);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable CargarDetalleOrdenMobiliario()
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            DataTable tabla = new DataTable();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = @"SELECT d.Pk_Id_Detalle_Orden_Mobiliario,
                                      d.Fk_Id_Orden_Produccion,
                                      d.Fk_Id_Mobiliario,
                                      m.Cmp_Mobiliario,
                                      d.Cmp_Cantidad_Mobiliario
                               FROM Tbl_Detalle_Ordenes_Mobiliario d
                               INNER JOIN Tbl_Mobiliario m ON d.Fk_Id_Mobiliario = m.Pk_Id_Mobiliario";
                using (OdbcDataAdapter da = new OdbcDataAdapter(sql, con))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        public DataTable CargarComboMobiliario()
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            DataTable tabla = new DataTable();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "SELECT Pk_Id_Mobiliario, Cmp_Mobiliario FROM Tbl_Mobiliario";
                using (OdbcDataAdapter da = new OdbcDataAdapter(sql, con))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }
    }
}

