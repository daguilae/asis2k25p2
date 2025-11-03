using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_Vista_Facturas
{
    public partial class Frm_Listado_Facturas : Form
    {
        // ⚠️ Lista estática en memoria (no crea archivos nuevos)
        public static readonly DataTable TablaFacturas;

        static Frm_Listado_Facturas()
        {
            TablaFacturas = new DataTable();
            TablaFacturas.Columns.Add("Numero", typeof(int));         // correlativo de factura
            TablaFacturas.Columns.Add("IdVenta", typeof(int));        // id de la venta en BD
            TablaFacturas.Columns.Add("Nombre", typeof(string));
            TablaFacturas.Columns.Add("Apellido", typeof(string));
            TablaFacturas.Columns.Add("Documento", typeof(string));   // NIT/CF
            TablaFacturas.Columns.Add("Fecha", typeof(DateTime));
            TablaFacturas.Columns.Add("Items", typeof(int));
            TablaFacturas.Columns.Add("Total", typeof(decimal));
        }

        public Frm_Listado_Facturas()
        {
            InitializeComponent();
            this.Load += Frm_Listado_Facturas_Load;
        }

        private void Frm_Listado_Facturas_Load(object sender, EventArgs e)
        {
            Dgv_Facturas.AutoGenerateColumns = true;
            Dgv_Facturas.ReadOnly = true;
            Dgv_Facturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Facturas.DataSource = TablaFacturas;
        }
    }
}
