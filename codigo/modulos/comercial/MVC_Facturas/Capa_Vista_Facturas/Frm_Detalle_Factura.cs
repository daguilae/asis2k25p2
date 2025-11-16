using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Capa_Controlador_Facturas;

namespace Capa_Vista_Facturas
{
    // Juan Carlos Sandoval Quej 0901-22-4170 12/11/2025
    public partial class Frm_Detalle_Factura : Form
    {
        // id de la venta que se va a mostrar
        private readonly int _idVenta;

        // tabla con el detalle que viene de la BD (vista)
        private DataTable _detalle;

        // total calculado para mostrar e imprimir
        private decimal _total;

        // controlador para llamar a consultas
        private readonly Cls_Controlador _ctrl = new Cls_Controlador();

        public Frm_Detalle_Factura(int idVenta)
        {
            _idVenta = idVenta;
            InitializeComponent();

            // eventos del formulario y botones
            Load += Frm_Detalle_Factura_Load;
            Btn_Cerrar.Click += (s, e) => Close();
            Btn_Imprimir.Click += (s, e) =>
            {
                // vista previa de impresión
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.UseAntiAlias = true;
                printPreviewDialog1.ShowDialog();
            };

            // evento de impresión
            printDocument1.PrintPage += printDocument1_PrintPage;
        }

        // función corta para verificar si una columna existe
        private static bool HasCol(DataTable dt, string col)
            => dt != null && dt.Columns.Contains(col);

        private void Frm_Detalle_Factura_Load(object sender, EventArgs e)
        {
            // 1) obtener el detalle de la venta desde la vista de BD
            _detalle = _ctrl.DetalleFacturaPorVentaBD(_idVenta) ?? new DataTable();

            // 2) obtener datos del encabezado desde el listado (número, fecha, cliente, documento, total)
            var listado = _ctrl.ListadoFacturasBD();
            DataRow hdr = listado?.AsEnumerable().FirstOrDefault(r => r.Field<int>("IdVenta") == _idVenta);

            // número de factura (si no hay, usar el id de venta)
            Lbl_Numero.Text = Convert.ToString(hdr?["Numero"] ?? _idVenta);

            // fecha (si no hay, usar fecha actual)
            DateTime fecha = DateTime.Now;
            if (hdr != null && listado.Columns.Contains("Fecha") && hdr["Fecha"] != DBNull.Value)
                fecha = Convert.ToDateTime(hdr["Fecha"]);
            Lbl_Fecha.Text = fecha.ToString("dd/MM/yyyy");

            // cliente y documento 
            Lbl_Cliente.Text = Convert.ToString(hdr?["Cliente"] ?? "").Trim();
            Lbl_Documento.Text = Convert.ToString(hdr?["Documento"] ?? "CF");

            // 3) cálculo del total de forma segura según columnas disponibles
            if (HasCol(_detalle, "Cmp_Total"))
                _total = _detalle.AsEnumerable().Sum(r => Convert.ToDecimal(r["Cmp_Total"]));
            else if (HasCol(_detalle, "Cmp_PrecioUnitario") && HasCol(_detalle, "Cmp_Cantidad"))
                _total = _detalle.AsEnumerable()
                                 .Sum(r => Convert.ToDecimal(r["Cmp_PrecioUnitario"]) * Convert.ToDecimal(r["Cmp_Cantidad"]));
            else
                _total = 0m;
            Lbl_Total.Text = _total.ToString("N2");

            // 4) configurar grid y enlazar datos
            Dgv_Detalle.AutoGenerateColumns = true;
            Dgv_Detalle.ReadOnly = true;
            Dgv_Detalle.DataSource = _detalle;

            // volver a calcular total por si la vista usa nombres distintos
            decimal total = 0m;
            if (_detalle != null && _detalle.Rows.Count > 0)
            {
                if (_detalle.Columns.Contains("Cmp_Total"))
                    total = _detalle.AsEnumerable().Sum(r => Convert.ToDecimal(r["Cmp_Total"]));
                else if (_detalle.Columns.Contains("Subtotal"))
                    total = _detalle.AsEnumerable().Sum(r => Convert.ToDecimal(r["Subtotal"]));
                else if (_detalle.Columns.Contains("Cmp_PrecioUnitario") && _detalle.Columns.Contains("Cmp_Cantidad"))
                    total = _detalle.AsEnumerable()
                                    .Sum(r => Convert.ToDecimal(r["Cmp_PrecioUnitario"]) * Convert.ToDecimal(r["Cmp_Cantidad"]));
            }
            _total = total;
            Lbl_Total.Text = _total.ToString("0.00");

            // formatos de columnas 
            void fmt(string col, string format)
            {
                if (Dgv_Detalle.Columns.Contains(col))
                    Dgv_Detalle.Columns[col].DefaultCellStyle.Format = format;
            }
            fmt("Cmp_PrecioUnitario", "N2");
            fmt("Cmp_Total", "N2");
            fmt("Cmp_Cantidad", "0");  // sin decimales para cantidades
            fmt("Cantidad", "0");      // alternativa
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // objetos básicos para dibujar
            var g = e.Graphics;
            float y = 40;
            var font = new Font("Segoe UI", 9);
            var bold = new Font("Segoe UI", 9, FontStyle.Bold);

            // título
            g.DrawString("HOTEL SAN CARLOS — FACTURA", new Font("Segoe UI", 13, FontStyle.Bold), Brushes.Black, 40, y);
            y += 26;
            g.DrawLine(Pens.Black, 40, y, e.PageBounds.Width - 40, y);
            y += 10;

            // encabezado
            g.DrawString($"Venta/Factura #: {Lbl_Numero.Text}", bold, Brushes.Black, 40, y); y += 18;
            g.DrawString($"Fecha: {Lbl_Fecha.Text}", font, Brushes.Black, 40, y); y += 18;
            g.DrawString($"Cliente: {Lbl_Cliente.Text}", font, Brushes.Black, 40, y); y += 18;
            g.DrawString($"Documento: {Lbl_Documento.Text}", font, Brushes.Black, 40, y); y += 18;

            // columnas del detalle
            y += 6;
            g.DrawString("Detalle", bold, Brushes.Black, 40, y); y += 16;
            g.DrawString("Producto", bold, Brushes.Black, 40, y);
            g.DrawString("Cant.", bold, Brushes.Black, 320, y);
            g.DrawString("Precio", bold, Brushes.Black, 380, y);
            g.DrawString("Subt.", bold, Brushes.Black, 460, y);
            y += 15;

            // recorrer filas del detalle
            foreach (DataRow row in _detalle.Rows)
            {
                // buscar nombres posibles de columnas 
                string producto =
                    HasCol(_detalle, "Cmp_Nombre_Producto") ? Convert.ToString(row["Cmp_Nombre_Producto"]) :
                    HasCol(_detalle, "Producto") ? Convert.ToString(row["Producto"]) : "";

                decimal cant =
                    HasCol(_detalle, "Cmp_Cantidad") ? Convert.ToDecimal(row["Cmp_Cantidad"]) :
                    HasCol(_detalle, "Cantidad") ? Convert.ToDecimal(row["Cantidad"]) : 0m;

                decimal precio =
                    HasCol(_detalle, "Cmp_PrecioUnitario") ? Convert.ToDecimal(row["Cmp_PrecioUnitario"]) :
                    HasCol(_detalle, "Precio") ? Convert.ToDecimal(row["Precio"]) : 0m;

                decimal sub =
                    HasCol(_detalle, "Cmp_Total") ? Convert.ToDecimal(row["Cmp_Total"]) :
                    (precio * cant);

                g.DrawString(producto, font, Brushes.Black, 40, y);
                g.DrawString(cant.ToString("0"), font, Brushes.Black, 320, y);
                g.DrawString(precio.ToString("0.00"), font, Brushes.Black, 380, y);
                g.DrawString(sub.ToString("0.00"), font, Brushes.Black, 460, y);
                y += 15;

                // salto de página manual
                if (y > e.MarginBounds.Bottom - 80) { e.HasMorePages = true; return; }
            }

            // total
            y += 8;
            g.DrawLine(Pens.Black, 40, y, e.PageBounds.Width - 40, y);
            y += 10;
            g.DrawString($"TOTAL: Q {_total:0.00}", new Font("Segoe UI", 11, FontStyle.Bold), Brushes.Black, 460, y);
        }
    }
}
