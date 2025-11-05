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
                        string fechaGeneracion;

                        if (fila.IsNull("Cmp_dFechaGeneracion_Nomina"))
                        {
                            fechaGeneracion = "EN ESPERA";
                        }
                        else
                        {
                            fechaGeneracion = Convert.ToDateTime(fila["Cmp_dFechaGeneracion_Nomina"]).ToString("dd/MM/yyyy");
                        }

                        dataGridView1.Rows.Add(
                            fila["Cmp_iId_Nomina"].ToString(),
                            Convert.ToDateTime(fila["Cmp_dPeriodoInicio_Nomina"]).ToString("dd/MM/yyyy"),
                            Convert.ToDateTime(fila["Cmp_dPeriodoFin_Nomina"]).ToString("dd/MM/yyyy"),
                            fechaGeneracion,
                            fila["Cmp_sTipo_Nomina"].ToString(),
                            fila["Cmp_sEstado_Nomina"].ToString()
                        );
                    }
                }
                else
                {
                    Console.WriteLine("No hay nóminas registradas.");
                    button3.Enabled = false;
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
            if (id_nomina <= 0)
            {
                MessageBox.Show("Debe seleccionar una nómina válida antes de calcular.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación del usuario
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea calcular la nómina seleccionada?\n\nEste proceso generará los detalles de pago para cada empleado.",
                "Confirmar cálculo de nómina",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    // Buscar la fila seleccionada o, si no, buscar por ID
                    DataGridViewRow fila = null;

                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        fila = dataGridView1.SelectedRows[0];
                    }
                    else
                    {
                        foreach (DataGridViewRow r in dataGridView1.Rows)
                        {
                            if (r.Cells[0].Value != null && Convert.ToInt32(r.Cells[0].Value) == id_nomina)
                            {
                                fila = r;
                                break;
                            }
                        }
                    }

                    if (fila == null)
                    {
                        MessageBox.Show("No se pudo obtener la nómina seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Obtener fechas del periodo desde el DataGridView
                    DateTime dInicio = Convert.ToDateTime(fila.Cells[1].Value);
                    DateTime dFin = Convert.ToDateTime(fila.Cells[2].Value);

                    // Llamar al método de cálculo en el controlador
                    clsControlador.proCalcularNomina(id_nomina, dInicio, dFin);

                    MessageBox.Show("✅ Nómina calculada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refrescar datos y botones
                    funCargarNominas();
                    button1.Enabled = true;
                    button2.Enabled = false;
                    button3.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al calcular la nómina: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada por el usuario.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                Frm_Detalle_Nomina frm = new Frm_Detalle_Nomina(id_nomina);
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
                    // Obtener los valores de la fila seleccionada
                    DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                    id_nomina = Convert.ToInt32(filaSeleccionada.Cells[0].Value);

                    string estadoNomina = filaSeleccionada.Cells[5].Value.ToString().Trim().ToUpper();

                    // Reglas de habilitación de botones
                    if (estadoNomina == "GENERADA")
                    {
                        button3.Enabled = true;   
                        button2.Enabled = false; 
                    }
                    else if (estadoNomina == "PENDIENTE")
                    {
                        button2.Enabled = true;
                        button3.Enabled = false;
                    }
                    else
                    {
                        button2.Enabled = false;
                        button3.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] al seleccionar nómina: {ex.Message}");
                button1.Enabled = false;
                button3.Enabled = false;
            }
        }

    }
}
