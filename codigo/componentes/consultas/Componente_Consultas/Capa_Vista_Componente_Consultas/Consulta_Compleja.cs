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

namespace Capa_Vista_Componente_Consultas
{
    public partial class Consulta_Compleja : Form
    {
        public Consulta_Compleja()
        {
            InitializeComponent();
        }

        private void Btn_consimple_Click(object sender, EventArgs e)
        {
            Frm_Consultas consultas = new Frm_Consultas();
            consultas.Show();
            this.Hide();
        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {
            // Volvemos a mostrar Form1
            Frm_Principal principal = new Frm_Principal();
            principal.Show();
            this.Close(); // cerramos Form2
        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_max_Click(object sender, EventArgs e)
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

        private void Lbl_Tabla_Click(object sender, EventArgs e)
        {

        }

        private void Consulta_Compleja_Load(object sender, EventArgs e)
        {

        }

        private void Dgv_Sql_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void Cbo_busqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Gpb_Orden_Enter(object sender, EventArgs e)
        {

        }

        private void Rdb_asc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gpb_Orden_Enter(object sender, EventArgs e)
        {

        }

        private void Rdb_desc_CheckedChanged(object sender, EventArgs e)
        {

        }

    
        private void Lst_Querys_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_EjecutarSQL_Click(object sender, EventArgs e)
        {

        }
    }
}
