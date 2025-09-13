
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
            this.gpb_Listado = new System.Windows.Forms.GroupBox();
            this.txt_Consulta = new System.Windows.Forms.TextBox();
            this.lbl_Cadena_Generada = new System.Windows.Forms.Label();
            this.lbl_Query = new System.Windows.Forms.Label();
            this.cbo_Query = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mstp_Consultas = new System.Windows.Forms.MenuStrip();
            this.creaciònToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.box_ordenar = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.gpb_Listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Mstp_Consultas.SuspendLayout();
            this.box_ordenar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_Listado
            // 
            this.gpb_Listado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpb_Listado.Controls.Add(this.btn_aceptar);
            this.gpb_Listado.Controls.Add(this.box_ordenar);
            this.gpb_Listado.Controls.Add(this.txt_Consulta);
            this.gpb_Listado.Controls.Add(this.lbl_Cadena_Generada);
            this.gpb_Listado.Controls.Add(this.lbl_Query);
            this.gpb_Listado.Controls.Add(this.btn_buscar);
            this.gpb_Listado.Controls.Add(this.cbo_Query);
            this.gpb_Listado.Font = new System.Drawing.Font("Rockwell", 10.8F);
            this.gpb_Listado.Location = new System.Drawing.Point(0, 26);
            this.gpb_Listado.Name = "gpb_Listado";
            this.gpb_Listado.Size = new System.Drawing.Size(975, 98);
            this.gpb_Listado.TabIndex = 5;
            this.gpb_Listado.TabStop = false;
            this.gpb_Listado.Text = "Consulta Simple";
            // 
            // txt_Consulta
            // 
            this.txt_Consulta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Consulta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Consulta.Location = new System.Drawing.Point(221, 50);
            this.txt_Consulta.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Consulta.Name = "txt_Consulta";
            this.txt_Consulta.ReadOnly = true;
            this.txt_Consulta.Size = new System.Drawing.Size(330, 23);
            this.txt_Consulta.TabIndex = 8;
            // 
            // lbl_Cadena_Generada
            // 
            this.lbl_Cadena_Generada.AutoSize = true;
            this.lbl_Cadena_Generada.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cadena_Generada.Location = new System.Drawing.Point(219, 29);
            this.lbl_Cadena_Generada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Cadena_Generada.Name = "lbl_Cadena_Generada";
            this.lbl_Cadena_Generada.Size = new System.Drawing.Size(136, 17);
            this.lbl_Cadena_Generada.TabIndex = 7;
            this.lbl_Cadena_Generada.Text = "Cadena Generada";
            // 
            // lbl_Query
            // 
            this.lbl_Query.AutoSize = true;
            this.lbl_Query.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Query.Location = new System.Drawing.Point(8, 29);
            this.lbl_Query.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Query.Name = "lbl_Query";
            this.lbl_Query.Size = new System.Drawing.Size(52, 17);
            this.lbl_Query.TabIndex = 6;
            this.lbl_Query.Text = "Query";
            // 
            // cbo_Query
            // 
            this.cbo_Query.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Query.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Query.FormattingEnabled = true;
            this.cbo_Query.Location = new System.Drawing.Point(11, 49);
            this.cbo_Query.Name = "cbo_Query";
            this.cbo_Query.Size = new System.Drawing.Size(158, 25);
            this.cbo_Query.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 140);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(952, 390);
            this.dataGridView1.TabIndex = 6;
            // 
            // Mstp_Consultas
            // 
            this.Mstp_Consultas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Mstp_Consultas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaciònToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.Mstp_Consultas.Location = new System.Drawing.Point(0, 0);
            this.Mstp_Consultas.Name = "Mstp_Consultas";
            this.Mstp_Consultas.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.Mstp_Consultas.Size = new System.Drawing.Size(980, 25);
            this.Mstp_Consultas.TabIndex = 9;
            this.Mstp_Consultas.Text = "menuStrip1";
            // 
            // creaciònToolStripMenuItem
            // 
            this.creaciònToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creaciònToolStripMenuItem.Name = "creaciònToolStripMenuItem";
            this.creaciònToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.creaciònToolStripMenuItem.Text = "Creación";
            this.creaciònToolStripMenuItem.Click += new System.EventHandler(this.creaciònToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(119, 21);
            this.editarToolStripMenuItem.Text = "Editar/Eliminar";
            // 
            // box_ordenar
            // 
            this.box_ordenar.Controls.Add(this.radioButton2);
            this.box_ordenar.Controls.Add(this.radioButton1);
            this.box_ordenar.Location = new System.Drawing.Point(568, 21);
            this.box_ordenar.Name = "box_ordenar";
            this.box_ordenar.Size = new System.Drawing.Size(188, 63);
            this.box_ordenar.TabIndex = 9;
            this.box_ordenar.TabStop = false;
            this.box_ordenar.Text = "Ordenamiento";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ASC";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(105, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "DESC";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Image = global::Capa_Vista_Componente_Consultas.Properties.Resources.icons8_accept_50;
            this.btn_aceptar.Location = new System.Drawing.Point(869, 8);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(78, 84);
            this.btn_aceptar.TabIndex = 10;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_aceptar.UseCompatibleTextRendering = true;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Image = global::Capa_Vista_Componente_Consultas.Properties.Resources.android_search_icon_icons_com_50501;
            this.btn_buscar.Location = new System.Drawing.Point(774, 8);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(78, 84);
            this.btn_buscar.TabIndex = 5;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_buscar.UseCompatibleTextRendering = true;
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Frm_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 541);
            this.Controls.Add(this.Mstp_Consultas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gpb_Listado);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Consultas";
            this.Load += new System.EventHandler(this.Frm_Consultas_Load);
            this.gpb_Listado.ResumeLayout(false);
            this.gpb_Listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Mstp_Consultas.ResumeLayout(false);
            this.Mstp_Consultas.PerformLayout();
            this.box_ordenar.ResumeLayout(false);
            this.box_ordenar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_Listado;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ComboBox cbo_Query;
        private System.Windows.Forms.TextBox txt_Consulta;
        private System.Windows.Forms.Label lbl_Cadena_Generada;
        private System.Windows.Forms.Label lbl_Query;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip Mstp_Consultas;
        private System.Windows.Forms.ToolStripMenuItem creaciònToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.GroupBox box_ordenar;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_aceptar;
    }
}