using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Capa_Modelo_MB;
using Capa_Controldor_MB;

namespace Capa_Vista_MB
{
    public partial class Forms_MB : Form
    {
        Conexion cn = new Conexion();
        CRUD crud = new CRUD();

        // Agrega esta clase en tu archivo Forms_MB.cs
        public class OpcionCombo
        {
            public string Texto { get; set; }
            public int Valor { get; set; }
        }

        public Forms_MB()
        {
            InitializeComponent();
            this.Load += Forms_MB_Load;
            // Btn_Guardar.Click += Btn_Guardar_Click; 
            Cbo_Signo.Items.Clear();
            Cbo_Signo.Items.Add("+");
            Cbo_Signo.Items.Add("-");
            Cbo_Signo.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo_Signo.SelectedIndex = -1;
            Cbo_Signo.Enabled = false;

            Cbo_NoCuenta_Recibe.SelectionChangeCommitted += Cbo_NoCuenta_Recibe_SelectionChangeCommitted;
            Cbo_NoCuenta_Envia.SelectionChangeCommitted += Cbo_NoCuenta_Envia_SelectionChangeCommitted;
            Cbo_Operacion.SelectionChangeCommitted += Cbo_Operacion_SelectionChangeCommitted;

            Cbo_Signo.DropDownStyle = ComboBoxStyle.DropDownList;

            Lbl_division.AutoSize = false;
            Lbl_division.Height = 2;
            Lbl_division.BorderStyle = BorderStyle.Fixed3D;
            Lbl_division.BackColor = Color.Green;

            Lbl_division2.AutoSize = false;
            Lbl_division2.Height = 2;
            Lbl_division2.BorderStyle = BorderStyle.Fixed3D;
            Lbl_division2.BackColor = Color.Green;
        }

        private void Forms_MB_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Font = new Font("Rockwell", 11, FontStyle.Regular);
            CargarCuentasRecibe();
            CargarCuentasEnvia();
            CargarOperaciones();
            ConfigurarComboConciliado();
            CargarEstadosMovimiento();
            CargarDatosEnEstructuraCaptura();

            // CargarDetalleMovimientos();  
            // CargarMovimientos();         
            //CargarMovimientos();

            Cbo_NoCuenta_Recibe.Enabled = false;
            Txt_NombreCuenta_Recibe.Enabled = false;
        }

        private void CargarDatosEnEstructuraCaptura()
        {
            try
            {
                // Forzar la preparación del grid si es necesario
                if (Dgv_Detalle_Movimiento.Columns.Count == 0)
                {
                    PrepararGridDetalleParaCaptura();
                }
                // Obtener datos del CRUD
                DataTable dt = crud.ObtenerDetallesContablesParaCaptura();
                if (dt.Rows.Count == 0)
                {
                    // Mostrar grid vacío pero con estructura lista para captura
                    Dgv_Detalle_Movimiento.Rows.Clear();
                    MessageBox.Show("No hay datos existentes. El grid está listo para capturar nuevos movimientos.", "Información");
                    return;
                }
                // VERIFICAR QUE LAS COLUMNAS EXISTEN ANTES DE ACCEDER
                DataTable dtSafe = new DataTable();
                foreach (DataColumn col in dt.Columns)
                {
                    dtSafe.Columns.Add(col.ColumnName, col.DataType);
                }
                // asignar directamente pero mantener estructura
                Dgv_Detalle_Movimiento.AutoGenerateColumns = false;
                // Limpiar filas existentes
                Dgv_Detalle_Movimiento.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int index = Dgv_Detalle_Movimiento.Rows.Add();
                    if (dt.Columns.Contains("Fk_Id_tipo_pago"))
                        Dgv_Detalle_Movimiento.Rows[index].Cells["Fk_Id_tipo_pago"].Value = row["Fk_Id_tipo_pago"];

                    if (dt.Columns.Contains("Cmp_Num_Documento"))
                        Dgv_Detalle_Movimiento.Rows[index].Cells["Cmp_Num_Documento"].Value = row["Cmp_Num_Documento"];

                    if (dt.Columns.Contains("Debe"))
                        Dgv_Detalle_Movimiento.Rows[index].Cells["Debe"].Value = row["Debe"];

                    if (dt.Columns.Contains("Haber"))
                        Dgv_Detalle_Movimiento.Rows[index].Cells["Haber"].Value = row["Haber"];

                    if (dt.Columns.Contains("Cmp_Concepto"))
                        Dgv_Detalle_Movimiento.Rows[index].Cells["Cmp_Concepto"].Value = row["Cmp_Concepto"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private void PrepararGridDetalleParaCaptura()
        {
            try
            {
                var g = Dgv_Detalle_Movimiento;
                g.AutoGenerateColumns = false;
                g.Columns.Clear();
                // Columna para Tipo de Pago
                g.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Fk_Id_tipo_pago",
                    HeaderText = "Tipo de Pago (ID)",
                    Width = 120,
                    ReadOnly = true 
                });
                // Columna para Número de Documento
                g.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Cmp_Num_Documento",
                    HeaderText = "Número Documento",
                    Width = 150,
                    ReadOnly = true 
                });
                // Columna para DEBE
                g.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Debe",
                    HeaderText = "Debe",
                    Width = 100,
                    ReadOnly = true,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "N2",
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        BackColor = Color.LightCoral //rojito
                    }
                });

                // Columna para HABER
                g.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Haber",
                    HeaderText = "Haber",
                    Width = 100,
                    ReadOnly = true,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "N2",
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        BackColor = Color.LightGreen //verde
                    }
                });
                // Columna para Descripción
                g.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Cmp_Concepto",
                    HeaderText = "Concepto",
                    Width = 200,
                    ReadOnly = true,
                });
                g.AllowUserToAddRows = true;
                g.AllowUserToDeleteRows = true;
                // Evento para validar que solo se ingrese en Debe o Haber
                g.CellEndEdit += Dgv_Detalle_Movimiento_CellEndEdit;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en PrepararGridDetalleParaCaptura: {ex.Message}", "Error");
            }
        }

        // Evento para validar que solo se ingrese en Debe o Haber
        private void Dgv_Detalle_Movimiento_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = Dgv_Detalle_Movimiento.Rows[e.RowIndex];
            // Si es la columna Debe
            if (e.ColumnIndex == Dgv_Detalle_Movimiento.Columns["Debe"].Index)
            {
                if (row.Cells["Debe"].Value != null && !string.IsNullOrEmpty(row.Cells["Debe"].Value.ToString()))
                {
                    // Limpiar Haber si se llenó Debe
                    row.Cells["Haber"].Value = null;
                }
            }
            // Si es la columna Haber
            else if (e.ColumnIndex == Dgv_Detalle_Movimiento.Columns["Haber"].Index)
            {
                if (row.Cells["Haber"].Value != null && !string.IsNullOrEmpty(row.Cells["Haber"].Value.ToString()))
                {
                    // Limpiar Debe si se llenó Haber
                    row.Cells["Debe"].Value = null;
                }
            }
        }
        private void ConfigurarComboConciliado()
        {
            if (Cbo_Conciliado == null)
            {
                Cbo_Conciliado = new ComboBox();
                Cbo_Conciliado.Name = "Cbo_Conciliado";
                Cbo_Conciliado.Location = new Point(180, 240);
                Cbo_Conciliado.Size = new Size(100, 20);
                Cbo_Conciliado.DropDownStyle = ComboBoxStyle.DropDownList;
                this.Controls.Add(Cbo_Conciliado);
            }
            // Configurar opciones usando una lista anónima
            Cbo_Conciliado.Items.Clear();
            Cbo_Conciliado.Items.Add(new { Text = "No", Value = 0 });
            Cbo_Conciliado.Items.Add(new { Text = "Sí", Value = 1 });
            Cbo_Conciliado.DisplayMember = "Text";
            Cbo_Conciliado.ValueMember = "Value";
            Cbo_Conciliado.SelectedIndex = -1;
        }

        // ========== MÉTODOS DE CARGA DE DATOS ==========
        private void CargarCuentasRecibe()
        {
            CRUD crud = new CRUD();
            try
            {
                DataTable dt = crud.ObtenerCuentas();
                if (dt.Rows.Count > 0)
                {
                    Cbo_NoCuenta_Recibe.DataSource = dt;
                    Cbo_NoCuenta_Recibe.DisplayMember = "Cmp_Numero_Cuenta"; // lo que se muestra
                    Cbo_NoCuenta_Recibe.ValueMember = "Pk_Id_Cuenta"; // valor interno
                    Cbo_NoCuenta_Recibe.SelectedIndex = -1; // empieza vacío
                }
                else
                {
                    MessageBox.Show("No hay cuentas disponibles en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cuentas: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCuentasEnvia()
        {
            CRUD crud = new CRUD();
            try
            {
                DataTable dt = crud.ObtenerCuentas();
                if (dt.Rows.Count > 0)
                {
                    Cbo_NoCuenta_Envia.DataSource = dt;
                    Cbo_NoCuenta_Envia.DisplayMember = "Cmp_Numero_Cuenta"; // lo que se muestra
                    Cbo_NoCuenta_Envia.ValueMember = "Pk_Id_Cuenta"; // valor interno
                    Cbo_NoCuenta_Envia.SelectedIndex = -1; // empieza vacío
                }
                else
                {
                    MessageBox.Show("No hay cuentas disponibles en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cuentas: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cbo_NoCuenta_Recibe_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cbo_NoCuenta_Recibe.SelectedValue != null)
            {
                int idCuenta = Convert.ToInt32(Cbo_NoCuenta_Recibe.SelectedValue);
                string nombreCuenta = crud.ObtenerNombreCuenta(idCuenta);
                Txt_NombreCuenta_Recibe.Text = nombreCuenta;

            }
        }

        private void Cbo_NoCuenta_Envia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cbo_NoCuenta_Envia.SelectedValue != null)
            {
                int idCuenta = Convert.ToInt32(Cbo_NoCuenta_Envia.SelectedValue);
                string nombreCuenta = crud.ObtenerNombreCuenta(idCuenta);
                Txt_NombreCuenta_Envia.Text = nombreCuenta;
            }
        }
        private void CargarEstadosMovimiento()
        {
            try
            {
                var crud = new CRUD();
                var estados = crud.ObtenerEstadosMovimiento();
                // Configurar el ComboBox
                Cbo_Estado.DataSource = estados;
                Cbo_Estado.DropDownStyle = ComboBoxStyle.DropDownList;
                // Establecer "Activo" como valor por defecto
                if (estados.Contains("Activo"))
                {
                    Cbo_Estado.SelectedItem = "Activo";
                }
                else if (estados.Count > 0)
                {
                    Cbo_Estado.SelectedIndex = 0;
                }
                Console.WriteLine($"Estados cargados: {string.Join(", ", estados)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estados: {ex.Message}");
                // Valores por defecto
                Cbo_Estado.Items.AddRange(new[] { "Activo", "Anulado", "Pendiente", "Trasladado" });
                Cbo_Estado.SelectedIndex = 0;
            }
        }

        private void CargarOperaciones()
        {
            try
            {
                var dt = crud.ObtenerOperaciones();
                Cbo_Operacion.DataSource = null;
                Cbo_Operacion.Items.Clear();

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay operaciones disponibles en la base de datos.");
                    Cbo_Operacion.Enabled = false;
                    return;
                }

                Cbo_Operacion.DataSource = dt;
                Cbo_Operacion.DisplayMember = "Cmp_nombre";
                Cbo_Operacion.ValueMember = "Pk_Id_operacion";
                Cbo_Operacion.SelectedIndex = -1;

                Console.WriteLine($"Operaciones cargadas: {dt.Rows.Count}");
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine($"ID: {row["Pk_Id_operacion"]}, Nombre: {row["Cmp_nombre"]}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar operaciones: " + ex.Message);
                Cbo_Operacion.DataSource = null;
                Cbo_Operacion.Items.Clear();
                Cbo_Operacion.Enabled = false;
            }
        }
        private void Cbo_Operacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cbo_Operacion.SelectedValue == null) return;
            // Lee desde el DataRowView para evitar des-sincronización del Text
            var row = Cbo_Operacion.SelectedItem as DataRowView;
            string nombreOperacion = row?["Cmp_nombre"]?.ToString().Trim() ?? string.Empty;
            // Habilitar "Recibe" SOLO si es Transferencia
            bool habilitarRecibe = nombreOperacion.Equals("Transferencia", StringComparison.OrdinalIgnoreCase);
            Cbo_NoCuenta_Recibe.Enabled = habilitarRecibe;
            Txt_NombreCuenta_Recibe.Enabled = habilitarRecibe;
            if (!habilitarRecibe)
            {
                Cbo_NoCuenta_Recibe.SelectedIndex = -1;
                Txt_NombreCuenta_Recibe.Clear();
            }
            // Signo por operación
            int idOperacion = Convert.ToInt32(Cbo_Operacion.SelectedValue);
            string signo = crud.ObtenerSignoOperacionPorId(idOperacion); // "+" o "-"
            if (signo == "+" || signo == "-")
            {
                if (Cbo_Signo.Items.Count == 0)
                {
                    Cbo_Signo.Items.Add("+");
                    Cbo_Signo.Items.Add("-");
                }
                Cbo_Signo.DropDownStyle = ComboBoxStyle.DropDownList;
                Cbo_Signo.Enabled = false;
                Cbo_Signo.SelectedItem = signo;
            }
            else
            {
                Cbo_Signo.Enabled = false;
            }
        }

        private int? ObtenerCuentaDestino()
        {
            if (Cbo_NoCuenta_Recibe.Enabled && Cbo_NoCuenta_Recibe.SelectedValue != null)
            {
                return Convert.ToInt32(Cbo_NoCuenta_Recibe.SelectedValue);
            }
            return null;
        }

        private bool guardando = false;

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // ========== CAPTURAR VALORES DE LOS COMBOBOX ==========
                int conciliado = Cbo_Conciliado.SelectedIndex == 1 ? 1 : 0;
                string estado = Cbo_Estado.SelectedItem?.ToString() ?? "Activo";
                // ========== VALIDAR MONTO PRINCIPAL ==========
                if (!decimal.TryParse(Txt_Monto.Text, out decimal montoPrincipal) || montoPrincipal <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un monto válido mayor a cero.");
                    Txt_Monto.Focus();
                    return;
                }
                // ========== CREAR OBJETO MOVIMIENTO ==========
                var mov = new Sentencias
                {
                    Fk_Id_cuenta_origen = Convert.ToInt32(Cbo_NoCuenta_Envia.SelectedValue),
                    Fk_Id_cuenta_destino = Cbo_NoCuenta_Recibe.SelectedValue != null ?
                                          Convert.ToInt32(Cbo_NoCuenta_Recibe.SelectedValue) : (int?)null,
                    Fk_Id_operacion = Convert.ToInt32(Cbo_Operacion.SelectedValue),
                    Cmp_fecha_movimiento = DateTime.Now,
                    Cmp_numero_documento = Txt_NumeroDocumento.Text,
                    Cmp_valor_total = montoPrincipal,
                    Cmp_observaciones = Txt_Concepto.Text,
                    Cmp_conciliado = conciliado,
                    Cmp_estado = estado
                };
                // ========== CREAR DETALLES CON DEBE Y HABER ==========
                var detalles = new List<Sentencias.MovimientoDetalle>();
                var controlador = new Controlador();
                // Procesar cada fila del DataGridView
                foreach (DataGridViewRow row in Dgv_Detalle_Movimiento.Rows)
                {
                    if (row.IsNewRow) continue;
                    // Capturar valores de Debe y Haber
                    decimal debe = 0;
                    decimal haber = 0;
                    string tipoLinea = "";
                    decimal monto = 0;
                    // Verificar si se ingresó en Debe
                    if (decimal.TryParse(row.Cells["Debe"].Value?.ToString(), out debe) && debe > 0)
                    {
                        monto = debe;
                        tipoLinea = "D"; // Debe
                    }
                    // Verificar si se ingresó en Haber
                    else if (decimal.TryParse(row.Cells["Haber"].Value?.ToString(), out haber) && haber > 0)
                    {
                        monto = haber;
                        tipoLinea = "H"; // Haber
                    }
                    else
                    {
                        continue; // Saltar fila si no tiene monto válido
                    }
                    int? tipoPago = null;
                    if (int.TryParse(row.Cells["Fk_Id_tipo_pago"].Value?.ToString(), out int tp))
                        tipoPago = tp;
                    string doc = row.Cells["Cmp_Num_Documento"].Value?.ToString();
                    string desc = row.Cells["Cmp_Concepto"].Value?.ToString();
                    // Crear detalle con la información de Debe/Haber
                    detalles.Add(new Sentencias.MovimientoDetalle
                    {
                        Fk_Id_tipo_pago = tipoPago,
                        Cmp_Num_Documento = doc?.Trim(),
                        Cmp_Monto = monto,
                        Cmp_Descripcion = desc?.Trim(),
                        Cmp_Conciliado = 0,

                    });
                }

                // ========== VALIDAR USANDO CONTROLADOR ==========
                var errores = controlador.ValidarMovimiento(mov, detalles);
                if (errores.Any())
                {
                    MessageBox.Show("Errores de validación:\n\n• " + string.Join("\n• ", errores));
                    return;
                }

                // ========== GUARDAR ==========
                var crud = new CRUD();
                int idNuevo = crud.CrearMovimientoConDetalles(mov, detalles);

                MessageBox.Show($"Movimiento guardado correctamente. ID: {idNuevo}");

                // ========== LIMPIAR FORMULARIO ==========
                LimpiarFormulario();
                // ========== RECARGAR DATOS EN EL DATAGRIDVIEW ==========
                CargarDatosEnEstructuraCaptura(); 

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}");
            }
            finally
            {
                guardando = false;
                Btn_Guardar.Enabled = true;
            }
        }

    private void LimpiarFormulario()
        {
            try
            {
                // Limpiar controles de texto
                Txt_NumeroDocumento.Clear();
                Txt_Monto.Clear();
                Txt_Concepto.Clear();
                Txt_NombreCuenta_Envia.Clear();
                Txt_NombreCuenta_Recibe.Clear();
                Txt_Fecha.Clear();
                Txt_Hora.Clear();
                Txt_Moneda.Clear();
                // Limpiar combos
                Cbo_NoCuenta_Envia.SelectedIndex = -1;
                Cbo_NoCuenta_Recibe.SelectedIndex = -1;
                Cbo_Operacion.SelectedIndex = -1;
                Cbo_Signo.SelectedIndex = -1;
                // Limpiar DataGridView
                if (Dgv_Detalle_Movimiento.Rows.Count > 0)
                {
                    // Remover filas existentes excepto la nueva
                    for (int i = Dgv_Detalle_Movimiento.Rows.Count - 1; i >= 0; i--)
                    {
                        if (!Dgv_Detalle_Movimiento.Rows[i].IsNewRow)
                        {
                            Dgv_Detalle_Movimiento.Rows.RemoveAt(i);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al limpiar formulario: {ex.Message}");
            }
        }
    }
}

