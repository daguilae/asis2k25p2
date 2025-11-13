// Nombre: Diego Andre Monterroso Rabarique
// Carné: 0901-22-1369
// Fecha de modificación: 2025-11-09
// Descripción: Lógica de negocio para CRUD de Horas_Extras.

namespace Capa_Vista_HorasExtra
{
    partial class Frm_Solicitar_Horas_Extras
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Gpb_SolicitarHorasE = new System.Windows.Forms.GroupBox();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Chb_Aprobado = new System.Windows.Forms.CheckBox();
            this.Txt_Motivo = new System.Windows.Forms.TextBox();
            this.Lbl_Motivo = new System.Windows.Forms.Label();
            this.Nud_Horas = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Horas = new System.Windows.Forms.Label();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Cbo_Empleado = new System.Windows.Forms.ComboBox();
            this.Lbl_Empleado = new System.Windows.Forms.Label();
            this.Gpb_SolicitarHorasE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Horas)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_SolicitarHorasE
            // 
            this.Gpb_SolicitarHorasE.Controls.Add(this.Btn_Regresar);
            this.Gpb_SolicitarHorasE.Controls.Add(this.Btn_Guardar);
            this.Gpb_SolicitarHorasE.Controls.Add(this.Chb_Aprobado);
            this.Gpb_SolicitarHorasE.Controls.Add(this.Txt_Motivo);
            this.Gpb_SolicitarHorasE.Controls.Add(this.Lbl_Motivo);
            this.Gpb_SolicitarHorasE.Controls.Add(this.Nud_Horas);
            this.Gpb_SolicitarHorasE.Controls.Add(this.Lbl_Horas);
            this.Gpb_SolicitarHorasE.Controls.Add(this.Dtp_Fecha);
            this.Gpb_SolicitarHorasE.Controls.Add(this.Lbl_Fecha);
            this.Gpb_SolicitarHorasE.Controls.Add(this.Cbo_Empleado);
            this.Gpb_SolicitarHorasE.Controls.Add(this.Lbl_Empleado);
            this.Gpb_SolicitarHorasE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Gpb_SolicitarHorasE.Location = new System.Drawing.Point(12, 12);
            this.Gpb_SolicitarHorasE.Name = "Gpb_SolicitarHorasE";
            this.Gpb_SolicitarHorasE.Size = new System.Drawing.Size(600, 400);
            this.Gpb_SolicitarHorasE.TabIndex = 0;
            this.Gpb_SolicitarHorasE.TabStop = false;
            this.Gpb_SolicitarHorasE.Text = "Solicitud de Horas Extra";
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regresar.Image = global::Capa_Vista_HorasExtra.Properties.Resources.Cancel_icon_icons_com_73703;
            this.Btn_Regresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Regresar.Location = new System.Drawing.Point(280, 330);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(100, 64);
            this.Btn_Regresar.TabIndex = 10;
            this.Btn_Regresar.Text = "Regresar";
            this.Btn_Regresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Regresar.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Image = global::Capa_Vista_HorasExtra.Properties.Resources.savetheapplication_guardar_2958;
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Guardar.Location = new System.Drawing.Point(160, 330);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(100, 64);
            this.Btn_Guardar.TabIndex = 9;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Chb_Aprobado
            // 
            this.Chb_Aprobado.AutoSize = true;
            this.Chb_Aprobado.Location = new System.Drawing.Point(160, 285);
            this.Chb_Aprobado.Name = "Chb_Aprobado";
            this.Chb_Aprobado.Size = new System.Drawing.Size(98, 24);
            this.Chb_Aprobado.TabIndex = 8;
            this.Chb_Aprobado.Text = "Aprobado";
            this.Chb_Aprobado.UseVisualStyleBackColor = true;
            // 
            // Txt_Motivo
            // 
            this.Txt_Motivo.Location = new System.Drawing.Point(160, 190);
            this.Txt_Motivo.Multiline = true;
            this.Txt_Motivo.Name = "Txt_Motivo";
            this.Txt_Motivo.Size = new System.Drawing.Size(300, 80);
            this.Txt_Motivo.TabIndex = 6;
            // 
            // Lbl_Motivo
            // 
            this.Lbl_Motivo.AutoSize = true;
            this.Lbl_Motivo.Location = new System.Drawing.Point(50, 193);
            this.Lbl_Motivo.Name = "Lbl_Motivo";
            this.Lbl_Motivo.Size = new System.Drawing.Size(59, 20);
            this.Lbl_Motivo.TabIndex = 7;
            this.Lbl_Motivo.Text = "Motivo:";
            // 
            // Nud_Horas
            // 
            this.Nud_Horas.Location = new System.Drawing.Point(160, 140);
            this.Nud_Horas.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.Nud_Horas.Name = "Nud_Horas";
            this.Nud_Horas.Size = new System.Drawing.Size(120, 26);
            this.Nud_Horas.TabIndex = 4;
            // 
            // Lbl_Horas
            // 
            this.Lbl_Horas.AutoSize = true;
            this.Lbl_Horas.Location = new System.Drawing.Point(50, 142);
            this.Lbl_Horas.Name = "Lbl_Horas";
            this.Lbl_Horas.Size = new System.Drawing.Size(56, 20);
            this.Lbl_Horas.TabIndex = 5;
            this.Lbl_Horas.Text = "Horas:";
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Location = new System.Drawing.Point(160, 90);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(300, 26);
            this.Dtp_Fecha.TabIndex = 2;
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Location = new System.Drawing.Point(50, 95);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(58, 20);
            this.Lbl_Fecha.TabIndex = 3;
            this.Lbl_Fecha.Text = "Fecha:";
            // 
            // Cbo_Empleado
            // 
            this.Cbo_Empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Empleado.FormattingEnabled = true;
            this.Cbo_Empleado.Location = new System.Drawing.Point(160, 40);
            this.Cbo_Empleado.Name = "Cbo_Empleado";
            this.Cbo_Empleado.Size = new System.Drawing.Size(300, 28);
            this.Cbo_Empleado.TabIndex = 0;
            // 
            // Lbl_Empleado
            // 
            this.Lbl_Empleado.AutoSize = true;
            this.Lbl_Empleado.Location = new System.Drawing.Point(50, 43);
            this.Lbl_Empleado.Name = "Lbl_Empleado";
            this.Lbl_Empleado.Size = new System.Drawing.Size(85, 20);
            this.Lbl_Empleado.TabIndex = 1;
            this.Lbl_Empleado.Text = "Empleado:";
            // 
            // Frm_Solicitar_Horas_Extras
            // 
            this.ClientSize = new System.Drawing.Size(624, 421);
            this.Controls.Add(this.Gpb_SolicitarHorasE);
            this.Name = "Frm_Solicitar_Horas_Extras";
            this.Text = "Solicitud de Horas Extras";
            this.Gpb_SolicitarHorasE.ResumeLayout(false);
            this.Gpb_SolicitarHorasE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Horas)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox Gpb_SolicitarHorasE;
        private System.Windows.Forms.ComboBox Cbo_Empleado;
        private System.Windows.Forms.Label Lbl_Empleado;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.NumericUpDown Nud_Horas;
        private System.Windows.Forms.Label Lbl_Horas;
        private System.Windows.Forms.TextBox Txt_Motivo;
        private System.Windows.Forms.Label Lbl_Motivo;
        private System.Windows.Forms.CheckBox Chb_Aprobado;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Regresar;
    }
}
