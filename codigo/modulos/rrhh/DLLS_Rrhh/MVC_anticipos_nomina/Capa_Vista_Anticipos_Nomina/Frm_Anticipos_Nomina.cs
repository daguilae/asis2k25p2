using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Capa_Controlador_Anticipos_Nomina;
// CARLO ANDREE BARQUERO BOCHE 0901-22-601  06-11-2025

namespace Capa_Vista_Anticipos_Nomina
{
    public partial class Frm_Anticipos_Nomina : UserControl
    {
        private readonly Cls_Controlador_Anticipos_Nomina controlador = new Cls_Controlador_Anticipos_Nomina();

        public Frm_Anticipos_Nomina()
        {
            InitializeComponent();
            Load += Frm_Anticipos_Nomina_Load;
        }

        private void Frm_Anticipos_Nomina_Load(object sender, EventArgs e)
        {
            // Inicializar ComboBox
            funCargarCombos();

            Dgv_anticipos.DataSource = null;
            Dgv_anticipos.Columns.Clear();
        }

        // Cargar los empleados en ComboBox
        private void funCargarCombos()
        {
            try
            {
                DataTable dtEmpleados = controlador.funObtenerEmpleados();

                if (dtEmpleados == null || dtEmpleados.Rows.Count == 0)
                {
                    MessageBox.Show("⚠️ No hay empleados activos registrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                cboEmpleado.SelectedIndexChanged -= cboEmpleado_SelectedIndexChanged;

                cboEmpleado.DataSource = dtEmpleados;
                cboEmpleado.DisplayMember = "Nombre";          // Columna con nombres
                cboEmpleado.ValueMember = "Cmp_iId_Empleado";  // Columna con ID
                cboEmpleado.SelectedIndex = -1;

                cboEmpleado.SelectedIndexChanged += cboEmpleado_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al cargar empleados:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento al seleccionar un empleado
        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedIndex == -1) return;

            if (int.TryParse(cboEmpleado.SelectedValue?.ToString(), out int idEmpleado))
            {
                funCargarAnticiposPorEmpleado(idEmpleado);
            }
        }

        // Funcion para cargar el datagrid con los anticipos
        private void funCargarAnticiposPorEmpleado(int iIdEmpleado)
        {
            try
            {
                DataTable dt = controlador.funObtenerAnticiposPorEmpleado(iIdEmpleado);

                // Limpiar DataGridView
                Dgv_anticipos.DataSource = null;
                Dgv_anticipos.Columns.Clear();

                if (dt == null || dt.Rows.Count == 0)
                {
                    return; // No hay anticipos
                }

                Dgv_anticipos.DataSource = dt;
                Dgv_anticipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // BLOQUEA MOVIMIENTOS Y EDICIONES
                Dgv_anticipos.AllowUserToAddRows = false;      // No permitime filas nuevas
                Dgv_anticipos.AllowUserToDeleteRows = false;   // No permitime borrar filas
                Dgv_anticipos.AllowUserToOrderColumns = false; // No permitime mover columnas
                Dgv_anticipos.ReadOnly = true;                 // Solo lectura
                Dgv_anticipos.MultiSelect = false;             // Solo una fila a la vez
                Dgv_anticipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selección por fila
                Dgv_anticipos.RowHeadersVisible = false;       // Ocultar encabezado de filas

                // Ocultar columnas técnicas
                if (Dgv_anticipos.Columns.Contains("Cmp_iId_Anticipo"))
                    Dgv_anticipos.Columns["Cmp_iId_Anticipo"].Visible = false;
                if (Dgv_anticipos.Columns.Contains("Cmp_iId_Empleado"))
                    Dgv_anticipos.Columns["Cmp_iId_Empleado"].Visible = false;

                // Nombres amigables
                if (Dgv_anticipos.Columns.Contains("Cmp_deMonto_Anticipo"))
                    Dgv_anticipos.Columns["Cmp_deMonto_Anticipo"].HeaderText = "Monto";
                if (Dgv_anticipos.Columns.Contains("Cmp_dFecha_Anticipo"))
                    Dgv_anticipos.Columns["Cmp_dFecha_Anticipo"].HeaderText = "Fecha";
                if (Dgv_anticipos.Columns.Contains("Cmp_sMotivo_Anticipo"))
                    Dgv_anticipos.Columns["Cmp_sMotivo_Anticipo"].HeaderText = "Motivo";
                if (Dgv_anticipos.Columns.Contains("Cmp_deSaldoPendiente_Anticipo"))
                    Dgv_anticipos.Columns["Cmp_deSaldoPendiente_Anticipo"].HeaderText = "Saldo Pendiente";

               // Formato de moneda
                var culturaGT = new System.Globalization.CultureInfo("es-GT");

                if (Dgv_anticipos.Columns.Contains("Cmp_dFecha_Anticipo"))
                    Dgv_anticipos.Columns["Cmp_dFecha_Anticipo"].DefaultCellStyle.Format = "dd/MM/yyyy";

                if (Dgv_anticipos.Columns.Contains("Cmp_deMonto_Anticipo"))
                {
                    Dgv_anticipos.Columns["Cmp_deMonto_Anticipo"].DefaultCellStyle.Format = "C2";
                    Dgv_anticipos.Columns["Cmp_deMonto_Anticipo"].DefaultCellStyle.FormatProvider = culturaGT;
                }

                if (Dgv_anticipos.Columns.Contains("Cmp_deSaldoPendiente_Anticipo"))
                {
                    Dgv_anticipos.Columns["Cmp_deSaldoPendiente_Anticipo"].DefaultCellStyle.Format = "C2";
                    Dgv_anticipos.Columns["Cmp_deSaldoPendiente_Anticipo"].DefaultCellStyle.FormatProvider = culturaGT;
                }

                Dgv_anticipos.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar anticipos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------------- NUEVO ANTICIPO ----------------------
        private void Btn_solicitar_Click(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un empleado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);

            Frm_NuevoAnticipo frm = new Frm_NuevoAnticipo(idEmpleado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                funCargarAnticiposPorEmpleado(idEmpleado);
            }
        }

        // ---------------------- ELIMINAR ANTICIPO ----------------------
        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_anticipos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un anticipo de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow fila = Dgv_anticipos.CurrentRow;

                int idAnticipo = Convert.ToInt32(fila.Cells["Cmp_iId_Anticipo"].Value);
                string motivo = fila.Cells["Cmp_sMotivo_Anticipo"].Value.ToString();
                decimal monto = Convert.ToDecimal(fila.Cells["Cmp_deMonto_Anticipo"].Value);

                DialogResult confirmar = MessageBox.Show(
                    $"¿Desea eliminar el anticipo seleccionado?\n\n" +
                    $"💵 Monto: Q{monto:N2}\n" +
                    $"📝 Motivo: {motivo}",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmar == DialogResult.No)
                    return;

                controlador.EliminarAnticipo(idAnticipo);

                MessageBox.Show("🗑️ Anticipo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (cboEmpleado.SelectedIndex != -1)
                {
                    int idEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);
                    funCargarAnticiposPorEmpleado(idEmpleado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar anticipo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------------- MODIFICAR ANTICIPO ----------------------
        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_anticipos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un anticipo de la tabla para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow fila = Dgv_anticipos.CurrentRow;

                int idAnticipo = Convert.ToInt32(fila.Cells["Cmp_iId_Anticipo"].Value);
                int idEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);
                decimal monto = Convert.ToDecimal(fila.Cells["Cmp_deMonto_Anticipo"].Value);
                string motivo = fila.Cells["Cmp_sMotivo_Anticipo"].Value.ToString();
                DateTime fecha = Convert.ToDateTime(fila.Cells["Cmp_dFecha_Anticipo"].Value);

                Frm_ModificarAnticipo frm = new Frm_ModificarAnticipo(idAnticipo, idEmpleado, monto, motivo, fecha);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    funCargarAnticiposPorEmpleado(idEmpleado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario de modificación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
