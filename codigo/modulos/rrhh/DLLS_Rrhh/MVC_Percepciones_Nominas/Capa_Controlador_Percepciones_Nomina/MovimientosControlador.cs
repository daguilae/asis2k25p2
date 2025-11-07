using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_Percepciones_Nomina;
namespace Capa_Controlador_Percepciones_Nomina
{
    // 📂 Capa_Controlador_Percepciones_Nomina / MovimientosControlador.cs
    public class MovimientosControlador
    {
        MovimientosModelo modelo = new MovimientosModelo();

        // Capa_Controlador_Percepciones_Nomina / MovimientosControlador.cs
        public DataTable MostrarMovimientosPorNomina(int idNomina, bool asc = true)
        {
            return modelo.ObtenerMovimientosPorNomina(idNomina, asc);
        }

    }


}
