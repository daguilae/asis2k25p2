using System;
using System.Data;

namespace Capa_Controldor_MB
{
    public static class Cls_ValidacionesCombos
    {
        public static (bool tieneDatos, string mensaje) ValidarDataTableCombo(DataTable dataTable, string nombreEntidad)
        {
            if (dataTable == null)
                return (false, $"No se pudo obtener {nombreEntidad} de la base de datos.");

            if (dataTable.Rows.Count == 0)
                return (false, $"No hay {nombreEntidad} disponibles en la base de datos.");

            return (true, "OK");
        }

        public static (bool configuracionCorrecta, string mensaje) ValidarConfiguracionCombo(
            DataTable dataTable, string displayMember, string valueMember)
        {
            if (dataTable == null)
                return (false, "El DataTable no puede ser nulo.");

            if (!dataTable.Columns.Contains(displayMember))
                return (false, $"La columna '{displayMember}' no existe en el DataTable.");

            if (!dataTable.Columns.Contains(valueMember))
                return (false, $"La columna '{valueMember}' no existe en el DataTable.");

            return (true, "OK");
        }

        public static string ObtenerMensajeErrorCarga(string entidad, Exception ex)
        {
            return $"Error al cargar {entidad}: {ex.Message}";
        }

        public static bool EsDataTableValidoParaCombo(DataTable dataTable, string displayMember, string valueMember)
        {
            return dataTable != null &&
                   dataTable.Columns.Contains(displayMember) &&
                   dataTable.Columns.Contains(valueMember);
        }
    }
}