// Nombre: Jose Pablo Medina González
// Carné: 0901-22-2592
// Fecha de modificación: 2025-11-09
// Descripción: Lógica de negocio para CRUD de vacaciones.

using System;
using System.Data;
using Capa_Modelo_Vacaciones;

namespace Capa_Controlador_Vacaciones
{
    public class Controlador
    {
        private readonly Sentencias _sentencias = new Sentencias();

        public DataTable BuscarVacaciones(int idEmpleado)
        {
            return _sentencias.ObtenerVacaciones(idEmpleado);
        }

        public string SolicitarVacaciones(int idEmpleado, DateTime inicio, DateTime fin)
        {
            if (inicio >= fin) return "La fecha de inicio debe ser anterior a la fecha final.";

            int dias = (fin - inicio).Days + 1;
            bool exito = _sentencias.InsertarSolicitud(idEmpleado, inicio, fin, dias);
            return exito ? "Solicitud enviada correctamente." : "Error al enviar solicitud.";
        }

        public string EditarVacacion(int idVacacion, DateTime inicio, DateTime fin)
        {
            if (inicio >= fin) return "La fecha de inicio debe ser anterior a la fecha final.";

            int dias = (fin - inicio).Days + 1;
            bool exito = _sentencias.ActualizarVacacion(idVacacion, inicio, fin, dias);
            return exito ? "Vacación actualizada correctamente." : "Error al actualizar.";
        }

        public DataRow CargarVacacion(int idVacacion)
        {
            return _sentencias.ObtenerVacacionPorId(idVacacion);
        }

        public string EliminarVacacion(int idVacacion)
        {
            bool exito = _sentencias.EliminarVacacion(idVacacion);
            return exito ? "Vacación eliminada correctamente." : "Error al eliminar.";
        }
    }
}