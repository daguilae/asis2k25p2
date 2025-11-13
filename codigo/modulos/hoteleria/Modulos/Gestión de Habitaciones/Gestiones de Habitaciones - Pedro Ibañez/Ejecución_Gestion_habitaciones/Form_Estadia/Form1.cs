using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Gestion_Habitacion;

namespace Form_Estadia
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            // Cargar el formulario de estadía al iniciar
            CargarFrmEstadia();
        }

        private void CargarFrmEstadia()
        {
            // Instancia del formulario de la otra capa
            Frm_Asignacion_Servicio_Cuarto frm = new Frm_Asignacion_Servicio_Cuarto();

            // Opcional: configuraciones visuales
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            // Agregarlo dentro de Form1 (como contenedor principal)
            this.Controls.Clear();
            this.Controls.Add(frm);
            frm.Show();
        }
    }
}