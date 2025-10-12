using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Componente_Consultas;
namespace Capa_Vista_Componente_Consultas_simples

    // CARLO ANDREE BARQUERO BOCHE 0901-22-601

{
    public partial class Consulta_simple : UserControl
    {
        Controlador controlador = new Controlador();

        public Consulta_simple()
        {
            InitializeComponent();
            fun_CargarTablas();
            Rdb_asc.CheckedChanged += Orden_CheckedChanged;
            Rdb_desc.CheckedChanged += Orden_CheckedChanged;
        }

        // Funcion para la carga de Tablas
        private void fun_CargarTablas()
        {
            try
            {
                DataTable tablas = controlador.fun_ObtenerTablas();
                if (tablas != null && tablas.Rows.Count > 0)
                {
                    string col = tablas.Columns[0].ColumnName; // nombre real de tabla (con prefijo)

                    DataTable vista = new DataTable();
                    vista.Columns.Add("Nombre"); // display sin prefijos
                    vista.Columns.Add("Tabla");  // value real con prefijo

                    foreach (DataRow r in tablas.Rows)
                    {
                        string real = r[col]?.ToString() ?? "";
                        string nombre = Regex.Replace(real, @"^tbl_?", "", RegexOptions.IgnoreCase);
                        // Si también quieres ocultar "vw_" al inicio, descomenta:
                        // nombre = Regex.Replace(nombre, @"^vw_?", "", RegexOptions.IgnoreCase);

                        vista.Rows.Add(nombre, real);
                    }

                    var dv = vista.DefaultView;
                    dv.Sort = "Nombre ASC";

                    cbo_Query.DisplayMember = "Nombre";
                    cbo_Query.ValueMember = "Tabla";
                    cbo_Query.DataSource = dv;

                    // ❌ No cargamos datos aquí. Solo al presionar Buscar.
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


        // Funcion para la busqueda

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_Query.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una tabla primero.");
                    return;
                }

                string stabla = cbo_Query.SelectedValue.ToString();
                string sorden = "";

                if (Rdb_asc.Checked)
                    sorden = "ORDER BY 1 ASC";
                else if (Rdb_desc.Checked)
                    sorden = "ORDER BY 1 DESC";
                DataTable resultado = controlador.fun_EjecutarConsulta(stabla, sorden);

                Dgv_consultas_simples.DataSource = resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar consulta: " + ex.Message);
            }
        }

      
        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Consulta generada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // RICHARD ANTHONY DE LEÓN MILIAN 0901 - 22 - 10265
        // Reutiliza el controlador para re-listar con el orden actual
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
        // RICHARD ANTHONY DE LEÓN MILIAN 0901 - 22 - 10265
        // Solo reordena si ya hay datos en la grilla
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


    }

}

