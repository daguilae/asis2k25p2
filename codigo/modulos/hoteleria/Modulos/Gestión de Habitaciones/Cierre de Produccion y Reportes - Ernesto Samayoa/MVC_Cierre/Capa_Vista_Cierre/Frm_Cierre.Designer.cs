
namespace Capa_Vista_Cierre
{
    partial class Frm_Cierre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cierre));
            this.lbl_Cierre_Produccion = new System.Windows.Forms.Label();
            this.Gpb_Datos_cierre = new System.Windows.Forms.GroupBox();
            this.Txt_Descripcion_Cierre = new System.Windows.Forms.TextBox();
            this.lbl_Descripción_Cierre = new System.Windows.Forms.Label();
            this.lbl_fecha_Cierre = new System.Windows.Forms.Label();
            this.Dtp_Fecha_Cierre = new System.Windows.Forms.DateTimePicker();
            this.Gpb_Totales = new System.Windows.Forms.GroupBox();
            this.Txt_Saldo_total = new System.Windows.Forms.TextBox();
            this.Txt_egresos = new System.Windows.Forms.TextBox();
            this.Btn_generar = new System.Windows.Forms.Button();
            this.Txt_ingresos = new System.Windows.Forms.TextBox();
            this.lbl_Total_egresos = new System.Windows.Forms.Label();
            this.lbl_Total_ingreso = new System.Windows.Forms.Label();
            this.lbl_Saldo_Total = new System.Windows.Forms.Label();
            this.lbl_Listado_cierre = new System.Windows.Forms.Label();
            this.Dgv_Cierre_general = new System.Windows.Forms.DataGridView();
            this.Btn_Buscar_cierre = new System.Windows.Forms.Button();
            this.Btn_Imprimir_cierre_general = new System.Windows.Forms.Button();
            this.Btn_eliminar_cierre = new System.Windows.Forms.Button();
            this.Btn_guardar_cierre = new System.Windows.Forms.Button();
            this.Btn_Agregar_cierre = new System.Windows.Forms.Button();
            this.Cbo_buscar = new System.Windows.Forms.ComboBox();
            this.lbl_buscar_cierre = new System.Windows.Forms.Label();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Gpb_Datos_cierre.SuspendLayout();
            this.Gpb_Totales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cierre_general)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Cierre_Produccion
            // 
            this.lbl_Cierre_Produccion.AutoSize = true;
            this.lbl_Cierre_Produccion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cierre_Produccion.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cierre_Produccion.Location = new System.Drawing.Point(12, 18);
            this.lbl_Cierre_Produccion.Name = "lbl_Cierre_Produccion";
            this.lbl_Cierre_Produccion.Size = new System.Drawing.Size(210, 35);
            this.lbl_Cierre_Produccion.TabIndex = 27;
            this.lbl_Cierre_Produccion.Text = "Cierre Diario.";
            // 
            // Gpb_Datos_cierre
            // 
            this.Gpb_Datos_cierre.Controls.Add(this.Txt_Descripcion_Cierre);
            this.Gpb_Datos_cierre.Controls.Add(this.lbl_Descripción_Cierre);
            this.Gpb_Datos_cierre.Controls.Add(this.lbl_fecha_Cierre);
            this.Gpb_Datos_cierre.Controls.Add(this.Dtp_Fecha_Cierre);
            this.Gpb_Datos_cierre.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Datos_cierre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gpb_Datos_cierre.Location = new System.Drawing.Point(18, 68);
            this.Gpb_Datos_cierre.Name = "Gpb_Datos_cierre";
            this.Gpb_Datos_cierre.Size = new System.Drawing.Size(785, 97);
            this.Gpb_Datos_cierre.TabIndex = 31;
            this.Gpb_Datos_cierre.TabStop = false;
            this.Gpb_Datos_cierre.Text = "Datos de cierre";
            // 
            // Txt_Descripcion_Cierre
            // 
            this.Txt_Descripcion_Cierre.Location = new System.Drawing.Point(454, 26);
            this.Txt_Descripcion_Cierre.Multiline = true;
            this.Txt_Descripcion_Cierre.Name = "Txt_Descripcion_Cierre";
            this.Txt_Descripcion_Cierre.Size = new System.Drawing.Size(319, 52);
            this.Txt_Descripcion_Cierre.TabIndex = 17;
            // 
            // lbl_Descripción_Cierre
            // 
            this.lbl_Descripción_Cierre.AutoSize = true;
            this.lbl_Descripción_Cierre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripción_Cierre.Location = new System.Drawing.Point(339, 29);
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
            // Dtp_Fecha_Cierre
            // 
            this.Dtp_Fecha_Cierre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha_Cierre.Location = new System.Drawing.Point(148, 28);
            this.Dtp_Fecha_Cierre.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.Dtp_Fecha_Cierre.MinDate = new System.DateTime(1912, 1, 1, 0, 0, 0, 0);
            this.Dtp_Fecha_Cierre.Name = "Dtp_Fecha_Cierre";
            this.Dtp_Fecha_Cierre.Size = new System.Drawing.Size(162, 29);
            this.Dtp_Fecha_Cierre.TabIndex = 3;
            this.Dtp_Fecha_Cierre.Value = new System.DateTime(2025, 11, 1, 0, 0, 0, 0);
            // 
            // Gpb_Totales
            // 
            this.Gpb_Totales.Controls.Add(this.Txt_Saldo_total);
            this.Gpb_Totales.Controls.Add(this.Txt_egresos);
            this.Gpb_Totales.Controls.Add(this.Btn_generar);
            this.Gpb_Totales.Controls.Add(this.Txt_ingresos);
            this.Gpb_Totales.Controls.Add(this.lbl_Total_egresos);
            this.Gpb_Totales.Controls.Add(this.lbl_Total_ingreso);
            this.Gpb_Totales.Controls.Add(this.lbl_Saldo_Total);
            this.Gpb_Totales.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Totales.Location = new System.Drawing.Point(18, 171);
            this.Gpb_Totales.Name = "Gpb_Totales";
            this.Gpb_Totales.Size = new System.Drawing.Size(1008, 108);
            this.Gpb_Totales.TabIndex = 33;
            this.Gpb_Totales.TabStop = false;
            this.Gpb_Totales.Text = "Totales Generales";
            // 
            // Txt_Saldo_total
            // 
            this.Txt_Saldo_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_Saldo_total.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Saldo_total.Location = new System.Drawing.Point(650, 45);
            this.Txt_Saldo_total.Name = "Txt_Saldo_total";
            this.Txt_Saldo_total.ReadOnly = true;
            this.Txt_Saldo_total.Size = new System.Drawing.Size(164, 29);
            this.Txt_Saldo_total.TabIndex = 21;
            this.Txt_Saldo_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txt_egresos
            // 
            this.Txt_egresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_egresos.Location = new System.Drawing.Point(178, 71);
            this.Txt_egresos.Name = "Txt_egresos";
            this.Txt_egresos.ReadOnly = true;
            this.Txt_egresos.Size = new System.Drawing.Size(133, 29);
            this.Txt_egresos.TabIndex = 20;
            this.Txt_egresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn_generar
            // 
            this.Btn_generar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_generar.Location = new System.Drawing.Point(890, 71);
            this.Btn_generar.Name = "Btn_generar";
            this.Btn_generar.Size = new System.Drawing.Size(101, 32);
            this.Btn_generar.TabIndex = 44;
            this.Btn_generar.Text = "Generar";
            this.Btn_generar.UseVisualStyleBackColor = true;
            this.Btn_generar.Click += new System.EventHandler(this.Btn_generar_Click);
            // 
            // Txt_ingresos
            // 
            this.Txt_ingresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_ingresos.Location = new System.Drawing.Point(178, 26);
            this.Txt_ingresos.Name = "Txt_ingresos";
            this.Txt_ingresos.ReadOnly = true;
            this.Txt_ingresos.Size = new System.Drawing.Size(133, 29);
            this.Txt_ingresos.TabIndex = 19;
            this.Txt_ingresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // lbl_Saldo_Total
            // 
            this.lbl_Saldo_Total.AutoSize = true;
            this.lbl_Saldo_Total.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saldo_Total.Location = new System.Drawing.Point(541, 45);
            this.lbl_Saldo_Total.Name = "lbl_Saldo_Total";
            this.lbl_Saldo_Total.Size = new System.Drawing.Size(95, 20);
            this.lbl_Saldo_Total.TabIndex = 12;
            this.lbl_Saldo_Total.Text = "Saldo Total";
            // 
            // lbl_Listado_cierre
            // 
            this.lbl_Listado_cierre.AutoSize = true;
            this.lbl_Listado_cierre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Listado_cierre.Location = new System.Drawing.Point(41, 288);
            this.lbl_Listado_cierre.Name = "lbl_Listado_cierre";
            this.lbl_Listado_cierre.Size = new System.Drawing.Size(141, 20);
            this.lbl_Listado_cierre.TabIndex = 34;
            this.lbl_Listado_cierre.Text = "Listado de cierre";
            // 
            // Dgv_Cierre_general
            // 
            this.Dgv_Cierre_general.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Cierre_general.Location = new System.Drawing.Point(45, 311);
            this.Dgv_Cierre_general.Name = "Dgv_Cierre_general";
            this.Dgv_Cierre_general.RowHeadersWidth = 51;
            this.Dgv_Cierre_general.RowTemplate.Height = 24;
            this.Dgv_Cierre_general.Size = new System.Drawing.Size(1075, 150);
            this.Dgv_Cierre_general.TabIndex = 35;
            // 
            // Btn_Buscar_cierre
            // 
            this.Btn_Buscar_cierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Buscar_cierre.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Buscar_cierre.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Buscar_cierre.Image = global::Capa_Vista_Cierre.Properties.Resources.icono_buscar;
            this.Btn_Buscar_cierre.Location = new System.Drawing.Point(923, 12);
            this.Btn_Buscar_cierre.Name = "Btn_Buscar_cierre";
            this.Btn_Buscar_cierre.Size = new System.Drawing.Size(65, 51);
            this.Btn_Buscar_cierre.TabIndex = 43;
            this.Btn_Buscar_cierre.UseVisualStyleBackColor = false;
            this.Btn_Buscar_cierre.Click += new System.EventHandler(this.Btn_Buscar_cierre_Click);
            // 
            // Btn_Imprimir_cierre_general
            // 
            this.Btn_Imprimir_cierre_general.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Imprimir_cierre_general.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Imprimir_cierre_general.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Imprimir_cierre_general.Image = global::Capa_Vista_Cierre.Properties.Resources.icono_imprimir;
            this.Btn_Imprimir_cierre_general.Location = new System.Drawing.Point(1074, 12);
            this.Btn_Imprimir_cierre_general.Name = "Btn_Imprimir_cierre_general";
            this.Btn_Imprimir_cierre_general.Size = new System.Drawing.Size(65, 51);
            this.Btn_Imprimir_cierre_general.TabIndex = 42;
            this.Btn_Imprimir_cierre_general.UseVisualStyleBackColor = false;
            this.Btn_Imprimir_cierre_general.Click += new System.EventHandler(this.Btn_Imprimir_cierre_general_Click_1);
            // 
            // Btn_eliminar_cierre
            // 
            this.Btn_eliminar_cierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_eliminar_cierre.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_eliminar_cierre.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_eliminar_cierre.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar_cierre.Image")));
            this.Btn_eliminar_cierre.Location = new System.Drawing.Point(853, 12);
            this.Btn_eliminar_cierre.Name = "Btn_eliminar_cierre";
            this.Btn_eliminar_cierre.Size = new System.Drawing.Size(65, 51);
            this.Btn_eliminar_cierre.TabIndex = 39;
            this.Btn_eliminar_cierre.UseVisualStyleBackColor = false;
            this.Btn_eliminar_cierre.Click += new System.EventHandler(this.Btn_eliminar_cierre_Click);
            // 
            // Btn_guardar_cierre
            // 
            this.Btn_guardar_cierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_guardar_cierre.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_guardar_cierre.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_guardar_cierre.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar_cierre.Image")));
            this.Btn_guardar_cierre.Location = new System.Drawing.Point(783, 12);
            this.Btn_guardar_cierre.Name = "Btn_guardar_cierre";
            this.Btn_guardar_cierre.Size = new System.Drawing.Size(65, 51);
            this.Btn_guardar_cierre.TabIndex = 40;
            this.Btn_guardar_cierre.UseVisualStyleBackColor = false;
            this.Btn_guardar_cierre.Click += new System.EventHandler(this.Btn_guardar_cierre_Click);
            // 
            // Btn_Agregar_cierre
            // 
            this.Btn_Agregar_cierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Agregar_cierre.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Agregar_cierre.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Agregar_cierre.Image = global::Capa_Vista_Cierre.Properties.Resources.icono_agregar;
            this.Btn_Agregar_cierre.Location = new System.Drawing.Point(713, 12);
            this.Btn_Agregar_cierre.Name = "Btn_Agregar_cierre";
            this.Btn_Agregar_cierre.Size = new System.Drawing.Size(65, 51);
            this.Btn_Agregar_cierre.TabIndex = 45;
            this.Btn_Agregar_cierre.UseVisualStyleBackColor = false;
            this.Btn_Agregar_cierre.Click += new System.EventHandler(this.Btn_Agregar_cierre_Click);
            // 
            // Cbo_buscar
            // 
            this.Cbo_buscar.FormattingEnabled = true;
            this.Cbo_buscar.Location = new System.Drawing.Point(892, 114);
            this.Cbo_buscar.Name = "Cbo_buscar";
            this.Cbo_buscar.Size = new System.Drawing.Size(228, 24);
            this.Cbo_buscar.TabIndex = 46;
            this.Cbo_buscar.SelectedIndexChanged += new System.EventHandler(this.Cbo_buscar_SelectedIndexChanged);
            // 
            // lbl_buscar_cierre
            // 
            this.lbl_buscar_cierre.AutoSize = true;
            this.lbl_buscar_cierre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar_cierre.Location = new System.Drawing.Point(819, 118);
            this.lbl_buscar_cierre.Name = "lbl_buscar_cierre";
            this.lbl_buscar_cierre.Size = new System.Drawing.Size(67, 20);
            this.lbl_buscar_cierre.TabIndex = 18;
            this.lbl_buscar_cierre.Text = "Buscar:";
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_cancelar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_cancelar.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_cancelar.Image = global::Capa_Vista_Cierre.Properties.Resources.icono_cancelar;
            this.Btn_cancelar.Location = new System.Drawing.Point(994, 12);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(65, 51);
            this.Btn_cancelar.TabIndex = 47;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Frm_Cierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 485);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.lbl_buscar_cierre);
            this.Controls.Add(this.Cbo_buscar);
            this.Controls.Add(this.Btn_Agregar_cierre);
            this.Controls.Add(this.Btn_Buscar_cierre);
            this.Controls.Add(this.Btn_Imprimir_cierre_general);
            this.Controls.Add(this.Btn_eliminar_cierre);
            this.Controls.Add(this.Btn_guardar_cierre);
            this.Controls.Add(this.lbl_Listado_cierre);
            this.Controls.Add(this.Dgv_Cierre_general);
            this.Controls.Add(this.Gpb_Totales);
            this.Controls.Add(this.Gpb_Datos_cierre);
            this.Controls.Add(this.lbl_Cierre_Produccion);
            this.Name = "Frm_Cierre";
            this.Text = "Frm_Cierre";
            this.Load += new System.EventHandler(this.Frm_Cierre_Load);
            this.Gpb_Datos_cierre.ResumeLayout(false);
            this.Gpb_Datos_cierre.PerformLayout();
            this.Gpb_Totales.ResumeLayout(false);
            this.Gpb_Totales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cierre_general)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Cierre_Produccion;
        private System.Windows.Forms.GroupBox Gpb_Datos_cierre;
        private System.Windows.Forms.TextBox Txt_Descripcion_Cierre;
        private System.Windows.Forms.Label lbl_Descripción_Cierre;
        private System.Windows.Forms.Label lbl_fecha_Cierre;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Cierre;
        private System.Windows.Forms.GroupBox Gpb_Totales;
        private System.Windows.Forms.TextBox Txt_Saldo_total;
        private System.Windows.Forms.TextBox Txt_egresos;
        private System.Windows.Forms.TextBox Txt_ingresos;
        private System.Windows.Forms.Label lbl_Total_egresos;
        private System.Windows.Forms.Label lbl_Total_ingreso;
        private System.Windows.Forms.Label lbl_Saldo_Total;
        private System.Windows.Forms.Label lbl_Listado_cierre;
        private System.Windows.Forms.DataGridView Dgv_Cierre_general;
        private System.Windows.Forms.Button Btn_Buscar_cierre;
        private System.Windows.Forms.Button Btn_Imprimir_cierre_general;
        private System.Windows.Forms.Button Btn_eliminar_cierre;
        private System.Windows.Forms.Button Btn_guardar_cierre;
        private System.Windows.Forms.Button Btn_generar;
        private System.Windows.Forms.Button Btn_Agregar_cierre;
        private System.Windows.Forms.ComboBox Cbo_buscar;
        private System.Windows.Forms.Label lbl_buscar_cierre;
        private System.Windows.Forms.Button Btn_cancelar;
    }
}