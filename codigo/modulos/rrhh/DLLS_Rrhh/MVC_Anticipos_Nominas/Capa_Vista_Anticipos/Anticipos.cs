using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



// CARLO ANDRE BARQUERO BOCHE 0901-22-601     29/10/2025
namespace Capa_Vista_Anticipos
{
    public partial class Anticipos : Form
    {
        public Anticipos()
        {
            InitializeComponent();
        }

        private void Btn_solicitar_Click(object sender, EventArgs e)
        {
            solicitaranticipo frmsoli = new solicitaranticipo();
            frmsoli.Show();
            this.Hide();
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            editaranticipos frmeditar = new editaranticipos();
            frmeditar.Show();
            this.Hide();
        }
    }
}
