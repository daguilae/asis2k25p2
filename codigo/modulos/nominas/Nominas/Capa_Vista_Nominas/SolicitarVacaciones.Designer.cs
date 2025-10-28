
namespace Capa_Vista_Nominas
{
    partial class SolicitarVacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitarVacaciones));
            this.Gpb_SolicitarV = new System.Windows.Forms.GroupBox();
            this.Cbo_Empleado = new System.Windows.Forms.ComboBox();
            this.Nud_Dias = new System.Windows.Forms.NumericUpDown();
            this.Dtp_FechaI = new System.Windows.Forms.DateTimePicker();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Lbl_Dias = new System.Windows.Forms.Label();
            this.Lbl_FechaInicio = new System.Windows.Forms.Label();
            this.Lbl_Empleado = new System.Windows.Forms.Label();
            this.Lbl_FechaFinal = new System.Windows.Forms.Label();
            this.Dtp_FechaF = new System.Windows.Forms.DateTimePicker();
            this.Gpb_SolicitarV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Dias)).BeginInit();
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
            this.Gpb_SolicitarV.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_SolicitarV.Location = new System.Drawing.Point(9, 18);
            this.Gpb_SolicitarV.Name = "Gpb_SolicitarV";
            this.Gpb_SolicitarV.Size = new System.Drawing.Size(769, 358);
            this.Gpb_SolicitarV.TabIndex = 8;
            this.Gpb_SolicitarV.TabStop = false;
            this.Gpb_SolicitarV.Text = "Solicitar Vacaciones";
            // 
            // Cbo_Empleado
            // 
            this.Cbo_Empleado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Empleado.FormattingEnabled = true;
            this.Cbo_Empleado.Location = new System.Drawing.Point(126, 85);
            this.Cbo_Empleado.Name = "Cbo_Empleado";
            this.Cbo_Empleado.Size = new System.Drawing.Size(121, 25);
            this.Cbo_Empleado.TabIndex = 18;
            // 
            // Nud_Dias
            // 
            this.Nud_Dias.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nud_Dias.Location = new System.Drawing.Point(104, 205);
            this.Nud_Dias.Name = "Nud_Dias";
            this.Nud_Dias.Size = new System.Drawing.Size(120, 25);
            this.Nud_Dias.TabIndex = 17;
            // 
            // Dtp_FechaI
            // 
            this.Dtp_FechaI.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaI.Location = new System.Drawing.Point(149, 139);
            this.Dtp_FechaI.Name = "Dtp_FechaI";
            this.Dtp_FechaI.Size = new System.Drawing.Size(200, 25);
            this.Dtp_FechaI.TabIndex = 16;
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Regresar.Image")));
            this.Btn_Regresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Regresar.Location = new System.Drawing.Point(455, 271);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(89, 60);
            this.Btn_Regresar.TabIndex = 13;
            this.Btn_Regresar.Text = "Regresar";
            this.Btn_Regresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Regresar.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Guardar.Location = new System.Drawing.Point(360, 271);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(89, 60);
            this.Btn_Guardar.TabIndex = 12;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Lbl_Dias
            // 
            this.Lbl_Dias.AutoSize = true;
            this.Lbl_Dias.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dias.Location = new System.Drawing.Point(38, 207);
            this.Lbl_Dias.Name = "Lbl_Dias";
            this.Lbl_Dias.Size = new System.Drawing.Size(39, 17);
            this.Lbl_Dias.TabIndex = 9;
            this.Lbl_Dias.Text = "Dias";
            // 
            // Lbl_FechaInicio
            // 
            this.Lbl_FechaInicio.AutoSize = true;
            this.Lbl_FechaInicio.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaInicio.Location = new System.Drawing.Point(36, 145);
            this.Lbl_FechaInicio.Name = "Lbl_FechaInicio";
            this.Lbl_FechaInicio.Size = new System.Drawing.Size(95, 17);
            this.Lbl_FechaInicio.TabIndex = 8;
            this.Lbl_FechaInicio.Text = "Fecha Inicio";
            // 
            // Lbl_Empleado
            // 
            this.Lbl_Empleado.AutoSize = true;
            this.Lbl_Empleado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Empleado.Location = new System.Drawing.Point(38, 86);
            this.Lbl_Empleado.Name = "Lbl_Empleado";
            this.Lbl_Empleado.Size = new System.Drawing.Size(79, 17);
            this.Lbl_Empleado.TabIndex = 7;
            this.Lbl_Empleado.Text = "Empleado";
            // 
            // Lbl_FechaFinal
            // 
            this.Lbl_FechaFinal.AutoSize = true;
            this.Lbl_FechaFinal.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaFinal.Location = new System.Drawing.Point(419, 145);
            this.Lbl_FechaFinal.Name = "Lbl_FechaFinal";
            this.Lbl_FechaFinal.Size = new System.Drawing.Size(89, 17);
            this.Lbl_FechaFinal.TabIndex = 19;
            this.Lbl_FechaFinal.Text = "Fecha Final";
            // 
            // Dtp_FechaF
            // 
            this.Dtp_FechaF.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaF.Location = new System.Drawing.Point(525, 139);
            this.Dtp_FechaF.Name = "Dtp_FechaF";
            this.Dtp_FechaF.Size = new System.Drawing.Size(200, 25);
            this.Dtp_FechaF.TabIndex = 20;
            // 
            // SolicitarVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.Gpb_SolicitarV);
            this.Name = "SolicitarVacaciones";
            this.Text = "SolicitarVacaciones";
            this.Load += new System.EventHandler(this.SolicitarVacaciones_Load);
            this.Gpb_SolicitarV.ResumeLayout(false);
            this.Gpb_SolicitarV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Dias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_SolicitarV;
        private System.Windows.Forms.ComboBox Cbo_Empleado;
        private System.Windows.Forms.NumericUpDown Nud_Dias;
        private System.Windows.Forms.DateTimePicker Dtp_FechaI;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label Lbl_Dias;
        private System.Windows.Forms.Label Lbl_FechaInicio;
        private System.Windows.Forms.Label Lbl_Empleado;
        private System.Windows.Forms.DateTimePicker Dtp_FechaF;
        private System.Windows.Forms.Label Lbl_FechaFinal;
    }
}