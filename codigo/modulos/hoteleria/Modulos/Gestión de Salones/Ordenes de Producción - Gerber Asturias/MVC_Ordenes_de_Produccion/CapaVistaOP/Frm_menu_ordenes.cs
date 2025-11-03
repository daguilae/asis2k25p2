using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaOP
{
    public partial class Frm_menu_ordenes : Form
    {
        public Frm_menu_ordenes()
        {
            InitializeComponent();
        }

        private void ss_Click(object sender, EventArgs e)
        {
            Frm_Ordenes_de_menu frm = new Frm_Ordenes_de_menu();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_mobiliario frm = new Frm_mobiliario();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Ordenes_de_Produccion frm = new Frm_Ordenes_de_Produccion();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Ordenes_mobiliario frm = new Frm_Ordenes_mobiliario();
            frm.Show();
        }
    }
}
