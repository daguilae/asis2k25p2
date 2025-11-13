using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_TipoDeCambio
{
    public class Modelo_TipoCambio
    {
        Cls_Conexion cn = new Cls_Conexion();

        public DataTable CargarMonedas()
        {
            string sql = "SELECT Pk_Id_Moneda, Cmp_NombreMoneda FROM Tbl_Monedas WHERE Cmp_Estado = 1;";

            OdbcDataAdapter da = new OdbcDataAdapter(sql, cn.conexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.desconexion(cn.conexion());

            return dt;
        }

        public void InsertarTipoCambio(string fecha, decimal compra, decimal venta, int idMoneda)
        {
            string sql = "INSERT INTO Tbl_TiposCambio (Fk_Id_Moneda, Cmp_Fecha, Cmp_ValorCompra, Cmp_ValorVenta) " +

                         $"VALUES ({idMoneda}, '{fecha}', {compra}, {venta});";


            OdbcConnection conn = cn.conexion();
            OdbcCommand cmd = new OdbcCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cn.desconexion(conn);
        }

        public DataTable MostrarTiposCambio()
        {

            string sql = @"
                SELECT 
                    T.Pk_Id_TipoCambio,
                    M.Cmp_NombreMoneda,
                    T.Cmp_Fecha,
                    T.Cmp_ValorCompra,
                    T.Cmp_ValorVenta
                FROM Tbl_TiposCambio T
                INNER JOIN Tbl_Monedas M ON T.Fk_Id_Moneda = M.Pk_Id_Moneda;";

            OdbcDataAdapter da = new OdbcDataAdapter(sql, cn.conexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.desconexion(cn.conexion());
            return dt;
        }


        // Buscar tipo de cambio por fecha
        public DataTable BuscarTipoCambio(string fecha)
        {
            string sql = @"
                SELECT 
                    M.Cmp_NombreMoneda AS Moneda,
                    T.Cmp_Fecha AS Fecha,
                    T.Cmp_ValorCompra AS Compra,
                    T.Cmp_ValorVenta AS Venta
                FROM Tbl_TiposCambio T
                INNER JOIN Tbl_Monedas M ON T.Fk_Id_Moneda = M.Pk_Id_Moneda
                WHERE T.Cmp_Fecha = '" + fecha + "';";

            OdbcDataAdapter da = new OdbcDataAdapter(sql, cn.conexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.desconexion(cn.conexion());
            return dt;
        }

        // Mostrar tipo de cambio del día
        public DataTable MostrarTiposCambioHoy()
        {
            string sql = @"
                SELECT 
                    M.Cmp_NombreMoneda AS Moneda,
                    T.Cmp_ValorCompra AS Compra,
                    T.Cmp_ValorVenta AS Venta
                FROM Tbl_TiposCambio T
                INNER JOIN Tbl_Monedas M ON T.Fk_Id_Moneda = M.Pk_Id_Moneda
                WHERE T.Cmp_Fecha = CURDATE() AND T.Cmp_Estado = 1;";

            OdbcDataAdapter da = new OdbcDataAdapter(sql, cn.conexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.desconexion(cn.conexion());
            return dt;
        }

        // Obtener bancos activos
        public DataTable ObtenerBancos()
        {
            string query = "SELECT Pk_Id_Banco, Cmp_NombreBanco FROM Tbl_Bancos WHERE Cmp_Estado = 1;";
            OdbcDataAdapter da = new OdbcDataAdapter(query, cn.conexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.desconexion(cn.conexion());
            return dt;
        }



        // Cargar tipos de cuenta en ComboBox
        public DataTable ObtenerTiposCuenta()
        {
            string query = "SELECT DISTINCT Cmp_TipoCuenta FROM Tbl_CuentasBancarias WHERE Cmp_TipoCuenta IS NOT NULL;";
            OdbcDataAdapter da = new OdbcDataAdapter(query, cn.conexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.desconexion(cn.conexion());
            return dt;
        }


        // Consultar disponibilidad diaria por filtros
        public DataTable ObtenerDisponibilidad(string banco, string tipoCuenta, string numeroCuenta)
        {
            string query = @"
        SELECT 
            B.Cmp_NombreBanco AS Banco,
            C.Cmp_TipoCuenta AS TipoCuenta,
            C.Cmp_NumeroCuenta AS NumeroCuenta,
            D.Cmp_Saldo_Final_Disponibilidad AS Disponibilidad,
            D.Cmp_Fecha_Disponibilidad AS Fecha
        FROM Tbl_Disponibilidad_Diaria D
        INNER JOIN Tbl_CuentasBancarias C ON D.Fk_Id_CuentaBancaria = C.Pk_Id_CuentaBancaria
        INNER JOIN Tbl_Bancos B ON C.Fk_Id_Banco = B.Pk_Id_Banco
        WHERE D.Cmp_Fecha_Disponibilidad = CURDATE()";

            if (!string.IsNullOrEmpty(banco))
                query += $" AND B.Pk_Id_Banco = {banco}";

            if (!string.IsNullOrEmpty(tipoCuenta))
                query += $" AND C.Cmp_TipoCuenta = '{tipoCuenta}'";

            if (!string.IsNullOrEmpty(numeroCuenta))
                query += $" AND C.Cmp_NumeroCuenta = '{numeroCuenta}'";

            OdbcDataAdapter da = new OdbcDataAdapter(query, cn.conexion());
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }


    }
}
