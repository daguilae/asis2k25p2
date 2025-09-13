
namespace Capa_Vista_Componente_Consultas
{
    partial class Consulta_Compleja
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
            this.Cbo_busqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.Dgv_Tabla = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_EjecutarSQL = new System.Windows.Forms.Button();
            this.rb_asc = new System.Windows.Forms.RadioButton();
            this.rb_desc = new System.Windows.Forms.RadioButton();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_consimple = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_Tabla = new System.Windows.Forms.Label();
            this.lst_Querys = new System.Windows.Forms.ListBox();
            this.gpb_Orden = new System.Windows.Forms.GroupBox();
            this.lbl_Sql = new System.Windows.Forms.Label();
            this.txt_Sql = new System.Windows.Forms.TextBox();
            this.dgv_Sql = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tabla)).BeginInit();
            this.gpb_Orden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sql)).BeginInit();
            this.SuspendLayout();
            // 
            // Cbo_busqueda
            // 
            this.Cbo_busqueda.FormattingEnabled = true;
            this.Cbo_busqueda.Location = new System.Drawing.Point(152, 19);
            this.Cbo_busqueda.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_busqueda.Name = "Cbo_busqueda";
            this.Cbo_busqueda.Size = new System.Drawing.Size(225, 21);
            this.Cbo_busqueda.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Image = global::Capa_Vista_Componente_Consultas.Properties.Resources.android_search_icon_icons_com_50501;
            this.btn_buscar.Location = new System.Drawing.Point(405, 7);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(44, 48);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_buscar.UseCompatibleTextRendering = true;
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Dgv_Tabla
            // 
            this.Dgv_Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Tabla.Location = new System.Drawing.Point(20, 76);
            this.Dgv_Tabla.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_Tabla.Name = "Dgv_Tabla";
            this.Dgv_Tabla.RowHeadersWidth = 51;
            this.Dgv_Tabla.RowTemplate.Height = 24;
            this.Dgv_Tabla.Size = new System.Drawing.Size(741, 223);
            this.Dgv_Tabla.TabIndex = 7;
            this.Dgv_Tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Tabla_CellContentClick);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(814, 332);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(54, 26);
            this.btn_editar.TabIndex = 8;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(936, 334);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(68, 24);
            this.btn_eliminar.TabIndex = 9;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_EjecutarSQL
            // 
            this.btn_EjecutarSQL.Location = new System.Drawing.Point(650, 337);
            this.btn_EjecutarSQL.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EjecutarSQL.Name = "btn_EjecutarSQL";
            this.btn_EjecutarSQL.Size = new System.Drawing.Size(111, 57);
            this.btn_EjecutarSQL.TabIndex = 10;
            this.btn_EjecutarSQL.Text = "Ejecutar SQL";
            this.btn_EjecutarSQL.UseVisualStyleBackColor = true;
            this.btn_EjecutarSQL.Click += new System.EventHandler(this.btn_EjecutarSQL_Click);
            // 
            // rb_asc
            // 
            this.rb_asc.AutoSize = true;
            this.rb_asc.Location = new System.Drawing.Point(14, 18);
            this.rb_asc.Margin = new System.Windows.Forms.Padding(2);
            this.rb_asc.Name = "rb_asc";
            this.rb_asc.Size = new System.Drawing.Size(46, 17);
            this.rb_asc.TabIndex = 11;
            this.rb_asc.TabStop = true;
            this.rb_asc.Text = "ASC";
            this.rb_asc.UseVisualStyleBackColor = true;
            // 
            // rb_desc
            // 
            this.rb_desc.AutoSize = true;
            this.rb_desc.Location = new System.Drawing.Point(87, 18);
            this.rb_desc.Margin = new System.Windows.Forms.Padding(2);
            this.rb_desc.Name = "rb_desc";
            this.rb_desc.Size = new System.Drawing.Size(47, 17);
            this.rb_desc.TabIndex = 12;
            this.rb_desc.TabStop = true;
            this.rb_desc.Text = "DES";
            this.rb_desc.UseVisualStyleBackColor = true;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(936, 1);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(63, 24);
            this.btn_regresar.TabIndex = 14;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            // 
            // btn_consimple
            // 
            this.btn_consimple.Location = new System.Drawing.Point(832, 2);
            this.btn_consimple.Margin = new System.Windows.Forms.Padding(2);
            this.btn_consimple.Name = "btn_consimple";
            this.btn_consimple.Size = new System.Drawing.Size(100, 23);
            this.btn_consimple.TabIndex = 15;
            this.btn_consimple.Text = "Consulta Simple";
            this.btn_consimple.UseVisualStyleBackColor = true;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(1004, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(48, 23);
            this.btn_cerrar.TabIndex = 16;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Lbl_Tabla
            // 
            this.Lbl_Tabla.AutoSize = true;
            this.Lbl_Tabla.Location = new System.Drawing.Point(50, 22);
            this.Lbl_Tabla.Name = "Lbl_Tabla";
            this.Lbl_Tabla.Size = new System.Drawing.Size(85, 13);
            this.Lbl_Tabla.TabIndex = 17;
            this.Lbl_Tabla.Text = "Nombre de tabla";
            // 
            // lst_Querys
            // 
            this.lst_Querys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_Querys.FormattingEnabled = true;
            this.lst_Querys.Location = new System.Drawing.Point(795, 76);
            this.lst_Querys.Name = "lst_Querys";
            this.lst_Querys.Size = new System.Drawing.Size(220, 251);
            this.lst_Querys.TabIndex = 18;
            // 
            // gpb_Orden
            // 
            this.gpb_Orden.Controls.Add(this.rb_asc);
            this.gpb_Orden.Controls.Add(this.rb_desc);
            this.gpb_Orden.Location = new System.Drawing.Point(495, 12);
            this.gpb_Orden.Name = "gpb_Orden";
            this.gpb_Orden.Size = new System.Drawing.Size(154, 38);
            this.gpb_Orden.TabIndex = 19;
            this.gpb_Orden.TabStop = false;
            this.gpb_Orden.Text = "Orden";
            // 
            // lbl_Sql
            // 
            this.lbl_Sql.AutoSize = true;
            this.lbl_Sql.Location = new System.Drawing.Point(17, 317);
            this.lbl_Sql.Name = "lbl_Sql";
            this.lbl_Sql.Size = new System.Drawing.Size(87, 13);
            this.lbl_Sql.TabIndex = 20;
            this.lbl_Sql.Text = "Consola de SQL:";
            // 
            // txt_Sql
            // 
            this.txt_Sql.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Sql.Location = new System.Drawing.Point(15, 336);
            this.txt_Sql.Multiline = true;
            this.txt_Sql.Name = "txt_Sql";
            this.txt_Sql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Sql.Size = new System.Drawing.Size(614, 60);
            this.txt_Sql.TabIndex = 21;
            // 
            // dgv_Sql
            // 
            this.dgv_Sql.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Sql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sql.Location = new System.Drawing.Point(12, 403);
            this.dgv_Sql.Name = "dgv_Sql";
            this.dgv_Sql.Size = new System.Drawing.Size(749, 190);
            this.dgv_Sql.TabIndex = 22;
            // 
            // Consulta_Compleja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 605);
            this.Controls.Add(this.dgv_Sql);
            this.Controls.Add(this.txt_Sql);
            this.Controls.Add(this.lbl_Sql);
            this.Controls.Add(this.gpb_Orden);
            this.Controls.Add(this.lst_Querys);
            this.Controls.Add(this.Lbl_Tabla);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_consimple);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_EjecutarSQL);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.Dgv_Tabla);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbo_busqueda);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Consulta_Compleja";
            this.Text = "Consulta_Compleja";
            this.Load += new System.EventHandler(this.Consulta_Compleja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tabla)).EndInit();
            this.gpb_Orden.ResumeLayout(false);
            this.gpb_Orden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sql)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbo_busqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView Dgv_Tabla;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_EjecutarSQL;
        private System.Windows.Forms.RadioButton rb_asc;
        private System.Windows.Forms.RadioButton rb_desc;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_consimple;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label Lbl_Tabla;
        private System.Windows.Forms.ListBox lst_Querys;
        private System.Windows.Forms.GroupBox gpb_Orden;
        private System.Windows.Forms.Label lbl_Sql;
        private System.Windows.Forms.TextBox txt_Sql;
        private System.Windows.Forms.DataGridView dgv_Sql;
    }
}