using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Descomentar para que funciones el MDI provisional
/*using Capa_Vista_Facturas;
using Capa_Vista_CxP;
using Capa_Vista_CxC;
using Capa_Vista_Compras;*/

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
        }

        private void cxCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Nelson recibos
            /*Frm_Recibos irCxP = new Frm_Recibos();
            irCxP.Show();*/

        }

        private void cxPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Diego Frm_CxP_Gestiòn
            /*Frm_CxP_Gestiòn irCxC = new Frm_CxP_Gestiòn();
            irCxC.Show();*/
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Raul Compras
            /*Frm_Compras irCompras = new Frm_Compras();
            irCompras.Show();*/
        }

        private void ventasFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Juan Carlos
            /*Frm_Venta irVenta = new Frm_Venta();
            irVenta.Show();*/
        }
    }
}