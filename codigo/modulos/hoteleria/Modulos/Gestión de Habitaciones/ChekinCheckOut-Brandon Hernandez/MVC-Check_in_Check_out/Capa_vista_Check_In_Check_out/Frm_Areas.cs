using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capa_vista_Check_In_Check_out
{
    public partial class Frm_Areas : Form
    {
        private Timer timerBotones; // 🔹 temporizador para vigilar los botones

        public Frm_Areas()
        {
            InitializeComponent();

            // Configurar el navegador
            var config = new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
            {
                Ancho = 1100,
                Alto = 200,
                PosX = 10,
                PosY = 300,
                ColorFondo = Color.AliceBlue,
                TipoScrollBars = ScrollBars.Both,
                Nombre = "dgv_areas"
            };

            string[] columnas =
            {
                "Tbl_Area",
                "Pk_Id_Area",
                "Cmp_Nombre_Area",
                "Cmp_Descripcion",
                "Cmp_Tipo_Movimiento",
                "Cmp_Monto",
               "Cmp_Fecha_Movimiento",
            };

            string[] etiquetas =
            {
                "Código Area",
                "Nombre del Aea",
                "Descripción del Area",
                "Tipo de Moimiento",
                "Monto",
                "Fecha del Movimiento "
            };

            navegador1.IPkId_Aplicacion = 303;
            navegador1.IPkId_Modulo = 4;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = etiquetas;
            navegador1.mostrarDatos();

        
            // Activar los botones al inicio
            
            ActivarBotonesInternos(navegador1);

            
        
            timerBotones = new Timer();
            timerBotones.Interval = 500; // medio segundo
            timerBotones.Tick += (s, e) => ActivarBotonesInternos(navegador1);
            timerBotones.Start();

        }

        // ======================================================
        // Función recursiva para habilitar botones dentro del navegador
        // ======================================================
        public void ActivarBotonesInternos(Control contenedor)
        {
            foreach (Control c in contenedor.Controls)
            {
                if (c is Button btn)
                    btn.Enabled = true;
                else if (c.HasChildren)
                    ActivarBotonesInternos(c);
            }
        }
    }
}
    

