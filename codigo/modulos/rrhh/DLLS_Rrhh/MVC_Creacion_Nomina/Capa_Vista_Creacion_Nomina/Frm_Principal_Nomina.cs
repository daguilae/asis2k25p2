// =============================================================
// Capa_Vista_Creacion_Nomina
// Clase: Frm_Principal_Nomina
// Autor: Fredy Reyes Sabán
// Carné: 20250000
// Fecha: 29/10/2025
// Descripción: Formulario principal para visualizar, crear y generar
//              nóminas. Muestra los registros de Tbl_Nomina en un DataGridView
//              y se conecta al controlador Cls_Controlador_Creacion_Nomina.
// =============================================================

using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Creacion_Nomina; // Importar el controlador

namespace Capa_Vista_Creacion_Nomina
{
    public partial class Frm_Principal_Nomina : Form
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
                // Obtener los datos desde el controlador
                DataTable dtsNominas = clsControlador.funObtenerTodasLasNominas();

                // Limpiar las filas actuales
                dataGridView1.Rows.Clear();

                // Validar si hay datos
                if (dtsNominas != null && dtsNominas.Rows.Count > 0)
                {
                    foreach (DataRow fila in dtsNominas.Rows)
                    {
                        // Agregar una nueva fila al DataGridView
                        dataGridView1.Rows.Add(
                            fila["Cmp_iNomina"].ToString(),
                            Convert.ToDateTime(fila["Cmp_dPeriodoInicioNomina"]).ToString("dd/MM/yyyy"),
                            Convert.ToDateTime(fila["Cmp_dPeriodoFinNomina"]).ToString("dd/MM/yyyy"),
                            Convert.ToDateTime(fila["Cmp_dFechaGeneracionNomina"]).ToString("dd/MM/yyyy"),
                            fila["Cmp_vTipoNomina"].ToString(),
                            fila["Cmp_vEstadoNomina"].ToString()
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No hay nóminas registradas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al cargar las nóminas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
