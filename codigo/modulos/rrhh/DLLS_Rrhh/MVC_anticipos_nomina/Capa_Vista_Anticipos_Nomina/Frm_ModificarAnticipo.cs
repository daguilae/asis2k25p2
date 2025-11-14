using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Anticipos_Nomina;
// CARLO ANDREE BARQUERO BOCHE 0901-22-601  06-11-2025
namespace Capa_Vista_Anticipos_Nomina
{
    public partial class Frm_ModificarAnticipo : Form
    {
        private readonly Cls_Controlador_Anticipos_Nomina controlador = new Cls_Controlador_Anticipos_Nomina();
        private readonly int idAnticipo;
        private readonly int idEmpleado;

        public Frm_ModificarAnticipo(int idAnticipoSeleccionado, int idEmpleadoSeleccionado, decimal monto, string motivo, DateTime fecha)
        {
            InitializeComponent();

            idAnticipo = idAnticipoSeleccionado;
            idEmpleado = idEmpleadoSeleccionado;

            // Cargar datos iniciales
            CargarEmpleado();
            Txt_monto.Text = monto.ToString();
            Txt_motivo.Text = motivo;
            Dtp_fecha.Value = fecha;

            // Eventos
            Btn_guardar.Click += Btn_guardar_Click;
            Btn_Cancelar.Click += Btn_Cancelar_Click;
        }

        // Funcion Para cargar el empleado
        private void CargarEmpleado()
        {
            try
            {
                DataTable empleados = controlador.funObtenerEmpleados();
                cboEmpleado.DataSource = empleados;
                cboEmpleado.DisplayMember = "Nombre";
                cboEmpleado.ValueMember = "Cmp_iId_Empleado";
                cboEmpleado.SelectedValue = idEmpleado;
                cboEmpleado.Enabled = false; // No editable
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Funcion para guardar
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(Txt_monto.Text.Trim(), out decimal monto) || monto <= 0)
                {
                    MessageBox.Show("Ingrese un monto válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string motivo = Txt_motivo.Text.Trim();
                if (string.IsNullOrEmpty(motivo))
                {
                    MessageBox.Show("Ingrese un motivo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime fecha = Dtp_fecha.Value;
                decimal saldoPendiente = monto;

                controlador.EditarAnticipo(idAnticipo, idEmpleado, monto, fecha, motivo, saldoPendiente);

                MessageBox.Show("✏️ Anticipo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar anticipo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Funcion para cancelar
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
