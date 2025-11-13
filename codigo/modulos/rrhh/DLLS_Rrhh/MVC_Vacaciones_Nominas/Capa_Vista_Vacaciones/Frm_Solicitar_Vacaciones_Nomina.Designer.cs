// Nombre: Jose Pablo Medina González
// Carné: 0901-22-2592
// Fecha de modificación: 2025-11-09
// Descripción: Designer del Form Solicitar Vacaciones.

namespace Capa_Vista_Vacaciones
{
    partial class Frm_Solicitar_Vacaciones_Nomina
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Solicitar_Vacaciones_Nomina));
            this.Gpb_SolicitarV = new System.Windows.Forms.GroupBox();
            this.Dtp_FechaF = new System.Windows.Forms.DateTimePicker();
            this.Lbl_FechaFinal = new System.Windows.Forms.Label();
            this.Cbo_Empleado = new System.Windows.Forms.ComboBox();
            this.Nud_Dias = new System.Windows.Forms.NumericUpDown();
            this.Dtp_FechaI = new System.Windows.Forms.DateTimePicker();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Lbl_Dias = new System.Windows.Forms.Label();
            this.Lbl_FechaInicio = new System.Windows.Forms.Label();
            this.Lbl_Empleado = new System.Windows.Forms.Label();
            this.Pnl_encabezado = new System.Windows.Forms.Panel();
            this.Lbl_Nomina = new System.Windows.Forms.Label();
            this.Gpb_SolicitarV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Dias)).BeginInit();
            this.Pnl_encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_SolicitarV
            // 
            this.Gpb_SolicitarV.Controls.Add(this.Dtp_FechaF);
            this.Gpb_SolicitarV.Controls.Add(this.Lbl_FechaFinal);
            this.Gpb_SolicitarV.Controls.Add(this.Cbo_Empleado);
            this.Gpb_SolicitarV.Controls.Add(this.Nud_Dias);
            this.Gpb_SolicitarV.Controls.Add(this.Dtp_FechaI);
            this.Gpb_SolicitarV.Controls.Add(this.Btn_Regresar);
            this.Gpb_SolicitarV.Controls.Add(this.Btn_Guardar);
            this.Gpb_SolicitarV.Controls.Add(this.Lbl_Dias);
            this.Gpb_SolicitarV.Controls.Add(this.Lbl_FechaInicio);
            this.Gpb_SolicitarV.Controls.Add(this.Lbl_Empleado);
            this.Gpb_SolicitarV.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Gpb_SolicitarV.Location = new System.Drawing.Point(12, 99);
            this.Gpb_SolicitarV.Name = "Gpb_SolicitarV";
            this.Gpb_SolicitarV.Size = new System.Drawing.Size(769, 358);
            this.Gpb_SolicitarV.TabIndex = 14;
            this.Gpb_SolicitarV.TabStop = false;
            this.Gpb_SolicitarV.Text = "Solicitar Vacaciones";
            // 
            // Dtp_FechaF
            // 
            this.Dtp_FechaF.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.Dtp_FechaF.Location = new System.Drawing.Point(525, 139);
            this.Dtp_FechaF.Name = "Dtp_FechaF";
            this.Dtp_FechaF.Size = new System.Drawing.Size(200, 25);
            this.Dtp_FechaF.TabIndex = 20;
            this.Dtp_FechaF.ValueChanged += new System.EventHandler(this.Dtp_FechaF_ValueChanged);
            // 
            // Lbl_FechaFinal
            // 
            this.Lbl_FechaFinal.AutoSize = true;
            this.Lbl_FechaFinal.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.Lbl_FechaFinal.Location = new System.Drawing.Point(419, 145);
            this.Lbl_FechaFinal.Name = "Lbl_FechaFinal";
            this.Lbl_FechaFinal.Size = new System.Drawing.Size(89, 17);
            this.Lbl_FechaFinal.TabIndex = 19;
            this.Lbl_FechaFinal.Text = "Fecha Final";
            // 
            // Cbo_Empleado
            // 
            this.Cbo_Empleado.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.Cbo_Empleado.FormattingEnabled = true;
            this.Cbo_Empleado.Location = new System.Drawing.Point(126, 85);
            this.Cbo_Empleado.Name = "Cbo_Empleado";
            this.Cbo_Empleado.Size = new System.Drawing.Size(229, 25);
            this.Cbo_Empleado.TabIndex = 18;
            // 
            // Nud_Dias
            // 
            this.Nud_Dias.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.Nud_Dias.Location = new System.Drawing.Point(104, 205);
            this.Nud_Dias.Name = "Nud_Dias";
            this.Nud_Dias.Size = new System.Drawing.Size(120, 25);
            this.Nud_Dias.TabIndex = 17;
            // 
            // Dtp_FechaI
            // 
            this.Dtp_FechaI.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.Dtp_FechaI.Location = new System.Drawing.Point(149, 139);
            this.Dtp_FechaI.Name = "Dtp_FechaI";
            this.Dtp_FechaI.Size = new System.Drawing.Size(200, 25);
            this.Dtp_FechaI.TabIndex = 16;
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.Btn_Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Regresar.Image")));
            this.Btn_Regresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Regresar.Location = new System.Drawing.Point(455, 271);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(89, 60);
            this.Btn_Regresar.TabIndex = 13;
            this.Btn_Regresar.Text = "Regresar";
            this.Btn_Regresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Regresar.UseVisualStyleBackColor = true;
            this.Btn_Regresar.Click += new System.EventHandler(this.Btn_Regresar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Guardar.Location = new System.Drawing.Point(360, 271);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(89, 60);
            this.Btn_Guardar.TabIndex = 12;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Lbl_Dias
            // 
            this.Lbl_Dias.AutoSize = true;
            this.Lbl_Dias.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.Lbl_Dias.Location = new System.Drawing.Point(38, 207);
            this.Lbl_Dias.Name = "Lbl_Dias";
            this.Lbl_Dias.Size = new System.Drawing.Size(39, 17);
            this.Lbl_Dias.TabIndex = 9;
            this.Lbl_Dias.Text = "Días";
            // 
            // Lbl_FechaInicio
            // 
            this.Lbl_FechaInicio.AutoSize = true;
            this.Lbl_FechaInicio.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.Lbl_FechaInicio.Location = new System.Drawing.Point(36, 145);
            this.Lbl_FechaInicio.Name = "Lbl_FechaInicio";
            this.Lbl_FechaInicio.Size = new System.Drawing.Size(95, 17);
            this.Lbl_FechaInicio.TabIndex = 8;
            this.Lbl_FechaInicio.Text = "Fecha Inicio";
            // 
            // Lbl_Empleado
            // 
            this.Lbl_Empleado.AutoSize = true;
            this.Lbl_Empleado.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.Lbl_Empleado.Location = new System.Drawing.Point(38, 86);
            this.Lbl_Empleado.Name = "Lbl_Empleado";
            this.Lbl_Empleado.Size = new System.Drawing.Size(79, 17);
            this.Lbl_Empleado.TabIndex = 7;
            this.Lbl_Empleado.Text = "Empleado";
            // 
            // Pnl_encabezado
            // 
            this.Pnl_encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Pnl_encabezado.Controls.Add(this.Lbl_Nomina);
            this.Pnl_encabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_encabezado.Location = new System.Drawing.Point(0, 0);
            this.Pnl_encabezado.Name = "Pnl_encabezado";
            this.Pnl_encabezado.Size = new System.Drawing.Size(800, 100);
            this.Pnl_encabezado.TabIndex = 13;
            this.Pnl_encabezado.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_encabezado_Paint);
            // 
            // Lbl_Nomina
            // 
            this.Lbl_Nomina.AutoSize = true;
            this.Lbl_Nomina.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Nomina.Location = new System.Drawing.Point(20, 39);
            this.Lbl_Nomina.Name = "Lbl_Nomina";
            this.Lbl_Nomina.Size = new System.Drawing.Size(109, 27);
            this.Lbl_Nomina.TabIndex = 12;
            this.Lbl_Nomina.Text = "Nóminas";
            // 
            // SolicitarVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.Gpb_SolicitarV);
            this.Controls.Add(this.Pnl_encabezado);
            this.Name = "SolicitarVacaciones";
            this.Text = "Solicitar Vacaciones";
            this.Gpb_SolicitarV.ResumeLayout(false);
            this.Gpb_SolicitarV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Dias)).EndInit();
            this.Pnl_encabezado.ResumeLayout(false);
            this.Pnl_encabezado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_SolicitarV;
        private System.Windows.Forms.DateTimePicker Dtp_FechaF;
        private System.Windows.Forms.Label Lbl_FechaFinal;
        private System.Windows.Forms.ComboBox Cbo_Empleado;
        private System.Windows.Forms.NumericUpDown Nud_Dias;
        private System.Windows.Forms.DateTimePicker Dtp_FechaI;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label Lbl_Dias;
        private System.Windows.Forms.Label Lbl_FechaInicio;
        private System.Windows.Forms.Label Lbl_Empleado;
        private System.Windows.Forms.Panel Pnl_encabezado;
        private System.Windows.Forms.Label Lbl_Nomina;
    }
}