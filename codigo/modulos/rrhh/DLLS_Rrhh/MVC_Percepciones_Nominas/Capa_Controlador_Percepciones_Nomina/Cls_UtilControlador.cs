/* 
 * Programador: Richard Anthony De León Milian
 * Carné: 0901-22-10245
 * Fecha de modificación: 8/11/2025
 * Archivo: Cls_UtilControlador.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Percepciones_Nomina;

namespace Capa_Controlador_Percepciones_Nomina
{
    public class Cls_UtilControlador
    {
        Cls_UtilModelo modelo = new Cls_UtilModelo();

        //Reiniciar contador si la tabla está vacía
        public void funReiniciarSiVacia(string tabla, string idColumna)
        {
            modelo.funResetAutoIncrementIfEmpty(tabla, idColumna);
        }

    }
}
