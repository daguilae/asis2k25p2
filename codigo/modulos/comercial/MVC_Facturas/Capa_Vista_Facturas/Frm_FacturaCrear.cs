// Capa_Vista_Facturas/Frm_FacturaCrear.cs
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Capa_Controlador_Facturas;

namespace Capa_Vista_Facturas
{
    // Formulario para crear la factura a partir de una venta
    public partial class Frm_FacturaCrear : Form
    {
        // Evento opcional para notificar que se guardó la factura (si algún form quiere escuchar)
        public event Action<int, decimal> FacturaGuardada;

        // Datos recibidos desde Frm_Venta
        public DataTable DetalleFactura { get; set; }   // lineas de productos
        public decimal Total { get; set; }              // total calculado de la venta
        public int? FacturaId { get; private set; }     // id de factura en BD (luego de guardar)

        // Carpeta base si algún día guardas también XML (no obligatorio)
        internal static readonly string BaseDir =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Facturas");

        // Estado interno para evitar doble guardado
        private bool _yaGuardado = false;

        // Controlador para hablar con la capa modelo/BD
        private readonly Cls_Controlador _ctrl = new Cls_Controlador();

        public Frm_FacturaCrear()
        {
            InitializeComponent();

            // Eventos del ciclo de vida y botones
            Load += Frm_FacturaCrear_Load;
            Cbo_TipoDoc.SelectedIndexChanged += Cbo_TipoDoc_SelectedIndexChanged;
            Btn_Guardar.Click += Btn_Guardar_Click;
            Btn_Imprimir.Click += Btn_Imprimir_Click;
            Btn_Cancelar.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };

            // Evento de impresión
            printDocument1.PrintPage += printDocument1_PrintPage;
        }

        private void Frm_FacturaCrear_Load(object sender, EventArgs e)
        {
            // Cargar opciones del tipo de documento (NIT/CF) una sola vez
            if (Cbo_TipoDoc.Items.Count == 0)
            {
                Cbo_TipoDoc.Items.Add("NIT");
                Cbo_TipoDoc.Items.Add("CF");
            }
            Cbo_TipoDoc.SelectedIndex = 1; // por defecto CF

            // Mostrar total
            Txt_Total.Text = Total.ToString("0.00");

            // Preparar grid con el detalle que viene de la venta
            Dgv_Detalle.AutoGenerateColumns = true;
            Dgv_Detalle.ReadOnly = true;
            Dgv_Detalle.DataSource = DetalleFactura;

            // Formatos si existen esas columnas
            if (Dgv_Detalle.Columns.Contains("Precio"))
                Dgv_Detalle.Columns["Precio"].DefaultCellStyle.Format = "N2";
            if (Dgv_Detalle.Columns.Contains("Subtotal"))
                Dgv_Detalle.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
        }

        private void Cbo_TipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si es CF, se bloquea el campo de documento y se pone "CF"
            bool esCF = (Cbo_TipoDoc.SelectedItem?.ToString() ?? "CF") == "CF";
            Txt_Documento.Text = esCF ? "CF" : Txt_Documento.Text;
            Txt_Documento.ReadOnly = esCF;
            Txt_Documento.BackColor = esCF ? SystemColors.ControlLight : SystemColors.Window;
        }

        // Validaciones básicas de campos
        private bool Validar()
        {
            // Se requiere el IdVenta (viene en Tag)
            if (!(Tag is int)) { MessageBox.Show("No se recibió el Id de la venta."); return false; }

            // Nombre del cliente obligatorio
            if (string.IsNullOrWhiteSpace(Txt_Nombre.Text)) { MessageBox.Show("Ingrese el nombre del cliente."); return false; }

            // Si el tipo es NIT, el documento no puede estar vacío
            if ((Cbo_TipoDoc.SelectedItem?.ToString() ?? "CF") == "NIT" && string.IsNullOrWhiteSpace(Txt_Documento.Text))
            { MessageBox.Show("Ingrese el NIT."); return false; }

            // Total debe ser mayor a 0
            if (Total <= 0) { MessageBox.Show("El total debe ser mayor a 0."); return false; }

            return true;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            // Evita doble clic/duplicar factura
            if (_yaGuardado) return;

            // Validaciones
            if (!Validar()) return;

            // Datos para guardar en BD
            int idVenta = (int)this.Tag;                // viene de Frm_Venta al abrir este form
            string tipo = (Cbo_TipoDoc.SelectedItem?.ToString() ?? "CF");
            string documento = tipo == "CF" ? "CF" : Txt_Documento.Text.Trim();
            string nombre = Txt_Nombre.Text.Trim();
            string apellido = Txt_Apellido.Text.Trim();
            DateTime fecha = Dtp_Fecha.Value;

            try
            {
                // Solo guardamos en BD 
                _ctrl.PersistenciaFactura = Cls_Controlador.ModoFactura.SoloBD;

                // Guardar factura en BD -> retorna Id de Tbl_Factura
                int idFactura = _ctrl.GuardarFacturaEnBD(
                    idVenta, tipo, documento, nombre, apellido, fecha, Total,
                    tambienLocalXml: _ctrl.PersistenciaFactura == Cls_Controlador.ModoFactura.Mixta
                );

                // Guardado OK: actualizamos estado
                FacturaId = idFactura;
                _yaGuardado = true;
                Btn_Guardar.Enabled = false;

                // Refrescar un Listado_Facturas que ya esté abierto (si existe)
                var listadoAbierto = Application.OpenForms
                    .OfType<Frm_Listado_Facturas>()
                    .FirstOrDefault();

                if (listadoAbierto != null)
                {
                    // Recargar datos desde BD y traer al frente
                    listadoAbierto.Recargar();
                    listadoAbierto.BringToFront();
                }

                // Cerrar para saber que todo salió bien
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                // Mensaje de error si algo falla al guardar
                MessageBox.Show("Error al guardar factura en BD:\n\n" + ex,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            // Para imprimir primero debe existir una factura guardada
            if (!FacturaId.HasValue) { MessageBox.Show("Guarda la factura antes de imprimir."); return; }

            // Previsualización de impresión
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.UseAntiAlias = true;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // (encabezado, detalle, total, etc.)
        }
    }
}
