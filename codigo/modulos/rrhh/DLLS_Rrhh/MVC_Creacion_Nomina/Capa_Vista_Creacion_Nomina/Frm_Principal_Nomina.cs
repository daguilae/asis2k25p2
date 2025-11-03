// =============================================================
// Capa_Vista_Creacion_Nomina
// Clase: Frm_Principal_Nomina
// Autor: Fredy Reyes Sabán
// Carné: 0901-22-9800
// Fecha: 29/10/2025
// =============================================================

using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Creacion_Nomina; // Importar el controlador

namespace Capa_Vista_Creacion_Nomina
{
    public partial class Frm_Principal_Nomina : UserControl
    {
        // Instancia del controlador
        private Cls_Controlador_Creacion_Nomina clsControlador = new Cls_Controlador_Creacion_Nomina();

        public Frm_Principal_Nomina()
        {
            InitializeComponent();
            funCargarNominas();
        }

        // ==========================================================
        // MÉTODO: CARGAR DATOS EN EL DATAGRIDVIEW
        // ==========================================================

        // Inicio de código de: Fredy Reyes Sabán en la fecha de: 29/10/2025
        private void funCargarNominas()
        {
            try
            {
                DataTable dtsNominas = clsControlador.funObtenerTodasLasNominas();
                dataGridView1.Rows.Clear();

                if (dtsNominas != null && dtsNominas.Rows.Count > 0)
                {
                    foreach (DataRow fila in dtsNominas.Rows)
                    {
                        dataGridView1.Rows.Add(
                            fila["Cmp_iId_Nomina"].ToString(),
                            Convert.ToDateTime(fila["Cmp_dPeriodoInicio_Nomina"]).ToString("dd/MM/yyyy"),
                            Convert.ToDateTime(fila["Cmp_dPeriodoFin_Nomina"]).ToString("dd/MM/yyyy"),
                            Convert.ToDateTime(fila["Cmp_dFechaGeneracion_Nomina"]).ToString("dd/MM/yyyy"),
                            fila["Cmp_sTipo_Nomina"].ToString(),
                            fila["Cmp_sEstado_Nomina"].ToString()
                        );
                    }
                }
                else
                {
                    Console.WriteLine("No hay nóminas registradas.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar las nóminas: {ex.Message}");
            }
        }

        // Fin de código de: Fredy Reyes Sabán en la fecha de: 29/10/2025


        // ==========================================================
        // EVENTOS DE BOTONES
        // ==========================================================

        private void button1_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar la funcionalidad de “Generar Nómina”
            MessageBox.Show("Función para generar nómina en desarrollo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Abrir formulario de creación
            Frm_Creacion_Nomina frm_Creacion_Nomina = new Frm_Creacion_Nomina();
            frm_Creacion_Nomina.ShowDialog();

            // Refrescar la tabla después de crear una nueva nómina
            funCargarNominas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función de movimientos aún no implementada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
