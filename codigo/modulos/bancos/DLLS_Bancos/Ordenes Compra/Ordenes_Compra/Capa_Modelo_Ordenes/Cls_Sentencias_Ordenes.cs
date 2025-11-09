using System;
using System.Data;
using System.Data.Odbc;

// Inicio de código de María Alejandra Morales García con carné: 0901-22-1226 con la fecha de: 07/11/2025
namespace Capa_Modelo_Ordenes
{
    public class Cls_Sentencias_Ordenes
    {
        private readonly Cls_Conexion_Ordenes _cnx = new Cls_Conexion_Ordenes();


        public DataTable ObtenerOrdenes()
        {
            const string sql = @"SELECT Pk_Id_Orden_Compra, Cmp_Descripcion_Orden_Compra
                                 FROM Tbl_Orden_Compra ORDER BY 1;";
            return FillTable(sql);
        }

        public DataTable ObtenerBancos()
        {
            const string sql = @"SELECT Pk_Id_Banco, Cmp_NombreBanco
                                 FROM Tbl_Bancos ORDER BY Cmp_NombreBanco;";
            return FillTable(sql);
        }

        public DataTable ObtenerEmpleados()
        {
            const string sql = @"SELECT Pk_Id_Empleado, Cmp_Nombre_Empleado
                                 FROM Tbl_Empleado_Autorizado ORDER BY Cmp_Nombre_Empleado;";
            return FillTable(sql);
        }

        public DataTable ObtenerEstados()
        {
            const string sql = @"SELECT Pk_Id_Estado_Autorizacion, Cmp_Nombre_Estado
                                 FROM Tbl_Estado_Autorizacion;";
            return FillTable(sql);
        }

        public DataTable ObtenerAutorizacionesDetalle()
        {
            const string sql = @"
                SELECT
                  a.Pk_Id_Autorizacion,
                  a.Fk_Id_Orden_Compra,
                  oc.Cmp_Descripcion_Orden_Compra AS Orden_Compra,
                  a.Fk_Id_Banco,
                  b.Cmp_NombreBanco AS Banco,
                  a.Fk_Id_Empleado,
                  ea.Cmp_Nombre_Empleado AS Empleado,
                  a.Cmp_Fecha_Autorizacion,
                  a.Cmp_Monto_Autorizado,
                  a.Fk_Id_Estado_Autorizacion,
                  es.Cmp_Nombre_Estado AS Estado,
                  a.Cmp_Observaciones
                FROM Tbl_Orden_Compra_Autorizada a
                JOIN Tbl_Orden_Compra oc        ON oc.Pk_Id_Orden_Compra = a.Fk_Id_Orden_Compra
                JOIN Tbl_Bancos b                ON b.Pk_Id_Banco = a.Fk_Id_Banco
                LEFT JOIN Tbl_Empleado_Autorizado ea ON ea.Pk_Id_Empleado = a.Fk_Id_Empleado
                JOIN Tbl_Estado_Autorizacion es ON es.Pk_Id_Estado_Autorizacion = a.Fk_Id_Estado_Autorizacion
                ORDER BY a.Pk_Id_Autorizacion DESC;";
            return FillTable(sql);
        }


        public int InsertarAutorizacion(int idOrden, int idBanco, int? idEmpleado, DateTime fecha,
                                        decimal monto, int idEstado, string observ)
        {
            const string sql = @"
                INSERT INTO Tbl_Orden_Compra_Autorizada
                (Fk_Id_Orden_Compra, Fk_Id_Banco, Fk_Id_Empleado, Cmp_Fecha_Autorizacion,
                 Cmp_Monto_Autorizado, Fk_Id_Estado_Autorizacion, Cmp_Observaciones)
                VALUES (?, ?, ?, ?, ?, ?, ?);";

            using (var conn = _cnx.conexion())
            using (var cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add("@p1", OdbcType.Int).Value = idOrden;
                cmd.Parameters.Add("@p2", OdbcType.Int).Value = idBanco;
                cmd.Parameters.Add("@p3", OdbcType.Int).Value =
                idEmpleado.HasValue ? (object)idEmpleado.Value : (object)DBNull.Value;

                cmd.Parameters.Add("@p4", OdbcType.DateTime).Value = fecha;
                cmd.Parameters.Add("@p5", OdbcType.Decimal).Value = monto;
                cmd.Parameters.Add("@p6", OdbcType.Int).Value = idEstado;
                cmd.Parameters.Add("@p7", OdbcType.VarChar, 255).Value =
                observ != null ? (object)observ : (object)DBNull.Value;

                cmd.ExecuteNonQuery();

                using (var cmdId = new OdbcCommand("SELECT LAST_INSERT_ID();", conn))
                {
                    return Convert.ToInt32(cmdId.ExecuteScalar());
                }
            }
        }

        public int ActualizarAutorizacion(int idAut, int idOrden, int idBanco, int? idEmpleado, DateTime fecha,
                                          decimal monto, int idEstado, string observ)
        {
            const string sql = @"
                UPDATE Tbl_Orden_Compra_Autorizada
                SET Fk_Id_Orden_Compra = ?, Fk_Id_Banco = ?, Fk_Id_Empleado = ?,
                    Cmp_Fecha_Autorizacion = ?, Cmp_Monto_Autorizado = ?,
                    Fk_Id_Estado_Autorizacion = ?, Cmp_Observaciones = ?
                WHERE Pk_Id_Autorizacion = ?;";

            using (var conn = _cnx.conexion())
            using (var cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add("@p1", OdbcType.Int).Value = idOrden;
                cmd.Parameters.Add("@p2", OdbcType.Int).Value = idBanco;
                cmd.Parameters.Add("@p3", OdbcType.Int).Value =
                 idEmpleado.HasValue ? (object)idEmpleado.Value : (object)DBNull.Value;
                cmd.Parameters.Add("@p4", OdbcType.DateTime).Value = fecha;
                cmd.Parameters.Add("@p5", OdbcType.Decimal).Value = monto;
                cmd.Parameters.Add("@p6", OdbcType.Int).Value = idEstado;
                cmd.Parameters.Add("@p7", OdbcType.VarChar, 255).Value =
                observ != null ? (object)observ : (object)DBNull.Value;
                cmd.Parameters.Add("@p8", OdbcType.Int).Value = idAut;

                return cmd.ExecuteNonQuery();
            }
        }

        public int EliminarAutorizacion(int idAut)
        {
            const string sql = @"DELETE FROM Tbl_Orden_Compra_Autorizada WHERE Pk_Id_Autorizacion = ?;";
            using (var conn = _cnx.conexion())
            using (var cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add("@p1", OdbcType.Int).Value = idAut;
                return cmd.ExecuteNonQuery();
            }
        }

 
        private DataTable FillTable(string sql)
        {
            using (var conn = _cnx.conexion())
            using (var da = new OdbcDataAdapter(sql, conn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
// Fin de código de María Alejandra Morales García con carné: 0901-22-1226 con la fecha de: 07/11/2025
