using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Check_In_Check_Out;
using Capa_Controlador_Seguridad;
using Capa_Modelo_GesHab;
namespace Capa_vista_Check_In_Check_out
{
    public partial class Frm_Check_In : Form
    {
        private readonly Cls_Check_In_Controlador Controlador = new Cls_Check_In_Controlador();
        Cls_BitacoraControlador ctrlBitacora = new Cls_BitacoraControlador();
        Cls_Dao_Estadia Estadia = new Cls_Dao_Estadia();
        private int idHabitacionSeleccionada = 0;
        private bool _canIngresar, _canConsultar, _canModificar, _canEliminar, _canImprimir;

        public Frm_Check_In()
        {
            InitializeComponent();
            fun_CargarCombos();
            fun_CargarEstados();
            fun_CargarTabla();
           
            fun_AplicarPermisos();
            fun_configuracion_inicial();
        }
        private void fun_AplicarPermisos()
        {
            int idUsuario = Cls_Usuario_Conectado.iIdUsuario;
            var usuarioCtrl = new Cls_Usuario_Controlador();
            var permisoUsuario = new Cls_Permiso_Usuario_Controlador();

            // Módulo y aplicación específicos
            int idAplicacion = permisoUsuario.ObtenerIdAplicacionPorNombre("Check In");
            if (idAplicacion <= 0) idAplicacion = 3402; // ID por defecto para Check In
            int idModulo = permisoUsuario.ObtenerIdModuloPorNombre("Hoteleria");
            int idPerfil = usuarioCtrl.ObtenerIdPerfilDeUsuario(idUsuario);

            var permisos = Cls_Aplicacion_Permisos.ObtenerPermisosCombinados(
                idUsuario, idAplicacion, idModulo, idPerfil);


           
            if (!permisos.ingresar && !permisos.consultar &&
                !permisos.modificar && !permisos.eliminar &&
                !permisos.imprimir)
            {
                MessageBox.Show("El usuario no tiene permisos asignados para esta aplicación.",
                                "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _canIngresar = permisos.ingresar;
            _canConsultar = permisos.consultar;
            _canModificar = permisos.modificar;
            _canEliminar = permisos.eliminar;
            _canImprimir = permisos.imprimir;


            // Asignar permisos
            _canIngresar = permisos.ingresar;
            _canConsultar = permisos.consultar;
            _canModificar = permisos.modificar;
            _canEliminar = permisos.eliminar;
            _canImprimir = permisos.imprimir;

            // Asignar permisos a controles
            if (Btn_Nuevo != null) Btn_Nuevo.Enabled = _canIngresar;
            if (Btn_Guardar != null) Btn_Guardar.Enabled = _canIngresar;
            if (Btn_Modificar != null) Btn_Modificar.Enabled = _canModificar;
            if (Btn_Reporte != null) Btn_Reporte.Enabled = _canImprimir;

            // DataGridView y combos visibles si puede consultar
            Dgv_Check_In.Enabled = _canConsultar;
            Cbo_Huesped.Enabled = _canConsultar || _canIngresar || _canModificar;
            Cbo_Reservas.Enabled = _canConsultar || _canIngresar || _canModificar;

            // Campos de texto / fecha
            bool puedeEditar = (_canIngresar || _canModificar);
            Txt_Id_Check_In.Enabled = false;
            Dtp_Fecha.Enabled = puedeEditar;
            Cbo_Estado.Enabled = puedeEditar;
        }
        public void fun_configuracion_inicial()
        {
            Btn_Guardar.Enabled = false;
            Btn_Modificar.Enabled = false;
            Btn_Nuevo.Enabled = _canIngresar;
            Btn_Reporte.Enabled = _canImprimir;
            Txt_Id_Check_In.Enabled = false;
            Cbo_Huesped.Enabled = false;
            Cbo_Estado.Enabled = false;
            Cbo_Huesped.Enabled = false;
            Dtp_Fecha.Enabled = false;
            Dgv_Check_In.Enabled = _canConsultar;
            Cbo_Reservas.Enabled = false;

        }

        private void fun_CargarCombos()
        {
            try
            {
                // ComboBox de Huéspedes
                Cbo_Huesped.DataSource = Controlador.fun_Obtener_Huespedes();
                Cbo_Huesped.DisplayMember = "NombreCompleto";
                Cbo_Huesped.ValueMember = "Pk_Id_Huesped";
                Cbo_Huesped.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combos: " + ex.Message);
            }
        }

        private void fun_CargarEstados()
        {
            Cbo_Estado.Items.Clear();
            Cbo_Estado.Items.Add("Activo");
            Cbo_Estado.Items.Add("Finalizado");
            Cbo_Estado.Items.Add("Cancelado");
            Cbo_Estado.SelectedIndex = 0;
        }

        private void fun_CargarTabla()
        {
            try
            {
                Dgv_Check_In.DataSource = Controlador.fun_Mostrar_CheckIn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tabla: " + ex.Message);
            }
        }

        private void fun_LimpiarCampos()
        {
            Txt_Id_Check_In.Clear();
            Cbo_Huesped.SelectedIndex = -1;
            Cbo_Reservas.SelectedIndex = -1;
            Cbo_Estado.SelectedIndex = 0;
            Dtp_Fecha.Value = DateTime.Now;
        }

        private void Cbo_Huesped_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Huesped.SelectedValue == null || Cbo_Huesped.SelectedValue is DataRowView)
                return;

            try
            {
                Cbo_Reservas.DataSource = null;
                Cbo_Reservas.Items.Clear();
                Cbo_Reservas.Text = string.Empty;

                int idHuesped = Convert.ToInt32(Cbo_Huesped.SelectedValue);

                DataTable dtReservas = Controlador.fun_Obtener_Reserva_Por_Huesped(idHuesped);

                Cbo_Reservas.DataSource = dtReservas;
                Cbo_Reservas.DisplayMember = "DescripcionReserva";
                Cbo_Reservas.ValueMember = "Pk_Id_Reserva";
                Cbo_Reservas.SelectedIndex = dtReservas.Rows.Count > 0 ? 0 : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reservas del huésped: " + ex.Message);
            }
        }

        private void Dgv_Check_In_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            Btn_Guardar.Enabled = false;
            Btn_Modificar.Enabled = _canModificar;
            Btn_Nuevo.Enabled = _canIngresar;
            Cbo_Huesped.Enabled = true;
            Cbo_Estado.Enabled = true;
            Cbo_Huesped.Enabled = true;
            Dtp_Fecha.Enabled = true;
            Cbo_Reservas.Enabled = true; 


            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow fila = Dgv_Check_In.Rows[e.RowIndex];
                    Txt_Id_Check_In.Text = fila.Cells["Pk_Id_Check_in"].Value.ToString();

                    // Cargar huésped
                    if (fila.Cells["Fk_Id_Huesped"].Value != null)
                        Cbo_Huesped.SelectedValue = Convert.ToInt32(fila.Cells["Fk_Id_Huesped"].Value);

                    // Cargar reservas (incluyendo la finalizada actual)
                    if (fila.Cells["Fk_Id_Reserva"].Value != null)
                    {
                        int iIdHuesped = Convert.ToInt32(fila.Cells["Fk_Id_Huesped"].Value);
                        int iIdReservaActual = Convert.ToInt32(fila.Cells["Fk_Id_Reserva"].Value);

                        DataTable dtReservas = Controlador.fun_Obtener_Reserva_Por_Huesped_Edicion(iIdHuesped, iIdReservaActual);
                        Cbo_Reservas.DataSource = dtReservas;
                        Cbo_Reservas.DisplayMember = "DescripcionReserva";
                        Cbo_Reservas.ValueMember = "Pk_Id_Reserva";
                        Cbo_Reservas.SelectedValue = iIdReservaActual;
                    }

                    Dtp_Fecha.Value = Convert.ToDateTime(fila.Cells["Cmp_Fecha_Check_In"].Value);
                    Cbo_Estado.SelectedItem = fila.Cells["Cmp_Estado"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos desde la tabla: " + ex.Message);
                }
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Huesped.SelectedIndex == -1 || Cbo_Reservas.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un huésped y una reserva válida.",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idHuesped = Convert.ToInt32(Cbo_Huesped.SelectedValue);
                int idReserva = Convert.ToInt32(Cbo_Reservas.SelectedValue);
                DateTime fecha = Dtp_Fecha.Value;
                string estado = Cbo_Estado.SelectedItem.ToString();

                int idHabitacion = Controlador.fun_Obtener_Habitacion_Por_Reserva(idReserva);
                int num_huespedes = Controlador.fun_ObtenerNumHuespedesPorReserva(idReserva);

                if (idHabitacionSeleccionada == 0)
                {
                    MessageBox.Show("No se encontró una habitación asociada a esta reserva.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Usa el método estandarizado del controlador
                bool exito = Controlador.pro_Registrar_CheckIn_Con_Folio(
                    idHuesped,
                    idReserva,
                    fecha,
                    estado,
                    idHabitacionSeleccionada
                );

                if (exito)
                {
                    Estadia.pro_InsertarEstadia(idHabitacion,idHuesped,num_huespedes,true,fecha,fecha,0); ;
                    ctrlBitacora.RegistrarAccion(Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario, 3402, $"Check In Guardado ", true);
                    fun_CargarTabla();
                    fun_LimpiarCampos();
                    idHabitacionSeleccionada = 0;
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al registrar el Check-In con Folio.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            Cbo_Huesped.Enabled = true;
            Cbo_Estado.Enabled = true;
            Cbo_Huesped.Enabled = true;
            Dtp_Fecha.Enabled = true;
            Cbo_Reservas.Enabled = true;
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_Id_Check_In.Text))
                {
                    MessageBox.Show("Seleccione un registro para modificar.");
                    return;
                }

                int idCheckIn = Convert.ToInt32(Txt_Id_Check_In.Text);
                int idHuesped = Convert.ToInt32(Cbo_Huesped.SelectedValue);
                int idReserva = Convert.ToInt32(Cbo_Reservas.SelectedValue);
                DateTime fecha = Dtp_Fecha.Value;
                string estado = Cbo_Estado.SelectedItem.ToString();

                // Actualiza usando el método estandarizado
                if (Controlador.bActualizar_CheckIn(idCheckIn, idHuesped, idReserva, fecha, estado, out string mensaje))
                {
                    MessageBox.Show("Check-In modificado correctamente.");
                    fun_CargarTabla();
                    fun_LimpiarCampos();
                    ctrlBitacora.RegistrarAccion(Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario, 3402, $"Check In Modificado ", true);
                    fun_configuracion_inicial();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            if (!_canIngresar)
            {
                MessageBox.Show("No tiene permiso para crear nuevos Check-In.");
                return;
            }
            Cbo_Huesped.Enabled = true;
            Cbo_Estado.Enabled = true;
            Cbo_Huesped.Enabled = true ;
            Dtp_Fecha.Enabled = true;
            fun_LimpiarCampos();
            Btn_Guardar.Enabled = _canIngresar;
            Btn_Modificar.Enabled = false;
            Cbo_Reservas.Enabled = true;
        }

    

    private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            fun_LimpiarCampos();
            fun_configuracion_inicial();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cbo_Reservas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Reservas.SelectedValue == null || Cbo_Reservas.SelectedValue is DataRowView)
                return;

            try
            {
                int idReserva = Convert.ToInt32(Cbo_Reservas.SelectedValue);

                // Usa el método actualizado del controlador
                idHabitacionSeleccionada = Controlador.fun_Obtener_Habitacion_Por_Reserva(idReserva);

                if (idHabitacionSeleccionada > 0)
                {
                    Console.WriteLine($"Habitación vinculada a la reserva: {idHabitacionSeleccionada}");
                }
                else
                {
                    MessageBox.Show("Esta reserva no tiene una habitación asignada.",
                                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la habitación: " + ex.Message);
            }
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            if (!_canImprimir)
            {
                MessageBox.Show("No tiene permiso para generar reportes.");
                return;
            }

            Frm_Reporte_Check_In Reporte = new Frm_Reporte_Check_In();
            Reporte.Show();
        }
    }
}
