using System;
using System.Windows.Forms;
using Capa_Controlador_Modulo_Comercial;

namespace Capa_Vista_Modulo_Comercial
{

    // Juan Carlos Sandoval Quej 0901-22-4170 25/10/2025
    public partial class Frm_Factura : Form
    {
        private Cls_Controlador _controlador;

        public Frm_Factura()
        {
            InitializeComponent();

            _controlador = new Cls_Controlador();

            Btn_Aceptar.Click += Btn_Aceptar_Click;
            Btn_Quitar.Click += Btn_Quitar_Click;
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            // leer campos
            string codigo = Txt_Codigo.Text.Trim();
            string almacen = Txt_Producto.Text.Trim();   // todavía no se usa en grid
            string medida = Txt_Medida.Text.Trim();
            string strCantidad = Txt_Cantidad.Text.Trim();
            string strCosto = Txt_Costo.Text.Trim();
            string strPrecioU = Txt_PrecioU.Text.Trim();

            // validar numéricos
            if (!decimal.TryParse(strCantidad, out decimal cantidad))
            {
                MessageBox.Show("Cantidad inválida", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(strCosto, out decimal costoUnitario))
            {
                MessageBox.Show("Costo inválido", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(strPrecioU, out decimal precioUnitario))
            {
                MessageBox.Show("Precio Unitario inválido", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // pedir al controlador que registre la línea
            var datosFila = _controlador.AgregarLinea(
                codigo: codigo,
                medida: medida,
                cantidad: cantidad,
                costoUnitario: costoUnitario,
                precioUnitario: precioUnitario
            );

            Dgv_Detalle.Rows.Add(
                datosFila.codigo,
                datosFila.descripcion,
                datosFila.cantidad.ToString("0.##"),
                datosFila.totalCosto.ToString("0.00"),
                datosFila.totalPrecio.ToString("0.00")
            );

            LimpiarLineaProducto();
        }

        private void Btn_Quitar_Click(object sender, EventArgs e)
        {
            if (Dgv_Detalle.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una línea para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int rowIndex = Dgv_Detalle.CurrentRow.Index;

            // avisar al controlador
            _controlador.QuitarLinea(rowIndex);

            // reflejar en UI
            Dgv_Detalle.Rows.RemoveAt(rowIndex);
        }

        private void LimpiarLineaProducto()
        {
            Txt_Codigo.Text = "";
            Txt_Producto.Text = "";
            Txt_Medida.Text = "";
            Txt_Cantidad.Text = "";
            Txt_Costo.Text = "";
            Txt_PrecioU.Text = "";

            Txt_Codigo.Focus();
        }
    }
}
