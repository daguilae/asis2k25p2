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
            OdbcConnection conn = cn.conexion();
            OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.desconexion(conn);
            return dt;
        }

        public void InsertarTipoCambio(string fecha, decimal compra, decimal venta, int idMoneda)
        {
            string sql = "INSERT INTO Tbl_TiposCambio (Fk_Id_Moneda, Cmp_Fecha, Cmp_ValorCompra, Cmp_ValorVenta) " +
                         "VALUES (" + idMoneda + ", '" + fecha + "', " + compra + ", " + venta + ");";
            OdbcConnection conn = cn.conexion();
            OdbcCommand cmd = new OdbcCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cn.desconexion(conn);
        }

        public DataTable MostrarTiposCambio()
        {
            string sql = "SELECT T.Pk_Id_TipoCambio, M.Cmp_NombreMoneda, T.Cmp_Fecha, T.Cmp_ValorCompra, T.Cmp_ValorVenta " +
                         "FROM Tbl_TiposCambio T INNER JOIN Tbl_Monedas M ON T.Fk_Id_Moneda = M.Pk_Id_Moneda;";
            OdbcConnection conn = cn.conexion();
            OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.desconexion(conn);
            return dt;
        }

        public DataTable BuscarTipoCambio(string fecha)
        {
            string sql = "SELECT M.Cmp_NombreMoneda, T.Cmp_Fecha, T.Cmp_ValorCompra, T.Cmp_ValorVenta " +
                         "FROM Tbl_TiposCambio T INNER JOIN Tbl_Monedas M ON T.Fk_Id_Moneda = M.Pk_Id_Moneda " +
                         "WHERE T.Cmp_Fecha = '" + fecha + "';";

            OdbcConnection conn = cn.conexion();
            OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.desconexion(conn);
            return dt;
        }

        public DataTable MostrarTiposCambioHoy()
        {
            string sql = "SELECT M.Cmp_NombreMoneda AS Moneda, T.Cmp_ValorCompra AS Compra, T.Cmp_ValorVenta AS Venta " +
                         "FROM Tbl_TiposCambio T INNER JOIN Tbl_Monedas M ON T.Fk_Id_Moneda = M.Pk_Id_Moneda " +
                         "WHERE T.Cmp_Fecha = CURDATE() AND T.Cmp_Estado = 1;";

            OdbcConnection conn = cn.conexion();
            OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.desconexion(conn);
            return dt;
        }

    }
}
