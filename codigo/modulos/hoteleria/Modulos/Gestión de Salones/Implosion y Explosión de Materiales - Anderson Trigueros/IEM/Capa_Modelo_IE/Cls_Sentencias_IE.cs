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

        public List<(string sIngrediente, double doStock)> ConsultarInventario(List<string> Ingredientes)
        {
            Cls_Conexion_IE conexion = new Cls_Conexion_IE();
            List<(string sIngrediente, double doStock)> Inventario = new List<(string sIngrediente, double doStock)>();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    foreach (string sIngrediente in Ingredientes)
                    {
                        string sConsultaInventario = @"SELECT p.Cmp_Nombre_Producto AS Producto,
                                                      e.Cmp_Cantidad as Cantidad
                                                      FROM Tbl_Existencia e
                                                      JOIN Tbl_Producto p ON e.Cmp_Id_Producto = p.Cmp_Id_Producto
                                                      WHERE p.Cmp_Nombre_Producto = ?";
                        OdbcCommand cmd = new OdbcCommand(sConsultaInventario, con);
                        cmd.Parameters.AddWithValue("", sIngrediente);
                        using (OdbcDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    double doCantidad = Convert.ToDouble(reader["Cantidad"]);
                                    Inventario.Add((sIngrediente, doCantidad));
                                }
                            }
                            else
                            {
                                Inventario.Add((sIngrediente, 0));
                            }
                        }
                    }
                    return Inventario;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar inventario: " + ex.Message, ex);
            }
        }

        public void GuardarOrdenCompra(List<(string sIngrediente, double doCantidad)> Listado)
        {

        }
    }
}
