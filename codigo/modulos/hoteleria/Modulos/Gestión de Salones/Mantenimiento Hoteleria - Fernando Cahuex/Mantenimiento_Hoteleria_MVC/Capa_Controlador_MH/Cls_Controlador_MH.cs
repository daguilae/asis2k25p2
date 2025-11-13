using System;
using System.Data;
using Capa_Modelo_MH;

namespace Capa_Controlador_MH
{
    public class Cls_Controlador_MH
    {
        private readonly Cls_Mantenimiento cls_Modelo = new Cls_Mantenimiento();

        public DataTable fun_MostrarMantenimientos()
        {
            var dts_Adapter = cls_Modelo.fun_MostrarMantenimientos();
            var dts_Tabla = new DataTable();
            dts_Adapter.Fill(dts_Tabla);
            return dts_Tabla;
        }

        public string fun_GuardarMantenimiento(string sSalon, string sHabitacion, string sEmpleado,
                                               string sTipo, string sDescripcion, string sEstado,
                                               string sFechaInicio, string sFechaFin)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(sHabitacion) && string.IsNullOrWhiteSpace(sSalon))
                    return "Debe seleccionar una habitación o un salón.";

                if (!string.IsNullOrWhiteSpace(sHabitacion) && !string.IsNullOrWhiteSpace(sSalon))
                    return "Solo puede seleccionar uno: habitación o salón.";

                if (string.IsNullOrWhiteSpace(sEmpleado))
                    return "Debe seleccionar un empleado.";

                if (string.IsNullOrWhiteSpace(sTipo))
                    return "Debe especificar el tipo de mantenimiento.";

                if (string.IsNullOrWhiteSpace(sEstado))
                    sEstado = "En mantenimiento";

                cls_Modelo.fun_InsertarMantenimiento(sSalon, sHabitacion, sEmpleado, sTipo, sDescripcion, sEstado, sFechaInicio, sFechaFin);
                return "Registro guardado correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error al guardar: {ex.Message}";
            }
        }

        public string fun_ActualizarMantenimiento(string sId, string sSalon, string sHabitacion, string sEmpleado,
                                                  string sTipo, string sDescripcion, string sEstado,
                                                  string sFechaInicio, string sFechaFin)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(sId))
                    return "Debe seleccionar un ID válido para actualizar.";

                cls_Modelo.fun_ActualizarMantenimiento(sId, sSalon, sHabitacion, sEmpleado, sTipo, sDescripcion, sEstado, sFechaInicio, sFechaFin);
                return "Registro actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error al actualizar: {ex.Message}";
            }
        }

        public string fun_EliminarMantenimiento(string sId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(sId))
                    return "Debe seleccionar un ID válido para eliminar.";

                cls_Modelo.fun_EliminarMantenimiento(sId);
                return "Registro eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar: {ex.Message}";
            }
        }

        public DataTable fun_BuscarMantenimientoPorId(string sId)
        {
            if (string.IsNullOrWhiteSpace(sId))
                return new DataTable();

            return cls_Modelo.fun_BuscarMantenimientoPorId(sId);
        }

        public DataTable fun_ObtenerEmpleados() => cls_Modelo.fun_ObtenerEmpleados();
        public DataTable fun_ObtenerSalones() => cls_Modelo.fun_ObtenerSalones();
        public DataTable fun_ObtenerHabitaciones() => cls_Modelo.fun_ObtenerHabitaciones();
    }
}
