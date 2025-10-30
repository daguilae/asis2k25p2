using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Ordenes;


namespace Capa_Vista_Ordenes
{
    public partial class Frm_Ordenes : Form
    {
        Cls_Controlador_Ordenes cn = new Cls_Controlador_Ordenes();
        string tabla = "Tbl_Orden_Compra_Autorizada";

        public Frm_Ordenes()
        {
            InitializeComponent();
            Btn_Agregar_Autorizacion.Click += Btn_Agregar_Autorizacion_Click;
            Btn_Consultar_Autorizaciones.Click += Btn_Consultar_Autorizaciones_Click;
        }


        private void ActualizarGrid()
        {
            DataTable dt = cn.LlenarTabla(tabla);
            Dgv_Auto_Ordenes.DataSource = dt;
        }

        private void Btn_Consultar_Autorizaciones_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }


        private void Btn_Agregar_Autorizacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Id_Autorizacion.Text) ||
                string.IsNullOrEmpty(Txt_Id_Orden.Text) ||
                string.IsNullOrEmpty(Txt_Id_Banco.Text) ||
                string.IsNullOrEmpty(Txt_Fecha_Autorizacion.Text) ||
                string.IsNullOrEmpty(Txt_Autorizado_Por.Text) ||
                string.IsNullOrEmpty(Txt_Monto_Autorizado.Text) ||
                string.IsNullOrEmpty(Txt_Estado_Autorizacion.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            Cls_Controlador_Ordenes controlador = new Cls_Controlador_Ordenes();

            bool resultado = controlador.AgregarAutorizacion(
                Txt_Id_Autorizacion.Text,
                Txt_Id_Orden.Text,
                Txt_Id_Banco.Text,
                Txt_Fecha_Autorizacion.Text,
                Txt_Autorizado_Por.Text,
                Txt_Monto_Autorizado.Text,
                Txt_Estado_Autorizacion.Text
            );

            if (resultado)
            {
                MessageBox.Show("Autorización agregada correctamente.");
                ActualizarGrid(); 
                             
                Txt_Id_Autorizacion.Clear();
                Txt_Id_Orden.Clear();
                Txt_Id_Banco.Clear();
                Txt_Fecha_Autorizacion.Clear();
                Txt_Autorizado_Por.Clear();
                Txt_Monto_Autorizado.Clear();
                Txt_Estado_Autorizacion.Clear();
            }
            else
            {
                MessageBox.Show("No se pudo agregar la autorización. Revise los datos ingresados.");
            }
        }

        private void Btn_Eliminar_Autorizacion_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
