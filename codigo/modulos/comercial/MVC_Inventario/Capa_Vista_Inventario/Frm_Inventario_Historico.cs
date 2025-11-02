using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Inventario;
using iTextSharp.text; // Para PDF
using iTextSharp.text.pdf; // Para PDF
using System.IO; // Para PDF

namespace Capa_Vista_Inventario
{
    public partial class Frm_Inventario_Historico : Form
    {
        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Variable del Controlador ====================
        // (Instancia global del controlador para comunicarse con la capa Modelo)
        private Cls_Controlador_Inventario controlador;

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Constructor del Formulario ====================
        public Frm_Inventario_Historico()
        {
            InitializeComponent();
            // Inicializa la variable del controlador
            controlador = new Cls_Controlador_Inventario();

            // Asigna el evento 'Frm_Inventario_Historico_Load' al evento 'Load' del formulario
            this.Load += new System.EventHandler(this.Frm_Inventario_Historico_Load);
        }

        // ==================== Stevens Cambranes 28/10/25 ====================
        // ==================== Botón Nuevo Inventario ====================
        // (Abre el formulario 'Frm_Inventario' para agregar un nuevo producto)
        private void Btn_Nuevo_Inventario_Click(object sender, EventArgs e)
        {
            Frm_Inventario NuevoInventario = new Frm_Inventario();
            NuevoInventario.Show(); // Muestra el nuevo formulario
            this.Hide(); // Oculta este formulario
        }

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Botón Imprimir PDF ====================
        // (Exporta el contenido del DataGridView a un archivo PDF) / depende de componentes que solo existen en la Vista
        private void Btn_Imprimir_PDF_Click(object sender, EventArgs e)
        {
            // Pregunta al usuario si está seguro
            if (MessageBox.Show("¿Seguro que quiere generar el PDF?", "Generar PDF", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // Verifica que el DGV no esté vacío
                if (Dgv_Vista_Inventarios_Pasados.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Sale del método si no hay datos
                }

                // Abre el diálogo para guardar el archivo
                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "Archivo PDF (*.pdf)|*.pdf",
                    Title = "Guardar Reporte de Histórico",
                    FileName = $"Reporte_De_Inventario_{DateTime.Now:dd-MM-yyyy}.pdf" // Nombre de archivo sugerido
                };

                // Si el usuario selecciona una ubicación y guarda
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Crea el documento PDF (Horizontal, márgenes)
                        Document doc = new Document(PageSize.A4.Rotate(), 10f, 10f, 20f, 10f);
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
                        doc.Open(); // Abre el documento para escribir

                        // Agrega un título
                        Paragraph titulo = new Paragraph("Reporte Histórico de Inventario",
                            FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK));
                        titulo.Alignment = Element.ALIGN_CENTER;
                        doc.Add(titulo);
                        doc.Add(Chunk.NEWLINE); // Agrega un espacio

                        // Crea la tabla PDF con el mismo número de columnas que el DGV
                        PdfPTable pdfTable = new PdfPTable(Dgv_Vista_Inventarios_Pasados.Columns.Count);
                        pdfTable.WidthPercentage = 100; // La tabla ocupa el 100% del ancho

                        // Agrega los encabezados (columnas) del DGV al PDF
                        foreach (DataGridViewColumn column in Dgv_Vista_Inventarios_Pasados.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText,
                                FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.WHITE)));
                            cell.BackgroundColor = new BaseColor(45, 75, 125); // Color de fondo
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            pdfTable.AddCell(cell);
                        }

                        // Agrega las filas (datos) del DGV al PDF
                        foreach (DataGridViewRow row in Dgv_Vista_Inventarios_Pasados.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string cellValue = cell.Value != null ? cell.Value.ToString() : "";
                                pdfTable.AddCell(new Phrase(cellValue,
                                    FontFactory.GetFont(FontFactory.HELVETICA, 9, BaseColor.BLACK)));
                            }
                        }

                        // Añade la tabla completa al documento
                        doc.Add(pdfTable);
                        doc.Close(); // Cierra el documento
                        writer.Close();

                        MessageBox.Show("Reporte PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Diagnostics.Process.Start(saveDialog.FileName); // Abre el PDF
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Botón Buscar Inventario ====================
        // (Ejecuta la búsqueda según los filtros y el modo seleccionado)
        private void Btn_Buscar_Inventario_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

                // Decide qué buscar: Cierres (resumen) o Movimientos (transacciones)
                if (Rdb_Ver_Historicos.Checked)
                {
                    // MODO 1: BÚSQUEDA EN CIERRES (Tbl_CierresInventario)
                    // Llama al controlador para obtener todos los cierres (sin filtros)
                    dt = controlador.Ctr_CargarTodosLosCierres();
                }
                else if (Rdb_Usar_Filtros_Busqueda.Checked)
                {
                    // MODO 2: BÚSQUEDA EN MOVIMIENTOS (Tbl_MovimientosInventario)

                    // Valida que se haya seleccionado un tipo de movimiento
                    if (string.IsNullOrEmpty(Cbo_Tipo_Operacion.Text))
                    {
                        MessageBox.Show("Tienes que escoger un tipo de movimiento.");
                        return; // Sale del método si no hay selección
                    }

                    // Recolecta todos los filtros de la interfaz
                    string tipoMovimiento = Cbo_Tipo_Operacion.Text;
                    int? idAlmacen = (Rdb_Filtro_Almacen.Checked && Cbo_Filtro_Almacen.SelectedValue != null)
                                      ? (int?)Cbo_Filtro_Almacen.SelectedValue : null;
                    int? idEstado = (Rdb_Filtro_Estado.Checked && Cbo_Filtro_Estado.SelectedValue != null)
                                      ? (int?)Cbo_Filtro_Estado.SelectedValue : null;
                    bool usarRango = Rdb_Filtro_Rango_Fecha.Checked;
                    DateTime fechaInicio = Dtp_Filtro_Rango_Fecha_Inicio.Value.Date;
                    DateTime fechaFin = Dtp_Filtro_Rango_Fecha_Fin.Value.Date.AddDays(1).AddTicks(-1); // Fin del día

                    // Determina el criterio de orden
                    string orden = "mov.Cmp_Fecha DESC"; // Orden por defecto
                    if (Rdb_Filtro_Menos_Recientes.Checked) orden = "mov.Cmp_Fecha ASC";
                    else if (Rdb_Filtro_Valor_Mas_Alto.Checked) orden = "ValorTotal DESC";
                    else if (Rdb_Filtro_Valor_Mas_Bajo.Checked) orden = "ValorTotal ASC";

                    // Llama al controlador para obtener los movimientos filtrados
                    dt = controlador.Ctr_ObtenerHistorico(
                        tipoMovimiento, idAlmacen, idEstado,
                        usarRango, fechaInicio, fechaFin, orden
                    );
                }

                // Muestra los resultados en el DataGridView
                Dgv_Vista_Inventarios_Pasados.DataSource = null;
                Dgv_Vista_Inventarios_Pasados.DataSource = dt;

                // Informa si no se encontraron resultados
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados para esta búsqueda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el histórico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==================== Stevens Cambranes 28/10/25 ====================
        // ==================== Habilitar / Deshabilitar Filtros ====================
        // (Estos métodos activan/desactivan los ComboBox según su RadioButton)
        private void Rdb_Filtro_Almacen_CheckedChanged(object sender, EventArgs e)
        {
            Cbo_Filtro_Almacen.Enabled = Rdb_Filtro_Almacen.Checked;
        }

        private void Rdb_Filtro_Estado_CheckedChanged(object sender, EventArgs e)
        {
            Cbo_Filtro_Estado.Enabled = Rdb_Filtro_Estado.Checked;
        }

        private void Rdb_Filtro_Rango_Fecha_CheckedChanged(object sender, EventArgs e)
        {
            Dtp_Filtro_Rango_Fecha_Inicio.Enabled = Rdb_Filtro_Rango_Fecha.Checked;
            Dtp_Filtro_Rango_Fecha_Fin.Enabled = Rdb_Filtro_Rango_Fecha.Checked;
        }

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Cargar ComboBox Tipo Movimiento ====================
        // (Obtiene los tipos de movimiento de la BD y los carga en el ComboBox)
        private void CargarComboBoxTiposMovimiento()
        {
            try
            {
                DataTable dt = controlador.Ctr_CargarTiposMovimiento();
                Cbo_Tipo_Operacion.DataSource = dt;
                Cbo_Tipo_Operacion.DisplayMember = "Cmp_Nombre"; // Texto a mostrar
                Cbo_Tipo_Operacion.ValueMember = "Pk_ID_TipoMovimiento"; // ID interno
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos de movimiento: " + ex.Message, "Error");
            }
        }

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Cargar DGV por Defecto ====================
        // (Carga los 100 movimientos más recientes en el DGV al abrir)
        private void CargarGridPorDefecto()
        {
            try
            {
                DataTable dt = controlador.Ctr_CargarHistoricoDefault();
                Dgv_Vista_Inventarios_Pasados.DataSource = null;
                Dgv_Vista_Inventarios_Pasados.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el histórico por defecto: " + ex.Message, "Error");
            }
        }

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Evento Load del Formulario ====================
        // (Se ejecuta una sola vez cuando el formulario carga)
        private void Frm_Inventario_Historico_Load(object sender, EventArgs e)
        {
            try
            {
                // Llena todos los ComboBox
                CargarComboBoxAlmacenes();
                CargarComboBoxEstados();
                CargarComboBoxTiposMovimiento();

                // Limpia la selección inicial de los ComboBox
                Cbo_Filtro_Almacen.SelectedIndex = -1;
                Cbo_Filtro_Estado.SelectedIndex = -1;
                Cbo_Tipo_Operacion.SelectedIndex = -1;

                // Establece el modo de búsqueda por defecto
                Rdb_Usar_Filtros_Busqueda.Checked = true;

                // Carga el DGV con los movimientos por defecto
                CargarGridPorDefecto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos iniciales: " + ex.Message, "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Cargar ComboBox Almacenes ====================
        // (Obtiene los almacenes de la BD y los carga en el ComboBox)
        private void CargarComboBoxAlmacenes()
        {
            try
            {
                DataTable dt = controlador.Ctr_CargarAlmacenes();
                Cbo_Filtro_Almacen.DataSource = dt;
                Cbo_Filtro_Almacen.DisplayMember = "Cmp_Nombre"; // Texto a mostrar
                Cbo_Filtro_Almacen.ValueMember = "Pk_ID_Almacen"; // ID interno
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar almacenes: " + ex.Message, "Error");
            }
        }

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Cargar ComboBox Estados ====================
        // (Obtiene los estados de producto de la BD y los carga en el ComboBox)
        private void CargarComboBoxEstados()
        {
            try
            {
                DataTable dt = controlador.Ctr_CargarEstadosProducto();
                Cbo_Filtro_Estado.DataSource = dt;
                Cbo_Filtro_Estado.DisplayMember = "Cmp_Nombre"; // Texto a mostrar
                Cbo_Filtro_Estado.ValueMember = "Pk_ID_EstadoProducto"; // ID interno
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estados: " + ex.Message, "Error");
            }
        }

        // ==================== Stevens Cambranes 01/11/2025 ====================
        // ==================== Control de Modos de Búsqueda ====================
        // (Este único método controla AMBOS RadioButtons: Rdb_Ver_Historicos y Rdb_Usar_Filtros)
        private void ModoDeBusqueda_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica si el modo "Ver Cierres" está activo
            bool verCierres = Rdb_Ver_Historicos.Checked;

            // Habilita o deshabilita los filtros basado en el modo
            // (!verCierres es 'true' si "Usar Filtros" está activo, y 'false' si "Ver Cierres" está activo)
            Cbo_Tipo_Operacion.Enabled = !verCierres;
            Gpb_Filtros.Enabled = !verCierres; // GroupBox de filtros

            // Si se activa "Ver Cierres", limpia el ComboBox de movimientos
            if (verCierres)
            {
                Cbo_Tipo_Operacion.SelectedIndex = -1;
            }
        }
    }
} 