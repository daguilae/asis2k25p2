using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Capa_Controlador_Componente_Consultas;

// CARLO ANDREE BARQUERO BOCHE 0901-22-601
// Diego André Monterroso Rabarique 0901-22-1369
// Samuel Estuardo Gómez Lec 0901-21-10616 (estandarizacion y reorganizacion del diseño)


namespace Capa_Vista_Componente_Consultas
{
    public partial class Frm_Consultas : Form
    {
        private Controlador controlador = new Controlador();
        private string nombreTablaExterna;
        private Dictionary<string, string> mapNombreAmigableAReal = new Dictionary<string, string>();

        // CARLO ANDREE BARQUERO BOCHE 0901-22-601
        // Constructor principal (recibe el nombre de la tabla desde otro módulo)
        public Frm_Consultas(string nombreTabla)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;

            nombreTablaExterna = nombreTabla;

            Rdb_asc.CheckedChanged += Orden_CheckedChanged;
            Rdb_desc.CheckedChanged += Orden_CheckedChanged;
        }

        // CARLO ANDREE BARQUERO BOCHE 0901-22-601
        // Constructor vacío (compatibilidad con diseñador)
        public Frm_Consultas() : this(string.Empty) { }

        private void Frm_Consultas_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nombreTablaExterna))
            {
                CargarDatosTabla(nombreTablaExterna);
            }
        }

        // CARLO ANDREE BARQUERO BOCHE 0901-22-601
        //  Método para cambiar tabla dinámicamente
        public void CambiarTabla(string nuevaTabla)
        {
            nombreTablaExterna = nuevaTabla;
            CargarDatosTabla(nombreTablaExterna);
        }

        // CARLO ANDREE BARQUERO BOCHE 0901-22-601
        //  Cargar datos iniciales y llenar combos
        private void CargarDatosTabla(string tabla)
        {
            try
            {
                DataTable datos = controlador.fun_EjecutarConsulta(tabla, "");
                Dgv_consultas_simples.DataSource = datos;
                Dgv_consultas_simples.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                LlenarComboCamposConFriendlyNames(datos);
                LlenarComboOperadores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
        // CARLO ANDREE BARQUERO BOCHE 0901-22-601
        // Llenar operadores
        private void LlenarComboOperadores()
        {
            cbo_Operador.Items.Clear();
            cbo_Operador.Items.AddRange(new string[]
            {
                "=",
                "!=",
                ">",
                "<",
                ">=",
                "<=",
                "Contiene",
                "Comienza con",
                "Termina con"
            });
            cbo_Operador.SelectedIndex = 0;
        }
        // Diego André Monterroso Rabarique 0901-22-1369
        // Genera nombres amigables y los vincula con sus verdaderos nombres
        private void LlenarComboCamposConFriendlyNames(DataTable resultado)
        {
            cbo_Campos.Items.Clear();
            mapNombreAmigableAReal.Clear();

            foreach (DataColumn col in resultado.Columns)
            {
                string friendly = col.ColumnName;
                friendly = Regex.Replace(friendly, @"^(cmp_|tbl_|cmp|pk_|pkid_)?", "", RegexOptions.IgnoreCase);
                friendly = friendly.Replace("_", " ");
                friendly = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(friendly.ToLower());

                string key = friendly;
                int i = 1;
                while (mapNombreAmigableAReal.ContainsKey(key))
                {
                    key = friendly + " (" + i + ")";
                    i++;
                }

                mapNombreAmigableAReal[key] = col.ColumnName;
                cbo_Campos.Items.Add(key);
            }

            if (cbo_Campos.Items.Count > 0)
                cbo_Campos.SelectedIndex = 0;
        }
        // Diego André Monterroso Rabarique 0901-22-1369
        // Botón Buscar (carga todos los registros de la tabla)
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreTablaExterna))
            {
                MessageBox.Show("No se ha recibido el nombre de la tabla.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarDatosTabla(nombreTablaExterna);
        }
        // Jose Pablo Medina 0901-22-22592
        // Botón Filtrar (realiza consulta simple)
        private void Btn_filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombreTablaExterna))
                {
                    MessageBox.Show("No se ha recibido el nombre de la tabla.", "Consulta",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbo_Campos.SelectedItem == null || cbo_Operador.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona un campo y un operador.", "Filtro",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string friendly = cbo_Campos.SelectedItem.ToString();
                string operador = cbo_Operador.SelectedItem.ToString();
                string valorRaw = Txt_Filtro.Text.Trim();

                if (string.IsNullOrWhiteSpace(valorRaw))
                {
                    MessageBox.Show("Ingresa un valor para filtrar.", "Filtro",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string campoReal = mapNombreAmigableAReal[friendly];
                string sorden = (Rdb_asc.Checked ? "ORDER BY 1 ASC" :
                                (Rdb_desc.Checked ? "ORDER BY 1 DESC" : ""));

                DataTable resultado = controlador.fun_ConsultaFiltrada(
                    nombreTablaExterna,
                    campoReal,
                    operador,
                    valorRaw,
                    sorden
                );

                Dgv_consultas_simples.DataSource = resultado;
                Dgv_consultas_simples.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar filtro: " + ex.Message);
            }
        }
        // Jose Pablo Medina 0901-22-22592
        // Genera WHERE
        private string ConstruirWhere(string campo, string operador, string valor)
        {
            string where = "";

            switch (operador)
            {
                case "=":
                case "!=":
                case ">":
                case "<":
                case ">=":
                case "<=":
                    where = $"{campo} {operador} '{valor}'";
                    break;

                case "Contiene":
                    where = $"{campo} LIKE '%{valor}%'";
                    break;

                case "Comienza con":
                    where = $"{campo} LIKE '{valor}%'";
                    break;

                case "Termina con":
                    where = $"{campo} LIKE '%{valor}'";
                    break;

                default:
                    where = $"{campo} = '{valor}'";
                    break;
            }

            return where;
        }
        // RICHARD ANTONY DE LEON 0901 - 22 - 10265
        // Cambia ordenamiento
        private void Orden_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreTablaExterna))
                return;

            bool asc = Rdb_asc.Checked;

            DataTable resultado = controlador.fun_ConsultaOrdenada(nombreTablaExterna, asc);
            Dgv_consultas_simples.DataSource = resultado;
            Dgv_consultas_simples.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        // RICHARD ANTONY DE LEON 0901 - 22 - 10265
        //  Obtener estructura de tabla (solo columnas)
        private DataTable ObtenerEstructuraTabla(string tabla)
        {
            DataTable dt = controlador.fun_EjecutarConsulta(tabla, "");
            if (dt == null) return new DataTable();
            return dt.Clone();
        }

        // Botón cerrar
        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
