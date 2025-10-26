using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Modulo_Comercial.Inventario
{
    public partial class Frm_Resumen_Inventario : Form
    {
        public Frm_Resumen_Inventario()
        {
            InitializeComponent();
        }

        private void Btn_Nuevo_Inventario_Click(object sender, EventArgs e)
        {
            // Ir a Frm_Inventario
            Frm_Inventario NuevoInventario = new Frm_Inventario();
            NuevoInventario.Show();
        }
    }
}
