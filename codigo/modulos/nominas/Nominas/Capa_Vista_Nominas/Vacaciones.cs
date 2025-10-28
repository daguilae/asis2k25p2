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
    public partial class Vacaciones : Form
    {
        public Vacaciones()
        {
            InitializeComponent();
        }

        private void Btn_Soli_Click(object sender, EventArgs e)
        {
            SolicitarVacaciones frmsoli = new SolicitarVacaciones();
            frmsoli.Show();
            this.Hide();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            EditarVacaciones frmeditar = new EditarVacaciones();
            frmeditar.Show();
            this.Hide();
        }
    }
}
