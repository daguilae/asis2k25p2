using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Inventario; // Usamos la capa Controlador
using iTextSharp.text; // Para PDF
using iTextSharp.text.pdf; // Para PDF
using System.IO; // Para PDF

namespace Capa_Vista_Inventario
{
    // ==================== Stevens Cambranes 05/11/2025 ====================
    // ==================== Formulario Histórico de Inventario ====================
    public partial class Frm_Inventario_Historico : Form
    {
        // ==================== Stevens Cambranes 05/11/2025 ====================
        // ==================== Variable del Controlador ====================
        // (Instancia global del controlador para comunicarse con la capa Modelo)
        private Cls_Controlador_Inventario controlador;

        // ==================== Stevens Cambranes 05/11/2025 ====================
        // ==================== Constructor del Formulario ====================
        public Frm_Inventario_Historico()
        {
            InitializeComponent();
            controlador = new Cls_Controlador_Inventario();
            // Asigna el evento 'Load' del formulario
            this.Load += new System.EventHandler(this.Frm_Inventario_Historico_Load);

            // Asigna el evento 'DataBindingComplete' para formatear el DGV
            this.Dgv_Vista_Inventarios_Pasados.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.Dgv_Vista_Inventarios_Pasados_DataBindingComplete);
        }

        // ==================== Stevens Cambranes 05/11/2025 ====================
        // ==================== Formateo de Celdas (DGV) ====================
        // (Se ejecuta después de que el DGV se llena de datos para formatear números y fechas)
        private void Dgv_Vista_Inventarios_Pasados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                // Formatea la cantidad a 4 decimales (N4)
                if (Dgv_Vista_Inventarios_Pasados.Columns.Contains("Cmp_Cantidad"))
                {
                    Dgv_Vista_Inventarios_Pasados.Columns["Cmp_Cantidad"].DefaultCellStyle.Format = "N4";
                }

                // Formatea el costo a 2 decimales (N2)
                if (Dgv_Vista_Inventarios_Pasados.Columns.Contains("CostoEnEseMomento"))
                {
                    Dgv_Vista_Inventarios_Pasados.Columns["CostoEnEseMomento"].DefaultCellStyle.Format = "N2";
                }

                // Formatea el valor total a 2 decimales (N2)
                if (Dgv_Vista_Inventarios_Pasados.Columns.Contains("ValorTotal"))
                {
                    Dgv_Vista_Inventarios_Pasados.Columns["ValorTotal"].DefaultCellStyle.Format = "N2";
                }

                // Formatea la fecha a solo día/mes/año (ShortDate)
                if (Dgv_Vista_Inventarios_Pasados.Columns.Contains("Cmp_Fecha"))
                {
                    Dgv_Vista_Inventarios_Pasados.Columns["Cmp_Fecha"].DefaultCellStyle.Format = "d"; // 'd' es para ShortDatePattern
                }
            }
            catch (Exception ex)
            {
                // No es un error crítico, solo informa en la consola de depuración
                System.Diagnostics.Debug.WriteLine("Error al formatear DGV: " + ex.Message);
            }
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

        // ==================== Stevens Cambranes 05/11/2025 ====================
        // ==================== Botón Imprimir PDF ====================
        // (Exporta el contenido del DataGridView a un archivo PDF)
        private void Btn_Imprimir_PDF_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere generar el PDF?", "Generar PDF", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Dgv_Vista_Inventarios_Pasados.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Sale del método si no hay datos
                }

                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "Archivo PDF (*.pdf)|*.pdf",
                    Title = "Guardar Reporte de Histórico",
                    FileName = $"Reporte_De_Inventario_{DateTime.Now:dd-MM-yyyy}.pdf"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Document doc = new Document(PageSize.A4.Rotate(), 10f, 10f, 20f, 10f);
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
                        doc.Open();

                        Paragraph titulo = new Paragraph("Reporte Histórico de Inventario",
                            FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK));
                        titulo.Alignment = Element.ALIGN_CENTER;
                        doc.Add(titulo);
                        doc.Add(Chunk.NEWLINE);

                        PdfPTable pdfTable = new PdfPTable(Dgv_Vista_Inventarios_Pasados.Columns.Count);
                        pdfTable.WidthPercentage = 100;

                        // Agrega los encabezados
                        foreach (DataGridViewColumn column in Dgv_Vista_Inventarios_Pasados.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText,
                                FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.WHITE)));
                            cell.BackgroundColor = new BaseColor(45, 75, 125);
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            pdfTable.AddCell(cell);
                        }

                        // Agrega las filas (aplicando el mismo formato que el DGV)
                        foreach (DataGridViewRow row in Dgv_Vista_Inventarios_Pasados.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string cellValue = cell.Value != null ? cell.Value.ToString() : "";

                                // Aplica formato a los números y fechas para el PDF
                                if (cell.OwningColumn.Name == "Cmp_Cantidad")
                                {
                                    cellValue = string.Format("{0:N4}", cell.Value);
                                }
                                else if (cell.OwningColumn.Name == "CostoEnEseMomento" || cell.OwningColumn.Name == "ValorTotal")
                                {
                                    cellValue = string.Format("{0:N2}", cell.Value);
                                }
                                else if (cell.OwningColumn.Name == "Cmp_Fecha" || cell.OwningColumn.Name == "Cmp_FechaCierre")
                                {
                                    cellValue = string.Format("{0:d}", cell.Value);
                                }

                                pdfTable.AddCell(new Phrase(cellValue,
                                    FontFactory.GetFont(FontFactory.HELVETICA, 9, BaseColor.BLACK)));
                            }
                        }

                        doc.Add(pdfTable);
                        doc.Close();
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

        // (Busca tu método Btn_Buscar_Inventario_Click y reemplázalo por este)

        // ==================== Stevens Cambranes 05/11/2025 ====================
        // ==================== Botón Buscar Inventario (Actualizado) ====================
        // (Se agrega lógica para "Ver Todos Los Movimientos")
        private void Btn_Buscar_Inventario_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

                if (Rdb_Ver_Historicos.Checked)
                {
                    // MODO 1: BÚSQUEDA EN CIERRES
                    dt = controlador.Ctr_CargarTodosLosCierres();
                }
                else if (Rdb_Usar_Filtros_Busqueda.Checked)
                {
                    // MODO 2: BÚSQUEDA EN MOVIMIENTOS

                    // Validación: Asegura que se seleccionó un Tipo de Movimiento
                    if (Cbo_Tipo_Operacion.SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe seleccionar un Tipo de Movimiento para buscar.", "Validación Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Cbo_Tipo_Operacion.Focus();
                        return;
                    }

                    // Recolecta todos los filtros
                    string tipoMovimiento = Cbo_Tipo_Operacion.Text;
                    if (tipoMovimiento == "Ver Todos Los Movimientos")
                    {
                        tipoMovimiento = null; // O string.Empty
                    }

                    int? idAlmacen = (Rdb_Filtro_Almacen.Checked && Cbo_Filtro_Almacen.SelectedValue != null)
                                        ? (int?)Cbo_Filtro_Almacen.SelectedValue : null;
                    int? idEstado = (Rdb_Filtro_Estado.Checked && Cbo_Filtro_Estado.SelectedValue != null)
                                        ? (int?)Cbo_Filtro_Estado.SelectedValue : null;
                    bool usarRango = Rdb_Filtro_Rango_Fecha.Checked;
                    DateTime fechaInicio = Dtp_Filtro_Rango_Fecha_Inicio.Value.Date;
                    DateTime fechaFin = Dtp_Filtro_Rango_Fecha_Fin.Value.Date;

                    string orden = "mov.Cmp_Fecha_Movimiento DESC"; // Default
                    if (Rdb_Filtro_Menos_Recientes.Checked) orden = "mov.Cmp_Fecha_Movimiento ASC";
                    else if (Rdb_Filtro_Valor_Mas_Alto.Checked) orden = "ValorTotal DESC";
                    else if (Rdb_Filtro_Valor_Mas_Bajo.Checked) orden = "ValorTotal ASC";

                    // Llama al controlador. Si tipoMovimiento es 'null', el Modelo lo ignorará.
                    dt = controlador.Ctr_ObtenerHistorico(
                        tipoMovimiento, idAlmacen, idEstado,
                        usarRango, fechaInicio, fechaFin, orden
                    );
                }

                // Muestra los resultados en el DGV
                Dgv_Vista_Inventarios_Pasados.DataSource = null;
                Dgv_Vista_Inventarios_Pasados.DataSource = dt;

                if (dt != null && dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados para esta búsqueda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Limpia los ComboBoxes después de la búsqueda
                Cbo_Tipo_Operacion.SelectedIndex = -1;
                Cbo_Filtro_Almacen.SelectedIndex = -1;
                Cbo_Filtro_Estado.SelectedIndex = -1;
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

        // ==================== Stevens Cambranes 05/11/2025 ====================
        // ==================== Cargar ComboBox Tipo Movimiento ====================
        // (Obtiene los tipos de movimiento de la BD y los carga en el ComboBox)
        private void CargarComboBoxTiposMovimiento()
        {
            try
            {
                DataTable dt = controlador.Ctr_CargarTiposMovimiento();
                Cbo_Tipo_Operacion.DataSource = dt;
                Cbo_Tipo_Operacion.DisplayMember = "Cmp_Nombre"; // Usa el alias 'Cmp_Nombre'
                Cbo_Tipo_Operacion.ValueMember = "Pk_ID_TipoMovimiento"; // Usa el alias 'Pk_ID...'
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos de movimiento: " + ex.Message, "Error");
            }
        }

        // ==================== Stevens Cambranes 05/11/2025 ====================
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

        // ==================== Stevens Cambranes 05/11/2025 ====================
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

                // Limpia la selección inicial
                Cbo_Filtro_Almacen.SelectedIndex = -1;
                Cbo_Filtro_Estado.SelectedIndex = -1;
                Cbo_Tipo_Operacion.SelectedIndex = -1;

                // Conecta los RadioButtons al método de control unificado
                this.Rdb_Ver_Historicos.CheckedChanged += new System.EventHandler(this.ModoDeBusqueda_CheckedChanged);
                this.Rdb_Usar_Filtros_Busqueda.CheckedChanged += new System.EventHandler(this.ModoDeBusqueda_CheckedChanged);

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

        // ==================== Stevens Cambranes 05/11/2025 ====================
        // ==================== Cargar ComboBox Almacenes ====================
        // (Obtiene los almacenes de la BD y los carga en el ComboBox)
        private void CargarComboBoxAlmacenes()
        {
            try
            {
                DataTable dt = controlador.Ctr_CargarAlmacenes();
                Cbo_Filtro_Almacen.DataSource = dt;
                Cbo_Filtro_Almacen.DisplayMember = "Cmp_Nombre"; // Usa el alias 'Cmp_Nombre'
                Cbo_Filtro_Almacen.ValueMember = "Pk_ID_Almacen"; // Usa el alias 'Pk_ID...'
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar almacenes: " + ex.Message, "Error");
            }
        }

        // ==================== Stevens Cambranes 05/11/2025 ====================
        // ==================== Cargar ComboBox Estados ====================
        // (Obtiene los estados de producto de la BD y los carga en el ComboBox)
        private void CargarComboBoxEstados()
        {
            try
            {
                DataTable dt = controlador.Ctr_CargarEstadosProducto();
                Cbo_Filtro_Estado.DataSource = dt;
                Cbo_Filtro_Estado.DisplayMember = "Cmp_Nombre"; // Usa 'Cmp_Nombre'
                Cbo_Filtro_Estado.ValueMember = "Pk_ID_EstadoProducto"; // Usa 'Pk_ID_EstadoProducto'
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estados: " + ex.Message, "Error");
            }
        }

        // ==================== Stevens Cambranes 05/11/2025 ====================
        // ==================== Control de Modos de Búsqueda (RadioButtons) ====================
        // (Este único método controla AMBOS RadioButtons: Rdb_Ver_Historicos y Rdb_Usar_Filtros)
        private void ModoDeBusqueda_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica si el modo "Ver Cierres" está activo
            bool verCierres = Rdb_Ver_Historicos.Checked;

            // Habilita o deshabilita los filtros basado en el modo
            Cbo_Tipo_Operacion.Enabled = !verCierres;
            Gpb_Filtros.Enabled = !verCierres; // Tu GroupBox de filtros

            // Si se activa "Ver Cierres", limpia el ComboBox de movimientos
            if (verCierres)
            {
                Cbo_Tipo_Operacion.SelectedIndex = -1;
            }
        }
    }
}