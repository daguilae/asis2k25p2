// Nombre: Diego Andre Monterroso Rabarique
// Carné: 0901-22-1369
// Fecha de modificación: 2025-11-09
// Descripción: Lógica de negocio para CRUD de Horas_Extras.

namespace Capa_Vista_HorasExtra
{
    partial class Frm_Editar_Horas_Extras
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Gpb_EditarHorasE = new System.Windows.Forms.GroupBox();
            this.Chb_Aprobado = new System.Windows.Forms.CheckBox();
            this.Txt_Motivo = new System.Windows.Forms.TextBox();
            this.Nud_Horas = new System.Windows.Forms.NumericUpDown();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Cbo_Empleado = new System.Windows.Forms.ComboBox();
            this.Lbl_Aprobado = new System.Windows.Forms.Label();
            this.Lbl_Motivo = new System.Windows.Forms.Label();
            this.Lbl_Horas = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Empleados = new System.Windows.Forms.Label();
            this.Pnl_Encabezado = new System.Windows.Forms.Panel();
            this.Lbl_Nomina = new System.Windows.Forms.Label();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Gpb_EditarHorasE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Horas)).BeginInit();
            this.Pnl_Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_EditarHorasE
            // 
            this.Gpb_EditarHorasE.Controls.Add(this.Btn_Regresar);
            this.Gpb_EditarHorasE.Controls.Add(this.Btn_Guardar);
            this.Gpb_EditarHorasE.Controls.Add(this.Chb_Aprobado);
            this.Gpb_EditarHorasE.Controls.Add(this.Txt_Motivo);
            this.Gpb_EditarHorasE.Controls.Add(this.Nud_Horas);
            this.Gpb_EditarHorasE.Controls.Add(this.Dtp_Fecha);
            this.Gpb_EditarHorasE.Controls.Add(this.Cbo_Empleado);
            this.Gpb_EditarHorasE.Controls.Add(this.Lbl_Aprobado);
            this.Gpb_EditarHorasE.Controls.Add(this.Lbl_Motivo);
            this.Gpb_EditarHorasE.Controls.Add(this.Lbl_Horas);
            this.Gpb_EditarHorasE.Controls.Add(this.Lbl_Fecha);
            this.Gpb_EditarHorasE.Controls.Add(this.Lbl_Empleados);
            this.Gpb_EditarHorasE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Gpb_EditarHorasE.Location = new System.Drawing.Point(20, 100);
            this.Gpb_EditarHorasE.Name = "Gpb_EditarHorasE";
            this.Gpb_EditarHorasE.Size = new System.Drawing.Size(760, 360);
            this.Gpb_EditarHorasE.TabIndex = 1;
            this.Gpb_EditarHorasE.TabStop = false;
            // 
            // Chb_Aprobado
            // 
            this.Chb_Aprobado.Location = new System.Drawing.Point(150, 240);
            this.Chb_Aprobado.Name = "Chb_Aprobado";
            this.Chb_Aprobado.Size = new System.Drawing.Size(104, 24);
            this.Chb_Aprobado.TabIndex = 2;
            // 
            // Txt_Motivo
            // 
            this.Txt_Motivo.Location = new System.Drawing.Point(150, 165);
            this.Txt_Motivo.Multiline = true;
            this.Txt_Motivo.Name = "Txt_Motivo";
            this.Txt_Motivo.Size = new System.Drawing.Size(400, 60);
            this.Txt_Motivo.TabIndex = 3;
            // 
            // Nud_Horas
            // 
            this.Nud_Horas.Location = new System.Drawing.Point(150, 125);
            this.Nud_Horas.Name = "Nud_Horas";
            this.Nud_Horas.Size = new System.Drawing.Size(120, 29);
            this.Nud_Horas.TabIndex = 4;
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Location = new System.Drawing.Point(150, 85);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(200, 29);
            this.Dtp_Fecha.TabIndex = 5;
            // 
            // Cbo_Empleado
            // 
            this.Cbo_Empleado.Location = new System.Drawing.Point(150, 45);
            this.Cbo_Empleado.Name = "Cbo_Empleado";
            this.Cbo_Empleado.Size = new System.Drawing.Size(200, 32);
            this.Cbo_Empleado.TabIndex = 6;
            // 
            // Lbl_Aprobado
            // 
            this.Lbl_Aprobado.Location = new System.Drawing.Point(40, 240);
            this.Lbl_Aprobado.Name = "Lbl_Aprobado";
            this.Lbl_Aprobado.Size = new System.Drawing.Size(100, 23);
            this.Lbl_Aprobado.TabIndex = 7;
            this.Lbl_Aprobado.Text = "Aprobado:";
            // 
            // Lbl_Motivo
            // 
            this.Lbl_Motivo.Location = new System.Drawing.Point(40, 170);
            this.Lbl_Motivo.Name = "Lbl_Motivo";
            this.Lbl_Motivo.Size = new System.Drawing.Size(100, 23);
            this.Lbl_Motivo.TabIndex = 8;
            this.Lbl_Motivo.Text = "Motivo:";
            // 
            // Lbl_Horas
            // 
            this.Lbl_Horas.Location = new System.Drawing.Point(40, 130);
            this.Lbl_Horas.Name = "Lbl_Horas";
            this.Lbl_Horas.Size = new System.Drawing.Size(100, 23);
            this.Lbl_Horas.TabIndex = 9;
            this.Lbl_Horas.Text = "Horas:";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.Location = new System.Drawing.Point(40, 90);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(100, 23);
            this.Lbl_Fecha.TabIndex = 10;
            this.Lbl_Fecha.Text = "Fecha:";
            // 
            // Lbl_Empleados
            // 
            this.Lbl_Empleados.Location = new System.Drawing.Point(40, 50);
            this.Lbl_Empleados.Name = "Lbl_Empleados";
            this.Lbl_Empleados.Size = new System.Drawing.Size(100, 23);
            this.Lbl_Empleados.TabIndex = 11;
            this.Lbl_Empleados.Text = "Empleado:";
            // 
            // Pnl_Encabezado
            // 
            this.Pnl_Encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Pnl_Encabezado.Controls.Add(this.Lbl_Nomina);
            this.Pnl_Encabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Encabezado.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Encabezado.Name = "Pnl_Encabezado";
            this.Pnl_Encabezado.Size = new System.Drawing.Size(800, 80);
            this.Pnl_Encabezado.TabIndex = 0;
            // 
            // Lbl_Nomina
            // 
            this.Lbl_Nomina.AutoSize = true;
            this.Lbl_Nomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Lbl_Nomina.Location = new System.Drawing.Point(20, 25);
            this.Lbl_Nomina.Name = "Lbl_Nomina";
            this.Lbl_Nomina.Size = new System.Drawing.Size(206, 29);
            this.Lbl_Nomina.TabIndex = 0;
            this.Lbl_Nomina.Text = "Editar Horas Extra";
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regresar.Image = global::Capa_Vista_HorasExtra.Properties.Resources.Cancel_icon_icons_com_73703;
            this.Btn_Regresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Regresar.Location = new System.Drawing.Point(370, 270);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(100, 60);
            this.Btn_Regresar.TabIndex = 0;
            this.Btn_Regresar.Text = "Regresar";
            this.Btn_Regresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Image = global::Capa_Vista_HorasExtra.Properties.Resources.savetheapplication_guardar_2958;
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Guardar.Location = new System.Drawing.Point(250, 270);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(100, 60);
            this.Btn_Guardar.TabIndex = 1;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Frm_Editar_Horas_Extras
            // 
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.Pnl_Encabezado);
            this.Controls.Add(this.Gpb_EditarHorasE);
            this.Name = "Frm_Editar_Horas_Extras";
            this.Text = "Editar Horas Extra";
            this.Gpb_EditarHorasE.ResumeLayout(false);
            this.Gpb_EditarHorasE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Horas)).EndInit();
            this.Pnl_Encabezado.ResumeLayout(false);
            this.Pnl_Encabezado.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox Gpb_EditarHorasE;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.CheckBox Chb_Aprobado;
        private System.Windows.Forms.TextBox Txt_Motivo;
        private System.Windows.Forms.NumericUpDown Nud_Horas;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        private System.Windows.Forms.ComboBox Cbo_Empleado;
        private System.Windows.Forms.Label Lbl_Aprobado;
        private System.Windows.Forms.Label Lbl_Motivo;
        private System.Windows.Forms.Label Lbl_Horas;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_Empleados;
        private System.Windows.Forms.Panel Pnl_Encabezado;
        private System.Windows.Forms.Label Lbl_Nomina;
    }
}
