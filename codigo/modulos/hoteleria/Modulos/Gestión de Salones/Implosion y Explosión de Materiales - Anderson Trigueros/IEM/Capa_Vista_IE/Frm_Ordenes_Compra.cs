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
    public partial class Frm_Ordenes_Compra : Form
    {
        Cls_Controlador_IE controlador = new Cls_Controlador_IE();
        private int iCodigoOC = -1;
        public Frm_Ordenes_Compra()
        {
            InitializeComponent();
        }

        private void pro_Frm_Ordenes_Compra_Load(object sender, EventArgs e)
        {
            Dgv_Ordenes.Columns.Clear();
            Dgv_Ordenes.Columns.Add("noOrden", "No. Orden");
            Dgv_Ordenes.Columns.Add("fecha", "Fecha de Orden");
            Dgv_Ordenes.Columns.Add("producto", "Producto");
            Dgv_Ordenes.Columns.Add("cantidad", "Cantidad");

            Dgv_Ordenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Ordenes.AllowUserToAddRows = false;
            Dgv_Ordenes.ReadOnly = true;
            pro_ObtenerOrdenes();

        }

        private void pro_ObtenerOrdenes()
        {
            try
            {
                DataTable tabla = controlador.fun_DatosOrdenes();
                Dgv_Ordenes.Rows.Clear();

                foreach (DataRow fila in tabla.Rows)
                {
                    int iIndice = Dgv_Ordenes.Rows.Add();

                    Dgv_Ordenes.Rows[iIndice].Cells["noOrden"].Value = fila["CodigoOrden"];
                    Dgv_Ordenes.Rows[iIndice].Cells["fecha"].Value = Convert.ToDateTime(fila["Fecha"]).ToString("dd/MM/yyyy");
                    Dgv_Ordenes.Rows[iIndice].Cells["producto"].Value = fila["producto"];
                    Dgv_Ordenes.Rows[iIndice].Cells["cantidad"].Value = fila["Cantidad"];

                    Dgv_Ordenes.Rows[iIndice].Tag = fila["codigo"]; 
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pro_Dgv_Ordenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = Dgv_Ordenes.Rows[e.RowIndex];
                string sNoOrden = filaSeleccionada.Cells["noOrden"].Value?.ToString();
                string sProducto = filaSeleccionada.Cells["producto"].Value?.ToString();
                string sCantidad = filaSeleccionada.Cells["cantidad"].Value?.ToString();

                int iCodigoOrden = 0;
                if (filaSeleccionada.Tag != null)
                    int.TryParse(filaSeleccionada.Tag.ToString(), out iCodigoOrden);
                iCodigoOC = iCodigoOrden;

                Txt_Orden.Text = sNoOrden;
                Txt_Producto.Text = sProducto;
                Txt_Cantidad.Text = sCantidad;
            }
        }

        private void pro_Btn_modificar_Click(object sender, EventArgs e)
        {
            double doCantidadNueva = 0;

            if (iCodigoOC < 0)
            {
                MessageBox.Show("Seleccione primero la fila de la orden que desea actualizar");
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_Cantidad.Text))
            {
                MessageBox.Show("Ingrese una cantidad válida");
                return;
            }

            if (!double.TryParse(Txt_Cantidad.Text, out double doValorIngresado))
            {
                MessageBox.Show("Ingrese un valor numérico válido");
                return;
            }

            if (doValorIngresado <= 0)
            {
                MessageBox.Show("Ingrese una cantidad mayor a 0");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Desea actualizar la cantidad de la orden?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
                return;

            doCantidadNueva = doValorIngresado;

            try
            {
                controlador.pro_ActualizarCantidad(iCodigoOC, doCantidadNueva);

                iCodigoOC = -1;
                Txt_Orden.Clear();
                Txt_Producto.Clear();
                Txt_Cantidad.Clear();
                MessageBox.Show("Orden de Compra Actualizada.");

                pro_ObtenerOrdenes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar la orden de compra " + ex.Message);
            }
        }

        private void pro_Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (iCodigoOC < 0)
            {
                MessageBox.Show("Seleccione primero la fila de la orden que desea eliminar");
                return;
            }
            DialogResult resultado = MessageBox.Show(
               "¿Desea eliminar el detalle de la orden de compra?",
               "Confirmación",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (resultado == DialogResult.No)
                return;
            try
            {
                controlador.pro_EliminarOrden(iCodigoOC);
                MessageBox.Show("Detalle eliminado de la orden de compra.");
                iCodigoOC = -1;
                Txt_Orden.Clear();
                Txt_Producto.Clear();
                Txt_Cantidad.Clear();
                pro_ObtenerOrdenes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el detalle de compra " + ex.Message);
            }

        }

        private void pro_Btn_Limpiar_Click(object sender, EventArgs e)
        {
            iCodigoOC = -1;
            Txt_Orden.Clear();
            Txt_Producto.Clear();
            Txt_Cantidad.Clear();
        }

        private void pro_Btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte_IE reporte = new Frm_Reporte_IE();
            reporte.Show();
        }
    }
}
