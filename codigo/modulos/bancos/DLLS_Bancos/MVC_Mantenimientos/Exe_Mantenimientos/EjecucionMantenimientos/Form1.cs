using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Mantenimientos;

namespace EjecucionMantenimientos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_M_Bancos M = new Frm_M_Bancos();
            M.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_M_Monedas M = new Frm_M_Monedas();
            M.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_M_CuentasBancarias M = new Frm_M_CuentasBancarias();
            M.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_M_TipoPagos M = new Frm_M_TipoPagos();
            M.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_M_Transacciones M = new Frm_M_Transacciones();
            M.ShowDialog();
        }
    }
}
