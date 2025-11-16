using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Capa_Controlador_Facturas;

namespace Capa_Vista_Facturas
{
    // Juan Carlos Sandoval Quej 0901-22-4170 12/11/2025
    public partial class Frm_Venta : Form
    {
        // Controlador general para manejar lógica y conexión
        private readonly Cls_Controlador _ctrl = new Cls_Controlador();

        // Tabla que contendrá los productos cargados desde la BD
        private DataTable _productos;

        // Cultura usada para manejar formato de decimales (Quetzales)
        private readonly CultureInfo _gt = new CultureInfo("es-GT");

        // Constructor: aquí se inicializan eventos y configuraciones iniciales
        public Frm_Venta()
        {
            InitializeComponent();

            // Asociar eventos principales
            Load += Frm_Venta_Load;
            Cbo_Producto.SelectedIndexChanged += Cbo_Producto_SelectedIndexChanged;
            Btn_Agregar.Click += Btn_Agregar_Click;
            Btn_Eliminar.Click += Btn_Eliminar_Click;
            Txt_Efectivo.TextChanged += (s, e) => ActualizarTotales();
            Btn_Vender.Click += Btn_Vender_Click;

            // Configurar el DataGridView de productos
            Dgv_Lista.AutoGenerateColumns = false;
            Dgv_Lista.DataSource = _ctrl.Lineas;
        }

        // Evento que se ejecuta al cargar el formulario
        private void Frm_Venta_Load(object sender, EventArgs e)
        {
            // Obtener productos desde la BD y cargarlos en el combo
            _productos = _ctrl.ObtenerProductos();
            Cbo_Producto.DataSource = _productos;
            Cbo_Producto.DisplayMember = "Cmp_Nombre_Producto";  // lo que se ve
            Cbo_Producto.ValueMember = "Cmp_Codigo_Producto";    // valor real

            // Vincular columnas del grid con las propiedades de las líneas
            if (Dgv_Lista.Columns.Count >= 5)
            {
                Dgv_Lista.Columns[0].DataPropertyName = "Codigo";
                Dgv_Lista.Columns[1].DataPropertyName = "Producto";
                Dgv_Lista.Columns[2].DataPropertyName = "Cantidad";
                Dgv_Lista.Columns[3].DataPropertyName = "Precio";
                Dgv_Lista.Columns[4].DataPropertyName = "Total";

                Dgv_Lista.Columns[3].DefaultCellStyle.Format = "N2";  // formato de precio
                Dgv_Lista.Columns[4].DefaultCellStyle.Format = "N2";  // formato de total
                Dgv_Lista.Columns[4].ReadOnly = true;                 // no editable
            }

            // Valores iniciales
            Lbl_TotalPagar.Text = "0.00";
            Lbl_IngresoDevolucion.Text = "0.00";
        }

        // Cuando se selecciona un producto en el ComboBox
        private void Cbo_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Producto.SelectedItem is DataRowView drv)
            {
                // Mostrar código, nombre y precio del producto seleccionado
                Lbl_IngresoCodigo.Text = Convert.ToString(drv["Cmp_Codigo_Producto"]);
                Lbl_IngresoNombre.Text = Convert.ToString(drv["Cmp_Nombre_Producto"]);
                Lbl_IngresoPrecio.Text = Convert
                    .ToDecimal(drv["Cmp_PrecioUnitario"])
                    .ToString("N2", _gt);
            }
        }

        // Botón AGREGAR: añade una línea de producto al detalle
        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            // Validar que haya un producto seleccionado
            if (string.IsNullOrWhiteSpace(Lbl_IngresoCodigo.Text))
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }

            // Validar que la cantidad sea un número válido y mayor a 0
            if (!int.TryParse(Txt_IngresoCantidad.Text, out var cant) || cant <= 0)
            {
                MessageBox.Show("Cantidad inválida.");
                return;
            }

            // Validar precio correcto
            if (!decimal.TryParse(Lbl_IngresoPrecio.Text, NumberStyles.Any, _gt, out var precio) &&
                !decimal.TryParse(Lbl_IngresoPrecio.Text, out precio))
            {
                MessageBox.Show("Precio inválido.");
                return;
            }

            // Agregar línea al controlador
            _ctrl.AgregarLinea(Lbl_IngresoCodigo.Text, Lbl_IngresoNombre.Text, precio, cant);

            // Limpiar entrada de cantidad
            Txt_IngresoCantidad.Clear();
            Txt_IngresoCantidad.Focus();

            // Actualizar totales
            ActualizarTotales();
        }

        // Botón ELIMINAR: quita una línea seleccionada del detalle
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_Lista.CurrentRow == null) return;

            if (MessageBox.Show("¿Eliminar línea seleccionada?", "Eliminar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _ctrl.EliminarLinea(Dgv_Lista.CurrentRow.Index);
                ActualizarTotales();
            }
        }

        // Calcula el total y la devolución en tiempo real
        private void ActualizarTotales()
        {
            var total = _ctrl.TotalVenta();
            Lbl_TotalPagar.Text = total.ToString("N2", _gt);

            // Si el efectivo ingresado es válido, calcular devolución
            if (decimal.TryParse(Txt_Efectivo.Text, NumberStyles.Any, _gt, out var efectivo) ||
                decimal.TryParse(Txt_Efectivo.Text, out efectivo))
            {
                var devolucion = _ctrl.Devolucion(efectivo);
                Lbl_IngresoDevolucion.Text = devolucion.ToString("N2", _gt);

                // Colorear según resultado
                if (devolucion < 0)
                    Lbl_IngresoDevolucion.ForeColor = System.Drawing.Color.Firebrick;   // rojo
                else if (devolucion > 0)
                    Lbl_IngresoDevolucion.ForeColor = System.Drawing.Color.ForestGreen; // verde
                else
                    Lbl_IngresoDevolucion.ForeColor = System.Drawing.Color.Black;       // exacto
            }
            else
            {
                Lbl_IngresoDevolucion.Text = "0.00";
                Lbl_IngresoDevolucion.ForeColor = System.Drawing.Color.Black;
            }
        }

        // Crea un DataTable con el detalle de venta para mandarlo a la factura
        private DataTable BuildDetalle()
        {
            var dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Precio", typeof(decimal));
            dt.Columns.Add("Subtotal", typeof(decimal));

            // Llenar con las líneas actuales
            foreach (var l in _ctrl.Lineas)
                dt.Rows.Add(l.Codigo, l.Producto, l.Cantidad, l.Precio, l.Total);

            return dt;
        }

        // Botón VENDER: valida, guarda venta y abre factura
        private void Btn_Vender_Click(object sender, EventArgs e)
        {
            // ======= VALIDACIONES =======
            if (_ctrl.Lineas.Count == 0)
            {
                MessageBox.Show("No hay productos agregados a la venta.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Revisar que todas las cantidades sean válidas
            foreach (var linea in _ctrl.Lineas)
            {
                if (linea.Cantidad <= 0)
                {
                    MessageBox.Show($"La cantidad del producto '{linea.Producto}' es inválida.\nDebe ser mayor a 0.",
                        "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Validar efectivo ingresado
            if (string.IsNullOrWhiteSpace(Txt_Efectivo.Text))
            {
                MessageBox.Show("Debe ingresar el efectivo recibido.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Efectivo.Focus();
                return;
            }

            if (!decimal.TryParse(Txt_Efectivo.Text, out var efectivo))
            {
                MessageBox.Show("El valor ingresado en efectivo no es válido.",
                    "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Efectivo.Focus();
                return;
            }

            // Validar que el efectivo cubra el total
            decimal total = _ctrl.TotalVenta();
            if (efectivo < total)
            {
                MessageBox.Show($"El efectivo ingresado es insuficiente.\n\nTotal: Q{total:0.00}\nEfectivo: Q{efectivo:0.00}",
                    "Efectivo insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Efectivo.Focus();
                return;
            }

            // ======= GUARDAR VENTA =======
            int? idUsuario = 2;    // temporal si no hay login
            int? idMetodoPago = 1; // efectivo
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

            // ======= CREAR FACTURA =======
            var frmFact = new Frm_FacturaCrear
            {
                DetalleFactura = BuildDetalle(),
                Total = total,
                Tag = idVenta
            };

            // Manejar el evento al guardar factura (refresca automáticamente el listado)
            frmFact.FacturaGuardada += (facturaId, totalFactura) =>
            {
                var listadoAbierto = Application.OpenForms.OfType<Frm_Listado_Facturas>().FirstOrDefault();
                if (listadoAbierto == null)
                {
                    listadoAbierto = new Frm_Listado_Facturas();
                    listadoAbierto.StartPosition = FormStartPosition.CenterParent;
                    listadoAbierto.Show(this);
                }
                else
                {
                    listadoAbierto.BringToFront();
                    listadoAbierto.Activate();
                }
                listadoAbierto.Recargar();
                listadoAbierto.SelectFactura(facturaId);
            };

            // Mostrar el formulario de factura y esperar resultado
            var dr = frmFact.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                // ======= LIMPIAR INTERFAZ =======
                _ctrl.Limpiar();
                Dgv_Lista.Refresh();
                Txt_Efectivo.Clear();
                ActualizarTotales();

                // ======= REFRESCAR LISTADO DE FACTURAS =======
                var listado = Application.OpenForms.OfType<Frm_Listado_Facturas>().FirstOrDefault();
                if (listado == null)
                {
                    listado = new Frm_Listado_Facturas();
                    listado.StartPosition = FormStartPosition.CenterParent;
                    listado.Show(this);
                }
                else
                {
                    listado.BringToFront();
                }
                listado.Recargar();
            }
        }

        // Abre o trae al frente el listado de facturas desde el menú superior
        private void listadoDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listado = Application.OpenForms.OfType<Frm_Listado_Facturas>().FirstOrDefault();
            if (listado == null)
            {
                listado = new Frm_Listado_Facturas();
                listado.StartPosition = FormStartPosition.CenterParent;
                listado.Show(this);
            }
            else
            {
                listado.BringToFront();
                listado.Activate();
            }
            listado.Recargar();
        }
    }
}
