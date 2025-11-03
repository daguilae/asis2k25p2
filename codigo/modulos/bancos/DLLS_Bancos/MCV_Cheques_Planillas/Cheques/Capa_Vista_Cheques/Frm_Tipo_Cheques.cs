using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Cheques
{
    public partial class Frm_Tipo_Cheques : Form
    {
        public Frm_Tipo_Cheques()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Frm_Cheques formularioCheques = new Frm_Cheques();
            formularioCheques.Show();  // Abre el formulario de cheques

        }

        private void bnt_Proveedores_Click(object sender, EventArgs e)
        {
            Frm_Proveedores formularioCheques = new Frm_Proveedores();
            formularioCheques.Show();  // Abre el formulario de cheques
        }
    }
}
