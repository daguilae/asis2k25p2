using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using Capa_Controlador_Vacaciones;
using Capa_Modelo_Vacaciones;

namespace Capa_Vista_Vacaciones
{
    public partial class ucVacaciones : UserControl
    {
        private readonly Controlador controlador = new Controlador();

        public ucVacaciones()
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
                Dvg_HoraE.DataSource = controlador.BuscarVacaciones(id);
                RenombrarColumnas();
            }
        }

        private void RenombrarColumnas()
        {
            if (Dvg_HoraE.Columns.Contains("Cmp_iId_Vacacion"))
                Dvg_HoraE.Columns["Cmp_iId_Vacacion"].HeaderText = "ID Vacación";
            if (Dvg_HoraE.Columns.Contains("Cmp_iId_Empleado"))
                Dvg_HoraE.Columns["Cmp_iId_Empleado"].HeaderText = "ID Empleado";
            if (Dvg_HoraE.Columns.Contains("Cmp_dFechaInicio_Vacacion"))
                Dvg_HoraE.Columns["Cmp_dFechaInicio_Vacacion"].HeaderText = "Fecha Inicio";
            if (Dvg_HoraE.Columns.Contains("Cmp_dFechaFin_Vacacion"))
                Dvg_HoraE.Columns["Cmp_dFechaFin_Vacacion"].HeaderText = "Fecha Fin";
            if (Dvg_HoraE.Columns.Contains("Cmp_iDias_Vacacion"))
                Dvg_HoraE.Columns["Cmp_iDias_Vacacion"].HeaderText = "Días";
            if (Dvg_HoraE.Columns.Contains("Cmp_bAprobada_Vacacion"))
                Dvg_HoraE.Columns["Cmp_bAprobada_Vacacion"].HeaderText = "Aprobada";
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            RefrescarGridEmpleadoActual();
        }

        private void Btn_Soli_Click(object sender, EventArgs e)
        {
            var formSolicitar = new SolicitarVacaciones();
            formSolicitar.FormClosed += (s, args) => RefrescarGridEmpleadoActual();
            formSolicitar.Show();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            var row = Dvg_HoraE.CurrentRow ?? (Dvg_HoraE.SelectedRows.Count > 0 ? Dvg_HoraE.SelectedRows[0] : null);
            if (row == null || !Dvg_HoraE.Columns.Contains("Cmp_iId_Vacacion"))
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

            var formEditar = new EditarVacaciones(idVacacion);
            formEditar.FormClosed += (s, args) => RefrescarGridEmpleadoActual();
            formEditar.Show();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            var row = Dvg_HoraE.CurrentRow ?? (Dvg_HoraE.SelectedRows.Count > 0 ? Dvg_HoraE.SelectedRows[0] : null);
            if (row == null || !Dvg_HoraE.Columns.Contains("Cmp_iId_Vacacion"))
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
                string resultado = controlador.EliminarVacacion(idVacacion);
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK,
                    resultado.Contains("correctamente") ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (resultado.Contains("correctamente"))
                    RefrescarGridEmpleadoActual();
            }
        }

        private void ucVacaciones_Load(object sender, EventArgs e) { }
        private void Dvg_HoraE_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}