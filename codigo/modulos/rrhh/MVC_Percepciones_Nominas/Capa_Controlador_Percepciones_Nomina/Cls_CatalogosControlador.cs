/* 
 * Programador: Richard Anthony De León Milian
 * Carné: 0901-22-10245
 * Fecha de modificación: 8/11/2025
 * Archivo: Cls_CatalogosControlador.cs
 */

using System.Data;
using Capa_Modelo_Percepciones_Nomina;

namespace Capa_Controlador_Percepciones_Nomina
{
    public class Cls_CatalogosControlador
    {
        // Instancia del modelo para acceder a consultas de catálogos
        public readonly Cls_CatalogosModelo _modelo = new Cls_CatalogosModelo();

        // Retorna lista de conceptos de nómina (percepciones o deducciones)
        public DataTable funListarConceptosNomina()
        {
            return _modelo.funObtenerConceptosNomina();
        }

        // Retorna listado de empleados para combobox
        public DataTable funListarEmpleados()
        {
            return _modelo.funObtenerEmpleados();
        }

        // Retorna listado de números de nómina existentes
        public DataTable funListarNumerosNomina()
        {
            return _modelo.funObtenerNumerosNomina();
        }

        // Obtiene el estado actual de una nómina específica
        public string funObtenerEstadoNomina(int idNomina)
        {
            return _modelo.funObtenerEstadoNomina(idNomina);
        }
    }
}
