
namespace Capa_Vista_Nominas
{
    partial class SolicitarHorasExtra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitarHorasExtra));
            this.Gpb_Solicitar = new System.Windows.Forms.GroupBox();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Lbl_Aprovado = new System.Windows.Forms.Label();
            this.Lbl_Motivo = new System.Windows.Forms.Label();
            this.Lbl_Horas = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Empleado = new System.Windows.Forms.Label();
            this.Chk_Aprobado = new System.Windows.Forms.CheckBox();
            this.Txt_Motivo = new System.Windows.Forms.TextBox();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Nud_Horas = new System.Windows.Forms.NumericUpDown();
            this.Cbo_Empleado = new System.Windows.Forms.ComboBox();
            this.Gpb_Solicitar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Horas)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_Solicitar
            // 
            this.Gpb_Solicitar.Controls.Add(this.Cbo_Empleado);
            this.Gpb_Solicitar.Controls.Add(this.Nud_Horas);
            this.Gpb_Solicitar.Controls.Add(this.Dtp_Fecha);
            this.Gpb_Solicitar.Controls.Add(this.Txt_Motivo);
            this.Gpb_Solicitar.Controls.Add(this.Chk_Aprobado);
            this.Gpb_Solicitar.Controls.Add(this.Btn_Regresar);
            this.Gpb_Solicitar.Controls.Add(this.Btn_Guardar);
            this.Gpb_Solicitar.Controls.Add(this.Lbl_Aprovado);
            this.Gpb_Solicitar.Controls.Add(this.Lbl_Motivo);
            this.Gpb_Solicitar.Controls.Add(this.Lbl_Horas);
            this.Gpb_Solicitar.Controls.Add(this.Lbl_Fecha);
            this.Gpb_Solicitar.Controls.Add(this.Lbl_Empleado);
            this.Gpb_Solicitar.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Solicitar.Location = new System.Drawing.Point(12, 12);
            this.Gpb_Solicitar.Name = "Gpb_Solicitar";
            this.Gpb_Solicitar.Size = new System.Drawing.Size(783, 414);
            this.Gpb_Solicitar.TabIndex = 7;
            this.Gpb_Solicitar.TabStop = false;
            this.Gpb_Solicitar.Text = "Solicitar Horas Extra";
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Regresar.Image")));
            this.Btn_Regresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Regresar.Location = new System.Drawing.Point(394, 324);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(89, 60);
            this.Btn_Regresar.TabIndex = 13;
            this.Btn_Regresar.Text = "Regresar";
            this.Btn_Regresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Regresar.UseVisualStyleBackColor = true;
            this.Btn_Regresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Guardar.Location = new System.Drawing.Point(299, 324);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(89, 60);
            this.Btn_Guardar.TabIndex = 12;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_Aprovado
            // 
            this.Lbl_Aprovado.AutoSize = true;
            this.Lbl_Aprovado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Aprovado.Location = new System.Drawing.Point(36, 295);
            this.Lbl_Aprovado.Name = "Lbl_Aprovado";
            this.Lbl_Aprovado.Size = new System.Drawing.Size(76, 17);
            this.Lbl_Aprovado.TabIndex = 11;
            this.Lbl_Aprovado.Text = "Aprovado";
            this.Lbl_Aprovado.Click += new System.EventHandler(this.Lbl_Aprovado_Click);
            // 
            // Lbl_Motivo
            // 
            this.Lbl_Motivo.AutoSize = true;
            this.Lbl_Motivo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Motivo.Location = new System.Drawing.Point(36, 197);
            this.Lbl_Motivo.Name = "Lbl_Motivo";
            this.Lbl_Motivo.Size = new System.Drawing.Size(57, 17);
            this.Lbl_Motivo.TabIndex = 10;
            this.Lbl_Motivo.Text = "Motivo";
            this.Lbl_Motivo.Click += new System.EventHandler(this.Lbl_Motivo_Click);
            // 
            // Lbl_Horas
            // 
            this.Lbl_Horas.AutoSize = true;
            this.Lbl_Horas.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Horas.Location = new System.Drawing.Point(36, 146);
            this.Lbl_Horas.Name = "Lbl_Horas";
            this.Lbl_Horas.Size = new System.Drawing.Size(49, 17);
            this.Lbl_Horas.TabIndex = 9;
            this.Lbl_Horas.Text = "Horas";
            this.Lbl_Horas.Click += new System.EventHandler(this.Lbl_Horas_Click);
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(36, 87);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(50, 17);
            this.Lbl_Fecha.TabIndex = 8;
            this.Lbl_Fecha.Text = "Fecha";
            this.Lbl_Fecha.Click += new System.EventHandler(this.Lbl_Fecha_Click);
            // 
            // Lbl_Empleado
            // 
            this.Lbl_Empleado.AutoSize = true;
            this.Lbl_Empleado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Empleado.Location = new System.Drawing.Point(36, 47);
            this.Lbl_Empleado.Name = "Lbl_Empleado";
            this.Lbl_Empleado.Size = new System.Drawing.Size(79, 17);
            this.Lbl_Empleado.TabIndex = 7;
            this.Lbl_Empleado.Text = "Empleado";
            this.Lbl_Empleado.Click += new System.EventHandler(this.Lbl_Empleado_Click);
            // 
            // Chk_Aprobado
            // 
            this.Chk_Aprobado.AutoSize = true;
            this.Chk_Aprobado.Location = new System.Drawing.Point(161, 298);
            this.Chk_Aprobado.Name = "Chk_Aprobado";
            this.Chk_Aprobado.Size = new System.Drawing.Size(15, 14);
            this.Chk_Aprobado.TabIndex = 14;
            this.Chk_Aprobado.UseVisualStyleBackColor = true;
            // 
            // Txt_Motivo
            // 
            this.Txt_Motivo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Motivo.Location = new System.Drawing.Point(112, 186);
            this.Txt_Motivo.Multiline = true;
            this.Txt_Motivo.Name = "Txt_Motivo";
            this.Txt_Motivo.Size = new System.Drawing.Size(598, 92);
            this.Txt_Motivo.TabIndex = 15;
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha.Location = new System.Drawing.Point(112, 87);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(200, 25);
            this.Dtp_Fecha.TabIndex = 16;
            // 
            // Nud_Horas
            // 
            this.Nud_Horas.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nud_Horas.Location = new System.Drawing.Point(102, 144);
            this.Nud_Horas.Name = "Nud_Horas";
            this.Nud_Horas.Size = new System.Drawing.Size(120, 25);
            this.Nud_Horas.TabIndex = 17;
            // 
            // Cbo_Empleado
            // 
            this.Cbo_Empleado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Empleado.FormattingEnabled = true;
            this.Cbo_Empleado.Location = new System.Drawing.Point(124, 46);
            this.Cbo_Empleado.Name = "Cbo_Empleado";
            this.Cbo_Empleado.Size = new System.Drawing.Size(121, 25);
            this.Cbo_Empleado.TabIndex = 18;
            // 
            // SolicitarHorasExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 438);
            this.Controls.Add(this.Gpb_Solicitar);
            this.Name = "SolicitarHorasExtra";
            this.Text = "SolicitarHorasExtra";
            this.Gpb_Solicitar.ResumeLayout(false);
            this.Gpb_Solicitar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Horas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_Solicitar;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label Lbl_Aprovado;
        private System.Windows.Forms.Label Lbl_Motivo;
        private System.Windows.Forms.Label Lbl_Horas;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_Empleado;
        private System.Windows.Forms.NumericUpDown Nud_Horas;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        private System.Windows.Forms.TextBox Txt_Motivo;
        private System.Windows.Forms.CheckBox Chk_Aprobado;
        private System.Windows.Forms.ComboBox Cbo_Empleado;
    }
}