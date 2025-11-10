// Nombre: Diego Andre Monterroso Rabarique
// Carné: 0901-22-1369
// Fecha de modificación: 2025-11-09
// Descripción: Lógica de negocio para CRUD de Horas_Extras.

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Capa_Controlador_HorasExtra;

namespace Capa_Vista_HorasExtra
{
    public partial class Frm_Solicitar_Horas_Extras : Form
    {
        private readonly Controlador cn = new Controlador();

        public Frm_Solicitar_Horas_Extras()
        {
            InitializeComponent();
            this.Load += Frm_Solicitar_Horas_Extras_Load;

            // Eventos
            Btn_Guardar.Click += Btn_Guardar_Click;
            Btn_Regresar.Click += Btn_Regresar_Click;
            Chb_Aprobado.CheckedChanged += (s, e) => ActualizarTextoCheckBox();
        }

        // =====================================================
        // Cargar empleados en el ComboBox al iniciar
        // =====================================================
        private void Frm_Solicitar_Horas_Extras_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            ActualizarTextoCheckBox(); // para que el checkbox tenga el texto correcto al abrir
        }

        private void CargarEmpleados()
        {
            try
            {
                DataTable empleados = cn.ObtenerEmpleados();
                Cbo_Empleado.DataSource = empleados;
                Cbo_Empleado.DisplayMember = "NombreEmpleado";
                Cbo_Empleado.ValueMember = "IdEmpleado";
                Cbo_Empleado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // Actualizar texto del CheckBox
        // =====================================================
        private void ActualizarTextoCheckBox()
        {
            Chb_Aprobado.Text = Chb_Aprobado.Checked ? "✔ Aprobado" : "✖ No aprobado";
            Chb_Aprobado.ForeColor = Chb_Aprobado.Checked ? Color.Green : Color.Red;
        }

        // =====================================================
        // Botón Guardar (inserta nueva hora extra)
        // =====================================================
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (Cbo_Empleado.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un empleado.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Nud_Horas.Value <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida de horas.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(Txt_Motivo.Text))
                {
                    MessageBox.Show("Debe ingresar un motivo.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Datos para insertar
                int empleado = Convert.ToInt32(Cbo_Empleado.SelectedValue);
                DateTime fecha = Dtp_Fecha.Value;
                int horas = Convert.ToInt32(Nud_Horas.Value);
                string motivo = Txt_Motivo.Text.Trim();
                bool aprobado = Chb_Aprobado.Checked;

                // Guardar en BD
                cn.GuardarHorasExtra(empleado, fecha, horas, motivo, aprobado);

                // Mensaje según el estado
                string estado = aprobado ? "aprobadas" : "registradas como NO aprobadas";
                MessageBox.Show($"✅ Horas extra {estado} correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); // Cierra el formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // Botón Regresar (cierra el formulario)
        // =====================================================
        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =====================================================
        // Eventos de diseño (puedes dejar vacíos)
        // =====================================================
        private void Pnl_Encabezado_Paint(object sender, PaintEventArgs e) { }
        private void Gpb_SolicitarHorasE_Enter(object sender, EventArgs e) { }
    }
}
