using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Capa_Controlador_Facturas;

namespace Capa_Vista_Facturas
{
    // Juan Carlos Sandoval Quej 0901-22-4170 12/11/2025
    public partial class Frm_Listado_Facturas : Form
    {
        // Controlador general para obtener datos de la BD
        private readonly Cls_Controlador _ctrl = new Cls_Controlador();

        public Frm_Listado_Facturas()
        {
            InitializeComponent();

            // Evento cuando carga el formulario
            Load += Frm_Listado_Facturas_Load;

            // === Configuración de búsqueda ===
            // Botón buscar
            Btn_Buscar.Click += (s, e) => Recargar();

            // Presionar Enter en el cuadro de texto también busca
            Txt_Buscar.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Recargar();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            };

            // Buscar “en vivo” al escribir
            Txt_Buscar.TextChanged += (s, e) => Recargar();

            // Doble clic en una fila abre el detalle
            Dgv_Facturas.CellDoubleClick += (s, e) =>
            {
                if (e.RowIndex >= 0) AbrirFila(e.RowIndex);
            };

            // Botón “Ver Detalle”
            Btn_VerDetalle.Click += (s, e) =>
            {
                if (Dgv_Facturas.CurrentRow != null)
                    AbrirFila(Dgv_Facturas.CurrentRow.Index);
            };

            // === “FacturaGuardada” 
            Cls_Controlador.FacturaGuardada += OnFacturaGuardada;

            // Cuando se cierre este form, se desuscribe para evitar duplicados
            this.FormClosed += (s, e) => Cls_Controlador.FacturaGuardada -= OnFacturaGuardada;
        }

        // EVENTO: Se ejecuta cuando se crea una nueva factura (en BD)
        private void OnFacturaGuardada(int idFactura, int idVenta)
        {
            // Solo si el form sigue activo
            if (IsHandleCreated)
                BeginInvoke(new Action(() =>
                {
                    Recargar();              // Actualiza listado
                    SeleccionarPorIdVenta(idVenta); // Marca la nueva venta
                }));
        }

        // CARGA INICIAL DEL FORMULARIO
        private void Frm_Listado_Facturas_Load(object sender, EventArgs e)
        {
            ConfigurarGridSiHaceFalta();
            Recargar();  // carga inicial
        }

        // CONFIGURA LAS COLUMNAS DEL DATAGRID (solo la primera vez)
        private void ConfigurarGridSiHaceFalta()
        {
            Dgv_Facturas.AutoGenerateColumns = false;

            // Evita duplicar columnas
            if (Dgv_Facturas.Columns.Count > 0) return;

            Dgv_Facturas.Columns.Clear();

            // Agrega las columnas manualmente con formato
            Dgv_Facturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Numero",
                HeaderText = "Número",
                DataPropertyName = "Numero",
                Width = 70
            });

            Dgv_Facturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdVenta",
                HeaderText = "IdVenta",
                DataPropertyName = "IdVenta",
                Width = 70
            });

            Dgv_Facturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Documento",
                HeaderText = "Documento",
                DataPropertyName = "Documento",
                Width = 110
            });

            Dgv_Facturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cliente",
                HeaderText = "Cliente",
                DataPropertyName = "Cliente",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            Dgv_Facturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fecha",
                HeaderText = "Fecha",
                DataPropertyName = "Fecha",
                Width = 110,
                DefaultCellStyle = { Format = "dd/MM/yyyy" }
            });

            Dgv_Facturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Total",
                HeaderText = "Total (Q)",
                DataPropertyName = "Total",
                Width = 110,
                DefaultCellStyle =
                {
                    Format = "N2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
        }


        // RECARGAR DATOS

        public void Recargar()
        {
            var filtro = (Txt_Buscar.Text ?? "").Trim();

            // Pide los datos filtrados al controlador
            var dt = _ctrl.ListadoFacturasBD(filtro);

            // Ordena de mayor a menor por número de factura
            var ordered = dt.AsEnumerable().OrderByDescending(r => r.Field<int>("Numero"));

            // Si hay filas, las copia al DataTable; si no, deja la estructura vacía
            Dgv_Facturas.DataSource = ordered.Any() ? ordered.CopyToDataTable() : dt.Clone();
        }

        // SELECCIONAR AUTOMÁTICAMENTE UNA FILA POR ID DE VENTA
        private void SeleccionarPorIdVenta(int idVenta)
        {
            foreach (DataGridViewRow row in Dgv_Facturas.Rows)
            {
                if (row.Cells["IdVenta"]?.Value is int v && v == idVenta)
                {
                    row.Selected = true;
                    Dgv_Facturas.CurrentCell = row.Cells["Numero"];
                    // Centra la fila en la vista
                    Dgv_Facturas.FirstDisplayedScrollingRowIndex = Math.Max(0, row.Index - 2);
                    break;
                }
            }
        }

        // ABRIR FORMULARIO DE DETALLE AL HACER DOBLE CLIC
        private void AbrirFila(int rowIndex)
        {
            if (rowIndex < 0) return;

            // Obtiene el idVenta de la fila seleccionada
            int idVenta = Convert.ToInt32(Dgv_Facturas.Rows[rowIndex].Cells["IdVenta"].Value);

            // Abre el detalle en un formulario modal
            using (var det = new Frm_Detalle_Factura(idVenta))
            {
                det.StartPosition = FormStartPosition.CenterParent;
                det.ShowDialog(this);
            }
        }

        // MÉTODO OPCIONAL PARA SELECCIONAR UNA FACTURA POR NÚMERO
        public void SelectFactura(int numero)
        {
            if (Dgv_Facturas.DataSource is DataTable dt && dt.Columns.Contains("Numero"))
            {
                foreach (DataGridViewRow row in Dgv_Facturas.Rows)
                {
                    if (row.DataBoundItem is DataRowView rv && Convert.ToInt32(rv.Row["Numero"]) == numero)
                    {
                        row.Selected = true;
                        Dgv_Facturas.CurrentCell = row.Cells[0];
                        Dgv_Facturas.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }
    }
}
