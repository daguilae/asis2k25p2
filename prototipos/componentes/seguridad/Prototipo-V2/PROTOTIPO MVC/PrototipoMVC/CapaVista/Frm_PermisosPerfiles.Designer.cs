
namespace Capa_Vista_Seguridad
{
    partial class Frm_PermisosPerfiles
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
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Gbp_datos = new System.Windows.Forms.GroupBox();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Cbo_aplicaciones = new System.Windows.Forms.ComboBox();
            this.Cbo_Modulos = new System.Windows.Forms.ComboBox();
            this.Cbo_perfiles = new System.Windows.Forms.ComboBox();
            this.Lbl_aplicaciones = new System.Windows.Forms.Label();
            this.Lbl_Perfiles = new System.Windows.Forms.Label();
            this.Lbl_modulos = new System.Windows.Forms.Label();
            this.Dgv_Permisos = new System.Windows.Forms.DataGridView();
            this.Btn_quitar = new System.Windows.Forms.Button();
            this.Btn_insertar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pic_Cerrar = new System.Windows.Forms.PictureBox();
            this.Gbp_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Permisos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(102, 35);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(375, 29);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "Asignacion Aplicacion Perfiles";
            // 
            // Gbp_datos
            // 
            this.Gbp_datos.Controls.Add(this.Btn_agregar);
            this.Gbp_datos.Controls.Add(this.Cbo_aplicaciones);
            this.Gbp_datos.Controls.Add(this.Cbo_Modulos);
            this.Gbp_datos.Controls.Add(this.Cbo_perfiles);
            this.Gbp_datos.Controls.Add(this.Lbl_aplicaciones);
            this.Gbp_datos.Controls.Add(this.Lbl_Perfiles);
            this.Gbp_datos.Controls.Add(this.Lbl_modulos);
            this.Gbp_datos.Location = new System.Drawing.Point(9, 85);
            this.Gbp_datos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Gbp_datos.Name = "Gbp_datos";
            this.Gbp_datos.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Gbp_datos.Size = new System.Drawing.Size(585, 97);
            this.Gbp_datos.TabIndex = 2;
            this.Gbp_datos.TabStop = false;
            this.Gbp_datos.Text = "Datos";
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.Btn_agregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_agregar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_agregar.Image = global::Capa_Vista_Seguridad.Properties.Resources.add_insert_new_plus_button_icon_142943;
            this.Btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_agregar.Location = new System.Drawing.Point(459, 36);
            this.Btn_agregar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(95, 42);
            this.Btn_agregar.TabIndex = 5;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_agregar.UseVisualStyleBackColor = false;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Cbo_aplicaciones
            // 
            this.Cbo_aplicaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.Cbo_aplicaciones.FormattingEnabled = true;
            this.Cbo_aplicaciones.Location = new System.Drawing.Point(310, 49);
            this.Cbo_aplicaciones.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Cbo_aplicaciones.Name = "Cbo_aplicaciones";
            this.Cbo_aplicaciones.Size = new System.Drawing.Size(130, 21);
            this.Cbo_aplicaciones.TabIndex = 4;
            // 
            // Cbo_Modulos
            // 
            this.Cbo_Modulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.Cbo_Modulos.FormattingEnabled = true;
            this.Cbo_Modulos.Location = new System.Drawing.Point(150, 49);
            this.Cbo_Modulos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Cbo_Modulos.Name = "Cbo_Modulos";
            this.Cbo_Modulos.Size = new System.Drawing.Size(130, 21);
            this.Cbo_Modulos.TabIndex = 3;
            // 
            // Cbo_perfiles
            // 
            this.Cbo_perfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.Cbo_perfiles.FormattingEnabled = true;
            this.Cbo_perfiles.Location = new System.Drawing.Point(11, 49);
            this.Cbo_perfiles.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Cbo_perfiles.Name = "Cbo_perfiles";
            this.Cbo_perfiles.Size = new System.Drawing.Size(113, 21);
            this.Cbo_perfiles.TabIndex = 2;
            // 
            // Lbl_aplicaciones
            // 
            this.Lbl_aplicaciones.AutoSize = true;
            this.Lbl_aplicaciones.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_aplicaciones.Location = new System.Drawing.Point(317, 23);
            this.Lbl_aplicaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_aplicaciones.Name = "Lbl_aplicaciones";
            this.Lbl_aplicaciones.Size = new System.Drawing.Size(90, 17);
            this.Lbl_aplicaciones.TabIndex = 1;
            this.Lbl_aplicaciones.Text = "Aplicaciones";
            // 
            // Lbl_Perfiles
            // 
            this.Lbl_Perfiles.AutoSize = true;
            this.Lbl_Perfiles.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Perfiles.Location = new System.Drawing.Point(31, 23);
            this.Lbl_Perfiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Perfiles.Name = "Lbl_Perfiles";
            this.Lbl_Perfiles.Size = new System.Drawing.Size(56, 17);
            this.Lbl_Perfiles.TabIndex = 0;
            this.Lbl_Perfiles.Text = "Perfiles";
            // 
            // Lbl_modulos
            // 
            this.Lbl_modulos.AutoSize = true;
            this.Lbl_modulos.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_modulos.Location = new System.Drawing.Point(179, 23);
            this.Lbl_modulos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_modulos.Name = "Lbl_modulos";
            this.Lbl_modulos.Size = new System.Drawing.Size(63, 17);
            this.Lbl_modulos.TabIndex = 0;
            this.Lbl_modulos.Text = "Modulos";
            // 
            // Dgv_Permisos
            // 
            this.Dgv_Permisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Permisos.Location = new System.Drawing.Point(20, 196);
            this.Dgv_Permisos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Dgv_Permisos.Name = "Dgv_Permisos";
            this.Dgv_Permisos.RowHeadersWidth = 51;
            this.Dgv_Permisos.RowTemplate.Height = 24;
            this.Dgv_Permisos.Size = new System.Drawing.Size(427, 175);
            this.Dgv_Permisos.TabIndex = 3;
            // 
            // Btn_quitar
            // 
            this.Btn_quitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.Btn_quitar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_quitar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_quitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_quitar.Image = global::Capa_Vista_Seguridad.Properties.Resources.delete_remove_trash_icon_177304;
            this.Btn_quitar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_quitar.Location = new System.Drawing.Point(480, 257);
            this.Btn_quitar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn_quitar.Name = "Btn_quitar";
            this.Btn_quitar.Size = new System.Drawing.Size(95, 42);
            this.Btn_quitar.TabIndex = 7;
            this.Btn_quitar.Text = "Quitar";
            this.Btn_quitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_quitar.UseVisualStyleBackColor = false;
            this.Btn_quitar.Click += new System.EventHandler(this.Btn_quitar_Click);
            // 
            // Btn_insertar
            // 
            this.Btn_insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.Btn_insertar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_insertar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_insertar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_insertar.Image = global::Capa_Vista_Seguridad.Properties.Resources.add_insert_new_plus_button_icon_142943;
            this.Btn_insertar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_insertar.Location = new System.Drawing.Point(480, 304);
            this.Btn_insertar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn_insertar.Name = "Btn_insertar";
            this.Btn_insertar.Size = new System.Drawing.Size(95, 42);
            this.Btn_insertar.TabIndex = 8;
            this.Btn_insertar.Text = "Insertar";
            this.Btn_insertar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_insertar.UseVisualStyleBackColor = false;
            this.Btn_insertar.Click += new System.EventHandler(this.Btn_insertar_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.Btn_salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_salir.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_salir.Image = global::Capa_Vista_Seguridad.Properties.Resources.sign_emergency_code_sos_61_icon_icons_com_57216;
            this.Btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_salir.Location = new System.Drawing.Point(480, 359);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(95, 42);
            this.Btn_salir.TabIndex = 9;
            this.Btn_salir.Text = "  Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.Btn_Buscar.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Btn_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Buscar.Location = new System.Drawing.Point(480, 209);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(95, 42);
            this.Btn_Buscar.TabIndex = 97;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.Pic_Cerrar);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 36);
            this.panel1.TabIndex = 98;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_Superior_MouseDown);
            // 
            // Pic_Cerrar
            // 
            this.Pic_Cerrar.Image = global::Capa_Vista_Seguridad.Properties.Resources.Cancel_icon_icons_com_73703;
            this.Pic_Cerrar.Location = new System.Drawing.Point(597, 4);
            this.Pic_Cerrar.Name = "Pic_Cerrar";
            this.Pic_Cerrar.Size = new System.Drawing.Size(31, 32);
            this.Pic_Cerrar.TabIndex = 0;
            this.Pic_Cerrar.TabStop = false;
            this.Pic_Cerrar.Click += new System.EventHandler(this.Pic_Cerrar_Click_1);
            // 
            // Frm_PermisosPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(627, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_insertar);
            this.Controls.Add(this.Btn_quitar);
            this.Controls.Add(this.Dgv_Permisos);
            this.Controls.Add(this.Gbp_datos);
            this.Controls.Add(this.Lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Frm_PermisosPerfiles";
            this.Text = "FrmPermisosPerfiles";
            this.Load += new System.EventHandler(this.FrmPermisosPerfiles_Load);
            this.Gbp_datos.ResumeLayout(false);
            this.Gbp_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Permisos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.GroupBox Gbp_datos;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.ComboBox Cbo_aplicaciones;
        private System.Windows.Forms.ComboBox Cbo_Modulos;
        private System.Windows.Forms.ComboBox Cbo_perfiles;
        private System.Windows.Forms.Label Lbl_aplicaciones;
        private System.Windows.Forms.Label Lbl_Perfiles;
        private System.Windows.Forms.Label Lbl_modulos;
        private System.Windows.Forms.DataGridView Dgv_Permisos;
        private System.Windows.Forms.Button Btn_quitar;
        private System.Windows.Forms.Button Btn_insertar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Pic_Cerrar;
    }
}