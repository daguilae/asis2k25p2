
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
            this.Lb_Campos = new System.Windows.Forms.Label();
            this.cbo_Operador = new System.Windows.Forms.ComboBox();
            this.cbo_Campos = new System.Windows.Forms.ComboBox();
            this.Btn_buscarClick = new System.Windows.Forms.Button();
            this.Txt_Filtro = new System.Windows.Forms.TextBox();
            this.Gpb_Ordenamiento = new System.Windows.Forms.GroupBox();
            this.Rdb_asc = new System.Windows.Forms.RadioButton();
            this.Rdb_desc = new System.Windows.Forms.RadioButton();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Dgv_consultas_simples = new System.Windows.Forms.DataGridView();
            this.Lb_Operador = new System.Windows.Forms.Label();
            this.Gpb_Listado.SuspendLayout();
            this.Gpb_Ordenamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultas_simples)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_Listado
            // 
            this.Gpb_Listado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpb_Listado.Controls.Add(this.Lb_Operador);
            this.Gpb_Listado.Controls.Add(this.Lb_Campos);
            this.Gpb_Listado.Controls.Add(this.cbo_Operador);
            this.Gpb_Listado.Controls.Add(this.cbo_Campos);
            this.Gpb_Listado.Controls.Add(this.Btn_buscarClick);
            this.Gpb_Listado.Controls.Add(this.Txt_Filtro);
            this.Gpb_Listado.Controls.Add(this.Gpb_Ordenamiento);
            this.Gpb_Listado.Controls.Add(this.Btn_buscar);
            this.Gpb_Listado.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Listado.Location = new System.Drawing.Point(0, 26);
            this.Gpb_Listado.Name = "Gpb_Listado";
            this.Gpb_Listado.Size = new System.Drawing.Size(803, 115);
            this.Gpb_Listado.TabIndex = 5;
            this.Gpb_Listado.TabStop = false;
            this.Gpb_Listado.Text = "Consultas Simples";
            // 
            // Lb_Campos
            // 
            this.Lb_Campos.AutoSize = true;
            this.Lb_Campos.Location = new System.Drawing.Point(251, 31);
            this.Lb_Campos.Name = "Lb_Campos";
            this.Lb_Campos.Size = new System.Drawing.Size(104, 27);
            this.Lb_Campos.TabIndex = 31;
            this.Lb_Campos.Text = "Campos";
            // 
            // cbo_Operador
            // 
            this.cbo_Operador.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Operador.FormattingEnabled = true;
            this.cbo_Operador.Location = new System.Drawing.Point(390, 65);
            this.cbo_Operador.Name = "cbo_Operador";
            this.cbo_Operador.Size = new System.Drawing.Size(132, 27);
            this.cbo_Operador.TabIndex = 30;
            // 
            // cbo_Campos
            // 
            this.cbo_Campos.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Campos.FormattingEnabled = true;
            this.cbo_Campos.Location = new System.Drawing.Point(252, 65);
            this.cbo_Campos.Name = "cbo_Campos";
            this.cbo_Campos.Size = new System.Drawing.Size(132, 27);
            this.cbo_Campos.TabIndex = 29;
            // 
            // Btn_buscarClick
            // 
            this.Btn_buscarClick.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_buscarClick.Image = global::Capa_Vista_Componente_Consultas.Properties.Resources.android_search_icon_icons_com_50501;
            this.Btn_buscarClick.Location = new System.Drawing.Point(720, 36);
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
            this.Txt_Filtro.Location = new System.Drawing.Point(528, 70);
            this.Txt_Filtro.Name = "Txt_Filtro";
            this.Txt_Filtro.Size = new System.Drawing.Size(186, 23);
            this.Txt_Filtro.TabIndex = 27;
            // 
            // Gpb_Ordenamiento
            // 
            this.Gpb_Ordenamiento.Controls.Add(this.Rdb_asc);
            this.Gpb_Ordenamiento.Controls.Add(this.Rdb_desc);
            this.Gpb_Ordenamiento.Font = new System.Drawing.Font("Rockwell", 11F);
            this.Gpb_Ordenamiento.Location = new System.Drawing.Point(107, 50);
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
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Rockwell", 11F);
            this.Btn_buscar.Image = global::Capa_Vista_Componente_Consultas.Properties.Resources.android_search_icon_icons_com_50501;
            this.Btn_buscar.Location = new System.Drawing.Point(14, 36);
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
            // Lb_Operador
            // 
            this.Lb_Operador.AutoSize = true;
            this.Lb_Operador.Location = new System.Drawing.Point(385, 32);
            this.Lb_Operador.Name = "Lb_Operador";
            this.Lb_Operador.Size = new System.Drawing.Size(122, 27);
            this.Lb_Operador.TabIndex = 32;
            this.Lb_Operador.Text = "Operador";
            // 
            // Frm_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 472);
            this.ControlBox = false;
            this.Controls.Add(this.Gpb_Listado);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_Listado;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.DataGridView Dgv_consultas_simples;
        private System.Windows.Forms.RadioButton Rdb_asc;
        private System.Windows.Forms.RadioButton Rdb_desc;
        private System.Windows.Forms.GroupBox Gpb_Ordenamiento;
        private System.Windows.Forms.TextBox Txt_Filtro;
        private System.Windows.Forms.Button Btn_buscarClick;
        private System.Windows.Forms.ComboBox cbo_Operador;
        private System.Windows.Forms.ComboBox cbo_Campos;
        private System.Windows.Forms.Label Lb_Campos;
        private System.Windows.Forms.Label Lb_Operador;
    }
}