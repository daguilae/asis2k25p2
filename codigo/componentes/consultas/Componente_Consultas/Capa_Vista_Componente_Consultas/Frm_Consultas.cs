using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Componente_Consultas;
using System.Text.RegularExpressions;

// CARLO ANDREE BARQUERO BOCHE 0901 - 22 - 601
// Diego André Monterroso Rabarique 0901-22-1369
// Samuel Estuardo Gómez Lec 0901-21-10616 (estandarizacion y reorganizacion del diseño)

namespace Capa_Vista_Componente_Consultas
{
    public partial class Frm_Consultas : Form
    {
        // BLOQUE 1: CONTROLADOR
        Controlador controlador = new Controlador();

        // BLOQUE 2: CONSTRUCTOR DEL FORMULARIO
        public Frm_Consultas()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;

            // Ordenar inmediatamente al marcar ASC/DESC (solo si ya hay datos)
            Rdb_asc.CheckedChanged += Orden_CheckedChanged;
            Rdb_desc.CheckedChanged += Orden_CheckedChanged;

            fun_CargarTablas();
        }

        // BLOQUE 3: EVENTO DE MENÚ "CREACIÓN"
        private void creaciònToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Creacion creacion = new Frm_Creacion();
            creacion.Show();
            this.Hide();
        }
        
        // RICHARD ANTONY DE LEON 0901 - 22 - 10265
        // BLOQUE 4: CARGA DE TABLAS EN EL COMBO BOX
        private void fun_CargarTablas()
        {
            try
            {
                DataTable tablas = controlador.fun_ObtenerTablas();
                if (tablas != null && tablas.Rows.Count > 0)
                {
                    string col = tablas.Columns[0].ColumnName;

                    DataTable vista = new DataTable();
                    vista.Columns.Add("Nombre");
                    vista.Columns.Add("Tabla");

                    foreach (DataRow r in tablas.Rows)
                    {
                        string real = r[col]?.ToString() ?? "";
                        string nombre = Regex.Replace(real, @"^tbl_?", "", RegexOptions.IgnoreCase);
                        vista.Rows.Add(nombre, real);
                    }

                    var dv = vista.DefaultView;
                    dv.Sort = "Nombre ASC";

                    cbo_Query.DisplayMember = "Nombre";
                    cbo_Query.ValueMember = "Tabla";
                    cbo_Query.DataSource = dv;
                }
                else
                {
                    MessageBox.Show("No se encontraron tablas en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tablas: " + ex.Message);
            }
        }

        // BLOQUE 5: BOTONES DE CONTROL DE VENTANA
        private void btn_cerrar_Click(object sender, EventArgs e) => this.Close();

        private void btn_min_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        // BLOQUE 6: NAVEGACIÓN ENTRE FORMULARIOS
        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Principal principal = new Frm_Principal();
            principal.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consulta_Compleja compleja = new Consulta_Compleja();
            compleja.Show();
            this.Close();
        }

        private void btn_min_Click_1(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void btn_max_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
        }
        // Diego André Monterroso Rabarique 0901-22-1369
        // BLOQUE 7: BÚSQUEDA SIMPLE (sin filtro)
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_Query.SelectedValue == null)
                {
                    MessageBox.Show("Selecciona una tabla del listado.", "Consulta",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string stabla = cbo_Query.SelectedValue.ToString();
                string sorden = string.Empty;
                DataTable resultado = controlador.fun_EjecutarConsulta(stabla, sorden);
                Dgv_consultas_simples.DataSource = resultado;

                if (Dgv_consultas_simples != null)
                    Dgv_consultas_simples.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar consulta: " + ex.Message);
            }
        }
        // Jose Pablo Medina 0901-22-22592
        // BLOQUE 8: BOTÓN FILTRAR (busca en todas las columnas)
        private void Btn_filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_Query.SelectedValue == null)
                {
                    MessageBox.Show("Selecciona una tabla del listado.", "Consulta",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string stabla = cbo_Query.SelectedValue.ToString();
                string sfiltro = Txt_Filtro.Text.Trim();  // texto del usuario
                string sorden = string.Empty;

                // Ejecutar consulta con filtro global
                DataTable resultado = controlador.fun_EjecutarConsultaConFiltro(stabla, sfiltro, sorden);
                Dgv_consultas_simples.DataSource = resultado;

                if (Dgv_consultas_simples != null)
                    Dgv_consultas_simples.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Mostrar SQL simulado
                string whereClause = string.IsNullOrWhiteSpace(sfiltro) ? "" : $" (Filtro: '{sfiltro}')";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar filtro: " + ex.Message);
            }
        }

        // BLOQUE 9: BOTÓN ACEPTAR
        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Consulta generada correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // RICHARD ANTONY DE LEON 0901 - 22 - 10265
        // BLOQUE 10: ORDENAMIENTO
        private void ListarTablaConOrdenActual()
        {
            try
            {
                if (cbo_Query.SelectedValue == null) return;

                string stabla = cbo_Query.SelectedValue.ToString();
                string sorden = (Rdb_asc != null && Rdb_asc.Checked) ? "ORDER BY 1 ASC"
                             : (Rdb_desc != null && Rdb_desc.Checked) ? "ORDER BY 1 DESC"
                             : string.Empty;

                DataTable dt = controlador.fun_EjecutarConsulta(stabla, sorden);
                Dgv_consultas_simples.DataSource = dt;

                if (Dgv_consultas_simples != null)
                    Dgv_consultas_simples.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar: " + ex.Message);
            }
        }

        private void Orden_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                if (Dgv_consultas_simples?.DataSource != null)
                {
                    ListarTablaConOrdenActual();
                }
            }
        }
    }
}
