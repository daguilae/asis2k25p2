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
    public partial class Frm_Inventario_Historico : Form
    {
        public Frm_Inventario_Historico()
        {
            InitializeComponent();
        }

        // ==================== Stevens Cambranes 26/10/25 ====================
        private void Btn_Nuevo_Inventario_Click(object sender, EventArgs e)
        {
            // Ir a Frm_Inventario y que aparezca campos vacios para agregar productos
            Frm_Inventario NuevoInventario = new Frm_Inventario();
            NuevoInventario.Show();
            this.Hide();
        }

        private void Btn_Imprimir_PDF_Click(object sender, EventArgs e)
        {
            // Llamar la funcion Convertir el DGV a PDF

            // Mensaje para el usuario
            MessageBox.Show("Quiere generar el PDF de este Historico?");
        }
    }
}
