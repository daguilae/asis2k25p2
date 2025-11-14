// Nombre: Jose Pablo Medina González
// Carné: 0901-22-2592
// Fecha de modificación: 2025-11-09
// Descripción: UserControl principal para búsqueda y CRUD de vacaciones.

using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using Capa_Controlador_Vacaciones;
using Capa_Modelo_Vacaciones;

namespace Capa_Vista_Vacaciones
{
    public partial class Frm_Prinicpal_Vacaciones_Nomina : UserControl
    {
        private readonly Controlador _controlador = new Controlador();

        public Frm_Prinicpal_Vacaciones_Nomina()
        {
            InitializeComponent();
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            try
            {
                using (var con = new Conexion().ConexionDB())
                using (var cmd = new OdbcCommand(@"
                        SELECT 
                            Cmp_iId_Empleado AS pk_idEmpleado,
                            CONCAT(Cmp_sNombre_Empleado, ' ', Cmp_sApellido_Empleado) AS nombre
                        FROM tbl_empleados;", con))
                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(reader);
                    Cbo_NombreE.DataSource = dt;
                    Cbo_NombreE.DisplayMember = "nombre";
                    Cbo_NombreE.ValueMember = "pk_idEmpleado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message, "BD",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarGridEmpleadoActual()
        {
            if (Cbo_NombreE.SelectedValue != null && int.TryParse(Cbo_NombreE.SelectedValue.ToString(), out int id))
            {
                Dgv_HoraE.DataSource = _controlador.BuscarVacaciones(id);
                RenombrarColumnas();
            }
        }

        private void RenombrarColumnas()
        {
            if (Dgv_HoraE.Columns.Contains("Cmp_iId_Vacacion"))
                Dgv_HoraE.Columns["Cmp_iId_Vacacion"].HeaderText = "ID Vacación";
            if (Dgv_HoraE.Columns.Contains("Cmp_iId_Empleado"))
                Dgv_HoraE.Columns["Cmp_iId_Empleado"].HeaderText = "ID Empleado";
            if (Dgv_HoraE.Columns.Contains("Cmp_dFechaInicio_Vacacion"))
                Dgv_HoraE.Columns["Cmp_dFechaInicio_Vacacion"].HeaderText = "Fecha Inicio";
            if (Dgv_HoraE.Columns.Contains("Cmp_dFechaFin_Vacacion"))
                Dgv_HoraE.Columns["Cmp_dFechaFin_Vacacion"].HeaderText = "Fecha Fin";
            if (Dgv_HoraE.Columns.Contains("Cmp_iDias_Vacacion"))
                Dgv_HoraE.Columns["Cmp_iDias_Vacacion"].HeaderText = "Días";
            if (Dgv_HoraE.Columns.Contains("Cmp_bAprobada_Vacacion"))
                Dgv_HoraE.Columns["Cmp_bAprobada_Vacacion"].HeaderText = "Aprobada";
        }

        private void Btn_buscar_Click(object sender, EventArgs e) => RefrescarGridEmpleadoActual();

        private void Btn_Soli_Click(object sender, EventArgs e)
        {
            var formSolicitar = new Frm_Solicitar_Vacaciones_Nomina();
            formSolicitar.FormClosed += (s, args) => RefrescarGridEmpleadoActual();
            formSolicitar.Show();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            var row = Dgv_HoraE.CurrentRow ?? (Dgv_HoraE.SelectedRows.Count > 0 ? Dgv_HoraE.SelectedRows[0] : null);
            if (row == null || !Dgv_HoraE.Columns.Contains("Cmp_iId_Vacacion"))
            {
                MessageBox.Show("Seleccione una vacación válida.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(row.Cells["Cmp_iId_Vacacion"].Value?.ToString(), out int idVacacion))
            {
                MessageBox.Show("No se pudo leer el ID de la vacación.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var formEditar = new Frm_Editar_Vacaciones_Nomina(idVacacion);
            formEditar.FormClosed += (s, args) => RefrescarGridEmpleadoActual();
            formEditar.Show();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            var row = Dgv_HoraE.CurrentRow ?? (Dgv_HoraE.SelectedRows.Count > 0 ? Dgv_HoraE.SelectedRows[0] : null);
            if (row == null || !Dgv_HoraE.Columns.Contains("Cmp_iId_Vacacion"))
            {
                MessageBox.Show("Seleccione una vacación válida.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(row.Cells["Cmp_iId_Vacacion"].Value?.ToString(), out int idVacacion))
            {
                MessageBox.Show("No se pudo leer el ID de la vacación.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Eliminar esta vacación?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string resultado = _controlador.EliminarVacacion(idVacacion);
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK,
                    resultado.Contains("correctamente") ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (resultado.Contains("correctamente"))
                    RefrescarGridEmpleadoActual();
            }
        }

        private void ucVacaciones_Load(object sender, EventArgs e) { }
        private void Dgv_HoraE_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}