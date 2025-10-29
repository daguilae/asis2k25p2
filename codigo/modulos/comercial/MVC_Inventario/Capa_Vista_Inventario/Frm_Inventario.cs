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
    public partial class Frm_Inventario : Form
    {
        public Frm_Inventario()
        {
            InitializeComponent();
        }

        // ==================== Stevens Cambranes 26/10/25 ====================
        private void Btn_Cierre_Inventario_Click(object sender, EventArgs e)
        {
            // Cuando se cierre inventario ir a Historico para ver el nuevo inventario cerrado
            Frm_Inventario_Historico CierreInventario = new Frm_Inventario_Historico();
            CierreInventario.Show();
            this.Hide();
        }
    }
}
