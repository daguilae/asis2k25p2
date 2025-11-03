
namespace Capa_Vista_CPR
{
    partial class Frm_Cierre_Produccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cierre_Produccion));
            this.Gpb_Totales = new System.Windows.Forms.GroupBox();
            this.Txt_cierre_total = new System.Windows.Forms.TextBox();
            this.Txt_egresos = new System.Windows.Forms.TextBox();
            this.Txt_ingresos = new System.Windows.Forms.TextBox();
            this.lbl_Total_egresos = new System.Windows.Forms.Label();
            this.lbl_Total_ingreso = new System.Windows.Forms.Label();
            this.lbl_Total_Cierre = new System.Windows.Forms.Label();
            this.Btn_limpiar_cierre = new System.Windows.Forms.Button();
            this.Btn_eliminar_cierre = new System.Windows.Forms.Button();
            this.Btn_guardar_cierre = new System.Windows.Forms.Button();
            this.Btn_agregar_Cierre = new System.Windows.Forms.Button();
            this.Gpb_Datos_cierre = new System.Windows.Forms.GroupBox();
            this.Btn_Generar_Cierre = new System.Windows.Forms.Button();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_Descripción_Cierre = new System.Windows.Forms.Label();
            this.lbl_fecha_Cierre = new System.Windows.Forms.Label();
            this.Dtp_Fecha_cierre = new System.Windows.Forms.DateTimePicker();
            this.lbl_Tipo_cierre = new System.Windows.Forms.Label();
            this.Cbo_Tipo_Cierre = new System.Windows.Forms.ComboBox();
            this.lbl_Cierre_Produccion = new System.Windows.Forms.Label();
            this.Gpb_Totales.SuspendLayout();
            this.Gpb_Datos_cierre.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_Totales
            // 
            this.Gpb_Totales.Controls.Add(this.Txt_cierre_total);
            this.Gpb_Totales.Controls.Add(this.Txt_egresos);
            this.Gpb_Totales.Controls.Add(this.Txt_ingresos);
            this.Gpb_Totales.Controls.Add(this.lbl_Total_egresos);
            this.Gpb_Totales.Controls.Add(this.lbl_Total_ingreso);
            this.Gpb_Totales.Controls.Add(this.lbl_Total_Cierre);
            this.Gpb_Totales.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Totales.Location = new System.Drawing.Point(11, 263);
            this.Gpb_Totales.Name = "Gpb_Totales";
            this.Gpb_Totales.Size = new System.Drawing.Size(344, 169);
            this.Gpb_Totales.TabIndex = 32;
            this.Gpb_Totales.TabStop = false;
            this.Gpb_Totales.Text = "Totales Generales";
            // 
            // Txt_cierre_total
            // 
            this.Txt_cierre_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_cierre_total.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cierre_total.Location = new System.Drawing.Point(188, 115);
            this.Txt_cierre_total.Name = "Txt_cierre_total";
            this.Txt_cierre_total.ReadOnly = true;
            this.Txt_cierre_total.Size = new System.Drawing.Size(133, 29);
            this.Txt_cierre_total.TabIndex = 21;
            this.Txt_cierre_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_cierre_total.TextChanged += new System.EventHandler(this.Txt_cierre_total_TextChanged);
            // 
            // Txt_egresos
            // 
            this.Txt_egresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_egresos.Location = new System.Drawing.Point(188, 71);
            this.Txt_egresos.Name = "Txt_egresos";
            this.Txt_egresos.ReadOnly = true;
            this.Txt_egresos.Size = new System.Drawing.Size(133, 29);
            this.Txt_egresos.TabIndex = 20;
            this.Txt_egresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_egresos.TextChanged += new System.EventHandler(this.Txt_egresos_TextChanged);
            // 
            // Txt_ingresos
            // 
            this.Txt_ingresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_ingresos.Location = new System.Drawing.Point(188, 26);
            this.Txt_ingresos.Name = "Txt_ingresos";
            this.Txt_ingresos.ReadOnly = true;
            this.Txt_ingresos.Size = new System.Drawing.Size(133, 29);
            this.Txt_ingresos.TabIndex = 19;
            this.Txt_ingresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_ingresos.TextChanged += new System.EventHandler(this.Txt_ingresos_TextChanged);
            // 
            // lbl_Total_egresos
            // 
            this.lbl_Total_egresos.AutoSize = true;
            this.lbl_Total_egresos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_egresos.Location = new System.Drawing.Point(6, 74);
            this.lbl_Total_egresos.Name = "lbl_Total_egresos";
            this.lbl_Total_egresos.Size = new System.Drawing.Size(120, 20);
            this.lbl_Total_egresos.TabIndex = 13;
            this.lbl_Total_egresos.Text = "Total egresos:";
            // 
            // lbl_Total_ingreso
            // 
            this.lbl_Total_ingreso.AutoSize = true;
            this.lbl_Total_ingreso.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_ingreso.Location = new System.Drawing.Point(6, 29);
            this.lbl_Total_ingreso.Name = "lbl_Total_ingreso";
            this.lbl_Total_ingreso.Size = new System.Drawing.Size(125, 20);
            this.lbl_Total_ingreso.TabIndex = 4;
            this.lbl_Total_ingreso.Text = "Total ingresos:";
            // 
            // lbl_Total_Cierre
            // 
            this.lbl_Total_Cierre.AutoSize = true;
            this.lbl_Total_Cierre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Cierre.Location = new System.Drawing.Point(7, 118);
            this.lbl_Total_Cierre.Name = "lbl_Total_Cierre";
            this.lbl_Total_Cierre.Size = new System.Drawing.Size(104, 20);
            this.lbl_Total_Cierre.TabIndex = 12;
            this.lbl_Total_Cierre.Text = "Total Cierre";
            // 
            // Btn_limpiar_cierre
            // 
            this.Btn_limpiar_cierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_limpiar_cierre.Font = new System.Drawing.Font("Rockwell", 9.5F);
            this.Btn_limpiar_cierre.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_limpiar_cierre.Image = global::Capa_Vista_CPR.Properties.Resources.icono_limpiar__1_;
            this.Btn_limpiar_cierre.Location = new System.Drawing.Point(789, 30);
            this.Btn_limpiar_cierre.Name = "Btn_limpiar_cierre";
            this.Btn_limpiar_cierre.Size = new System.Drawing.Size(53, 44);
            this.Btn_limpiar_cierre.TabIndex = 31;
            this.Btn_limpiar_cierre.UseVisualStyleBackColor = false;
            this.Btn_limpiar_cierre.Click += new System.EventHandler(this.Btn_limpiar_cierre_Click);
            // 
            // Btn_eliminar_cierre
            // 
            this.Btn_eliminar_cierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_eliminar_cierre.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_eliminar_cierre.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_eliminar_cierre.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar_cierre.Image")));
            this.Btn_eliminar_cierre.Location = new System.Drawing.Point(671, 28);
            this.Btn_eliminar_cierre.Name = "Btn_eliminar_cierre";
            this.Btn_eliminar_cierre.Size = new System.Drawing.Size(53, 46);
            this.Btn_eliminar_cierre.TabIndex = 28;
            this.Btn_eliminar_cierre.UseVisualStyleBackColor = false;
            this.Btn_eliminar_cierre.Click += new System.EventHandler(this.Btn_eliminar_cierre_Click);
            // 
            // Btn_guardar_cierre
            // 
            this.Btn_guardar_cierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_guardar_cierre.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_guardar_cierre.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_guardar_cierre.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar_cierre.Image")));
            this.Btn_guardar_cierre.Location = new System.Drawing.Point(730, 29);
            this.Btn_guardar_cierre.Name = "Btn_guardar_cierre";
            this.Btn_guardar_cierre.Size = new System.Drawing.Size(53, 45);
            this.Btn_guardar_cierre.TabIndex = 29;
            this.Btn_guardar_cierre.UseVisualStyleBackColor = false;
            this.Btn_guardar_cierre.Click += new System.EventHandler(this.Btn_guardar_cierre_Click);
            // 
            // Btn_agregar_Cierre
            // 
            this.Btn_agregar_Cierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_agregar_Cierre.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_agregar_Cierre.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_agregar_Cierre.Image = ((System.Drawing.Image)(resources.GetObject("Btn_agregar_Cierre.Image")));
            this.Btn_agregar_Cierre.Location = new System.Drawing.Point(612, 28);
            this.Btn_agregar_Cierre.Name = "Btn_agregar_Cierre";
            this.Btn_agregar_Cierre.Size = new System.Drawing.Size(53, 46);
            this.Btn_agregar_Cierre.TabIndex = 27;
            this.Btn_agregar_Cierre.UseVisualStyleBackColor = false;
            this.Btn_agregar_Cierre.Click += new System.EventHandler(this.Btn_agregar_Cierre_Click);
            // 
            // Gpb_Datos_cierre
            // 
            this.Gpb_Datos_cierre.Controls.Add(this.Btn_Generar_Cierre);
            this.Gpb_Datos_cierre.Controls.Add(this.Txt_Descripcion);
            this.Gpb_Datos_cierre.Controls.Add(this.lbl_Descripción_Cierre);
            this.Gpb_Datos_cierre.Controls.Add(this.lbl_fecha_Cierre);
            this.Gpb_Datos_cierre.Controls.Add(this.Dtp_Fecha_cierre);
            this.Gpb_Datos_cierre.Controls.Add(this.lbl_Tipo_cierre);
            this.Gpb_Datos_cierre.Controls.Add(this.Cbo_Tipo_Cierre);
            this.Gpb_Datos_cierre.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Datos_cierre.Location = new System.Drawing.Point(11, 80);
            this.Gpb_Datos_cierre.Name = "Gpb_Datos_cierre";
            this.Gpb_Datos_cierre.Size = new System.Drawing.Size(829, 177);
            this.Gpb_Datos_cierre.TabIndex = 30;
            this.Gpb_Datos_cierre.TabStop = false;
            this.Gpb_Datos_cierre.Text = "Datos de cierre";
            // 
            // Btn_Generar_Cierre
            // 
            this.Btn_Generar_Cierre.Location = new System.Drawing.Point(614, 129);
            this.Btn_Generar_Cierre.Name = "Btn_Generar_Cierre";
            this.Btn_Generar_Cierre.Size = new System.Drawing.Size(195, 32);
            this.Btn_Generar_Cierre.TabIndex = 18;
            this.Btn_Generar_Cierre.Text = "Generar";
            this.Btn_Generar_Cierre.UseVisualStyleBackColor = true;
            this.Btn_Generar_Cierre.Click += new System.EventHandler(this.Btn_Generar_Cierre_Click);
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(144, 78);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(296, 83);
            this.Txt_Descripcion.TabIndex = 17;
            this.Txt_Descripcion.TextChanged += new System.EventHandler(this.Txt_Descripcion_TextChanged);
            // 
            // lbl_Descripción_Cierre
            // 
            this.lbl_Descripción_Cierre.AutoSize = true;
            this.lbl_Descripción_Cierre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripción_Cierre.Location = new System.Drawing.Point(6, 78);
            this.lbl_Descripción_Cierre.Name = "lbl_Descripción_Cierre";
            this.lbl_Descripción_Cierre.Size = new System.Drawing.Size(109, 20);
            this.lbl_Descripción_Cierre.TabIndex = 16;
            this.lbl_Descripción_Cierre.Text = "Descripción:";
            // 
            // lbl_fecha_Cierre
            // 
            this.lbl_fecha_Cierre.AutoSize = true;
            this.lbl_fecha_Cierre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_Cierre.Location = new System.Drawing.Point(6, 29);
            this.lbl_fecha_Cierre.Name = "lbl_fecha_Cierre";
            this.lbl_fecha_Cierre.Size = new System.Drawing.Size(117, 20);
            this.lbl_fecha_Cierre.TabIndex = 4;
            this.lbl_fecha_Cierre.Text = "Fecha Cierre:";
            // 
            // Dtp_Fecha_cierre
            // 
            this.Dtp_Fecha_cierre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha_cierre.Location = new System.Drawing.Point(152, 29);
            this.Dtp_Fecha_cierre.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.Dtp_Fecha_cierre.MinDate = new System.DateTime(1912, 1, 1, 0, 0, 0, 0);
            this.Dtp_Fecha_cierre.Name = "Dtp_Fecha_cierre";
            this.Dtp_Fecha_cierre.Size = new System.Drawing.Size(208, 29);
            this.Dtp_Fecha_cierre.TabIndex = 3;
            this.Dtp_Fecha_cierre.Value = new System.DateTime(2025, 10, 30, 16, 34, 29, 0);
            this.Dtp_Fecha_cierre.ValueChanged += new System.EventHandler(this.Dtp_Fecha_cierre_ValueChanged);
            // 
            // lbl_Tipo_cierre
            // 
            this.lbl_Tipo_cierre.AutoSize = true;
            this.lbl_Tipo_cierre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tipo_cierre.Location = new System.Drawing.Point(460, 31);
            this.lbl_Tipo_cierre.Name = "lbl_Tipo_cierre";
            this.lbl_Tipo_cierre.Size = new System.Drawing.Size(125, 20);
            this.lbl_Tipo_cierre.TabIndex = 12;
            this.lbl_Tipo_cierre.Text = "Tipo de cierre:";
            // 
            // Cbo_Tipo_Cierre
            // 
            this.Cbo_Tipo_Cierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.Cbo_Tipo_Cierre.FormattingEnabled = true;
            this.Cbo_Tipo_Cierre.Location = new System.Drawing.Point(601, 28);
            this.Cbo_Tipo_Cierre.Name = "Cbo_Tipo_Cierre";
            this.Cbo_Tipo_Cierre.Size = new System.Drawing.Size(178, 28);
            this.Cbo_Tipo_Cierre.TabIndex = 15;
            this.Cbo_Tipo_Cierre.SelectedIndexChanged += new System.EventHandler(this.Cbo_Tipo_Cierre_SelectedIndexChanged);
            // 
            // lbl_Cierre_Produccion
            // 
            this.lbl_Cierre_Produccion.AutoSize = true;
            this.lbl_Cierre_Produccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(196)))), ((int)(((byte)(210)))));
            this.lbl_Cierre_Produccion.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cierre_Produccion.Location = new System.Drawing.Point(5, 19);
            this.lbl_Cierre_Produccion.Name = "lbl_Cierre_Produccion";
            this.lbl_Cierre_Produccion.Size = new System.Drawing.Size(282, 35);
            this.lbl_Cierre_Produccion.TabIndex = 26;
            this.lbl_Cierre_Produccion.Text = "Cierre Producción.";
            // 
            // Frm_Cierre_Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(196)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(865, 457);
            this.Controls.Add(this.Gpb_Totales);
            this.Controls.Add(this.Btn_limpiar_cierre);
            this.Controls.Add(this.Btn_eliminar_cierre);
            this.Controls.Add(this.Btn_guardar_cierre);
            this.Controls.Add(this.Btn_agregar_Cierre);
            this.Controls.Add(this.Gpb_Datos_cierre);
            this.Controls.Add(this.lbl_Cierre_Produccion);
            this.Name = "Frm_Cierre_Produccion";
            this.Text = "Frm_Cierre_Produccion";
            this.Gpb_Totales.ResumeLayout(false);
            this.Gpb_Totales.PerformLayout();
            this.Gpb_Datos_cierre.ResumeLayout(false);
            this.Gpb_Datos_cierre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_Totales;
        private System.Windows.Forms.TextBox Txt_cierre_total;
        private System.Windows.Forms.TextBox Txt_egresos;
        private System.Windows.Forms.TextBox Txt_ingresos;
        private System.Windows.Forms.Label lbl_Total_egresos;
        private System.Windows.Forms.Label lbl_Total_ingreso;
        private System.Windows.Forms.Label lbl_Total_Cierre;
        private System.Windows.Forms.Button Btn_limpiar_cierre;
        private System.Windows.Forms.Button Btn_eliminar_cierre;
        private System.Windows.Forms.Button Btn_guardar_cierre;
        private System.Windows.Forms.Button Btn_agregar_Cierre;
        private System.Windows.Forms.GroupBox Gpb_Datos_cierre;
        private System.Windows.Forms.Button Btn_Generar_Cierre;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.Label lbl_Descripción_Cierre;
        private System.Windows.Forms.Label lbl_fecha_Cierre;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_cierre;
        private System.Windows.Forms.Label lbl_Tipo_cierre;
        private System.Windows.Forms.ComboBox Cbo_Tipo_Cierre;
        private System.Windows.Forms.Label lbl_Cierre_Produccion;
    }
}