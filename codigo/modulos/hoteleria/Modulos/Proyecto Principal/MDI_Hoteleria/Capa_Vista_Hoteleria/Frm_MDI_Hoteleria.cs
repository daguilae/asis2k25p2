using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_vista_Check_In_Check_out;
using Capa_Vista_Seguridad;
using Capa_Vista_Contabilidad;
using Capa_Vista_Gestion_Habitacion;
using Capa_Vista_Reservas_Hotel;
using Capa_Vista_S;
using Capa_Vista_IE;
using Capa_Vista_MH;
using CapaVistaOP;
using CapaVistaProduccion;

namespace Capa_Vista_Hoteleria
{
    public partial class Frm_MDI_Hoteleria : Form
    {
        private int iIChildFormNumber = 0;

        public Frm_MDI_Hoteleria()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // <- activa MDI container
            this.Load += Frm_MDI_Hoteleria_Load;
        }

        private void Frm_MDI_Hoteleria_Load(object sender, EventArgs e)
        {
            // Mostrar usuario conectado en StatusStrip si existe el control
            try
            {
                toolStripStatusLabel.Text = $"Estado: Conectado | Usuario: {Capa_Controlador_Seguridad.Cls_Usuario_Conectado.sNombreUsuario}";
            }
            catch
            {
                // Si no existe toolStripStatusLabel en este formulario, ignorar.
            }
        }

        // --- Control de formularios hijos MDI ---
        private void CerrarFormulariosHijos()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + iIChildFormNumber++;
            childForm.Show();
        }

        // --- Handlers adaptados para abrir formularios como hijos MDI ---
        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mantengo el comportamiento original: ocultar MDI y abrir Frm_Seguridad como diálogo modal
            this.Hide();
            Frm_Seguridad seguridad = new Frm_Seguridad();
            seguridad.ShowDialog();
            this.Show();
        }

        private void polizaContableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Frm_Poliza_Turismo poliza = new Frm_Poliza_Turismo();
            poliza.MdiParent = this;
            poliza.Show();
        }

        private void mantenimientoHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Frm_Mantenimiento_Habitaciones habitaciones = new Frm_Mantenimiento_Habitaciones();
            habitaciones.MdiParent = this;
            habitaciones.Show();
        }

        private void tipoHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Frm_Mantenimiento_Tipo_Habitaciones Tipo_Habitaciones = new Frm_Mantenimiento_Tipo_Habitaciones();
            Tipo_Habitaciones.MdiParent = this;
            Tipo_Habitaciones.Show();
        }

        private void serviciosCuartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Frm_Servicios_Cuartos Servicio_Cuartos = new Frm_Servicios_Cuartos();
            Servicio_Cuartos.MdiParent = this;
            Servicio_Cuartos.Show();
        }

        private void huespedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Frm_Huespedes huespedes = new Frm_Huespedes();
            huespedes.MdiParent = this;
            huespedes.Show();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Frm_Reservas Reserva = new Frm_Reservas();
            Reserva.MdiParent = this;
            Reserva.Show();
        }

        private void checkInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Frm_Check_In check_In = new Frm_Check_In();
            check_In.MdiParent = this;
            check_In.Show();
        }

        private void salonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Frm_Salones salones = new Frm_Salones();
            salones.MdiParent = this;
            salones.Show();
        }

        private void implosionYExplosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Frm_Implosion IE = new Frm_Implosion();
            IE.MdiParent = this;
            IE.Show();
        }

        private void mantenimientoHoteleriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Frm_Mantenimiento_hoteleria mantenimiento_Hoteleria = new Frm_Mantenimiento_hoteleria();
            mantenimiento_Hoteleria.MdiParent = this;
            mantenimiento_Hoteleria.Show();
        }

        private void ordenDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Frm_menu_ordenes formularioOP = new Frm_menu_ordenes();
            formularioOP.MdiParent = this;
            formularioOP.Show();
        }

        private void produccionHoteleriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Frm_Produccion_Hoteleria formularioP = new Frm_Produccion_Hoteleria();
            formularioP.MdiParent = this;
            formularioP.Show();
        }

        private void actualizaciónEstadiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Frm_Estadia estadia = new Frm_Estadia();
            estadia.MdiParent = this;
            estadia.Show();
        }

        private void asignacionServiciosAHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Frm_Asignacion_Servicio_Cuarto asig = new Frm_Asignacion_Servicio_Cuarto();
            asig.MdiParent = this;
            asig.Show();
        }

        private void areaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Frm_Area area = new Frm_Area();
            area.MdiParent = this;
            area.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Frm_Check_Out check_out = new Frm_Check_Out();
            check_out.MdiParent = this;
            check_out.Show();
        }

        private void cuentaTurismoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Frm_Cuenta_Turismo cuenta_Turismo = new Frm_Cuenta_Turismo();
            cuenta_Turismo.MdiParent = this;
            cuenta_Turismo.Show();
        }

        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            Frm_Pago Pago = new Frm_Pago();
            Pago.MdiParent = this;
            Pago.Show();
        }
    }
}