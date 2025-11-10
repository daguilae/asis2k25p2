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
    public partial class Frm_Horas_Extras : UserControl
    {
        Controlador cn = new Controlador();

        public Frm_Horas_Extras()
        {
            InitializeComponent();
            CargarEmpleados();
            CargarHorasExtra();
        }

        // =====================================================
        // Cargar empleados al ComboBox
        // =====================================================
        public void CargarEmpleados()
        {
            try
            {
                DataTable empleados = cn.ObtenerEmpleados();
                Cbo_NombreE.DataSource = empleados;
                Cbo_NombreE.DisplayMember = "NombreEmpleado";
                Cbo_NombreE.ValueMember = "IdEmpleado";
                Cbo_NombreE.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
            }
        }

        // =====================================================
        // Cargar horas extra al DataGridView
        // =====================================================
        public void CargarHorasExtra()
        {
            try
            {
                DataTable dt = cn.MostrarHorasExtra();
                Dvg_HoraE.DataSource = dt;

                // Encabezados más claros
                if (Dvg_HoraE.Columns.Contains("IdHoraExtra"))
                    Dvg_HoraE.Columns["IdHoraExtra"].HeaderText = "ID";
                if (Dvg_HoraE.Columns.Contains("Empleado"))
                    Dvg_HoraE.Columns["Empleado"].HeaderText = "Empleado";
                if (Dvg_HoraE.Columns.Contains("Fecha"))
                    Dvg_HoraE.Columns["Fecha"].HeaderText = "Fecha";
                if (Dvg_HoraE.Columns.Contains("Horas"))
                    Dvg_HoraE.Columns["Horas"].HeaderText = "Horas";
                if (Dvg_HoraE.Columns.Contains("Motivo"))
                    Dvg_HoraE.Columns["Motivo"].HeaderText = "Motivo";
                if (Dvg_HoraE.Columns.Contains("Estado"))
                    Dvg_HoraE.Columns["Estado"].HeaderText = "Estado";

                // Colorear filas según estado
                foreach (DataGridViewRow row in Dvg_HoraE.Rows)
                {
                    string estado = row.Cells["Estado"].Value?.ToString();
                    if (estado == "Aprobado")
                        row.DefaultCellStyle.BackColor = Color.FromArgb(200, 255, 200); // verde suave
                    else
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 220); // rojo suave
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar horas extra: " + ex.Message);
            }
        }

        // =====================================================
        // Buscar por empleado
        // =====================================================
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Cbo_NombreE.Text.Trim();
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    CargarHorasExtra();
                }
                else
                {
                    Dvg_HoraE.DataSource = cn.BuscarPorEmpleado(nombre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar empleado: " + ex.Message);
            }
        }

        // =====================================================
        // Abrir formulario de solicitud
        // =====================================================
        private void Btn_Soli_Click(object sender, EventArgs e)
        {
            var soli = new Frm_Solicitar_Horas_Extras();
            soli.ShowDialog();
            CargarHorasExtra(); // refrescar después de guardar
        }

        // =====================================================
        // Abrir formulario de edición
        // =====================================================
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dvg_HoraE.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un registro para modificar.");
                    return;
                }

                DataGridViewRow row = Dvg_HoraE.SelectedRows[0];

                int id = Convert.ToInt32(row.Cells["IdHoraExtra"].Value);
                string empleado = row.Cells["Empleado"].Value.ToString();
                DateTime fecha = DateTime.Parse(row.Cells["Fecha"].Value.ToString());
                int horas = Convert.ToInt32(row.Cells["Horas"].Value);
                string motivo = row.Cells["Motivo"].Value.ToString();
                bool aprobado = row.Cells["Estado"].Value.ToString() == "Aprobado";

                var editar = new Frm_Editar_Horas_Extras(id, empleado, fecha, horas, motivo, aprobado);
                editar.ShowDialog();

                CargarHorasExtra(); // refrescar al cerrar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir edición: " + ex.Message);
            }
        }

        // =====================================================
        // Eliminar registro
        // =====================================================
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dvg_HoraE.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila para eliminar.");
                    return;
                }

                int id = Convert.ToInt32(Dvg_HoraE.SelectedRows[0].Cells["IdHoraExtra"].Value);

                if (MessageBox.Show("¿Desea eliminar este registro?", "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cn.EliminarHorasExtra(id);
                    MessageBox.Show("Registro eliminado correctamente.");
                    CargarHorasExtra();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
    }
}