using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Ordenes;
using System.Data.Odbc;
using System.Data;



namespace Capa_Controlador_Ordenes
{
    public class Cls_Controlador_Ordenes
    {
        Cls_Sentencias_Ordenes sn = new Cls_Sentencias_Ordenes();

        // Cargar una tabla en DataTable
        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        // Insertar una autorización nueva
        public void AgregarAutorizacion(int idOrden, int idBanco, DateTime fecha, string autorizadoPor, decimal monto, int idEstado)
        {
            sn.InsertarAutorizacion(idOrden, idBanco, fecha, autorizadoPor, monto, idEstado);
        }
    }
}

