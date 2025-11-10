// Nombre: Diego Andre Monterroso Rabarique
// Carné: 0901-22-1369
// Fecha de modificación: 2025-11-09
// Descripción: Lógica de negocio para CRUD de Horas_Extras.

using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using Capa_Controlador_HorasExtra;

namespace Capa_Vista_HorasExtra
{
    public partial class Frm_Editar_Horas_Extras : Form
    {
        private readonly Controlador cn = new Controlador();
        private readonly int idSeleccionado;

        public Frm_Editar_Horas_Extras(int id, string empleado, DateTime fecha, int horas, string motivo, bool aprobado)
        {
            InitializeComponent();
            idSeleccionado = id;

            // Cargar empleados y valores iniciales
            CargarEmpleados();
            Cbo_Empleado.Text = empleado;
            Dtp_Fecha.Value = fecha;
            Nud_Horas.Value = horas;
            Txt_Motivo.Text = motivo;
            Chb_Aprobado.Checked = aprobado;
            ActualizarTextoCheckBox();

            // Eventos
            Btn_Guardar.Click += Btn_Guardar_Click;
            Btn_Regresar.Click += Btn_Regresar_Click;
            Chb_Aprobado.CheckedChanged += (s, e) => ActualizarTextoCheckBox();
        }

        // =====================================================
        // Cargar empleados
        // =====================================================
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
                MessageBox.Show("Error al cargar empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        // Botón Guardar
        // =====================================================
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (Cbo_Empleado.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un empleado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Nud_Horas.Value <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida de horas.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(Txt_Motivo.Text))
                {
                    MessageBox.Show("Debe ingresar un motivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Datos para actualizar
                int idEmpleado = Convert.ToInt32(Cbo_Empleado.SelectedValue);
                DateTime fecha = Dtp_Fecha.Value;
                int horas = (int)Nud_Horas.Value;
                string motivo = Txt_Motivo.Text.Trim();
                bool aprobado = Chb_Aprobado.Checked;

                // Actualizar en BD
                cn.ActualizarHorasExtra(idSeleccionado, idEmpleado, fecha, horas, motivo, aprobado);

                // Mensaje según el estado
                string estado = aprobado ? "aprobadas" : "registradas como NO aprobadas";
                MessageBox.Show($"✅ Horas extra {estado} correctamente.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // Botón Regresar
        // =====================================================
        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show(
                "¿Desea salir sin guardar los cambios?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}