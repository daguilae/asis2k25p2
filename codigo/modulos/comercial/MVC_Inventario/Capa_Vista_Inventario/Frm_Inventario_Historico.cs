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
        // ==================== Variable del Controlador ====================
        private Cls_Controlador_Inventario controlador;

        public Frm_Inventario_Historico()
        {
            InitializeComponent();
            controlador = new Cls_Controlador_Inventario();

            // Asignamos el evento Load del formulario
            this.Load += new System.EventHandler(this.Frm_Inventario_Historico_Load);
        }

        // ==================== Botón Nuevo Inventario ====================
        private void Btn_Nuevo_Inventario_Click(object sender, EventArgs e)
        {
            Frm_Inventario NuevoInventario = new Frm_Inventario();
            NuevoInventario.Show();
            this.Hide();
        }

        // ==================== Botón Imprimir PDF ====================
        private void Btn_Imprimir_PDF_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere generar el PDF?", "Generar PDF", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Dgv_Vista_Inventarios_Pasados.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
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

                        foreach (DataGridViewColumn column in Dgv_Vista_Inventarios_Pasados.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText,
                                FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.WHITE)));
                            cell.BackgroundColor = new BaseColor(45, 75, 125);
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            pdfTable.AddCell(cell);
                        }

                        foreach (DataGridViewRow row in Dgv_Vista_Inventarios_Pasados.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string cellValue = cell.Value != null ? cell.Value.ToString() : "";
                                pdfTable.AddCell(new Phrase(cellValue,
                                    FontFactory.GetFont(FontFactory.HELVETICA, 9, BaseColor.BLACK)));
                            }
                        }

                        doc.Add(pdfTable);
                        doc.Close();
                        writer.Close();

                        MessageBox.Show("Reporte PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Diagnostics.Process.Start(saveDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // ==================== Botón Buscar Inventario ====================
        private void Btn_Buscar_Inventario_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

                // ¿Buscamos Cierres o Movimientos?
                if (Rdb_Ver_Historicos.Checked)
                {
                    // Llamamos al método que no usa filtros
                    dt = controlador.Ctr_CargarTodosLosCierres();
                }
                else if (Rdb_Usar_Filtros_Busqueda.Checked)
                {
                    // BÚSQUEDA EN MOVIMIENTOS (Tbl_MovimientosInventario)

                    // Validación
                    if (string.IsNullOrEmpty(Cbo_Tipo_Operacion.Text))
                    {
                        MessageBox.Show("Tienes que escoger un tipo de movimiento.");
                        return;
                    }

                    // Recolectar filtros (esta lógica ya la tenías)
                    string tipoMovimiento = Cbo_Tipo_Operacion.Text;
                    int? idAlmacen = (Rdb_Filtro_Almacen.Checked && Cbo_Filtro_Almacen.SelectedValue != null)
                                     ? (int?)Cbo_Filtro_Almacen.SelectedValue : null;
                    int? idEstado = (Rdb_Filtro_Estado.Checked && Cbo_Filtro_Estado.SelectedValue != null)
                                    ? (int?)Cbo_Filtro_Estado.SelectedValue : null;
                    bool usarRango = Rdb_Filtro_Rango_Fecha.Checked;
                    DateTime fechaInicio = Dtp_Filtro_Rango_Fecha_Inicio.Value.Date;
                    DateTime fechaFin = Dtp_Filtro_Rango_Fecha_Fin.Value.Date.AddDays(1).AddTicks(-1);

                    // Determinar el orden
                    string orden = "mov.Cmp_Fecha DESC"; // Default
                    if (Rdb_Filtro_Menos_Recientes.Checked) orden = "mov.Cmp_Fecha ASC";
                    else if (Rdb_Filtro_Valor_Mas_Alto.Checked) orden = "ValorTotal DESC";
                    else if (Rdb_Filtro_Valor_Mas_Bajo.Checked) orden = "ValorTotal ASC";

                    // Llamamos al método original de Histórico (Movimientos)
                    dt = controlador.Ctr_ObtenerHistorico(
                        tipoMovimiento, idAlmacen, idEstado,
                        usarRango, fechaInicio, fechaFin, orden
                    );
                }

                // Mostrar resultados en el DataGridView
                Dgv_Vista_Inventarios_Pasados.DataSource = null;
                Dgv_Vista_Inventarios_Pasados.DataSource = dt;

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

        // ==================== Lógica de Habilitar/Deshabilitar ====================

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

        // Este código se ejecuta JUSTO cuando el formulario se abre
        private void CargarComboBoxTiposMovimiento()
        {
            try
            {
                DataTable dt = controlador.Ctr_CargarTiposMovimiento();
                Cbo_Tipo_Operacion.DataSource = dt;
                Cbo_Tipo_Operacion.DisplayMember = "Cmp_Nombre"; // Texto a mostrar
                Cbo_Tipo_Operacion.ValueMember = "Pk_ID_TipoMovimiento"; // ID
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos de movimiento: " + ex.Message, "Error");
            }
        }

        // Para el DGV
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
        private void Frm_Inventario_Historico_Load(object sender, EventArgs e)
        {
            try
            {
                // ComboBox
                CargarComboBoxAlmacenes();
                CargarComboBoxEstados();
                CargarComboBoxTiposMovimiento();

                // Limpiamos selección
                Cbo_Filtro_Almacen.SelectedIndex = -1;
                Cbo_Filtro_Estado.SelectedIndex = -1;
                Cbo_Tipo_Operacion.SelectedIndex = -1;
                Rdb_Usar_Filtros_Busqueda.Checked = true;

                // Cargamos el DGV por defecto con los MOVIMIENTOS
                CargarGridPorDefecto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos iniciales: " + ex.Message, "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metodo para el Cbo almacenes
        private void CargarComboBoxAlmacenes()
        {
            try
            {
                DataTable dt = controlador.Ctr_CargarAlmacenes();
                Cbo_Filtro_Almacen.DataSource = dt;
                Cbo_Filtro_Almacen.DisplayMember = "Cmp_Nombre"; // El texto que ve el usuario
                Cbo_Filtro_Almacen.ValueMember = "Pk_ID_Almacen"; // El ID que usamos en el código
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar almacenes: " + ex.Message, "Error");
            }
        }

        // Metodo para el Cbo estados
        private void CargarComboBoxEstados()
        {
            try
            {
                DataTable dt = controlador.Ctr_CargarEstadosProducto();
                Cbo_Filtro_Estado.DataSource = dt;
                Cbo_Filtro_Estado.DisplayMember = "Cmp_Nombre"; // El texto que ve el usuario
                Cbo_Filtro_Estado.ValueMember = "Pk_ID_EstadoProducto"; // El ID que usamos en el código
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estados: " + ex.Message, "Error");
            }
        }

        private void ModoDeBusqueda_CheckedChanged(object sender, EventArgs e)
        {
            // Verificamos si el modo "Ver Cierres" (Rdb_Ver_Historicos) está activo
            bool verCierres = Rdb_Ver_Historicos.Checked;
            // Habilitamos o Deshabilitamos los filtros basado en el modo:
            // Si 'verCierres' es true, 'Enabled' será false.
            // Si 'verCierres' es false (o sea, Rdb_Usar_Filtros está activo), 'Enabled' será true.
            Cbo_Tipo_Operacion.Enabled = !verCierres;
            Gpb_Filtros.Enabled = !verCierres; // Tu GroupBox de filtros

            // Opcional: Limpiar el ComboBox de movimiento si se cambia a modo "Cierres"
            if (verCierres)
            {
                Cbo_Tipo_Operacion.SelectedIndex = -1;
            }
        }
    }
}