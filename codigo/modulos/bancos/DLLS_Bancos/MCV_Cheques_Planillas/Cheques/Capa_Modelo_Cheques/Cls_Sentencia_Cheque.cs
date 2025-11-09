using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;




namespace Capa_Modelo_Cheques
{
    public class Cls_Sentencia_Cheque
    {    // Instancia de la clase de conexión
        Cls_Conexion_Cheque con = new Cls_Conexion_Cheque();
        // 1️ Crear nuevo lote y devolver su ID

        public int InsertarLote(string usuario)
        {
            int idGenerado = 0;

            try
            {
                string sql = "INSERT INTO Tbl_LotesCheques (Cmp_UsuarioCrea) VALUES (?)";

                using (OdbcConnection cnx = con.conexion())
                {
                    OdbcCommand cmd = new OdbcCommand(sql, cnx);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.ExecuteNonQuery();

                    cmd = new OdbcCommand("SELECT LAST_INSERT_ID()", cnx);
                    idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error InsertarLote: " + ex.Message);
            }

            return idGenerado;
        }


        public void InsertarCheque(int idLote, int numeroCheque, string nombre, decimal monto)
        {
            try
            {
                string sql = @"INSERT INTO Tbl_DetalleLoteCheques
                               (Fk_Id_Lote, Cmp_NumeroCheque, Cmp_NombreEmpleado, Cmp_Monto)
                               VALUES (?, ?, ?, ?)";

                using (OdbcConnection cnx = con.conexion())
                {
                    OdbcCommand cmd = new OdbcCommand(sql, cnx);
                    cmd.Parameters.AddWithValue("@lote", idLote);
                    cmd.Parameters.AddWithValue("@numcheque", numeroCheque);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@monto", monto);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error InsertarCheque: " + ex.Message);
            }
        }


        public void ActualizarTotal(int idLote)
        {
            string sql = @"UPDATE Tbl_LotesCheques 
                           SET Cmp_TotalCheques = 
                               (SELECT IFNULL(SUM(Cmp_Monto),0) 
                                FROM Tbl_DetalleLoteCheques 
                                WHERE Fk_Id_Lote = ?)
                           WHERE Pk_Id_Lote = ?";

            try
            {
                using (OdbcConnection cnx = con.conexion())
                {
                    OdbcCommand cmd = new OdbcCommand(sql, cnx);
                    cmd.Parameters.AddWithValue("@id1", idLote);
                    cmd.Parameters.AddWithValue("@id2", idLote);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error ActualizarTotal: " + ex.Message);
            }
        }



    }


}

