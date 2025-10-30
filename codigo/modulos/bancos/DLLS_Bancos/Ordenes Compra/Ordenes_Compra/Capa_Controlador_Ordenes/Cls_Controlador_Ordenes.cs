using System;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Ordenes;

namespace Capa_Controlador_Ordenes
{
    public class Cls_Controlador_Ordenes
    {
        Cls_Sentencias_Ordenes sn = new Cls_Sentencias_Ordenes();


        public DataTable LlenarTabla(string tabla)
        {
            OdbcDataAdapter dt = sn.LlenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public bool AgregarAutorizacion(
     string idAutorizacion, string idOrden, string idBanco, string fecha, string autorizadoPor, string monto, string estado)
{
    try
    {
        int pk = int.Parse(idAutorizacion);
        int fkOrden = int.Parse(idOrden);
        int fkBanco = int.Parse(idBanco);
        decimal montoDec = decimal.Parse(monto);
        int fkEstado = int.Parse(estado);

        return sn.AgregarAutorizacion(pk, fkOrden, fkBanco, fecha, autorizadoPor, montoDec, fkEstado);
    }
    catch (Exception ex)
    {
                Console.WriteLine("Error en el controlador: " + ex.Message);
        return false;
    }
}

    }
}
