using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Creacion_Nomina;

namespace Capa_Vista_Creacion_Nomina
{
    public partial class Frm_Movimientos_Nomina : Form
    {
        private int idNomina;
        private int idEmpleado;
        private Cls_Controlador_Creacion_Nomina controlador = new Cls_Controlador_Creacion_Nomina();

        public Frm_Movimientos_Nomina(int idNomina, int idEmpleado, string nombreEmpleado)
        {
            InitializeComponent();
            this.idNomina = idNomina;
            this.idEmpleado = idEmpleado;

            this.Text = $"Movimientos de {nombreEmpleado}";
            funCargarMovimientosEmpleado(idNomina, idEmpleado);
        }



        // ==========================================================
        // MÉTODO: CARGAR MOVIMIENTOS DEL EMPLEADO
        // ==========================================================
        private void funCargarMovimientosEmpleado(int idNomina, int idEmpleado)
        {
            try
            {
                Console.WriteLine($"[INFO] Cargando movimientos del empleado {idEmpleado} en nómina {idNomina}");

                DataTable dt = controlador.funObtenerMovimientosPorEmpleado(idNomina, idEmpleado);

                dataGridView1.Rows.Clear();

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        string tipoConcepto = fila["TipoConcepto"].ToString().Trim().ToUpper();
                        double monto = Convert.ToDouble(fila["Monto"]);

                        // Si es percepción, va en Abono (suma)
                        // Si es deducción, va en Cargo (resta)
                        string cargo = tipoConcepto == "DEDUCCION" ? monto.ToString("N2") : "";
                        string abono = tipoConcepto == "PERCEPCION" ? monto.ToString("N2") : "";

                        dataGridView1.Rows.Add(
                            fila["IdMovimiento"].ToString(),
                            fila["IdNomina"].ToString(),
                            fila["IdEmpleado"].ToString(),
                            fila["Empleado"].ToString(),
                            fila["Concepto"].ToString(),
                            fila["TipoConcepto"].ToString(),
                            cargo,
                            abono
                        );
                    }

                    Console.WriteLine($"[OK] Se cargaron {dt.Rows.Count} movimientos para el empleado {idEmpleado}.");
                }
                else
                {
                    MessageBox.Show("No hay movimientos registrados para este empleado en la nómina seleccionada.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar movimientos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
