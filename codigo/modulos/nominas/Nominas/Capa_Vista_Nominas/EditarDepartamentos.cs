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
    public partial class EditarDepartamentos : Form
    {
        public EditarDepartamentos()
        {
            InitializeComponent();
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            Departamentos frm = new Departamentos();
            frm.Show();
            this.Hide();
        }
    }
}
