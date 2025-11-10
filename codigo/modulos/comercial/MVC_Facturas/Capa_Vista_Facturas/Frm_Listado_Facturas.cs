using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Capa_Vista_Facturas

        // Juan Carlos Sandoval Quej 0901-22-4170 09/11/2025
{
    public partial class Frm_Listado_Facturas : Form
    {
        private static readonly string BaseDir = Frm_FacturaCrear.BaseDir;

        public Frm_Listado_Facturas()
        {
            InitializeComponent();

            Load += (s, e) => Recargar();
            Activated += (s, e) => Recargar();     // “tiempo real” al volver a enfocarse
            Btn_Buscar.Click += (s, e) => Recargar();
            Btn_VerDetalle.Click += Btn_VerDetalle_Click;

            Dgv_Facturas.AutoGenerateColumns = true;
            Dgv_Facturas.CellDoubleClick += (s, e) => { if (e.RowIndex >= 0) AbrirFila(e.RowIndex); };
        }

        private void Recargar()
        {
            Directory.CreateDirectory(BaseDir);
            string filtro = (Txt_Buscar.Text ?? "").Trim().ToUpperInvariant();

            var dt = new DataTable();
            dt.Columns.Add("Numero", typeof(int));
            dt.Columns.Add("Cliente", typeof(string));
            dt.Columns.Add("Documento", typeof(string));
            dt.Columns.Add("Fecha", typeof(DateTime));
            dt.Columns.Add("Total", typeof(decimal));
            dt.Columns.Add("Archivo", typeof(string)); // oculto para abrir detalle

            foreach (var file in Directory.GetFiles(BaseDir, "F*.xml"))
            {
                var ds = new DataSet();
                ds.ReadXml(file);
                var cab = ds.Tables["Cabecera"]?.Rows.Cast<DataRow>().FirstOrDefault();
                if (cab == null) continue;

                int numero = Convert.ToInt32(cab["Numero"]);
                string nombre = Convert.ToString(cab["Nombre"]);
                string apellido = Convert.ToString(cab["Apellido"]);
                string doc = Convert.ToString(cab["Documento"]);
                DateTime fecha = Convert.ToDateTime(cab["Fecha"]);
                decimal total = Convert.ToDecimal(cab["Total"]);

                string cliente = $"{nombre} {apellido}".Trim();

                if (string.IsNullOrWhiteSpace(filtro) ||
                    cliente.ToUpperInvariant().Contains(filtro) ||
                    doc.ToUpperInvariant().Contains(filtro) ||
                    numero.ToString().Contains(filtro))
                {
                    dt.Rows.Add(numero, cliente, doc, fecha, total, file);
                }
            }

            // Si no hay filas, evita CopyToDataTable()
            if (dt.Rows.Count == 0)
            {
                Dgv_Facturas.DataSource = dt;
            }
            else
            {
                var dtOrden = dt.AsEnumerable()
                                .OrderByDescending(r => r.Field<int>("Numero"))
                                .CopyToDataTable();
                Dgv_Facturas.DataSource = dtOrden;
            }

            if (Dgv_Facturas.Columns.Contains("Total"))
                Dgv_Facturas.Columns["Total"].DefaultCellStyle.Format = "N2";
            if (Dgv_Facturas.Columns.Contains("Archivo"))
                Dgv_Facturas.Columns["Archivo"].Visible = false;
        }

        private void Btn_VerDetalle_Click(object sender, EventArgs e)
        {
            if (Dgv_Facturas.CurrentRow == null)
            {
                // Si no seleccionó, abre el último (comodidad para demo)
                var files = Directory.GetFiles(BaseDir, "F*.xml");
                if (files.Length == 0) return;
                string ultimo = files.OrderByDescending(f =>
                {
                    var n = Path.GetFileNameWithoutExtension(f);
                    return int.TryParse(n.Substring(1), out var v) ? v : 0;
                }).First();
                new Frm_Detalle_Factura(ultimo).ShowDialog(this);
                return;
            }
            AbrirFila(Dgv_Facturas.CurrentRow.Index);
        }

        private void AbrirFila(int rowIndex)
        {
            if (rowIndex < 0) return;
            var archivo = Convert.ToString(Dgv_Facturas.Rows[rowIndex].Cells["Archivo"].Value);
            if (string.IsNullOrWhiteSpace(archivo) || !File.Exists(archivo))
            {
                MessageBox.Show("Archivo de factura no encontrado.");
                return;
            }
            new Frm_Detalle_Factura(archivo).ShowDialog(this);
        }
    }
}
