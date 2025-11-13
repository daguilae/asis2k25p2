
namespace Capa_Vista_Cheques_Panilla
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Txt_Fecha = new System.Windows.Forms.TextBox();
            this.Lbl_Moneda = new System.Windows.Forms.Label();
            this.Txt_Moneda = new System.Windows.Forms.TextBox();
            this.Lbl_Monto = new System.Windows.Forms.Label();
            this.Txt_Monto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Banco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_planilla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Dgv_Detalle_Empleados = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 31);
            this.label2.TabIndex = 37;
            this.label2.Text = "Generacion de Cheques Planilla";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(16, 66);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(145, 24);
            this.Lbl_Fecha.TabIndex = 38;
            this.Lbl_Fecha.Text = "Fecha de pago:";
            // 
            // Txt_Fecha
            // 
            this.Txt_Fecha.Location = new System.Drawing.Point(207, 66);
            this.Txt_Fecha.Name = "Txt_Fecha";
            this.Txt_Fecha.Size = new System.Drawing.Size(143, 22);
            this.Txt_Fecha.TabIndex = 45;
            // 
            // Lbl_Moneda
            // 
            this.Lbl_Moneda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Moneda.AutoSize = true;
            this.Lbl_Moneda.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Moneda.Location = new System.Drawing.Point(420, 112);
            this.Lbl_Moneda.Name = "Lbl_Moneda";
            this.Lbl_Moneda.Size = new System.Drawing.Size(89, 24);
            this.Lbl_Moneda.TabIndex = 51;
            this.Lbl_Moneda.Text = "Moneda:";
            // 
            // Txt_Moneda
            // 
            this.Txt_Moneda.Location = new System.Drawing.Point(515, 112);
            this.Txt_Moneda.Name = "Txt_Moneda";
            this.Txt_Moneda.Size = new System.Drawing.Size(59, 22);
            this.Txt_Moneda.TabIndex = 53;
            // 
            // Lbl_Monto
            // 
            this.Lbl_Monto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Monto.AutoSize = true;
            this.Lbl_Monto.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Monto.Location = new System.Drawing.Point(420, 140);
            this.Lbl_Monto.Name = "Lbl_Monto";
            this.Lbl_Monto.Size = new System.Drawing.Size(75, 24);
            this.Lbl_Monto.TabIndex = 61;
            this.Lbl_Monto.Text = "Monto:";
            // 
            // Txt_Monto
            // 
            this.Txt_Monto.Location = new System.Drawing.Point(515, 140);
            this.Txt_Monto.Name = "Txt_Monto";
            this.Txt_Monto.Size = new System.Drawing.Size(143, 22);
            this.Txt_Monto.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 63;
            this.label1.Text = "Banco:";
            // 
            // Txt_Banco
            // 
            this.Txt_Banco.Location = new System.Drawing.Point(494, 66);
            this.Txt_Banco.Name = "Txt_Banco";
            this.Txt_Banco.Size = new System.Drawing.Size(143, 22);
            this.Txt_Banco.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 65;
            this.label3.Text = "Número de planilla:";
            // 
            // Txt_planilla
            // 
            this.Txt_planilla.Location = new System.Drawing.Point(207, 114);
            this.Txt_planilla.Name = "Txt_planilla";
            this.Txt_planilla.Size = new System.Drawing.Size(143, 22);
            this.Txt_planilla.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 81;
            this.label4.Text = "lote de pago:";
            // 
            // Dgv_Detalle_Empleados
            // 
            this.Dgv_Detalle_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Detalle_Empleados.Location = new System.Drawing.Point(19, 284);
            this.Dgv_Detalle_Empleados.Name = "Dgv_Detalle_Empleados";
            this.Dgv_Detalle_Empleados.RowHeadersWidth = 51;
            this.Dgv_Detalle_Empleados.RowTemplate.Height = 24;
            this.Dgv_Detalle_Empleados.Size = new System.Drawing.Size(961, 308);
            this.Dgv_Detalle_Empleados.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 83;
            this.label5.Text = "Total:  Q.";
            // 
            // Txt_Total
            // 
            this.Txt_Total.Location = new System.Drawing.Point(207, 182);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.Size = new System.Drawing.Size(143, 22);
            this.Txt_Total.TabIndex = 84;
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reporte.Image = global::Capa_Vista_Cheques_Panilla.Properties.Resources.print_black_printer_tool_symbol_icon_icons_com_54467;
            this.Btn_Reporte.Location = new System.Drawing.Point(779, 210);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(68, 51);
            this.Btn_Reporte.TabIndex = 89;
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Image = global::Capa_Vista_Cheques_Panilla.Properties.Resources.delete_remove_trash_icon_177304;
            this.Btn_Eliminar.Location = new System.Drawing.Point(711, 210);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(62, 51);
            this.Btn_Eliminar.TabIndex = 88;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayuda.Image = global::Capa_Vista_Cheques_Panilla.Properties.Resources.help_question_16768;
            this.Btn_Ayuda.Location = new System.Drawing.Point(853, 210);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(64, 51);
            this.Btn_Ayuda.TabIndex = 85;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Image = global::Capa_Vista_Cheques_Panilla.Properties.Resources.savetheapplication_guardar_2958;
            this.Btn_Guardar.Location = new System.Drawing.Point(639, 210);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(66, 51);
            this.Btn_Guardar.TabIndex = 86;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Image = global::Capa_Vista_Cheques_Panilla.Properties.Resources.add_insert_new_plus_button_icon_142943;
            this.Btn_Agregar.Location = new System.Drawing.Point(572, 210);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(56, 51);
            this.Btn_Agregar.TabIndex = 80;
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 604);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Txt_Total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dgv_Detalle_Empleados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.Txt_planilla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Banco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Monto);
            this.Controls.Add(this.Lbl_Monto);
            this.Controls.Add(this.Txt_Moneda);
            this.Controls.Add(this.Lbl_Moneda);
            this.Controls.Add(this.Txt_Fecha);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.TextBox Txt_Fecha;
        private System.Windows.Forms.Label Lbl_Moneda;
        private System.Windows.Forms.TextBox Txt_Moneda;
        private System.Windows.Forms.Label Lbl_Monto;
        private System.Windows.Forms.TextBox Txt_Monto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Banco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_planilla;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Dgv_Detalle_Empleados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Ayuda;
    }
}