using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Inventario
{
    public class Cls_Sentencias_Inventario
    {
        public string Snt_ConstruirSqlHistorico(
            string tipoMovimiento,
            int? idAlmacen,
            int? idEstado,
            bool usarRangoFechas,
            DateTime fechaInicio,
            DateTime fechaFin,
            string ordenarPor,
            out List<object> parametros)
        {
            parametros = new List<object>();

            // Consulta Principal
            var sqlBuilder = new System.Text.StringBuilder(
                @"SELECT 
                    mov.Pk_ID_Movimiento, mov.Cmp_Fecha, prod.Cmp_Nombre AS Producto, 
                    tm.Cmp_Nombre AS TipoMovimiento, alm.Cmp_Nombre AS Almacen, 
                    mov.Cmp_Cantidad, mov.Cmp_CostoUnitario_Snapshot AS CostoEnEseMomento, 
                    (mov.Cmp_Cantidad * mov.Cmp_CostoUnitario_Snapshot) AS ValorTotal, 
                    est.Cmp_Nombre AS EstadoDelProducto 
                  FROM Tbl_MovimientosInventario AS mov
                  JOIN Tbl_Productos AS prod ON mov.Fk_ID_Producto = prod.Pk_ID_Producto
                  JOIN Tbl_Almacenes AS alm ON mov.Fk_ID_Almacen = alm.Pk_ID_Almacen
                  JOIN Tbl_TipoMovimiento AS tm ON mov.Fk_ID_TipoMovimiento = tm.Pk_ID_TipoMovimiento
                  JOIN Tbl_EstadoProducto AS est ON prod.Fk_ID_EstadoProducto = est.Pk_ID_EstadoProducto "
            );

            // 2. Cláusulas WHERE dinámicas
            var whereClauses = new List<string>();

            if (!string.IsNullOrEmpty(tipoMovimiento))
            {
                whereClauses.Add("tm.Cmp_Nombre = ?"); // '?' es el parámetro para ODBC
                parametros.Add(tipoMovimiento);
            }

            if (idAlmacen.HasValue && idAlmacen.Value > 0)
            {
                whereClauses.Add("mov.Fk_ID_Almacen = ?");
                parametros.Add(idAlmacen.Value);
            }

            if (idEstado.HasValue && idEstado.Value > 0)
            {
                whereClauses.Add("est.Pk_ID_EstadoProducto = ?");
                parametros.Add(idEstado.Value);
            }

            if (usarRangoFechas)
            {
                whereClauses.Add("mov.Cmp_Fecha BETWEEN ? AND ?");
                parametros.Add(fechaInicio);
                parametros.Add(fechaFin);
            }

            // 3. WHERE
            if (whereClauses.Count > 0)
            {
                sqlBuilder.Append(" WHERE " + string.Join(" AND ", whereClauses));
            }

            // 4. ORDER BY
            if (string.IsNullOrEmpty(ordenarPor))
            {
                ordenarPor = "mov.Cmp_Fecha DESC"; // Orden por defecto
            }
            sqlBuilder.Append(" ORDER BY " + ordenarPor);

            return sqlBuilder.ToString();
        }

        public string Snt_CargarAlmacenes()
        {
            return "SELECT Pk_ID_Almacen, Cmp_Nombre FROM Tbl_Almacenes ORDER BY Cmp_Nombre;";
        }

        public string Snt_CargarEstadosProducto()
        {
            // Usamos Tbl_EstadoProducto (Bueno, Dañado)
            return "SELECT Pk_ID_EstadoProducto, Cmp_Nombre FROM Tbl_EstadoProducto ORDER BY Cmp_Nombre;";
        }

        public string Snt_CargarTodosLosCierres()
        {
            // Esta consulta trae todos los cierres, uniéndolos con productos y almacenes
            return @"SELECT 
            c.Pk_ID_Cierre, c.Cmp_FechaCierre, p.Cmp_Nombre AS Producto, 
            a.Cmp_Nombre AS Almacen, c.Cmp_SaldoInicial, c.Cmp_SaldoFinal, 
            c.Cmp_AbonoDelMes, c.Cmp_CargosDelMes, c.Cmp_AbonosAcumulados, c.Cmp_CargosAcumulados
          FROM Tbl_CierresInventario AS c
          JOIN Tbl_Productos AS p ON c.Fk_ID_Producto = p.Pk_ID_Producto
          JOIN Tbl_Almacenes AS a ON c.Fk_ID_Almacen = a.Pk_ID_Almacen
          ORDER BY c.Cmp_FechaCierre DESC;"; // Ordenados por fecha
        }

        // (Agrega estos métodos DENTRO de tu clase Cls_Sentencias_Inventario)

        // Para el ComboBox (Error 1)
        public string Snt_CargarTiposMovimiento()
        {
            return "SELECT Pk_ID_TipoMovimiento, Cmp_Nombre FROM Tbl_TipoMovimiento ORDER BY Cmp_Nombre;";
        }

        // Para el DGV al inicio (Error 2)
        public string Snt_CargarHistoricoDefault()
        {
            return @"SELECT 
                mov.Pk_ID_Movimiento, mov.Cmp_Fecha, prod.Cmp_Nombre AS Producto, 
                tm.Cmp_Nombre AS TipoMovimiento, alm.Cmp_Nombre AS Almacen, 
                mov.Cmp_Cantidad, mov.Cmp_CostoUnitario_Snapshot AS CostoEnEseMomento, 
                (mov.Cmp_Cantidad * mov.Cmp_CostoUnitario_Snapshot) AS ValorTotal, 
                est.Cmp_Nombre AS EstadoDelProducto 
              FROM Tbl_MovimientosInventario AS mov
              JOIN Tbl_Productos AS prod ON mov.Fk_ID_Producto = prod.Pk_ID_Producto
              JOIN Tbl_Almacenes AS alm ON mov.Fk_ID_Almacen = alm.Pk_ID_Almacen
              JOIN Tbl_TipoMovimiento AS tm ON mov.Fk_ID_TipoMovimiento = tm.Pk_ID_TipoMovimiento
              JOIN Tbl_EstadoProducto AS est ON prod.Fk_ID_EstadoProducto = est.Pk_ID_EstadoProducto
              ORDER BY mov.Cmp_Fecha DESC 
              LIMIT 100;";
        }

    }
}