using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Hoteleria
{
    public partial class Frm_Reservaciones : Form
    {
        public Frm_Reservaciones()
        {
            InitializeComponent();
        }

        private void Frm_Reservaciones_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Hoteleria nuevoFormulario = new Frm_Hoteleria();
            nuevoFormulario.Show();
            this.Hide();

        }

        private void gestionDeSalonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Salones nuevoFormulario = new Frm_Salones();
            nuevoFormulario.Show();
            this.Hide();
        }
    }
}
