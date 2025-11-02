using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Ordenes
{
    public class Cls_Sentencias_Ordenes
    {
        Cls_Conexion_Ordenes con = new Cls_Conexion_Ordenes();

        // INSERTAR
        public void Insertar(int idOrden, int idBanco, string fecha, string autorizadoPor, string monto, int idEstado)
        {
            try
            {
                using (OdbcConnection conn = con.conexion())
                {
                    string sql = "INSERT INTO Tbl_Orden_Compra_Autorizada (Fk_Id_Orden_Compra, Fk_Id_Banco, Cmp_Fecha_Autorizacion, Cmp_Autorizado_Por, Cmp_Monto_Autorizado, Fk_Id_Estado_Autorizacion) VALUES (?, ?, ?, ?, ?, ?)";
                    OdbcCommand cmd = new OdbcCommand(sql, conn);

                    cmd.Parameters.AddWithValue("Fk_Id_Orden_Compra", idOrden);
                    cmd.Parameters.AddWithValue("Fk_Id_Banco", idBanco);
                    cmd.Parameters.AddWithValue("Cmp_Fecha_Autorizacion", fecha);
                    cmd.Parameters.AddWithValue("Cmp_Autorizado_Por", autorizadoPor);
                    cmd.Parameters.AddWithValue("Cmp_Monto_Autorizado", monto);
                    cmd.Parameters.AddWithValue("Fk_Id_Estado_Autorizacion", idEstado);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al insertar: " + ex.Message);
            }
        }

        // ELIMINAR
        public void Eliminar(string idAutorizacion)
        {
            try
            {
                using (OdbcConnection conn = con.conexion())
                {
                    string sql = "DELETE FROM Tbl_Orden_Compra_Autorizada WHERE Pk_Id_Autorizacion = ?";
                    OdbcCommand cmd = new OdbcCommand(sql, conn);
                    cmd.Parameters.AddWithValue("Pk_Id_Autorizacion", idAutorizacion);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al eliminar: " + ex.Message);
            }
        }


        // ACTUALIZAR
        public void Actualizar(string idAutorizacion, int idOrden, int idBanco, string fecha, string autorizadoPor, string monto, int idEstado)
        {
            try
            {
                using (OdbcConnection conn = con.conexion())
                {
                    string sql = "UPDATE Tbl_Orden_Compra_Autorizada " +
                                 "SET Fk_Id_Orden_Compra = ?, Fk_Id_Banco = ?, Cmp_Fecha_Autorizacion = ?, " +
                                 "Cmp_Autorizado_Por = ?, Cmp_Monto_Autorizado = ?, Fk_Id_Estado_Autorizacion = ? " +
                                 "WHERE Pk_Id_Autorizacion = ?";

                    OdbcCommand cmd = new OdbcCommand(sql, conn);

                    cmd.Parameters.AddWithValue("Fk_Id_Orden_Compra", idOrden);
                    cmd.Parameters.AddWithValue("Fk_Id_Banco", idBanco);
                    cmd.Parameters.AddWithValue("Cmp_Fecha_Autorizacion", fecha);
                    cmd.Parameters.AddWithValue("Cmp_Autorizado_Por", autorizadoPor);
                    cmd.Parameters.AddWithValue("Cmp_Monto_Autorizado", monto);
                    cmd.Parameters.AddWithValue("Fk_Id_Estado_Autorizacion", idEstado);
                    cmd.Parameters.AddWithValue("Pk_Id_Autorizacion", idAutorizacion);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al actualizar: " + ex.Message);
            }
        }



        // MOSTRAR TABLA
        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (OdbcConnection conn = con.conexion())
                {
                    string sql = "SELECT * FROM Tbl_Orden_Compra_Autorizada";
                    OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                    da.Fill(tabla);
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al mostrar datos: " + ex.Message);
            }

            return tabla;
        }




    }
}
