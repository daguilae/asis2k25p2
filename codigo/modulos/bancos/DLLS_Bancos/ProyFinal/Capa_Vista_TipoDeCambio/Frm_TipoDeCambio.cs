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
    public partial class Frm_TipoDeCambio : Form
    {
        Controlador_TipoCambio ctrl = new Controlador_TipoCambio();

        private void Frm_TipoDeCambio_Load(object sender, EventArgs e)
        {
            DataTable datos = ctrl.MostrarTodo();
            Dgv_TipoDeCambio.AutoGenerateColumns = false;
            Dgv_TipoDeCambio.DataSource = datos;

            Dgv_TipoDeCambio.Columns["tipo_cambio"].DataPropertyName = "Pk_Id_TipoCambio";
            Dgv_TipoDeCambio.Columns["nombre_moneda"].DataPropertyName = "Cmp_NombreMoneda";
            Dgv_TipoDeCambio.Columns["fecha"].DataPropertyName = "Cmp_Fecha";
            Dgv_TipoDeCambio.Columns["valor_compra"].DataPropertyName = "Cmp_ValorCompra";
            Dgv_TipoDeCambio.Columns["valor_venta"].DataPropertyName = "Cmp_ValorVenta";

            Dgv_TipoDeCambio.Columns["fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            Dgv_TipoDeCambio.Columns["fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string fechaTexto = Txt_Fecha.Text.Trim();

            // Validar que haya ingresado algo
            if (string.IsNullOrEmpty(fechaTexto))
            {
                MessageBox.Show("Por favor, ingrese una fecha para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Intentar convertir de DD/MM/YYYY a DateTime
            DateTime fechaConvertida;
            if (!DateTime.TryParseExact(fechaTexto, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaConvertida))
            {
                MessageBox.Show("Formato de fecha no válido. Use el formato DD/MM/YYYY.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convertir a formato compatible con la base de datos (YYYY-MM-DD)
            string fechaFormateada = fechaConvertida.ToString("yyyy-MM-dd");

            // Buscar por fecha
            DataTable datos = ctrl.BuscarPorFecha(fechaFormateada);

            if (datos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron registros para la fecha ingresada.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar resultados en la tabla
            Dgv_TipoDeCambio.AutoGenerateColumns = false;
            Dgv_TipoDeCambio.DataSource = datos;

            // Enlazar campos de base con columnas
            Dgv_TipoDeCambio.Columns["nombre_moneda"].DataPropertyName = "Cmp_NombreMoneda";
            Dgv_TipoDeCambio.Columns["fecha"].DataPropertyName = "Cmp_Fecha";
            Dgv_TipoDeCambio.Columns["valor_compra"].DataPropertyName = "Cmp_ValorCompra";
            Dgv_TipoDeCambio.Columns["valor_venta"].DataPropertyName = "Cmp_ValorVenta";

            Dgv_TipoDeCambio.Columns["fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            Dgv_TipoDeCambio.Columns["fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }



        public Frm_TipoDeCambio()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
