using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Creacion_Nomina;

namespace Capa_Vista_Creacion_Nomina
{
    public partial class Frm_Movimientos_Nomina : Form
    {

        public Frm_Movimientos_Nomina(int idNomina)
        {
            InitializeComponent();
            funCargarMovimientos(idNomina);
        }


        private void funCargarMovimientos(int idNomina)
        {
            try
            {
                Console.WriteLine("El id es:" + idNomina);
                Cls_Controlador_Creacion_Nomina controlador = new Cls_Controlador_Creacion_Nomina();

                DataTable dt = controlador.funObtenerMovimientosPorIdNomina(idNomina);

                dataGridView1.Rows.Clear();

                foreach (DataRow fila in dt.Rows)
                {
                    dataGridView1.Rows.Add(
                        fila["IdMovimiento"].ToString(),
                        fila["IdNomina"].ToString(),
                        fila["IdEmpleado"].ToString(),
                        fila["Empleado"].ToString(),
                        fila["Concepto"].ToString(),
                        fila["TipoConcepto"].ToString(),
                        fila["Monto"].ToString()
                    );
                }

                Console.WriteLine($"[OK] Se cargaron {dt.Rows.Count} movimientos para la nómina {idNomina}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] al cargar movimientos: {ex.Message}");
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
