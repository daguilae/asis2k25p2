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
            int idLote = 0;

            try
            {
                string sql = "INSERT INTO Tbl_LotesCheques (Cmp_UsuarioCrea, Cmp_TotalCheques, Cmp_Estado) VALUES (?, 0.00, 'Pendiente')";
                using (OdbcConnection conn = con.conexion())
                {
                    // Insertar el nuevo lote
                    OdbcCommand cmd = new OdbcCommand(sql, conn);
                    cmd.Parameters.AddWithValue("usuario", usuario);
                    cmd.ExecuteNonQuery();

                    // Obtener el último ID insertado
                    cmd = new OdbcCommand("SELECT LAST_INSERT_ID()", conn);
                    idLote = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error al insertar lote: " + ex.Message);
            }

            return idLote; // Devuelve el ID para usarlo en los cheques
        }

        // 2️⃣ Insertar un cheque en el detalle
        public void InsertarCheque(int idLote, string numeroCheque, string nombreEmpleado, decimal monto)
        {
            try
            {
                string query = @"INSERT INTO Tbl_DetalleLoteCheques 
                                (Fk_Id_Lote, Cmp_NumeroCheque, Cmp_Monto, Cmp_EstadoEnvio)
                                VALUES (?, ?, ?, 'Pendiente')";

                using (OdbcConnection conn = con.conexion())
                {
                    OdbcCommand cmd = new OdbcCommand(query, conn);
                    cmd.Parameters.AddWithValue("lote", idLote);
                    cmd.Parameters.AddWithValue("numCheque", numeroCheque);
                    cmd.Parameters.AddWithValue("monto", monto);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error al insertar cheque: " + ex.Message);
            }
        }





        // 3️ Actualizar total del lote
        public void ActualizarTotalLote(int idLote)
        {
            try
            {
                string sql = "UPDATE Tbl_LotesCheques SET Cmp_TotalCheques = (SELECT SUM(Cmp_Monto) FROM Tbl_DetalleLoteCheques WHERE Fk_Id_Lote = ?) WHERE Pk_Id_Lote = ?;";
                using (OdbcConnection conn = con.conexion())
                {
                    OdbcCommand cmd = new OdbcCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id1", idLote);
                    cmd.Parameters.AddWithValue("@id2", idLote);
                    cmd.ExecuteNonQuery();
                    con.desconexion(conn);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar total: " + ex.Message);
            }
        }






    }


}

