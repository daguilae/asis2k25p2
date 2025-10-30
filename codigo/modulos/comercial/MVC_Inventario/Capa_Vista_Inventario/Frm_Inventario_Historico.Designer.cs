
namespace Capa_Vista_Inventario
{
    partial class Frm_Inventario_Historico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pnl_Herramientas = new System.Windows.Forms.Panel();
            this.Lbl_Inventarios_Pasados = new System.Windows.Forms.Label();
            this.Gpb_Buscar_Inventario_Pasado = new System.Windows.Forms.GroupBox();
            this.Btn_Buscar_Inventario = new System.Windows.Forms.Button();
            this.Gpb_Gestion_Inventario = new System.Windows.Forms.GroupBox();
            this.Btn_Nuevo_Inventario = new System.Windows.Forms.Button();
            this.Btn_Imprimir_PDF = new System.Windows.Forms.Button();
            this.Gpb_Filtros = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Rdb_Filtro_Mas_Recientes = new System.Windows.Forms.RadioButton();
            this.Rdb_Filtro_Menos_Recientes = new System.Windows.Forms.RadioButton();
            this.Pnl_Vista_Inventarios_Pasados = new System.Windows.Forms.Panel();
            this.Dgv_Vista_Inventarios_Pasados = new System.Windows.Forms.DataGridView();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Cbo_Tipo_Operacion = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.Pnl_Herramientas.SuspendLayout();
            this.Gpb_Buscar_Inventario_Pasado.SuspendLayout();
            this.Gpb_Gestion_Inventario.SuspendLayout();
            this.Gpb_Filtros.SuspendLayout();
            this.Pnl_Vista_Inventarios_Pasados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Vista_Inventarios_Pasados)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Herramientas
            // 
            this.Pnl_Herramientas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Herramientas.Controls.Add(this.Btn_Buscar_Inventario);
            this.Pnl_Herramientas.Controls.Add(this.Lbl_Inventarios_Pasados);
            this.Pnl_Herramientas.Controls.Add(this.Gpb_Buscar_Inventario_Pasado);
            this.Pnl_Herramientas.Controls.Add(this.Gpb_Gestion_Inventario);
            this.Pnl_Herramientas.Controls.Add(this.Gpb_Filtros);
            this.Pnl_Herramientas.Location = new System.Drawing.Point(13, 12);
            this.Pnl_Herramientas.Name = "Pnl_Herramientas";
            this.Pnl_Herramientas.Size = new System.Drawing.Size(1113, 154);
            this.Pnl_Herramientas.TabIndex = 0;
            // 
            // Lbl_Inventarios_Pasados
            // 
            this.Lbl_Inventarios_Pasados.AutoSize = true;
            this.Lbl_Inventarios_Pasados.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Inventarios_Pasados.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Inventarios_Pasados.Name = "Lbl_Inventarios_Pasados";
            this.Lbl_Inventarios_Pasados.Size = new System.Drawing.Size(295, 29);
            this.Lbl_Inventarios_Pasados.TabIndex = 0;
            this.Lbl_Inventarios_Pasados.Text = "Historico de Inventarios";
            // 
            // Gpb_Buscar_Inventario_Pasado
            // 
            this.Gpb_Buscar_Inventario_Pasado.Controls.Add(this.Cbo_Tipo_Operacion);
            this.Gpb_Buscar_Inventario_Pasado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Buscar_Inventario_Pasado.Location = new System.Drawing.Point(5, 35);
            this.Gpb_Buscar_Inventario_Pasado.Name = "Gpb_Buscar_Inventario_Pasado";
            this.Gpb_Buscar_Inventario_Pasado.Size = new System.Drawing.Size(292, 70);
            this.Gpb_Buscar_Inventario_Pasado.TabIndex = 9;
            this.Gpb_Buscar_Inventario_Pasado.TabStop = false;
            this.Gpb_Buscar_Inventario_Pasado.Text = "Buscar por Tipo de Movimiento";
            // 
            // Btn_Buscar_Inventario
            // 
            this.Btn_Buscar_Inventario.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar_Inventario.Location = new System.Drawing.Point(303, 111);
            this.Btn_Buscar_Inventario.Name = "Btn_Buscar_Inventario";
            this.Btn_Buscar_Inventario.Size = new System.Drawing.Size(228, 40);
            this.Btn_Buscar_Inventario.TabIndex = 5;
            this.Btn_Buscar_Inventario.Text = "Buscar";
            this.Btn_Buscar_Inventario.UseVisualStyleBackColor = true;
            // 
            // Gpb_Gestion_Inventario
            // 
            this.Gpb_Gestion_Inventario.Controls.Add(this.Btn_Nuevo_Inventario);
            this.Gpb_Gestion_Inventario.Controls.Add(this.Btn_Imprimir_PDF);
            this.Gpb_Gestion_Inventario.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Gestion_Inventario.Location = new System.Drawing.Point(303, 3);
            this.Gpb_Gestion_Inventario.Name = "Gpb_Gestion_Inventario";
            this.Gpb_Gestion_Inventario.Size = new System.Drawing.Size(228, 102);
            this.Gpb_Gestion_Inventario.TabIndex = 8;
            this.Gpb_Gestion_Inventario.TabStop = false;
            this.Gpb_Gestion_Inventario.Text = "Gestion Inventario";
            // 
            // Btn_Nuevo_Inventario
            // 
            this.Btn_Nuevo_Inventario.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nuevo_Inventario.Location = new System.Drawing.Point(40, 19);
            this.Btn_Nuevo_Inventario.Name = "Btn_Nuevo_Inventario";
            this.Btn_Nuevo_Inventario.Size = new System.Drawing.Size(152, 31);
            this.Btn_Nuevo_Inventario.TabIndex = 10;
            this.Btn_Nuevo_Inventario.Text = "Nuevo Inventario";
            this.Btn_Nuevo_Inventario.UseVisualStyleBackColor = true;
            this.Btn_Nuevo_Inventario.Click += new System.EventHandler(this.Btn_Nuevo_Inventario_Click);
            // 
            // Btn_Imprimir_PDF
            // 
            this.Btn_Imprimir_PDF.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Imprimir_PDF.Location = new System.Drawing.Point(40, 56);
            this.Btn_Imprimir_PDF.Name = "Btn_Imprimir_PDF";
            this.Btn_Imprimir_PDF.Size = new System.Drawing.Size(152, 31);
            this.Btn_Imprimir_PDF.TabIndex = 9;
            this.Btn_Imprimir_PDF.Text = "Imprimir en PDF";
            this.Btn_Imprimir_PDF.UseVisualStyleBackColor = true;
            this.Btn_Imprimir_PDF.Click += new System.EventHandler(this.Btn_Imprimir_PDF_Click);
            // 
            // Gpb_Filtros
            // 
            this.Gpb_Filtros.Controls.Add(this.radioButton3);
            this.Gpb_Filtros.Controls.Add(this.label2);
            this.Gpb_Filtros.Controls.Add(this.label1);
            this.Gpb_Filtros.Controls.Add(this.dateTimePicker2);
            this.Gpb_Filtros.Controls.Add(this.dateTimePicker1);
            this.Gpb_Filtros.Controls.Add(this.radioButton4);
            this.Gpb_Filtros.Controls.Add(this.radioButton5);
            this.Gpb_Filtros.Controls.Add(this.comboBox2);
            this.Gpb_Filtros.Controls.Add(this.radioButton2);
            this.Gpb_Filtros.Controls.Add(this.comboBox1);
            this.Gpb_Filtros.Controls.Add(this.radioButton1);
            this.Gpb_Filtros.Controls.Add(this.Rdb_Filtro_Mas_Recientes);
            this.Gpb_Filtros.Controls.Add(this.Rdb_Filtro_Menos_Recientes);
            this.Gpb_Filtros.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Filtros.Location = new System.Drawing.Point(537, 3);
            this.Gpb_Filtros.Name = "Gpb_Filtros";
            this.Gpb_Filtros.Size = new System.Drawing.Size(573, 148);
            this.Gpb_Filtros.TabIndex = 1;
            this.Gpb_Filtros.TabStop = false;
            this.Gpb_Filtros.Text = "Filtros y Orden";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cerrado",
            "Abierto"});
            this.comboBox1.Location = new System.Drawing.Point(342, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 26);
            this.comboBox1.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(245, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 22);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Estado";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Rdb_Filtro_Mas_Recientes
            // 
            this.Rdb_Filtro_Mas_Recientes.AutoSize = true;
            this.Rdb_Filtro_Mas_Recientes.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Filtro_Mas_Recientes.Location = new System.Drawing.Point(6, 24);
            this.Rdb_Filtro_Mas_Recientes.Name = "Rdb_Filtro_Mas_Recientes";
            this.Rdb_Filtro_Mas_Recientes.Size = new System.Drawing.Size(193, 22);
            this.Rdb_Filtro_Mas_Recientes.TabIndex = 0;
            this.Rdb_Filtro_Mas_Recientes.TabStop = true;
            this.Rdb_Filtro_Mas_Recientes.Text = "Fechas Más Recientes";
            this.Rdb_Filtro_Mas_Recientes.UseVisualStyleBackColor = true;
            // 
            // Rdb_Filtro_Menos_Recientes
            // 
            this.Rdb_Filtro_Menos_Recientes.AutoSize = true;
            this.Rdb_Filtro_Menos_Recientes.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Filtro_Menos_Recientes.Location = new System.Drawing.Point(6, 52);
            this.Rdb_Filtro_Menos_Recientes.Name = "Rdb_Filtro_Menos_Recientes";
            this.Rdb_Filtro_Menos_Recientes.Size = new System.Drawing.Size(211, 22);
            this.Rdb_Filtro_Menos_Recientes.TabIndex = 1;
            this.Rdb_Filtro_Menos_Recientes.TabStop = true;
            this.Rdb_Filtro_Menos_Recientes.Text = "Fechas Menos Recientes";
            this.Rdb_Filtro_Menos_Recientes.UseVisualStyleBackColor = true;
            // 
            // Pnl_Vista_Inventarios_Pasados
            // 
            this.Pnl_Vista_Inventarios_Pasados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Vista_Inventarios_Pasados.Controls.Add(this.Dgv_Vista_Inventarios_Pasados);
            this.Pnl_Vista_Inventarios_Pasados.Location = new System.Drawing.Point(13, 172);
            this.Pnl_Vista_Inventarios_Pasados.Name = "Pnl_Vista_Inventarios_Pasados";
            this.Pnl_Vista_Inventarios_Pasados.Size = new System.Drawing.Size(1113, 377);
            this.Pnl_Vista_Inventarios_Pasados.TabIndex = 1;
            // 
            // Dgv_Vista_Inventarios_Pasados
            // 
            this.Dgv_Vista_Inventarios_Pasados.AllowUserToAddRows = false;
            this.Dgv_Vista_Inventarios_Pasados.AllowUserToDeleteRows = false;
            this.Dgv_Vista_Inventarios_Pasados.AllowUserToResizeRows = false;
            this.Dgv_Vista_Inventarios_Pasados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Vista_Inventarios_Pasados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_Vista_Inventarios_Pasados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Vista_Inventarios_Pasados.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Vista_Inventarios_Pasados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Vista_Inventarios_Pasados.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Vista_Inventarios_Pasados.MultiSelect = false;
            this.Dgv_Vista_Inventarios_Pasados.Name = "Dgv_Vista_Inventarios_Pasados";
            this.Dgv_Vista_Inventarios_Pasados.ReadOnly = true;
            this.Dgv_Vista_Inventarios_Pasados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Dgv_Vista_Inventarios_Pasados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Vista_Inventarios_Pasados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Vista_Inventarios_Pasados.Size = new System.Drawing.Size(1113, 377);
            this.Dgv_Vista_Inventarios_Pasados.TabIndex = 0;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(245, 24);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 22);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Almacen";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Cbo_Tipo_Operacion
            // 
            this.Cbo_Tipo_Operacion.FormattingEnabled = true;
            this.Cbo_Tipo_Operacion.Items.AddRange(new object[] {
            "Ventas (-)",
            "Compras (+)",
            "Envios (-)",
            "Devol. Prod. Dañado (+)",
            "Devol. A Huespedes (-)"});
            this.Cbo_Tipo_Operacion.Location = new System.Drawing.Point(6, 26);
            this.Cbo_Tipo_Operacion.Name = "Cbo_Tipo_Operacion";
            this.Cbo_Tipo_Operacion.Size = new System.Drawing.Size(280, 26);
            this.Cbo_Tipo_Operacion.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Cerrado",
            "Abierto"});
            this.comboBox2.Location = new System.Drawing.Point(342, 23);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(225, 26);
            this.comboBox2.TabIndex = 7;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(6, 80);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(239, 22);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Valor Mas Alto en Inventario";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(6, 108);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(243, 22);
            this.radioButton5.TabIndex = 11;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Valor Mas Bajo en Inventario";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(379, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 25);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2025, 10, 29, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(379, 118);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(125, 25);
            this.dateTimePicker2.TabIndex = 13;
            this.dateTimePicker2.Value = new System.DateTime(2025, 10, 29, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Del";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Al";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(245, 87);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 22);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Rango";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Frm_Inventario_Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1138, 561);
            this.Controls.Add(this.Pnl_Vista_Inventarios_Pasados);
            this.Controls.Add(this.Pnl_Herramientas);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1154, 600);
            this.Name = "Frm_Inventario_Historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Pnl_Herramientas.ResumeLayout(false);
            this.Pnl_Herramientas.PerformLayout();
            this.Gpb_Buscar_Inventario_Pasado.ResumeLayout(false);
            this.Gpb_Gestion_Inventario.ResumeLayout(false);
            this.Gpb_Filtros.ResumeLayout(false);
            this.Gpb_Filtros.PerformLayout();
            this.Pnl_Vista_Inventarios_Pasados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Vista_Inventarios_Pasados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Herramientas;
        private System.Windows.Forms.Panel Pnl_Vista_Inventarios_Pasados;
        private System.Windows.Forms.DataGridView Dgv_Vista_Inventarios_Pasados;
        private System.Windows.Forms.GroupBox Gpb_Filtros;
        private System.Windows.Forms.RadioButton Rdb_Filtro_Menos_Recientes;
        private System.Windows.Forms.RadioButton Rdb_Filtro_Mas_Recientes;
        private System.Windows.Forms.Label Lbl_Inventarios_Pasados;
        private System.Windows.Forms.Button Btn_Buscar_Inventario;
        private System.Windows.Forms.GroupBox Gpb_Gestion_Inventario;
        private System.Windows.Forms.GroupBox Gpb_Buscar_Inventario_Pasado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button Btn_Imprimir_PDF;
        private System.Windows.Forms.Button Btn_Nuevo_Inventario;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox Cbo_Tipo_Operacion;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}