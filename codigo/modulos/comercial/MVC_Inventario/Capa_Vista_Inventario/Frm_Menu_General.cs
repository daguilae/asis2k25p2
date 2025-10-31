using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Inventario
{
    public partial class Frm_Menu_General : Form
    {
        public Frm_Menu_General()
        {
            InitializeComponent();
        }

        // ==================== ESTE MDI ES PROVISIONAL ====================

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Inventario_Historico irInventario = new Frm_Inventario_Historico();
            irInventario.Show();
            this.Hide();
        }

        private void cxCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Nelson
        }

        private void cxPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Diego
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Raul
        }

        private void ventasFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Juan Carlos
        }
    }
}
