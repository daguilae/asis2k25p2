using System;
using System.Windows.Forms;

namespace Exe_Percepciones
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Habilita visual styles
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Ejecuta el formulario principal
            Application.Run(new FrmPrincipal());
        }
    }
}
