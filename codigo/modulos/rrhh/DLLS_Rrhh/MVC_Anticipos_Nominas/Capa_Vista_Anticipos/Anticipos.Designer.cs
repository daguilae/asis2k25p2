
namespace Capa_Vista_Anticipos
{
    partial class Anticipos
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
            this.Gpb_anticipos = new System.Windows.Forms.GroupBox();
            this.Lbl_NombreEmpleado = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Dgv_anticipo = new System.Windows.Forms.DataGridView();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_solicitar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Pnl_Encabezado = new System.Windows.Forms.Panel();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Gpb_anticipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_anticipo)).BeginInit();
            this.Pnl_Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_anticipos
            // 
            this.Gpb_anticipos.Controls.Add(this.Lbl_NombreEmpleado);
            this.Gpb_anticipos.Controls.Add(this.comboBox1);
            this.Gpb_anticipos.Controls.Add(this.Btn_buscar);
            this.Gpb_anticipos.Controls.Add(this.Btn_solicitar);
            this.Gpb_anticipos.Controls.Add(this.Btn_modificar);
            this.Gpb_anticipos.Controls.Add(this.Btn_eliminar);
            this.Gpb_anticipos.Controls.Add(this.Dgv_anticipo);
            this.Gpb_anticipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Gpb_anticipos.Location = new System.Drawing.Point(85, 118);
            this.Gpb_anticipos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Gpb_anticipos.Name = "Gpb_anticipos";
            this.Gpb_anticipos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Gpb_anticipos.Size = new System.Drawing.Size(1244, 717);
            this.Gpb_anticipos.TabIndex = 8;
            this.Gpb_anticipos.TabStop = false;
            this.Gpb_anticipos.Text = "Anticipos";
            // 
            // Lbl_NombreEmpleado
            // 
            this.Lbl_NombreEmpleado.AutoSize = true;
            this.Lbl_NombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Lbl_NombreEmpleado.Location = new System.Drawing.Point(15, 86);
            this.Lbl_NombreEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_NombreEmpleado.Name = "Lbl_NombreEmpleado";
            this.Lbl_NombreEmpleado.Size = new System.Drawing.Size(317, 40);
            this.Lbl_NombreEmpleado.TabIndex = 1;
            this.Lbl_NombreEmpleado.Text = "Nombre Empleado";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(376, 82);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(316, 48);
            this.comboBox1.TabIndex = 2;
            // 
            // Dgv_anticipo
            // 
            this.Dgv_anticipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_anticipo.Location = new System.Drawing.Point(22, 149);
            this.Dgv_anticipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dgv_anticipo.Name = "Dgv_anticipo";
            this.Dgv_anticipo.RowHeadersWidth = 62;
            this.Dgv_anticipo.Size = new System.Drawing.Size(1164, 489);
            this.Dgv_anticipo.TabIndex = 0;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_buscar.Image = global::Capa_Vista_Anticipos.Properties.Resources.android_search_icon_icons_com_50501;
            this.Btn_buscar.Location = new System.Drawing.Point(722, 43);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(106, 97);
            this.Btn_buscar.TabIndex = 3;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_solicitar
            // 
            this.Btn_solicitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_solicitar.Image = global::Capa_Vista_Anticipos.Properties.Resources.add_insert_new_plus_button_icon_142943;
            this.Btn_solicitar.Location = new System.Drawing.Point(837, 43);
            this.Btn_solicitar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_solicitar.Name = "Btn_solicitar";
            this.Btn_solicitar.Size = new System.Drawing.Size(106, 97);
            this.Btn_solicitar.TabIndex = 4;
            this.Btn_solicitar.Text = "Solicitar";
            this.Btn_solicitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_solicitar.UseVisualStyleBackColor = true;
            this.Btn_solicitar.Click += new System.EventHandler(this.Btn_solicitar_Click);
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_modificar.Image = global::Capa_Vista_Anticipos.Properties.Resources.compose_edit_modify_icon_177770;
            this.Btn_modificar.Location = new System.Drawing.Point(952, 43);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(118, 97);
            this.Btn_modificar.TabIndex = 5;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_modificar.UseVisualStyleBackColor = true;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_eliminar.Image = global::Capa_Vista_Anticipos.Properties.Resources.delete_remove_trash_icon_177304;
            this.Btn_eliminar.Location = new System.Drawing.Point(1080, 43);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(106, 97);
            this.Btn_eliminar.TabIndex = 6;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Pnl_Encabezado
            // 
            this.Pnl_Encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Pnl_Encabezado.Controls.Add(this.Lbl_Titulo);
            this.Pnl_Encabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Encabezado.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Encabezado.Name = "Pnl_Encabezado";
            this.Pnl_Encabezado.Size = new System.Drawing.Size(1381, 96);
            this.Pnl_Encabezado.TabIndex = 13;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Lbl_Titulo.Location = new System.Drawing.Point(91, 23);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(163, 40);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Anticipos";
            // 
            // Anticipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 862);
            this.Controls.Add(this.Pnl_Encabezado);
            this.Controls.Add(this.Gpb_anticipos);
            this.Name = "Anticipos";
            this.Text = "Anticipos";
            this.Gpb_anticipos.ResumeLayout(false);
            this.Gpb_anticipos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_anticipo)).EndInit();
            this.Pnl_Encabezado.ResumeLayout(false);
            this.Pnl_Encabezado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_anticipos;
        private System.Windows.Forms.Label Lbl_NombreEmpleado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_solicitar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.DataGridView Dgv_anticipo;
        private System.Windows.Forms.Panel Pnl_Encabezado;
        private System.Windows.Forms.Label Lbl_Titulo;
    }
}