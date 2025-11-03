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
        Cls_Seleccion seleccion = new Cls_Seleccion();
        private bool bEditando = false;
        private int iMovimientoEditandoId = 0;
        private int iCuentaOrigenEditando = 0;
        private int iOperacionEditando = 0;

        public class Cls_OpcionCombo
        {
            public string sTexto { get; set; }
            public int iValor { get; set; }

        }

        public Forms_MB()
        {
            InitializeComponent();
            this.Load += Forms_MB_Load;
            this.Font = new Font("Rockwell", 11, FontStyle.Regular);

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

            //lineas divisoras
            Lbl_Division.AutoSize = false;
            Lbl_Division.Height = 2;
            Lbl_Division.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Division.BackColor = Color.Green;

            Lbl_Division2.AutoSize = false;
            Lbl_Division2.Height = 2;
            Lbl_Division2.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Division2.BackColor = Color.Green;

            Lbl_Division3.AutoSize = false;
            Lbl_Division3.Height = 2;
            Lbl_Division3.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Division3.BackColor = Color.Green;
        }

        private void Forms_MB_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Font = new Font("Rockwell", 11, FontStyle.Regular);

            //cargar cosas esas 
            pro_CargarCuentasRecibe();
            pro_CargarCuentasEnvia();
            pro_CargarOperaciones();
            pro_ConfigurarComboConciliado();
            pro_CargarEstadosMovimiento();
            pro_CargarMovimientosCompletos();
            pro_CargarMonedas();

            pro_CargarTiposPago();

            Cbo_NoCuenta_Recibe.Enabled = false;
            Txt_NombreCuenta_Recibe.Enabled = false;
        }

        //genera el datagrie
        private void pro_CargarMovimientosCompletos()
        {
            try
            {
                pro_ConfigurarGridParaVisualizacion();
                var dt = crud.fun_ObtenerMovimientosPorFiltro();
                Dgv_Detalle_Movimiento.Rows.Clear();

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        int index = Dgv_Detalle_Movimiento.Rows.Add();

                        if (dt.Columns.Contains("Pk_Id_Movimiento"))
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Pk_Id_Movimiento"].Value = row["Pk_Id_Movimiento"];

                        if (dt.Columns.Contains("Fk_Id_CuentaOrigen"))
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Fk_Id_CuentaOrigen"].Value = row["Fk_Id_CuentaOrigen"];

                        if (dt.Columns.Contains("Fk_Id_Operacion"))
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Fk_Id_Operacion"].Value = row["Fk_Id_Operacion"];

                        if (dt.Columns.Contains("Cmp_Estado"))
                        {
                            string estado = row["Cmp_Estado"]?.ToString() ?? "";
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Estado_Movimiento"].Value = estado;

                            Dgv_Detalle_Movimiento.Rows[index].Cells["Estado_Visible"].Value = estado;

                            if (estado == "ANULADO")
                            {
                                Dgv_Detalle_Movimiento.Rows[index].Cells["Estado_Visible"].Style.BackColor = Color.LightCoral;
                                Dgv_Detalle_Movimiento.Rows[index].Cells["Estado_Visible"].Style.ForeColor = Color.DarkRed;
                            }
                            else if (estado == "ACTIVO")
                            {
                                Dgv_Detalle_Movimiento.Rows[index].Cells["Estado_Visible"].Style.BackColor = Color.LightGreen;
                                Dgv_Detalle_Movimiento.Rows[index].Cells["Estado_Visible"].Style.ForeColor = Color.DarkGreen;
                            }
                            else
                            {
                                Dgv_Detalle_Movimiento.Rows[index].Cells["Estado_Visible"].Style.BackColor = Color.LightYellow;
                                Dgv_Detalle_Movimiento.Rows[index].Cells["Estado_Visible"].Style.ForeColor = Color.DarkOrange;
                            }
                        }

                        if (dt.Columns.Contains("Cmp_Conciliado"))
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Cmp_Conciliado"].Value = row["Cmp_Conciliado"];

                        if (dt.Columns.Contains("Cmp_NombreBanco"))
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Nombre_Cuenta"].Value = row["Cmp_NombreBanco"];

                        if (dt.Columns.Contains("Cmp_NumeroCuenta"))
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Codigo_Cuenta"].Value = row["Cmp_NumeroCuenta"];

                        if (dt.Columns.Contains("Cmp_NombreTransaccion"))
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Tipo_Operacion"].Value = row["Cmp_NombreTransaccion"];

                        if (dt.Columns.Contains("Cmp_MontoTotal") && dt.Columns.Contains("Cmp_NombreTransaccion"))
                        {
                            decimal monto = Convert.ToDecimal(row["Cmp_MontoTotal"]);
                            string tipoTransaccion = row["Cmp_NombreTransaccion"]?.ToString() ?? "";

                            if (tipoTransaccion.ToUpper().Contains("DEPÓSITO") ||
                                tipoTransaccion.ToUpper().Contains("INGRESO") ||
                                tipoTransaccion.ToUpper().Contains("RECIBIDA"))
                            {
                                Dgv_Detalle_Movimiento.Rows[index].Cells["Debe"].Value = monto; // Débito
                                Dgv_Detalle_Movimiento.Rows[index].Cells["Haber"].Value = 0;
                            }
                            else
                            {
                                Dgv_Detalle_Movimiento.Rows[index].Cells["Debe"].Value = 0;
                                Dgv_Detalle_Movimiento.Rows[index].Cells["Haber"].Value = monto; // Crédito
                            }
                        }

                        if (dt.Columns.Contains("Cmp_Concepto"))
                        {
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Cmp_Concepto"].Value = row["Cmp_Concepto"];
                        }
                        else
                        {
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Cmp_Concepto"].Value = "Movimiento bancario";
                        }

                        if (dt.Columns.Contains("Cmp_NumeroDocumento"))
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Cmp_Num_Documento"].Value = row["Cmp_NumeroDocumento"];
                    }

                    Dgv_Detalle_Movimiento.ReadOnly = true;
                    Dgv_Detalle_Movimiento.AllowUserToAddRows = false;

                    ActualizarTodosLosTotales();
                }
                else
                {
                    Dgv_Detalle_Movimiento.ReadOnly = false;
                    Dgv_Detalle_Movimiento.AllowUserToAddRows = true;
                    Dgv_Detalle_Movimiento.Rows.Add();

                    ActualizarTodosLosTotales();
                    MessageBox.Show("No hay movimientos existentes. Listo para capturar nuevos movimientos.", "Información");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar movimientos: {ex.Message}");
            }
        }
        private void pro_ConfigurarGridParaVisualizacion()
        {
            try
            {
                Dgv_Detalle_Movimiento.Columns.Clear();

                // CONFIGURACIÓN CLAVE PARA ENCABEZADOS
                Dgv_Detalle_Movimiento.EnableHeadersVisualStyles = false;

                // Configurar selección
                Dgv_Detalle_Movimiento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Dgv_Detalle_Movimiento.MultiSelect = false;

                // Colores de selección para celdas 
                Dgv_Detalle_Movimiento.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
                Dgv_Detalle_Movimiento.DefaultCellStyle.SelectionForeColor = Color.Black;

                // ENCABEZADOS DE COLUMNA 
                Dgv_Detalle_Movimiento.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
                Dgv_Detalle_Movimiento.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                Dgv_Detalle_Movimiento.ColumnHeadersDefaultCellStyle.Font = new Font("Rockwell", 11, FontStyle.Bold);
                Dgv_Detalle_Movimiento.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //color de selección mismo que el normal
                Dgv_Detalle_Movimiento.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SeaGreen;
                Dgv_Detalle_Movimiento.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
                Dgv_Detalle_Movimiento.RowHeadersVisible = true;
                Dgv_Detalle_Movimiento.RowHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                Dgv_Detalle_Movimiento.RowHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Control;

                Dgv_Detalle_Movimiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // OCULTAS PARA LLAVES PRIMARIAS
                DataGridViewTextBoxColumn colCuentaContable = new DataGridViewTextBoxColumn();
                colCuentaContable.Name = "Cuenta_Contable";
                colCuentaContable.HeaderText = "Cuenta Contable";
                colCuentaContable.FillWeight = 15;
                colCuentaContable.Visible = false;
                Dgv_Detalle_Movimiento.Columns.Add(colCuentaContable);

                DataGridViewComboBoxColumn colTipoLinea = new DataGridViewComboBoxColumn();
                colTipoLinea.Name = "Tipo_Linea";
                colTipoLinea.HeaderText = "Tipo";
                colTipoLinea.FillWeight = 8;
                colTipoLinea.Items.AddRange("D", "C");
                colTipoLinea.Visible = false;
                Dgv_Detalle_Movimiento.Columns.Add(colTipoLinea);

                DataGridViewTextBoxColumn colValor = new DataGridViewTextBoxColumn();
                colValor.Name = "Valor";
                colValor.HeaderText = "Valor";
                colValor.FillWeight = 12;
                colValor.DefaultCellStyle.Format = "N2";
                colValor.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                colValor.Visible = false;
                Dgv_Detalle_Movimiento.Columns.Add(colValor);

                DataGridViewTextBoxColumn colDescripcion = new DataGridViewTextBoxColumn();
                colDescripcion.Name = "Descripcion";
                colDescripcion.HeaderText = "Descripción";
                colDescripcion.FillWeight = 20;
                colDescripcion.Visible = false;
                Dgv_Detalle_Movimiento.Columns.Add(colDescripcion);

                DataGridViewTextBoxColumn colPkIdMovimiento = new DataGridViewTextBoxColumn();
                colPkIdMovimiento.Name = "Pk_Id_Movimiento";
                colPkIdMovimiento.HeaderText = "ID Movimiento";
                colPkIdMovimiento.Visible = false;
                Dgv_Detalle_Movimiento.Columns.Add(colPkIdMovimiento);

                DataGridViewTextBoxColumn colFkIdCuentaOrigen = new DataGridViewTextBoxColumn();
                colFkIdCuentaOrigen.Name = "Fk_Id_CuentaOrigen";
                colFkIdCuentaOrigen.HeaderText = "ID Cuenta Origen";
                colFkIdCuentaOrigen.Visible = false;
                Dgv_Detalle_Movimiento.Columns.Add(colFkIdCuentaOrigen);

                DataGridViewTextBoxColumn colFkIdOperacion = new DataGridViewTextBoxColumn();
                colFkIdOperacion.Name = "Fk_Id_Operacion";
                colFkIdOperacion.HeaderText = "ID Operación";
                colFkIdOperacion.Visible = false;
                Dgv_Detalle_Movimiento.Columns.Add(colFkIdOperacion);

                DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn();
                colEstado.Name = "Estado_Movimiento";
                colEstado.HeaderText = "Estado";
                colEstado.Visible = false;
                Dgv_Detalle_Movimiento.Columns.Add(colEstado);

                DataGridViewTextBoxColumn colConciliado = new DataGridViewTextBoxColumn();
                colConciliado.Name = "Cmp_Conciliado";
                colConciliado.HeaderText = "Conciliado";
                colConciliado.Visible = false;
                Dgv_Detalle_Movimiento.Columns.Add(colConciliado);

                // VISIBLES
                DataGridViewTextBoxColumn colEstadoVisible = new DataGridViewTextBoxColumn();
                colEstadoVisible.Name = "Estado_Visible";
                colEstadoVisible.HeaderText = "Estado";
                colEstadoVisible.FillWeight = 8; // 8% del ancho disponible
                colEstadoVisible.ReadOnly = true;
                colEstadoVisible.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colEstadoVisible.DefaultCellStyle.Font = new Font("Rockwell", 9, FontStyle.Bold);
                Dgv_Detalle_Movimiento.Columns.Add(colEstadoVisible);

                DataGridViewTextBoxColumn colNombreCuenta = new DataGridViewTextBoxColumn();
                colNombreCuenta.Name = "Nombre_Cuenta";
                colNombreCuenta.HeaderText = "Cuenta Bancaria";
                colNombreCuenta.FillWeight = 20; // Reducido de 25% a 20%
                colNombreCuenta.ReadOnly = true;
                colNombreCuenta.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                Dgv_Detalle_Movimiento.Columns.Add(colNombreCuenta);

                DataGridViewTextBoxColumn colCodigoCuenta = new DataGridViewTextBoxColumn();
                colCodigoCuenta.Name = "Codigo_Cuenta";
                colCodigoCuenta.HeaderText = "N° Cuenta";
                colCodigoCuenta.FillWeight = 12; // Reducido de 15% a 12%
                colCodigoCuenta.ReadOnly = true;
                Dgv_Detalle_Movimiento.Columns.Add(colCodigoCuenta);

                DataGridViewTextBoxColumn colTipoOperacion = new DataGridViewTextBoxColumn();
                colTipoOperacion.Name = "Tipo_Operacion";
                colTipoOperacion.HeaderText = "Tipo";
                colTipoOperacion.FillWeight = 10; // 10% del ancho disponible
                colTipoOperacion.ReadOnly = true;
                Dgv_Detalle_Movimiento.Columns.Add(colTipoOperacion);

                DataGridViewTextBoxColumn colDebe = new DataGridViewTextBoxColumn();
                colDebe.Name = "Debe";
                colDebe.HeaderText = "Débito";
                colDebe.FillWeight = 10; // Reducido de 12% a 10%
                colDebe.DefaultCellStyle.Format = "N2";
                colDebe.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                colDebe.DefaultCellStyle.BackColor = Color.LightPink;
                colDebe.ReadOnly = true;
                Dgv_Detalle_Movimiento.Columns.Add(colDebe);

                DataGridViewTextBoxColumn colHaber = new DataGridViewTextBoxColumn();
                colHaber.Name = "Haber";
                colHaber.HeaderText = "Crédito";
                colHaber.FillWeight = 10; // 10% del ancho disponible
                colHaber.DefaultCellStyle.Format = "N2";
                colHaber.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                colHaber.DefaultCellStyle.BackColor = Color.LightGreen;
                colHaber.ReadOnly = true;
                Dgv_Detalle_Movimiento.Columns.Add(colHaber);

                DataGridViewTextBoxColumn colConcepto = new DataGridViewTextBoxColumn();
                colConcepto.Name = "Cmp_Concepto";
                colConcepto.HeaderText = "Concepto";
                colConcepto.FillWeight = 20; // Aumentado de 18% a 20%
                colConcepto.ReadOnly = true;
                colConcepto.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                Dgv_Detalle_Movimiento.Columns.Add(colConcepto);

                DataGridViewTextBoxColumn colDocumento = new DataGridViewTextBoxColumn();
                colDocumento.Name = "Cmp_Num_Documento";
                colDocumento.HeaderText = "N° Documento";
                colDocumento.FillWeight = 10; // 10% del ancho disponible
                colDocumento.ReadOnly = true;
                Dgv_Detalle_Movimiento.Columns.Add(colDocumento);

                Dgv_Detalle_Movimiento.ReadOnly = true;
                Dgv_Detalle_Movimiento.AllowUserToAddRows = false;

                // encabezado
                Dgv_Detalle_Movimiento.EnableHeadersVisualStyles = false;
                Dgv_Detalle_Movimiento.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
                Dgv_Detalle_Movimiento.ColumnHeadersDefaultCellStyle.Font = new Font("Rockwell", 11, FontStyle.Bold);
                Dgv_Detalle_Movimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                Dgv_Detalle_Movimiento.ColumnHeadersHeight = 40;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al configurar grid para visualización: {ex.Message}");
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
            try
            {
                DataTable dts_Cuentas = seleccion.fun_ObtenerCuentas();
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
            try
            {
                DataTable dts_Cuentas = seleccion.fun_ObtenerCuentas();
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
                string sNombreCuenta = seleccion.fun_ObtenerNombreCuenta(iIdCuenta);
                Txt_NombreCuenta_Recibe.Text = sNombreCuenta;
            }
        }

        private void Cbo_NoCuenta_Envia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cbo_NoCuenta_Envia.SelectedValue != null)
            {
                int iIdCuenta = Convert.ToInt32(Cbo_NoCuenta_Envia.SelectedValue);
                string sNombreCuenta = seleccion.fun_ObtenerNombreCuenta(iIdCuenta);
                Txt_NombreCuenta_Envia.Text = sNombreCuenta;
            }
        }

        private void pro_CargarEstadosMovimiento()
        {
            try
            {
                var lst_Estados = seleccion.fun_ObtenerEstadosMovimiento();

                Cbo_Estado.DataSource = null;
                Cbo_Estado.Items.Clear();

                if (lst_Estados == null || lst_Estados.Count == 0)
                {
                    // Cargar estados por defecto
                    Cbo_Estado.Items.AddRange(new[] { "ACTIVO", "ANULADO", "PENDIENTE", "TRASLADADO" });
                }
                else
                {
                    // Usar los estados de la base de datos
                    foreach (var estado in lst_Estados)
                    {
                        Cbo_Estado.Items.Add(estado);
                    }
                }
                Cbo_Estado.DropDownStyle = ComboBoxStyle.DropDownList;
                Cbo_Estado.SelectedIndex = -1; // Sin selección por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estados: {ex.Message}");
                Cbo_Estado.Items.AddRange(new[] { "ACTIVO", "ANULADO", "PENDIENTE", "TRASLADADO" });
                Cbo_Estado.SelectedIndex = -1;
            }
        }

        private void pro_CargarOperaciones()
        {
            try
            {
                DataTable dts_Operaciones = seleccion.fun_ObtenerOperaciones();
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

        private void pro_CargarMonedas()
        {
            try
            {
                DataTable dts_Monedas = seleccion.fun_ObtenerMonedas();
                Cbo_Moneda.DataSource = null;
                Cbo_Moneda.Items.Clear();

                if (dts_Monedas == null || dts_Monedas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay monedas disponibles en la base de datos.");
                    Cbo_Moneda.Enabled = false;
                    return;
                }
                Cbo_Moneda.DataSource = dts_Monedas;
                Cbo_Moneda.DisplayMember = "Cmp_NombreMoneda";
                Cbo_Moneda.ValueMember = "Pk_Id_Moneda";
                Cbo_Moneda.SelectedIndex = -1; // Sin selección por defecto
                Cbo_Moneda.DropDownStyle = ComboBoxStyle.DropDownList; // No editable
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las monedas: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string sSigno = seleccion.fun_ObtenerSignoOperacionPorId(iIdOperacion);
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

        private bool bGuardando = false;


        // debe - haber - diferencia 
        private void ActualizarTotalDebe()
        {
            try
            {
                decimal totalDebe = 0;
                int celdasProcesadas = 0;
                // Verificar que el DataGridView tiene columnas
                if (Dgv_Detalle_Movimiento.Columns.Count == 0)
                {
                    Lbl_Debe.Text = "Debe: 0.00";
                    return;
                }
                // Verificar que existe la columna "Debe"
                if (!Dgv_Detalle_Movimiento.Columns.Contains("Debe"))
                {
                    Lbl_Debe.Text = "Debe: Columna no encontrada";
                    return;
                }
                // Recorrer todas las filas del DataGridView
                foreach (DataGridViewRow row in Dgv_Detalle_Movimiento.Rows)
                {
                    // Saltar filas nuevas vacías
                    if (row.IsNewRow) continue;
                    // Obtener el valor de la celda "Debe"
                    object valorCelda = row.Cells["Debe"].Value;

                    if (valorCelda != null && valorCelda != DBNull.Value && !string.IsNullOrEmpty(valorCelda.ToString()))
                    {
                        if (decimal.TryParse(valorCelda.ToString(), out decimal monto))
                        {
                            totalDebe += monto;
                            celdasProcesadas++;
                        }
                    }
                }
                Console.WriteLine($"Total Débito calculado: {totalDebe:N2} - Celdas procesadas: {celdasProcesadas}");

                Lbl_Debe.Text = $"Debe: {totalDebe:N2}";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al calcular total débito: {ex.Message}");
                Lbl_Debe.Text = "Debe: Error";
            }
        }

        private void ActualizarTotalHaber()
        {
            try
            {
                decimal totalHaber = 0;
                int celdasProcesadas = 0;
                // Verificar que el DataGridView tiene columnas
                if (Dgv_Detalle_Movimiento.Columns.Count == 0)
                {
                    Lbl_Haber.Text = "Haber: 0.00";
                    return;
                }
                // Verificar que existe la columna "Haber"
                if (!Dgv_Detalle_Movimiento.Columns.Contains("Haber"))
                {
                    Lbl_Haber.Text = "Haber: Columna no encontrada";
                    return;
                }
                // Recorrer todas las filas del DataGridView
                foreach (DataGridViewRow row in Dgv_Detalle_Movimiento.Rows)
                {
                    // Saltar filas nuevas vacías
                    if (row.IsNewRow) continue;

                    // Obtener el valor de la celda "Haber"
                    object valorCelda = row.Cells["Haber"].Value;

                    if (valorCelda != null && valorCelda != DBNull.Value && !string.IsNullOrEmpty(valorCelda.ToString()))
                    {
                        if (decimal.TryParse(valorCelda.ToString(), out decimal monto))
                        {
                            totalHaber += monto;
                            celdasProcesadas++;
                        }
                    }
                }
                Console.WriteLine($"Total Haber calculado: {totalHaber:N2} - Celdas procesadas: {celdasProcesadas}");
                Lbl_Haber.Text = $"Haber: {totalHaber:N2}";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al calcular total haber: {ex.Message}");
                Lbl_Haber.Text = "Haber: Error";
            }
        }

        private void ActualizarDiferencia()
        {
            try
            {
                decimal totalDebe = 0;
                decimal totalHaber = 0;

                // Calcular ambos totales
                foreach (DataGridViewRow row in Dgv_Detalle_Movimiento.Rows)
                {
                    if (row.IsNewRow) continue;
                    // Débito
                    object valorDebe = row.Cells["Debe"].Value;
                    if (valorDebe != null && valorDebe != DBNull.Value)
                    {
                        if (decimal.TryParse(valorDebe.ToString(), out decimal montoDebe))
                        {
                            totalDebe += montoDebe;
                        }
                    }
                    // Crédito
                    object valorHaber = row.Cells["Haber"].Value;
                    if (valorHaber != null && valorHaber != DBNull.Value)
                    {
                        if (decimal.TryParse(valorHaber.ToString(), out decimal montoHaber))
                        {
                            totalHaber += montoHaber;
                        }
                    }
                }
                // Calcular diferencia
                decimal diferencia = totalDebe - totalHaber;

                // Actualizar label de diferencia
                Lbl_Diferencia.Text = $"Diferencia: {diferencia:N2}";

                //Cambiar color según el resultado
                if (diferencia > 0)
                {
                    Lbl_Diferencia.ForeColor = Color.DarkRed; // Más débito que crédito
                    Lbl_Diferencia.Text = $"Diferencia: +{diferencia:N2}";
                }
                else if (diferencia < 0)
                {
                    Lbl_Diferencia.ForeColor = Color.DarkGreen; // Más crédito que débito
                    Lbl_Diferencia.Text = $"Diferencia: {diferencia:N2}"; // Ya incluye el signo negativo
                }
                else
                {
                    Lbl_Diferencia.ForeColor = Color.Black; // Balanceado
                    Lbl_Diferencia.Text = $"Diferencia: {diferencia:N2}";
                }

                // Asegurar que esté en negrita
                if (Lbl_Diferencia.Font.Style != FontStyle.Bold)
                {
                    Lbl_Diferencia.Font = new Font(Lbl_Diferencia.Font, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al calcular diferencia: {ex.Message}");
                Lbl_Diferencia.Text = "Diferencia: Error";
            }
        }

        private void ActualizarTodosLosTotales()
        {
            try
            {
                decimal totalDebe = 0;
                decimal totalHaber = 0;
                int filasProcesadas = 0;

                // Un solo recorrido para ambos totales - SOLO FILAS ACTIVAS
                foreach (DataGridViewRow row in Dgv_Detalle_Movimiento.Rows)
                {
                    if (row.IsNewRow) continue;
                    //VERIFICAR SI EL MOVIMIENTO ESTÁ ACTIVO
                    string estado = row.Cells["Estado_Movimiento"]?.Value?.ToString() ?? "ACTIVO";
                    if (estado == "ANULADO")
                    {
                        // Si está anulado, no sumar a los totales
                        continue;
                    }
                    // Débito
                    object valorDebe = row.Cells["Debe"].Value;
                    if (valorDebe != null && valorDebe != DBNull.Value)
                    {
                        if (decimal.TryParse(valorDebe.ToString(), out decimal montoDebe))
                        {
                            totalDebe += montoDebe;
                        }
                    }
                    // Crédito
                    object valorHaber = row.Cells["Haber"].Value;
                    if (valorHaber != null && valorHaber != DBNull.Value)
                    {
                        if (decimal.TryParse(valorHaber.ToString(), out decimal montoHaber))
                        {
                            totalHaber += montoHaber;
                        }
                    }
                    filasProcesadas++;
                }
                Console.WriteLine($"Totales calculados - Débito: {totalDebe:N2}, Crédito: {totalHaber:N2}, Filas procesadas: {filasProcesadas}");

                // Actualizar labels individuales
                Lbl_Debe.Text = $"Debe: {totalDebe:N2}";
                Lbl_Haber.Text = $"Haber: {totalHaber:N2}";

                // Calcular y mostrar diferencia
                decimal diferencia = totalDebe - totalHaber;

                // Configurar diferencia con colores
                if (diferencia > 0)
                {
                    Lbl_Diferencia.ForeColor = Color.DarkRed;
                    Lbl_Diferencia.Text = $"Diferencia: +{diferencia:N2}";
                }
                else if (diferencia < 0)
                {
                    Lbl_Diferencia.ForeColor = Color.DarkGreen;
                    Lbl_Diferencia.Text = $"Diferencia: {diferencia:N2}";
                }
                else
                {
                    Lbl_Diferencia.ForeColor = Color.Black;
                    Lbl_Diferencia.Text = $"Diferencia: {diferencia:N2}";
                }

                Lbl_Debe.Font = new Font(Lbl_Debe.Font, FontStyle.Bold);
                Lbl_Haber.Font = new Font(Lbl_Haber.Font, FontStyle.Bold);
                Lbl_Diferencia.Font = new Font(Lbl_Diferencia.Font, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al calcular totales: {ex.Message}");
                Lbl_Debe.Text = "Debe: Error";
                Lbl_Haber.Text = "Haber: Error";
                Lbl_Diferencia.Text = "Diferencia: Error";
            }
        }


        ///bOTONES
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Dgv_Detalle_Movimiento.EndEdit();

            // VERIFICAR SI ESTAMOS EN MODO EDICIÓN
            if (bEditando)
            {
                ActualizarMovimiento();
                return;
            }

            // SI NO ESTÁ EDITANDO, ENTONCES CREAR NUEVO MOVIMIENTO
            try
            {
                // Evitar múltiples ejecuciones
                if (bGuardando) return;
                bGuardando = true;

                // VALIDACIONES DEL FORMULARIO
                var validacion = Cls_ValidacionesGuardar.ValidarFormulario(
                    Cbo_NoCuenta_Envia,
                    Cbo_Operacion,
                    Txt_NumeroDocumento.Text,
                    Txt_Concepto.Text,
                    Txt_Monto.Text
                );

                var cv = Cls_ValidacionesGuardar.CamposObligatorios(
                    Cbo_NoCuenta_Envia.SelectedValue, Cbo_Operacion.SelectedValue,
                    Txt_NumeroDocumento.Text, Txt_Concepto.Text);
                if (!cv.ok) { MessageBox.Show(cv.msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                var vm = Cls_ValidacionesGuardar.MontoPositivo(Txt_Monto.Text);
                if (!vm.ok) { MessageBox.Show(vm.msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); Txt_Monto.Focus(); Txt_Monto.SelectAll(); return; }
                decimal deMonto = vm.monto;

                // PREPARAR DATOS DEL MOVIMIENTO
                Cls_Sentencias movimiento = new Cls_Sentencias
                {
                    iFk_Id_cuenta_origen = Convert.ToInt32(Cbo_NoCuenta_Envia.SelectedValue),
                    iFk_Id_operacion = Convert.ToInt32(Cbo_Operacion.SelectedValue),
                    sCmp_numero_documento = Txt_NumeroDocumento.Text.Trim(),
                    dCmp_fecha_movimiento = Dtp_FechaMovimiento.Value,
                    sCmp_concepto = Txt_Concepto.Text.Trim(),
                    deCmp_valor_total = deMonto,   
                    sCmp_beneficiario = Txt_Beneficiario.Text.Trim(),
                    sCmp_usuario_registro = Environment.UserName,
                    sCmp_estado = "ACTIVO",
                    iCmp_conciliado = 0
                };
                // Cuenta destino 
                if (Cbo_NoCuenta_Recibe.Enabled && Cbo_NoCuenta_Recibe.SelectedValue != null)
                {
                    movimiento.iFk_Id_cuenta_destino = Convert.ToInt32(Cbo_NoCuenta_Recibe.SelectedValue);
                }
                // Tipo de pago
                if (Cbo_TipoPago.SelectedValue != null)
                {
                    movimiento.iFk_Id_tipo_pago = Convert.ToInt32(Cbo_TipoPago.SelectedValue);
                }
                List<Cls_Sentencias.Cls_MovimientoDetalle> lst_Detalles = new List<Cls_Sentencias.Cls_MovimientoDetalle>();
                
                // CREAR DETALLE AUTOMÁTICO 
                string sSigno = seleccion.fun_ObtenerSignoOperacionPorId(movimiento.iFk_Id_operacion);
                string sTipoLinea = sSigno == "+" ? "D" : "C";
                string sCuentaContable = seleccion.fun_ObtenerCuentaContablePorDefecto();

                var detalleAutomatico = new Cls_Sentencias.Cls_MovimientoDetalle
                {
                    sFk_Id_cuenta_contable = sCuentaContable,
                    sCmp_tipo_operacion = sTipoLinea,
                    deCmp_valor = movimiento.deCmp_valor_total,
                    sCmp_Descripcion = movimiento.sCmp_concepto,
                    iCmp_Conciliado = 0
                };

                lst_Detalles.Add(detalleAutomatico);
                
                // GUARDAR EN BASE DE DATOS
                Cursor.Current = Cursors.WaitCursor;
                int iIdMovimiento = crud.fun_CrearMovimientoConDetalles(movimiento, lst_Detalles);
                Cursor.Current = Cursors.Default;

                if (iIdMovimiento > 0)
                {
                    MessageBox.Show($"¡Movimiento guardado exitosamente!\nNúmero de movimiento: {iIdMovimiento}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                    // Limpiar formulario después de guardar
                    pro_LimpiarFormulario();
                    
                    // Recargar movimientos para mostrar el nuevo
                    pro_CargarMovimientosCompletos();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el movimiento. Verifique los datos.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;

                MessageBox.Show($"Error al guardar el movimiento:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Console.WriteLine($"ERROR Btn_Guardar: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");

                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
            }
            finally
            {
                bGuardando = false;
            }
        }

        // =============================================
        // MÉTODO AUXILIAR PARA LIMPIAR FORMULARIO
        // =============================================
        private void pro_LimpiarFormulario()
        {
            try
            {
                // Salir del modo edición si estamos editando
                if (bEditando)
                {
                    bEditando = false;
                    Btn_Guardar.Text = "Guardar";
                }

                // Limpiar combos
                Cbo_NoCuenta_Envia.SelectedIndex = -1;
                Cbo_Operacion.SelectedIndex = -1;
                Cbo_NoCuenta_Recibe.SelectedIndex = -1;
                Cbo_TipoPago.SelectedIndex = -1;
                Cbo_Signo.SelectedIndex = -1;
                Cbo_Estado.SelectedIndex = -1;
                Cbo_Moneda.SelectedIndex = -1; 
               
                // Limpiar textos
                Txt_NombreCuenta_Envia.Clear();
                Txt_NombreCuenta_Recibe.Clear();
                Txt_NumeroDocumento.Clear();
                Txt_Concepto.Clear();
                Txt_Monto.Clear();
                Txt_Beneficiario.Clear();
                
                // Resetear fecha
                Dtp_FechaMovimiento.Value = DateTime.Now;
                
                // Deshabilitar cuenta destino
                Cbo_NoCuenta_Recibe.Enabled = false;
                Txt_NombreCuenta_Recibe.Enabled = false;
                
                // Limpiar grid si está en modo captura
                if (!Dgv_Detalle_Movimiento.ReadOnly)
                {
                    Dgv_Detalle_Movimiento.Rows.Clear();
                    Dgv_Detalle_Movimiento.Rows.Add(); // Agregar fila nueva
                }
                
                // Resetear totales
                ActualizarTodosLosTotales();
                
                // Enfocar primer control
                Cbo_NoCuenta_Envia.Focus();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al limpiar formulario: {ex.Message}");
            }
        }

        // =============================================
        // MÉTODO PARA CARGAR TIPOS DE PAGO
        // =============================================
        private void pro_CargarTiposPago()
        {
            try
            {
                DataTable dts_TiposPago = seleccion.fun_ObtenerTiposPago();
                Cbo_TipoPago.DataSource = null;
                Cbo_TipoPago.Items.Clear();

                if (dts_TiposPago != null && dts_TiposPago.Rows.Count > 0)
                {
                    Cbo_TipoPago.DataSource = dts_TiposPago;
                    Cbo_TipoPago.DisplayMember = "Cmp_nombre";
                    Cbo_TipoPago.ValueMember = "Pk_Id_TipoPago";
                    Cbo_TipoPago.SelectedIndex = -1;
                    Cbo_TipoPago.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tipos de pago: {ex.Message}");
            }
        }

        // =============================================
        // MÉTODOS PARA EDITAR MOVIMIENTOS
        // =============================================
        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_Detalle_Movimiento.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un movimiento para editar.", "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataGridViewRow selectedRow = Dgv_Detalle_Movimiento.SelectedRows[0];

                // Obtener datos de la fila seleccionada
                iMovimientoEditandoId = Convert.ToInt32(selectedRow.Cells["Pk_Id_Movimiento"].Value);
                iCuentaOrigenEditando = Convert.ToInt32(selectedRow.Cells["Fk_Id_CuentaOrigen"].Value);
                iOperacionEditando = Convert.ToInt32(selectedRow.Cells["Fk_Id_Operacion"].Value);
                string sEstado = selectedRow.Cells["Estado_Movimiento"].Value?.ToString();

                // Validar que no esté anulado
                var can = Cls_MovimientoValidaciones.PuedeEditar(sEstado);
                if (!can.ok) { MessageBox.Show(can.msg, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                bEditando = true;

                CargarDatosParaEdicion();

                MessageBox.Show("Modo edición activado. Modifique los datos y haga clic en 'Guardar'.",
                              "Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al preparar edición: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método completo para actualizar movimiento CON ACTUALIZACIÓN DE SALDOS
        private void ActualizarMovimiento()
        {
            try
            {
                // --- VALIDACIONES CENTRALIZADAS ---
                var cv = Capa_Controldor_MB.Cls_ValidacionesEditar.CamposObligatorios(
                    Cbo_NoCuenta_Envia.SelectedValue,
                    Cbo_Operacion.SelectedValue,
                    Txt_NumeroDocumento.Text,
                    Txt_Concepto.Text
                );
                if (!cv.ok)
                {
                    MessageBox.Show(cv.msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var vm = Capa_Controldor_MB.Cls_ValidacionesEditar.MontoPositivo(Txt_Monto.Text);
                if (!vm.ok)
                {
                    MessageBox.Show(vm.msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txt_Monto.Focus(); Txt_Monto.SelectAll();
                    return;
                }
                decimal deMonto = vm.monto;

                int? iTipoPago = Capa_Controldor_MB.Cls_ValidacionesEditar.IntNullable(Cbo_TipoPago.SelectedValue);
                int? iCuentaDestino = Capa_Controldor_MB.Cls_ValidacionesEditar.CuentaDestinoNullable(
                    Cbo_NoCuenta_Recibe.Enabled, Cbo_NoCuenta_Recibe.SelectedValue
                );

                string sEstado = Capa_Controldor_MB.Cls_ValidacionesEditar.EstadoSeleccionado(Cbo_Estado.SelectedItem);

                // EXTRACCIÓN DE CLAVES
                int iNuevaCuentaOrigen = Convert.ToInt32(Cbo_NoCuenta_Envia.SelectedValue);
                int iNuevaOperacion = Convert.ToInt32(Cbo_Operacion.SelectedValue);

                // cuenta/origen u operación
                bool bCambioClave = Capa_Controldor_MB.Cls_ValidacionesEditar.CambioClave(
                    iNuevaCuentaOrigen, iCuentaOrigenEditando,
                    iNuevaOperacion, iOperacionEditando
                );

                if (bCambioClave)
                {
                    // Confirmación UI
                    DialogResult respuesta = MessageBox.Show(
                        "Al cambiar la Cuenta Origen o el Tipo de Operación se creará un nuevo movimiento y se anulará el anterior.\n\n¿Desea continuar?",
                        "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    );

                    if (respuesta != DialogResult.Yes)
                    {
                        // Restaurar valores originales en los combos
                        Cbo_NoCuenta_Envia.SelectedValue = iCuentaOrigenEditando;
                        Cbo_Operacion.SelectedValue = iOperacionEditando;
                        return;
                    }

                    // Anular el movimiento anterior
                    Cursor.Current = Cursors.WaitCursor;
                    bool anulacionExitosa = crud.fun_AnularMovimiento(
                        iMovimientoEditandoId, iCuentaOrigenEditando, iOperacionEditando, Environment.UserName
                    );
                    Cursor.Current = Cursors.Default;

                    if (!anulacionExitosa)
                    {
                        MessageBox.Show("No se pudo anular el movimiento anterior. La operación fue cancelada.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Crear el nuevo movimiento con los datos actualizados
                    var movimiento = new Cls_Sentencias
                    {
                        iFk_Id_cuenta_origen = iNuevaCuentaOrigen,
                        iFk_Id_operacion = iNuevaOperacion,
                        sCmp_numero_documento = Txt_NumeroDocumento.Text.Trim(),
                        dCmp_fecha_movimiento = Dtp_FechaMovimiento.Value,
                        sCmp_concepto = Txt_Concepto.Text.Trim(),
                        deCmp_valor_total = deMonto,
                        sCmp_beneficiario = Txt_Beneficiario.Text.Trim(),
                        sCmp_usuario_registro = Environment.UserName,
                        sCmp_estado = sEstado,
                        iCmp_conciliado = 0,
                        iFk_Id_cuenta_destino = iCuentaDestino,
                        iFk_Id_tipo_pago = iTipoPago
                    };

                    // Detalle contable automático
                    string sSigno = seleccion.fun_ObtenerSignoOperacionPorId(movimiento.iFk_Id_operacion);
                    string sTipoLinea = sSigno == "+" ? "D" : "C";
                    string sCuentaContable = seleccion.fun_ObtenerCuentaContablePorDefecto();

                    var lst_Detalles = new List<Cls_Sentencias.Cls_MovimientoDetalle>
            {
                new Cls_Sentencias.Cls_MovimientoDetalle
                {
                    sFk_Id_cuenta_contable = sCuentaContable,
                    sCmp_tipo_operacion    = sTipoLinea,
                    deCmp_valor            = movimiento.deCmp_valor_total,
                    sCmp_Descripcion       = movimiento.sCmp_concepto,
                    iCmp_Conciliado        = 0
                }
            };

                    Cursor.Current = Cursors.WaitCursor;
                    int iIdMovimientoNuevo = crud.fun_CrearMovimientoConDetalles(movimiento, lst_Detalles);
                    Cursor.Current = Cursors.Default;

                    if (iIdMovimientoNuevo > 0)
                    {
                        MessageBox.Show($"¡Movimiento actualizado correctamente! Se creó el nuevo movimiento #{iIdMovimientoNuevo} y se anuló el anterior #{iMovimientoEditandoId}.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        bEditando = false;
                        pro_LimpiarFormulario();
                        pro_CargarMovimientosCompletos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear el nuevo movimiento. El movimiento anterior fue anulado.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Actualización normal
                    Cursor.Current = Cursors.WaitCursor;
                    bool exito = crud.fun_ActualizarMovimiento(
                        iMovimientoEditandoId,
                        iNuevaCuentaOrigen,
                        iNuevaOperacion,
                        Txt_NumeroDocumento.Text.Trim(),
                        Dtp_FechaMovimiento.Value,
                        Txt_Beneficiario.Text.Trim(),
                        deMonto,
                        iTipoPago,
                        iCuentaDestino,
                        Txt_Concepto.Text.Trim(),
                        Environment.UserName,
                        iCuentaOrigenEditando,
                        iOperacionEditando,
                        sEstado
                    );
                    Cursor.Current = Cursors.Default;

                    if (exito)
                    {
                        MessageBox.Show("Movimiento actualizado correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        bEditando = false;
                        pro_LimpiarFormulario();
                        pro_CargarMovimientosCompletos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el movimiento.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show($"Error al actualizar movimiento: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Console.WriteLine($"ERROR ActualizarMovimiento: {ex.Message}");
                if (ex.InnerException != null)
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
            }
        }

        private void CargarDatosParaEdicion()
        {
            try
            {
                // Obtener datos crudos
                DataTable dtMovimiento = seleccion.fun_ObtenerMovimientoPorId(
                    iMovimientoEditandoId, iCuentaOrigenEditando, iOperacionEditando);
                
                // Validar + mapear a DTO
                var val = new Capa_Controldor_MB.Cls_EditarValidaciones();
                var res = val.MapearMovimiento(
                    dtMovimiento,
                    seleccion.fun_ObtenerMonedaPorCuenta,        
                    seleccion.fun_ObtenerSignoOperacionPorId   
                );

                if (!res.Exito)
                {
                    MessageBox.Show(res.Mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var d = res.Data;

                // ---- PINTAR CONTROLES  ----
                Cbo_NoCuenta_Envia.SelectedValue = d.FkCuentaOrigen;
                Cbo_Operacion.SelectedValue = d.FkOperacion;
                Txt_NumeroDocumento.Text = d.NumeroDocumento ?? string.Empty;
                Dtp_FechaMovimiento.Value = d.Fecha;
                Txt_Concepto.Text = d.Concepto ?? string.Empty;
                Txt_Monto.Text = d.MontoTotal.ToString("N2");
                Txt_Beneficiario.Text = d.Beneficiario ?? string.Empty;
                
                // Estado
                if (!string.IsNullOrWhiteSpace(d.Estado))
                    Cbo_Estado.SelectedItem = d.Estado;
                
                // Signo 
                if (d.Signo == "+" || d.Signo == "-")
                    Cbo_Signo.SelectedItem = d.Signo;
                
                // Tipo de pago
                if (d.TipoPagoId.HasValue)
                    Cbo_TipoPago.SelectedValue = d.TipoPagoId.Value;
                else
                    Cbo_TipoPago.SelectedIndex = -1;
                
                // Moneda
                if (d.MonedaId.HasValue)
                    Cbo_Moneda.SelectedValue = d.MonedaId.Value;
                else
                    Cbo_Moneda.SelectedIndex = -1;
                
                // Cuenta destino + nombre
                if (d.CuentaDestinoId.HasValue)
                {
                    Cbo_NoCuenta_Recibe.SelectedValue = d.CuentaDestinoId.Value;
                    Cbo_NoCuenta_Recibe.Enabled = true;
                    Txt_NombreCuenta_Recibe.Enabled = true;

                    var nombreDestino = seleccion.fun_ObtenerNombreCuenta(d.CuentaDestinoId.Value);
                    Txt_NombreCuenta_Recibe.Text = nombreDestino;
                }
                else
                {
                    Cbo_NoCuenta_Recibe.SelectedIndex = -1;
                    Txt_NombreCuenta_Recibe.Clear();
                    Cbo_NoCuenta_Recibe.Enabled = false;
                    Txt_NombreCuenta_Recibe.Enabled = false;
                }
                
                // Nombre cuenta origen
                if (Cbo_NoCuenta_Envia.SelectedValue != null)
                {
                    int idOri = Convert.ToInt32(Cbo_NoCuenta_Envia.SelectedValue);
                    Txt_NombreCuenta_Envia.Text = seleccion.fun_ObtenerNombreCuenta(idOri);
                }

                // Habilitar/deshabilitar cuenta recibe según nombre de operación en el combo
                if (Cbo_Operacion.SelectedValue != null)
                {
                    var drv = Cbo_Operacion.SelectedItem as DataRowView;
                    string nomOp = drv?["Cmp_nombre"]?.ToString().Trim() ?? string.Empty;

                    bool habilitarRecibe =
                        nomOp.Equals("TRANSFERENCIA_ENVIADA", StringComparison.OrdinalIgnoreCase) ||
                        nomOp.Equals("TRANSFERENCIA RECIBIDA", StringComparison.OrdinalIgnoreCase) ||
                        nomOp.Equals("TRANSFERENCIA_RECIBIDA", StringComparison.OrdinalIgnoreCase);

                    Cbo_NoCuenta_Recibe.Enabled = habilitarRecibe;
                    Txt_NombreCuenta_Recibe.Enabled = habilitarRecibe;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar datos para edición: {ex.Message}");
            }
        }


        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (bEditando)
            {
                DialogResult result = MessageBox.Show(
                    "¿Está seguro de cancelar la edición? Los cambios no guardados se perderán.",
                    "Cancelar Edición",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    pro_LimpiarFormulario();
                    MessageBox.Show("Edición cancelada.", "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                pro_LimpiarFormulario();
            }
        }

        private void Btn_Anular_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar selección
                if (!Cls_ValidacionesAnular.ValidarSeleccionMovimiento(Dgv_Detalle_Movimiento.SelectedRows.Count))
                {
                    MessageBox.Show("Seleccione un movimiento para anular.", "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataGridViewRow selectedRow = Dgv_Detalle_Movimiento.SelectedRows[0];
                
                // Extraer valores de las celdas
                var cellIdMovimiento = selectedRow.Cells["Pk_Id_Movimiento"].Value;
                var cellIdCuentaOrigen = selectedRow.Cells["Fk_Id_CuentaOrigen"].Value;
                var cellIdOperacion = selectedRow.Cells["Fk_Id_Operacion"].Value;
                var cellEstado = selectedRow.Cells["Estado_Movimiento"].Value;
                var cellConciliado = selectedRow.Cells["Cmp_Conciliado"].Value;

                // Validar anulación
                var validacion = Cls_ValidacionesAnular.ValidarAnulacion(
                    cellIdMovimiento,
                    cellIdCuentaOrigen,
                    cellIdOperacion,
                    cellEstado,
                    cellConciliado
                );

                if (!validacion.esValido)
                {
                    MessageBox.Show(validacion.mensaje, validacion.mensaje.Contains("anulado") ? "Advertencia" : "Error",
                                  MessageBoxButtons.OK,
                                  validacion.mensaje.Contains("anulado") ? MessageBoxIcon.Warning : MessageBoxIcon.Error);
                    return;
                }
                
                // Obtener datos para el diagnóstico y la anulación
                int iIdMovimiento = Convert.ToInt32(cellIdMovimiento);
                int iIdCuentaOrigen = Convert.ToInt32(cellIdCuentaOrigen);
                int iIdOperacion = Convert.ToInt32(cellIdOperacion);

                // Mostrar información para diagnóstico
                Cls_ValidacionesAnular.MostrarInformacionDiagnostico(
                    iIdMovimiento,
                    iIdCuentaOrigen,
                    iIdOperacion,
                    cellEstado?.ToString()
                );
                
                // Confirmar anulación
                DialogResult result = MessageBox.Show(
                    Cls_ValidacionesAnular.ObtenerMensajeConfirmacion(iIdMovimiento),
                    "Confirmar Anulación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    bool exito = crud.fun_AnularMovimiento(iIdMovimiento, iIdCuentaOrigen, iIdOperacion, Environment.UserName);

                    Cursor.Current = Cursors.Default;

                    if (exito)
                    {
                        MessageBox.Show("Movimiento anulado correctamente.", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Aplicar estilo de anulado en la vista
                        selectedRow.Cells["Estado_Movimiento"].Value = "ANULADO";
                        selectedRow.Cells["Estado_Visible"].Value = "ANULADO";
                        selectedRow.Cells["Estado_Visible"].Style.BackColor = Color.LightCoral;
                        selectedRow.Cells["Estado_Visible"].Style.ForeColor = Color.DarkRed;

                        ActualizarTodosLosTotales();
                        pro_CargarMovimientosCompletos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo anular el movimiento.", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show($"Error al anular movimiento: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
