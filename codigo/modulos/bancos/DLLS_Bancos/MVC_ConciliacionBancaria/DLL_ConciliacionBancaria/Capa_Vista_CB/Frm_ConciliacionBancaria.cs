using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_CB;

namespace Capa_Vista_CB
{
    public partial class Frm_ConciliacionBancaria : Form
    {

        // Instancia global del controlador
        Cls_Controlador_Conciliacion gControlador = new Cls_Controlador_Conciliacion();

        public Frm_ConciliacionBancaria()
        {
            InitializeComponent();
        }

        // ==========================================================
        // CARGAS DE DATOS
        // ==========================================================
        private void fun_cargar_bancos()
        {
            try
            {
                DataTable dtBancos = gControlador.fun_cargar_bancos();
                Cbo_Bancos.DisplayMember = "Cmp_NombreBanco";
                Cbo_Bancos.ValueMember = "Pk_Id_Banco";
                Cbo_Bancos.DataSource = dtBancos;
                Cbo_Bancos.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar bancos: " + ex.Message);
            }
        }
        private void Frm_ConciliacionBancaria_Load(object sender, EventArgs e)
        {
            fun_cargar_bancos();
            Cbo_Mes.SelectedIndex = 0;
            Txt_Anio.Text = DateTime.Now.Year.ToString();
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            // Aun no programado
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_BuscarConciliacion_Click(object sender, EventArgs e)
        {
            Frm_BuscarConciliacion frmBuscar = new Frm_BuscarConciliacion();
            frmBuscar.Show();
            this.Hide();
        }

        private void Btn_LimpiarCampos_Click(object sender, EventArgs e)
        {
            Cbo_Bancos.SelectedIndex = -1;
            Cbo_Cuenta.DataSource = null;
            Txt_SaldoBanco.Clear();
            Txt_SaldoLibros.Clear();
            Txt_Diferencias.Clear();
            Txt_Observaciones.Clear();
            Chk_Estado.Checked = true;
            Dgv_MovimientoBancario.DataSource = null;
            Dgv_ConciliacionesAgregadas.Rows.Clear();
        }

        private void Cbo_Bancos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Bancos.SelectedValue != null)
            {
                int idBanco = Convert.ToInt32(Cbo_Bancos.SelectedValue);
                DataTable dtCuentas = gControlador.fun_cargar_cuentas(idBanco);
                Cbo_Cuenta.DisplayMember = "Cmp_NumeroCuenta";
                Cbo_Cuenta.ValueMember = "Pk_Id_CuentaBancaria";
                Cbo_Cuenta.DataSource = dtCuentas;
                Cbo_Cuenta.SelectedIndex = -1;
            }
        }

        private void Cbo_Cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Cuenta.SelectedValue != null)
            {
                int idCuenta = Convert.ToInt32(Cbo_Cuenta.SelectedValue);
                DataTable dtMovimientos = gControlador.fun_cargar_movimientos(idCuenta);
                Dgv_MovimientoBancario.DataSource = dtMovimientos;
            }
        }

        private void Dtp_FechaConciliacion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cbo_Mes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Anio_TextChanged(object sender, EventArgs e)
        {

        }

        private void fun_calcular_diferencia()
        {
            try
            {
                // Intenta convertir ambos valores a decimal
                decimal saldoBanco = 0;
                decimal saldoSistema = 0;

                // Evita errores si las cajas están vacías o contienen texto no numérico
                decimal.TryParse(Txt_SaldoBanco.Text, out saldoBanco);
                decimal.TryParse(Txt_SaldoLibros.Text, out saldoSistema);

                // Llama al método del controlador para obtener la diferencia
                decimal diferencia = gControlador.fun_calcular_diferencia(saldoBanco, saldoSistema);

                // Muestra la diferencia formateada con 2 decimales
                Txt_Diferencias.Text = diferencia.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular diferencia: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_SaldoBanco_TextChanged(object sender, EventArgs e)
        {
            fun_calcular_diferencia();
        }

        private void Txt_SaldoLibros_TextChanged(object sender, EventArgs e)
        {
            fun_calcular_diferencia();
        }

        private void Txt_Diferencias_TextChanged(object sender, EventArgs e)
        {
            decimal.TryParse(Txt_SaldoBanco.Text, out decimal saldoBanco);
            decimal.TryParse(Txt_SaldoLibros.Text, out decimal saldoSistema);
            Txt_Diferencias.Text = gControlador.fun_calcular_diferencia(saldoBanco, saldoSistema).ToString("N2");
        }

        private void Txt_Observaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void Chk_Estado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Btn_AgregarMovimiento_Click(object sender, EventArgs e)
        {

        }

        private void Btn_EliminarMovimiento_Click(object sender, EventArgs e)
        {

        }

        private void Cbo_TipoMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dgv_MovimientoBancario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dgv_ConciliacionesAgregadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

