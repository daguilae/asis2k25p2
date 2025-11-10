using System;
using System.Data;
using System.Drawing;              
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Capa_Vista_Facturas

        // Juan Carlos Sandoval Quej 0901-22-4170 09/11/2025
{
    public partial class Frm_FacturaCrear : Form
    {
        // ====== Datos que recibe desde Frm_Venta ======
        public DataTable DetalleFactura { get; set; }
        public decimal Total { get; set; }
        public int? FacturaId { get; private set; }

        // ====== Carpeta ÚNICA para cabeceras+detalles ======
        internal static readonly string BaseDir =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Facturas");

        // Guard de clic doble/Enter/AcceptButton (evita duplicar)
        private bool _yaGuardado = false;

        public Frm_FacturaCrear()
        {
            InitializeComponent();

            Load += Frm_FacturaCrear_Load;

            Cbo_TipoDoc.SelectedIndexChanged += Cbo_TipoDoc_SelectedIndexChanged;
            Btn_Guardar.Click += Btn_Guardar_Click;
            Btn_Imprimir.Click += Btn_Imprimir_Click;
            Btn_Cancelar.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };

            printDocument1.PrintPage += printDocument1_PrintPage;
        }

        private void Frm_FacturaCrear_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(BaseDir);

            if (Cbo_TipoDoc.Items.Count == 0)
            {
                Cbo_TipoDoc.Items.Add("NIT");
                Cbo_TipoDoc.Items.Add("CF");
            }
            Cbo_TipoDoc.SelectedIndex = 1; // CF por defecto

            Txt_Total.Text = Total.ToString("0.00");

            Dgv_Detalle.AutoGenerateColumns = true;
            Dgv_Detalle.ReadOnly = true;
            Dgv_Detalle.DataSource = DetalleFactura ?? new DataTable();

            if (Dgv_Detalle.Columns.Contains("Precio"))
                Dgv_Detalle.Columns["Precio"].DefaultCellStyle.Format = "N2";
            if (Dgv_Detalle.Columns.Contains("Subtotal"))
                Dgv_Detalle.Columns["Subtotal"].DefaultCellStyle.Format = "N2";

            _yaGuardado = false;        // reset guard
            Btn_Guardar.Enabled = true; // por si viene reabierto
        }

        private void Cbo_TipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esCF = (Cbo_TipoDoc.SelectedItem?.ToString() ?? "CF") == "CF";
            if (esCF) Txt_Documento.Text = "CF";
            Txt_Documento.ReadOnly = esCF;
            Txt_Documento.BackColor = esCF
                ? SystemColors.ControlLight
                : SystemColors.Window;
        }

        // ================== GUARDAR ==================
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            // 1) guard anti-doble-click/enter
            if (_yaGuardado) return;

            // 2) validaciones
            if (!Validar()) return;

            try
            {
                Directory.CreateDirectory(BaseDir);

                // correlativo a partir de los archivos existentes
                int numero = SiguienteNumero();

                // ===== Cabecera =====
                var cab = new DataTable("Cabecera");
                cab.Columns.Add("Numero", typeof(int));
                cab.Columns.Add("IdVenta", typeof(int));
                cab.Columns.Add("TipoDoc", typeof(string));
                cab.Columns.Add("Documento", typeof(string));
                cab.Columns.Add("Nombre", typeof(string));
                cab.Columns.Add("Apellido", typeof(string));
                cab.Columns.Add("Fecha", typeof(DateTime));
                cab.Columns.Add("Total", typeof(decimal));

                cab.Rows.Add(
                    numero,
                    (int)Tag, // IdVenta en Tag
                    Cbo_TipoDoc.SelectedItem?.ToString() ?? "CF",
                    ((Cbo_TipoDoc.SelectedItem?.ToString() ?? "CF") == "CF") ? "CF" : Txt_Documento.Text.Trim(),
                    Txt_Nombre.Text.Trim(),
                    Txt_Apellido.Text.Trim(),
                    Dtp_Fecha.Value,
                    Total
                );

                // ===== Detalle =====
                var det = (DetalleFactura?.Copy()) ?? new DataTable();
                if (string.IsNullOrWhiteSpace(det.TableName)) det.TableName = "Detalle";
                if (det.Columns.Count == 0)
                {
                    det.Columns.Add("Codigo", typeof(string));
                    det.Columns.Add("Producto", typeof(string));
                    det.Columns.Add("Cantidad", typeof(int));
                    det.Columns.Add("Precio", typeof(decimal));
                    det.Columns.Add("Subtotal", typeof(decimal));
                }

                // ===== Persistir en un solo XML =====
                var ds = new DataSet("Factura");
                ds.Tables.Add(cab);
                ds.Tables.Add(det);

                string fileXml = Path.Combine(BaseDir, $"F{numero:000000}.xml");
                ds.WriteXml(fileXml, XmlWriteMode.WriteSchema);

                FacturaId = numero;

                _yaGuardado = true;
                Btn_Guardar.Enabled = false;  // seguridad extra

                MessageBox.Show($"Factura #{numero} guardada.", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Señal al que llamó para refrescar el listado
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar la factura.\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _yaGuardado = false;
                Btn_Guardar.Enabled = true;
            }
        }

        private static int SiguienteNumero()
        {
            int max = 0;
            foreach (var f in Directory.GetFiles(BaseDir, "F*.xml"))
            {
                var name = Path.GetFileNameWithoutExtension(f); // F000123
                if (name?.Length > 1 && int.TryParse(name.Substring(1), out int n))
                    if (n > max) max = n;
            }
            return max + 1;
        }

        private bool Validar()
        {
            if (!(Tag is int))
            {
                MessageBox.Show("No se recibió el Id de la venta.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(Txt_Nombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente.");
                return false;
            }
            if ((Cbo_TipoDoc.SelectedItem?.ToString() ?? "CF") == "NIT" &&
                string.IsNullOrWhiteSpace(Txt_Documento.Text))
            {
                MessageBox.Show("Ingrese el NIT.");
                return false;
            }
            if (Total <= 0)
            {
                MessageBox.Show("El total debe ser mayor a 0.");
                return false;
            }
            return true;
        }

        // ================== IMPRIMIR ==================
        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            if (!FacturaId.HasValue)
            {
                MessageBox.Show("Guarda la factura antes de imprimir.");
                return;
            }

            // Asignación mínima y sin icono de recursos (evita MissingManifestResourceException)
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Icon = null;               // <- evita la excepción de recursos
            printPreviewDialog1.UseAntiAlias = true;
            printPreviewDialog1.ShowDialog(this);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Dibujo simple (puedes mantener tu bloque original si ya lo tenías)
            var g = e.Graphics;
            float y = 40;
            var font = new Font("Segoe UI", 9);
            var bold = new Font("Segoe UI", 9, FontStyle.Bold);

            g.DrawString("HOTEL SAN CARLOS — FACTURA", new Font("Segoe UI", 13, FontStyle.Bold), Brushes.Black, 40, y); y += 26;
            g.DrawLine(Pens.Black, 40, y, e.PageBounds.Width - 40, y); y += 10;

            g.DrawString($"Factura #: {FacturaId}", bold, Brushes.Black, 40, y); y += 18;
            g.DrawString($"Fecha: {Dtp_Fecha.Value:dd/MM/yyyy HH:mm}", font, Brushes.Black, 40, y); y += 18;
            g.DrawString($"Cliente: {Txt_Nombre.Text.Trim()} {Txt_Apellido.Text.Trim()}", font, Brushes.Black, 40, y); y += 18;
            g.DrawString($"Documento: {Txt_Documento.Text.Trim()}", font, Brushes.Black, 40, y); y += 18;

            y += 6;
            g.DrawString("Detalle", bold, Brushes.Black, 40, y); y += 16;
            g.DrawString("Producto", bold, Brushes.Black, 40, y);
            g.DrawString("Cant.", bold, Brushes.Black, 320, y);
            g.DrawString("Precio", bold, Brushes.Black, 380, y);
            g.DrawString("Subt.", bold, Brushes.Black, 460, y);
            y += 15;

            if (DetalleFactura != null)
            {
                foreach (DataRow row in DetalleFactura.Rows)
                {
                    string producto = Convert.ToString(row["Producto"]);
                    string cant = Convert.ToDecimal(row["Cantidad"]).ToString("0.##");
                    string precio = Convert.ToDecimal(row["Precio"]).ToString("0.00");
                    string sub = Convert.ToDecimal(row["Subtotal"]).ToString("0.00");

                    g.DrawString(producto, font, Brushes.Black, 40, y);
                    g.DrawString(cant, font, Brushes.Black, 320, y);
                    g.DrawString(precio, font, Brushes.Black, 380, y);
                    g.DrawString(sub, font, Brushes.Black, 460, y);
                    y += 15;

                    if (y > e.MarginBounds.Bottom - 80) { e.HasMorePages = true; return; }
                }
            }

            y += 8;
            g.DrawLine(Pens.Black, 40, y, e.PageBounds.Width - 40, y); y += 10;
            g.DrawString($"TOTAL: Q {Total:0.00}", new Font("Segoe UI", 11, FontStyle.Bold), Brushes.Black, 460, y);
        }
    }
}
