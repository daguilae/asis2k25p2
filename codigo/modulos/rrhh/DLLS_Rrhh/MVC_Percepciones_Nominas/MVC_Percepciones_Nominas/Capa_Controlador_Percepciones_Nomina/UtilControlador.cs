using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Percepciones_Nomina;

namespace Capa_Controlador_Percepciones_Nomina
{
    public class UtilControlador
    {
        UtilModelo modelo = new UtilModelo();

        public void ReiniciarSiVacia(string tabla, string idColumna)
        {
            modelo.ResetAutoIncrementIfEmpty(tabla, idColumna);
        }

        public void TruncarTabla(string tabla)
        {
            modelo.TruncarTabla(tabla);
        }
    }
}
