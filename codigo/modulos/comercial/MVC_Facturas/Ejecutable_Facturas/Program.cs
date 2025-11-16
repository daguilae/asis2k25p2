using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Facturas;

namespace Ejecutable_Facturas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new Frm_Listado_Facturas());
        //    Application.Run(new Frm_Detalle_Factura());
            Application.Run(new Frm_Venta());
        }
    }
}
