using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Ordenes
{
    public class Cls_Sentencias_Ordenes
    {
        Cls_Conexion_Ordenes con = new Cls_Conexion_Ordenes();

        // Método para obtener todas las órdenes autorizadas con información completa
        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }
    }
}
