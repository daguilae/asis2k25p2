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
    public partial class Frm_Ordenes_mobiliario : Form
    {
        Cls_Controlador_OP controlador = new Cls_Controlador_OP();
        public Frm_Ordenes_mobiliario()
        {
            InitializeComponent();
        }

        private void Frm_Ordenes_mobiliario_Load(object sender, EventArgs e)
        {
            // Cargar combos
            cmbOrdenProduccion.DataSource = controlador.LlenarComboOrdenesProduccion();
            cmbOrdenProduccion.DisplayMember = "Pk_Id_Orden_Produccion";
            cmbOrdenProduccion.ValueMember = "Pk_Id_Orden_Produccion";

            cmbMobiliario.DataSource = controlador.LlenarComboMobiliario();
            cmbMobiliario.DisplayMember = "Cmp_Mobiliario";
            cmbMobiliario.ValueMember = "Pk_Id_Mobiliario";

            // Cargar DataGrid
            dgvDetalleOrdenmobiliario.DataSource = controlador.MostrarDetalleOrdenMobiliario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int idOrden = Convert.ToInt32(cmbOrdenProduccion.SelectedValue);
                int idMobiliario = Convert.ToInt32(cmbMobiliario.SelectedValue);
                int cantidad = (int)numCantidad.Value;

                controlador.GuardarDetalleOrdenMobiliario(idOrden, idMobiliario, cantidad);
                dgvDetalleOrdenmobiliario.DataSource = controlador.MostrarDetalleOrdenMobiliario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idDetalle = Convert.ToInt32(dgvDetalleOrdenmobiliario.CurrentRow.Cells["Pk_Id_Detalle_Orden_Mobiliario"].Value);
            controlador.BorrarDetalleOrdenMobiliario(idDetalle);
            dgvDetalleOrdenmobiliario.DataSource = controlador.MostrarDetalleOrdenMobiliario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idDetalle = Convert.ToInt32(dgvDetalleOrdenmobiliario.CurrentRow.Cells["Pk_Id_Detalle_Orden_Mobiliario"].Value);
            int idOrden = Convert.ToInt32(cmbOrdenProduccion.SelectedValue);
            int idMobiliario = Convert.ToInt32(cmbMobiliario.SelectedValue);
            int cantidad = (int)numCantidad.Value;

            controlador.ActualizarDetalleOrdenMobiliario(idDetalle, idOrden, idMobiliario, cantidad);
            dgvDetalleOrdenmobiliario.DataSource = controlador.MostrarDetalleOrdenMobiliario();
        }

        private void dgvDetalleOrdenmobiliario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    cmbOrdenProduccion.SelectedValue = dgvDetalleOrdenmobiliario.Rows[e.RowIndex].Cells["Fk_Id_Orden_Produccion"].Value;
                    cmbMobiliario.SelectedValue = dgvDetalleOrdenmobiliario.Rows[e.RowIndex].Cells["Fk_Id_Mobiliario"].Value;
                    numCantidad.Value = Convert.ToDecimal(dgvDetalleOrdenmobiliario.Rows[e.RowIndex].Cells["Cmp_Cantidad_Mobiliario"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar fila: " + ex.Message);
            }
        }
    }
}
