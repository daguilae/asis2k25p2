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
    public partial class Departamentos : Form
    {
        public Departamentos()
        {
            InitializeComponent();
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            CrearDepartamentos frmcrear = new CrearDepartamentos();
            frmcrear.Show();
            this.Hide();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            EditarDepartamentos frmeditar = new EditarDepartamentos();
            frmeditar.Show();
            this.Hide();
        }
    }
}
