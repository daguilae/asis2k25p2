using System;
using System.Data;
using System.Windows.Forms;
using CapaControladorOP;

namespace CapaVistaOP
{
    public partial class Frm_Ordenes_mobiliario : Form
    {
        private Cls_Controlador_OP controlador = new Cls_Controlador_OP();
        private int idDetalleSeleccionado = 0;
        private bool _cargando = false; // Flag para evitar validaciones prematuras

        public Frm_Ordenes_mobiliario()
        {
            InitializeComponent();
            Load += Frm_Ordenes_mobiliario_Load;
            Btn_Guardar.Click += Btn_Guardar_Click;
            Btn_Editar.Click += Btn_Editar_Click;
            Btn_Eliminar.Click += Btn_Eliminar_Click;
            Dgv_Ordenes_Mobiliario.CellClick += Dgv_Ordenes_Mobiliario_CellClick;
        }

        private void Frm_Ordenes_mobiliario_Load(object sender, EventArgs e)
        {
            _cargando = true;
            CargarCombos();
            CargarTabla();
            _cargando = false;
        }

        private void CargarCombos()
        {
            // Orden de Producción
            Cbo_Orden_Produccion.DataSource = controlador.LlenarComboOrdenesProduccion();
            Cbo_Orden_Produccion.DisplayMember = "Pk_Id_Orden_Produccion";
            Cbo_Orden_Produccion.ValueMember = "Pk_Id_Orden_Produccion";
            Cbo_Orden_Produccion.SelectedIndex = -1;

            // Mobiliario
            Cbo_Mobiliario.DataSource = controlador.LlenarComboMobiliario();
            Cbo_Mobiliario.DisplayMember = "Cmp_Mobiliario";
            Cbo_Mobiliario.ValueMember = "Pk_Id_Mobiliario";
            Cbo_Mobiliario.SelectedIndex = -1;
        }

        private void CargarTabla()
        {
            Dgv_Ordenes_Mobiliario.DataSource = controlador.MostrarDetalleOrdenMobiliario();
            Dgv_Ordenes_Mobiliario.ClearSelection();
        }

        private bool ValidarCampos()
        {
            if (_cargando) return false; // Evita que se dispare al cargar

            if (Cbo_Orden_Produccion.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una Orden de Producción.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Cbo_Mobiliario.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un Mobiliario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Nud_Cantidad_Mobiliario.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verificar duplicados
            foreach (DataGridViewRow row in Dgv_Ordenes_Mobiliario.Rows)
            {
                if (row.Cells["Fk_Id_Orden_Produccion"].Value != null &&
                    row.Cells["Fk_Id_Mobiliario"].Value != null)
                {
                    int orden = Convert.ToInt32(Cbo_Orden_Produccion.SelectedValue);
                    int mobiliario = Convert.ToInt32(Cbo_Mobiliario.SelectedValue);

                    if (orden == Convert.ToInt32(row.Cells["Fk_Id_Orden_Produccion"].Value) &&
                        mobiliario == Convert.ToInt32(row.Cells["Fk_Id_Mobiliario"].Value) &&
                        idDetalleSeleccionado != Convert.ToInt32(row.Cells["Pk_Id_Detalle_Orden_Mobiliario"].Value))
                    {
                        MessageBox.Show("Este Mobiliario ya está registrado para la Orden seleccionada.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            return true;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            int idOrden = Convert.ToInt32(Cbo_Orden_Produccion.SelectedValue);
            int idMobiliario = Convert.ToInt32(Cbo_Mobiliario.SelectedValue);
            int cantidad = (int)Nud_Cantidad_Mobiliario.Value;

            controlador.GuardarDetalleOrdenMobiliario(idOrden, idMobiliario, cantidad);
            CargarTabla();
            LimpiarControles();
            MessageBox.Show("Registro guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            if (idDetalleSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione una fila para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idOrden = Convert.ToInt32(Cbo_Orden_Produccion.SelectedValue);
            int idMobiliario = Convert.ToInt32(Cbo_Mobiliario.SelectedValue);
            int cantidad = (int)Nud_Cantidad_Mobiliario.Value;

            controlador.ActualizarDetalleOrdenMobiliario(idDetalleSeleccionado, idOrden, idMobiliario, cantidad);
            CargarTabla();
            LimpiarControles();
            MessageBox.Show("Registro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (idDetalleSeleccionado <= 0)
            {
                MessageBox.Show("Seleccione una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            controlador.BorrarDetalleOrdenMobiliario(idDetalleSeleccionado);
            CargarTabla();
            LimpiarControles();
            MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Dgv_Ordenes_Mobiliario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    idDetalleSeleccionado = Convert.ToInt32(Dgv_Ordenes_Mobiliario.Rows[e.RowIndex].Cells["Pk_Id_Detalle_Orden_Mobiliario"].Value);
                    Cbo_Orden_Produccion.SelectedValue = Dgv_Ordenes_Mobiliario.Rows[e.RowIndex].Cells["Fk_Id_Orden_Produccion"].Value;
                    Cbo_Mobiliario.SelectedValue = Dgv_Ordenes_Mobiliario.Rows[e.RowIndex].Cells["Fk_Id_Mobiliario"].Value;
                    Nud_Cantidad_Mobiliario.Value = Convert.ToDecimal(Dgv_Ordenes_Mobiliario.Rows[e.RowIndex].Cells["Cmp_Cantidad_Mobiliario"].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar fila: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarControles()
        {
            idDetalleSeleccionado = 0;
            Cbo_Orden_Produccion.SelectedIndex = -1;
            Cbo_Mobiliario.SelectedIndex = -1;
            Nud_Cantidad_Mobiliario.Value = 1;
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Orden_Mobiliario frm = new Frm_Reporte_Orden_Mobiliario();
            frm.Show();
        }
    }
}

