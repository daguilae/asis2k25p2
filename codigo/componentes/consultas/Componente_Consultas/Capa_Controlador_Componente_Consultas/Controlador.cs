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


        // Carlo Andree Barquero Boche 0901-22-601
        // Ejecuta consulta sin filtro
        public DataTable fun_EjecutarConsulta(string stabla, string sorden)
        {
            return sentencias.fun_EjecutarConsulta(stabla, sorden);
        }

        // Jose Pablo Medina 0901-22-22592
        // Ejecuta consulta con filtro (busca en todas las columnas)
        public DataTable fun_EjecutarConsultaConFiltro(string stabla, string sfiltro, string sorden)
        {
            return sentencias.fun_EjecutarConsultaConFiltro(stabla, sfiltro, sorden);
        }
        // Jose Pablo Medina 0901-22-22592
        // Ejecuta la funcion del filtro construyendo el WHERE
        public DataTable fun_ConsultaFiltrada(string tabla, string campo, string operador, string valor, string sorden)
        {
            return sentencias.fun_EjecutarConsultaCondicional(tabla, campo, operador, valor, sorden);
        }


        // RICHARD ANTONY DE LEON 0901 - 22 - 10265
        public DataTable fun_ConsultaOrdenada(string tabla, bool asc)
        {
            return sentencias.fun_ConsultaOrdenada(tabla, asc);
        }



    }
}
