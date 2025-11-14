/* 
 * Programador: Richard Anthony De León Milian
 * Carné: 0901-22-10245
 * Fecha de modificación: 8/11/2025
 * Archivo: Cls_Conexion.cs
 * Descripción: Vista, Funcionamiento de los botones y demás elementos
 */
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Capa_Controlador_Percepciones_Nomina;
using Capa_Modelo_Percepciones_Nomina;

namespace Capa_Vista_Percepciones_Nomina
{
    public partial class Form_Percep : UserControl
    {
        private readonly Cls_CatalogosControlador ctrl = new Cls_CatalogosControlador();
        private readonly Cls_MovimientosControlador _controlador = new Cls_MovimientosControlador();
        private readonly Cls_UtilControlador _util = new Cls_UtilControlador();

        // Ctor: inicializa componentes visuales del UserControl.
        public Form_Percep()
        {
            InitializeComponent();
        }

        // OnLoad: suscribe eventos y carga combos al montar el control.
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                try
                {
                    Cbo_NoNomina.SelectedIndexChanged += Cbo_NoNomina_SelectedIndexChanged;
                    CargarCombos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en OnLoad: " + ex.Message,
                                    "Percepciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // RefreshData: permite recargar las fuentes de datos desde el contenedor padre.
        public void RefreshData() => CargarCombos();

        // CargarCombos: llena los ComboBox (concepto, empleado, nómina) y configura estilos/selecciones.
        private void CargarCombos()
        {
            // --- Concepto de Nómina ---
            var dtConceptos = ctrl.funListarConceptosNomina();
            Cbo_ConceptoNomina.DisplayMember = "nombre_concepto_nomina";
            Cbo_ConceptoNomina.ValueMember = "id_concepto_nomina";
            Cbo_ConceptoNomina.DataSource = dtConceptos;

            // --- Empleados (opcional / no usado en movimientos) ---
            var dtEmpleados = ctrl.funListarEmpleados();
            Cbo_Empleado.DisplayMember = "nombre_empleado";
            Cbo_Empleado.ValueMember = "id_empleado";
            Cbo_Empleado.DataSource = dtEmpleados;

            // --- No. Nómina ---
            var dtNominas = ctrl.funListarNumerosNomina();
            Cbo_NoNomina.DisplayMember = "numero_nomina";
            Cbo_NoNomina.ValueMember = "id_nomina";
            Cbo_NoNomina.DataSource = dtNominas;

            Cbo_ConceptoNomina.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Empleado.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_NoNomina.DropDownStyle = ComboBoxStyle.DropDownList;

            // Sin selección inicial
            Cbo_ConceptoNomina.SelectedIndex = -1;
            Cbo_Empleado.SelectedIndex = -1;
            Cbo_NoNomina.SelectedIndex = -1;

            // Limpiar grid si no hay nóminas
            if (dtNominas == null || dtNominas.Rows.Count == 0)
                Dgv_Detalle.DataSource = null;
        }

        // Cbo_NoNomina_SelectedIndexChanged: al cambiar nómina, recarga el grid correspondiente.
        private void Cbo_NoNomina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_NoNomina.SelectedValue == null) return;
            if (Cbo_NoNomina.SelectedValue.ToString() == "System.Data.DataRowView") return;

            if (int.TryParse(Cbo_NoNomina.SelectedValue.ToString(), out int idNomina))
                proCargarDgvMovimientos(idNomina);
        }

        // proCargarDgvMovimientos: consulta y muestra movimientos de la nómina seleccionada.
        private void proCargarDgvMovimientos(int idNomina)
        {
            var dt = _controlador.funMostrarMovimientosPorNomina(idNomina, asc: true);

            Dgv_Detalle.AutoGenerateColumns = true;
            Dgv_Detalle.DataSource = null;
            Dgv_Detalle.Columns.Clear();
            Dgv_Detalle.DataSource = dt;

            // Encabezados legibles
            if (Dgv_Detalle.Columns.Contains("id_movimiento"))
                Dgv_Detalle.Columns["id_movimiento"].HeaderText = "ID Movimiento";
            if (Dgv_Detalle.Columns.Contains("id_nomina"))
                Dgv_Detalle.Columns["id_nomina"].HeaderText = "ID Nómina";
            if (Dgv_Detalle.Columns.Contains("id_concepto_nomina"))
                Dgv_Detalle.Columns["id_concepto_nomina"].HeaderText = "ID Concepto";
            if (Dgv_Detalle.Columns.Contains("concepto"))
                Dgv_Detalle.Columns["concepto"].HeaderText = "Concepto";
            if (Dgv_Detalle.Columns.Contains("monto"))
                Dgv_Detalle.Columns["monto"].HeaderText = "Monto";
            // NUEVO: Ocultar columna id_concepto_nomina
            if (Dgv_Detalle.Columns.Contains("id_concepto_nomina"))
                Dgv_Detalle.Columns["id_concepto_nomina"].Visible = false;

            Dgv_Detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // proSeleccionarFilaPorMovimiento: resalta en el grid el movimiento recién insertado por su ID.
        private void proSeleccionarFilaPorMovimiento(int iIdMovimiento)
        {
            if (Dgv_Detalle.DataSource is DataTable dt && dt.Columns.Contains("id_movimiento"))
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dt.Rows[i]["id_movimiento"]) == iIdMovimiento)
                    {
                        Dgv_Detalle.ClearSelection();
                        Dgv_Detalle.Rows[i].Selected = true;
                        Dgv_Detalle.FirstDisplayedScrollingRowIndex = i;
                        break;
                    }
                }
            }
        }

        // proCbo_NoNomina_SelectedIndexChanged: versión estandarizada del cambio de nómina (mantener si se usa).
        private void proCbo_NoNomina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_NoNomina.SelectedValue == null) return;
            if (Cbo_NoNomina.SelectedValue.ToString() == "System.Data.DataRowView") return;

            if (int.TryParse(Cbo_NoNomina.SelectedValue.ToString(), out int iIdNomina))
                proCargarDgvMovimientos(iIdNomina);
        }

        // Btn_Guardar_Click: valida entradas e inserta un movimiento de nómina.
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Cbo_NoNomina.SelectedValue == null ||
                Cbo_ConceptoNomina.SelectedValue == null ||
                Cbo_Empleado.SelectedValue == null)
            {
                MessageBox.Show("Selecciona Nómina, Empleado y Concepto.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(Txt_Valor.Text, out var deMonto) || deMonto <= 0)
            {
                MessageBox.Show("Ingresa un monto válido.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int iIdNomina = Convert.ToInt32(Cbo_NoNomina.SelectedValue);
            int iIdEmpleado = Convert.ToInt32(Cbo_Empleado.SelectedValue);
            int iIdConcepto = Convert.ToInt32(Cbo_ConceptoNomina.SelectedValue);

            try
            {
                int iNuevoIdMovimiento = _controlador.funInsertarMovimiento(
                    iIdNomina, iIdEmpleado, iIdConcepto, deMonto);

                proCargarDgvMovimientos(iIdNomina);
                proSeleccionarFilaPorMovimiento(iNuevoIdMovimiento);

                MessageBox.Show("Movimiento registrado correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Btn_Eliminar_Click: elimina el movimiento seleccionado y recarga el grid.
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_Detalle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un movimiento para eliminar.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // obtén el ID del movimiento seleccionado
            int iIdMovimiento = Convert.ToInt32(
                Dgv_Detalle.SelectedRows[0].Cells["id_movimiento"].Value);

            var confirm = MessageBox.Show(
                "¿Seguro que deseas eliminar este movimiento?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.No)
                return;

            try
            {
                _controlador.proEliminarMovimiento(iIdMovimiento);

                // recargar grid
                int iIdNomina = Convert.ToInt32(Cbo_NoNomina.SelectedValue);
                proCargarDgvMovimientos(iIdNomina);

                MessageBox.Show("Movimiento eliminado correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
