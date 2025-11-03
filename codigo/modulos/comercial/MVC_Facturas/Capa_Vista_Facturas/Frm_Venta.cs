using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Capa_Controlador_Facturas;
using System.ComponentModel;   // BindingList

namespace Capa_Vista_Facturas
{
    public partial class Frm_Venta : Form
    {
        private readonly Cls_Controlador ctrl = new Cls_Controlador();
        private DataTable productos;
        private readonly CultureInfo gt = new CultureInfo("es-GT");

        public Frm_Venta()
        {
            InitializeComponent();

            Load += Frm_Venta_Load;
            Cbo_Producto.SelectedIndexChanged += Cbo_Producto_SelectedIndexChanged;
            Btn_Agregar.Click += Btn_Agregar_Click;
            Btn_Eliminar.Click += Btn_Eliminar_Click;
            Txt_Efectivo.TextChanged += Txt_Efectivo_TextChanged;
            Btn_Vender.Click += Btn_Vender_Click;

            Dgv_Lista.AutoGenerateColumns = false;
            Dgv_Lista.DataSource = ctrl.Lineas;
        }

        private void Frm_Venta_Load(object sender, EventArgs e)
        {
            // Cargar productos
            productos = ctrl.ObtenerProductos();
            Cbo_Producto.DataSource = productos;
            Cbo_Producto.DisplayMember = "Cmp_NombreProducto";
            Cbo_Producto.ValueMember = "Cmp_CodigoProducto";

            // columnas del DGV (enlaza a propiedades de Cls_LineaVenta)
            if (Dgv_Lista.Columns.Count >= 5)
            {
                Dgv_Lista.Columns[0].DataPropertyName = "Codigo";
                Dgv_Lista.Columns[1].DataPropertyName = "Producto";
                Dgv_Lista.Columns[2].DataPropertyName = "Precio";
                Dgv_Lista.Columns[3].DataPropertyName = "Cantidad";
                Dgv_Lista.Columns[4].DataPropertyName = "Total";
                Dgv_Lista.Columns[4].ReadOnly = true;
                Dgv_Lista.Columns[2].DefaultCellStyle.Format = "N2";
                Dgv_Lista.Columns[4].DefaultCellStyle.Format = "N2";
            }

            // Inicializar textos (títulos)
            Lbl_Total.Text = "TOTAL A PAGAR:";
            Lbl_Efectivo.Text = "EFECTIVO:";
            Lbl_Devolucion.Text = "DEVOLUCIÓN:";

            // Valores visibles
            Lbl_IngresoCodigo.Text = "-";
            Lbl_IngresoNombre.Text = "-";
            Lbl_IngresoPrecio.Text = "-";
            Lbl_TotalPagar.Text = "0.00";
            Lbl_IngresoDevolucion.Text = "0.00";
        }

        private void Cbo_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Producto.SelectedItem is DataRowView drv)
            {
                Lbl_IngresoCodigo.Text = drv["Cmp_CodigoProducto"].ToString();
                Lbl_IngresoNombre.Text = drv["Cmp_NombreProducto"].ToString();
                Lbl_IngresoPrecio.Text = Convert
                    .ToDecimal(drv["Cmp_PrecioUnitario"])
                    .ToString("N2", gt);
            }
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            string codigo = Lbl_IngresoCodigo.Text;
            string nombre = Lbl_IngresoNombre.Text;

            if (codigo == "-" || nombre == "-")
            {
                MessageBox.Show("Selecciona un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!decimal.TryParse(Lbl_IngresoPrecio.Text, NumberStyles.Any, gt, out decimal precio) &&
                !decimal.TryParse(Lbl_IngresoPrecio.Text, out precio))
            {
                MessageBox.Show("Precio inválido.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(Txt_IngresoCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ctrl.AgregarLinea(codigo, nombre, precio, cantidad);

            Txt_IngresoCantidad.Clear();
            Txt_IngresoCantidad.Focus();
            ActualizarTotales();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_Lista.CurrentRow == null) return;

            var r = MessageBox.Show("¿Eliminar línea seleccionada?", "Eliminar",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                ctrl.EliminarLinea(Dgv_Lista.CurrentRow.Index);
                ActualizarTotales();
            }
        }

        private void Txt_Efectivo_TextChanged(object sender, EventArgs e)
        {
            ActualizarTotales();
        }

        private void ActualizarTotales()
        {
            decimal total = ctrl.CalcularTotal();
            Lbl_TotalPagar.Text = total.ToString("N2", gt);

            if (decimal.TryParse(Txt_Efectivo.Text, NumberStyles.Any, gt, out decimal efectivo) ||
                decimal.TryParse(Txt_Efectivo.Text, out efectivo))
            {
                var dev = ctrl.CalcularDevolucion(efectivo, total);
                Lbl_IngresoDevolucion.Text = dev.ToString("N2", gt);
                Lbl_IngresoDevolucion.ForeColor = (dev >= 0)
                    ? System.Drawing.Color.ForestGreen
                    : System.Drawing.Color.Firebrick;
            }
            else
            {
                Lbl_IngresoDevolucion.Text = "0.00";
                Lbl_IngresoDevolucion.ForeColor = System.Drawing.SystemColors.ControlText;
            }
        }

        private void Btn_Vender_Click(object sender, EventArgs e)
        {
            if (ctrl.Lineas.Count == 0)
            {
                MessageBox.Show("No hay productos para vender.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 1) Guardar SOLO la VENTA en BD
            decimal efectivo = 0m;
            decimal.TryParse(Txt_Efectivo.Text, NumberStyles.Any, gt, out efectivo);
            int idUsuario = 2;      // TODO: reemplazar por el usuario real
            int idMetodoPago = 1;   // TODO: reemplazar por el método real

            int idVenta;
            try
            {
                idVenta = ctrl.GuardarVenta(efectivo, idUsuario, idMetodoPago);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la venta:\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2) Preparar detalle y total para la factura (UI)
            DataTable detalle = BuildDetalleFromLineas(ctrl.Lineas);
            decimal total = ctrl.CalcularTotal();

            // 3) Abrir formulario de factura (solo visualización/impresión)
            var frm = new Frm_FacturaCrear
            {
                DetalleFactura = detalle,
                Total = total
            };
            frm.Tag = idVenta;   // Pasamos el ID de la venta

            var dr = frm.ShowDialog(this);

            // 4) Si el usuario guardó la factura correctamente, limpiar la venta (UI)
            if (dr == DialogResult.OK && frm.FacturaId != null)
            {
                MessageBox.Show($"Venta #{idVenta} finalizada. Factura #{frm.FacturaId}.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ctrl.LimpiarLineas();
                Dgv_Lista.Refresh();
                Txt_Efectivo.Clear();
                ActualizarTotales();
            }
        }


        private static DataTable BuildDetalleFromLineas(
            BindingList<Capa_Controlador_Facturas.Cls_Controlador.Cls_LineaVenta> lineas)
        {
            var dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Precio", typeof(decimal));
            dt.Columns.Add("Subtotal", typeof(decimal));

            foreach (var l in lineas)
                dt.Rows.Add(l.Codigo, l.Producto, l.Cantidad, l.Precio, l.Total);

            return dt;
        }
    }
}
