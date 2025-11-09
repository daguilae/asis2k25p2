using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Controlador_Cheques;
using System.Data;


namespace Capa_Vista_Cheques
{
    public partial class Frm_Cheques : Form
    {
        Cls_Controlador_Cheques cn = new Cls_Controlador_Cheques();
        string tabla = "";
        public Frm_Cheques()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txt_Banco_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Cargar_Click(object sender, EventArgs e)
        {
            Cls_Controlador_Cheques ctrl = new Cls_Controlador_Cheques();

            // Obtener empleados simulados
            List<Empleado> empleados = ctrl.ObtenerEmpleadosSimulados();

            // Mostrar en el DataGridView
            dgv_Cheques.DataSource = empleados;
            string usuario = "Rocio";

            int idLote = ctrl.CrearLote(usuario);

            if (idLote > 0)
                MessageBox.Show("✅ Lote creado correctamente");
            else
                MessageBox.Show("❌ Error al crear el lote");

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Txt_debe_haber_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_nombre_banco_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Cuenta_Contable_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {

        }

        private void btn_Generar_Cheque_Click(object sender, EventArgs e)
        {
            // 1️ Crear instancia del controlador
            Capa_Controlador_Cheques.Cls_Controlador_Cheques control = new Capa_Controlador_Cheques.Cls_Controlador_Cheques();

            // 2️ Obtener los empleados simulados
            List<Empleado> empleados = control.ObtenerEmpleadosSimulados();


            // 2. Generar el lote y guardar los cheques en la BD
            bool exito = control.GenerarLoteConCheques("Rocio", empleados);


            // 3️ Recorrer cada empleado y generar su cheque
            int numeroCheque = 1;

            foreach (var emp in empleados)
            {
                // Simular la creación de un cheque
                string infoCheque = $"Cheque #{numeroCheque}\n" +
                                    $"Nombre: {emp.Nombre}\n" +
                                    $"Monto: Q{emp.MontoPagar}\n";

                MessageBox.Show(infoCheque, "Cheque generado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                numeroCheque++;
            }

        }

        private void Txt_Valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_planilla_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Moneda_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Moneda_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Fecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Fecha_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
