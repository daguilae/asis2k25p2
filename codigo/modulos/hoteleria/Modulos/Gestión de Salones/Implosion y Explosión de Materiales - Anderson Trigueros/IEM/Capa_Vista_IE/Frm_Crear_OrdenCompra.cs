using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_IE
{
    public partial class Frm_Crear_OrdenCompra : Form
    {
        private List<(string sIngrediente, double doCantidad)> lista;

        public Frm_Crear_OrdenCompra(List<(string sIngrediente, double doCantidad)> Listado)
        {
            InitializeComponent();
            lista = Listado;
        }

        private void Frm_Crear_OrdenCompra_Load(object sender, EventArgs e)
        {
            Dgv_ListadoCompra.Columns.Clear();

            Dgv_ListadoCompra.Columns.Add("ingrediente", "Producto");
            Dgv_ListadoCompra.Columns.Add("cantidad", "Cantidad a Comprar");

            Dgv_ListadoCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_ListadoCompra.AllowUserToAddRows = false;
            Dgv_ListadoCompra.Columns[0].ReadOnly = true;

            mostrarDatos(lista);
        }

        public void mostrarDatos(List<(string sIngrediente, double doCantidad)> Listado)
        {
            Dgv_ListadoCompra.Rows.Clear();

            foreach (var (sIngrediente, doCantidad) in Listado)
            {
                Dgv_ListadoCompra.Rows.Add(sIngrediente, doCantidad);
            }
        }


    }
}
