using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Ordenes
{
    public class Cls_Sentencias_Ordenes
    {
        Cls_Conexion_Ordenes con = new Cls_Conexion_Ordenes();

  
        public OdbcDataAdapter llenarTbl(string tabla)
        {
            string sql = "SELECT * FROM " + tabla + ";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

  
        public void InsertarAutorizacion(int idOrden, int idBanco, DateTime fecha, string autorizadoPor, decimal monto, int idEstado)
        {
            try
            {
                using (OdbcConnection conn = con.conexion())
                {
                    string sql = @"INSERT INTO Tbl_Orden_Compra_Autorizada
                                   (Fk_Id_Orden_Compra, Fk_Id_Banco, Cmp_Fecha_Autorizacion, Cmp_Autorizado_Por, Cmp_Monto_Autorizado, Fk_Id_Estado_Autorizacion)
                                   VALUES (?, ?, ?, ?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.Add("Fk_Id_Orden_Compra", OdbcType.Int).Value = idOrden;
                        cmd.Parameters.Add("Fk_Id_Banco", OdbcType.Int).Value = idBanco;
                        cmd.Parameters.Add("Cmp_Fecha_Autorizacion", OdbcType.Date).Value = fecha;
                        cmd.Parameters.Add("Cmp_Autorizado_Por", OdbcType.VarChar).Value = autorizadoPor;
                        cmd.Parameters.Add("Cmp_Monto_Autorizado", OdbcType.Decimal).Value = monto;
                        cmd.Parameters.Add("Fk_Id_Estado_Autorizacion", OdbcType.Int).Value = idEstado;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine(" Error al insertar la autorización: " + ex.Message);
                throw;
            }
        }
    }
}
