using System;
using System.Data;
using System.Data.Odbc;
using System.Globalization;

namespace Capa_Modelo_MH
{
    public class Cls_Modelo_OP
    {
        private readonly Cls_ConexionMysql cls_Conexion = new Cls_ConexionMysql();

        // ============================================================
        // AUXILIARES (NULL Y FECHA)
        // ============================================================
        private object fun_ValorONull(string valor) =>
            string.IsNullOrWhiteSpace(valor) ? DBNull.Value : (object)valor;

        private object fun_FechaONull(string fecha)
        {
            if (string.IsNullOrWhiteSpace(fecha)) return DBNull.Value;

            DateTime f = DateTime.ParseExact(
                fecha,
                new[] { "yyyy-MM-dd", "dd-MM-yyyy", "dd/MM/yyyy" },
                CultureInfo.InvariantCulture,
                DateTimeStyles.None
            );

            return f.ToString("yyyy-MM-dd");
        }

        // ============================================================
        // MOSTRAR
        // ============================================================
        public OdbcDataAdapter fun_MostrarObjetos()
        {
            string sql = @"
                SELECT 
                    op.Pk_Id_Objeto,
                    op.Cmp_Nombre_Objeto,
                    op.Cmp_Tipo_Objeto,
                    op.Cmp_Descripcion_Objeto,
                    op.Cmp_Fecha_Encontrado,
                    op.Cmp_Entregado,
                    m.Cmp_Tipo_Mantenimiento AS Mantenimiento,
                    h.Cmp_Nombre AS Huesped,
                    f.Pk_Id_Folio AS Folio_Habitacion,
                    fs.Pk_Id_Folio_Salones AS Folio_Salon
                FROM Tbl_Objetos_Perdidos op
                LEFT JOIN Tbl_Mantenimiento m ON op.Fk_Id_Mantenimiento = m.Pk_Id_Mantenimiento
                LEFT JOIN Tbl_Huesped h ON op.Fk_Id_Huesped = h.Pk_Id_Huesped
                LEFT JOIN Tbl_Folio f ON op.Fk_Id_Folio = f.Pk_Id_Folio
                LEFT JOIN Tbl_Folio_Salones fs ON op.Fk_Id_Folio_Salon = fs.Pk_Id_Folio_Salones
                ORDER BY op.Pk_Id_Objeto DESC;";

            return new OdbcDataAdapter(sql, cls_Conexion.fun_Conexion());
        }

        // ============================================================
        // INSERTAR
        // ============================================================
        public void fun_InsertarObjeto(string mantenimiento, string folioSalon, string folioHabitacion,
                                       string huesped, string nombre, string descripcion,
                                       string tipo, string fecha, int entregado)
        {
            const string sql = @"
                INSERT INTO Tbl_Objetos_Perdidos 
                (Fk_Id_Mantenimiento, Fk_Id_Folio_Salon, Fk_Id_Folio, Fk_Id_Huesped,
                 Cmp_Nombre_Objeto, Cmp_Descripcion_Objeto, Cmp_Tipo_Objeto,
                 Cmp_Fecha_Encontrado, Cmp_Entregado)
                VALUES (?,?,?,?,?,?,?,?,?);";

            using (var conn = cls_Conexion.fun_Conexion())
            {
                conn.Open();
                using (var cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("Fk_Id_Mantenimiento", fun_ValorONull(mantenimiento));
                    cmd.Parameters.AddWithValue("Fk_Id_Folio_Salon", fun_ValorONull(folioSalon));
                    cmd.Parameters.AddWithValue("Fk_Id_Folio", fun_ValorONull(folioHabitacion));
                    cmd.Parameters.AddWithValue("Fk_Id_Huesped", fun_ValorONull(huesped));
                    cmd.Parameters.AddWithValue("Cmp_Nombre_Objeto", fun_ValorONull(nombre));
                    cmd.Parameters.AddWithValue("Cmp_Descripcion_Objeto", fun_ValorONull(descripcion));
                    cmd.Parameters.AddWithValue("Cmp_Tipo_Objeto", fun_ValorONull(tipo));
                    cmd.Parameters.AddWithValue("Cmp_Fecha_Encontrado", fun_FechaONull(fecha));
                    cmd.Parameters.AddWithValue("Cmp_Entregado", entregado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ============================================================
        // ACTUALIZAR
        // ============================================================
        public void fun_ActualizarObjeto(string id, string mantenimiento, string folioSalon, string folioHabitacion,
                                         string huesped, string nombre, string descripcion,
                                         string tipo, string fecha, int entregado)
        {
            const string sql = @"
                UPDATE Tbl_Objetos_Perdidos SET
                    Fk_Id_Mantenimiento = ?, 
                    Fk_Id_Folio_Salon = ?, 
                    Fk_Id_Folio = ?, 
                    Fk_Id_Huesped = ?, 
                    Cmp_Nombre_Objeto = ?, 
                    Cmp_Descripcion_Objeto = ?, 
                    Cmp_Tipo_Objeto = ?, 
                    Cmp_Fecha_Encontrado = ?, 
                    Cmp_Entregado = ?
                WHERE Pk_Id_Objeto = ?;";

            using (var conn = cls_Conexion.fun_Conexion())
            {
                conn.Open();
                using (var cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("Fk_Id_Mantenimiento", fun_ValorONull(mantenimiento));
                    cmd.Parameters.AddWithValue("Fk_Id_Folio_Salon", fun_ValorONull(folioSalon));
                    cmd.Parameters.AddWithValue("Fk_Id_Folio", fun_ValorONull(folioHabitacion));
                    cmd.Parameters.AddWithValue("Fk_Id_Huesped", fun_ValorONull(huesped));
                    cmd.Parameters.AddWithValue("Cmp_Nombre_Objeto", fun_ValorONull(nombre));
                    cmd.Parameters.AddWithValue("Cmp_Descripcion_Objeto", fun_ValorONull(descripcion));
                    cmd.Parameters.AddWithValue("Cmp_Tipo_Objeto", fun_ValorONull(tipo));
                    cmd.Parameters.AddWithValue("Cmp_Fecha_Encontrado", fun_FechaONull(fecha));
                    cmd.Parameters.AddWithValue("Cmp_Entregado", entregado);
                    cmd.Parameters.AddWithValue("Pk_Id_Objeto", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ============================================================
        // ELIMINAR
        // ============================================================
        public void fun_EliminarObjeto(string id)
        {
            using (var conn = cls_Conexion.fun_Conexion())
            {
                conn.Open();
                using (var cmd = new OdbcCommand("DELETE FROM Tbl_Objetos_Perdidos WHERE Pk_Id_Objeto = ?;", conn))
                {
                    cmd.Parameters.AddWithValue("Pk_Id_Objeto", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ============================================================
        // BUSCAR
        // ============================================================
        public DataTable fun_BuscarObjetoPorId(string id)
        {
            DataTable dt = new DataTable();
            using (var conn = cls_Conexion.fun_Conexion())
            {
                using (var cmd = new OdbcCommand("SELECT * FROM Tbl_Objetos_Perdidos WHERE Pk_Id_Objeto = ?;", conn))
                {
                    cmd.Parameters.AddWithValue("Pk_Id_Objeto", id);
                    new OdbcDataAdapter(cmd).Fill(dt);
                }
            }
            return dt;
        }

        // ============================================================
        // CONSULTA GENÉRICA
        // ============================================================
        public DataTable fun_EjecutarConsulta(string sql)
        {
            DataTable dt = new DataTable();
            using (var da = new OdbcDataAdapter(sql, cls_Conexion.fun_Conexion()))
            {
                da.Fill(dt);
            }
            return dt;
        }
    }
}
