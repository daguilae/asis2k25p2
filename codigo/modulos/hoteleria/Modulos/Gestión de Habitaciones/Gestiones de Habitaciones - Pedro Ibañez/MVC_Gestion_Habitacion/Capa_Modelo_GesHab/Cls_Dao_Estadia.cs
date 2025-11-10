using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_GesHab
{
    public class Cls_Dao_Estadia
    {
        private Cls_conexionMYSQL oConexion = new Cls_conexionMYSQL();

        // ==========================================================================================
        // Insertar una nueva estadía
        public bool InsertarEstadia(
            int iIdHabitacion,
            int iIdHuesped,
            int iNumHuespedes,
            bool bTieneReserva,
            DateTime dFechaCheckIn,
            DateTime dFechaActual,
            decimal deMontoTotal)
        {
            try
            {
                using (OdbcConnection oConn = oConexion.conexion())
                {
                    oConn.Open();

                    string sQuery = "INSERT INTO Tbl_Estadia " +
                                   "(Fk_Id_Habitaciones, Fk_Id_Huesped_Checkin, Cmp_Num_Huespedes, " +
                                   "Cmp_Fecha_Check_In, Cmp_Fecha_Check_Out, Cmp_Tiene_Reservacion, Cmp_Monto_Total_Pago) " +
                                   "VALUES (?,?,?,?,?,?,?)";

                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    {
                        oCmd.Parameters.AddWithValue("@Fk_Id_Habitaciones", iIdHabitacion);
                        oCmd.Parameters.AddWithValue("@Fk_Id_Huesped_Checkin", iIdHuesped);
                        oCmd.Parameters.AddWithValue("@Cmp_Num_Huespedes", iNumHuespedes);
                        oCmd.Parameters.AddWithValue("@Cmp_Fecha_Check_In", dFechaCheckIn);
                        oCmd.Parameters.AddWithValue("@Cmp_Fecha_Check_Out", dFechaActual);
                        oCmd.Parameters.AddWithValue("@Cmp_Tiene_Reservacion", bTieneReserva ? 1 : 0);
                        oCmd.Parameters.AddWithValue("@Cmp_Monto_Total_Pago", deMontoTotal);

                        oCmd.ExecuteNonQuery();
                    }

                    oConn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar estadía: " + ex.Message);
                return false;
            }
        }

        // ==========================================================================================
        // Eliminar una estadía existente
        public bool EliminarEstadia(int iIdEstadia)
        {
            try
            {
                using (OdbcConnection oConn = oConexion.conexion())
                {
                    oConn.Open();

                    string sQuery = "DELETE FROM Tbl_Estadia WHERE Pk_Id_Estadia = ?";

                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    {
                        oCmd.Parameters.AddWithValue("@Pk_Id_Estadia", iIdEstadia);
                        int iFilasAfectadas = oCmd.ExecuteNonQuery();

                        oConn.Close();
                        return iFilasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar estadía: " + ex.Message);
                return false;
            }
        }

        // ==========================================================================================
        // Modificar una estadía existente
        public bool ModificarEstadia(
            int iIdEstadia,
            int iIdHabitacion,
            int iIdHuesped,
            int iNumHuespedes,
            bool bTieneReserva,
            DateTime dFechaCheckIn,
            DateTime dFechaActual,
            decimal deMontoTotal)
        {
            try
            {
                using (OdbcConnection oConn = oConexion.conexion())
                {
                    oConn.Open();

                    string sQuery = "UPDATE Tbl_Estadia SET " +
                                   "Fk_Id_Habitaciones = ?, " +
                                   "Fk_Id_Huesped_Checkin = ?, " +
                                   "Cmp_Num_Huespedes = ?, " +
                                   "Cmp_Fecha_Check_In = ?, " +
                                   "Cmp_Fecha_Check_Out = ?, " +
                                   "Cmp_Tiene_Reservacion = ?, " +
                                   "Cmp_Monto_Total_Pago = ? " +
                                   "WHERE Pk_Id_Estadia = ?";

                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    {
                        oCmd.Parameters.AddWithValue("@Fk_Id_Habitaciones", iIdHabitacion);
                        oCmd.Parameters.AddWithValue("@Fk_Id_Huesped_Checkin", iIdHuesped);
                        oCmd.Parameters.AddWithValue("@Cmp_Num_Huespedes", iNumHuespedes);
                        oCmd.Parameters.AddWithValue("@Cmp_Fecha_Check_In", dFechaCheckIn);
                        oCmd.Parameters.AddWithValue("@Cmp_Fecha_Check_Out", dFechaActual);
                        oCmd.Parameters.AddWithValue("@Cmp_Tiene_Reservacion", bTieneReserva ? 1 : 0);
                        oCmd.Parameters.AddWithValue("@Cmp_Monto_Total_Pago", deMontoTotal);
                        oCmd.Parameters.AddWithValue("@Pk_Id_Estadia", iIdEstadia);

                        int iFilasAfectadas = oCmd.ExecuteNonQuery();
                        oConn.Close();

                        return iFilasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar estadía: " + ex.Message);
                return false;
            }
        }

        // ==========================================================================================
        // Obtener IDs de estadías
        public DataTable ObtenerIdsEstadia()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = "SELECT Pk_Id_Estadia FROM Tbl_Estadia;";

            try
            {
                using (OdbcConnection oConn = oConexion.conexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    using (OdbcDataAdapter oDa = new OdbcDataAdapter(oCmd))
                    {
                        oDa.Fill(dtResultado);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los IDs de estadía: " + ex.Message);
            }

            return dtResultado;
        }

        // ==========================================================================================
        // Obtener habitaciones disponibles
        public DataTable ObtenerHabitaciones()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = "SELECT PK_Id_Habitaciones FROM Tbl_Habitaciones WHERE Cmp_Estado_Habitacion = 1;";

            try
            {
                using (OdbcConnection oConn = oConexion.conexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    using (OdbcDataAdapter oDa = new OdbcDataAdapter(oCmd))
                    {
                        oDa.Fill(dtResultado);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener habitaciones: " + ex.Message);
            }

            return dtResultado;
        }

        // ==========================================================================================
        // Obtener huéspedes (ID y nombre completo)
        public DataTable ObtenerHuespedes()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = "SELECT Pk_Id_Huesped, CONCAT(Cmp_Nombre, ' ', Cmp_Apellido) AS NombreCompleto FROM Tbl_Huesped;";

            try
            {
                using (OdbcConnection oConn = oConexion.conexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    using (OdbcDataAdapter oDa = new OdbcDataAdapter(oCmd))
                    {
                        oDa.Fill(dtResultado);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener huéspedes: " + ex.Message);
            }

            return dtResultado;
        }

        // ==========================================================================================
        // Obtener tarifa por noche
        public double ObtenerTarifaPorNoche(int iIdHabitacion)
        {
            double doTarifa = 0.0;
            string sQuery = "SELECT Cmp_Tarifa_Noche FROM Tbl_Habitaciones WHERE Pk_Id_Habitaciones = ?;";

            try
            {
                using (OdbcConnection oConn = oConexion.conexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    {
                        oCmd.Parameters.AddWithValue("@id", iIdHabitacion);

                        object oResult = oCmd.ExecuteScalar();
                        if (oResult != null && oResult != DBNull.Value)
                        {
                            doTarifa = Convert.ToDouble(oResult);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener tarifa por noche: " + ex.Message);
            }

            return doTarifa;
        }

        // ==========================================================================================
        // Obtener capacidad de habitación
        public int ObtenerCapacidadHabitacion(int iIdHabitacion)
        {
            int iCapacidad = 0;
            string sQuery = "SELECT Cmp_Capacidad_Habitacion FROM Tbl_Habitaciones WHERE Pk_Id_Habitaciones = ?;";

            try
            {
                using (OdbcConnection oConn = oConexion.conexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    {
                        oCmd.Parameters.AddWithValue("@id", iIdHabitacion);

                        object oResult = oCmd.ExecuteScalar();
                        if (oResult != null && oResult != DBNull.Value)
                        {
                            iCapacidad = Convert.ToInt32(oResult);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener capacidad de habitación: " + ex.Message);
            }

            return iCapacidad;
        }

        // ==========================================================================================
        // Obtener una estadía específica por ID
        public DataTable ObtenerEstadiaPorId(int iIdEstadia)
        {
            DataTable dtResultado = new DataTable();
            string sQuery = @"
                SELECT 
                    E.Pk_Id_Estadia,
                    E.Fk_Id_Habitaciones,
                    E.Fk_Id_Huesped_Checkin,
                    E.Cmp_Num_Huespedes,
                    E.Cmp_Tiene_Reservacion,
                    E.Cmp_Fecha_Check_In,
                    E.Cmp_Fecha_Check_Out,
                    E.Cmp_Monto_Total_Pago
                FROM Tbl_Estadia E
                WHERE E.Pk_Id_Estadia = ?;";

            try
            {
                using (OdbcConnection oConn = oConexion.conexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    {
                        oCmd.Parameters.AddWithValue("@id", iIdEstadia);
                        using (OdbcDataAdapter oDa = new OdbcDataAdapter(oCmd))
                        {
                            oDa.Fill(dtResultado);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener estadía: " + ex.Message);
            }

            return dtResultado;
        }
    }
}
