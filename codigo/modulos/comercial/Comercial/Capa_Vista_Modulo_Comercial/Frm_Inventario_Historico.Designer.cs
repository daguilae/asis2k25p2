
namespace Capa_Vista_Modulo_Comercial.Inventario
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
            this.Cbo_Buscar_Inventario_Pasado = new System.Windows.Forms.ComboBox();
            this.Btn_Buscar_Inventario_Pasado = new System.Windows.Forms.Button();
            this.Gpb_Gestion_Inventario = new System.Windows.Forms.GroupBox();
            this.Btn_Modificar_Inventario = new System.Windows.Forms.Button();
            this.Btn_Nuevo_Inventario = new System.Windows.Forms.Button();
            this.Gpb_Filtros = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Rdb_Filtro_Mas_Recientes = new System.Windows.Forms.RadioButton();
            this.Rdb_Filtro_Menos_Recientes = new System.Windows.Forms.RadioButton();
            this.Rdb_Filtro_Anios_Pasados = new System.Windows.Forms.RadioButton();
            this.Cbo_Filtrar_Anios = new System.Windows.Forms.ComboBox();
            this.Pnl_Vista_Inventarios_Pasados = new System.Windows.Forms.Panel();
            this.Dgv_Vista_Inventarios_Pasados = new System.Windows.Forms.DataGridView();
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
            this.Pnl_Herramientas.Controls.Add(this.Lbl_Inventarios_Pasados);
            this.Pnl_Herramientas.Controls.Add(this.Gpb_Buscar_Inventario_Pasado);
            this.Pnl_Herramientas.Controls.Add(this.Gpb_Gestion_Inventario);
            this.Pnl_Herramientas.Controls.Add(this.Gpb_Filtros);
            this.Pnl_Herramientas.Location = new System.Drawing.Point(13, 12);
            this.Pnl_Herramientas.Name = "Pnl_Herramientas";
            this.Pnl_Herramientas.Size = new System.Drawing.Size(809, 154);
            this.Pnl_Herramientas.TabIndex = 0;
            // 
            // Lbl_Inventarios_Pasados
            // 
            this.Lbl_Inventarios_Pasados.AutoSize = true;
            this.Lbl_Inventarios_Pasados.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Inventarios_Pasados.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Inventarios_Pasados.Name = "Lbl_Inventarios_Pasados";
            this.Lbl_Inventarios_Pasados.Size = new System.Drawing.Size(120, 29);
            this.Lbl_Inventarios_Pasados.TabIndex = 0;
            this.Lbl_Inventarios_Pasados.Text = "Historico";
            // 
            // Gpb_Buscar_Inventario_Pasado
            // 
            this.Gpb_Buscar_Inventario_Pasado.Controls.Add(this.Cbo_Buscar_Inventario_Pasado);
            this.Gpb_Buscar_Inventario_Pasado.Controls.Add(this.Btn_Buscar_Inventario_Pasado);
            this.Gpb_Buscar_Inventario_Pasado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Buscar_Inventario_Pasado.Location = new System.Drawing.Point(3, 35);
            this.Gpb_Buscar_Inventario_Pasado.Name = "Gpb_Buscar_Inventario_Pasado";
            this.Gpb_Buscar_Inventario_Pasado.Size = new System.Drawing.Size(393, 116);
            this.Gpb_Buscar_Inventario_Pasado.TabIndex = 9;
            this.Gpb_Buscar_Inventario_Pasado.TabStop = false;
            this.Gpb_Buscar_Inventario_Pasado.Text = "Buscar Inventario Pasado";
            // 
            // Cbo_Buscar_Inventario_Pasado
            // 
            this.Cbo_Buscar_Inventario_Pasado.FormattingEnabled = true;
            this.Cbo_Buscar_Inventario_Pasado.Items.AddRange(new object[] {
            "id: 1"});
            this.Cbo_Buscar_Inventario_Pasado.Location = new System.Drawing.Point(6, 25);
            this.Cbo_Buscar_Inventario_Pasado.Name = "Cbo_Buscar_Inventario_Pasado";
            this.Cbo_Buscar_Inventario_Pasado.Size = new System.Drawing.Size(274, 26);
            this.Cbo_Buscar_Inventario_Pasado.TabIndex = 3;
            // 
            // Btn_Buscar_Inventario_Pasado
            // 
            this.Btn_Buscar_Inventario_Pasado.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar_Inventario_Pasado.Location = new System.Drawing.Point(286, 26);
            this.Btn_Buscar_Inventario_Pasado.Name = "Btn_Buscar_Inventario_Pasado";
            this.Btn_Buscar_Inventario_Pasado.Size = new System.Drawing.Size(101, 25);
            this.Btn_Buscar_Inventario_Pasado.TabIndex = 5;
            this.Btn_Buscar_Inventario_Pasado.Text = "Buscar";
            this.Btn_Buscar_Inventario_Pasado.UseVisualStyleBackColor = true;
            // 
            // Gpb_Gestion_Inventario
            // 
            this.Gpb_Gestion_Inventario.Controls.Add(this.Btn_Modificar_Inventario);
            this.Gpb_Gestion_Inventario.Controls.Add(this.Btn_Nuevo_Inventario);
            this.Gpb_Gestion_Inventario.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Gestion_Inventario.Location = new System.Drawing.Point(402, 3);
            this.Gpb_Gestion_Inventario.Name = "Gpb_Gestion_Inventario";
            this.Gpb_Gestion_Inventario.Size = new System.Drawing.Size(164, 148);
            this.Gpb_Gestion_Inventario.TabIndex = 8;
            this.Gpb_Gestion_Inventario.TabStop = false;
            this.Gpb_Gestion_Inventario.Text = "Gestion Inventario";
            // 
            // Btn_Modificar_Inventario
            // 
            this.Btn_Modificar_Inventario.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar_Inventario.Location = new System.Drawing.Point(6, 55);
            this.Btn_Modificar_Inventario.Name = "Btn_Modificar_Inventario";
            this.Btn_Modificar_Inventario.Size = new System.Drawing.Size(98, 25);
            this.Btn_Modificar_Inventario.TabIndex = 7;
            this.Btn_Modificar_Inventario.Text = "Modificar Inventario";
            this.Btn_Modificar_Inventario.UseVisualStyleBackColor = true;
            this.Btn_Modificar_Inventario.Click += new System.EventHandler(this.Btn_Modificar_Inventario_Click);
            // 
            // Btn_Nuevo_Inventario
            // 
            this.Btn_Nuevo_Inventario.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nuevo_Inventario.Location = new System.Drawing.Point(6, 24);
            this.Btn_Nuevo_Inventario.Name = "Btn_Nuevo_Inventario";
            this.Btn_Nuevo_Inventario.Size = new System.Drawing.Size(139, 25);
            this.Btn_Nuevo_Inventario.TabIndex = 8;
            this.Btn_Nuevo_Inventario.Text = "Nuevo Inventario";
            this.Btn_Nuevo_Inventario.UseVisualStyleBackColor = true;
            this.Btn_Nuevo_Inventario.Click += new System.EventHandler(this.Btn_Nuevo_Inventario_Click);
            // 
            // Gpb_Filtros
            // 
            this.Gpb_Filtros.Controls.Add(this.comboBox1);
            this.Gpb_Filtros.Controls.Add(this.radioButton1);
            this.Gpb_Filtros.Controls.Add(this.Rdb_Filtro_Mas_Recientes);
            this.Gpb_Filtros.Controls.Add(this.Rdb_Filtro_Menos_Recientes);
            this.Gpb_Filtros.Controls.Add(this.Rdb_Filtro_Anios_Pasados);
            this.Gpb_Filtros.Controls.Add(this.Cbo_Filtrar_Anios);
            this.Gpb_Filtros.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Filtros.Location = new System.Drawing.Point(572, 3);
            this.Gpb_Filtros.Name = "Gpb_Filtros";
            this.Gpb_Filtros.Size = new System.Drawing.Size(234, 148);
            this.Gpb_Filtros.TabIndex = 1;
            this.Gpb_Filtros.TabStop = false;
            this.Gpb_Filtros.Text = "Filtros";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cerrado",
            "Abierto"});
            this.comboBox1.Location = new System.Drawing.Point(88, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 26);
            this.comboBox1.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(6, 108);
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
            // Rdb_Filtro_Anios_Pasados
            // 
            this.Rdb_Filtro_Anios_Pasados.AutoSize = true;
            this.Rdb_Filtro_Anios_Pasados.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Filtro_Anios_Pasados.Location = new System.Drawing.Point(6, 80);
            this.Rdb_Filtro_Anios_Pasados.Name = "Rdb_Filtro_Anios_Pasados";
            this.Rdb_Filtro_Anios_Pasados.Size = new System.Drawing.Size(128, 22);
            this.Rdb_Filtro_Anios_Pasados.TabIndex = 3;
            this.Rdb_Filtro_Anios_Pasados.TabStop = true;
            this.Rdb_Filtro_Anios_Pasados.Text = "Años Pasados";
            this.Rdb_Filtro_Anios_Pasados.UseVisualStyleBackColor = true;
            // 
            // Cbo_Filtrar_Anios
            // 
            this.Cbo_Filtrar_Anios.FormattingEnabled = true;
            this.Cbo_Filtrar_Anios.Items.AddRange(new object[] {
            "2025",
            "2024",
            "2023"});
            this.Cbo_Filtrar_Anios.Location = new System.Drawing.Point(140, 76);
            this.Cbo_Filtrar_Anios.Name = "Cbo_Filtrar_Anios";
            this.Cbo_Filtrar_Anios.Size = new System.Drawing.Size(73, 26);
            this.Cbo_Filtrar_Anios.TabIndex = 2;
            // 
            // Pnl_Vista_Inventarios_Pasados
            // 
            this.Pnl_Vista_Inventarios_Pasados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Vista_Inventarios_Pasados.Controls.Add(this.Dgv_Vista_Inventarios_Pasados);
            this.Pnl_Vista_Inventarios_Pasados.Location = new System.Drawing.Point(13, 172);
            this.Pnl_Vista_Inventarios_Pasados.Name = "Pnl_Vista_Inventarios_Pasados";
            this.Pnl_Vista_Inventarios_Pasados.Size = new System.Drawing.Size(809, 377);
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
            this.Dgv_Vista_Inventarios_Pasados.Size = new System.Drawing.Size(809, 377);
            this.Dgv_Vista_Inventarios_Pasados.TabIndex = 0;
            // 
            // Frm_Inventario_Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.Pnl_Vista_Inventarios_Pasados);
            this.Controls.Add(this.Pnl_Herramientas);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(850, 600);
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
        private System.Windows.Forms.RadioButton Rdb_Filtro_Anios_Pasados;
        private System.Windows.Forms.ComboBox Cbo_Filtrar_Anios;
        private System.Windows.Forms.RadioButton Rdb_Filtro_Menos_Recientes;
        private System.Windows.Forms.RadioButton Rdb_Filtro_Mas_Recientes;
        private System.Windows.Forms.Label Lbl_Inventarios_Pasados;
        private System.Windows.Forms.ComboBox Cbo_Buscar_Inventario_Pasado;
        private System.Windows.Forms.Button Btn_Buscar_Inventario_Pasado;
        private System.Windows.Forms.GroupBox Gpb_Gestion_Inventario;
        private System.Windows.Forms.Button Btn_Nuevo_Inventario;
        private System.Windows.Forms.Button Btn_Modificar_Inventario;
        private System.Windows.Forms.GroupBox Gpb_Buscar_Inventario_Pasado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}