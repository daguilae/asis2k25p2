using System.Data;
using System;
using System.Data.Odbc;

namespace Capa_Modelo_Cierre
{//================================= KEVIN NATARENO, 0901-21-635 =================================================
    public class Cls_CRUD_Cierre
    {
        private Cls_Conexion objConexion = new Cls_Conexion();

        // ================================
        // OBTENER CUENTAS BANCARIAS
        // ================================
        public DataTable fun_obtener_cuentas()
        {
            string sQuery = "SELECT Pk_Id_CuentaBancaria, Cmp_NumeroCuenta FROM Tbl_CuentasBancarias";
            OdbcConnection conn = objConexion.conexion();

            OdbcDataAdapter da = new OdbcDataAdapter(sQuery, conn);
            DataTable dtResultado = new DataTable();
            da.Fill(dtResultado);

            objConexion.desconexion(conn);
            return dtResultado;
        }

        // ================================
        // OBTENER CIERRES EXISTENTES
        // ================================
        public DataTable fun_obtener_cierres(int iCuenta, int iAnio, int iMes)
        {
            string sQuery = $@"
                SELECT * 
                FROM Tbl_CierreBancario 
                WHERE Fk_Id_CuentaBancaria = {iCuenta}
                  AND Cmp_AnioCierre = {iAnio}
                  AND Cmp_MesCierre = {iMes}";

            OdbcConnection conn = objConexion.conexion();

            OdbcDataAdapter da = new OdbcDataAdapter(sQuery, conn);
            DataTable dtResultado = new DataTable();
            da.Fill(dtResultado);

            objConexion.desconexion(conn);
            return dtResultado;
        }

        public DataTable fun_obtener_todos_cierres()
        {
            string sQuery = "SELECT * FROM Tbl_CierreBancario ORDER BY Cmp_AnioCierre, Cmp_MesCierre, Fk_Id_CuentaBancaria";
            OdbcConnection conn = objConexion.conexion();
            OdbcDataAdapter da = new OdbcDataAdapter(sQuery, conn);
            DataTable dtResultado = new DataTable();
            da.Fill(dtResultado);
            objConexion.desconexion(conn);
            return dtResultado;
        }







        // ================================
        // INSERTAR NUEVO CIERRE
        // ================================
        public void fun_guardar_cierre(Cls_Modelo_Cierre obj)
        {
            try
            {
                using (OdbcConnection conn = objConexion.conexion())
                {
                    string sSql = @"
                        INSERT INTO Tbl_CierreBancario
                        (
                            Fk_Id_CuentaBancaria,
                            Cmp_AnioCierre,
                            Cmp_MesCierre,
                            Cmp_SaldoInicial,
                            Cmp_SaldoFinal,
                            Cmp_SaldoConciliado,
                            Cmp_Estado,
                            Cmp_Observaciones,
                            Cmp_UsuarioRegistro
                        )
                        VALUES (?,?,?,?,?,?,?,?,?)";

                    OdbcCommand cmd = new OdbcCommand(sSql, conn);

                    cmd.Parameters.AddWithValue("@1", obj.iIdCuentaBancaria);
                    cmd.Parameters.AddWithValue("@2", obj.iAnioCierre);
                    cmd.Parameters.AddWithValue("@3", obj.iMesCierre);
                    cmd.Parameters.AddWithValue("@4", obj.dSaldoInicial);
                    cmd.Parameters.AddWithValue("@5", obj.dSaldoFinal);
                    cmd.Parameters.AddWithValue("@6", obj.dSaldoConciliado);
                    cmd.Parameters.AddWithValue("@7", obj.sEstado);
                    cmd.Parameters.AddWithValue("@8", obj.sObservaciones);
                    cmd.Parameters.AddWithValue("@9", obj.sUsuarioRegistro);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cierre bancario: " + ex.Message);
            }
        }

        // ================================
        // CERRAR CIERRE
        // ================================
        public void fun_cerrar_cierre(int iIdCierre, string sUsuario)
        {
            string sQuery = $@"
                UPDATE Tbl_CierreBancario
                SET 
                    Cmp_Estado = 'CERRADO',
                    Cmp_FechaCierre = NOW(),
                    Cmp_UsuarioModifico = '{sUsuario}',
                    Cmp_FechaModificacion = NOW()
                WHERE Pk_Id_Cierre = {iIdCierre}";

            OdbcConnection conn = objConexion.conexion();
            new OdbcCommand(sQuery, conn).ExecuteNonQuery();
            objConexion.desconexion(conn);
        }

        // ================================
        // ANULAR CIERRE
        // ================================
        public void fun_anular_cierre(int iIdCierre, string sUsuario)
        {
            string sQuery = $@"
                UPDATE Tbl_CierreBancario
                SET 
                    Cmp_Estado = 'ANULADO',
                    Cmp_UsuarioModifico = '{sUsuario}',
                    Cmp_FechaModificacion = NOW()
                WHERE Pk_Id_Cierre = {iIdCierre}";

            OdbcConnection conn = objConexion.conexion();
            new OdbcCommand(sQuery, conn).ExecuteNonQuery();
            objConexion.desconexion(conn);
        }
    }
}
