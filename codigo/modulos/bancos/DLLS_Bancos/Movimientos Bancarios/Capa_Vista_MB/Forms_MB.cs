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
        Cls_Conexion cn = new Cls_Conexion();
        Cls_CRUD crud = new Cls_CRUD();

        public class Cls_OpcionCombo
        {
            public string sTexto { get; set; }
            public int iValor { get; set; }
        }

        public Forms_MB()
        {
            InitializeComponent();
            this.Load += Forms_MB_Load;

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

            Lbl_Division.AutoSize = false;
            Lbl_Division.Height = 2;
            Lbl_Division.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Division.BackColor = Color.Green;

            Lbl_Division2.AutoSize = false;
            Lbl_Division2.Height = 2;
            Lbl_Division2.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Division2.BackColor = Color.Green;
        }

        private void Forms_MB_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Font = new Font("Rockwell", 11, FontStyle.Regular);
            pro_CargarCuentasRecibe();
            pro_CargarCuentasEnvia();
            pro_CargarOperaciones();
            pro_ConfigurarComboConciliado();
            pro_CargarEstadosMovimiento();
            pro_CargarDatosEnEstructuraCaptura();
            pro_PrepararGridParaNuevoMovimiento();

            pro_CargarMovimientosCompletos();      

            pro_CargarMovimientosCompletos();

            Cbo_NoCuenta_Recibe.Enabled = false;
            Txt_NombreCuenta_Recibe.Enabled = false;
        }

        private void pro_CargarDatosEnEstructuraCaptura()
        {
            try
            {
                if (Dgv_Detalle_Movimiento.Columns.Count == 0)
                {
                    pro_CargarMovimientosCompletos();
                }
                DataTable dts_Movimientos = crud.fun_ObtenerMovimientosCompletos();
                if (dts_Movimientos.Rows.Count == 0)
                {
                    Dgv_Detalle_Movimiento.Rows.Clear();
                    MessageBox.Show("No hay movimientos registrados.", "Información");
                    return;
                }
                // LIMPIAR GRID
                Dgv_Detalle_Movimiento.Rows.Clear();
                // CARGAR DATOS EN EL GRID
                foreach (DataRow row in dts_Movimientos.Rows)
                {
                    int iIndex = Dgv_Detalle_Movimiento.Rows.Add();
                    // ASIGNAR VALORES 
                    Dgv_Detalle_Movimiento.Rows[iIndex].Cells["Cmp_Num_Documento"].Value =
                        row["Cmp_NumeroDocumento"] != DBNull.Value ? row["Cmp_NumeroDocumento"] : "SIN DOC";

                    Dgv_Detalle_Movimiento.Rows[iIndex].Cells["Debe"].Value =
                        row["Debe"] != DBNull.Value ? Convert.ToDecimal(row["Debe"]) : 0m;

                    Dgv_Detalle_Movimiento.Rows[iIndex].Cells["Haber"].Value =
                        row["Haber"] != DBNull.Value ? Convert.ToDecimal(row["Haber"]) : 0m;

                    // CREAR UN CONCEPTO DESCRIPTIVO
                    string concepto = $"{row["Tipo_Operacion"]} - {row["Cmp_Beneficiario"]}";
                    Dgv_Detalle_Movimiento.Rows[iIndex].Cells["Cmp_Concepto"].Value =
                        concepto.Length > 50 ? concepto.Substring(0, 50) + "..." : concepto;

                    // Mostrar tipo de pago
                    Dgv_Detalle_Movimiento.Rows[iIndex].Cells["Fk_Id_tipo_pago"].Value =
                        row["Tipo_Operacion"] != DBNull.Value ? row["Tipo_Operacion"] : "";
                }

                decimal totalDebe = Convert.ToDecimal(dts_Movimientos.Compute("SUM(Debe)", ""));
                decimal totalHaber = Convert.ToDecimal(dts_Movimientos.Compute("SUM(Haber)", ""));

                MessageBox.Show($"Movimientos cargados: {dts_Movimientos.Rows.Count}\n" +
                               $"Total Débito: {totalDebe:C2}\n" +
                               $"Total Crédito: {totalHaber:C2}",
                               "Resumen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
            }
        }

        //genera el datagrie
        private void pro_CargarMovimientosCompletos()
        {
            try
            {
                // USAR ESTE ENFOQUE MÁS SEGURO
                if (Dgv_Detalle_Movimiento.InvokeRequired)
                {
                    Dgv_Detalle_Movimiento.Invoke(new Action(() => pro_CargarMovimientosCompletos()));
                    return;
                }

                // GUARDAR LA CONFIGURACIÓN ACTUAL DEL GRID
                bool estabaEditando = !Dgv_Detalle_Movimiento.ReadOnly;

                // LIMPIAR DE FORMA SEGURA
                Dgv_Detalle_Movimiento.DataSource = null;
                Dgv_Detalle_Movimiento.Rows.Clear();
                Dgv_Detalle_Movimiento.Columns.Clear();

                // CARGAR DATOS EXISTENTES
                var dt = crud.fun_ObtenerMovimientosView();

                if (dt != null && dt.Rows.Count > 0)
                {
                    Dgv_Detalle_Movimiento.DataSource = dt;

                    // CONFIGURAR COMO SOLO LECTURA PARA DATOS EXISTENTES
                    Dgv_Detalle_Movimiento.ReadOnly = true;
                    Dgv_Detalle_Movimiento.AllowUserToAddRows = false;
                }
                else
                {
                    // SI NO HAY DATOS, CONFIGURAR PARA CAPTURA
                    pro_ConfigurarGridParaCaptura();
                }
            }
            catch (Exception)
            {
            }
        }


        private void pro_PrepararGridParaNuevoMovimiento()
        {
            try
            {
                // LIMPIAR COMPLETAMENTE
                Dgv_Detalle_Movimiento.DataSource = null;
                Dgv_Detalle_Movimiento.Rows.Clear();
                Dgv_Detalle_Movimiento.Columns.Clear();

                // CONFIGURAR COLUMNAS PARA CAPTURA
                DataGridViewTextBoxColumn colDoc = new DataGridViewTextBoxColumn();
                colDoc.Name = "Cmp_Num_Documento";
                colDoc.HeaderText = "Documento";
                colDoc.Width = 120;
                Dgv_Detalle_Movimiento.Columns.Add(colDoc);

                DataGridViewTextBoxColumn colDebe = new DataGridViewTextBoxColumn();
                colDebe.Name = "Debe";
                colDebe.HeaderText = "Débito";
                colDebe.Width = 100;
                colDebe.DefaultCellStyle.Format = "N2";
                colDebe.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Dgv_Detalle_Movimiento.Columns.Add(colDebe);

                DataGridViewTextBoxColumn colHaber = new DataGridViewTextBoxColumn();
                colHaber.Name = "Haber";
                colHaber.HeaderText = "Crédito";
                colHaber.Width = 100;
                colHaber.DefaultCellStyle.Format = "N2";
                colHaber.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Dgv_Detalle_Movimiento.Columns.Add(colHaber);

                DataGridViewTextBoxColumn colConcepto = new DataGridViewTextBoxColumn();
                colConcepto.Name = "Cmp_Concepto";
                colConcepto.HeaderText = "Concepto";
                colConcepto.Width = 200;
                Dgv_Detalle_Movimiento.Columns.Add(colConcepto);

                DataGridViewTextBoxColumn colTipoPago = new DataGridViewTextBoxColumn();
                colTipoPago.Name = "Fk_Id_tipo_pago";
                colTipoPago.HeaderText = "Tipo Pago";
                colTipoPago.Width = 100;
                Dgv_Detalle_Movimiento.Columns.Add(colTipoPago);

                // HACER EDITABLE
                Dgv_Detalle_Movimiento.ReadOnly = false;
                Dgv_Detalle_Movimiento.AllowUserToAddRows = true;

                // AGREGAR FILA VACÍA
                Dgv_Detalle_Movimiento.Rows.Add();

                MessageBox.Show("Grid listo para capturar nuevo movimiento", "Información");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al preparar grid: {ex.Message}");
            }
        }

        private void pro_ConfigurarGridMovimientos()
        {
            // Limpiar columnas existentes
            Dgv_Detalle_Movimiento.Columns.Clear();

            // Agregar columnas necesarias para captura
            Dgv_Detalle_Movimiento.Columns.Add("Cmp_Num_Documento", "N° Documento");
            Dgv_Detalle_Movimiento.Columns.Add("Debe", "Débito");
            Dgv_Detalle_Movimiento.Columns.Add("Haber", "Crédito");
            Dgv_Detalle_Movimiento.Columns.Add("Cmp_Concepto", "Concepto");
            Dgv_Detalle_Movimiento.Columns.Add("Fk_Id_tipo_pago", "Tipo Pago");

            // Configurar columnas
            Dgv_Detalle_Movimiento.Columns["Debe"].DefaultCellStyle.Format = "N2";
            Dgv_Detalle_Movimiento.Columns["Haber"].DefaultCellStyle.Format = "N2";
            Dgv_Detalle_Movimiento.Columns["Debe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgv_Detalle_Movimiento.Columns["Haber"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            Dgv_Detalle_Movimiento.Columns["Cmp_Num_Documento"].Width = 120;
            Dgv_Detalle_Movimiento.Columns["Debe"].Width = 100;
            Dgv_Detalle_Movimiento.Columns["Haber"].Width = 100;
            Dgv_Detalle_Movimiento.Columns["Cmp_Concepto"].Width = 200;
            Dgv_Detalle_Movimiento.Columns["Fk_Id_tipo_pago"].Width = 100;

            // Hacer editable solo las columnas necesarias para nuevo movimiento
            Dgv_Detalle_Movimiento.Columns["Cmp_Num_Documento"].ReadOnly = false;
            Dgv_Detalle_Movimiento.Columns["Debe"].ReadOnly = false;
            Dgv_Detalle_Movimiento.Columns["Haber"].ReadOnly = false;
            Dgv_Detalle_Movimiento.Columns["Cmp_Concepto"].ReadOnly = false;
            Dgv_Detalle_Movimiento.Columns["Fk_Id_tipo_pago"].ReadOnly = false;
        }

        private void pro_ConfigurarGridParaCaptura()
        {
            try
            {
                Dgv_Detalle_Movimiento.Columns.Clear();

                // COLUMNAS PARA CAPTURA DE NUEVO MOVIMIENTO
                DataGridViewTextBoxColumn colDocumento = new DataGridViewTextBoxColumn();
                colDocumento.Name = "Cmp_Num_Documento";
                colDocumento.HeaderText = "N° Documento";
                colDocumento.Width = 120;
                Dgv_Detalle_Movimiento.Columns.Add(colDocumento);

                DataGridViewTextBoxColumn colDebe = new DataGridViewTextBoxColumn();
                colDebe.Name = "Debe";
                colDebe.HeaderText = "Débito";
                colDebe.Width = 100;
                colDebe.DefaultCellStyle.Format = "N2";
                colDebe.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Dgv_Detalle_Movimiento.Columns.Add(colDebe);

                DataGridViewTextBoxColumn colHaber = new DataGridViewTextBoxColumn();
                colHaber.Name = "Haber";
                colHaber.HeaderText = "Crédito";
                colHaber.Width = 100;
                colHaber.DefaultCellStyle.Format = "N2";
                colHaber.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Dgv_Detalle_Movimiento.Columns.Add(colHaber);

                DataGridViewTextBoxColumn colConcepto = new DataGridViewTextBoxColumn();
                colConcepto.Name = "Cmp_Concepto";
                colConcepto.HeaderText = "Concepto";
                colConcepto.Width = 200;
                Dgv_Detalle_Movimiento.Columns.Add(colConcepto);

                DataGridViewTextBoxColumn colTipoPago = new DataGridViewTextBoxColumn();
                colTipoPago.Name = "Fk_Id_tipo_pago";
                colTipoPago.HeaderText = "Tipo Pago";
                colTipoPago.Width = 100;
                Dgv_Detalle_Movimiento.Columns.Add(colTipoPago);

                // HACER EDITABLE PARA CAPTURA
                Dgv_Detalle_Movimiento.ReadOnly = false;
                Dgv_Detalle_Movimiento.AllowUserToAddRows = true;

                // AGREGAR UNA FILA VACÍA PARA CAPTURA
                Dgv_Detalle_Movimiento.Rows.Add();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al configurar grid: {ex.Message}");
            }
        }

        private void Dgv_Detalle_Movimiento_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow dgv_Row = Dgv_Detalle_Movimiento.Rows[e.RowIndex];

            if (e.ColumnIndex == Dgv_Detalle_Movimiento.Columns["Debe"].Index)
            {
                if (dgv_Row.Cells["Debe"].Value != null && !string.IsNullOrEmpty(dgv_Row.Cells["Debe"].Value.ToString()))
                {
                    dgv_Row.Cells["Haber"].Value = null;
                }
            }
            else if (e.ColumnIndex == Dgv_Detalle_Movimiento.Columns["Haber"].Index)
            {
                if (dgv_Row.Cells["Haber"].Value != null && !string.IsNullOrEmpty(dgv_Row.Cells["Haber"].Value.ToString()))
                {
                    dgv_Row.Cells["Debe"].Value = null;
                }
            }
        }

        private void pro_ConfigurarComboConciliado()
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

            Cbo_Conciliado.Items.Clear();
            Cbo_Conciliado.Items.Add(new { Text = "No", Value = 0 });
            Cbo_Conciliado.Items.Add(new { Text = "Sí", Value = 1 });
            Cbo_Conciliado.DisplayMember = "Text";
            Cbo_Conciliado.ValueMember = "Value";
            Cbo_Conciliado.SelectedIndex = -1;
        }

        private void pro_CargarCuentasRecibe()
        {
            Cls_CRUD crud = new Cls_CRUD();
            try
            {
                DataTable dts_Cuentas = crud.fun_ObtenerCuentas();
                if (dts_Cuentas.Rows.Count > 0)
                {
                    Cbo_NoCuenta_Recibe.DataSource = dts_Cuentas;
                    Cbo_NoCuenta_Recibe.DisplayMember = "Cmp_Numero_Cuenta";
                    Cbo_NoCuenta_Recibe.ValueMember = "Pk_Id_Cuenta";
                    Cbo_NoCuenta_Recibe.SelectedIndex = -1;
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

        private void pro_CargarCuentasEnvia()
        {
            Cls_CRUD crud = new Cls_CRUD();
            try
            {
                DataTable dts_Cuentas = crud.fun_ObtenerCuentas();
                if (dts_Cuentas.Rows.Count > 0)
                {
                    Cbo_NoCuenta_Envia.DataSource = dts_Cuentas;
                    Cbo_NoCuenta_Envia.DisplayMember = "Cmp_Numero_Cuenta";
                    Cbo_NoCuenta_Envia.ValueMember = "Pk_Id_Cuenta";
                    Cbo_NoCuenta_Envia.SelectedIndex = -1;
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
                int iIdCuenta = Convert.ToInt32(Cbo_NoCuenta_Recibe.SelectedValue);
                string sNombreCuenta = crud.fun_ObtenerNombreCuenta(iIdCuenta);
                Txt_NombreCuenta_Recibe.Text = sNombreCuenta;
            }
        }

        private void Cbo_NoCuenta_Envia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cbo_NoCuenta_Envia.SelectedValue != null)
            {
                int iIdCuenta = Convert.ToInt32(Cbo_NoCuenta_Envia.SelectedValue);
                string sNombreCuenta = crud.fun_ObtenerNombreCuenta(iIdCuenta);
                Txt_NombreCuenta_Envia.Text = sNombreCuenta;
            }
        }

        private void pro_CargarEstadosMovimiento()
        {
            try
            {
                var crud = new Cls_CRUD();
                var lst_Estados = crud.fun_ObtenerEstadosMovimiento();

                Cbo_Estado.DataSource = lst_Estados;
                Cbo_Estado.DropDownStyle = ComboBoxStyle.DropDownList;

                if (lst_Estados.Contains("Activo"))
                {
                    Cbo_Estado.SelectedItem = "Activo";
                }
                else if (lst_Estados.Count > 0)
                {
                    Cbo_Estado.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estados: {ex.Message}");
                Cbo_Estado.Items.AddRange(new[] { "Activo", "Anulado", "Pendiente", "Trasladado" });
                Cbo_Estado.SelectedIndex = 0;
            }
        }

        private void pro_CargarOperaciones()
        {
            try
            {
                DataTable dts_Operaciones = crud.fun_ObtenerOperaciones();
                Cbo_Operacion.DataSource = null;
                Cbo_Operacion.Items.Clear();

                if (dts_Operaciones == null || dts_Operaciones.Rows.Count == 0)
                {
                    MessageBox.Show("No hay operaciones disponibles en la base de datos.");
                    Cbo_Operacion.Enabled = false;
                    return;
                }

                Cbo_Operacion.DataSource = dts_Operaciones;
                Cbo_Operacion.DisplayMember = "Cmp_nombre";
                Cbo_Operacion.ValueMember = "Pk_Id_operacion";
                Cbo_Operacion.SelectedIndex = -1;
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

            DataRowView drv_Row = Cbo_Operacion.SelectedItem as DataRowView;
            string sNombreOperacion = drv_Row?["Cmp_nombre"]?.ToString().Trim() ?? string.Empty;

            bool bHabilitarRecibe = sNombreOperacion.Equals("TRANSFERENCIA_ENVIADA", StringComparison.OrdinalIgnoreCase) ||
                                    sNombreOperacion.Equals("TRANSFERENCIA_RECIBIDA", StringComparison.OrdinalIgnoreCase);

            Cbo_NoCuenta_Recibe.Enabled = bHabilitarRecibe;
            Txt_NombreCuenta_Recibe.Enabled = bHabilitarRecibe;

            if (!bHabilitarRecibe)
            {
                Cbo_NoCuenta_Recibe.SelectedIndex = -1;
                Txt_NombreCuenta_Recibe.Clear();
            }

            int iIdOperacion = Convert.ToInt32(Cbo_Operacion.SelectedValue);
            string sSigno = crud.fun_ObtenerSignoOperacionPorId(iIdOperacion);

            if (sSigno == "+" || sSigno == "-")
            {
                if (Cbo_Signo.Items.Count == 0)
                {
                    Cbo_Signo.Items.Add("+");
                    Cbo_Signo.Items.Add("-");
                }
                Cbo_Signo.DropDownStyle = ComboBoxStyle.DropDownList;
                Cbo_Signo.Enabled = false;
                Cbo_Signo.SelectedItem = sSigno;
            }
            else
            {
                Cbo_Signo.Enabled = false;
            }
        }

        private int? fun_ObtenerCuentaDestino()
        {
            if (Cbo_NoCuenta_Recibe.Enabled && Cbo_NoCuenta_Recibe.SelectedValue != null)
            {
                return Convert.ToInt32(Cbo_NoCuenta_Recibe.SelectedValue);
            }
            return null;
        }

        private bool bGuardando = false;


        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bGuardando) return;
                bGuardando = true;
                Btn_Guardar.Enabled = false;

                // FORZAR TERMINAR EDICIÓN
                Dgv_Detalle_Movimiento.EndEdit();

                // VALIDACIONES BÁSICAS
                if (Cbo_NoCuenta_Envia.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una cuenta origen.");
                    return;
                }

                if (Cbo_Operacion.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una operación.");
                    return;
                }

                // VALIDAR MONTO - MÁS FLEXIBLE
                string montoTexto = Txt_Monto.Text.Trim();
                if (string.IsNullOrEmpty(montoTexto))
                {
                    MessageBox.Show("Ingrese un monto.");
                    Txt_Monto.Focus();
                    return;
                }

                // PERMITIR DIFERENTES FORMATOS NUMÉRICOS
                montoTexto = montoTexto.Replace(",", "").Replace(" ", "");
                if (!decimal.TryParse(montoTexto, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal deMontoPrincipal) || deMontoPrincipal <= 0)
                {
                    MessageBox.Show("Ingrese un monto válido mayor a cero.\nEjemplos: 4, 4.00, 4,000.00", "Validación");
                    Txt_Monto.Focus();
                    Txt_Monto.SelectAll();
                    return;
                }

                // VERIFICAR DETALLES EN EL GRID - CON MÁS INFORMACIÓN DE DEPURACIÓN
                bool tieneDetalles = false;
                var lst_Detalles = new List<Cls_Sentencias.Cls_MovimientoDetalle>();

                MessageBox.Show($"Verificando {Dgv_Detalle_Movimiento.Rows.Count} filas en el grid...", "Depuración");

                for (int i = 0; i < Dgv_Detalle_Movimiento.Rows.Count; i++)
                {
                    var row = Dgv_Detalle_Movimiento.Rows[i];
                    if (row.IsNewRow) continue;

                    // Mostrar qué contiene cada celda
                    string debeVal = row.Cells["Debe"]?.Value?.ToString() ?? "null";
                    string haberVal = row.Cells["Haber"]?.Value?.ToString() ?? "null";

                    MessageBox.Show($"Fila {i}: Debe='{debeVal}', Haber='{haberVal}'", "Depuración");

                    decimal deMonto = 0;
                    string sTipoLinea = "";

                    // VERIFICAR DEBE
                    if (!string.IsNullOrEmpty(debeVal) && decimal.TryParse(debeVal, out decimal deDebe) && deDebe > 0)
                    {
                        deMonto = deDebe;
                        sTipoLinea = "D";
                        tieneDetalles = true;
                    }
                    // VERIFICAR HABER
                    else if (!string.IsNullOrEmpty(haberVal) && decimal.TryParse(haberVal, out decimal deHaber) && deHaber > 0)
                    {
                        deMonto = deHaber;
                        sTipoLinea = "C";
                        tieneDetalles = true;
                    }

                    if (tieneDetalles)
                    {
                        string sDocumento = row.Cells["Cmp_Concepto"]?.Value?.ToString() ?? Txt_NumeroDocumento.Text.Trim();
                        string sDescripcion = row.Cells["Cmp_Concepto"]?.Value?.ToString() ?? Txt_Concepto.Text.Trim();

                        int? iTipoPago = null;
                        if (row.Cells["Fk_Id_tipo_pago"]?.Value != null &&
                            int.TryParse(row.Cells["Fk_Id_tipo_pago"].Value.ToString(), out int iTp))
                        {
                            iTipoPago = iTp;
                        }

                        lst_Detalles.Add(new Cls_Sentencias.Cls_MovimientoDetalle
                        {
                            iFk_Id_tipo_pago = iTipoPago,
                            sCmp_Num_Documento = sDocumento,
                            deCmp_Monto = deMonto,
                            deCmp_valor = deMonto,
                            sCmp_Descripcion = sDescripcion,
                            iCmp_Conciliado = 0,
                            sFk_Id_cuenta_contable = "1110",
                            sCmp_tipo_operacion = sTipoLinea
                        });

                        MessageBox.Show($"Detalle agregado: {sTipoLinea} {deMonto:C}", "Depuración");
                    }
                }

                if (!tieneDetalles || lst_Detalles.Count == 0)
                {
                    MessageBox.Show("No se encontraron detalles válidos.\n\nAsegúrese de:\n1. Ingresar un valor en Débito O Crédito\n2. El valor debe ser mayor a cero\n3. Presionar ENTER después de ingresar el valor", "Validación");
                    return;
                }

                // CREAR MOVIMIENTO PRINCIPAL
                var mov = new Cls_Sentencias
                {
                    iFk_Id_cuenta_origen = Convert.ToInt32(Cbo_NoCuenta_Envia.SelectedValue),
                    iFk_Id_cuenta_destino = Cbo_NoCuenta_Recibe.SelectedValue != null ?
                                          Convert.ToInt32(Cbo_NoCuenta_Recibe.SelectedValue) : (int?)null,
                    iFk_Id_operacion = Convert.ToInt32(Cbo_Operacion.SelectedValue),
                    dCmp_fecha_movimiento = DateTime.Now,
                    sCmp_numero_documento = Txt_NumeroDocumento.Text.Trim(),
                    deCmp_valor_total = deMontoPrincipal,
                    sCmp_concepto = Txt_Concepto.Text.Trim(),
                    iCmp_conciliado = Cbo_Conciliado.SelectedIndex == 1 ? 1 : 0,
                    sCmp_estado = Cbo_Estado.SelectedItem?.ToString() ?? "ACTIVO",
                    sCmp_usuario_registro = "USUARIO_SISTEMA"
                };

                // GUARDAR
                var crud = new Cls_CRUD();
                int iIdNuevo = crud.fun_CrearMovimientoConDetalles(mov, lst_Detalles);

                MessageBox.Show($"Movimiento guardado! ID: {iIdNuevo}", "Éxito");
                pro_LimpiarFormulario();
                pro_CargarMovimientosCompletos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\n{ex.StackTrace}", "Error");
            }
            finally
            {
                bGuardando = false;
                Btn_Guardar.Enabled = true;
            }
        }

        private void pro_LimpiarFormulario()
        {
            try
            {
                Txt_NumeroDocumento.Clear();
                Txt_Monto.Clear();
                Txt_Concepto.Clear();
                Txt_NombreCuenta_Envia.Clear();
                Txt_NombreCuenta_Recibe.Clear();
                Txt_Fecha.Clear();
                Txt_Hora.Clear();
                Txt_Moneda.Clear();

                Cbo_NoCuenta_Envia.SelectedIndex = -1;
                Cbo_NoCuenta_Recibe.SelectedIndex = -1;
                Cbo_Operacion.SelectedIndex = -1;
                Cbo_Signo.SelectedIndex = -1;

                if (Dgv_Detalle_Movimiento.Rows.Count > 0)
                {
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_Detalle_Movimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}