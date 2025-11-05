using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Movimientos_Nomina;

namespace Capa_Vista_Deducciones_Nomina
{
    public partial class Frm_Deducciones_Nomina : UserControl
    {
        private readonly Cls_Controlador_Movimientos_Nomina controlador = new Cls_Controlador_Movimientos_Nomina();

        public Frm_Deducciones_Nomina()
        {
            InitializeComponent();
        }

        // ==========================================================
        // EVENTO LOAD
        // ==========================================================
        private void Frm_Deducciones_Nomina1_Load(object sender, EventArgs e)
        {
            funCargarCombos();
        }

        // ==========================================================
        // CARGA DE COMBOS
        // ==========================================================
        private void funCargarCombos()
        {
            try
            {
                // --- Nóminas ---
                DataTable dtNominas = controlador.funObtenerNominas();
                cboNoNomina.DataSource = dtNominas;
                cboNoNomina.DisplayMember = "Nombre";
                cboNoNomina.ValueMember = "Cmp_iId_Nomina";
                cboNoNomina.SelectedIndex = -1;

                // --- Empleados ---
                DataTable dtEmpleados = controlador.funObtenerEmpleados();
                cboEmpleado.DataSource = dtEmpleados;
                cboEmpleado.DisplayMember = "Nombre";
                cboEmpleado.ValueMember = "Cmp_iId_Empleado";
                cboEmpleado.SelectedIndex = -1;

                // --- Conceptos ---
                DataTable dtConceptos = controlador.funObtenerConceptos();
                cboConcepto.DataSource = dtConceptos;
                cboConcepto.DisplayMember = "Cmp_sNombre_ConceptoNomina";
                cboConcepto.ValueMember = "Cmp_iId_ConceptoNomina";
                cboConcepto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR al cargar combos: {ex.Message}");
            }
        }

        // ==========================================================
        // CARGAR MOVIMIENTOS SEGÚN NÓMINA
        // ==========================================================
        private void cboNoNomina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNoNomina.SelectedValue == null || !(cboNoNomina.SelectedValue is int))
                return;

            int idNomina = Convert.ToInt32(cboNoNomina.SelectedValue);
            funCargarMovimientosPorNomina(idNomina);
        }

        private void funCargarMovimientosPorNomina(int iIdNomina)
        {
            try
            {
                DataTable dt = controlador.funObtenerMovimientosPorNomina(iIdNomina);
                dgvDatos.Rows.Clear();

                foreach (DataRow fila in dt.Rows)
                {
                    dgvDatos.Rows.Add(
                        fila["Cmp_iId_MovimientoNomina"].ToString(),
                        fila["Cmp_iId_Nomina"].ToString(),
                        fila["NombreConcepto"].ToString(),
                        fila["Cmp_deMonto_MovimientoNomina"].ToString()
                    );
                }

                Console.WriteLine($"Movimientos cargados para nómina #{iIdNomina}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"al cargar movimientos por nómina: {ex.Message}");
            }
        }

        // ==========================================================
        // CARGAR MOVIMIENTOS SEGÚN NÓMINA Y EMPLEADO
        // ==========================================================
        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNoNomina.SelectedValue == null || cboEmpleado.SelectedValue == null)
                return;

            if (!(cboNoNomina.SelectedValue is int) || !(cboEmpleado.SelectedValue is int))
                return;

            int idNomina = Convert.ToInt32(cboNoNomina.SelectedValue);
            int idEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);
            funCargarMovimientosPorNominaYEmpleado(idNomina, idEmpleado);
        }

        private void funCargarMovimientosPorNominaYEmpleado(int iIdNomina, int iIdEmpleado)
        {
            try
            {
                DataTable dt = controlador.funObtenerMovimientosPorNominaYEmpleado(iIdNomina, iIdEmpleado);
                dgvDatos.Rows.Clear();

                foreach (DataRow fila in dt.Rows)
                {
                    dgvDatos.Rows.Add(
                        fila["Cmp_iId_MovimientoNomina"].ToString(),
                        iIdNomina.ToString(),
                        fila["NombreConcepto"].ToString(),
                        fila["Cmp_deMonto_MovimientoNomina"].ToString()
                    );
                }

                Console.WriteLine($"Movimientos cargados para nómina #{iIdNomina}, empleado #{iIdEmpleado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR al cargar movimientos por nómina y empleado: {ex.Message}");
            }
        }

        // ==========================================================
        // PLACEHOLDERS DE EVENTOS
        // ==========================================================
        private void label2_Click(object sender, EventArgs e) { }
        private void cboConcepto_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtValor_TextChanged(object sender, EventArgs e) { }
        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btn_guardar_datos_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar selección de nómina
                if (cboNoNomina.SelectedValue == null || !(cboNoNomina.SelectedValue is int))
                {
                    MessageBox.Show("Seleccione una nómina antes de guardar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int iIdNomina = Convert.ToInt32(cboNoNomina.SelectedValue);

                // 🔹 Verificar si la nómina está generada
                string estadoNomina = controlador.funObtenerEstadoNomina(iIdNomina);
                if (estadoNomina.ToUpper() == "GENERADA")
                {
                    MessageBox.Show(
                        "No puede agregar movimientos a una nómina ya generada.",
                        "Operación no permitida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return;
                }

                // Validar selección de empleado
                if (cboEmpleado.SelectedValue == null || !(cboEmpleado.SelectedValue is int))
                {
                    MessageBox.Show("Seleccione un empleado antes de guardar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar selección de concepto
                if (cboConcepto.SelectedValue == null || !(cboConcepto.SelectedValue is int))
                {
                    MessageBox.Show("Seleccione un concepto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar valor numérico
                if (!decimal.TryParse(txtValor.Text, out decimal dMonto) || dMonto <= 0)
                {
                    MessageBox.Show("Ingrese un monto válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int iIdEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);
                int iIdConcepto = Convert.ToInt32(cboConcepto.SelectedValue);

                // Guardar movimiento
                controlador.proInsertarMovimientoNomina(iIdNomina, iIdEmpleado, iIdConcepto, dMonto);
                Console.WriteLine($"Movimiento insertado en nómina #{iIdNomina}, empleado #{iIdEmpleado}, concepto #{iIdConcepto}, monto {dMonto}");

                funCargarMovimientosPorNominaYEmpleado(iIdNomina, iIdEmpleado);

                cboConcepto.SelectedIndex = -1;
                txtValor.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR al guardar movimiento: {ex.Message}");
                MessageBox.Show("Ocurrió un error al guardar el movimiento. Revise la consola para más detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
