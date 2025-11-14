using System;
using System.Data;
using Capa_Modelo_MH;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Capa_Controlador_MH
{
    public class Cls_Controlador_OP
    {
        private readonly Cls_Modelo_OP modelo = new Cls_Modelo_OP();

        // ============================================================
        // MOSTRAR REGISTROS
        // ============================================================
        public DataTable fun_MostrarObjetos()
        {
            OdbcDataAdapter da = modelo.fun_MostrarObjetos();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // ============================================================
        // CRUD
        // ============================================================
        public void fun_InsertarObjeto(string mantenimiento, string folioSalon, string folioHabitacion,
                                       string huesped, string nombre, string descripcion,
                                       string tipo, string fecha, int entregado)
        {
            modelo.fun_InsertarObjeto(mantenimiento, folioSalon, folioHabitacion,
                                      huesped, nombre, descripcion, tipo, fecha, entregado);
        }

        public void fun_ActualizarObjeto(string id, string mantenimiento, string folioSalon, string folioHabitacion,
                                         string huesped, string nombre, string descripcion,
                                         string tipo, string fecha, int entregado)
        {
            modelo.fun_ActualizarObjeto(id, mantenimiento, folioSalon, folioHabitacion,
                                        huesped, nombre, descripcion, tipo, fecha, entregado);
        }

        public void fun_EliminarObjeto(string id)
        {
            modelo.fun_EliminarObjeto(id);
        }

        public DataTable fun_BuscarObjetoPorId(string id)
        {
            return modelo.fun_BuscarObjetoPorId(id);
        }

        // ============================================================
        // MÉTODOS DE SOPORTE PARA LA VISTA
        // ============================================================
        public void fun_LlenarCombos(Form frm)
        {
            try
            {
                ComboBox cboObjeto = (ComboBox)frm.Controls.Find("Cbo_Id_Objeto", true)[0];
                ComboBox cboMantenimiento = (ComboBox)frm.Controls.Find("Cbo_Id_Mantenimiento", true)[0];
                ComboBox cboFolioHab = (ComboBox)frm.Controls.Find("Cbo_Id_FolioHabitacion", true)[0];
                ComboBox cboFolioSalon = (ComboBox)frm.Controls.Find("Cbo_Id_FolioSalon", true)[0];
                ComboBox cboHuesped = (ComboBox)frm.Controls.Find("Cbo_Id_Huesped", true)[0];

                // Combo: Objetos Perdidos
                cboObjeto.DataSource = modelo.fun_EjecutarConsulta(
                    "SELECT Pk_Id_Objeto, CONCAT(Pk_Id_Objeto, ' - ', Cmp_Nombre_Objeto) AS Display FROM Tbl_Objetos_Perdidos ORDER BY Pk_Id_Objeto;");
                cboObjeto.DisplayMember = "Display";
                cboObjeto.ValueMember = "Pk_Id_Objeto";
                cboObjeto.SelectedIndex = -1;

                // Combo: Mantenimiento
                cboMantenimiento.DataSource = modelo.fun_EjecutarConsulta(
                    "SELECT Pk_Id_Mantenimiento, CONCAT(Pk_Id_Mantenimiento, ' - ', Cmp_Tipo_Mantenimiento) AS Display FROM Tbl_Mantenimiento;");
                cboMantenimiento.DisplayMember = "Display";
                cboMantenimiento.ValueMember = "Pk_Id_Mantenimiento";
                cboMantenimiento.SelectedIndex = -1;

                // Combo: Folio Habitación
                cboFolioHab.DataSource = modelo.fun_EjecutarConsulta(
                    "SELECT Pk_Id_Folio, CONCAT(Pk_Id_Folio, ' - Habitación ', Fk_Id_Habitacion) AS Display FROM Tbl_Folio;");
                cboFolioHab.DisplayMember = "Display";
                cboFolioHab.ValueMember = "Pk_Id_Folio";
                cboFolioHab.SelectedIndex = -1;

                // Combo: Folio Salón
                cboFolioSalon.DataSource = modelo.fun_EjecutarConsulta(
                    "SELECT Pk_Id_Folio_Salones, CONCAT(Pk_Id_Folio_Salones, ' - Evento ', Fk_Id_Reserva_Salon) AS Display FROM Tbl_Folio_Salones;");
                cboFolioSalon.DisplayMember = "Display";
                cboFolioSalon.ValueMember = "Pk_Id_Folio_Salones";
                cboFolioSalon.SelectedIndex = -1;

                cboHuesped.DataSource = modelo.fun_EjecutarConsulta(
                    "SELECT Pk_Id_Huesped, CONCAT(Pk_Id_Huesped, ' - ', Cmp_Nombre, ' ', Cmp_Apellido) AS Display FROM Tbl_Huesped;");
                cboHuesped.DisplayMember = "Display";
                cboHuesped.ValueMember = "Pk_Id_Huesped";
                cboHuesped.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los combos: " + ex.Message);
            }
        }

        public void fun_LimpiarCampos(Form frm)
        {
            ((ComboBox)frm.Controls.Find("Cbo_Id_Objeto", true)[0]).SelectedIndex = -1;
            ((ComboBox)frm.Controls.Find("Cbo_Id_Mantenimiento", true)[0]).SelectedIndex = -1;
            ((ComboBox)frm.Controls.Find("Cbo_Id_FolioSalon", true)[0]).SelectedIndex = -1;
            ((ComboBox)frm.Controls.Find("Cbo_Id_FolioHabitacion", true)[0]).SelectedIndex = -1;
            ((ComboBox)frm.Controls.Find("Cbo_Id_Huesped", true)[0]).SelectedIndex = -1;
            ((TextBox)frm.Controls.Find("Txt_Nombre_Objeto", true)[0]).Clear();
            ((TextBox)frm.Controls.Find("Txt_Descripcion_Objeto", true)[0]).Clear();
            ((TextBox)frm.Controls.Find("Txt_Tipo_Objeto", true)[0]).Clear();
            ((DateTimePicker)frm.Controls.Find("Dtp_Fecha_Encontrado", true)[0]).Value = DateTime.Now;
            ((CheckBox)frm.Controls.Find("Chk_Entregado", true)[0]).Checked = false;
        }

        public void fun_BuscarObjeto(Form frm)
        {
            ComboBox cboObjeto = (ComboBox)frm.Controls.Find("Cbo_Id_Objeto", true)[0];
            string idBuscar = cboObjeto.SelectedValue?.ToString();

            if (string.IsNullOrWhiteSpace(idBuscar))
            {
                MessageBox.Show("Seleccione el objeto que desea buscar.");
                return;
            }

            DataTable dt = modelo.fun_BuscarObjetoPorId(idBuscar);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró el registro.");
                return;
            }

            DataRow fila = dt.Rows[0];


            ((TextBox)frm.Controls.Find("Txt_Nombre_Objeto", true)[0]).Text = fila["Cmp_Nombre_Objeto"].ToString();
            ((TextBox)frm.Controls.Find("Txt_Descripcion_Objeto", true)[0]).Text = fila["Cmp_Descripcion_Objeto"].ToString();
            ((TextBox)frm.Controls.Find("Txt_Tipo_Objeto", true)[0]).Text = fila["Cmp_Tipo_Objeto"].ToString();


            ((ComboBox)frm.Controls.Find("Cbo_Id_Mantenimiento", true)[0]).SelectedValue =
                fila["Fk_Id_Mantenimiento"] == DBNull.Value ? -1 : Convert.ToInt32(fila["Fk_Id_Mantenimiento"]);

            ((ComboBox)frm.Controls.Find("Cbo_Id_FolioSalon", true)[0]).SelectedValue =
                fila["Fk_Id_Folio_Salon"] == DBNull.Value ? -1 : Convert.ToInt32(fila["Fk_Id_Folio_Salon"]);

            ((ComboBox)frm.Controls.Find("Cbo_Id_FolioHabitacion", true)[0]).SelectedValue =
                fila["Fk_Id_Folio"] == DBNull.Value ? -1 : Convert.ToInt32(fila["Fk_Id_Folio"]);

            ((ComboBox)frm.Controls.Find("Cbo_Id_Huesped", true)[0]).SelectedValue =
                fila["Fk_Id_Huesped"] == DBNull.Value ? -1 : Convert.ToInt32(fila["Fk_Id_Huesped"]);


            if (DateTime.TryParse(fila["Cmp_Fecha_Encontrado"].ToString(), out DateTime fecha))
                ((DateTimePicker)frm.Controls.Find("Dtp_Fecha_Encontrado", true)[0]).Value = fecha;
            else
                ((DateTimePicker)frm.Controls.Find("Dtp_Fecha_Encontrado", true)[0]).Value = DateTime.Now;

  
            ((CheckBox)frm.Controls.Find("Chk_Entregado", true)[0]).Checked = fila["Cmp_Entregado"].ToString() == "1";

            MessageBox.Show("Registro encontrado correctamente.", "Búsqueda exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
