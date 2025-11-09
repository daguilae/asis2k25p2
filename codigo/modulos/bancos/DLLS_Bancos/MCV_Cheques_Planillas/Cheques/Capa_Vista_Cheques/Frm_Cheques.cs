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
            var controlador = new Cls_Controlador_Cheques();

            // 1. Obtener empleados (o desde nómina después)
            List<Empleado> empleados = controlador.ObtenerEmpleadosSimulados();

            // 2. Crear lote
            int idLote = controlador.CrearLote("Rocio");

            // 3. Generar cheques
            controlador.GenerarChequesCompletos("Rocio", idLote, empleados);

            // 4. Mostrar en DataGridView
            dgv_Cheques.DataSource = empleados;

            MessageBox.Show("✅ Cheques generados correctamente.\nLote ID: " + idLote);



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
