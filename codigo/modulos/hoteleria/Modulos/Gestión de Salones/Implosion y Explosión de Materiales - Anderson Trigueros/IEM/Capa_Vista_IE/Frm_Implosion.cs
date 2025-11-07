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
        private void Frm_Implosion_Load(object sender, EventArgs e)
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
            Lstv_Receta.Columns.Add("Disponibilidad");

            int totalColumnas = Lstv_Receta.Columns.Count;
            int anchoDisponible = Lstv_Receta.ClientSize.Width; 

            int anchoPorColumna = anchoDisponible / totalColumnas;

            foreach (ColumnHeader col in Lstv_Receta.Columns)
            {
                col.Width = anchoPorColumna;
            }

            Lbl_Resultado.Visible = false;
            Btn_OrdenCompra.Visible = false;

        }

        private void pro_CargarDatos()
        {

            try
            {
                DataTable datos = controlador.DatosMenu();
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
                DataTable receta = controlador.DatosReceta(codigoMenu);
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
                    double cantidadPorPlatillo = Convert.ToDouble(item.SubItems[1].Text);
                    double cantidadNecesaria = cantidadPorPlatillo * cantidadPlatillos;
                    item.SubItems.Add(cantidadNecesaria.ToString());
                }
            }
        }

        private void pro_ConsultarInventario()
        {
            List<(string sIngrediente, double doStock)> Inventario = controlador.verificarInventario(listaIngrediente);
            try
            {
                if (Lstv_Receta.Items.Count > 0)
                {
                    if (Inventario.Count != 0)
                    {
                        for (int i = 0; i < Lstv_Receta.Items.Count; i++)
                        {
                            ListViewItem item = Lstv_Receta.Items[i];
                            double stock = Inventario[i].doStock;
                            item.SubItems.Add(stock.ToString());

                            double totalNecesario = Convert.ToDouble(item.SubItems[3].Text);
                            string disponibilidad = stock >= totalNecesario ? "Suficiente" : "Insuficiente";
                            item.SubItems.Add(disponibilidad);
                        }
                    }
                }
                else return;
            } catch(Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de inventario " + ex.Message);
            }
        }

        private void pro_ResultadoInventario()
        {
            bool hayInsuficiente = false;

            foreach (ListViewItem item in Lstv_Receta.Items)
            {
                if (item.SubItems.Count > 5)
                {
                    string disponibilidad = item.SubItems[5].Text.Trim();
                    if (disponibilidad.Equals("Insuficiente", StringComparison.OrdinalIgnoreCase))
                    {
                        hayInsuficiente = true;
                        break;
                    }
                }
            }
    
            Lbl_Resultado.Visible = hayInsuficiente;
            Btn_OrdenCompra.Visible = hayInsuficiente;
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

        private void Cbo_Platillos_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Btn_Consulta_Click(object sender, EventArgs e)
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
            pro_LimpiarColumnas();
            pro_CantidadTotal(cantidad);
            pro_ConsultarInventario();
            pro_ResultadoInventario();
        }

        private void Btn_OrdenCompra_Click(object sender, EventArgs e)
        {
            List<(string sIngrediente, double doCantidadFaltante)> listaFaltantes = new List<(string, double)>();

            foreach (ListViewItem item in Lstv_Receta.Items)
            {
                if (item.SubItems.Count > 5)
                {
                    string sDisponibilidad = item.SubItems[5].Text.Trim();
                    if (sDisponibilidad.Equals("Insuficiente", StringComparison.OrdinalIgnoreCase))
                    {
                        string sIngrediente = item.SubItems[0].Text.Trim();
                        double doTotalNecesario = Convert.ToDouble(item.SubItems[3].Text);
                        double doStock = Convert.ToDouble(item.SubItems[4].Text);

                        double doCantidadFaltante = doTotalNecesario - doStock;
                        if (doCantidadFaltante < 0) doCantidadFaltante = 0; // Evitar negativos

                        listaFaltantes.Add((sIngrediente, doCantidadFaltante));
                    }
                }
            }
            Frm_Crear_OrdenCompra formulario = new Frm_Crear_OrdenCompra(listaFaltantes);
            formulario.Show();
        }
    }
}

