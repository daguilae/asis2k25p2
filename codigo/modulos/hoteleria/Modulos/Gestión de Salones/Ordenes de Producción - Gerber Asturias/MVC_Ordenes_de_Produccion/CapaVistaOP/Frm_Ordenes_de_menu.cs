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
            Dgv_Detalle_Orden_menu.CellClick += dgvDetalleOrdenes_CellContentClick;

            // Eventos botones
            Btn_Guardar.Click += btnGuardar_Click;
            Btn_Editar.Click += btnEditar_Click;
            Btn_Eliminar.Click += btnEliminar_Click;

        }
        private void CargarComboOrdenesProduccion()
        {
            Cbo_Orden_Produccion.DataSource = controlador.LlenarComboOrdenesProduccion();
            Cbo_Orden_Produccion.DisplayMember = "Pk_Id_Orden_Produccion";
            Cbo_Orden_Produccion.ValueMember = "Pk_Id_Orden_Produccion";
            Cbo_Orden_Produccion.SelectedIndex = -1;
        }

        private void CargarComboMenu()
        {
            Cbo_Menu.DataSource = controlador.LlenarComboMenu();
            Cbo_Menu.DisplayMember = "Cmp_Nombre_Platillo";
            Cbo_Menu.ValueMember = "Pk_Id_Menu";
            Cbo_Menu.SelectedIndex = -1;
        }

        private void Frm_Ordenes_de_produccion_Load(object sender, EventArgs e)
        {

        }

        private void CargarDetalleOrdenesMenu()
        {
            Dgv_Detalle_Orden_menu.DataSource = controlador.MostrarDetalleOrdenMenu();
        }




        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            controlador.GuardarDetalleOrdenMenu(
                Convert.ToInt32(Cbo_Orden_Produccion.SelectedValue),
                Convert.ToInt32(Cbo_Menu.SelectedValue),
                (int)Nud_Cantidad.Value
            );

            CargarDetalleOrdenesMenu();
            LimpiarControles();
            MessageBox.Show("Registro guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idDetalleSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un registro válido para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            controlador.BorrarDetalleOrdenMenu(idDetalleSeleccionado);
            CargarDetalleOrdenesMenu();
            LimpiarControles();
            MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idDetalleSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione un registro válido para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos()) return;

            controlador.ActualizarDetalleOrdenMenu(
                idDetalleSeleccionado,
                Convert.ToInt32(Cbo_Orden_Produccion.SelectedValue),
                Convert.ToInt32(Cbo_Menu.SelectedValue),
                (int)Nud_Cantidad.Value
            );

            CargarDetalleOrdenesMenu();
            LimpiarControles();
            MessageBox.Show("Registro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvDetalleOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idDetalleSeleccionado = Convert.ToInt32(Dgv_Detalle_Orden_menu.Rows[e.RowIndex].Cells["Pk_Id_Detalle_Orden"].Value);
                Cbo_Orden_Produccion.SelectedValue = Convert.ToInt32(Dgv_Detalle_Orden_menu.Rows[e.RowIndex].Cells["Fk_Id_Orden_Produccion"].Value);
                Cbo_Menu.SelectedValue = Convert.ToInt32(Dgv_Detalle_Orden_menu.Rows[e.RowIndex].Cells["Fk_Id_Menu"].Value);
                Nud_Cantidad.Value = Convert.ToInt32(Dgv_Detalle_Orden_menu.Rows[e.RowIndex].Cells["Cmp_Cantidad_Platillos"].Value);
            }

        }
        private void LimpiarControles()
        {
            idDetalleSeleccionado = 0;
            Cbo_Orden_Produccion.SelectedIndex = -1;
            Cbo_Menu.SelectedIndex = -1;
            Nud_Cantidad.Value = 1;
        }

        private void cbOrdenesProduccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarCampos()
        {
            // Validar selección de Orden
            if (Cbo_Orden_Produccion.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una Orden de Producción.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar selección de Menú
            if (Cbo_Menu.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un Menú.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar cantidad
            if (Nud_Cantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar duplicados en la misma orden
            foreach (DataGridViewRow row in Dgv_Detalle_Orden_menu.Rows)
            {
                if (row.Cells["Fk_Id_Orden_Produccion"].Value != null && row.Cells["Fk_Id_Menu"].Value != null)
                {
                    int orden = Convert.ToInt32(Cbo_Orden_Produccion.SelectedValue);
                    int menu = Convert.ToInt32(Cbo_Menu.SelectedValue);

                    if (orden == Convert.ToInt32(row.Cells["Fk_Id_Orden_Produccion"].Value) &&
                        menu == Convert.ToInt32(row.Cells["Fk_Id_Menu"].Value) &&
                        idDetalleSeleccionado != Convert.ToInt32(row.Cells["Pk_Id_Detalle_Orden"].Value))
                    {
                        MessageBox.Show("Este Menú ya está registrado para la Orden seleccionada.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            return true;
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Orden_Menu frm = new Frm_Reporte_Orden_Menu();
            frm.Show();
        }
    }
}
