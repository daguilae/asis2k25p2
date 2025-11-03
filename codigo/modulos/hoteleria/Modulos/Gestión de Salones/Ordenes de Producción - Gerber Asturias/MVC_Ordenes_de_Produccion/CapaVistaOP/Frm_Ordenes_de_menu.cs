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
    public partial class Frm_Ordenes_de_menu : Form
    {
        Cls_Controlador_OP controlador = new Cls_Controlador_OP();
        private int idDetalleSeleccionado = 0;

        public Frm_Ordenes_de_menu()
        {
            InitializeComponent();
            Load += Frm_Ordenes_de_menu_Load;
        }

        private void Frm_Ordenes_de_menu_Load(object sender, EventArgs e)
        {
            CargarComboOrdenesProduccion();
            CargarComboMenu();
            CargarDetalleOrdenesMenu();

            // Eventos del DataGridView
            dgvDetalleOrdenmenu.CellClick += dgvDetalleOrdenes_CellContentClick;

            // Eventos botones
            btnGuardar.Click += btnGuardar_Click;
            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click;

        }
        private void CargarComboOrdenesProduccion()
        {
            cmbOrdenProduccion.DataSource = controlador.LlenarComboOrdenesProduccion();
            cmbOrdenProduccion.DisplayMember = "Pk_Id_Orden_Produccion";
            cmbOrdenProduccion.ValueMember = "Pk_Id_Orden_Produccion";
            cmbOrdenProduccion.SelectedIndex = -1;
        }

        private void CargarComboMenu()
        {
            cmbMenu.DataSource = controlador.LlenarComboMenu();
            cmbMenu.DisplayMember = "Cmp_Nombre_Platillo";
            cmbMenu.ValueMember = "Pk_Id_Menu";
            cmbMenu.SelectedIndex = -1;
        }

        private void Frm_Ordenes_de_produccion_Load(object sender, EventArgs e)
        {

        }

        private void CargarDetalleOrdenesMenu()
        {
            dgvDetalleOrdenmenu.DataSource = controlador.MostrarDetalleOrdenMenu();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbOrdenProduccion.SelectedIndex >= 0 && cmbMenu.SelectedIndex >= 0)
            {
                controlador.GuardarDetalleOrdenMenu(
                    Convert.ToInt32(cmbOrdenProduccion.SelectedValue),
                    Convert.ToInt32(cmbMenu.SelectedValue),
                    (int)numCantidad.Value
                );
                CargarDetalleOrdenesMenu();
                LimpiarControles();
            }
            else
            {
                MessageBox.Show("Seleccione una Orden y un Menú.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idDetalleSeleccionado > 0)
            {
                controlador.BorrarDetalleOrdenMenu(idDetalleSeleccionado);
                CargarDetalleOrdenesMenu();
                LimpiarControles();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idDetalleSeleccionado > 0)
            {
                controlador.ActualizarDetalleOrdenMenu(
                    idDetalleSeleccionado,
                    Convert.ToInt32(cmbOrdenProduccion.SelectedValue),
                    Convert.ToInt32(cmbMenu.SelectedValue),
                    (int)numCantidad.Value
                );
                CargarDetalleOrdenesMenu();
                LimpiarControles();
            }
        }

        private void dgvDetalleOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idDetalleSeleccionado = Convert.ToInt32(dgvDetalleOrdenmenu.Rows[e.RowIndex].Cells["Pk_Id_Detalle_Orden"].Value);
                cmbOrdenProduccion.SelectedValue = Convert.ToInt32(dgvDetalleOrdenmenu.Rows[e.RowIndex].Cells["Fk_Id_Orden_Produccion"].Value);
                cmbMenu.SelectedValue = Convert.ToInt32(dgvDetalleOrdenmenu.Rows[e.RowIndex].Cells["Fk_Id_Menu"].Value);
                numCantidad.Value = Convert.ToInt32(dgvDetalleOrdenmenu.Rows[e.RowIndex].Cells["Cmp_Cantidad_Platillos"].Value);
            }

        }
        private void LimpiarControles()
        {
            idDetalleSeleccionado = 0;
            cmbOrdenProduccion.SelectedIndex = -1;
            cmbMenu.SelectedIndex = -1;
            numCantidad.Value = 1;
        }

        private void cbOrdenesProduccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
