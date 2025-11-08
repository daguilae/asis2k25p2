using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Inventario
{
    // ==================== Stevens Cambranes 05/11/2025 ====================
    // ==================== Clase Sentencias Inventario ====================
    public class Cls_Sentencias_Inventario
    {
        // ==================== Stevens Cambranes 05/11/2025 ====================
        // ==================== Construir SQL Histórico (Movimientos) ====================
        public string Snt_ConstruirSqlHistorico(
            string tipoMovimiento,
            int? idAlmacen,
            int? idEstado, // (idEstado 1 = Activo, 2 = Inactivo)
            bool usarRangoFechas,
            DateTime fechaInicio,
            DateTime fechaFin,
            string ordenarPor,
            out List<object> parametros)
        {
            // Solo 'tipoMovimiento' y 'idAlmacen' usarán parámetros.
            // Estado y Fecha se "quemarán" en el SQL.
            parametros = new List<object>();

            var sqlBuilder = new System.Text.StringBuilder(
                @"SELECT 
                    mov.Cmp_Id_Mov_Inv AS Pk_ID_Movimiento, mov.Cmp_Fecha_Movimiento AS Cmp_Fecha, prod.Cmp_Nombre_Producto AS Producto, 
                    tm.Cmp_Nombre_Tipo AS TipoMovimiento, alm.Cmp_Nombre_Almacen AS Almacen, 
                    movdet.Cmp_Cantidad, 
                    prod.Cmp_PrecioUnitario AS CostoEnEseMomento, 
                    (movdet.Cmp_Cantidad * prod.Cmp_PrecioUnitario) AS ValorTotal, 
                    CASE WHEN prod.Cmp_Activo = 1 THEN 'Activo' ELSE 'Inactivo' END AS EstadoDelProducto 
                  FROM Tbl_Mov_Inv AS mov 
                  JOIN Tbl_Mov_Inv_Det AS movdet ON mov.Cmp_Id_Mov_Inv = movdet.Cmp_Id_Mov_Inv 
                  JOIN Tbl_Producto AS prod ON movdet.Cmp_Id_Producto = prod.Cmp_Id_Producto
                  JOIN Tbl_Almacen AS alm ON movdet.Cmp_Id_Almacen = alm.Cmp_Id_Almacen
                  JOIN Tbl_Tipo_Movimiento_Inv AS tm ON mov.Cmp_Id_Tipo_Movimiento_Inv = tm.Cmp_Id_Tipo_Movimiento_Inv "
            );

            var whereClauses = new List<string>();

            // Filtro 1: Tipo Movimiento (SEGURO - Usa parámetros)
            if (!string.IsNullOrEmpty(tipoMovimiento))
            {
                whereClauses.Add("tm.Cmp_Nombre_Tipo = ?");
                parametros.Add(tipoMovimiento);
            }

            // Filtro 2: Almacén (SEGURO - Usa parámetros)
            if (idAlmacen.HasValue && idAlmacen.Value > 0)
            {
                whereClauses.Add("movdet.Cmp_Id_Almacen = ?");
                parametros.Add(idAlmacen.Value);
            }

            // Filtro 3: Estado (INSEGURO - "Quemado" en SQL)
            if (idEstado.HasValue && idEstado.Value > 0)
            {
                string valorBit = (idEstado.Value == 1) ? "1" : "0";
                whereClauses.Add($"prod.Cmp_Activo = {valorBit}");
            }

            // Filtro 4: Fecha (INSEGURO - "Quemado" en SQL)
            if (usarRangoFechas)
            {
                // Formatea la fecha 'yyyy-MM-dd' y la rodea con comillas simples '
                string fechaInicioSql = fechaInicio.ToString("yyyy-MM-dd");
                string fechaFinSql = fechaFin.ToString("yyyy-MM-dd");

                whereClauses.Add($"mov.Cmp_Fecha_Movimiento BETWEEN '{fechaInicioSql}' AND '{fechaFinSql}'");
            }

            // Ensambla el WHERE
            if (whereClauses.Count > 0)
            {
                sqlBuilder.Append(" WHERE " + string.Join(" AND ", whereClauses));
            }

            if (string.IsNullOrEmpty(ordenarPor))
            {
                ordenarPor = "mov.Cmp_Fecha_Movimiento DESC";
            }
            sqlBuilder.Append(" ORDER BY " + ordenarPor);

            return sqlBuilder.ToString();
        }

        // ==================== Stevens Cambranes 05/11/2025 ====================
        // ==================== Cargar ComboBox Almacenes ====================
        public string Snt_CargarAlmacenes()
        {
            return "SELECT Cmp_Id_Almacen AS Pk_ID_Almacen, Cmp_Nombre_Almacen AS Cmp_Nombre FROM Tbl_Almacen ORDER BY Cmp_Nombre_Almacen;";
        }

        // ==================== Stevens Cambranes 05/11/2025 ====================
        // ==================== Cargar ComboBox Estados ====================
        public string Snt_CargarEstadosProducto()
        {
            return "SELECT 1 AS Pk_ID_EstadoProducto, 'Activo' AS Cmp_Nombre UNION ALL SELECT 2, 'Inactivo' ORDER BY 1;";
        }

        // ==================== Stevens Cambranes 05/11/2025 ====================
        // ==================== Cargar Todos los Cierres (CORREGIDO) ====================
        public string Snt_CargarTodosLosCierres()
        {
            return @"SELECT 
                    c.Cmp_Id_Cierre AS Pk_ID_Cierre, 
                    c.Cmp_Fecha_Cierre AS Cmp_FechaCierre, 
                    a.Cmp_Nombre_Almacen AS Almacen, 
                    c.Cmp_Observaciones AS Observaciones,
                    'N/A (Encabezado)' AS Producto, 
                    0.00 AS Cmp_SaldoInicial, 
                    0.00 AS Cmp_SaldoFinal,
                    0.00 AS Cmp_AbonoDelMes,
                    0.00 AS Cmp_CargosDelMes,
                    0.00 AS Cmp_AbonosAcumulados, 
                    0.00 AS Cmp_CargosAcumulados
                  FROM Tbl_Cierre_Inventario AS c
                  JOIN Tbl_Almacen AS a ON c.Cmp_Id_Almacen = a.Cmp_Id_Almacen
                  ORDER BY c.Cmp_Fecha_Cierre DESC;";
        }

        // ==================== Stevens Cambranes 05/11/2025 ====================
        // ==================== Cargar ComboBox Tipo Movimiento ====================
        public string Snt_CargarTiposMovimiento()
        {
            return "SELECT Cmp_Id_Tipo_Movimiento_Inv AS Pk_ID_TipoMovimiento, Cmp_Nombre_Tipo AS Cmp_Nombre FROM Tbl_Tipo_Movimiento_Inv ORDER BY Cmp_Nombre_Tipo;";
        }

        // ==================== Stevens Cambranes 05/11/2025 ====================
        // ==================== Cargar DGV por Defecto ====================
        public string Snt_CargarHistoricoDefault()
        {
            return @"SELECT 
                    mov.Cmp_Id_Mov_Inv AS Pk_ID_Movimiento, mov.Cmp_Fecha_Movimiento AS Cmp_Fecha, prod.Cmp_Nombre_Producto AS Producto, 
                    tm.Cmp_Nombre_Tipo AS TipoMovimiento, alm.Cmp_Nombre_Almacen AS Almacen, 
                    movdet.Cmp_Cantidad, 
                    prod.Cmp_PrecioUnitario AS CostoEnEseMomento, 
                    (movdet.Cmp_Cantidad * prod.Cmp_PrecioUnitario) AS ValorTotal,
                    CASE WHEN prod.Cmp_Activo = 1 THEN 'Activo' ELSE 'Inactivo' END AS EstadoDelProducto 
                  FROM Tbl_Mov_Inv AS mov
                  JOIN Tbl_Mov_Inv_Det AS movdet ON mov.Cmp_Id_Mov_Inv = movdet.Cmp_Id_Mov_Inv
                  JOIN Tbl_Producto AS prod ON movdet.Cmp_Id_Producto = prod.Cmp_Id_Producto
                  JOIN Tbl_Almacen AS alm ON movdet.Cmp_Id_Almacen = alm.Cmp_Id_Almacen
                  JOIN Tbl_Tipo_Movimiento_Inv AS tm ON mov.Cmp_Id_Tipo_Movimiento_Inv = tm.Cmp_Id_Tipo_Movimiento_Inv
                  ORDER BY mov.Cmp_Fecha_Movimiento DESC 
                  LIMIT 100;";
        }
    }
}