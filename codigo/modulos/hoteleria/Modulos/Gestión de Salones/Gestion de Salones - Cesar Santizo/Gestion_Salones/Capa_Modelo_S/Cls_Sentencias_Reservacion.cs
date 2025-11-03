using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_S
{
    public class Cls_Sentencias_Reservacion
    {
        // ==========================
        // INSERTAR RESERVA
        // ==========================
        public void InsertarReservaSalon(int idHuesped, int idSalon, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin, int cantidadPersonas, decimal montoTotal)
        {
            Cls_Conexion_Hoteleria cn = new Cls_Conexion_Hoteleria();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = @"INSERT INTO Tbl_Reservas_Salones 
                            (Fk_Id_Huesped, Fk_Id_Salon, Cmp_Fecha_Reserva, Cmp_Hora_Inicio, Cmp_Hora_Fin, Cmp_Cantidad_Personas, Cmp_Monto_Total)
                            VALUES (?,?,?,?,?,?,?)";

                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.Add(new OdbcParameter("", idHuesped));
                    cmd.Parameters.Add(new OdbcParameter("", idSalon));
                    cmd.Parameters.Add(new OdbcParameter("", fecha));
                    cmd.Parameters.Add(new OdbcParameter("", horaInicio));
                    cmd.Parameters.Add(new OdbcParameter("", horaFin));
                    cmd.Parameters.Add(new OdbcParameter("", cantidadPersonas));
                    cmd.Parameters.Add(new OdbcParameter("", montoTotal));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ==========================
        // MODIFICAR RESERVA
        // ==========================
        public void ModificarReservaSalon(int idReserva, int idHuesped, int idSalon, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin, int cantidadPersonas, decimal montoTotal)
        {
            Cls_Conexion_Hoteleria cn = new Cls_Conexion_Hoteleria();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = @"UPDATE Tbl_Reservas_Salones 
                            SET Fk_Id_Huesped=?, Fk_Id_Salon=?, Cmp_Fecha_Reserva=?, Cmp_Hora_Inicio=?, Cmp_Hora_Fin=?, 
                                Cmp_Cantidad_Personas=?, Cmp_Monto_Total=? 
                            WHERE Pk_Id_Reserva_Salon=?";

                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.Add(new OdbcParameter("", idHuesped));
                    cmd.Parameters.Add(new OdbcParameter("", idSalon));
                    cmd.Parameters.Add(new OdbcParameter("", fecha));
                    cmd.Parameters.Add(new OdbcParameter("", horaInicio));
                    cmd.Parameters.Add(new OdbcParameter("", horaFin));
                    cmd.Parameters.Add(new OdbcParameter("", cantidadPersonas));
                    cmd.Parameters.Add(new OdbcParameter("", montoTotal));
                    cmd.Parameters.Add(new OdbcParameter("", idReserva));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ==========================
        // ELIMINAR RESERVA
        // ==========================
        public void EliminarReservaSalon(int idReserva)
        {
            Cls_Conexion_Hoteleria cn = new Cls_Conexion_Hoteleria();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "DELETE FROM Tbl_Reservas_Salones WHERE Pk_Id_Reserva_Salon=?";
                using (OdbcCommand cmd = new OdbcCommand(sql, con))
                {
                    cmd.Parameters.Add(new OdbcParameter("", idReserva));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ==========================
        // CONSULTAR TODAS LAS RESERVAS
        // ==========================
        public DataTable ObtenerReservasSalones()
        {
            DataTable tabla = new DataTable();
            Cls_Conexion_Hoteleria cn = new Cls_Conexion_Hoteleria();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = @"SELECT 
                                r.Pk_Id_Reserva_Salon,
                                r.Fk_Id_Huesped,
                                r.Fk_Id_Salon,
                                CONCAT(h.Cmp_Nombre, ' ', h.Cmp_Apellido) AS Cmp_Huesped,
                                s.Cmp_Nombre_Salon AS Cmp_Salon,
                                r.Cmp_Fecha_Reserva,
                                r.Cmp_Hora_Inicio,
                                r.Cmp_Hora_Fin,
                                r.Cmp_Cantidad_Personas,
                                r.Cmp_Monto_Total
                               FROM Tbl_Reservas_Salones r
                               INNER JOIN Tbl_Huesped h ON r.Fk_Id_Huesped = h.Pk_Id_Huesped
                               INNER JOIN Tbl_Salones s ON r.Fk_Id_Salon = s.Pk_Id_Salon";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, con);
                da.Fill(tabla);
            }
            return tabla;
        }

        // ==========================
        // COMBOBOX: HUESPEDES
        // ==========================
        public DataTable ObtenerHuespedes()
        {
            DataTable dt = new DataTable();
            Cls_Conexion_Hoteleria cn = new Cls_Conexion_Hoteleria();
            using (OdbcConnection con = cn.conexion())
            {
                string query = "SELECT Pk_Id_Huesped, CONCAT(Cmp_Nombre, ' ', Cmp_Apellido) AS Cmp_Nombre FROM Tbl_Huesped";
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, con);
                adapter.Fill(dt);
            }
            return dt;
        }

        // ==========================
        // COMBOBOX: SALONES DISPONIBLES
        // ==========================
        public DataTable ObtenerSalonesDisponibles()
        {
            DataTable tabla = new DataTable();
            Cls_Conexion_Hoteleria cn = new Cls_Conexion_Hoteleria();
            using (OdbcConnection con = cn.conexion())
            {
                string sql = "SELECT Pk_Id_Salon, Cmp_Nombre_Salon FROM Tbl_Salones WHERE Cmp_Disponibilidad = 1";
                OdbcDataAdapter da = new OdbcDataAdapter(sql, con);
                da.Fill(tabla);
            }
            return tabla;
        }
    }
}