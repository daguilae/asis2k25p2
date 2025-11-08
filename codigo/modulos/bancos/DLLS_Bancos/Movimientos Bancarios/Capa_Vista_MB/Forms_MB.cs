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
        Cls_Conexion oCn = new Cls_Conexion();
        Cls_CRUD oCrud = new Cls_CRUD();
        Cls_Seleccion oSeleccion = new Cls_Seleccion();
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
            pro_cargar_cuentas_recibe();
            pro_cargar_cuentas_envia();
            pro_cargar_operaciones();
            pro_configurar_combo_conciliado();
            pro_cargar_estados_movimiento();
            pro_cargar_movimientos_completos();
            pro_cargar_monedas();

            pro_cargar_tipos_pago();

            Cbo_NoCuenta_Recibe.Enabled = false;
            Txt_NombreCuenta_Recibe.Enabled = false;
        }

        //genera el datagrie
        private void pro_cargar_movimientos_completos()
        {
            try
            {
                pro_configurar_grid_para_visualizacion();
                var dt = oCrud.fun_obtener_movimientos_por_filtro();
                Dgv_Detalle_Movimiento.Rows.Clear();

                // Validar DataTable usando la clase de validaciones
                var validacionDataTable = Cls_MovimientoValidaciones.ValidarDataTableMovimientos(dt);

                if (validacionDataTable.tieneDatos)
                {
                    // Validar columnas obligatorias
                    var columnasRequeridas = new[] {
                "Pk_Id_Movimiento", "Fk_Id_CuentaOrigen", "Fk_Id_Operacion",
                "Cmp_Estado", "Cmp_NombreBanco", "Cmp_NumeroCuenta",
                "Cmp_NombreTransaccion", "Cmp_MontoTotal"
            };

                    var validacionColumnas = Cls_MovimientoValidaciones.ValidarColumnasObligatorias(dt, columnasRequeridas);

                    if (!validacionColumnas.todasExisten)
                    {
                        MessageBox.Show($"Faltan columnas en los datos: {string.Join(", ", validacionColumnas.columnasFaltantes)}",
                                      "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        int index = Dgv_Detalle_Movimiento.Rows.Add();

                        // Asignar valores básicos con validación
                        if (Cls_MovimientoValidaciones.ValidarExistenciaColumna(dt, "Pk_Id_Movimiento"))
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Pk_Id_Movimiento"].Value = row["Pk_Id_Movimiento"];

                        if (Cls_MovimientoValidaciones.ValidarExistenciaColumna(dt, "Fk_Id_CuentaOrigen"))
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Fk_Id_CuentaOrigen"].Value = row["Fk_Id_CuentaOrigen"];

                        if (Cls_MovimientoValidaciones.ValidarExistenciaColumna(dt, "Fk_Id_Operacion"))
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Fk_Id_Operacion"].Value = row["Fk_Id_Operacion"];

                        // Estado y estilos
                        if (Cls_MovimientoValidaciones.ValidarExistenciaColumna(dt, "Cmp_Estado"))
                        {
                            string estado = row["Cmp_Estado"]?.ToString() ?? "";
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Estado_Movimiento"].Value = estado;
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Estado_Visible"].Value = estado;

                            // Aplicar estilos según estado
                            var estilos = Cls_MovimientoValidaciones.ObtenerEstilosPorEstado(estado);
                            if (estilos.colorFondo != null)
                            {
                                Dgv_Detalle_Movimiento.Rows[index].Cells["Estado_Visible"].Style.BackColor =
                                    Color.FromName(estilos.colorFondo);
                                Dgv_Detalle_Movimiento.Rows[index].Cells["Estado_Visible"].Style.ForeColor =
                                    Color.FromName(estilos.colorTexto);
                            }
                        }

                        // Conciliado
                        if (Cls_MovimientoValidaciones.ValidarExistenciaColumna(dt, "Cmp_Conciliado"))
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Cmp_Conciliado"].Value = row["Cmp_Conciliado"];

                        // Información de cuenta
                        if (Cls_MovimientoValidaciones.ValidarExistenciaColumna(dt, "Cmp_NombreBanco"))
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Nombre_Cuenta"].Value = row["Cmp_NombreBanco"];

                        if (Cls_MovimientoValidaciones.ValidarExistenciaColumna(dt, "Cmp_NumeroCuenta"))
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Codigo_Cuenta"].Value = row["Cmp_NumeroCuenta"];

                        if (Cls_MovimientoValidaciones.ValidarExistenciaColumna(dt, "Cmp_NombreTransaccion"))
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Tipo_Operacion"].Value = row["Cmp_NombreTransaccion"];

                        // Débito y Haber
                        if (Cls_MovimientoValidaciones.ValidarExistenciaColumna(dt, "Cmp_MontoTotal") &&
                            Cls_MovimientoValidaciones.ValidarExistenciaColumna(dt, "Cmp_NombreTransaccion"))
                        {
                            var validacionMonto = Cls_MovimientoValidaciones.ValidarMontoMovimiento(row["Cmp_MontoTotal"]);
                            if (validacionMonto.esValido)
                            {
                                decimal monto = validacionMonto.monto;
                                string tipoTransaccion = row["Cmp_NombreTransaccion"]?.ToString() ?? "";

                                var operacion = Cls_MovimientoValidaciones.DeterminarTipoOperacionYMonto(tipoTransaccion, monto);
                                Dgv_Detalle_Movimiento.Rows[index].Cells["Debe"].Value = operacion.debe;
                                Dgv_Detalle_Movimiento.Rows[index].Cells["Haber"].Value = operacion.haber;
                            }
                        }

                        // Concepto
                        if (Cls_MovimientoValidaciones.ValidarExistenciaColumna(dt, "Cmp_Concepto"))
                        {
                            string concepto = Cls_MovimientoValidaciones.ObtenerConceptoPorDefecto(row["Cmp_Concepto"]);
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Cmp_Concepto"].Value = concepto;
                        }

                        // Documento
                        if (Cls_MovimientoValidaciones.ValidarExistenciaColumna(dt, "Cmp_NumeroDocumento"))
                            Dgv_Detalle_Movimiento.Rows[index].Cells["Cmp_Num_Documento"].Value = row["Cmp_NumeroDocumento"];
                    }

                    // Configurar modo del grid
                    var modoGrid = Cls_MovimientoValidaciones.DeterminarModoGrid(true);
                    Dgv_Detalle_Movimiento.ReadOnly = modoGrid.modoLectura;
                    Dgv_Detalle_Movimiento.AllowUserToAddRows = modoGrid.permitirAgregarFilas;

                    pro_actualizar_todos_los_totales();
                }
                else
                {
                    // Modo sin datos - preparar para captura
                    var modoGrid = Cls_MovimientoValidaciones.DeterminarModoGrid(false);
                    Dgv_Detalle_Movimiento.ReadOnly = modoGrid.modoLectura;
                    Dgv_Detalle_Movimiento.AllowUserToAddRows = modoGrid.permitirAgregarFilas;
                    Dgv_Detalle_Movimiento.Rows.Add();

                    pro_actualizar_todos_los_totales();
                    MessageBox.Show("No hay movimientos existentes. Listo para capturar nuevos movimientos.", "Información");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar movimientos: {ex.Message}");
            }
        }
        private void pro_configurar_grid_para_visualizacion()
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

        private void pro_configurar_combo_conciliado()
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

        private void pro_cargar_cuentas_recibe()
        {
            try
            {
                DataTable dts_Cuentas = oSeleccion.fun_obtener_cuentas();
                if (dts_Cuentas.Rows.Count > 0)
                {
                    // Validar configuración del combo
                    var validacionConfig = Cls_ValidacionesCombos.ValidarConfiguracionCombo(
                        dts_Cuentas, "Cmp_Numero_Cuenta", "Pk_Id_Cuenta");

                    if (validacionConfig.configuracionCorrecta)
                    {
                        // Configurar combo manualmente (sin pasar el control a la clase de validaciones)
                        Cbo_NoCuenta_Recibe.DataSource = dts_Cuentas;
                        Cbo_NoCuenta_Recibe.DisplayMember = "Cmp_Numero_Cuenta";
                        Cbo_NoCuenta_Recibe.ValueMember = "Pk_Id_Cuenta";
                        Cbo_NoCuenta_Recibe.SelectedIndex = -1;
                        Cbo_NoCuenta_Recibe.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    else
                    {
                        MessageBox.Show(validacionConfig.mensaje, "Error de Configuración",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(validacion.mensaje, "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string mensajeError = Cls_ValidacionesCombos.ObtenerMensajeErrorCarga("las cuentas", ex);
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pro_cargar_cuentas_envia()
        {
            try
            {
                DataTable dts_Cuentas = oSeleccion.fun_obtener_cuentas();
                if (dts_Cuentas.Rows.Count > 0)
                {
                    var validacionConfig = Cls_ValidacionesCombos.ValidarConfiguracionCombo(
                        dts_Cuentas, "Cmp_Numero_Cuenta", "Pk_Id_Cuenta");

                    if (validacionConfig.configuracionCorrecta)
                    {
                        // Configurar combo manualmente
                        Cbo_NoCuenta_Envia.DataSource = dts_Cuentas;
                        Cbo_NoCuenta_Envia.DisplayMember = "Cmp_Numero_Cuenta";
                        Cbo_NoCuenta_Envia.ValueMember = "Pk_Id_Cuenta";
                        Cbo_NoCuenta_Envia.SelectedIndex = -1;
                        Cbo_NoCuenta_Envia.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    else
                    {
                        MessageBox.Show(validacionConfig.mensaje, "Error de Configuración",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(validacion.mensaje, "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string mensajeError = Cls_ValidacionesCombos.ObtenerMensajeErrorCarga("las cuentas", ex);
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cbo_NoCuenta_Recibe_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cbo_NoCuenta_Recibe.SelectedValue != null)
            {
                int iIdCuenta = Convert.ToInt32(Cbo_NoCuenta_Recibe.SelectedValue);
                string sNombreCuenta = oSeleccion.fun_obtener_nombre_cuenta(iIdCuenta);
                Txt_NombreCuenta_Recibe.Text = sNombreCuenta;
            }
        }

        private void Cbo_NoCuenta_Envia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cbo_NoCuenta_Envia.SelectedValue != null)
            {
                int iIdCuenta = Convert.ToInt32(Cbo_NoCuenta_Envia.SelectedValue);
                string sNombreCuenta = oSeleccion.fun_obtener_nombre_cuenta(iIdCuenta);
                Txt_NombreCuenta_Envia.Text = sNombreCuenta;
            }
        }

        private void pro_cargar_estados_movimiento()
        {
            try
            {
                var lst_Estados = oSeleccion.fun_obtener_estados_movimiento();

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

        private void pro_cargar_operaciones()
        {
            try
            {
                DataTable dts_Operaciones = oSeleccion.fun_obtener_operaciones();
                Cbo_Operacion.DataSource = null;
                Cbo_Operacion.Items.Clear();

                var validacion = Cls_ValidacionesCombos.ValidarDataTableCombo(dts_Operaciones, "operaciones");

                if (validacion.tieneDatos)
                {
                    var validacionConfig = Cls_ValidacionesCombos.ValidarConfiguracionCombo(
                        dts_Operaciones, "Cmp_nombre", "Pk_Id_operacion");

                    if (validacionConfig.configuracionCorrecta)
                    {
                        // Configurar combo manualmente
                        Cbo_Operacion.DataSource = dts_Operaciones;
                        Cbo_Operacion.DisplayMember = "Cmp_nombre";
                        Cbo_Operacion.ValueMember = "Pk_Id_operacion";
                        Cbo_Operacion.SelectedIndex = -1;
                        Cbo_Operacion.DropDownStyle = ComboBoxStyle.DropDownList;
                        Cbo_Operacion.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show(validacionConfig.mensaje, "Error de Configuración",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cbo_Operacion.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show(validacion.mensaje, "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cbo_Operacion.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                string mensajeError = Cls_ValidacionesCombos.ObtenerMensajeErrorCarga("operaciones", ex);
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cbo_Operacion.DataSource = null;
                Cbo_Operacion.Items.Clear();
                Cbo_Operacion.Enabled = false;
            }
        }

        private void pro_cargar_monedas()
        {
            try
            {
                DataTable dts_Monedas = oSeleccion.fun_obtener_monedas();
                Cbo_Moneda.DataSource = null;
                Cbo_Moneda.Items.Clear();

                var validacion = Cls_ValidacionesCombos.ValidarDataTableCombo(dts_Monedas, "monedas");

                if (validacion.tieneDatos)
                {
                    var validacionConfig = Cls_ValidacionesCombos.ValidarConfiguracionCombo(
                        dts_Monedas, "Cmp_NombreMoneda", "Pk_Id_Moneda");

                    if (validacionConfig.configuracionCorrecta)
                    {
                        // Configurar combo manualmente
                        Cbo_Moneda.DataSource = dts_Monedas;
                        Cbo_Moneda.DisplayMember = "Cmp_NombreMoneda";
                        Cbo_Moneda.ValueMember = "Pk_Id_Moneda";
                        Cbo_Moneda.SelectedIndex = -1;
                        Cbo_Moneda.DropDownStyle = ComboBoxStyle.DropDownList;
                        Cbo_Moneda.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show(validacionConfig.mensaje, "Error de Configuración",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cbo_Moneda.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show(validacion.mensaje, "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cbo_Moneda.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                string mensajeError = Cls_ValidacionesCombos.ObtenerMensajeErrorCarga("las monedas", ex);
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cbo_Moneda.Enabled = false;
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
            string sSigno = oSeleccion.fun_obtener_signo_operacion_por_id(iIdOperacion);
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


        // ====================================================================================
        // ======================= DEBE Y HABER ===============================================
        // ====================================================================================

        // debe - haber - diferencia 
        private void pro_actualizar_total_debe()
        {
            try
            {
                decimal deTotalDebe = 0;
                int iCeldasProcesadas = 0;
                // Verificar que el DataGridView tiene columnas
                if (Dgv_Detalle_Movimiento.Columns.Count == 0)
                {
                    Lbl_Debe.Text = "Debe: 0.00";
                    return;
                }
                // Verificar que existe la columna "Debe"
                if (!Dgv_Detalle_Movimiento.Columns.Contains("Debe"))
                {
                    Lbl_Debe.Text = validacionGrid.mensaje.Contains("Debe") ?
                                   "Debe: Columna no encontrada" : "Debe: 0.00";
                    return;
                }

                decimal totalDebe = 0;
                int celdasProcesadas = 0;

                // Recorrer todas las filas del DataGridView
                foreach (DataGridViewRow row in Dgv_Detalle_Movimiento.Rows)
                {
                    // Validar fila
                    if (!Cls_ValidacionesTotales.EsFilaValidaParaCalculo(row.IsNewRow))
                        continue;

                    // Obtener y validar valor de la celda "Debe"
                    object valorCelda = row.Cells["Debe"].Value;
                    var validacionValor = Cls_ValidacionesTotales.ObtenerValorDecimalDeCelda(valorCelda);

                    if (validacionValor.esValido)
                    {
                        if (decimal.TryParse(valorCelda.ToString(), out decimal deMonto))
                        {
                            deTotalDebe += deMonto;
                            iCeldasProcesadas++;
                        }
                    }
                }
                Console.WriteLine($"Total Débito calculado: {deTotalDebe:N2} - Celdas procesadas: {iCeldasProcesadas}");

                Lbl_Debe.Text = $"Debe: {deTotalDebe:N2}";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al calcular total débito: {ex.Message}");
                Lbl_Debe.Text = "Debe: Error";
            }
        }

        private void pro_actualizar_total_haber()
        {
            try
            {
                decimal deTotalHaber = 0;
                int iCeldasProcesadas = 0;
                // Verificar que el DataGridView tiene columnas
                if (Dgv_Detalle_Movimiento.Columns.Count == 0)
                {
                    Lbl_Haber.Text = "Haber: 0.00";
                    return;
                }
                // Verificar que existe la columna "Haber"
                if (!Dgv_Detalle_Movimiento.Columns.Contains("Haber"))
                {
                    Lbl_Haber.Text = validacionGrid.mensaje.Contains("Haber") ?
                                    "Haber: Columna no encontrada" : "Haber: 0.00";
                    return;
                }

                decimal totalHaber = 0;
                int celdasProcesadas = 0;

                // Recorrer todas las filas del DataGridView
                foreach (DataGridViewRow row in Dgv_Detalle_Movimiento.Rows)
                {
                    // Validar fila
                    if (!Cls_ValidacionesTotales.EsFilaValidaParaCalculo(row.IsNewRow))
                        continue;

                    // Obtener y validar valor de la celda "Haber"
                    object valorCelda = row.Cells["Haber"].Value;
                    var validacionValor = Cls_ValidacionesTotales.ObtenerValorDecimalDeCelda(valorCelda);

                    if (validacionValor.esValido)
                    {
                        if (decimal.TryParse(valorCelda.ToString(), out decimal deMonto))
                        {
                            deTotalHaber += deMonto;
                            iCeldasProcesadas++;
                        }
                    }
                }
                Console.WriteLine($"Total Haber calculado: {deTotalHaber:N2} - Celdas procesadas: {iCeldasProcesadas}");
                Lbl_Haber.Text = $"Haber: {deTotalHaber:N2}";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al calcular total haber: {ex.Message}");
                Lbl_Haber.Text = "Haber: Error";
            }
        }

        private void pro_actualizar_diferencia()
        {
            try
            {
                decimal deTotalDebe = 0;
                decimal deTotalHaber = 0;

                // Calcular ambos totales
                foreach (DataGridViewRow row in Dgv_Detalle_Movimiento.Rows)
                {
                    if (!Cls_ValidacionesTotales.EsFilaValidaParaCalculo(row.IsNewRow))
                        continue;

                    // Débito
                    object valorDebe = row.Cells["Debe"].Value;
                    if (valorDebe != null && valorDebe != DBNull.Value)
                    {
                        if (decimal.TryParse(valorDebe.ToString(), out decimal deMontoDebe))
                        {
                            deTotalDebe += deMontoDebe;
                        }
                    }
                    // Crédito
                    object valorHaber = row.Cells["Haber"].Value;
                    if (valorHaber != null && valorHaber != DBNull.Value)
                    {
                        if (decimal.TryParse(valorHaber.ToString(), out decimal deMontoHaber))
                        {
                            deTotalHaber += deMontoHaber;
                        }
                    }
                }
                // Calcular diferencia
                decimal deDiferencia = deTotalDebe - deTotalHaber;

                // Actualizar label de diferencia
                Lbl_Diferencia.Text = $"Diferencia: {deDiferencia:N2}";

                //Cambiar color según el resultado
                if (deDiferencia > 0)
                {
                    Lbl_Diferencia.ForeColor = Color.DarkRed; // Más débito que crédito
                    Lbl_Diferencia.Text = $"Diferencia: +{deDiferencia:N2}";
                }
                else if (deDiferencia < 0)
                {
                    Lbl_Diferencia.ForeColor = Color.DarkGreen; // Más crédito que débito
                    Lbl_Diferencia.Text = $"Diferencia: {deDiferencia:N2}"; // Ya incluye el signo negativo
                }
                else
                {
                    Lbl_Diferencia.ForeColor = Color.Black; // Balanceado
                    Lbl_Diferencia.Text = $"Diferencia: {deDiferencia:N2}";
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

        private void pro_actualizar_todos_los_totales()
        {
            try
            {
                decimal deTotalDebe = 0;
                decimal deTotalHaber = 0;
                int iFilasProcesadas = 0;

                // Un solo recorrido para ambos totales - SOLO FILAS ACTIVAS
                foreach (DataGridViewRow row in Dgv_Detalle_Movimiento.Rows)
                {
                    if (!Cls_ValidacionesTotales.EsFilaValidaParaCalculo(row.IsNewRow))
                        continue;

                    // Obtener estado del movimiento
                    string estado = row.Cells["Estado_Movimiento"]?.Value?.ToString() ?? "ACTIVO";

                    // Débito
                    object valorDebe = row.Cells["Debe"].Value;
                    if (valorDebe != null && valorDebe != DBNull.Value)
                    {
                        if (decimal.TryParse(valorDebe.ToString(), out decimal deMontoDebe))
                        {
                            deTotalDebe += deMontoDebe;
                        }
                    }
                    // Crédito
                    object valorHaber = row.Cells["Haber"].Value;
                    if (valorHaber != null && valorHaber != DBNull.Value)
                    {
                        if (decimal.TryParse(valorHaber.ToString(), out decimal deMontoHaber))
                        {
                            deTotalHaber += deMontoHaber;
                        }
                    }
                    iFilasProcesadas++;
                }
                Console.WriteLine($"Totales calculados - Débito: {deTotalDebe:N2}, Crédito: {deTotalHaber:N2}, Filas procesadas: {iFilasProcesadas}");

                // Actualizar labels individuales
                Lbl_Debe.Text = $"Debe: {deTotalDebe:N2}";
                Lbl_Haber.Text = $"Haber: {deTotalHaber:N2}";

                // Calcular y mostrar diferencia
                decimal deDiferencia = deTotalDebe - deTotalHaber;

                // Configurar diferencia con colores
                if (deDiferencia > 0)
                {
                    Lbl_Diferencia.ForeColor = Color.DarkRed;
                    Lbl_Diferencia.Text = $"Diferencia: +{deDiferencia:N2}";
                }
                else if (deDiferencia < 0)
                {
                    Lbl_Diferencia.ForeColor = Color.DarkGreen;
                    Lbl_Diferencia.Text = $"Diferencia: {deDiferencia:N2}";
                }
                else
                {
                    Lbl_Diferencia.ForeColor = Color.Black;
                    Lbl_Diferencia.Text = $"Diferencia: {deDiferencia:N2}";
                }

                // Aplicar estilos en negrita
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


        // =============================================
        // GUARDAR
        // =============================================
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Dgv_Detalle_Movimiento.EndEdit();
            // VERIFICAR SI ESTAMOS EN MODO EDICIÓN
            if (bEditando)
            {
                pro_actualizar_movimiento();
                return;
            }
            // SI NO ESTÁ EDITANDO, ENTONCES CREAR NUEVO MOVIMIENTO
            try
            {
                // Evitar múltiples ejecuciones
                if (bGuardando) return;
                bGuardando = true;
                // VALIDACIONES DEL FORMULARIO
                var validacion = Cls_ValidacionesGuardar.fun_validar_formulario(
                    Cbo_NoCuenta_Envia,
                    Cbo_Operacion,
                    Txt_NumeroDocumento.Text,
                    Txt_Concepto.Text,
                    Txt_Monto.Text
                );

                var cv = Cls_ValidacionesGuardar.fun_campos_obligatorios(
                    Cbo_NoCuenta_Envia.SelectedValue, Cbo_Operacion.SelectedValue,
                    Txt_NumeroDocumento.Text, Txt_Concepto.Text);
                if (!cv.ok) { MessageBox.Show(cv.msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                var vm = Cls_ValidacionesGuardar.fun_monto_positivo(Txt_Monto.Text);
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
                string sSigno = oSeleccion.fun_obtener_signo_operacion_por_id(movimiento.iFk_Id_operacion);
                string sTipoLinea = sSigno == "+" ? "D" : "C";
                string sCuentaContable = oSeleccion.fun_obtener_cuenta_contable_por_defecto();

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
                int iIdMovimiento = oCrud.fun_crear_movimiento_con_detalles(movimiento, lst_Detalles);
                Cursor.Current = Cursors.Default;

                if (iIdMovimiento > 0)
                {
                    MessageBox.Show($"¡Movimiento guardado exitosamente!\nNúmero de movimiento: {iIdMovimiento}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar formulario después de guardar
                    pro_limpiar_formulario();

                    // Recargar movimientos para mostrar el nuevo
                    pro_cargar_movimientos_completos();
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
        // LIMPIAR FORMULARIO
        // =============================================
        private void pro_limpiar_formulario()
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
                pro_actualizar_todos_los_totales();

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
        private void pro_cargar_tipos_pago()
        {
            try
            {
                DataTable dts_TiposPago = oSeleccion.fun_obtener_tipos_pago();
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
                var can = Cls_MovimientoValidaciones.fun_puede_editar(sEstado);
                if (!can.ok) { MessageBox.Show(can.msg, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                bEditando = true;

                pro_cargar_datos_para_edicion();

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
        private void pro_actualizar_movimiento()
        {
            try
            {
                // --- VALIDACIONES CENTRALIZADAS ---
                var cv = Capa_Controldor_MB.Cls_ValidacionesEditar.fun_campos_obligatorios(
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

                var vm = Capa_Controldor_MB.Cls_ValidacionesEditar.fun_monto_positivo(Txt_Monto.Text);
                if (!vm.ok)
                {
                    MessageBox.Show(vm.msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txt_Monto.Focus(); Txt_Monto.SelectAll();
                    return;
                }
                decimal deMonto = vm.monto;

                int? iTipoPago = Capa_Controldor_MB.Cls_ValidacionesEditar.fun_int_nullable(Cbo_TipoPago.SelectedValue);
                int? iCuentaDestino = Capa_Controldor_MB.Cls_ValidacionesEditar.fun_cuenta_destino_nullable(
                    Cbo_NoCuenta_Recibe.Enabled, Cbo_NoCuenta_Recibe.SelectedValue
                );

                string sEstado = Capa_Controldor_MB.Cls_ValidacionesEditar.fun_estado_seleccionado(Cbo_Estado.SelectedItem);

                // EXTRACCIÓN DE CLAVES
                int iNuevaCuentaOrigen = Convert.ToInt32(Cbo_NoCuenta_Envia.SelectedValue);
                int iNuevaOperacion = Convert.ToInt32(Cbo_Operacion.SelectedValue);

                // cuenta/origen u operación
                bool bCambioClave = Capa_Controldor_MB.Cls_ValidacionesEditar.fun_cambio_clave(
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
                    bool anulacionExitosa = oCrud.fun_anular_movimiento(
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
                    string sSigno = oSeleccion.fun_obtener_signo_operacion_por_id(movimiento.iFk_Id_operacion);
                    string sTipoLinea = sSigno == "+" ? "D" : "C";
                    string sCuentaContable = oSeleccion.fun_obtener_cuenta_contable_por_defecto();

                    var lst_Detalles = new List<Cls_Sentencias.Cls_MovimientoDetalle> {
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
                    int iIdMovimientoNuevo = oCrud.fun_crear_movimiento_con_detalles(movimiento, lst_Detalles);
                    Cursor.Current = Cursors.Default;

                    if (iIdMovimientoNuevo > 0)
                    {
                        MessageBox.Show($"¡Movimiento actualizado correctamente! Se creó el nuevo movimiento #{iIdMovimientoNuevo} y se anuló el anterior #{iMovimientoEditandoId}.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        bEditando = false;
                        pro_limpiar_formulario();
                        pro_cargar_movimientos_completos();
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
                    bool exito = oCrud.fun_actualizar_movimiento(
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
                        pro_limpiar_formulario();
                        pro_cargar_movimientos_completos();
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

                Console.WriteLine($"ERROR pro_actualizar_movimiento: {ex.Message}");
                if (ex.InnerException != null)
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
            }
        }

        private void pro_cargar_datos_para_edicion()
        {
            try
            {
                // Obtener datos crudos
                DataTable dtMovimiento = oSeleccion.fun_obtener_movimiento_por_id(
                    iMovimientoEditandoId, iCuentaOrigenEditando, iOperacionEditando);

                // Validar + mapear a DTO
                var val = new Capa_Controldor_MB.Cls_EditarValidaciones();
                var res = val.MapearMovimiento(
                    dtMovimiento,
                    oSeleccion.fun_obtener_moneda_por_cuenta,
                    oSeleccion.fun_obtener_signo_operacion_por_id
                );

                if (!resultado.Exito)
                {
                    MessageBox.Show(resultado.Mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var d = resultado.Data;

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

                    var nombreDestino = oSeleccion.fun_obtener_nombre_cuenta(d.CuentaDestinoId.Value);
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
                    Txt_NombreCuenta_Envia.Text = oSeleccion.fun_obtener_nombre_cuenta(idOri);
                }

         void CargarControlesConDatos(Cls_ValidacionesCargarEdicion.MovimientoEdicionDTO )
        {
            // ---- PINTAR CONTROLES ----
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

                    bool bHabilitarRecibe =
                        nomOp.Equals("TRANSFERENCIA_ENVIADA", StringComparison.OrdinalIgnoreCase) ||
                        nomOp.Equals("TRANSFERENCIA RECIBIDA", StringComparison.OrdinalIgnoreCase) ||
                        nomOp.Equals("TRANSFERENCIA_RECIBIDA", StringComparison.OrdinalIgnoreCase);

                    Cbo_NoCuenta_Recibe.Enabled = bHabilitarRecibe;
                    Txt_NombreCuenta_Recibe.Enabled = bHabilitarRecibe;
                }
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
                    pro_limpiar_formulario();
                    MessageBox.Show("Edición cancelada.", "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                pro_limpiar_formulario();
            }
        }

        private void Btn_Anular_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar selección
                if (!Cls_ValidacionesAnular.fun_validar_seleccion_movimiento(Dgv_Detalle_Movimiento.SelectedRows.Count))
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
                var validacion = Cls_ValidacionesAnular.fun_validar_anulacion(
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
                Cls_ValidacionesAnular.pro_mostrar_informacion_diagnostico(
                    iIdMovimiento,
                    iIdCuentaOrigen,
                    iIdOperacion,
                    cellEstado?.ToString()
                );

                // Confirmar anulación
                DialogResult result = MessageBox.Show(
                    Cls_ValidacionesAnular.fun_obtener_mensaje_confirmacion(iIdMovimiento),
                    "Confirmar Anulación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    bool exito = oCrud.fun_anular_movimiento(iIdMovimiento, iIdCuentaOrigen, iIdOperacion, Environment.UserName);

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

                        pro_actualizar_todos_los_totales();
                        pro_cargar_movimientos_completos();
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
