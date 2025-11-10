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
    public partial class Frm_Implosion : Form
    {
        Cls_Controlador_IE controlador = new Cls_Controlador_IE();
        public Frm_Implosion()
        {
            InitializeComponent();
        }
        private void pro_Frm_Implosion_Load(object sender, EventArgs e)
        {
            pro_CargarDatos();
            Lstv_Receta.View = View.Details;           
            Lstv_Receta.FullRowSelect = true;          
            Lstv_Receta.GridLines = true;              
            Lstv_Receta.Columns.Clear();
            Lstv_Receta.Columns.Add("Ingrediente");
            Lstv_Receta.Columns.Add("Cantidad");
            Lstv_Receta.Columns.Add("Unidad");
            Lstv_Receta.Columns.Add("Total Necesario");
            Lstv_Receta.Columns.Add("Stock en Inventario");
            Lstv_Receta.Columns.Add("Conversión");
            Lstv_Receta.Columns.Add("Disponibilidad");

            int iTotalColumnas = Lstv_Receta.Columns.Count;
            int iAnchoDisponible = Lstv_Receta.ClientSize.Width; 

            int iAnchoPorColumna = iAnchoDisponible / iTotalColumnas;

            foreach (ColumnHeader col in Lstv_Receta.Columns)
            {
                col.Width = iAnchoPorColumna;
            }

            Lbl_Resultado.Visible = false;
            Btn_OrdenCompra.Visible = false;

        }

        private void pro_CargarDatos()
        {

            try
            {
                DataTable datos = controlador.fun_DatosMenu();
                if (datos.Rows.Count > 0)
                {
                    DataRow fila = datos.NewRow();
                    fila["codigoMenu"] = 0;
                    fila["Platillo"] = "— Opciones de menú —";
                    datos.Rows.InsertAt(fila, 0);

                    Cbo_Platillos.DataSource = datos;
                    Cbo_Platillos.DisplayMember = "Platillo";
                    Cbo_Platillos.ValueMember = "codigoMenu";
                }
                else
                {
                    Cbo_Platillos.DataSource = null; 
                    Cbo_Platillos.Items.Clear();    
                    Cbo_Platillos.Items.Add("No hay platillos disponibles");
                    Cbo_Platillos.SelectedIndex = 0; 
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los menús: " + ex.Message);
            }

        }

        List<string> listaIngrediente = new List<string>();

        private void pro_Receta(int codigoMenu)
        {
            try
            {
                DataTable receta = controlador.fun_DatosReceta(codigoMenu);
                Lstv_Receta.Items.Clear();
                listaIngrediente.Clear();
                if (receta.Rows.Count == 0)
                {
                    MessageBox.Show("No hay receta asignada para el menú seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                foreach (DataRow fila in receta.Rows)
                {
                    string sIngrediente = fila["ingrediente"].ToString();
                    double doCantidad = Convert.ToDouble(fila["cantidad"]);
                    string sUnidad = fila["unidadMedida"].ToString();

                    ListViewItem item = new ListViewItem(sIngrediente);
                    item.SubItems.Add(doCantidad.ToString());
                    item.SubItems.Add(sUnidad);

                    Lstv_Receta.Items.Add(item);
                    listaIngrediente.Add(sIngrediente);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la receta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pro_CantidadTotal(int cantidadPlatillos)
        {
            if (Lstv_Receta.Items.Count > 0)
            {
                foreach (ListViewItem item in Lstv_Receta.Items)
                {
                    double doCantidadPorPlatillo = Convert.ToDouble(item.SubItems[1].Text);
                    double doCantidadNecesaria = doCantidadPorPlatillo * cantidadPlatillos;

                    if (item.SubItems.Count > 3)
                        item.SubItems[3].Text = doCantidadNecesaria.ToString();
                    else
                        item.SubItems.Add(doCantidadNecesaria.ToString());
                }
            }
        }


        private void pro_ConsultarInventario()
        {
            List<(string sCodigo, string sIngrediente, double doStock, string sUnidad)> Inventario = controlador.fun_verificarInventario(listaIngrediente);
            try
            {
                if (Lstv_Receta.Items.Count > 0)
                {
                    if (Inventario.Count != 0)
                    {
                        for (int i = 0; i < Lstv_Receta.Items.Count; i++)
                        {
                            ListViewItem item = Lstv_Receta.Items[i];
                            double doStock = Inventario[i].doStock;
                            string sUnidadInv = Inventario[i].sUnidad;
                            int.TryParse(Inventario[i].sCodigo, out int iCodigo);

                            item.Tag = iCodigo;
                            double doTotalNecesario = Convert.ToDouble(item.SubItems[3].Text);

                            string sUnidadReceta = item.SubItems[2].Text;    
                            double doStockConvertido;
                            try
                            {
                                doStockConvertido = Cls_Conversion_Unidad.Convertir(doStock, sUnidadInv, sUnidadReceta);
                            }
                            catch (Exception ex)
                            {
                                System.Diagnostics.Debug.WriteLine("Error al convertir unidad: " + ex.Message);
                                doStockConvertido = doStock;
                            }


                            string sCantidad = $"{doStock} {sUnidadInv}";
                            item.SubItems.Add(sCantidad);

                            item.SubItems.Add(doStockConvertido.ToString());
                        }
                    }
                }
                else return;
            } catch(Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de inventario " + ex.Message);
            }
        }

        private void pro_ResultadoDisponibilidad()
        {
            bool bDisponibilidad = false;

            foreach (ListViewItem item in Lstv_Receta.Items)
            {
                if (item.SubItems.Count >= 5)
                {
                    bool bTotal = double.TryParse(item.SubItems[3].Text, out double doTotalNecesario);
                    bool bStock = double.TryParse(item.SubItems[5].Text, out double doStockConvertido);

                    if (!bTotal || !bStock)
                        continue; 

                    string sDisponibilidad = doStockConvertido >= doTotalNecesario ? "Suficiente" : "Insuficiente";

                    if (item.SubItems.Count > 6)
                        item.SubItems[6].Text = sDisponibilidad;
                    else
                        item.SubItems.Add(sDisponibilidad);

                    if (sDisponibilidad == "Insuficiente")
                        bDisponibilidad = true;
                }
            }

            Lbl_Resultado.Visible = bDisponibilidad;
            Btn_OrdenCompra.Visible = bDisponibilidad;
        }


        private void pro_LimpiarColumnas()
        {
            foreach (ListViewItem item in Lstv_Receta.Items)
            {
                while (item.SubItems.Count > 3) 
                {
                    item.SubItems.RemoveAt(3);
                }
            }
        }

        private void pro_LimpiarColumnasCalculo()
        {
            foreach (ListViewItem item in Lstv_Receta.Items)
            {
                if (item.SubItems.Count > 3)
                    item.SubItems[3].Text = string.Empty;

                if (item.SubItems.Count > 6)
                    item.SubItems[6].Text = string.Empty;
            }
        }



        private void pro_Cbo_Platillos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lbl_Resultado.Visible = false;
            Btn_OrdenCompra.Visible = false;
            try
            {
                if (Cbo_Platillos.SelectedValue == null) return;
                if (Cbo_Platillos.SelectedValue is DataRowView)return;

                int icodigoMenu = Convert.ToInt32(Cbo_Platillos.SelectedValue);

                if (icodigoMenu > 0)
                {
                    pro_Receta(icodigoMenu);
                }
                else
                {
                    Lstv_Receta.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la receta: " + ex.Message);
            }
        }

        private void pro_Btn_Consulta_Click(object sender, EventArgs e)
        {
            if (Cbo_Platillos.SelectedValue == null || (int)Cbo_Platillos.SelectedValue == 0)
            {
                MessageBox.Show("Debe seleccionar un platillo válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(!int.TryParse(Txt_Cantidad.Text, out int cantidad))
            {
                MessageBox.Show("Debe ingresar un número válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Lstv_Receta.Items.Count > 0 && Lstv_Receta.Items[0].SubItems.Count > 3)
            {
                pro_LimpiarColumnasCalculo();
                pro_CantidadTotal(cantidad);
                pro_ResultadoDisponibilidad();
            }
            else
            {
                pro_LimpiarColumnas();
                pro_CantidadTotal(cantidad);
                pro_ConsultarInventario();
                pro_ResultadoDisponibilidad();
            }

        }

        private void pro_Btn_OrdenCompra_Click(object sender, EventArgs e)
        {
            List<(int iCodigo, string sIngrediente, double doCantidadFaltante)> listaFaltantes
                = new List<(int, string, double)>();

            List<string> listaNoRegistrados = new List<string>();

            foreach (ListViewItem item in Lstv_Receta.Items)
            {
                if (item.SubItems.Count > 6)
                {
                    string sDisponibilidad = item.SubItems[6].Text.Trim();

                    if (sDisponibilidad.Equals("Insuficiente", StringComparison.OrdinalIgnoreCase))
                    {
                        string sIngrediente = item.SubItems[0].Text.Trim();
                        int iCodigo = (int)item.Tag;

                        if (iCodigo == 0)
                        {
                            listaNoRegistrados.Add(sIngrediente);
                            continue;
                        }

                        double doTotalNecesario = Convert.ToDouble(item.SubItems[3].Text);
                        string sColumnaStock = item.SubItems[4].Text.Split(' ')[0];
                        double doStock = Convert.ToDouble(sColumnaStock);

                        double doCantidadFaltante = doTotalNecesario - doStock;
                        if (doCantidadFaltante < 0)
                            doCantidadFaltante = 0;

                        listaFaltantes.Add((iCodigo, sIngrediente, doCantidadFaltante));
                    }
                }
            }
            // Si no hay productos registrados, indicar mensaje
            if (listaNoRegistrados.Count > 0)
            {
                string sMensaje = "Debe registrar los siguientes productos antes de generar la orden de compra:\n\n" +
                                 string.Join("\n", listaNoRegistrados);

                MessageBox.Show(sMensaje, "Productos no registrados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Si no hay productos validos para generar compra
            if (listaFaltantes.Count == 0)
            {
                MessageBox.Show("No hay productos válidos para generar orden de compra.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Frm_Crear_OrdenCompra formulario = new Frm_Crear_OrdenCompra(listaFaltantes);
            formulario.Show();
        }

    }
}

