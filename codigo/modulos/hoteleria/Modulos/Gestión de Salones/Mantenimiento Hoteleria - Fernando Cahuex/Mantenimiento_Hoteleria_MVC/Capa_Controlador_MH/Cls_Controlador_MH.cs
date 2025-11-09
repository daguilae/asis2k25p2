using System;
using System.Data;
using Capa_Modelo_MH;

namespace Capa_Controlador_MH
{
    public class Cls_Controlador_MH
    {
        private readonly Cls_Mantenimiento modelo = new Cls_Mantenimiento();

        // ================================================================
        // MOSTRAR TODOS LOS REGISTROS
        // ================================================================
        public DataTable MostrarMantenimientos()
        {
            var adapter = modelo.MostrarMantenimientos();
            var tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }

        // ================================================================
        // GUARDAR REGISTRO
        // ================================================================
        public string GuardarMantenimiento(string salon, string habitacion, string empleado,
                                           string tipo, string descripcion, string estado,
                                           string fechaInicio, string fechaFin)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(habitacion) && string.IsNullOrWhiteSpace(salon))
                    return "Debe seleccionar una habitación o un salón.";

                if (!string.IsNullOrWhiteSpace(habitacion) && !string.IsNullOrWhiteSpace(salon))
                    return "Solo puede seleccionar uno: habitación o salón.";

                if (string.IsNullOrWhiteSpace(empleado))
                    return "Debe seleccionar un empleado.";

                if (string.IsNullOrWhiteSpace(tipo))
                    return "Debe especificar el tipo de mantenimiento.";

                if (string.IsNullOrWhiteSpace(estado))
                    estado = "En mantenimiento";

                modelo.InsertarMantenimiento(salon, habitacion, empleado, tipo, descripcion, estado, fechaInicio, fechaFin);
                return "Registro guardado correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error al guardar: {ex.Message}";
            }
        }

        // ================================================================
        // ACTUALIZAR
        // ================================================================
        public string ActualizarMantenimiento(string id, string salon, string habitacion, string empleado,
                                              string tipo, string descripcion, string estado,
                                              string fechaInicio, string fechaFin)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                    return "Debe seleccionar un ID válido para actualizar.";

                modelo.ActualizarMantenimiento(id, salon, habitacion, empleado, tipo, descripcion, estado, fechaInicio, fechaFin);
                return "Registro actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error al actualizar: {ex.Message}";
            }
        }

        // ================================================================
        // ELIMINAR
        // ================================================================
        public string EliminarMantenimiento(string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                    return "Debe seleccionar un ID válido para eliminar.";

                modelo.EliminarMantenimiento(id);
                return "Registro eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar: {ex.Message}";
            }
        }

        // ================================================================
        // BUSCAR POR ID
        // ================================================================
        public DataTable BuscarMantenimientoPorId(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return new DataTable();

            return modelo.BuscarMantenimientoPorId(id);
        }

        // ================================================================
        // MÉTODOS PARA COMBOS
        // ================================================================
        public DataTable ObtenerEmpleados() => modelo.ObtenerEmpleados();
        public DataTable ObtenerSalones() => modelo.ObtenerSalones();
        public DataTable ObtenerHabitaciones() => modelo.ObtenerHabitaciones();
    }
}
