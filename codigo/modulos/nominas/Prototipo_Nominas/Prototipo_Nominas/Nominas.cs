using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Nominas;

// CARLO ANDREE BARQUERO BOCHE 0901-22-601 27/10/2025
// DIEGO ANDRE MONTERROSO  RABARIQUE 0901-22-1369 27/10/2025


namespace Prototipo_Nominas
{
    public partial class Nominas : Form
    {
        public Nominas()
        {
            InitializeComponent();

        }

        private void Btn_Anticipos_Click(object sender, EventArgs e)
        {
            Anticipos frmAnticipo = new Anticipos();
            frmAnticipo.Show();
        }
    }
}
