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
        string sAuto = "Tbl_Orden_Compra_Autorizada";
        Cls_Controlador_Ordenes cn = new Cls_Controlador_Ordenes();

        public Frm_Ordenes()
        {
            InitializeComponent();
        }

 
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(sAuto);
            Dgv_Auto_Ordenes.DataSource = dt;
        }

  
        private void Btn_Consultar_Autorizaciones_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

   
        private void Btn_Agregar_Autorizacion_Click(object sender, EventArgs e)
        {
            try
            {
                int idOrden = int.Parse(Txt_Id_Orden.Text);
                int idBanco = int.Parse(Txt_Id_Banco.Text);
                DateTime fecha = Convert.ToDateTime(Txt_Fecha_Autorizacion.Text);
                string autorizadoPor = Txt_Autorizado_Por.Text;
                decimal monto = decimal.Parse(Txt_Monto_Autorizado.Text);
                int idEstado = int.Parse(Txt_Estado_Autorizacion.Text);

                cn.AgregarAutorizacion(idOrden, idBanco, fecha, autorizadoPor, monto, idEstado);

                MessageBox.Show(" Autorización agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizardatagriew();

                
                Txt_Id_Orden.Clear();
                Txt_Id_Banco.Clear();
                Txt_Fecha_Autorizacion.Clear();
                Txt_Autorizado_Por.Clear();
                Txt_Monto_Autorizado.Clear();
                Txt_Estado_Autorizacion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al agregar la autorización: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
