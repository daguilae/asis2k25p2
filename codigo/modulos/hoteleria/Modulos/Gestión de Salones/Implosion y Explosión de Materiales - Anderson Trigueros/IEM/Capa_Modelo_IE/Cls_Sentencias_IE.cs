using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_IE
{
    public class Cls_Sentencias_IE
    {
        public DataTable fun_ObtenerMenus()
        {
            Cls_Conexion_IE conexion = new Cls_Conexion_IE();
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaMenus = "SELECT m.Pk_Id_Menu AS codigoMenu, m.Cmp_Nombre_Platillo as Platillo FROM Tbl_Menu m";
                    OdbcCommand cmd = new OdbcCommand(sConsultaMenus, con);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los menús: " + ex.Message, ex);
            }
            return tabla;
        }
        public DataTable fun_ObtenerReceta(int iCodigoMenu)
        {
            Cls_Conexion_IE conexion = new Cls_Conexion_IE();
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaReceta = @"SELECT mp.Cmp_Materia_Prima AS ingrediente,
                                              r.Cmp_Cantidad as cantidad, r.Cmp_Unidad_Medida AS unidadMedida
                                              FROM Tbl_Receta r
                                              JOIN Tbl_Menu m ON r.Fk_Id_Menu = m.Pk_Id_Menu
                                              JOIN Tbl_Materia_Prima mp ON r.Fk_Id_Materia_Prima = mp.Pk_Id_Materia_Prima
                                              WHERE r.Fk_Id_Menu = ?";
                    OdbcCommand cmd = new OdbcCommand(sConsultaReceta, con);
                    cmd.Parameters.AddWithValue("", iCodigoMenu);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los menús: " + ex.Message, ex);
            }
            return tabla;
        }

        public List<(string sCodigo, string sIngrediente, double doStock, string sUnidad)> fun_ConsultarInventario(List<string> Ingredientes)
        {
            Cls_Conexion_IE conexion = new Cls_Conexion_IE();
            List<(string sCodigo, string sIngrediente, double doStock, string sUnidad)> resultado =
                new List<(string sCodigo, string sIngrediente, double doStock, string sUnidad)>();

            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    // Consulta rápida
                    string sIngredientes = string.Join(",", Ingredientes.Select(_ => "?"));

                    string sConsulta = $@"SELECT p.Cmp_Id_Producto AS Codigo,
                                                 p.Cmp_Nombre_Producto AS Producto,
                                                 e.Cmp_Cantidad AS Cantidad,
                                                 u.Cmp_Nombre_Unidad AS Unidad
                                          FROM Tbl_Existencia e
                                          JOIN Tbl_Producto p ON e.Cmp_Id_Producto = p.Cmp_Id_Producto
                                          JOIN Tbl_Unidad_Medida u ON p.Cmp_Id_Unidad_Base = u.Cmp_Id_Unidad_Medida
                                          WHERE p.Cmp_Nombre_Producto IN ({sIngredientes})";

                    OdbcCommand cmd = new OdbcCommand(sConsulta, con);

                    foreach (var ing in Ingredientes)
                        cmd.Parameters.AddWithValue("", ing);

                    Dictionary<string, (string sCodigo, double doStock, string sUnidad)> datos =
                        new Dictionary<string, (string sCodigo, double doStock, string sUnidad)>();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string sNombre = reader["Producto"].ToString();
                            string sCodigo = reader["Codigo"].ToString();
                            double doCantidad = 0;

                            if (reader["Cantidad"] != DBNull.Value)
                            {
                                string sCantidad = reader["Cantidad"]?.ToString();
                                if (!double.TryParse(sCantidad, System.Globalization.NumberStyles.Any,
                                                     System.Globalization.CultureInfo.InvariantCulture,
                                                     out doCantidad))
                                {
                                    doCantidad = 0;
                                }
                            }
                            else
                            {
                                doCantidad = 0;
                            }
                            string sUnidad = reader["Unidad"].ToString();

                            datos[sNombre] = (sCodigo, doCantidad, sUnidad);
                        }
                    }

                    foreach (var ing in Ingredientes)
                    {
                        if (datos.ContainsKey(ing))
                        {
                            var dato = datos[ing];
                            resultado.Add((dato.sCodigo, ing, dato.doStock, dato.sUnidad));
                        }
                        else
                        {
                            resultado.Add(("", ing, 0, "")); // No encontrado
                        }
                    }
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar inventario: " + ex.Message, ex);
            }
        }


        public void pro_GuardarOrdenCompra(List<(int iCodigo, double doCantidad)> Listado)
        {
            Cls_Conexion_IE conexion = new Cls_Conexion_IE();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    using (var transaction = con.BeginTransaction())
                    {
                        try
                        {
                            string sIngresoEncabezado = @"INSERT INTO Tbl_OC (Cmp_Fecha_OC) VALUES (CURRENT_DATE)";
                            OdbcCommand cmdEnc = new OdbcCommand(sIngresoEncabezado, con, transaction);
                            cmdEnc.ExecuteNonQuery();

                            int iCodigoOrdenCompra = 0;
                            OdbcCommand cmdLast = new OdbcCommand("SELECT LAST_INSERT_ID()", con, transaction);
                            iCodigoOrdenCompra = Convert.ToInt32(cmdLast.ExecuteScalar());

                            foreach (var item in Listado)
                            {
                                int iCodigoProducto = item.iCodigo;
                                double doCantidadSolicitada = item.doCantidad;

                                string sIngresoDetalle = @"INSERT INTO Tbl_OC_Det(Cmp_Id_OC,Cmp_Id_Producto,Cmp_Cantidad)
                                                            VALUES (?,?,?)";
                                OdbcCommand cmdDet = new OdbcCommand(sIngresoDetalle, con, transaction);
                                cmdDet.Parameters.AddWithValue("", iCodigoOrdenCompra);
                                cmdDet.Parameters.AddWithValue("", iCodigoProducto);
                                cmdDet.Parameters.AddWithValue("", doCantidadSolicitada);
                                cmdDet.ExecuteNonQuery();
                            }
                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar la orden de compra." + ex.Message, ex);
            }
        }

        public DataTable fun_ObtenerOrdenes()
        {
            Cls_Conexion_IE conexion = new Cls_Conexion_IE();
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaOrdenes = @"SELECT d.Cmp_Id_OC_Det as codigo,
                                                d.Cmp_Id_OC as CodigoOrden, p.Cmp_Nombre_Producto AS producto,
                                                o.Cmp_Fecha_OC as Fecha, d.Cmp_Cantidad as Cantidad
                                                FROM Tbl_OC_Det d
                                                JOIN Tbl_OC o ON d.Cmp_Id_OC = o.Cmp_Id_OC
                                                JOIN Tbl_Producto p ON d.Cmp_Id_Producto = p.Cmp_Id_Producto
                                                ORDER BY o.Cmp_Fecha_OC DESC";
                    OdbcCommand cmd = new OdbcCommand(sConsultaOrdenes, con);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las ordenes de compra: " + ex.Message, ex);
            }
            return tabla;
        }

        public void pro_ActualizarCantidad(int iCodigoDetalle, double doCantidad)
        {
            Cls_Conexion_IE conexion = new Cls_Conexion_IE();
            try
            {
                using(OdbcConnection con = conexion.conexion())
                {
                    string sActualizar = @"UPDATE Tbl_OC_Det d 
                                           SET d.Cmp_Cantidad = ? WHERE d.Cmp_Id_OC_Det = ?";
                    OdbcCommand cmd = new OdbcCommand(sActualizar, con);
                    cmd.Parameters.AddWithValue("", doCantidad);
                    cmd.Parameters.AddWithValue("", iCodigoDetalle);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar: " + ex.Message, ex);
            }
        }
        public void pro_EliminarOrden(int iCodigoDetalle)
        {
            Cls_Conexion_IE conexion = new Cls_Conexion_IE();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sActualizar = @"DELETE FROM Tbl_OC_Det d 
                                           WHERE d.Cmp_Id_OC_Det = ?";
                    OdbcCommand cmd = new OdbcCommand(sActualizar, con);
                    cmd.Parameters.AddWithValue("", iCodigoDetalle);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar: " + ex.Message, ex);
            }
        }
    }
}
