using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using Capa_Controlador_Vacaciones;
using Capa_Modelo_Vacaciones;

namespace Capa_Vista_Vacaciones
{
    public partial class SolicitarVacaciones : Form
    {
        private Controlador controlador = new Controlador();

        public SolicitarVacaciones()
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

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Cbo_Empleado.SelectedValue == null || !int.TryParse(Cbo_Empleado.SelectedValue.ToString(), out int idEmpleado))
            {
                MessageBox.Show("Seleccione un empleado válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Dtp_FechaI.Value >= Dtp_FechaF.Value)
            {
                MessageBox.Show("Fecha inicio debe ser menor que fecha final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string resultado = controlador.SolicitarVacaciones(idEmpleado, Dtp_FechaI.Value, Dtp_FechaF.Value);
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK,
                resultado.Contains("correctamente") ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (resultado.Contains("correctamente"))
            {
                this.Close();  // Cierra y dispara FormClosed en el UC
            }
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dtp_FechaF_ValueChanged(object sender, EventArgs e)
        {
            if (Dtp_FechaI.Value < Dtp_FechaF.Value)
            {
                int dias = (Dtp_FechaF.Value - Dtp_FechaI.Value).Days + 1;
                Nud_Dias.Value = dias;
            }
            else
            {
                Nud_Dias.Value = 0;
            }
        }

        private void Pnl_encabezado_Paint(object sender, PaintEventArgs e) { }
    }
}