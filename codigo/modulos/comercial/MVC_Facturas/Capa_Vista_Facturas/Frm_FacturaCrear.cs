using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Capa_Vista_Facturas
{
    public partial class Frm_FacturaCrear : Form
    {
        // Recibe desde Frm_Venta
        public DataTable DetalleFactura { get; set; } // columnas: Codigo, Producto, Cantidad, Precio, Subtotal
        public decimal Total { get; set; }
        public int? FacturaId { get; private set; }   // correlativo visual para la factura

        public Frm_FacturaCrear()
        {
            InitializeComponent();
        }

        private void Frm_FacturaCrear_Load(object sender, EventArgs e)
        {
            if (Cbo_TipoDoc.Items.Count == 0)
            {
                Cbo_TipoDoc.Items.Add("NIT");
                Cbo_TipoDoc.Items.Add("CF");
            }
            Cbo_TipoDoc.SelectedIndex = 0;

            Txt_Total.Text = Total.ToString("0.00");

            Dgv_Detalle.AutoGenerateColumns = true;
            Dgv_Detalle.ReadOnly = true;
            Dgv_Detalle.DataSource = null; // lo llenamos al Guardar
        }

        private void PrepararColumnasGrid()
        {
            Dgv_Detalle.AutoGenerateColumns = false;
            Dgv_Detalle.Columns.Clear();

            var colCod = new DataGridViewTextBoxColumn { HeaderText = "Codigo", DataPropertyName = "Codigo", ReadOnly = true };
            var colProd = new DataGridViewTextBoxColumn { HeaderText = "Producto", DataPropertyName = "Producto", ReadOnly = true, Width = 240 };
            var colCant = new DataGridViewTextBoxColumn { HeaderText = "Cantidad", DataPropertyName = "Cantidad", ReadOnly = true };
            var colPrecio = new DataGridViewTextBoxColumn { HeaderText = "Precio", DataPropertyName = "Precio", ReadOnly = true };
            colPrecio.DefaultCellStyle.Format = "N2";
            var colSub = new DataGridViewTextBoxColumn { HeaderText = "Subtotal", DataPropertyName = "Subtotal", ReadOnly = true };
            colSub.DefaultCellStyle.Format = "N2";

            Dgv_Detalle.Columns.AddRange(colCod, colProd, colCant, colPrecio, colSub);
        }

        private void Cbo_TipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_TipoDoc.SelectedItem?.ToString() == "CF")
            {
                Txt_Documento.Text = "CF";
                Txt_Documento.ReadOnly = true;
                Txt_Documento.BackColor = SystemColors.ControlLight;
            }
            else
            {
                if (Txt_Documento.Text == "CF") Txt_Documento.Clear();
                Txt_Documento.ReadOnly = false;
                Txt_Documento.BackColor = SystemColors.Window;
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            // 1) Mostrar DETALLE en el grid (pre-visualización en pantalla)
            Dgv_Detalle.DataSource = null;
            Dgv_Detalle.DataSource = DetalleFactura;

            // 2) “Guardar” la FACTURA en el listado del formulario (en memoria)
            int idVenta = (this.Tag is int v) ? v : 0; // viene desde Frm_Venta
            int numero = Frm_Listado_Facturas.TablaFacturas.Rows.Count + 1;

            Frm_Listado_Facturas.TablaFacturas.Rows.Add(
                numero,
                idVenta,
                Txt_Nombre.Text.Trim(),
                Txt_Apellido.Text.Trim(),
                Txt_Documento.Text.Trim(),
                Dtp_Fecha.Value,
                DetalleFactura?.Rows.Count ?? 0,
                Total
            );

            this.FacturaId = numero; // para que Frm_Venta muestre el número

            // 3) Abrir PREVIEW tipo PDF (antes de imprimir) — blindado
            EnsurePreviewInitialized();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.UseAntiAlias = true;
            printPreviewDialog1.ShowDialog();

            // devolvemos OK para que Frm_Venta pueda limpiar
            this.DialogResult = DialogResult.OK;
        }

        private void CargarDetalleEnGrid()
        {
            if (DetalleFactura == null || DetalleFactura.Rows.Count == 0)
            {
                MessageBox.Show("No hay detalle para mostrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Recalcular total por si acaso y reflejarlo
            decimal suma = 0m;
            foreach (DataRow r in DetalleFactura.Rows)
                suma += Convert.ToDecimal(r["Subtotal"]);

            Txt_Total.Text = suma.ToString("0.00");
            Total = suma;

            Dgv_Detalle.DataSource = null;
            Dgv_Detalle.DataSource = DetalleFactura;

            // evitar edición
            Dgv_Detalle.ReadOnly = true;
            Dgv_Detalle.AllowUserToAddRows = false;
            Dgv_Detalle.AllowUserToDeleteRows = false;
            Dgv_Detalle.ClearSelection();
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            if (FacturaId == null)
            {
                MessageBox.Show("Primero guarde la factura.", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            printDocument1.Print(); // Elige "Microsoft Print to PDF" si quieres archivo PDF
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(Txt_Nombre.Text))
            { MessageBox.Show("Ingrese el nombre del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); Txt_Nombre.Focus(); return false; }

            if (string.IsNullOrWhiteSpace(Txt_Apellido.Text))
            { MessageBox.Show("Ingrese el apellido del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); Txt_Apellido.Focus(); return false; }

            if (Cbo_TipoDoc.SelectedItem?.ToString() == "NIT" && string.IsNullOrWhiteSpace(Txt_Documento.Text))
            { MessageBox.Show("Ingrese el NIT del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); Txt_Documento.Focus(); return false; }

            if (Total <= 0)
            { MessageBox.Show("El total debe ser mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            return true;
        }

        // “PDF”/Ticket
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            float y = 40;
            var g = e.Graphics;
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

        // ====== Blindaje para el Preview (evita NullReference si el diseñador no lo instanció)
        private void EnsurePreviewInitialized()
        {
            if (printDocument1 == null)
            {
                printDocument1 = new PrintDocument();
                printDocument1.PrintPage += printDocument1_PrintPage;
            }

            if (printPreviewDialog1 == null)
            {
                printPreviewDialog1 = new PrintPreviewDialog
                {
                    ClientSize = new Size(900, 700),
                    UseAntiAlias = true,
                    Name = "printPreviewDialog1"
                };
            }
        }
    }
}
