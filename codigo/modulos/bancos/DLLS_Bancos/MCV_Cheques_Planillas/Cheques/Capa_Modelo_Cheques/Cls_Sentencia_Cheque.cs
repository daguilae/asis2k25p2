using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
//REALIZADO POR ROCIO LOPEZ 



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
                    cmd.Parameters.AddWithValue(" ", usuario);
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


        public void InsertarCheque(int idLote, int numeroCheque, string nombre, decimal monto, int idBanco)
        {
            try
            {
                string sql = @"INSERT INTO Tbl_DetalleLoteCheques
                       (Fk_Id_Lote, Cmp_NumeroCheque, Cmp_NombreEmpleado, Cmp_Monto, Cmp_Banco)
                       VALUES (?, ?, ?, ?, ?)";

                using (OdbcConnection cnx = con.conexion())
                {
                    OdbcCommand cmd = new OdbcCommand(sql, cnx);

                    cmd.Parameters.Add("Fk_Id_Lote", OdbcType.Int).Value = idLote;
                    cmd.Parameters.Add("Cmp_NumeroCheque", OdbcType.VarChar).Value = numeroCheque.ToString();
                    cmd.Parameters.Add("Cmp_NombreEmpleado", OdbcType.VarChar).Value = nombre;
                    cmd.Parameters.Add("Cmp_Monto", OdbcType.Decimal).Value = monto;
                    cmd.Parameters.Add("Cmp_Banco", OdbcType.Int).Value = idBanco;

                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine($"✅ Insertado cheque: {nombre} (Banco: {idBanco})");
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ ERROR InsertarCheque: " + ex.Message);
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
                    cmd.Parameters.AddWithValue(" ", idLote);
                    cmd.Parameters.AddWithValue(" ", idLote);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error ActualizarTotal: " + ex.Message);
            }
        }

        public DataTable ObtenerCuentasBancarias()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT Pk_Id_CuentaBancaria AS ID, Cmp_NumeroCuenta AS Cuenta FROM Tbl_CuentasBancarias";

            using (OdbcConnection cnx = con.conexion())
            {
                OdbcCommand cmd = new OdbcCommand(sql, cnx);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }

        public DataTable ObtenerBancosContabilidad()
        {
            DataTable dt = new DataTable();

            string query = "SELECT Pk_Id_Banco AS ID, Cmp_NombreBanco AS Banco FROM Tbl_Bancos";

            using (OdbcConnection cnx = con.conexion())
            {
                OdbcCommand cmd = new OdbcCommand(query, cnx);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
        public bool InsertarChequePrueba()
        {
            try
            {
                using (OdbcConnection cnx = con.conexion())
                {
                    cnx.Open();

                    string sql = @"INSERT INTO Tbl_DetalleLoteCheques
               (Fk_Id_Lote, Cmp_NumeroCheque, Cmp_NombreEmpleado, Cmp_Monto, Cmp_Banco, Cmp_Estado)
               VALUES (?, ?, ?, ?, 1, 1)";

                    OdbcCommand cmd = new OdbcCommand(sql, cnx);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ ERROR InsertarChequePrueba: " + ex.Message);
                return false;
            }
        }

        public DataTable ObtenerLotes()
        {
            DataTable tabla = new DataTable();

            string sql = @"SELECT 
                        Pk_Id_Lote AS ID, 
                        CONCAT('Lote ', Pk_Id_Lote, ' - ', DATE_FORMAT(Cmp_FechaCreacion, '%d/%m/%Y')) AS Nombre
                   FROM Tbl_LotesCheques
                   ORDER BY Pk_Id_Lote DESC";

            using (OdbcConnection cnx = con.conexion())
            {
                OdbcCommand cmd = new OdbcCommand(sql, cnx);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }

    }


}

