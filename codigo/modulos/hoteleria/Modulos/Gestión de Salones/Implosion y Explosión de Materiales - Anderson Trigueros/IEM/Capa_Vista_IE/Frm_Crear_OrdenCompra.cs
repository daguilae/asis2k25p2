using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_IE;

namespace Capa_Vista_IE
{
    public partial class Frm_Crear_OrdenCompra : Form
    {
        Cls_Controlador_IE controlador = new Cls_Controlador_IE(); 
        private List<(int iCodigo, string sIngrediente, double doCantidad)> lista;
        public Frm_Crear_OrdenCompra(List<(int iCodigo, string sIngrediente, double doCantidad)> Listado)
        {
            InitializeComponent();
            lista = Listado;
        }

        private void pro_Frm_Crear_OrdenCompra_Load(object sender, EventArgs e)
        {
            Dgv_ListadoCompra.Columns.Clear();

            Dgv_ListadoCompra.Columns.Add("ingrediente", "Producto");
            Dgv_ListadoCompra.Columns.Add("cantidad", "Cantidad a Comprar");

            Dgv_ListadoCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_ListadoCompra.AllowUserToAddRows = false;
            Dgv_ListadoCompra.Columns[0].ReadOnly = true;

            pro_MostrarDatos(lista);
        }

        public void pro_MostrarDatos(List<(int iCodigo, string sIngrediente, double doCantidad)> Listado)
        {
            Dgv_ListadoCompra.Rows.Clear();

            foreach (var (iCodigo, sIngrediente, doCantidad) in Listado)
            {
                int iFila = Dgv_ListadoCompra.Rows.Add(sIngrediente, doCantidad);
                Dgv_ListadoCompra.Rows[iFila].Tag = iCodigo;
            }
        }

        private void pro_GenerarOrden()
        {
            var listaCompra = new List<(int iCodigo, double doCantidad)>();
            foreach (DataGridViewRow fila in Dgv_ListadoCompra.Rows)
            {
                int iCodigo = (int)fila.Tag;

                double doCantidad = 0;
                double.TryParse(fila.Cells["cantidad"].Value?.ToString(), out doCantidad);

                listaCompra.Add((iCodigo, doCantidad));
            }
            try
            {
                controlador.pro_GenerarOrdenCompra(listaCompra);
                MessageBox.Show("Orden de Compra Registrada Correctamente.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al ingresar la orden de compra " + ex.Message);
            }

        }


        private void pro_Btn_Guardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in Dgv_ListadoCompra.Rows)
            {
                if (fila.Cells["cantidad"].Value != null)
                {
                    string sValor = fila.Cells["cantidad"].Value.ToString().Trim();

                    if (!double.TryParse(sValor, out double doCantidad))
                    {
                        MessageBox.Show($"El valor '{sValor}' no es un número válido.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (doCantidad <= 0)
                    {
                        MessageBox.Show($"El valor '{sValor}' debe ser mayor que cero.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
            }
            pro_GenerarOrden();
        }

        private void pro_Pic_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
