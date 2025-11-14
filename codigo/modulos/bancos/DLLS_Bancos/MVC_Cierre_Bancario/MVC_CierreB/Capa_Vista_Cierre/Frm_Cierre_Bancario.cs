using System;
using System.Windows.Forms;
using Capa_Controlador_Cierre;

namespace Capa_Vista_Cierre
{
    //================================= KEVIN NATARENO, 0901-21-635 =================================================
    public partial class Frm_Cierre_Bancario : Form
    {
        private readonly Cls_Controlador_Cierre objControlador = new Cls_Controlador_Cierre();

        public Frm_Cierre_Bancario()
        {
            InitializeComponent();
            fun_cargar_cuentas();
            fun_cargar_meses();
        }

        private void Frm_Cierre_Bancario_Load(object sender, EventArgs e)
        {
            CargarCierres();
        }

        // =============================
        // Carga de datos iniciales
        // =============================
        private void fun_cargar_meses()
        {
            Cbo_Mes.Items.Clear();

            Cbo_Mes.Items.Add("Enero");
            Cbo_Mes.Items.Add("Febrero");
            Cbo_Mes.Items.Add("Marzo");
            Cbo_Mes.Items.Add("Abril");
            Cbo_Mes.Items.Add("Mayo");
            Cbo_Mes.Items.Add("Junio");
            Cbo_Mes.Items.Add("Julio");
            Cbo_Mes.Items.Add("Agosto");
            Cbo_Mes.Items.Add("Septiembre");
            Cbo_Mes.Items.Add("Octubre");
            Cbo_Mes.Items.Add("Noviembre");
            Cbo_Mes.Items.Add("Diciembre");

            Cbo_Mes.SelectedIndex = 0;
        }

        private void fun_cargar_cuentas()
        {
            Cbo_Cuenta.DataSource = objControlador.fun_obtener_cuentas();
            Cbo_Cuenta.DisplayMember = "Cmp_NumeroCuenta";
            Cbo_Cuenta.ValueMember = "Pk_Id_CuentaBancaria";
        }


        private void Btn_Guardar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return; // Validamos antes de continuar

            try
            {
                objControlador.fun_guardar_cierre(
                    Convert.ToInt32(Cbo_Cuenta.SelectedValue),
                    Convert.ToInt32(Nud_Anio.Value),
                    Cbo_Mes.SelectedIndex + 1,
                    decimal.Parse(Txt_SaldoI.Text),
                    decimal.Parse(Txt_SaldoF.Text),
                    decimal.Parse(Txt_SaldoC.Text),
                    "PENDIENTE",
                    Txt_Obs.Text,
                    Environment.UserName
                );

                MessageBox.Show("Cierre guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // recargar grilla
                CargarCierres();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Anular_Click_1(object sender, EventArgs e)
        {
            if (Dgv_CierreB.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un registro.");
                return;
            }

            int iId = Convert.ToInt32(Dgv_CierreB.CurrentRow.Cells["Pk_Id_Cierre"].Value);

            objControlador.fun_anular_cierre(iId, Environment.UserName);

            MessageBox.Show("Cierre anulado.");

            Btn_Buscar.PerformClick();
        }

        private void Btn_Cerrar_Click_1(object sender, EventArgs e)
        {
            if (Dgv_CierreB.CurrentRow == null) return;

            int iId = Convert.ToInt32(Dgv_CierreB.CurrentRow.Cells["Pk_Id_Cierre"].Value);

            objControlador.fun_cerrar_cierre(iId, Environment.UserName);

            // Actualizar la fila en el DataGridView
            Dgv_CierreB.CurrentRow.Cells["Cmp_Estado"].Value = "CERRADO";
            Dgv_CierreB.CurrentRow.Cells["Cmp_FechaCierre"].Value = DateTime.Now;

            MessageBox.Show("Cierre cerrado.");
        }

        private void Btn_Buscar_Click_1(object sender, EventArgs e)
        {
            int iCuenta = Convert.ToInt32(Cbo_Cuenta.SelectedValue);
            int iAnio = Convert.ToInt32(Nud_Anio.Value);
            int iMes = Cbo_Mes.SelectedIndex + 1;

            Dgv_CierreB.DataSource = objControlador.fun_obtener_cierres(iCuenta, iAnio, iMes);
        }

        private void CargarCierres()
        {
            Dgv_CierreB.DataSource = objControlador.fun_obtener_todos_cierres();
        }


        private bool ValidarDatos() // Estas validaciones son antes de enviar datos al controlador, por eso estan en esta capa
        {
            
            if (Cbo_Cuenta.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una cuenta bancaria.");
                return false;
            }

           
            if (Cbo_Mes.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un mes.");
                return false;
            }

           
         

          
            decimal dSaldoI, dSaldoF, dSaldoC;
            if (!decimal.TryParse(Txt_SaldoI.Text, out dSaldoI))
            {
                MessageBox.Show("Saldo Inicial no es válido.");
                return false;
            }
            if (!decimal.TryParse(Txt_SaldoF.Text, out dSaldoF))
            {
                MessageBox.Show("Saldo Final no es válido.");
                return false;
            }
            if (!decimal.TryParse(Txt_SaldoC.Text, out dSaldoC))
            {
                MessageBox.Show("Saldo Conciliado no es válido.");
                return false;
            }

           
            if (dSaldoI < 0 || dSaldoF < 0 || dSaldoC < 0)
            {
                MessageBox.Show("Los saldos no pueden ser negativos.");
                return false;
            }

            return true;
        }

    }
}
