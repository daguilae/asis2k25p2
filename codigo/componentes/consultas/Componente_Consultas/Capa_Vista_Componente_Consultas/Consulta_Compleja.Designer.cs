
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
            this.cmb_busqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_rango = new System.Windows.Forms.Button();
            this.rb_asc = new System.Windows.Forms.RadioButton();
            this.rb_desc = new System.Windows.Forms.RadioButton();
            this.lbl_orden = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_consimple = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_busqueda
            // 
            this.cmb_busqueda.FormattingEnabled = true;
            this.cmb_busqueda.Location = new System.Drawing.Point(295, 69);
            this.cmb_busqueda.Name = "cmb_busqueda";
            this.cmb_busqueda.Size = new System.Drawing.Size(253, 24);
            this.cmb_busqueda.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Image = global::Capa_Vista_Componente_Consultas.Properties.Resources.android_search_icon_icons_com_50501;
            this.btn_buscar.Location = new System.Drawing.Point(555, 42);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(93, 74);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_buscar.UseCompatibleTextRendering = true;
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(870, 274);
            this.dataGridView1.TabIndex = 7;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(102, 451);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(90, 39);
            this.btn_editar.TabIndex = 8;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(248, 451);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(90, 39);
            this.btn_eliminar.TabIndex = 9;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_rango
            // 
            this.btn_rango.Location = new System.Drawing.Point(388, 451);
            this.btn_rango.Name = "btn_rango";
            this.btn_rango.Size = new System.Drawing.Size(97, 39);
            this.btn_rango.TabIndex = 10;
            this.btn_rango.Text = "Rango";
            this.btn_rango.UseVisualStyleBackColor = true;
            // 
            // rb_asc
            // 
            this.rb_asc.AutoSize = true;
            this.rb_asc.Location = new System.Drawing.Point(567, 469);
            this.rb_asc.Name = "rb_asc";
            this.rb_asc.Size = new System.Drawing.Size(56, 21);
            this.rb_asc.TabIndex = 11;
            this.rb_asc.TabStop = true;
            this.rb_asc.Text = "ASC";
            this.rb_asc.UseVisualStyleBackColor = true;
            // 
            // rb_desc
            // 
            this.rb_desc.AutoSize = true;
            this.rb_desc.Location = new System.Drawing.Point(670, 469);
            this.rb_desc.Name = "rb_desc";
            this.rb_desc.Size = new System.Drawing.Size(57, 21);
            this.rb_desc.TabIndex = 12;
            this.rb_desc.TabStop = true;
            this.rb_desc.Text = "DES";
            this.rb_desc.UseVisualStyleBackColor = true;
            // 
            // lbl_orden
            // 
            this.lbl_orden.AutoSize = true;
            this.lbl_orden.Location = new System.Drawing.Point(619, 442);
            this.lbl_orden.Name = "lbl_orden";
            this.lbl_orden.Size = new System.Drawing.Size(48, 17);
            this.lbl_orden.TabIndex = 13;
            this.lbl_orden.Text = "Orden";
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(855, 22);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(84, 29);
            this.btn_regresar.TabIndex = 14;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            // 
            // btn_consimple
            // 
            this.btn_consimple.Location = new System.Drawing.Point(746, 22);
            this.btn_consimple.Name = "btn_consimple";
            this.btn_consimple.Size = new System.Drawing.Size(91, 48);
            this.btn_consimple.TabIndex = 15;
            this.btn_consimple.Text = "Consulta Simple";
            this.btn_consimple.UseVisualStyleBackColor = true;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(962, 22);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(64, 28);
            this.btn_cerrar.TabIndex = 16;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // Consulta_Compleja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 633);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_consimple);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.lbl_orden);
            this.Controls.Add(this.rb_desc);
            this.Controls.Add(this.rb_asc);
            this.Controls.Add(this.btn_rango);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_busqueda);
            this.Name = "Consulta_Compleja";
            this.Text = "Consulta_Compleja";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_busqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_rango;
        private System.Windows.Forms.RadioButton rb_asc;
        private System.Windows.Forms.RadioButton rb_desc;
        private System.Windows.Forms.Label lbl_orden;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_consimple;
        private System.Windows.Forms.Button btn_cerrar;
    }
}