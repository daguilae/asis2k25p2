// Cesar Armando Estrada Elias 0901-22-10153
using System;
using System.Collections.Generic;
using System.Linq;
using Capa_Modelo_Seguridad;

namespace Capa_Controlador_Seguridad
{
    public class Cls_AplicacionControlador
    {
        private Cls_AplicacionDAO daoAplicacion = new Cls_AplicacionDAO();

        // Obtener todas las aplicaciones
        public List<Cls_Aplicacion> ObtenerTodasLasAplicaciones()
        {
            return daoAplicacion.ObtenerAplicaciones();
        }

        // Insertar aplicación con validaciones
        public (bool exito, string mensaje) InsertarAplicacion(int idAplicacion, string nombre, string descripcion, bool estado, int? idModulo = null, int? idReporte = null)
        {
            if (idAplicacion <= 0) return (false, "El ID de aplicación debe ser mayor a 0.");
            if (string.IsNullOrWhiteSpace(nombre)) return (false, "Debe ingresar el nombre de la aplicación.");
            if (string.IsNullOrWhiteSpace(descripcion)) return (false, "Debe ingresar la descripción de la aplicación.");
            if (daoAplicacion.BuscarPorId(idAplicacion) != null) return (false, "El ID ya existe, por favor ingrese otro.");
            if (idModulo == null) return (false, "Debe seleccionar un módulo.");

            Cls_Aplicacion nuevaApp = new Cls_Aplicacion
            {
                iPkIdAplicacion = idAplicacion,
                sNombreAplicacion = nombre,
                sDescripcionAplicacion = descripcion,
                bEstadoAplicacion = estado,
                iFkIdReporte = idReporte
            };

            int resultado = daoAplicacion.InsertarAplicacion(nuevaApp);
            return resultado > 0 ? (true, "Aplicación guardada correctamente.") : (false, "Error al guardar la aplicación.");
        }

        // Actualizar aplicación con validaciones
        public (bool exito, string mensaje) ActualizarAplicacion(int idAplicacion, string nombre, string descripcion, bool estado, int? idReporte = null)
        {
            if (idAplicacion <= 0) return (false, "ID inválido para actualizar.");
            if (string.IsNullOrWhiteSpace(nombre)) return (false, "Debe ingresar el nombre de la aplicación.");
            if (string.IsNullOrWhiteSpace(descripcion)) return (false, "Debe ingresar la descripción de la aplicación.");

            Cls_Aplicacion appExistente = daoAplicacion.BuscarPorId(idAplicacion);
            if (appExistente == null) return (false, "No se encontró la aplicación a modificar.");

            Cls_Aplicacion appActualizada = new Cls_Aplicacion
            {
                iPkIdAplicacion = idAplicacion,
                sNombreAplicacion = nombre,
                sDescripcionAplicacion = descripcion,
                bEstadoAplicacion = estado,
                iFkIdReporte = idReporte
            };

            bool actualizado = daoAplicacion.ActualizarAplicacion(appActualizada) > 0;
            return actualizado ? (true, "Aplicación modificada correctamente.") : (false, "Error al modificar la aplicación.");
        }

        // Eliminar aplicación (físico), bitácora desde la vista
        public (bool exito, string mensaje) BorrarAplicacion(int idAplicacion)
        {
            if (idAplicacion <= 0) return (false, "ID inválido para eliminar.");

            Cls_Aplicacion appExistente = daoAplicacion.BuscarPorId(idAplicacion);
            if (appExistente == null) return (false, "No se encontró la aplicación a eliminar.");

            try
            {
                // Llamamos al método correcto del DAO
                bool eliminado = daoAplicacion.BorrarAplicacion(idAplicacion) > 0;

                return eliminado ? (true, "Aplicación eliminada correctamente.")
                                 : (false, "Error al eliminar la aplicación.");
            }
            catch (Exception ex)
            {
                return (false, $"No se pudo eliminar la aplicación: {ex.Message}");
            }
        }

        // Buscar aplicación por ID
        public Cls_Aplicacion BuscarAplicacionPorId(int idAplicacion)
        {
            return daoAplicacion.BuscarPorId(idAplicacion);
        }

        // Buscar aplicación por nombre
        public Cls_Aplicacion BuscarAplicacionPorNombre(string nombre)
        {
            return daoAplicacion.ObtenerAplicaciones()
                               .FirstOrDefault(a => a.sNombreAplicacion.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }
    }
}
