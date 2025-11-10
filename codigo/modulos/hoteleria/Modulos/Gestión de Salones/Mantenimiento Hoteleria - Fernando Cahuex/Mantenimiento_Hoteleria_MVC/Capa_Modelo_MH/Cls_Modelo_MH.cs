using System;
using System.Data;
using System.Data.Odbc;
using System.Globalization;

namespace Capa_Modelo_MH
{
    public class Cls_Mantenimiento
    {
        private readonly Cls_ConexionMysql cls_Conexion = new Cls_ConexionMysql();

        private object fun_ValorONull(string sValor) =>
            string.IsNullOrWhiteSpace(sValor) ? DBNull.Value : (object)sValor;

        private object fun_FechaONull(string sFecha)
        {
            if (string.IsNullOrWhiteSpace(sFecha)) return DBNull.Value;
            DateTime dFecha = DateTime.ParseExact(sFecha, new[] { "yyyy-MM-dd", "dd-MM-yyyy", "dd/MM/yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.None);
            return dFecha.ToString("yyyy-MM-dd");
        }

        public OdbcDataAdapter fun_MostrarMantenimientos()
        {
            return new OdbcDataAdapter("SELECT * FROM Tbl_Mantenimiento;", cls_Conexion.fun_Conexion());
        }

        public void fun_InsertarMantenimiento(string sSalon, string sHabitacion, string sEmpleado, string sTipo, string sDescripcion,
                                              string sEstado, string sFechaInicio, string sFechaFin)
        {
            const string sSql = @"INSERT INTO Tbl_Mantenimiento 
                                 (Fk_Id_Salon, Fk_Id_Habitacion, Fk_Id_Empleado, 
                                  Cmp_Tipo_Mantenimiento, Cmp_Descripcion_Mantenimiento,
                                  Cmp_Estado, Cmp_Fecha_Inicio_Mantenimiento, Cmp_Fecha_Fin_Mantenimiento)
                                 VALUES (?,?,?,?,?,?,?,?)";

            using (var conn = cls_Conexion.fun_Conexion())
            {
                conn.Open();
                using (var cmd = new OdbcCommand(sSql, conn))
                {
                    cmd.Parameters.AddWithValue("Fk_Id_Salon", fun_ValorONull(sSalon));
                    cmd.Parameters.AddWithValue("Fk_Id_Habitacion", fun_ValorONull(sHabitacion));
                    cmd.Parameters.AddWithValue("Fk_Id_Empleado", fun_ValorONull(sEmpleado));
                    cmd.Parameters.AddWithValue("Cmp_Tipo_Mantenimiento", fun_ValorONull(sTipo));
                    cmd.Parameters.AddWithValue("Cmp_Descripcion_Mantenimiento", fun_ValorONull(sDescripcion));
                    cmd.Parameters.AddWithValue("Cmp_Estado", fun_ValorONull(sEstado));
                    cmd.Parameters.AddWithValue("Cmp_Fecha_Inicio", fun_FechaONull(sFechaInicio));
                    cmd.Parameters.AddWithValue("Cmp_Fecha_Fin", fun_FechaONull(sFechaFin));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void fun_ActualizarMantenimiento(string sId, string sSalon, string sHabitacion, string sEmpleado, string sTipo,
                                                string sDescripcion, string sEstado, string sFechaInicio, string sFechaFin)
        {
            const string sSql = @"UPDATE Tbl_Mantenimiento SET 
                                 Fk_Id_Salon=?, Fk_Id_Habitacion=?, Fk_Id_Empleado=?, 
                                 Cmp_Tipo_Mantenimiento=?, Cmp_Descripcion_Mantenimiento=?, 
                                 Cmp_Estado=?, Cmp_Fecha_Inicio_Mantenimiento=?, Cmp_Fecha_Fin_Mantenimiento=? 
                                 WHERE Pk_Id_Mantenimiento=?";

            using (var conn = cls_Conexion.fun_Conexion())
            {
                conn.Open();
                using (var cmd = new OdbcCommand(sSql, conn))
                {
                    cmd.Parameters.AddWithValue("Fk_Id_Salon", fun_ValorONull(sSalon));
                    cmd.Parameters.AddWithValue("Fk_Id_Habitacion", fun_ValorONull(sHabitacion));
                    cmd.Parameters.AddWithValue("Fk_Id_Empleado", fun_ValorONull(sEmpleado));
                    cmd.Parameters.AddWithValue("Cmp_Tipo_Mantenimiento", fun_ValorONull(sTipo));
                    cmd.Parameters.AddWithValue("Cmp_Descripcion_Mantenimiento", fun_ValorONull(sDescripcion));
                    cmd.Parameters.AddWithValue("Cmp_Estado", fun_ValorONull(sEstado));
                    cmd.Parameters.AddWithValue("Cmp_Fecha_Inicio", fun_FechaONull(sFechaInicio));
                    cmd.Parameters.AddWithValue("Cmp_Fecha_Fin", fun_FechaONull(sFechaFin));
                    cmd.Parameters.AddWithValue("Pk_Id_Mantenimiento", sId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void fun_EliminarMantenimiento(string sId)
        {
            using (var conn = cls_Conexion.fun_Conexion())
            {
                conn.Open();
                using (var cmd = new OdbcCommand("DELETE FROM Tbl_Mantenimiento WHERE Pk_Id_Mantenimiento=?;", conn))
                {
                    cmd.Parameters.AddWithValue("Pk_Id_Mantenimiento", sId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable fun_BuscarMantenimientoPorId(string sId)
        {
            var dts_Tabla = new DataTable();
            using (var conn = cls_Conexion.fun_Conexion())
            {
                using (var cmd = new OdbcCommand("SELECT * FROM Tbl_Mantenimiento WHERE Pk_Id_Mantenimiento=?;", conn))
                {
                    cmd.Parameters.AddWithValue("Pk_Id_Mantenimiento", sId);
                    new OdbcDataAdapter(cmd).Fill(dts_Tabla);
                }
            }
            return dts_Tabla;
        }

        public DataTable fun_EjecutarConsulta(string sSql)
        {
            var dts_Tabla = new DataTable();
            new OdbcDataAdapter(sSql, cls_Conexion.fun_Conexion()).Fill(dts_Tabla);
            return dts_Tabla;
        }

        public DataTable fun_ObtenerEmpleados() =>
            fun_EjecutarConsulta("SELECT Pk_Id_Empleado, CONCAT(Pk_Id_Empleado, ' - ', Cmp_Nombres_Empleado, ' ', Cmp_Apellidos_Empleado) AS Nombre_Empleado FROM Tbl_Empleado ORDER BY Pk_Id_Empleado;");

        public DataTable fun_ObtenerSalones() =>
            fun_EjecutarConsulta("SELECT Pk_Id_Salon, CONCAT(Pk_Id_Salon, ' - ', Cmp_Nombre_Salon) AS Nombre_Salon FROM Tbl_Salones ORDER BY Pk_Id_Salon;");

        public DataTable fun_ObtenerHabitaciones() =>
            fun_EjecutarConsulta(@"SELECT h.PK_ID_Habitaciones, CONCAT(h.PK_ID_Habitaciones, ' - ', t.Cmp_Tipo_Habitacion) AS Nombre_Habitacion FROM Tbl_Habitaciones h INNER JOIN Tbl_Tipo_Habitacion t ON h.FK_ID_Tipo_Habitaciones = t.PK_ID_Tipo_Habitaciones ORDER BY h.PK_ID_Habitaciones;");
    }
}
