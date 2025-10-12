using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//COmentario push PM 

namespace Capa_Vista_Componente_Consultas
{
    public partial class Frm_editar : Form
    {
        public Frm_editar()
        {
            InitializeComponent();
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

    }
}
