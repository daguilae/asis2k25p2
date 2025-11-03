using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorOP;

namespace CapaVistaOP
{
    public partial class Frm_mobiliario : Form
    {
        Cls_Controlador_OP controlador = new Cls_Controlador_OP();
        int idSeleccionado = 0;

        public Frm_mobiliario()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            dgvmobiliario.DataSource = controlador.MostrarMobiliario();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMobiliario.Text))
            {
                controlador.GuardarMobiliario(txtMobiliario.Text);
                CargarDatos();
                txtMobiliario.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un nombre de mobiliario.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado > 0)
            {
                controlador.ActualizarMobiliario(idSeleccionado, txtMobiliario.Text);
                CargarDatos();
                txtMobiliario.Clear();
                idSeleccionado = 0;
            }
            else
            {
                MessageBox.Show("Seleccione un registro para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado > 0)
            {
                controlador.BorrarMobiliario(idSeleccionado);
                CargarDatos();
                txtMobiliario.Clear();
                idSeleccionado = 0;
            }
            else
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
            }
        }

        private void dgvmobiliario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(dgvmobiliario.Rows[e.RowIndex].Cells["Pk_Id_Mobiliario"].Value);
                txtMobiliario.Text = dgvmobiliario.Rows[e.RowIndex].Cells["Cmp_Mobiliario"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
