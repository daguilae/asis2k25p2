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
                MessageBox.Show("Debe seleccionar una nómina antes de generar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea generar la nómina seleccionada?",
                "Confirmar generación de nómina",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                // Aquí irá el proceso real de generación de nómina
                MessageBox.Show("La nómina ha sido generada correctamente (simulado).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar la tabla y botones
                funCargarNominas();
                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
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
                    // Obtener los valores de la fila seleccionada
                    DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                    id_nomina = Convert.ToInt32(filaSeleccionada.Cells[0].Value);

                    string estadoNomina = filaSeleccionada.Cells[5].Value.ToString().Trim().ToUpper();

                    Console.WriteLine($"[OK] Nómina seleccionada: {id_nomina} | Estado: {estadoNomina}");

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
