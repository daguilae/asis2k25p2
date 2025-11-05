using System.Data;
using Capa_Modelo_Percepciones_Nomina;

namespace Capa_Controlador_Percepciones_Nomina
{
    public class CatalogosControlador
    {
        public readonly CatalogosModelo _modelo = new CatalogosModelo();

        public DataTable ListarConceptosNomina()
        {
            return _modelo.ObtenerConceptosNomina();
        }

        public DataTable ListarEmpleados()
        {
            return _modelo.ObtenerEmpleados();
        }

        public DataTable ListarNumerosNomina()
        {
            return _modelo.ObtenerNumerosNomina();
        }

        public string ObtenerEstadoNomina(int idNomina)
        {
            return _modelo.ObtenerEstadoNomina(idNomina);
        }

    }
}
