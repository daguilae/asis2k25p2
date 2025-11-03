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
using Capa_Vista_Produccion;


namespace Capa_Vista_Hoteleria
{
    public partial class Frm_MDI_Hoteleria : Form
    {
        public Frm_MDI_Hoteleria()
        {
            InitializeComponent();
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Area area = new Frm_Area();
            area.Show();
        }


        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Seguridad seguridad = new Frm_Seguridad();
            seguridad.Show();

        }

        private void polizaContableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Poliza_Turismo poliza = new Frm_Poliza_Turismo();
            poliza.Show();
        }

        private void mantenimientoHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_Habitaciones habitaciones = new Frm_Mantenimiento_Habitaciones();
            habitaciones.Show();
        }

        private void tipoHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_Tipo_Habitaciones Tipo_Habitaciones = new Frm_Mantenimiento_Tipo_Habitaciones();
            Tipo_Habitaciones.Show();

        }

        private void serviciosCuartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Servicios_Cuartos Servicio_Cuartos = new Frm_Servicios_Cuartos();
            Servicio_Cuartos.Show();
        }

        private void huespedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Huespedes _Huespedes = new Frm_Huespedes();
            _Huespedes.Show();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reservas Reserva = new Frm_Reservas();
            Reserva.Show();
        }

        private void checkInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_Check_In check_In = new Frm_Check_In();
            check_In.Show();
        }

        private void salonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Salones salones = new Frm_Salones();
            salones.Show();

        }

        private void implosionYExplosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Implosion IE = new Frm_Implosion();
            IE.Show();
        }

        private void mantenimientoHoteleriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_hoteleria mantenimiento_Hoteleria = new Frm_Mantenimiento_hoteleria();
            mantenimiento_Hoteleria.Show();
        }

        private void ordenDeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordenDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produccionHoteleriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Produccion_Hoteleria produccion_Hoteleria = new Frm_Produccion_Hoteleria();

        }

        private void cuentaTurismoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cuenta_Turismo cuenta_Turismo = new Frm_Cuenta_Turismo();
            cuenta_Turismo.Show();
        }

        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Pago Pago = new Frm_Pago();
            Pago.Show();
        }

    }
}
