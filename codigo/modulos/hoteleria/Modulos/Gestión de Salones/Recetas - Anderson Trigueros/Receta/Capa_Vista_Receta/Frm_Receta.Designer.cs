
namespace Capa_Vista_Receta
{
    partial class Frm_Receta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Receta));
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Dgv_Receta = new System.Windows.Forms.DataGridView();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Cbo_Menu = new System.Windows.Forms.ComboBox();
            this.Lbl_Platillo = new System.Windows.Forms.Label();
            this.Txt_Ingrediente = new System.Windows.Forms.TextBox();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Txt_Unidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Lbl_Unidad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Receta)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lbl_Titulo.Location = new System.Drawing.Point(37, 9);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(133, 38);
            this.Lbl_Titulo.TabIndex = 4;
            this.Lbl_Titulo.Text = "Recetas";
            // 
            // Dgv_Receta
            // 
            this.Dgv_Receta.AllowUserToAddRows = false;
            this.Dgv_Receta.AllowUserToDeleteRows = false;
            this.Dgv_Receta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Receta.Location = new System.Drawing.Point(28, 225);
            this.Dgv_Receta.Name = "Dgv_Receta";
            this.Dgv_Receta.ReadOnly = true;
            this.Dgv_Receta.RowHeadersWidth = 51;
            this.Dgv_Receta.RowTemplate.Height = 24;
            this.Dgv_Receta.Size = new System.Drawing.Size(981, 321);
            this.Dgv_Receta.TabIndex = 5;
            this.Dgv_Receta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pro_Dgv_Receta_CellClick);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.White;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(770, 11);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(53, 46);
            this.Btn_guardar.TabIndex = 14;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.pro_Btn_guardar_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.Color.White;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar.Image")));
            this.Btn_Limpiar.Location = new System.Drawing.Point(942, 11);
            this.Btn_Limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(53, 46);
            this.Btn_Limpiar.TabIndex = 17;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.pro_Btn_Limpiar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(888, 11);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(48, 46);
            this.Btn_Eliminar.TabIndex = 16;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.pro_Btn_Eliminar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.White;
            this.Btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(829, 11);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(53, 46);
            this.Btn_Modificar.TabIndex = 15;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.pro_Btn_Modificar_Click);
            // 
            // Cbo_Menu
            // 
            this.Cbo_Menu.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Menu.FormattingEnabled = true;
            this.Cbo_Menu.Location = new System.Drawing.Point(44, 134);
            this.Cbo_Menu.Name = "Cbo_Menu";
            this.Cbo_Menu.Size = new System.Drawing.Size(226, 28);
            this.Cbo_Menu.TabIndex = 6;
            this.Cbo_Menu.SelectedIndexChanged += new System.EventHandler(this.Cbo_Menu_SelectedIndexChanged);
            // 
            // Lbl_Platillo
            // 
            this.Lbl_Platillo.AutoSize = true;
            this.Lbl_Platillo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Platillo.Location = new System.Drawing.Point(40, 111);
            this.Lbl_Platillo.Name = "Lbl_Platillo";
            this.Lbl_Platillo.Size = new System.Drawing.Size(169, 20);
            this.Lbl_Platillo.TabIndex = 7;
            this.Lbl_Platillo.Text = "Seleccione un menu";
            // 
            // Txt_Ingrediente
            // 
            this.Txt_Ingrediente.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Ingrediente.Location = new System.Drawing.Point(307, 134);
            this.Txt_Ingrediente.Name = "Txt_Ingrediente";
            this.Txt_Ingrediente.Size = new System.Drawing.Size(241, 27);
            this.Txt_Ingrediente.TabIndex = 8;
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cantidad.Location = new System.Drawing.Point(571, 135);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(157, 27);
            this.Txt_Cantidad.TabIndex = 9;
            // 
            // Txt_Unidad
            // 
            this.Txt_Unidad.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Unidad.Location = new System.Drawing.Point(755, 135);
            this.Txt_Unidad.Name = "Txt_Unidad";
            this.Txt_Unidad.Size = new System.Drawing.Size(241, 27);
            this.Txt_Unidad.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingrediente";
            // 
            // Lbl_Cantidad
            // 
            this.Lbl_Cantidad.AutoSize = true;
            this.Lbl_Cantidad.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cantidad.Location = new System.Drawing.Point(567, 112);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(80, 20);
            this.Lbl_Cantidad.TabIndex = 12;
            this.Lbl_Cantidad.Text = "Cantidad";
            // 
            // Lbl_Unidad
            // 
            this.Lbl_Unidad.AutoSize = true;
            this.Lbl_Unidad.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Unidad.Location = new System.Drawing.Point(751, 112);
            this.Lbl_Unidad.Name = "Lbl_Unidad";
            this.Lbl_Unidad.Size = new System.Drawing.Size(152, 20);
            this.Lbl_Unidad.TabIndex = 13;
            this.Lbl_Unidad.Text = "Unidad de Medida";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 121);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.BackColor = System.Drawing.Color.White;
            this.Btn_Reporte.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Reporte.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Reporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(708, 12);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(56, 46);
            this.Btn_Reporte.TabIndex = 161;
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Reporte.UseVisualStyleBackColor = false;
            this.Btn_Reporte.Click += new System.EventHandler(this.pro_Btn_Reporte_Click);
            // 
            // Frm_Receta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 615);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Lbl_Unidad);
            this.Controls.Add(this.Lbl_Cantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Unidad);
            this.Controls.Add(this.Txt_Cantidad);
            this.Controls.Add(this.Txt_Ingrediente);
            this.Controls.Add(this.Lbl_Platillo);
            this.Controls.Add(this.Cbo_Menu);
            this.Controls.Add(this.Dgv_Receta);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Receta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Receta";
            this.Load += new System.EventHandler(this.pro_Frm_Receta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Receta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.DataGridView Dgv_Receta;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.ComboBox Cbo_Menu;
        private System.Windows.Forms.Label Lbl_Platillo;
        private System.Windows.Forms.TextBox Txt_Ingrediente;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.TextBox Txt_Unidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.Label Lbl_Unidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Reporte;
    }
}