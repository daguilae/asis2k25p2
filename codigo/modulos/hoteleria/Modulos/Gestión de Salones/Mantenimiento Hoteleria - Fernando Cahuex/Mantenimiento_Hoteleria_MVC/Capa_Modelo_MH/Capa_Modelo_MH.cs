using System;
using System.Data;
using System.Data.Odbc;
using System.Globalization;

namespace Capa_Modelo_MH
{
    public class Cls_Mantenimiento
    {
        private readonly Cls_ConexionMysql conexion = new Cls_ConexionMysql();

        private object ValorONull(string valor) =>
            string.IsNullOrWhiteSpace(valor) ? DBNull.Value : (object)valor;

        private object FechaONull(string fecha)
        {
            if (string.IsNullOrWhiteSpace(fecha)) return DBNull.Value;
            DateTime f = DateTime.ParseExact(fecha, new[] { "yyyy-MM-dd", "dd-MM-yyyy", "dd/MM/yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.None);
            return f.ToString("yyyy-MM-dd");
        }

        public OdbcDataAdapter MostrarMantenimientos()
        {
            return new OdbcDataAdapter("SELECT * FROM Tbl_mantenimiento;", conexion.conexion());
        }

        public void InsertarMantenimiento(string salon, string habitacion, string empleado, string tipo, string descripcion,
                                          string estado, string fechaInicio, string fechaFin)
        {
            const string sql = @"INSERT INTO Tbl_mantenimiento 
                                 (Fk_Id_Salon, Fk_Id_Habitacion, Fk_Id_Empleado, 
                                  Cmp_Tipo_Mantenimiento, Cmp_Descripcion_Mantenimiento,
                                  Cmp_Estado, Cmp_Fecha_Inicio_Mantenimiento, Cmp_Fecha_Fin_Mantenimiento)
                                 VALUES (?,?,?,?,?,?,?,?)";

            using (var conn = conexion.conexion())
            {
                conn.Open();
                using (var cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("Fk_Id_Salon", ValorONull(salon));
                    cmd.Parameters.AddWithValue("Fk_Id_Habitacion", ValorONull(habitacion));
                    cmd.Parameters.AddWithValue("Fk_Id_Empleado", ValorONull(empleado));
                    cmd.Parameters.AddWithValue("Cmp_Tipo_Mantenimiento", ValorONull(tipo));
                    cmd.Parameters.AddWithValue("Cmp_Descripcion_Mantenimiento", ValorONull(descripcion));
                    cmd.Parameters.AddWithValue("Cmp_Estado", ValorONull(estado));
                    cmd.Parameters.AddWithValue("Cmp_Fecha_Inicio", FechaONull(fechaInicio));
                    cmd.Parameters.AddWithValue("Cmp_Fecha_Fin", FechaONull(fechaFin));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarMantenimiento(string id, string salon, string habitacion, string empleado, string tipo,
                                            string descripcion, string estado, string fechaInicio, string fechaFin)
        {
            const string sql = @"UPDATE Tbl_mantenimiento SET 
                                 Fk_Id_Salon=?, Fk_Id_Habitacion=?, Fk_Id_Empleado=?, 
                                 Cmp_Tipo_Mantenimiento=?, Cmp_Descripcion_Mantenimiento=?, 
                                 Cmp_Estado=?, Cmp_Fecha_Inicio_Mantenimiento=?, Cmp_Fecha_Fin_Mantenimiento=? 
                                 WHERE Pk_Id_Mantenimiento=?";

            using (var conn = conexion.conexion())
            {
                conn.Open();
                using (var cmd = new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("Fk_Id_Salon", ValorONull(salon));
                    cmd.Parameters.AddWithValue("Fk_Id_Habitacion", ValorONull(habitacion));
                    cmd.Parameters.AddWithValue("Fk_Id_Empleado", ValorONull(empleado));
                    cmd.Parameters.AddWithValue("Cmp_Tipo_Mantenimiento", ValorONull(tipo));
                    cmd.Parameters.AddWithValue("Cmp_Descripcion_Mantenimiento", ValorONull(descripcion));
                    cmd.Parameters.AddWithValue("Cmp_Estado", ValorONull(estado));
                    cmd.Parameters.AddWithValue("Cmp_Fecha_Inicio", FechaONull(fechaInicio));
                    cmd.Parameters.AddWithValue("Cmp_Fecha_Fin", FechaONull(fechaFin));
                    cmd.Parameters.AddWithValue("Pk_Id_Mantenimiento", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarMantenimiento(string id)
        {
            using (var conn = conexion.conexion())
            {
                conn.Open();
                using (var cmd = new OdbcCommand("DELETE FROM Tbl_mantenimiento WHERE Pk_Id_Mantenimiento=?;", conn))
                {
                    cmd.Parameters.AddWithValue("Pk_Id_Mantenimiento", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable BuscarMantenimientoPorId(string id)
        {
            var tabla = new DataTable();
            using (var conn = conexion.conexion())
            {
                using (var cmd = new OdbcCommand("SELECT * FROM Tbl_mantenimiento WHERE Pk_Id_Mantenimiento=?;", conn))
                {
                    cmd.Parameters.AddWithValue("Pk_Id_Mantenimiento", id);
                    new OdbcDataAdapter(cmd).Fill(tabla);
                }
            }
            return tabla;
        }

        public DataTable EjecutarConsulta(string sql)
        {
            var tabla = new DataTable();
            new OdbcDataAdapter(sql, conexion.conexion()).Fill(tabla);
            return tabla;
        }

        public DataTable ObtenerEmpleados() =>
            EjecutarConsulta("SELECT Pk_Id_Empleado, CONCAT(Pk_Id_Empleado, ' - ', Cmp_Nombres_Empleado, ' ', Cmp_Apellidos_Empleado) AS Nombre_Empleado FROM tbl_empleado ORDER BY Pk_Id_Empleado;");

        public DataTable ObtenerSalones() =>
            EjecutarConsulta("SELECT Pk_Id_Salon, CONCAT(Pk_Id_Salon, ' - ', Cmp_Nombre_Salon) AS Nombre_Salon FROM tbl_salones ORDER BY Pk_Id_Salon;");

        public DataTable ObtenerHabitaciones() =>
            EjecutarConsulta(@"SELECT h.PK_ID_Habitaciones, CONCAT(h.PK_ID_Habitaciones, ' - ', t.Cmp_Tipo_Habitacion) AS Nombre_Habitacion FROM Tbl_Habitaciones h INNER JOIN Tbl_Tipo_Habitacion t ON h.FK_ID_Tipo_Habitaciones = t.PK_ID_Tipo_Habitaciones ORDER BY h.PK_ID_Habitaciones;");

    }
}
