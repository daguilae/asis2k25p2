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
        private Cls_Conexion gCn = new Cls_Conexion();

        public DataTable CargarMonedas()
        {
            string sQuery = "SELECT Pk_Id_Moneda, Cmp_NombreMoneda FROM Tbl_Monedas WHERE Cmp_Estado = 1;";
            OdbcDataAdapter odAdapter = new OdbcDataAdapter(sQuery, gCn.Conexion());

            DataTable dtsResultado = new DataTable();
            odAdapter.Fill(dtsResultado);

            return dtsResultado;
        }

        public void InsertarTipoCambio(string sFecha, decimal deCompra, decimal deVenta, int iIdMoneda)
        {
            string sQuery =
                "INSERT INTO Tbl_TiposCambio (Fk_Id_Moneda, Cmp_Fecha, Cmp_ValorCompra, Cmp_ValorVenta) " +
                $"VALUES ({iIdMoneda}, '{sFecha}', {deCompra}, {deVenta});";

            OdbcConnection odConn = gCn.Conexion();
            OdbcCommand odCmd = new OdbcCommand(sQuery, odConn);

            odCmd.ExecuteNonQuery();
            gCn.Desconexion(odConn);
        }

        public DataTable MostrarTiposCambio()
        {
            string sQuery = @"
                SELECT 
                    T.Pk_Id_TipoCambio,
                    M.Cmp_NombreMoneda,
                    T.Cmp_Fecha,
                    T.Cmp_ValorCompra,
                    T.Cmp_ValorVenta
                FROM Tbl_TiposCambio T
                INNER JOIN Tbl_Monedas M ON T.Fk_Id_Moneda = M.Pk_Id_Moneda;";

            OdbcDataAdapter odAdapter = new OdbcDataAdapter(sQuery, gCn.Conexion());
            DataTable dtsResultado = new DataTable();
            odAdapter.Fill(dtsResultado);

            return dtsResultado;
        }

        public DataTable BuscarTipoCambio(string sFecha)
        {
            string sQuery = @"
                SELECT 
                    M.Cmp_NombreMoneda AS Cmp_NombreMoneda,
                    T.Cmp_Fecha AS Cmp_Fecha,
                    T.Cmp_ValorCompra AS Cmp_ValorCompra,
                    T.Cmp_ValorVenta AS Cmp_ValorVenta
                FROM Tbl_TiposCambio T
                INNER JOIN Tbl_Monedas M 
                    ON T.Fk_Id_Moneda = M.Pk_Id_Moneda
                WHERE DATE(T.Cmp_Fecha) = '" + sFecha + "'";

            OdbcConnection odConn = gCn.Conexion();
            OdbcDataAdapter odAdapter = new OdbcDataAdapter(sQuery, odConn);

            DataTable dtsResultado = new DataTable();
            odAdapter.Fill(dtsResultado);

            gCn.Desconexion(odConn);
            return dtsResultado;
        }

        public DataTable MostrarTiposCambioHoy()
        {
            string sQuery = @"
                SELECT 
                    M.Cmp_NombreMoneda AS Moneda,
                    T.Cmp_ValorCompra AS Compra,
                    T.Cmp_ValorVenta AS Venta
                FROM Tbl_TiposCambio T
                INNER JOIN Tbl_Monedas M ON T.Fk_Id_Moneda = M.Pk_Id_Moneda
                WHERE T.Cmp_Fecha = CURDATE() AND T.Cmp_Estado = 1;";

            OdbcDataAdapter odAdapter = new OdbcDataAdapter(sQuery, gCn.Conexion());
            DataTable dtsResultado = new DataTable();
            odAdapter.Fill(dtsResultado);

            return dtsResultado;
        }

        public DataTable ObtenerBancos()
        {
            string sQuery = "SELECT Pk_Id_Banco, Cmp_NombreBanco FROM Tbl_Bancos WHERE Cmp_Estado = 1;";
            OdbcDataAdapter odAdapter = new OdbcDataAdapter(sQuery, gCn.Conexion());

            DataTable dtsResultado = new DataTable();
            odAdapter.Fill(dtsResultado);

            return dtsResultado;
        }

        public DataTable ObtenerTiposCuenta()
        {
            string sQuery = "SELECT DISTINCT Cmp_TipoCuenta FROM Tbl_CuentasBancarias WHERE Cmp_TipoCuenta IS NOT NULL;";
            OdbcDataAdapter odAdapter = new OdbcDataAdapter(sQuery, gCn.Conexion());

            DataTable dtsResultado = new DataTable();
            odAdapter.Fill(dtsResultado);

            return dtsResultado;
        }

        public DataTable ObtenerDisponibilidad(string sBanco, string sTipoCuenta, string sNumeroCuenta)
        {
            string sQuery = @"
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

            if (!string.IsNullOrEmpty(sBanco))
                sQuery += $" AND B.Pk_Id_Banco = {sBanco}";

            if (!string.IsNullOrEmpty(sTipoCuenta))
                sQuery += $" AND C.Cmp_TipoCuenta = '{sTipoCuenta}'";

            if (!string.IsNullOrEmpty(sNumeroCuenta))
                sQuery += $" AND C.Cmp_NumeroCuenta = '{sNumeroCuenta}'";

            OdbcDataAdapter odAdapter = new OdbcDataAdapter(sQuery, gCn.Conexion());
            DataTable dtsResultado = new DataTable();

            odAdapter.Fill(dtsResultado);
            return dtsResultado;
        }
    }
}