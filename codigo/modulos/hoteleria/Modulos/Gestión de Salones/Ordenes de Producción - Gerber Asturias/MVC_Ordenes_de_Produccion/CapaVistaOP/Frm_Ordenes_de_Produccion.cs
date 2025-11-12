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
            CargarTabla();
           


        }

        private void Dgv_OP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (Dtp_Fecha_Registro.Value < Dtp_Fecha_Solicitud.Value)
            {
                MessageBox.Show("La Fecha de Registro no puede ser menor que la Fecha de Solicitud.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            controlador.GuardarOP(Dtp_Fecha_Solicitud.Value, Dtp_Fecha_Registro.Value);
            MessageBox.Show("Orden de producción guardada correctamente");
            CargarTabla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Txt_Id_OP.Text == "")
            {
                MessageBox.Show("Seleccione un registro para editar");
                return;
            }

            // Validación fechas
            if (Dtp_Fecha_Registro.Value < Dtp_Fecha_Solicitud.Value)
            {
                MessageBox.Show("La Fecha de Registro no puede ser menor que la Fecha de Solicitud.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            controlador.ActualizarOP(Convert.ToInt32(Txt_Id_OP.Text), Dtp_Fecha_Solicitud.Value, Dtp_Fecha_Registro.Value);
            MessageBox.Show("Orden de producción actualizada correctamente");
            CargarTabla();
        }

        public void CargarTabla()
        {
            Dgv_OP.DataSource = controlador.MostrarOP();
        }

        private void dgvOP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Txt_Id_OP.Text = Dgv_OP.Rows[e.RowIndex].Cells[0].Value.ToString();
                Dtp_Fecha_Solicitud.Value = Convert.ToDateTime(Dgv_OP.Rows[e.RowIndex].Cells[1].Value);
                Dtp_Fecha_Registro.Value = Convert.ToDateTime(Dgv_OP.Rows[e.RowIndex].Cells[2].Value);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Id_OP.Text))
            {
                MessageBox.Show("Seleccione un registro para eliminar");
                return;
            }

            int idOrden = Convert.ToInt32(Txt_Id_OP.Text);

            // Validación: revisar si la orden tiene detalles en otras tablas
            if (controlador.TieneRelaciones(idOrden))
            {
                MessageBox.Show("No se puede eliminar esta Orden de Producción porque tiene registros relacionados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            controlador.BorrarOP(idOrden);
            MessageBox.Show("Orden de producción eliminada correctamente");
            CargarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Ordenes_Produccion frm = new Frm_Reporte_Ordenes_Produccion();
            frm.Show();
        }
    }
}
