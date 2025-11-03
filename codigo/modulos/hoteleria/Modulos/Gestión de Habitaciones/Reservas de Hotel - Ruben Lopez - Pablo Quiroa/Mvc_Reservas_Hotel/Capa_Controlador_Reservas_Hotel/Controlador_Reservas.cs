using System;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Reservas_Hotel;

namespace Capa_Controlador_Reservas_Hotel
{
    public class Controlador_Reserva
    {
        private readonly Cls_Reserva modeloReserva = new Cls_Reserva();

        // ==================== METODOS PARA Frm_Reserva ====================
        public DataTable ObtenerHabitaciones() => modeloReserva.ObtenerHabitaciones();

        public string ObtenerBuffetDescripcion()
        {
            DataTable dt = modeloReserva.ObtenerBuffetData();
            if (dt.Rows.Count == 0) return null;
            var r = dt.Rows[0];
            return $"{r["Cmp_Tipo_Buffet"]} - {r["Cmp_Descripcion"]}";
        }

        public int ObtenerBuffetIdIncluido()
        {
            DataTable dt = modeloReserva.ObtenerBuffetData();
            if (dt.Rows.Count == 0) return 0;
            return Convert.ToInt32(dt.Rows[0]["Pk_Id_Buffet"]);
        }

        public DataRow ObtenerHuesped(string sTipoDoc, string sNumero)
        {
            DataTable dt = modeloReserva.ObtenerHuespedData(sTipoDoc, sNumero);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public int ObtenerPuntosHuesped(int iDHuesped) => modeloReserva.ObtenerPuntosHuesped(iDHuesped);

        public decimal CalcularTotalReserva(decimal dTarifaNoche, DateTime dFechaEntrada, DateTime dFechaSalida)
        {
            int dias = (dFechaSalida - dFechaEntrada).Days;
            if (dias <= 0) throw new ArgumentException("La fecha de salida debe ser posterior a la fecha de entrada.");
            return dTarifaNoche * dias;
        }

        public (decimal dTotalFinal, int iPuntosUsados, int iPuntosRestantes) CanjearPuntos(int iDHuesped, decimal dTotalActual, int iPuntosDisponibles)
        {
            int iUsados = Math.Min((int)Math.Ceiling(dTotalActual), Math.Max(iPuntosDisponibles, 0));
            decimal dTotalFinal = dTotalActual - iUsados;
            if (dTotalFinal < 0) dTotalFinal = 0;

            int iRestantes = iPuntosDisponibles - iUsados;
            if (iRestantes < 0) iRestantes = 0;

            modeloReserva.ActualizarPuntosHuesped(iDHuesped, iRestantes);
            return (dTotalFinal, iUsados, iRestantes);
        }

        public void InsertarReserva(int iDHuesped, int iDHabitacion, int iDBuffet,
                                    DateTime dFechaEntrada, DateTime dFechaSalida,
                                    int iNumHuespedes, string sPeticiones, string sEstado, decimal dTotal)
        {
            if (dFechaEntrada >= dFechaSalida)
                throw new ArgumentException("La fecha de entrada debe ser anterior a la de salida.");

            modeloReserva.InsertarReserva(iDHuesped, iDHabitacion, iDBuffet,
                                          dFechaEntrada, dFechaSalida,
                                          iNumHuespedes, sPeticiones, sEstado, dTotal);
        }

        // ==================== METODOS PARA Frm_ModificarReserva ====================
        public DataTable BuscarReservas(string sFiltro) => modeloReserva.BuscarReservas(sFiltro);
        public decimal ObtenerTarifaHabitacion(int iDHabitacion) => modeloReserva.ObtenerTarifaHabitacion(iDHabitacion);

        public void ActualizarReserva(int iDReserva, int iDHabitacion, DateTime dFechaEntrada, DateTime dFechaSalida,
                                      int iNumHuespedes, string sPeticiones, string sEstado, decimal dTotal)
        {
            modeloReserva.ActualizarReserva(iDReserva, iDHabitacion, dFechaEntrada, dFechaSalida, iNumHuespedes, sPeticiones, sEstado, dTotal);
        }

        // ==================== Salud de conexion ====================
        // Solo depuracion de que se conecta a la base de datos.
        public bool ProbarConexion()
        {
            try
            {
                Cls_Conexion c = new Cls_Conexion();
                using (OdbcConnection conn = c.conexion())
                {
                    return conn.State == System.Data.ConnectionState.Open;
                }
            }
            catch { return false; }
        }
    }
}
