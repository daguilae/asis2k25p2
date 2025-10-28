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
    public partial class Anticipos : Form
    {
        public Anticipos()
        {
            InitializeComponent();
        }

        private void Btn_solicitar_Click(object sender, EventArgs e)
        {
            Frm_solicitar frmsolicitar = new Frm_solicitar();
            frmsolicitar.Show();
            this.Hide();
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            EditarAnticipo frm = new EditarAnticipo();
            frm.Show();
            this.Hide();
        }
    }
}
