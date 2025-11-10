using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Capa_Controlador_Facturas;

namespace Capa_Vista_Facturas

    // Juan Carlos Sandoval Quej 0901-22-4170 09/11/2025
{
    public partial class Frm_Venta : Form
    {
        private readonly Cls_Controlador _ctrl = new Cls_Controlador();
        private DataTable _productos;
        private readonly CultureInfo _gt = new CultureInfo("es-GT");

        public Frm_Venta()
        {
            InitializeComponent();

            Load += Frm_Venta_Load;
            Cbo_Producto.SelectedIndexChanged += Cbo_Producto_SelectedIndexChanged;
            Btn_Agregar.Click += Btn_Agregar_Click;
            Btn_Eliminar.Click += Btn_Eliminar_Click;
            Txt_Efectivo.TextChanged += (s, e) => ActualizarTotales();
            Btn_Vender.Click += Btn_Vender_Click;

            Dgv_Lista.AutoGenerateColumns = false;
            Dgv_Lista.DataSource = _ctrl.Lineas;
        }

        private void Frm_Venta_Load(object sender, EventArgs e)
        {
            _productos = _ctrl.ObtenerProductos();
            Cbo_Producto.DataSource = _productos;
            Cbo_Producto.DisplayMember = "Cmp_Nombre_Producto";
            Cbo_Producto.ValueMember = "Cmp_Codigo_Producto";

            if (Dgv_Lista.Columns.Count >= 5)
            {
                Dgv_Lista.Columns[0].DataPropertyName = "Codigo";
                Dgv_Lista.Columns[1].DataPropertyName = "Producto";
                Dgv_Lista.Columns[2].DataPropertyName = "Cantidad";
                Dgv_Lista.Columns[3].DataPropertyName = "Precio";
                Dgv_Lista.Columns[4].DataPropertyName = "Total";
                Dgv_Lista.Columns[3].DefaultCellStyle.Format = "N2";
                Dgv_Lista.Columns[4].DefaultCellStyle.Format = "N2";
                Dgv_Lista.Columns[4].ReadOnly = true;
            }

            Lbl_TotalPagar.Text = "0.00";
            Lbl_IngresoDevolucion.Text = "0.00";
        }

        private void Cbo_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Producto.SelectedItem is DataRowView drv)
            {
                Lbl_IngresoCodigo.Text = Convert.ToString(drv["Cmp_Codigo_Producto"]);
                Lbl_IngresoNombre.Text = Convert.ToString(drv["Cmp_Nombre_Producto"]);
                Lbl_IngresoPrecio.Text = Convert.ToDecimal(drv["Cmp_PrecioUnitario"]).ToString("N2", _gt);
            }
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Lbl_IngresoCodigo.Text)) { MessageBox.Show("Selecciona un producto."); return; }
            if (!int.TryParse(Txt_IngresoCantidad.Text, out var cant) || cant <= 0) { MessageBox.Show("Cantidad inválida."); return; }

            if (!decimal.TryParse(Lbl_IngresoPrecio.Text, NumberStyles.Any, _gt, out var precio) &&
                !decimal.TryParse(Lbl_IngresoPrecio.Text, out precio))
            { MessageBox.Show("Precio inválido."); return; }

            _ctrl.AgregarLinea(Lbl_IngresoCodigo.Text, Lbl_IngresoNombre.Text, precio, cant);
            Txt_IngresoCantidad.Clear();
            Txt_IngresoCantidad.Focus();
            ActualizarTotales();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_Lista.CurrentRow == null) return;
            if (MessageBox.Show("¿Eliminar línea seleccionada?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _ctrl.EliminarLinea(Dgv_Lista.CurrentRow.Index);
                ActualizarTotales();
            }
        }

        private void ActualizarTotales()
        {
            var total = _ctrl.TotalVenta();
            Lbl_TotalPagar.Text = total.ToString("N2", _gt);

            // Intentar leer el efectivo ingresado
            if (decimal.TryParse(Txt_Efectivo.Text, NumberStyles.Any, _gt, out var efectivo) ||
                decimal.TryParse(Txt_Efectivo.Text, out efectivo))
            {
                var devolucion = _ctrl.Devolucion(efectivo);
                Lbl_IngresoDevolucion.Text = devolucion.ToString("N2", _gt);

                // ===== COLORES SEGÚN VALOR =====
                if (devolucion < 0)
                {
                    Lbl_IngresoDevolucion.ForeColor = System.Drawing.Color.Firebrick;   // rojo
                }
                else if (devolucion > 0)
                {
                    Lbl_IngresoDevolucion.ForeColor = System.Drawing.Color.ForestGreen; // verde
                }
                else
                {
                    Lbl_IngresoDevolucion.ForeColor = System.Drawing.Color.Black;       // exacto
                }
            }
            else
            {
                Lbl_IngresoDevolucion.Text = "0.00";
                Lbl_IngresoDevolucion.ForeColor = System.Drawing.Color.Black;
            }
        }


        private DataTable BuildDetalle()
        {
            var dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Precio", typeof(decimal));
            dt.Columns.Add("Subtotal", typeof(decimal));
            foreach (var l in _ctrl.Lineas) dt.Rows.Add(l.Codigo, l.Producto, l.Cantidad, l.Precio, l.Total);
            return dt;
        }

        private void Btn_Vender_Click(object sender, EventArgs e)
        {
            // 1. Validar que haya productos
           
            if (_ctrl.Lineas.Count == 0)
            {
                MessageBox.Show("No hay productos agregados a la venta.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

  
            // 2. Validar que TODAS las cantidades agregadas sean correctas
       
            foreach (var linea in _ctrl.Lineas)
            {
                if (linea.Cantidad <= 0)
                {
                    MessageBox.Show(
                        $"La cantidad del producto '{linea.Producto}' es inválida.\nDebe ser mayor a 0.",
                        "Cantidad inválida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

    
            // 3. Validación de EFECTIVO

            // 3.1 - Campo vacío
            if (string.IsNullOrWhiteSpace(Txt_Efectivo.Text))
            {
                MessageBox.Show("Debe ingresar el efectivo recibido.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Efectivo.Focus();
                return;
            }

            // 3.2 - Intentar convertir a número
            if (!decimal.TryParse(Txt_Efectivo.Text, out var efectivo))
            {
                MessageBox.Show("El valor ingresado en efectivo no es válido.",
                    "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Efectivo.Focus();
                return;
            }

            decimal total = _ctrl.TotalVenta();

            // 3.3 - Efectivo insuficiente
            if (efectivo < total)
            {
                MessageBox.Show(
                    $"El efectivo ingresado es insuficiente.\n\n" +
                    $"Total a pagar : Q{total:0.00}\n" +
                    $"Efectivo       : Q{efectivo:0.00}",
                    "Efectivo insuficiente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Txt_Efectivo.Focus();
                return;
            }


            // 4. Guardar la venta en BD
            int? idUsuario = 2;     // si no usas login real
            int? idMetodoPago = 1;  // 1 = efectivo

            int idVenta;
            try
            {
                idVenta = _ctrl.GuardarVenta(efectivo, idUsuario, idMetodoPago);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la venta:\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

  
            // 5. Abrir la ventana para generar factura
            var frmFact = new Frm_FacturaCrear
            {
                DetalleFactura = BuildDetalle(),
                Total = total,
                Tag = idVenta
            };

            var dr = frmFact.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
              
                // 6. Limpiar la venta actual
         
                _ctrl.Limpiar();
                Dgv_Lista.Refresh();
                Txt_Efectivo.Clear();
                ActualizarTotales();

                // Abrir listado de facturas automáticamente
                using (var listado = new Frm_Listado_Facturas())
                {
                    listado.StartPosition = FormStartPosition.CenterParent;
                    listado.ShowDialog(this);
                }
            }
        }

        private void listadoDeFacturaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_Listado_Facturas Listado = new Frm_Listado_Facturas();
            Listado.Show();
            this.Hide();
        }
    }
}
