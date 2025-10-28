using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Nominas
{
    public partial class EditarAnticipo : Form
    {
        public EditarAnticipo()
        {
            InitializeComponent();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Anticipos frm = new Anticipos();
            frm.Show();
            this.Hide();
        }
    }
}
