using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_TipoDeCambio;

namespace Capa_Vista_TipoDeCambio
{
    public partial class Frm_IngresoTipoDeCambio1 : Form
    {
        public Frm_IngresoTipoDeCambio1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Frm_IngresoTipoDeCambio_Load);

        }

        Controlador_TipoCambio ctrl = new Controlador_TipoCambio();

        private void Frm_IngresoTipoDeCambio_Load(object sender, EventArgs e)
        {
            Cbo_Moneda.DataSource = ctrl.CargarMonedas();
            Cbo_Moneda.DisplayMember = "Cmp_NombreMoneda";
            Cbo_Moneda.ValueMember = "Pk_Id_Moneda";
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            // --- 1️⃣ Validar que no haya campos vacíos ---
            if (string.IsNullOrWhiteSpace(Txt_Fecha.Text) ||
                string.IsNullOrWhiteSpace(Txt_Compra.Text) ||
                string.IsNullOrWhiteSpace(Txt_Venta.Text) ||
             Cbo_Moneda.SelectedItem == null)
            {
                MessageBox.Show("Por favor, completa todos los campos antes de continuar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- 2️⃣ Validar formato de fecha DD/MM/YYYY ---
            DateTime fechaConvertida;
            bool formatoValido = DateTime.TryParseExact(
                Txt_Fecha.Text,
                "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out fechaConvertida
            );

            if (!formatoValido)
            {
                MessageBox.Show("La fecha no es válida. Usa el formato DD/MM/YYYY, por ejemplo: 05/11/2025", "Error en la fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Fecha.Focus();
                return;
            }

            // --- 3️⃣ Validar que Compra y Venta sean valores numéricos y mayores a 0 ---
            decimal valorCompra, valorVenta;

            if (!decimal.TryParse(Txt_Compra.Text, out valorCompra) || valorCompra <= 0)
            {
                MessageBox.Show("El valor de compra debe ser un número mayor a 0.", "Error en compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Compra.Focus();
                return;
            }

            if (!decimal.TryParse(Txt_Venta.Text, out valorVenta) || valorVenta <= 0)
            {
                MessageBox.Show("El valor de venta debe ser un número mayor a 0.", "Error en venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Venta.Focus();
                return;
            }



            // --- 5️⃣ Si todo está correcto, guardar los datos ---
            try
            {
                string fechaSQL = fechaConvertida.ToString("yyyy-MM-dd"); // formato SQL

                ctrl.GuardarTipoCambio(
                    fechaSQL,
                    valorCompra,
                    valorVenta,
                    Convert.ToInt32(Cbo_Moneda.SelectedValue)
                );

                MessageBox.Show("✅ Tipo de cambio agregado con éxito.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // --- 6️⃣ Reiniciar formulario ---
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el tipo de cambio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimpiarFormulario()
        {
            Txt_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Txt_Compra.Clear();
            Txt_Venta.Clear();

            if (Cbo_Moneda.Items.Count > 0)
                Cbo_Moneda.SelectedIndex = 0;

            Txt_Fecha.Focus();
        }




        private void Cbo_Moneda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
