// Nombre: Diego Andre Monterroso Rabarique
// Carné: 0901-22-1369
// Fecha de modificación: 2025-11-09
// Descripción: Lógica de negocio para CRUD de Horas_Extras.

using System;
using System.Data;
using Capa_Modelo_HorasExtra;

namespace Capa_Controlador_HorasExtra
{
    public class Controlador
    {
        Sentencia sn = new Sentencia();

        public DataTable MostrarHorasExtra() => sn.ObtenerHorasExtra();
        // =====================================================
        // Guaradar Horas Extras
        // =====================================================
        public void GuardarHorasExtra(int idEmpleado, DateTime fecha, int horas, string motivo, bool aprobado)
        {
            sn.InsertarHoraExtra(idEmpleado, fecha, horas, motivo, aprobado);
        }
        // =====================================================
        // Actualizar Horas Extras
        // =====================================================
        public void ActualizarHorasExtra(int id, int idEmpleado, DateTime fecha, int horas, string motivo, bool aprobado)
        {
            sn.ModificarHoraExtra(id, idEmpleado, fecha, horas, motivo, aprobado);
        }

        // =====================================================
        // Eliminar Horas Extras
        // =====================================================
        public void EliminarHorasExtra(int id)
        {
            sn.EliminarHoraExtra(id);
        }
        // =====================================================
        // Buscar Empelados
        // =====================================================
        public DataTable BuscarPorEmpleado(string nombre)
        {
            return sn.BuscarPorEmpleado(nombre);
        }

        // =====================================================
        // Obtener Empleados
        // =====================================================

        public DataTable ObtenerEmpleados()
        {
            return sn.ObtenerEmpleados();
        }
    }
}