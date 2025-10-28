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
    public partial class CrearDepartamentos : Form
    {
        public CrearDepartamentos()
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
