// Nombre: Jose Pablo Medina González
// Carné: 0901-22-2592
// Fecha de modificación: 2025-11-09
// Descripción: Form para editar una vacación existente.

using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using Capa_Controlador_Vacaciones;
using Capa_Modelo_Vacaciones;

namespace Capa_Vista_Vacaciones
{
    public partial class Frm_Editar_Vacaciones_Nomina : Form
    {
        private readonly Controlador _controlador = new Controlador();
        private readonly int _idVacacion;

        public Frm_Editar_Vacaciones_Nomina(int idVacacion)
        {
            InitializeComponent();
            _idVacacion = idVacacion;
            CargarEmpleados();
            CargarDatos();
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
                    Cbo_Empleado.DataSource = dt;
                    Cbo_Empleado.DisplayMember = "nombre";
                    Cbo_Empleado.ValueMember = "pk_idEmpleado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message, "BD",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatos()
        {
            DataRow row = _controlador.CargarVacacion(_idVacacion);
            if (row != null)
            {
                Cbo_Empleado.SelectedValue = row["Cmp_iId_Empleado"];
                Dtp_FechaI.Value = Convert.ToDateTime(row["Cmp_dFechaInicio_Vacacion"]);
                Dtp_FechaF.Value = Convert.ToDateTime(row["Cmp_dFechaFin_Vacacion"]);
                Nud_Dias.Value = Convert.ToDecimal(row["Cmp_iDias_Vacacion"]);
            }
            else
            {
                MessageBox.Show("No se encontró la vacación.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Dtp_FechaI.Value >= Dtp_FechaF.Value)
            {
                MessageBox.Show("Fecha inicio debe ser menor que fecha final.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string resultado = _controlador.EditarVacacion(_idVacacion, Dtp_FechaI.Value, Dtp_FechaF.Value);
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK,
                resultado.Contains("correctamente") ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (resultado.Contains("correctamente"))
                Close();
        }

        private void Btn_Regresar_Click(object sender, EventArgs e) => Close();

        private void Dtp_FechaF_ValueChanged(object sender, EventArgs e)
        {
            if (Dtp_FechaI.Value < Dtp_FechaF.Value)
                Nud_Dias.Value = (Dtp_FechaF.Value - Dtp_FechaI.Value).Days + 1;
            else
                Nud_Dias.Value = 0;
        }

        private void Gpb_EditarV_Enter(object sender, EventArgs e) { }
        private void Pnl_encabezado_Paint(object sender, PaintEventArgs e) { }
    }
}