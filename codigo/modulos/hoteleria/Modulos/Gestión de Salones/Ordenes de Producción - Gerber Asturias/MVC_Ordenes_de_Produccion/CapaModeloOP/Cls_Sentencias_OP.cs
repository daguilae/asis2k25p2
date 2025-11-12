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

        public void pro_insertarOP(DateTime dFecha_solicitud, DateTime dFecha_registro)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.fun_conexion())
            {
                string sql = "INSERT INTO Tbl_Ordenes_Produccion (Cmp_Fecha_Solicitud, Cmp_Fecha_Registro) VALUES (?, ?)";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("fecha_solicitud", dFecha_solicitud);
                    cmd.Parameters.AddWithValue("fecha_registro", dFecha_registro);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void pro_editarOP(int iId, DateTime dFecha_solicitud, DateTime dFecha_registro)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.fun_conexion())
            {
                string sql = "UPDATE Tbl_Ordenes_Produccion SET Cmp_Fecha_Solicitud=?, Cmp_Fecha_Registro=? WHERE Pk_Id_Orden_Produccion=?";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("fecha_solicitud", dFecha_solicitud);
                    cmd.Parameters.AddWithValue("fecha_registro", dFecha_registro);
                    cmd.Parameters.AddWithValue("id", iId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable fun_CargarMenu()
        {
            throw new NotImplementedException();
        }

        public void fun_eliminarMenu(int iId)
        {
            throw new NotImplementedException();
        }

        public void fun_editarMenu(int iId, string sNombre, string sDescripcion, decimal dePrecio, int iIdTipoMenu)
        {
            throw new NotImplementedException();
        }

        public void fun_insertarMenu(string sNombre, string sDescripcion, decimal dePrecio, int iIdTipoMenu)
        {
            throw new NotImplementedException();
        }

        public void pro_eliminarOP(int iId)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.fun_conexion())
            {
                string sql = "DELETE FROM Tbl_Ordenes_Produccion WHERE Pk_Id_Orden_Produccion=?";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("id", iId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable fun_cargarOrdenesProduccion()
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            DataTable tabla = new DataTable();
            using (OdbcConnection con = cn.fun_conexion())
            {
                string sql = "SELECT * FROM Tbl_Ordenes_Produccion";
                using (OdbcDataAdapter da = new OdbcDataAdapter(sql, con))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        public bool fun_tieneRelaciones(int iIdOrden)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.fun_conexion())
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
                    cmd.Parameters.AddWithValue("id1", iIdOrden);
                    cmd.Parameters.AddWithValue("id2", iIdOrden);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }


        // -----------------------------------------------------------
        // MOBILIARIO
        // -----------------------------------------------------------

        public void pro_insertarMobiliario(string sMobiliario)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.fun_conexion())
            {
                string sql = "INSERT INTO Tbl_Mobiliario (Cmp_Mobiliario) VALUES (?)";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("mobiliario", sMobiliario);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void pro_editarMobiliario(int iId, string sMobiliario)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.fun_conexion())
            {
                string sql = "UPDATE Tbl_Mobiliario SET Cmp_Mobiliario=? WHERE Pk_Id_Mobiliario=?";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("mobiliario", sMobiliario);
                    cmd.Parameters.AddWithValue("id", iId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void pro_eliminarMobiliario(int iId)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.fun_conexion())
            {
                string sql = "DELETE FROM Tbl_Mobiliario WHERE Pk_Id_Mobiliario=?";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("id", iId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable fun_cargarMobiliario()
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            DataTable tabla = new DataTable();
            using (OdbcConnection con = cn.fun_conexion())
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

        public void pro_insertarDetalleOrdenMenu(int iIdOrdenProduccion, int iIdMenu, int iCantidad)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.fun_conexion())
            {
                string sql = "INSERT INTO Tbl_Detalle_Ordenes_Menu (Fk_Id_Orden_Produccion, Fk_Id_Menu, Cmp_Cantidad_Platillos) VALUES (?, ?, ?)";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("idOrdenProduccion", iIdOrdenProduccion);
                    cmd.Parameters.AddWithValue("idMenu", iIdMenu);
                    cmd.Parameters.AddWithValue("cantidad", iCantidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void pro_editarDetalleOrdenMenu(int iIdDetalle, int iIdOrdenProduccion, int iIdMenu, int iCantidad)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.fun_conexion())
            {
                string sql = "UPDATE Tbl_Detalle_Ordenes_Menu SET Fk_Id_Orden_Produccion=?, Fk_Id_Menu=?, Cmp_Cantidad_Platillos=? WHERE Pk_Id_Detalle_Orden=?";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("idOrdenProduccion", iIdOrdenProduccion);
                    cmd.Parameters.AddWithValue("idMenu", iIdMenu);
                    cmd.Parameters.AddWithValue("cantidad", iCantidad);
                    cmd.Parameters.AddWithValue("idDetalle", iIdDetalle);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void pro_eliminarDetalleOrdenMenu(int iIdDetalle)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.fun_conexion())
            {
                string sql = "DELETE FROM Tbl_Detalle_Ordenes_Menu WHERE Pk_Id_Detalle_Orden=?";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("idDetalle", iIdDetalle);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable fun_cargarDetalleOrdenMenu()
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            DataTable tabla = new DataTable();
            using (OdbcConnection con = cn.fun_conexion())
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

        public DataTable fun_cargarComboOrdenesProduccion()
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            DataTable tabla = new DataTable();
            using (OdbcConnection con = cn.fun_conexion())
            {
                string sql = "SELECT Pk_Id_Orden_Produccion FROM Tbl_Ordenes_Produccion";
                using (OdbcDataAdapter da = new OdbcDataAdapter(sql, con))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        public DataTable fun_cargarComboMenu()
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            DataTable tabla = new DataTable();
            using (OdbcConnection con = cn.fun_conexion())
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

        public void pro_insertarDetalleOrdenMobiliario(int iIdOrden, int iIdMobiliario, int iCantidad)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.fun_conexion())
            {
                string sql = "INSERT INTO Tbl_Detalle_Ordenes_Mobiliario (Fk_Id_Orden_Produccion, Fk_Id_Mobiliario, Cmp_Cantidad_Mobiliario) VALUES (?, ?, ?)";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("idOrden", iIdOrden);
                    cmd.Parameters.AddWithValue("idMobiliario", iIdMobiliario);
                    cmd.Parameters.AddWithValue("cantidad", iCantidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void pro_editarDetalleOrdenMobiliario(int iIdDetalle, int iIdOrden, int iIdMobiliario, int iCantidad)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.fun_conexion())
            {
                string sql = "UPDATE Tbl_Detalle_Ordenes_Mobiliario SET Fk_Id_Orden_Produccion=?, Fk_Id_Mobiliario=?, Cmp_Cantidad_Mobiliario=? WHERE Pk_Id_Detalle_Orden_Mobiliario=?";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("idOrden", iIdOrden);
                    cmd.Parameters.AddWithValue("idMobiliario", iIdMobiliario);
                    cmd.Parameters.AddWithValue("cantidad", iCantidad);
                    cmd.Parameters.AddWithValue("idDetalle", iIdDetalle);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void pro_eliminarDetalleOrdenMobiliario(int iIdDetalle)
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            using (OdbcConnection con = cn.fun_conexion())
            {
                string sql = "DELETE FROM Tbl_Detalle_Ordenes_Mobiliario WHERE Pk_Id_Detalle_Orden_Mobiliario=?";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("idDetalle", iIdDetalle);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable fun_cargarDetalleOrdenMobiliario()
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            DataTable tabla = new DataTable();
            using (OdbcConnection con = cn.fun_conexion())
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

        public DataTable fun_cargarComboMobiliario()
        {
            Cls_Conexion_OP cn = new Cls_Conexion_OP();
            DataTable tabla = new DataTable();
            using (OdbcConnection con = cn.fun_conexion())
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

