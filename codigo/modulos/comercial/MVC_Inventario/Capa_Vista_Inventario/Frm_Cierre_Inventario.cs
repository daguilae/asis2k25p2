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
    public partial class Frm_Cierre_Inventario : Form
    {
        public Frm_Cierre_Inventario()
        {
            InitializeComponent();
        }

        private void Btn_Cierre_Inventario_Click(object sender, EventArgs e)
        {
            Frm_Inventario_Historico irHistorico = new Frm_Inventario_Historico();
            irHistorico.Show();
            this.Hide();
        }

        private void Btn_Cancelar_Cierre_Click(object sender, EventArgs e)
        {
            Frm_Inventario volverInventario = new Frm_Inventario();
            volverInventario.Show();
            this.Hide();
        }
    }
}
