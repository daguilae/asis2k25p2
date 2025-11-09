using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Capa_Controlador_CB;

namespace Capa_Vista_CB
{
    public partial class Frm_BuscarConciliacion : Form
    {
        private readonly Cls_Controlador_Conciliacion gControlador = new Cls_Controlador_Conciliacion();

        public Frm_BuscarConciliacion()
        {
            InitializeComponent();
            // ENLACE SEGURO: si ya lo uniste con el diseñador (⚡), no lo dupliques.
            this.Load += Frm_BuscarConciliacion_Load;
        }

        private void Frm_BuscarConciliacion_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void Btn_AyudaBC_Click(object sender, EventArgs e)
        {
            // Aún no se programa
        }

        private void Btn_SalirBuscarCB_Click(object sender, EventArgs e)
        {
            // Regresar al formulario principal si existe
            var frmPrincipal = Application.OpenForms.OfType<Frm_ConciliacionBancaria>().FirstOrDefault();
            if (frmPrincipal != null)
            {
                frmPrincipal.Show();
                frmPrincipal.Activate();
            }
            else
            {
                new Frm_ConciliacionBancaria().Show();
            }
            this.Close();
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            // Aún no se programa
        }

        private void Btn_ModificarSeleccion_Click(object sender, EventArgs e)
        {
            int iIdConciliacion = ObtenerIdSeleccionado();
            if (iIdConciliacion <= 0)
            {
                MessageBox.Show("Seleccione una conciliación de la tabla.");
                return;
            }

            var frmPrincipal = Application.OpenForms.OfType<Frm_ConciliacionBancaria>().FirstOrDefault();
            if (frmPrincipal == null)
                frmPrincipal = new Frm_ConciliacionBancaria();

            frmPrincipal.Show();
            frmPrincipal.Activate();
            frmPrincipal.CargarConciliacionPorId(iIdConciliacion);
            this.Close();
        }

        private void Btn_EliminarCB_Click(object sender, EventArgs e)
        {
            int iIdConciliacion = ObtenerIdSeleccionado();
            if (iIdConciliacion <= 0)
            {
                MessageBox.Show("Seleccione una conciliación de la tabla.");
                return;
            }

            var dr = MessageBox.Show("¿Desea eliminar la conciliación seleccionada?",
                                     "Confirmación",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    gControlador.EliminarConciliacion(iIdConciliacion);
                    MessageBox.Show("Conciliación eliminada correctamente.");
                    ActualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar: " + ex.Message);
                }
            }
        }

        private void Dgv_Conciliaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void ActualizarGrid()
        {
            try
            {
                DataTable dtConciliaciones = gControlador.ObtenerConciliaciones();
                Dgv_Conciliaciones.AutoGenerateColumns = true;
                Dgv_Conciliaciones.DataSource = dtConciliaciones;

                // Formato amigable
                if (Dgv_Conciliaciones.Columns.Count > 0)
                {
                    SetHeader("Pk_Id_Conciliacion", "ID");
                    SetHeader("Fk_Id_Banco", "Banco (Id)");
                    SetHeader("Fk_Id_CuentaBancaria", "Cuenta (Id)");
                    SetHeader("Cmp_AnioConciliacion", "Año");
                    SetHeader("Cmp_MesConciliacion", "Mes");
                    SetHeader("Cmp_FechaConciliacion", "Fecha");
                    SetHeader("Cmp_SaldoBanco", "Saldo Banco");
                    SetHeader("Cmp_SaldoSistema", "Saldo Sistema");
                    SetHeader("Cmp_Diferencia", "Diferencia");
                    SetHeader("Cmp_Observaciones", "Observaciones");
                    SetHeader("Cmp_EstadoConciliacion", "Estado");
                }


                Dgv_Conciliaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Dgv_Conciliaciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                Dgv_Conciliaciones.AllowUserToAddRows = false;
                Dgv_Conciliaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Dgv_Conciliaciones.MultiSelect = false;
                Dgv_Conciliaciones.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar conciliaciones: " + ex.Message);
            }
        }

        private void SetHeader(string sColName, string sHeader)
        {
            if (Dgv_Conciliaciones.Columns.Contains(sColName))
                Dgv_Conciliaciones.Columns[sColName].HeaderText = sHeader;
        }

        private int ObtenerIdSeleccionado()
        {
            if (Dgv_Conciliaciones.CurrentRow == null) return 0;
            var cell = Dgv_Conciliaciones.CurrentRow.Cells["Pk_Id_Conciliacion"];
            if (cell == null || cell.Value == null || cell.Value == DBNull.Value) return 0;

            int id;
            return int.TryParse(cell.Value.ToString(), out id) ? id : 0;
        }
    }
}

