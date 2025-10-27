using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Modulo_Comercial
{
    public partial class Frm_Compras : Form
    {
        public Frm_Compras()
        {
            InitializeComponent();
        }

        // Bryan Ramirez 0901-21-8202 27/10/2025 
        // Función para abrir subformularios en el panel
        private void AbrirFormulario(Form formulario)
        {
            Pnl_Contenido.Controls.Clear();
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            Pnl_Contenido.Controls.Add(formulario);
            formulario.Show();
        }

        private void Btn_Orden_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frm_Orden_Compra());
        }

        private void Btn_FacturaProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frm_Factura_Proveedor());
        }

        private void Btn_Notas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frm_Nota_CreditoDebito());
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frm_Compras_Periodo());
        }

        private void Btn_Contabilidad_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frm_Envio_Contabilidad());
        }
    }
}
