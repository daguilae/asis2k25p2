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
using System.Data;
using System.Data.Odbc;

//REALIZADO POR ROCIO LOPEZ 

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
            //  Validar banco seleccionado ANTES de hacer lote
            if (Cmb_CodigoCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un banco antes de cargar los datos.",
                                "Banco requerido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

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
//esto solo es una prueba 
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
              try
                {
                    using (OdbcConnection cn = new OdbcConnection("Dsn=Bd_Hoteleria"))
                    {
                        cn.Open();
                        OdbcCommand cmd = new OdbcCommand(
                            "INSERT INTO Tbl_DetalleLoteCheques (Fk_Id_Lote, Cmp_NumeroCheque, Cmp_NombreEmpleado, Cmp_Monto) " +
                            "VALUES (1, 9999, 'PRUEBA', 123.45)", cn);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("✅ Insert PRUEBA completado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ ERROR MySQL: " + ex.Message);
                }
            
        }


        private void btn_Generar_Cheque_Click(object sender, EventArgs e)
        {
            // 1. Validar banco seleccionado
            if (Cmb_CodigoCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un banco antes de generar los cheques.",
                                "Banco requerido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // ❌ Bloquea la operación
            }

            //  Si sí seleccionó banco, seguimos
            int idBanco = Convert.ToInt32(Cmb_CodigoCuenta.SelectedValue);

            Cls_Controlador_Cheques control = new Cls_Controlador_Cheques();

            // empleados simulados
            List<Empleado> empleados = control.ObtenerEmpleadosSimulados();

            int idLote = control.CrearLote("Rocio");
            control.GenerarChequesCompletos("Rocio", idLote, idBanco, empleados);
            MessageBox.Show("✅ Cheques generados");

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


        private void Lbl_Fecha_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Cheques_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable bancos = cn.ObtenerListaBancos();
                Cmb_CodigoCuenta.DataSource = bancos;
                Cmb_CodigoCuenta.DisplayMember = "Banco"; // lo que ve el usuario
                Cmb_CodigoCuenta.ValueMember = "ID";      // valor real
                Cmb_CodigoCuenta.SelectedIndex = -1;      // nada seleccionado
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los bancos: " + ex.Message);
            }
        }
    }
}
