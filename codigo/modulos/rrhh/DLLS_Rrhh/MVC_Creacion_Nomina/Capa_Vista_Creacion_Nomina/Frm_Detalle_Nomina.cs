using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Creacion_Nomina;

namespace Capa_Vista_Creacion_Nomina
{
    public partial class Frm_Detalle_Nomina : Form
    {
        private Cls_Controlador_Creacion_Nomina clsControlador = new Cls_Controlador_Creacion_Nomina();
        private int idNominaSeleccionada;

        public Frm_Detalle_Nomina(int idNomina)
        {
            InitializeComponent();
            idNominaSeleccionada = idNomina;
            funCargarDetalleNomina(idNomina);
        }

        // ==========================================================
        // CARGAR DETALLE DE NÓMINA
        // ==========================================================
        private void funCargarDetalleNomina(int idNomina)
        {
            try
            {
                DataTable dtsDetalle = clsControlador.funObtenerDetalleNomina(idNomina);
                dataGridView1.Rows.Clear();

                if (dtsDetalle != null && dtsDetalle.Rows.Count > 0)
                {
                    foreach (DataRow fila in dtsDetalle.Rows)
                    {
                        dataGridView1.Rows.Add(
                            fila["Nomina"].ToString(),
                            fila["IdEmpleado"].ToString(),
                            fila["Empleado"].ToString(),
                            fila["Ausencias"].ToString(),
                            fila["DiasLaborados"].ToString(),
                            fila["Percepciones"].ToString(),
                            fila["Deducciones"].ToString(),
                            fila["SueldoLiquido"].ToString()
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros para esta nómina.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el detalle de la nómina: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
        
        }

        // ==========================================================
        // EVENTO: AL CAMBIAR SELECCIÓN → ABRIR MOVIMIENTOS
        // ==========================================================
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow fila = dataGridView1.SelectedRows[0];

                    int idNomina = Convert.ToInt32(fila.Cells["nomina"].Value);
                    int idEmpleado = Convert.ToInt32(fila.Cells["codigo_empleado"].Value);
                    string nombreEmpleado = fila.Cells["empleado"].Value.ToString();

                    Frm_Movimientos_Nomina frmMov = new Frm_Movimientos_Nomina(idNomina, idEmpleado, nombreEmpleado);
                    frmMov.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] al abrir movimientos: {ex.Message}");
            }
        }
    }
}
