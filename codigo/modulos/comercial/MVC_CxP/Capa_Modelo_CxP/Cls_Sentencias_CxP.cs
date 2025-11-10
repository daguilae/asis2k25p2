using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_CxP
{
    public class Cls_Sentencias_CxP
    {
        private readonly Cls_Conexion _cx = new Cls_Conexion();

        // ===== Proveedores para combo =====
        public DataTable Proveedores_ListarActivos()
        {
            var dt = new DataTable();
            const string sql = @"
                SELECT Cmp_Id_Proveedor, Cmp_Nombre_Proveedor
                FROM Tbl_Proveedor
                ORDER BY Cmp_Nombre_Proveedor;";
            using (var cn = _cx.conexion())
            using (var da = new OdbcDataAdapter(sql, cn))
                da.Fill(dt);
            return dt;
        }

        // ===== Vista para el grid =====
        public DataTable Gestion_Listar()
        {
            var dt = new DataTable();
            const string sql = @"SELECT * FROM Vw_CxP_Gestion ORDER BY FechaEmision DESC, Id_DocCxP DESC;";
            using (var cn = _cx.conexion())
            using (var da = new OdbcDataAdapter(sql, cn))
                da.Fill(dt);
            return dt;
        }

        // ===== Insertar documento =====
        public int DocCxP_Insertar(
            int idProveedor, string serie, string numero,
            DateTime fechaEmision, DateTime fechaVenc,
            decimal total, string descripcion, int idUsuarioCrea)
        {
            const string sql = @"
                INSERT INTO Tbl_CxP_Documento
                (Cmp_Id_Proveedor, Cmp_Serie, Cmp_Numero, 
                 Cmp_Tipo_Documento, Cmp_Fecha_Emision, Cmp_Fecha_Vencimiento,
                 Cmp_Total_Documento, Cmp_Saldo_Pendiente, Cmp_Estado, Cmp_Descripcion, 
                 Cmp_Id_Usuario_Creacion)
                VALUES (?,?,?,?,?,?,?, ?, 'Pendiente', ?, ?);";

            using (var cn = _cx.conexion())
            using (var cmd = new OdbcCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@p1", idProveedor);
                cmd.Parameters.AddWithValue("@p2", serie?.Trim() ?? "");
                cmd.Parameters.AddWithValue("@p3", numero?.Trim() ?? "");
                cmd.Parameters.AddWithValue("@p4", "Factura Compra");
                cmd.Parameters.AddWithValue("@p5", fechaEmision);
                cmd.Parameters.AddWithValue("@p6", fechaVenc);
                cmd.Parameters.AddWithValue("@p7", total);
                cmd.Parameters.AddWithValue("@p8", total);      // Saldo inicial = total
                cmd.Parameters.AddWithValue("@p9", descripcion?.Trim() ?? "");
                cmd.Parameters.AddWithValue("@p10", idUsuarioCrea);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
