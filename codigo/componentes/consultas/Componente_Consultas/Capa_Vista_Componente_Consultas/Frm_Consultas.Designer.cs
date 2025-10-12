
namespace Capa_Vista_Componente_Consultas
{
    partial class Frm_Consultas
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
            this.Gpb_Listado = new System.Windows.Forms.GroupBox();
            this.Btn_buscarClick = new System.Windows.Forms.Button();
            this.Txt_Filtro = new System.Windows.Forms.TextBox();
            this.Gpb_Ordenamiento = new System.Windows.Forms.GroupBox();
            this.Rdb_asc = new System.Windows.Forms.RadioButton();
            this.Rdb_desc = new System.Windows.Forms.RadioButton();
            this.Lbl_Query = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.cbo_Query = new System.Windows.Forms.ComboBox();
            this.Dgv_consultas_simples = new System.Windows.Forms.DataGridView();
            this.Mstp_Consultas = new System.Windows.Forms.MenuStrip();
            this.MenúPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_min = new System.Windows.Forms.Button();
            this.Btn_regresar = new System.Windows.Forms.Button();
            this.Btn_ConsultaC = new System.Windows.Forms.Button();
            this.Btn_max = new System.Windows.Forms.Button();
            this.Gpb_Listado.SuspendLayout();
            this.Gpb_Ordenamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultas_simples)).BeginInit();
            this.Mstp_Consultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_Listado
            // 
            this.Gpb_Listado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpb_Listado.Controls.Add(this.Btn_buscarClick);
            this.Gpb_Listado.Controls.Add(this.Txt_Filtro);
            this.Gpb_Listado.Controls.Add(this.Gpb_Ordenamiento);
            this.Gpb_Listado.Controls.Add(this.Lbl_Query);
            this.Gpb_Listado.Controls.Add(this.Btn_buscar);
            this.Gpb_Listado.Controls.Add(this.cbo_Query);
            this.Gpb_Listado.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Listado.Location = new System.Drawing.Point(0, 26);
            this.Gpb_Listado.Name = "Gpb_Listado";
            this.Gpb_Listado.Size = new System.Drawing.Size(803, 115);
            this.Gpb_Listado.TabIndex = 5;
            this.Gpb_Listado.TabStop = false;
            this.Gpb_Listado.Text = "Consultas Simples";
            // 
            // Btn_buscarClick
            // 
            this.Btn_buscarClick.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_buscarClick.Image = global::Capa_Vista_Componente_Consultas.Properties.Resources.android_search_icon_icons_com_50501;
            this.Btn_buscarClick.Location = new System.Drawing.Point(413, 34);
            this.Btn_buscarClick.Name = "Btn_buscarClick";
            this.Btn_buscarClick.Size = new System.Drawing.Size(67, 61);
            this.Btn_buscarClick.TabIndex = 28;
            this.Btn_buscarClick.Text = "Filtrar";
            this.Btn_buscarClick.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_buscarClick.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_buscarClick.UseCompatibleTextRendering = true;
            this.Btn_buscarClick.UseVisualStyleBackColor = true;
            this.Btn_buscarClick.Click += new System.EventHandler(this.Btn_filtrar_Click);
            // 
            // Txt_Filtro
            // 
            this.Txt_Filtro.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_Filtro.Location = new System.Drawing.Point(503, 67);
            this.Txt_Filtro.Name = "Txt_Filtro";
            this.Txt_Filtro.Size = new System.Drawing.Size(186, 23);
            this.Txt_Filtro.TabIndex = 27;
            // 
            // Gpb_Ordenamiento
            // 
            this.Gpb_Ordenamiento.Controls.Add(this.Rdb_asc);
            this.Gpb_Ordenamiento.Controls.Add(this.Rdb_desc);
            this.Gpb_Ordenamiento.Font = new System.Drawing.Font("Rockwell", 11F);
            this.Gpb_Ordenamiento.Location = new System.Drawing.Point(181, 48);
            this.Gpb_Ordenamiento.Name = "Gpb_Ordenamiento";
            this.Gpb_Ordenamiento.Size = new System.Drawing.Size(138, 47);
            this.Gpb_Ordenamiento.TabIndex = 26;
            this.Gpb_Ordenamiento.TabStop = false;
            this.Gpb_Ordenamiento.Text = "Ordenamiento";
            // 
            // Rdb_asc
            // 
            this.Rdb_asc.AutoSize = true;
            this.Rdb_asc.Font = new System.Drawing.Font("Rockwell", 11F);
            this.Rdb_asc.Location = new System.Drawing.Point(6, 21);
            this.Rdb_asc.Name = "Rdb_asc";
            this.Rdb_asc.Size = new System.Drawing.Size(55, 21);
            this.Rdb_asc.TabIndex = 10;
            this.Rdb_asc.TabStop = true;
            this.Rdb_asc.Text = "ASC";
            this.Rdb_asc.UseVisualStyleBackColor = true;
            // 
            // Rdb_desc
            // 
            this.Rdb_desc.AutoSize = true;
            this.Rdb_desc.Font = new System.Drawing.Font("Rockwell", 11F);
            this.Rdb_desc.Location = new System.Drawing.Point(67, 21);
            this.Rdb_desc.Name = "Rdb_desc";
            this.Rdb_desc.Size = new System.Drawing.Size(65, 21);
            this.Rdb_desc.TabIndex = 26;
            this.Rdb_desc.TabStop = true;
            this.Rdb_desc.Text = "DESC";
            this.Rdb_desc.UseVisualStyleBackColor = true;
            // 
            // Lbl_Query
            // 
            this.Lbl_Query.AutoSize = true;
            this.Lbl_Query.Font = new System.Drawing.Font("Rockwell", 11F);
            this.Lbl_Query.Location = new System.Drawing.Point(11, 40);
            this.Lbl_Query.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Query.Name = "Lbl_Query";
            this.Lbl_Query.Size = new System.Drawing.Size(52, 17);
            this.Lbl_Query.TabIndex = 6;
            this.Lbl_Query.Text = "Query";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Rockwell", 11F);
            this.Btn_buscar.Image = global::Capa_Vista_Componente_Consultas.Properties.Resources.android_search_icon_icons_com_50501;
            this.Btn_buscar.Location = new System.Drawing.Point(325, 34);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(71, 61);
            this.Btn_buscar.TabIndex = 5;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_buscar.UseCompatibleTextRendering = true;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // cbo_Query
            // 
            this.cbo_Query.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Query.Font = new System.Drawing.Font("Rockwell", 10F);
            this.cbo_Query.FormattingEnabled = true;
            this.cbo_Query.Location = new System.Drawing.Point(12, 71);
            this.cbo_Query.Name = "cbo_Query";
            this.cbo_Query.Size = new System.Drawing.Size(142, 24);
            this.cbo_Query.TabIndex = 0;
            // 
            // Dgv_consultas_simples
            // 
            this.Dgv_consultas_simples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultas_simples.Location = new System.Drawing.Point(14, 147);
            this.Dgv_consultas_simples.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_consultas_simples.Name = "Dgv_consultas_simples";
            this.Dgv_consultas_simples.RowHeadersWidth = 51;
            this.Dgv_consultas_simples.RowTemplate.Height = 24;
            this.Dgv_consultas_simples.Size = new System.Drawing.Size(782, 314);
            this.Dgv_consultas_simples.TabIndex = 6;
            // 
            // Mstp_Consultas
            // 
            this.Mstp_Consultas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Mstp_Consultas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenúPrincipalToolStripMenuItem,
            this.ConsultasToolStripMenuItem});
            this.Mstp_Consultas.Location = new System.Drawing.Point(0, 0);
            this.Mstp_Consultas.Name = "Mstp_Consultas";
            this.Mstp_Consultas.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.Mstp_Consultas.Size = new System.Drawing.Size(808, 25);
            this.Mstp_Consultas.TabIndex = 9;
            this.Mstp_Consultas.Text = "menuStrip1";
            // 
            // MenúPrincipalToolStripMenuItem
            // 
            this.MenúPrincipalToolStripMenuItem.Name = "MenúPrincipalToolStripMenuItem";
            this.MenúPrincipalToolStripMenuItem.Size = new System.Drawing.Size(99, 21);
            this.MenúPrincipalToolStripMenuItem.Text = "Menú Principal";
            this.MenúPrincipalToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultasToolStripMenuItem
            // 
            this.ConsultasToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem";
            this.ConsultasToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.ConsultasToolStripMenuItem.Text = "Consultas";
            // 
            // Btn_min
            // 
            this.Btn_min.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_min.Location = new System.Drawing.Point(685, 2);
            this.Btn_min.Name = "Btn_min";
            this.Btn_min.Size = new System.Drawing.Size(82, 23);
            this.Btn_min.TabIndex = 14;
            this.Btn_min.Text = "Minimizar";
            this.Btn_min.UseVisualStyleBackColor = true;
            this.Btn_min.Click += new System.EventHandler(this.btn_min_Click_1);
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_regresar.Location = new System.Drawing.Point(524, 2);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.Size = new System.Drawing.Size(71, 23);
            this.Btn_regresar.TabIndex = 15;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.UseVisualStyleBackColor = true;
            this.Btn_regresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_ConsultaC
            // 
            this.Btn_ConsultaC.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConsultaC.Location = new System.Drawing.Point(325, 1);
            this.Btn_ConsultaC.Name = "Btn_ConsultaC";
            this.Btn_ConsultaC.Size = new System.Drawing.Size(141, 24);
            this.Btn_ConsultaC.TabIndex = 16;
            this.Btn_ConsultaC.Text = "Consulta Compleja";
            this.Btn_ConsultaC.UseVisualStyleBackColor = true;
            this.Btn_ConsultaC.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_max
            // 
            this.Btn_max.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_max.Location = new System.Drawing.Point(601, 2);
            this.Btn_max.Name = "Btn_max";
            this.Btn_max.Size = new System.Drawing.Size(78, 23);
            this.Btn_max.TabIndex = 25;
            this.Btn_max.Text = "Maximizar";
            this.Btn_max.UseVisualStyleBackColor = true;
            this.Btn_max.Click += new System.EventHandler(this.btn_max_Click_1);
            // 
            // Frm_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 472);
            this.ControlBox = false;
            this.Controls.Add(this.Gpb_Listado);
            this.Controls.Add(this.Btn_max);
            this.Controls.Add(this.Btn_ConsultaC);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Btn_min);
            this.Controls.Add(this.Mstp_Consultas);
            this.Controls.Add(this.Dgv_consultas_simples);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Consultas";
            this.Gpb_Listado.ResumeLayout(false);
            this.Gpb_Listado.PerformLayout();
            this.Gpb_Ordenamiento.ResumeLayout(false);
            this.Gpb_Ordenamiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultas_simples)).EndInit();
            this.Mstp_Consultas.ResumeLayout(false);
            this.Mstp_Consultas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_Listado;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.ComboBox cbo_Query;
        private System.Windows.Forms.Label Lbl_Query;
        private System.Windows.Forms.DataGridView Dgv_consultas_simples;
        private System.Windows.Forms.MenuStrip Mstp_Consultas;
        private System.Windows.Forms.Button Btn_min;
        private System.Windows.Forms.ToolStripMenuItem MenúPrincipalToolStripMenuItem;
        private System.Windows.Forms.Button Btn_regresar;
        private System.Windows.Forms.Button Btn_ConsultaC;
        private System.Windows.Forms.Button Btn_max;
        private System.Windows.Forms.RadioButton Rdb_asc;
        private System.Windows.Forms.RadioButton Rdb_desc;
        private System.Windows.Forms.GroupBox Gpb_Ordenamiento;
        private System.Windows.Forms.ToolStripMenuItem ConsultasToolStripMenuItem;
        private System.Windows.Forms.TextBox Txt_Filtro;
        private System.Windows.Forms.Button Btn_buscarClick;
    }
}