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
    public partial class Frm_Consultas : Form
    {
        public Frm_Consultas()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
        }

        private void creaciònToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //En navegador movemos la vista del formulario consultas a creación
            Frm_Creacion creacion = new Frm_Creacion();
            creacion.Show();
            this.Hide();
        }

        private void Frm_Consultas_Load(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Volvemos a mostrar Form1
            Frm_Principal principal = new Frm_Principal();
            principal.Show();
            this.Close(); // cerramos Form2
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Volvemos a mostrar Form1
            Consulta_Compleja compleja = new Consulta_Compleja();
            compleja.Show();
            this.Close(); // cerramos Form2
        }

        private void btn_min_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized; // Si está normal, se maximiza
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal; // Si ya está maximizada, se restaura
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gpb_Listado_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_Query_Click(object sender, EventArgs e)
        {

        }

        private void cbo_Query_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
