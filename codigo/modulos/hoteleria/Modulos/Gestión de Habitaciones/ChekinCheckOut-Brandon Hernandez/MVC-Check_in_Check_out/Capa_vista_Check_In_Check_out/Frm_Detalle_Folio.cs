using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Check_In_Check_Out;
using Capa_Controlador_Seguridad;

namespace Capa_vista_Check_In_Check_out
{
    public partial class Frm_Detalle_Folio : Form
    {
        private readonly Cls_Detalle_Folio_Controlador Controlador = new Cls_Detalle_Folio_Controlador();
        private bool _canConsultar, _canImprimir;

        public Frm_Detalle_Folio()
        {
            InitializeComponent();
            fun_AplicarPermisos();
            fun_CargarFolios();
            fun_ConfigInicial();
        }

        private void fun_CargarFolios()
        {
            try
            {
                DataTable dt = Controlador.datObtenerFolios();
                Cbo_Folios.DataSource = dt;
                Cbo_Folios.DisplayMember = "DescripcionFolio";
                Cbo_Folios.ValueMember = "Pk_Id_Folio";
                Cbo_Folios.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar folios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fun_AplicarPermisos()
        {
            try
            {
                int idUsuario = Cls_Usuario_Conectado.iIdUsuario;
                var usuarioCtrl = new Cls_Usuario_Controlador();
                var permisoUsuario = new Cls_Permiso_Usuario_Controlador();

                // Identificación de módulo y aplicación
                int idAplicacion = permisoUsuario.ObtenerIdAplicacionPorNombre("Detalle Folio");
                if (idAplicacion <= 0) idAplicacion = 3405; // ID estándar para Detalle Folio
                int idModulo = permisoUsuario.ObtenerIdModuloPorNombre("Hoteleria");
                int idPerfil = usuarioCtrl.ObtenerIdPerfilDeUsuario(idUsuario);

                var permisos = Cls_Aplicacion_Permisos.ObtenerPermisosCombinados(
                    idUsuario, idAplicacion, idModulo, idPerfil);

                // Validación: si el usuario no tiene acceso
                if (!permisos.consultar && !permisos.imprimir)
                {
                    MessageBox.Show("El usuario no tiene permisos para consultar ni imprimir en esta aplicación.",
                                    "Permisos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Asignar permisos
                _canConsultar = permisos.consultar;
                _canImprimir = permisos.imprimir;

                // Aplicar a controles
               
                if (Btn_Reporte != null) Btn_Reporte.Enabled = _canImprimir;
                if (Cbo_Folios != null) Cbo_Folios.Enabled = _canConsultar;
                Dgv_Movimientos.Enabled = _canConsultar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar permisos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fun_ConfigInicial()
        {
            Txt_Nombre.Enabled = false;
            Txt_Numero_Habitaciones.Enabled = false;
            Txt_Numero_Documentos.Enabled = false;
            Txt_Fecha_Creacion.Enabled = false;
            Txt_Estado.Enabled = false;
            Txt_Total.Enabled = false;
            Cbo_Folios.Enabled = _canConsultar;
            Dgv_Movimientos.ReadOnly = true;
            Dgv_Movimientos.AllowUserToAddRows = false;
            Dgv_Movimientos.AllowUserToDeleteRows = false;
        }
        private void Cbo_Folios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Folios.SelectedValue == null || Cbo_Folios.SelectedIndex == -1)
                return;

            int idFolio;
            if (int.TryParse(Cbo_Folios.SelectedValue.ToString(), out idFolio))
            {
                fun_CargarDatosCliente(idFolio);
                fun_CargarMovimientos(idFolio);
                fun_CargarTotales(idFolio);
            }
        }
        private void fun_CargarDatosCliente(int idFolio)
        {
            try
            {
                DataTable dt = Controlador.datObtenerDatosCliente(idFolio);

                if (dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];
                    Txt_Nombre.Text = row["NombreCompleto"].ToString();
                    Txt_Numero_Habitaciones.Text = row["NumeroHabitacion"].ToString();
                    Txt_Numero_Documentos.Text = row["NumeroDocumento"].ToString();

                    if (DateTime.TryParse(row["FechaCreacion"].ToString(), out DateTime fecha))
                        Txt_Fecha_Creacion.Text = fecha.ToString("yyyy-MM-dd");
                    else
                        Txt_Fecha_Creacion.Text = "";

                    Txt_Estado.Text = row["Cmp_Estado"].ToString();
                }
                else
                {
                    Txt_Nombre.Clear();
                    Txt_Numero_Habitaciones.Clear();
                    Txt_Numero_Documentos.Clear();
                    Txt_Fecha_Creacion.Clear();
                    Txt_Estado.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del huésped: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fun_CargarMovimientos(int idFolio)
        {
            try
            {
                DataTable dt = Controlador.datObtenerMovimientos(idFolio);
                Dgv_Movimientos.DataSource = dt;

                if (Dgv_Movimientos.Columns.Contains("Monto"))
                    Dgv_Movimientos.Columns["Monto"].DefaultCellStyle.Format = "N2";

                Dgv_Movimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar movimientos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fun_CargarTotales(int idFolio)
        {
            try
            {
                DataTable dt = Controlador.datObtenerTotales(idFolio);
                if (dt.Rows.Count > 0)
                {
                    decimal cargos = Convert.ToDecimal(dt.Rows[0]["TotalCargos"]);
                    decimal abonos = Convert.ToDecimal(dt.Rows[0]["TotalAbonos"]);
                    decimal saldo = Convert.ToDecimal(dt.Rows[0]["Saldo"]);

                    Txt_Total.Text = saldo.ToString("F2");
                }
                else
                {
                    Txt_Total.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular totales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (Cbo_Folios.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un folio primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idFolio = Convert.ToInt32(Cbo_Folios.SelectedValue);
            fun_CargarDatosCliente(idFolio);
            fun_CargarMovimientos(idFolio);
            fun_CargarTotales(idFolio);
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            if (!_canImprimir)
            {
                MessageBox.Show("No tiene permiso para generar reportes.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Frm_Reporte_Folio Reporte = new Frm_Reporte_Folio();
            Reporte.Show();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

