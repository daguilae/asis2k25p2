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
            Dgv_Mobiliario.DataSource = controlador.MostrarMobiliario();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Mobiliario.Text))
            {
                MessageBox.Show("Ingrese un nombre de mobiliario.");
                return;
            }

            controlador.GuardarMobiliario(Txt_Mobiliario.Text.Trim());
            CargarDatos();
            Txt_Mobiliario.Clear();
            MessageBox.Show("Mobiliario guardado con éxito.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un registro para editar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_Mobiliario.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            controlador.ActualizarMobiliario(idSeleccionado, Txt_Mobiliario.Text.Trim());
            CargarDatos();
            Txt_Mobiliario.Clear();
            idSeleccionado = 0;
            MessageBox.Show("Mobiliario actualizado correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este mobiliario?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                controlador.BorrarMobiliario(idSeleccionado);
                CargarDatos();
                Txt_Mobiliario.Clear();
                idSeleccionado = 0;
                MessageBox.Show("Mobiliario eliminado con éxito.");
            }
        }

        private void dgvmobiliario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(Dgv_Mobiliario.Rows[e.RowIndex].Cells["Pk_Id_Mobiliario"].Value);
                Txt_Mobiliario.Text = Dgv_Mobiliario.Rows[e.RowIndex].Cells["Cmp_Mobiliario"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Mobiliario frm = new Frm_Reporte_Mobiliario();
            frm.Show();
        }
    }
}
