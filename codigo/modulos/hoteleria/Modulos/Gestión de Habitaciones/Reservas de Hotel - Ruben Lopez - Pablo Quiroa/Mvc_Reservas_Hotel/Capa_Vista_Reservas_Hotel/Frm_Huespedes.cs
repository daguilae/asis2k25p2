using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Reservas_Hotel
{
    public partial class Frm_Huespedes : Form
    {
        private Timer timerBotones; // 🔹 temporizador para vigilar los botones

        public Frm_Huespedes()
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
                Nombre = "dgv_huesped"
            };

            string[] columnas =
            {
                "Tbl_Huesped",
                "Pk_Id_Huesped",
                "Cmp_Tipo_Documento",
                "Cmp_Numero_Documento",
                "Cmp_Nombre",
                "Cmp_Apellido",
               "Cmp_Email",
               "Cmp_Telefono",
               "Cmp_Pais",
               "Cmp_Viajar_Por_Trabajo",
               "Cmp_Nombre_Empresa"
            };

            string[] etiquetas =
            {
                "Código Huesped",
                "Tipo de documento",
                "Numero de documento",
                "Nombre",
                "Apellido",
                "Email",
                "Telefono",
                "Pais",
                "Viaje por trabajo",
                "Nombre de empresa"
            };

            navegador1.IPkId_Aplicacion = 303;
            navegador1.IPkId_Modulo = 4;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = etiquetas;
            navegador1.mostrarDatos();

            // ==============================
            // 🔓 Activar los botones al inicio
            // ==============================
            ActivarBotonesInternos(navegador1);

            // ==============================
            // 🔁 Crear un temporizador que re-activa botones cada 0.5 segundos
            // ==============================
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

    

