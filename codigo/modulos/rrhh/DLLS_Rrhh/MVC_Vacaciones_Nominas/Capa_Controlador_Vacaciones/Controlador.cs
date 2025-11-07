using System;
using System.Data;
using Capa_Modelo_Vacaciones;

namespace Capa_Controlador_Vacaciones
{
    public class Controlador
    {
        private readonly Sentencias sentencias = new Sentencias();

        public DataTable BuscarVacaciones(int idEmpleado)
            => sentencias.ObtenerVacaciones(idEmpleado);

        public string SolicitarVacaciones(int idEmpleado, DateTime inicio, DateTime fin)
        {
            if (inicio >= fin) return "La fecha de inicio debe ser anterior a la fecha final.";

            int dias = (fin - inicio).Days + 1;
            bool exito = sentencias.InsertarSolicitud(idEmpleado, inicio, fin, dias);
            return exito ? "Solicitud enviada correctamente." : "Error al enviar solicitud.";
        }

        public string EditarVacacion(int idVacacion, DateTime inicio, DateTime fin)
        {
            if (inicio >= fin) return "La fecha de inicio debe ser anterior a la fecha final.";

            int dias = (fin - inicio).Days + 1;
            bool exito = sentencias.ActualizarVacacion(idVacacion, inicio, fin, dias);
            return exito ? "Vacación actualizada correctamente." : "Error al actualizar.";
        }

        public DataRow CargarVacacion(int idVacacion)
            => sentencias.ObtenerVacacionPorId(idVacacion);

        public string EliminarVacacion(int idVacacion)
        {
            bool exito = sentencias.EliminarVacacion(idVacacion);
            return exito ? "Vacación eliminada correctamente." : "Error al eliminar.";
        }
    }
}