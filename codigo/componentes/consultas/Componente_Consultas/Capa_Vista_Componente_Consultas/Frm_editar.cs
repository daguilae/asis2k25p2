using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Componente_Consultas
{
    public partial class Frm_editar : Form
    {
        public Frm_editar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void creaciònToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Creacion creacion = new Frm_Creacion();
            creacion.Show();
            this.Hide();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Consultas Consultas = new Frm_Consultas();
            Consultas.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Volvemos a mostrar Form1
            Frm_Principal principal = new Frm_Principal();
            principal.Show();
            this.Close(); // cerramos Form2
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
