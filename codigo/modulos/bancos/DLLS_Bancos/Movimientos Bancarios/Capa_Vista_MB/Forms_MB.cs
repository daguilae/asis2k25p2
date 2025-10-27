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
        Controlador controlador = new Controlador();

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

            Cbo_Signo.Enabled = false;
            Cbo_Signo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Forms_MB_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Font = new Font("Rockwell", 11, FontStyle.Regular);
            CargarDetalleMovimientos();
            CargarCuentasRecibe();
            CargarCuentasEnvia();
            CargarOperaciones();
            PrepararGridDetalleParaCaptura();

            Cbo_NoCuenta_Recibe.Enabled = false;
            Txt_NombreCuenta_Recibe.Enabled = false;
        }


        private void PrepararGridDetalleParaCaptura()
        {
            var g = Dgv_Detalle_Movimiento;
            g.AutoGenerateColumns = false;
            g.Columns.Clear();

            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fk_Id_tipo_pago",
                HeaderText = "Tipo de Pago (ID)"
            });

            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cmp_Num_Documento",
                HeaderText = "Número Documento"
            });

            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cmp_Monto",
                HeaderText = "Monto"
            });

            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cmp_Descripcion",
                HeaderText = "Descripción"
            });

            g.AllowUserToAddRows = true;
            g.AllowUserToDeleteRows = true;
        }


        private void CargarDetalleMovimientos()
        {
            try
            {
                // Llamar directamente al método del modelo
                var crud = new Capa_Modelo_MB.Sentencias();
                OdbcDataAdapter da = crud.llenarTbl("Tbl_Movimientos_Bancarios");

                DataTable dt = new DataTable();
                da.Fill(dt);

                // Mostrar los datos en el DataGridView
                Dgv_Detalle_Movimiento.AutoGenerateColumns = true;
                Dgv_Detalle_Movimiento.DataSource = dt;

                // Encabezados legibles
                if (Dgv_Detalle_Movimiento.Columns.Contains("Pk_Id_movimiento"))
                    Dgv_Detalle_Movimiento.Columns["Pk_Id_movimiento"].HeaderText = "ID Movimiento";
                
                if (Dgv_Detalle_Movimiento.Columns.Contains("Fk_Id_cuenta_origen"))
                    Dgv_Detalle_Movimiento.Columns["Fk_Id_cuenta_origen"].HeaderText = "Cuenta Origen";

                if (Dgv_Detalle_Movimiento.Columns.Contains("Fk_Id_cuenta_destino"))
                    Dgv_Detalle_Movimiento.Columns["Fk_Id_cuenta_destino"].HeaderText = "Cuenta Destino";

                if (Dgv_Detalle_Movimiento.Columns.Contains("Fk_Id_operacion"))
                    Dgv_Detalle_Movimiento.Columns["Fk_Id_operacion"].HeaderText = "Operación";

                if (Dgv_Detalle_Movimiento.Columns.Contains("Fk_Id_concepto"))
                    Dgv_Detalle_Movimiento.Columns["Fk_Id_concepto"].HeaderText = "Concepto";

                if (Dgv_Detalle_Movimiento.Columns.Contains("Cmp_fecha_movimiento"))
                    Dgv_Detalle_Movimiento.Columns["Cmp_fecha_movimiento"].HeaderText = "Fecha";

                if (Dgv_Detalle_Movimiento.Columns.Contains("Cmp_valor_total"))
                    Dgv_Detalle_Movimiento.Columns["Cmp_valor_total"].HeaderText = "Monto Total";

                if (Dgv_Detalle_Movimiento.Columns.Contains("Cmp_observaciones"))
                    Dgv_Detalle_Movimiento.Columns["Cmp_observaciones"].HeaderText = "Observaciones";

                if (Dgv_Detalle_Movimiento.Columns.Contains("Cmp_conciliado"))
                    Dgv_Detalle_Movimiento.Columns["Cmp_conciliado"].HeaderText = "Conciliado";

                if (Dgv_Detalle_Movimiento.Columns.Contains("Cmp_estado"))
                    Dgv_Detalle_Movimiento.Columns["Cmp_estado"].HeaderText = "Estado";

                // Ajustes visuales
                Dgv_Detalle_Movimiento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                Dgv_Detalle_Movimiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Dgv_Detalle_Movimiento.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void CargarOperaciones()
        {
            try
            {
                var dt = crud.ObtenerOperaciones();
                Cbo_Operacion.DataSource = dt;
                Cbo_Operacion.DisplayMember = "Cmp_nombre";
                Cbo_Operacion.ValueMember = "Pk_Id_operacion";
                Cbo_Operacion.SelectedIndex = -1; // empieza vacío
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar operaciones: " + ex.Message);
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
                Cbo_Signo.Enabled = true;
                Cbo_Signo.SelectedItem = signo;
            }
            else
            {
                Cbo_Signo.SelectedIndex = -1;
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
            // Protección contra doble clic
            if (guardando) return;

            try
            {
                guardando = true;
                Btn_Guardar.Enabled = false; // Deshabilitar botón durante el proceso

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
                    Cmp_conciliado = 0,
                    Cmp_estado = "Activo"
                };

                // ========== CREAR DETALLES ==========
                var detalles = new List<Sentencias.MovimientoDetalle>();
                var controlador = new Controlador();

                // Agregar el detalle principal desde Txt_Monto
                var detallePrincipal = controlador.CrearDetallePrincipal(
                    montoPrincipal,
                    Txt_NumeroDocumento.Text,
                    Txt_Concepto.Text
                );
                detalles.Add(detallePrincipal);

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

                // ========== LIMPIAR FORMULARIO DE FORMA SEGURA ==========
                LimpiarFormularioSeguro();

                // ========== RECARGAR DATOS ==========
                CargarDetalleMovimientos();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}");
            }
            finally
            {
                guardando = false;
                Btn_Guardar.Enabled = true; // Rehabilitar botón
            }
        }

        // Método alternativo para limpiar de forma segura
        private void LimpiarFormularioSeguro()
        {
            try
            {
                // Usar Invoke para evitar problemas de hilos
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(LimpiarFormularioSeguro));
                    return;
                }

                // Limpiar controles básicos
                Txt_NumeroDocumento.Text = "";
                Txt_Monto.Text = "";
                Txt_Concepto.Text = "";
                Txt_NombreCuenta_Envia.Text = "";
                Txt_NombreCuenta_Recibe.Text = "";

                // Resetear combos
                Cbo_NoCuenta_Envia.SelectedIndex = -1;
                Cbo_NoCuenta_Recibe.SelectedIndex = -1;
                Cbo_Operacion.SelectedIndex = -1;
                Cbo_Signo.SelectedIndex = -1;

                // Limpiar DataGridView de forma más segura
                LimpiarDataGridViewSeguro();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en limpieza segura: {ex.Message}");
            }
        }

        private void LimpiarDataGridViewSeguro()
        {
            try
            {
                // Método 1: Usar DataSource (si estás usando binding)
                if (Dgv_Detalle_Movimiento.DataSource != null)
                {
                    Dgv_Detalle_Movimiento.DataSource = null;
                }
                else
                {
                    // Método 2: Limpiar filas manualmente
                    Dgv_Detalle_Movimiento.Rows.Clear();
                }

                // Forzar refresco
                Dgv_Detalle_Movimiento.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error limpiando DataGridView: {ex.Message}");
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

                // Limpiar DataGridView de forma segura
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

                    // Método alternativo: Limpiar datos sin remover estructura
                    // Dgv_Detalle_Movimiento.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al limpiar formulario: {ex.Message}");
            }
        }


    }
}

