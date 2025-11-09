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
        private readonly CatalogosControlador ctrl = new CatalogosControlador();
        private readonly MovimientosControlador _controlador = new MovimientosControlador();
        private readonly UtilControlador _util = new UtilControlador();

        public Form_Percep()
        {
            InitializeComponent();
        }

        // OnLoad es más confiable en UserControl
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

        // Permite recargar desde el formulario padre si quieres
        public void RefreshData() => CargarCombos();

        private void CargarCombos()
        {
            // --- Concepto de Nómina ---
            var dtConceptos = ctrl.ListarConceptosNomina();
            Cbo_ConceptoNomina.DisplayMember = "nombre_concepto_nomina";
            Cbo_ConceptoNomina.ValueMember = "id_concepto_nomina";
            Cbo_ConceptoNomina.DataSource = dtConceptos;

            // --- Empleados (opcional / no usado en movimientos) ---
            var dtEmpleados = ctrl.ListarEmpleados();
            Cbo_Empleado.DisplayMember = "nombre_empleado";
            Cbo_Empleado.ValueMember = "id_empleado";
            Cbo_Empleado.DataSource = dtEmpleados;

            // --- No. Nómina ---
            var dtNominas = ctrl.ListarNumerosNomina();
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
                Dvg_Detalle.DataSource = null;
        }

        // Recargar grid al cambiar la nómina
        private void Cbo_NoNomina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_NoNomina.SelectedValue == null) return;
            if (Cbo_NoNomina.SelectedValue.ToString() == "System.Data.DataRowView") return;

            if (int.TryParse(Cbo_NoNomina.SelectedValue.ToString(), out int idNomina))
                CargarDgvMovimientos(idNomina);
        }

        // GRID: Movimientos por nómina
        private void CargarDgvMovimientos(int idNomina)
        {
            var dt = _controlador.MostrarMovimientosPorNomina(idNomina, asc: true);

            Dvg_Detalle.AutoGenerateColumns = true;
            Dvg_Detalle.DataSource = null;
            Dvg_Detalle.Columns.Clear();
            Dvg_Detalle.DataSource = dt;

            // Encabezados legibles
            if (Dvg_Detalle.Columns.Contains("id_movimiento"))
                Dvg_Detalle.Columns["id_movimiento"].HeaderText = "ID Movimiento";
            if (Dvg_Detalle.Columns.Contains("id_nomina"))
                Dvg_Detalle.Columns["id_nomina"].HeaderText = "ID Nómina";
            if (Dvg_Detalle.Columns.Contains("id_concepto_nomina"))
                Dvg_Detalle.Columns["id_concepto_nomina"].HeaderText = "ID Concepto";
            if (Dvg_Detalle.Columns.Contains("concepto"))
                Dvg_Detalle.Columns["concepto"].HeaderText = "Concepto";
            if (Dvg_Detalle.Columns.Contains("monto"))
                Dvg_Detalle.Columns["monto"].HeaderText = "Monto";

            Dvg_Detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Seleccionar el movimiento recién insertado
        private void SeleccionarFilaPorMovimiento(int idMovimiento)
        {
            if (Dvg_Detalle.DataSource is DataTable dt && dt.Columns.Contains("id_movimiento"))
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dt.Rows[i]["id_movimiento"]) == idMovimiento)
                    {
                        Dvg_Detalle.ClearSelection();
                        Dvg_Detalle.Rows[i].Selected = true;
                        Dvg_Detalle.FirstDisplayedScrollingRowIndex = i;
                        break;
                    }
                }
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (Cbo_NoNomina.SelectedValue == null || Cbo_ConceptoNomina.SelectedValue == null || Cbo_Empleado.SelectedValue == null)
                {
                    MessageBox.Show("Selecciona Nómina, Empleado y Concepto.", "Validación",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(Txt_Valor.Text, out var monto) || monto <= 0)
                {
                    MessageBox.Show("Ingresa un monto válido.", "Validación",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idNomina = Convert.ToInt32(Cbo_NoNomina.SelectedValue);
                int idEmpleado = Convert.ToInt32(Cbo_Empleado.SelectedValue);
                int idConcepto = Convert.ToInt32(Cbo_ConceptoNomina.SelectedValue);

                // ✅ Verificar estado de la nómina
                string estadoNomina = ctrl.ObtenerEstadoNomina(idNomina);
                if (estadoNomina.ToUpper() == "GENERADA")
                {
                    MessageBox.Show(
                        "No puedes agregar movimientos a una nómina ya generada.",
                        "Operación no permitida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return;
                }

                // --- Guardar movimiento ---
                Conexion cn = new Conexion();
                using (OdbcConnection con = cn.conexionDB())
                using (OdbcTransaction tx = con.BeginTransaction())
                {
                    int nuevoIdMovimiento = 0;

                    try
                    {
                        string sqlMov = @"
                    INSERT INTO `Tbl_MovimientosNomina`
                        (`Cmp_iId_Nomina`, `Cmp_iId_Empleado`, `Cmp_iId_ConceptoNomina`, `Cmp_deMonto_MovimientoNomina`)
                    VALUES (?, ?, ?, ?);";

                        using (OdbcCommand cmd = new OdbcCommand(sqlMov, con, tx))
                        {
                            cmd.Parameters.Add("p1", OdbcType.Int).Value = idNomina;
                            cmd.Parameters.Add("p2", OdbcType.Int).Value = idEmpleado;
                            cmd.Parameters.Add("p3", OdbcType.Int).Value = idConcepto;
                            cmd.Parameters.Add("p4", OdbcType.Decimal).Value = monto;
                            cmd.ExecuteNonQuery();
                        }

                        using (OdbcCommand cmdId = new OdbcCommand("SELECT LAST_INSERT_ID();", con, tx))
                        {
                            nuevoIdMovimiento = Convert.ToInt32(cmdId.ExecuteScalar());
                        }

                        tx.Commit();

                        CargarDgvMovimientos(idNomina);
                        SeleccionarFilaPorMovimiento(nuevoIdMovimiento);

                        MessageBox.Show("Movimiento registrado correctamente.", "Éxito",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        try { tx.Rollback(); } catch { }
                        MessageBox.Show("Error al insertar: " + ex.Message, "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cn.cerrarConexion();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "¿Seguro que quieres eliminar todos los movimientos?\nEsto reiniciará el contador de ID.",
                "Confirmar limpieza", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // Limpiar solo movimientos y reiniciar contador
                    _util.TruncarTabla("Tbl_MovimientosNomina");

                    MessageBox.Show("Movimientos eliminados y contador reiniciado.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar grid vacío
                    Dvg_Detalle.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al limpiar: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
