using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Creacion_Nomina;

namespace Capa_Vista_Creacion_Nomina
{
    public partial class Frm_Principal_Nomina : UserControl
    {
        private int id_nomina = -1; // Valor inicial sin selección
        private Cls_Controlador_Creacion_Nomina clsControlador = new Cls_Controlador_Creacion_Nomina();

        public Frm_Principal_Nomina()
        {
            InitializeComponent();
            button3.Enabled = false; 
            funCargarNominas();
        }

        // ==========================================================
        // MÉTODO: CARGAR DATOS EN EL DATAGRIDVIEW
        // ==========================================================
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
                    button3.Enabled = false; // Si no hay datos, mantener deshabilitado
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar las nóminas: {ex.Message}");
            }
        }

        // ==========================================================
        // EVENTOS DE BOTONES
        // ==========================================================
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función para generar nómina en desarrollo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Creacion_Nomina frm_Creacion_Nomina = new Frm_Creacion_Nomina();
            frm_Creacion_Nomina.ShowDialog();
            funCargarNominas();
            button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id_nomina > 0)
            {
                Frm_Movimientos_Nomina frm = new Frm_Movimientos_Nomina(id_nomina);
                frm.ShowDialog();
            }
            else
            {
                Console.WriteLine("No hay una nómina seleccionada válida.");
            }
        }

        // ==========================================================
        // EVENTO: SELECCIÓN DE FILA EN GRID
        // ==========================================================
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int iIdNomina = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    id_nomina = iIdNomina;
                    Console.WriteLine($"[OK] Nómina seleccionada: {id_nomina}");
                    button3.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] al seleccionar nómina: {ex.Message}");
                button3.Enabled = false;
            }
        }
    }
}
