using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Usando capa controlador 
using Capa_Controlador_Componente_Consultas;
// COMO ESTAn
namespace Capa_Vista_Componente_Consultas
{
    public partial class Consulta_Compleja : Form
    {
        public Consulta_Compleja()
        {
            InitializeComponent();
        }

        private void btn_consimple_Click(object sender, EventArgs e)
        {
            Frm_Consultas consultas = new Frm_Consultas();
            consultas.Show();
            this.Hide();
        }
    }
}
