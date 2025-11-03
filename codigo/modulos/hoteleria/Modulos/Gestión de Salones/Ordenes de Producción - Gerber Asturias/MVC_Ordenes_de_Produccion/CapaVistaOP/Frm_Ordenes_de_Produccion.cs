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
    public partial class Frm_Ordenes_de_Produccion : Form
    {

        Cls_Controlador_OP controlador = new Cls_Controlador_OP();

        public Frm_Ordenes_de_Produccion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            controlador.GuardarOP(dtpSolicitud.Value, dtpRegistro.Value);
            MessageBox.Show("Orden de producción guardada correctamente");
            CargarTabla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtIdOP.Text == "")
            {
                MessageBox.Show("Seleccione un registro para editar");
                return;
            }

            controlador.ActualizarOP(Convert.ToInt32(txtIdOP.Text), dtpSolicitud.Value, dtpRegistro.Value);
            MessageBox.Show("Orden de producción actualizada correctamente");
            CargarTabla();
        }

        public void CargarTabla()
        {
            dgvOP.DataSource = controlador.MostrarOP();
        }

        private void dgvOP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIdOP.Text = dgvOP.Rows[e.RowIndex].Cells[0].Value.ToString();
                dtpSolicitud.Value = Convert.ToDateTime(dgvOP.Rows[e.RowIndex].Cells[1].Value);
                dtpRegistro.Value = Convert.ToDateTime(dgvOP.Rows[e.RowIndex].Cells[2].Value);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (txtIdOP.Text == "")
            {
                MessageBox.Show("Seleccione un registro para eliminar");
                return;
            }

            controlador.BorrarOP(Convert.ToInt32(txtIdOP.Text));
            MessageBox.Show("Orden de producción eliminada correctamente");
            CargarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
