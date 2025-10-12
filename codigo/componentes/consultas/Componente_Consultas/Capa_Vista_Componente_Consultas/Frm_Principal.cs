using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Componente_Consultas
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_ConsultaSimple_Click(object sender, EventArgs e)
        {
            //Consulta simple
            Frm_Consultas consultas = new Frm_Consultas();
            consultas.Show();
            this.Hide();
        }

        private void btn_ConsultaCompleja_Click(object sender, EventArgs e)
        {
            Consulta_Compleja consulta_compleja = new Consulta_Compleja();
            consulta_compleja.Show();
            this.Hide();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
