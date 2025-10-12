using System;
using System.Data;
using Capa_Modelo_Componente_Consultas;
// Carlo Andree Barquero Boche 0901-22-601

namespace Capa_Controlador_Componente_Consultas
{
    public class Controlador
    {
        // Instancia de la clase Sentencias
        Sentencias sentencias = new Sentencias();

        // Obtiene todas las tablas
        public DataTable fun_ObtenerTablas()
        {
            return sentencias.fun_ObtenerTablas();
        }

        // Jose Pablo Medina 0901-22-22592

        // Ejecuta consulta sin filtro
        public DataTable fun_EjecutarConsulta(string stabla, string sorden)
        {
            return sentencias.fun_EjecutarConsulta(stabla, sorden);
        }

        // Jose Pablo Medina 0901-22-22592
        // ✅ Ejecuta consulta con filtro (busca en todas las columnas)
        public DataTable fun_EjecutarConsultaConFiltro(string stabla, string sfiltro, string sorden)
        {
            return sentencias.fun_EjecutarConsultaConFiltro(stabla, sfiltro, sorden);
        }
    }
}
