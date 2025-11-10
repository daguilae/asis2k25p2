using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Capa_Vista_Facturas

        // Juan Carlos Sandoval Quej 0901-22-4170 09/11/2025
{
    public partial class Frm_Detalle_Factura : Form
    {
        private readonly string _file;
        private DataTable _detalle;
        private decimal _total;

        public Frm_Detalle_Factura(string fileXml)
        {
            _file = fileXml ?? throw new ArgumentNullException(nameof(fileXml));
            InitializeComponent();
            Load += Frm_Detalle_Factura_Load;

            Btn_Cerrar.Click += (s, e) => Close();
            Btn_Imprimir.Click += (s, e) =>
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.UseAntiAlias = true;
                printPreviewDialog1.ShowDialog();
            };
            printDocument1.PrintPage += printDocument1_PrintPage;
        }

        private void Frm_Detalle_Factura_Load(object sender, EventArgs e)
        {
            var ds = new DataSet();
            ds.ReadXml(_file);

            var cab = ds.Tables["Cabecera"]?.Rows.Cast<DataRow>().FirstOrDefault();
            _detalle = ds.Tables["Detalle"] ?? new DataTable();

            Lbl_Numero.Text = Convert.ToString(cab?["Numero"] ?? "-");
            Lbl_Fecha.Text = Convert.ToDateTime(cab?["Fecha"] ?? DateTime.Now).ToString("dd/MM/yyyy HH:mm");
            Lbl_Cliente.Text = $"{Convert.ToString(cab?["Nombre"] ?? "")} {Convert.ToString(cab?["Apellido"] ?? "")}".Trim();
            Lbl_Documento.Text = Convert.ToString(cab?["Documento"] ?? "CF");
            _total = Convert.ToDecimal(cab?["Total"] ?? 0m);
            Lbl_Total.Text = _total.ToString("N2");

            Dgv_Detalle.AutoGenerateColumns = true;
            Dgv_Detalle.ReadOnly = true;
            Dgv_Detalle.DataSource = _detalle;
            if (Dgv_Detalle.Columns.Contains("Precio")) Dgv_Detalle.Columns["Precio"].DefaultCellStyle.Format = "N2";
            if (Dgv_Detalle.Columns.Contains("Subtotal")) Dgv_Detalle.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
        }

        // printDocument1 en tu diseñador
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var g = e.Graphics;
            float y = 40;
            var font = new Font("Segoe UI", 9);
            var bold = new Font("Segoe UI", 9, FontStyle.Bold);

            g.DrawString("HOTEL SAN CARLOS — FACTURA (Detalle)", new Font("Segoe UI", 13, FontStyle.Bold), Brushes.Black, 40, y); y += 26;
            g.DrawLine(Pens.Black, 40, y, e.PageBounds.Width - 40, y); y += 10;

            g.DrawString($"Factura #: {Lbl_Numero.Text}", bold, Brushes.Black, 40, y); y += 18;
            g.DrawString($"Fecha: {Lbl_Fecha.Text}", font, Brushes.Black, 40, y); y += 18;
            g.DrawString($"Cliente: {Lbl_Cliente.Text}", font, Brushes.Black, 40, y); y += 18;
            g.DrawString($"Documento: {Lbl_Documento.Text}", font, Brushes.Black, 40, y); y += 18;

            y += 6;
            g.DrawString("Detalle", bold, Brushes.Black, 40, y); y += 16;
            g.DrawString("Producto", bold, Brushes.Black, 40, y);
            g.DrawString("Cant.", bold, Brushes.Black, 320, y);
            g.DrawString("Precio", bold, Brushes.Black, 380, y);
            g.DrawString("Subt.", bold, Brushes.Black, 460, y);
            y += 15;

            if (_detalle != null)
            {
                foreach (DataRow row in _detalle.Rows)
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
            g.DrawString($"TOTAL: Q {_total:0.00}", new Font("Segoe UI", 11, FontStyle.Bold), Brushes.Black, 460, y);
        }
    }
}
