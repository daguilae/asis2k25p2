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
        public DataTable fun_ObtenerReceta(int codigoMenu)
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
                    cmd.Parameters.AddWithValue("", codigoMenu);
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

    }
}
