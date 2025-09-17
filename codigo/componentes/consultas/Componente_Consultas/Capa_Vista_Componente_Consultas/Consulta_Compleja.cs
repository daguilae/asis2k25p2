using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Usando capa controlador 
using Capa_Controlador_Componente_Consultas;

namespace Capa_Vista_Componente_Consultas
{
    public partial class Consulta_Compleja : Form
    {
        public Consulta_Compleja()
        {
            InitializeComponent();
        }

        private void btn_consimple_Click(object sender, EventArgs e)
        {
            Frm_Consultas consultas = new Frm_Consultas();
            consultas.Show();
            this.Hide();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            // Volvemos a mostrar Form1
            Frm_Principal principal = new Frm_Principal();
            principal.Show();
            this.Close(); // cerramos Form2
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized; // Si está normal, se maximiza
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal; // Si ya está maximizada, se restaura
            }
        }
    }
}
