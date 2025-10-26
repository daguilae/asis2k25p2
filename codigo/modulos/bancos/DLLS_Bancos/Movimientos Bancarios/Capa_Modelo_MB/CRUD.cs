using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_MB
{
    public class CRUD
    {
        Conexion cn = new Conexion();

        // Obtener las cuentas bancarias
        public DataTable ObtenerCuentas()
        {
            try
            {
                string sql = @"SELECT 
                            Pk_Id_Cuenta, 
                            Cmp_Numero_Cuenta,
                            Cmp_Nombre_Cuenta
                       FROM Tbl_Cuenta_Bancaria
                       WHERE Cmp_Estado_Cuenta = 1";


                OdbcDataAdapter da = new OdbcDataAdapter(sql, cn.ConexionBD());
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las cuentas: " + ex.Message);
            }
        }


        public string ObtenerNombreCuenta(int idCuenta)
        {
            string nombreCuenta = "";

            try
            {
                string sql = @"SELECT Cmp_Nombre_Cuenta
                       FROM Tbl_Cuenta_Bancaria
                       WHERE Pk_Id_Cuenta = ?";

                using (OdbcConnection conn = cn.ConexionBD())
                {
                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Pk_Id_Cuenta", idCuenta);
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                            nombreCuenta = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el nombre de la cuenta: " + ex.Message);
            }

            return nombreCuenta;
        }

        public DataTable ObtenerOperaciones()
        {
            try
            {
                string sql = @"SELECT 
                        Pk_Id_operacion, 
                        Cmp_nombre 
                       FROM Tbl_Operaciones_Bancarias
                       WHERE Cmp_estado = 'Activo'";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, cn.ConexionBD());
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las operaciones bancarias: " + ex.Message);
            }
        }
    }
}
