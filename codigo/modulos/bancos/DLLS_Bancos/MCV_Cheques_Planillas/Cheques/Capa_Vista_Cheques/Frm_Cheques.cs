using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Controlador_Cheques;
using System.Data;


namespace Capa_Vista_Cheques
{
    public partial class Frm_Cheques : Form
    {
        Cls_Controlador_Cheques cn = new Cls_Controlador_Cheques();
        string tabla = "";
        public Frm_Cheques()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txt_Banco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
