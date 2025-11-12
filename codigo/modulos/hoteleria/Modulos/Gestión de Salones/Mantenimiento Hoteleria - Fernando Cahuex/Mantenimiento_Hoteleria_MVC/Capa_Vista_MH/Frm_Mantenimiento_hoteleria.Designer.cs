
namespace Capa_Vista_MH
{
    partial class Frm_Mantenimiento_hoteleria
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
            this.Lbl_Mantenimiento = new System.Windows.Forms.Label();
            this.Dgv_Mantenimiento_hoteleria = new System.Windows.Forms.DataGridView();
            this.Lbl_Id_mantenimiento = new System.Windows.Forms.Label();
            this.Lbl_Id_Salon = new System.Windows.Forms.Label();
            this.Lbl_Id_Habitacion = new System.Windows.Forms.Label();
            this.Lbl_Id_Empleado = new System.Windows.Forms.Label();
            this.Lbl_Tipo_Mantenimiento = new System.Windows.Forms.Label();
            this.Lbl_Desc_Mantenimiento = new System.Windows.Forms.Label();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Inicio = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Fin = new System.Windows.Forms.Label();
            this.Cbo_Id_Mantenimiento = new System.Windows.Forms.ComboBox();
            this.Cbo_Id_Salon = new System.Windows.Forms.ComboBox();
            this.Cbo_Id_Habitacion = new System.Windows.Forms.ComboBox();
            this.Cbo_Id_Empleado = new System.Windows.Forms.ComboBox();
            this.Txt_Tipo_Mantenimiento = new System.Windows.Forms.TextBox();
            this.Txt_Descripcion_Mantenimiento = new System.Windows.Forms.TextBox();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.Dtp_Fecha_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Fecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.Pic_Reporte = new System.Windows.Forms.PictureBox();
            this.Pic_Buscar = new System.Windows.Forms.PictureBox();
            this.Pic_Eliminar = new System.Windows.Forms.PictureBox();
            this.Pic_Guardar = new System.Windows.Forms.PictureBox();
            this.Pic_Editar = new System.Windows.Forms.PictureBox();
            this.Pic_Cancelar = new System.Windows.Forms.PictureBox();
            this.Pic_Salir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Mantenimiento_hoteleria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Reporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Mantenimiento
            // 
            this.Lbl_Mantenimiento.AutoSize = true;
            this.Lbl_Mantenimiento.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mantenimiento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Mantenimiento.Location = new System.Drawing.Point(507, 66);
            this.Lbl_Mantenimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Mantenimiento.Name = "Lbl_Mantenimiento";
            this.Lbl_Mantenimiento.Size = new System.Drawing.Size(357, 35);
            this.Lbl_Mantenimiento.TabIndex = 3;
            this.Lbl_Mantenimiento.Text = "Mantenimiento Hoteleria";
            // 
            // Dgv_Mantenimiento_hoteleria
            // 
            this.Dgv_Mantenimiento_hoteleria.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dgv_Mantenimiento_hoteleria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Mantenimiento_hoteleria.Location = new System.Drawing.Point(63, 420);
            this.Dgv_Mantenimiento_hoteleria.Name = "Dgv_Mantenimiento_hoteleria";
            this.Dgv_Mantenimiento_hoteleria.ReadOnly = true;
            this.Dgv_Mantenimiento_hoteleria.RowHeadersWidth = 51;
            this.Dgv_Mantenimiento_hoteleria.RowTemplate.Height = 24;
            this.Dgv_Mantenimiento_hoteleria.Size = new System.Drawing.Size(1216, 279);
            this.Dgv_Mantenimiento_hoteleria.TabIndex = 102;
            // 
            // Lbl_Id_mantenimiento
            // 
            this.Lbl_Id_mantenimiento.AutoSize = true;
            this.Lbl_Id_mantenimiento.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_Id_mantenimiento.Location = new System.Drawing.Point(150, 176);
            this.Lbl_Id_mantenimiento.Name = "Lbl_Id_mantenimiento";
            this.Lbl_Id_mantenimiento.Size = new System.Drawing.Size(214, 20);
            this.Lbl_Id_mantenimiento.TabIndex = 103;
            this.Lbl_Id_mantenimiento.Text = "Codigo de Mantenimiento";
            // 
            // Lbl_Id_Salon
            // 
            this.Lbl_Id_Salon.AutoSize = true;
            this.Lbl_Id_Salon.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_Id_Salon.Location = new System.Drawing.Point(150, 256);
            this.Lbl_Id_Salon.Name = "Lbl_Id_Salon";
            this.Lbl_Id_Salon.Size = new System.Drawing.Size(138, 20);
            this.Lbl_Id_Salon.TabIndex = 104;
            this.Lbl_Id_Salon.Text = "Codigo de Salon";
            // 
            // Lbl_Id_Habitacion
            // 
            this.Lbl_Id_Habitacion.AutoSize = true;
            this.Lbl_Id_Habitacion.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_Id_Habitacion.Location = new System.Drawing.Point(150, 341);
            this.Lbl_Id_Habitacion.Name = "Lbl_Id_Habitacion";
            this.Lbl_Id_Habitacion.Size = new System.Drawing.Size(179, 20);
            this.Lbl_Id_Habitacion.TabIndex = 105;
            this.Lbl_Id_Habitacion.Text = "Codigo de Habitacion";
            // 
            // Lbl_Id_Empleado
            // 
            this.Lbl_Id_Empleado.AutoSize = true;
            this.Lbl_Id_Empleado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Empleado.Location = new System.Drawing.Point(563, 174);
            this.Lbl_Id_Empleado.Name = "Lbl_Id_Empleado";
            this.Lbl_Id_Empleado.Size = new System.Drawing.Size(175, 20);
            this.Lbl_Id_Empleado.TabIndex = 106;
            this.Lbl_Id_Empleado.Text = "Codigo de Empleado";
            // 
            // Lbl_Tipo_Mantenimiento
            // 
            this.Lbl_Tipo_Mantenimiento.AutoSize = true;
            this.Lbl_Tipo_Mantenimiento.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_Tipo_Mantenimiento.Location = new System.Drawing.Point(563, 254);
            this.Lbl_Tipo_Mantenimiento.Name = "Lbl_Tipo_Mantenimiento";
            this.Lbl_Tipo_Mantenimiento.Size = new System.Drawing.Size(191, 20);
            this.Lbl_Tipo_Mantenimiento.TabIndex = 107;
            this.Lbl_Tipo_Mantenimiento.Text = "Tipo de Mantenimiento";
            // 
            // Lbl_Desc_Mantenimiento
            // 
            this.Lbl_Desc_Mantenimiento.AutoSize = true;
            this.Lbl_Desc_Mantenimiento.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_Desc_Mantenimiento.Location = new System.Drawing.Point(563, 339);
            this.Lbl_Desc_Mantenimiento.Name = "Lbl_Desc_Mantenimiento";
            this.Lbl_Desc_Mantenimiento.Size = new System.Drawing.Size(251, 20);
            this.Lbl_Desc_Mantenimiento.TabIndex = 108;
            this.Lbl_Desc_Mantenimiento.Text = "Descripcion de Mantenimiento";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_Estado.Location = new System.Drawing.Point(971, 174);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(62, 20);
            this.Lbl_Estado.TabIndex = 109;
            this.Lbl_Estado.Text = "Estado";
            // 
            // Lbl_Fecha_Inicio
            // 
            this.Lbl_Fecha_Inicio.AutoSize = true;
            this.Lbl_Fecha_Inicio.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_Fecha_Inicio.Location = new System.Drawing.Point(971, 254);
            this.Lbl_Fecha_Inicio.Name = "Lbl_Fecha_Inicio";
            this.Lbl_Fecha_Inicio.Size = new System.Drawing.Size(128, 20);
            this.Lbl_Fecha_Inicio.TabIndex = 110;
            this.Lbl_Fecha_Inicio.Text = "Fecha de inicio";
            // 
            // Lbl_Fecha_Fin
            // 
            this.Lbl_Fecha_Fin.AutoSize = true;
            this.Lbl_Fecha_Fin.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_Fecha_Fin.Location = new System.Drawing.Point(971, 339);
            this.Lbl_Fecha_Fin.Name = "Lbl_Fecha_Fin";
            this.Lbl_Fecha_Fin.Size = new System.Drawing.Size(174, 20);
            this.Lbl_Fecha_Fin.TabIndex = 111;
            this.Lbl_Fecha_Fin.Text = "Fecha de finalizacion";
            // 
            // Cbo_Id_Mantenimiento
            // 
            this.Cbo_Id_Mantenimiento.FormattingEnabled = true;
            this.Cbo_Id_Mantenimiento.Location = new System.Drawing.Point(154, 210);
            this.Cbo_Id_Mantenimiento.Name = "Cbo_Id_Mantenimiento";
            this.Cbo_Id_Mantenimiento.Size = new System.Drawing.Size(210, 24);
            this.Cbo_Id_Mantenimiento.TabIndex = 112;
            // 
            // Cbo_Id_Salon
            // 
            this.Cbo_Id_Salon.FormattingEnabled = true;
            this.Cbo_Id_Salon.Location = new System.Drawing.Point(154, 293);
            this.Cbo_Id_Salon.Name = "Cbo_Id_Salon";
            this.Cbo_Id_Salon.Size = new System.Drawing.Size(210, 24);
            this.Cbo_Id_Salon.TabIndex = 113;
            this.Cbo_Id_Salon.SelectedIndexChanged += new System.EventHandler(this.Cbo_Id_Salon_TextChanged);
            this.Cbo_Id_Salon.TextChanged += new System.EventHandler(this.Cbo_Id_Salon_TextChanged);
            // 
            // Cbo_Id_Habitacion
            // 
            this.Cbo_Id_Habitacion.FormattingEnabled = true;
            this.Cbo_Id_Habitacion.Location = new System.Drawing.Point(154, 374);
            this.Cbo_Id_Habitacion.Name = "Cbo_Id_Habitacion";
            this.Cbo_Id_Habitacion.Size = new System.Drawing.Size(210, 24);
            this.Cbo_Id_Habitacion.TabIndex = 114;
            this.Cbo_Id_Habitacion.SelectedIndexChanged += new System.EventHandler(this.Cbo_Id_Habitacion_TextChanged);
            this.Cbo_Id_Habitacion.TextChanged += new System.EventHandler(this.Cbo_Id_Habitacion_TextChanged);
            // 
            // Cbo_Id_Empleado
            // 
            this.Cbo_Id_Empleado.FormattingEnabled = true;
            this.Cbo_Id_Empleado.Location = new System.Drawing.Point(567, 208);
            this.Cbo_Id_Empleado.Name = "Cbo_Id_Empleado";
            this.Cbo_Id_Empleado.Size = new System.Drawing.Size(210, 24);
            this.Cbo_Id_Empleado.TabIndex = 115;
            // 
            // Txt_Tipo_Mantenimiento
            // 
            this.Txt_Tipo_Mantenimiento.Location = new System.Drawing.Point(567, 293);
            this.Txt_Tipo_Mantenimiento.Name = "Txt_Tipo_Mantenimiento";
            this.Txt_Tipo_Mantenimiento.Size = new System.Drawing.Size(210, 22);
            this.Txt_Tipo_Mantenimiento.TabIndex = 116;
            // 
            // Txt_Descripcion_Mantenimiento
            // 
            this.Txt_Descripcion_Mantenimiento.Location = new System.Drawing.Point(567, 374);
            this.Txt_Descripcion_Mantenimiento.Name = "Txt_Descripcion_Mantenimiento";
            this.Txt_Descripcion_Mantenimiento.Size = new System.Drawing.Size(210, 22);
            this.Txt_Descripcion_Mantenimiento.TabIndex = 117;
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Location = new System.Drawing.Point(975, 210);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(210, 22);
            this.Txt_Estado.TabIndex = 118;
            // 
            // Dtp_Fecha_Inicio
            // 
            this.Dtp_Fecha_Inicio.Location = new System.Drawing.Point(975, 293);
            this.Dtp_Fecha_Inicio.Name = "Dtp_Fecha_Inicio";
            this.Dtp_Fecha_Inicio.Size = new System.Drawing.Size(210, 22);
            this.Dtp_Fecha_Inicio.TabIndex = 119;
            // 
            // Dtp_Fecha_Fin
            // 
            this.Dtp_Fecha_Fin.Location = new System.Drawing.Point(975, 374);
            this.Dtp_Fecha_Fin.Name = "Dtp_Fecha_Fin";
            this.Dtp_Fecha_Fin.Size = new System.Drawing.Size(210, 22);
            this.Dtp_Fecha_Fin.TabIndex = 120;
            // 
            // Pic_Reporte
            // 
            this.Pic_Reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Reporte.Image = global::Capa_Vista_MH.Properties.Resources.icono_imprimir;
            this.Pic_Reporte.Location = new System.Drawing.Point(1125, 102);
            this.Pic_Reporte.Name = "Pic_Reporte";
            this.Pic_Reporte.Size = new System.Drawing.Size(42, 42);
            this.Pic_Reporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Reporte.TabIndex = 123;
            this.Pic_Reporte.TabStop = false;
            this.Pic_Reporte.Click += new System.EventHandler(this.Pic_Reporte_Click);
            // 
            // Pic_Buscar
            // 
            this.Pic_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Buscar.Image = global::Capa_Vista_MH.Properties.Resources.icono_buscar;
            this.Pic_Buscar.Location = new System.Drawing.Point(893, 102);
            this.Pic_Buscar.Name = "Pic_Buscar";
            this.Pic_Buscar.Size = new System.Drawing.Size(42, 42);
            this.Pic_Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Buscar.TabIndex = 122;
            this.Pic_Buscar.TabStop = false;
            this.Pic_Buscar.Click += new System.EventHandler(this.Pic_Buscar_Click);
            // 
            // Pic_Eliminar
            // 
            this.Pic_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Eliminar.Image = global::Capa_Vista_MH.Properties.Resources.icono_eliminar;
            this.Pic_Eliminar.Location = new System.Drawing.Point(1066, 102);
            this.Pic_Eliminar.Name = "Pic_Eliminar";
            this.Pic_Eliminar.Size = new System.Drawing.Size(42, 42);
            this.Pic_Eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Eliminar.TabIndex = 121;
            this.Pic_Eliminar.TabStop = false;
            this.Pic_Eliminar.Click += new System.EventHandler(this.Pic_Eliminar_Click);
            // 
            // Pic_Guardar
            // 
            this.Pic_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Guardar.Image = global::Capa_Vista_MH.Properties.Resources.icono_guardar;
            this.Pic_Guardar.Location = new System.Drawing.Point(950, 102);
            this.Pic_Guardar.Name = "Pic_Guardar";
            this.Pic_Guardar.Size = new System.Drawing.Size(42, 42);
            this.Pic_Guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Guardar.TabIndex = 101;
            this.Pic_Guardar.TabStop = false;
            this.Pic_Guardar.Click += new System.EventHandler(this.Pic_Guardar_Click);
            // 
            // Pic_Editar
            // 
            this.Pic_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Editar.Image = global::Capa_Vista_MH.Properties.Resources.icono_modificar;
            this.Pic_Editar.Location = new System.Drawing.Point(1009, 102);
            this.Pic_Editar.Name = "Pic_Editar";
            this.Pic_Editar.Size = new System.Drawing.Size(42, 42);
            this.Pic_Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Editar.TabIndex = 100;
            this.Pic_Editar.TabStop = false;
            this.Pic_Editar.Click += new System.EventHandler(this.Pic_Editar_Click);
            // 
            // Pic_Cancelar
            // 
            this.Pic_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Cancelar.Image = global::Capa_Vista_MH.Properties.Resources.icono_limpiar__1_;
            this.Pic_Cancelar.Location = new System.Drawing.Point(1185, 102);
            this.Pic_Cancelar.Name = "Pic_Cancelar";
            this.Pic_Cancelar.Size = new System.Drawing.Size(42, 42);
            this.Pic_Cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Cancelar.TabIndex = 99;
            this.Pic_Cancelar.TabStop = false;
            this.Pic_Cancelar.Click += new System.EventHandler(this.Pic_Cancelar_Click);
            // 
            // Pic_Salir
            // 
            this.Pic_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Salir.Image = global::Capa_Vista_MH.Properties.Resources.icono_cancelar;
            this.Pic_Salir.Location = new System.Drawing.Point(1266, 12);
            this.Pic_Salir.Name = "Pic_Salir";
            this.Pic_Salir.Size = new System.Drawing.Size(42, 42);
            this.Pic_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Salir.TabIndex = 122;
            this.Pic_Salir.TabStop = false;
            this.Pic_Salir.Click += new System.EventHandler(this.Pic_Salir_Click_1);
            // 
            // Frm_Mantenimiento_hoteleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1320, 711);
            this.Controls.Add(this.Pic_Salir);
            this.Controls.Add(this.Pic_Reporte);
            this.Controls.Add(this.Pic_Buscar);
            this.Controls.Add(this.Pic_Eliminar);
            this.Controls.Add(this.Dtp_Fecha_Fin);
            this.Controls.Add(this.Dtp_Fecha_Inicio);
            this.Controls.Add(this.Txt_Estado);
            this.Controls.Add(this.Txt_Descripcion_Mantenimiento);
            this.Controls.Add(this.Txt_Tipo_Mantenimiento);
            this.Controls.Add(this.Cbo_Id_Empleado);
            this.Controls.Add(this.Cbo_Id_Habitacion);
            this.Controls.Add(this.Cbo_Id_Salon);
            this.Controls.Add(this.Cbo_Id_Mantenimiento);
            this.Controls.Add(this.Lbl_Fecha_Fin);
            this.Controls.Add(this.Lbl_Fecha_Inicio);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.Lbl_Desc_Mantenimiento);
            this.Controls.Add(this.Lbl_Tipo_Mantenimiento);
            this.Controls.Add(this.Lbl_Id_Empleado);
            this.Controls.Add(this.Lbl_Id_Habitacion);
            this.Controls.Add(this.Lbl_Id_Salon);
            this.Controls.Add(this.Lbl_Id_mantenimiento);
            this.Controls.Add(this.Dgv_Mantenimiento_hoteleria);
            this.Controls.Add(this.Pic_Guardar);
            this.Controls.Add(this.Pic_Editar);
            this.Controls.Add(this.Pic_Cancelar);
            this.Controls.Add(this.Lbl_Mantenimiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Mantenimiento_hoteleria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Mantenimiento_hoteleria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Mantenimiento_hoteleria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Reporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Mantenimiento;
        private System.Windows.Forms.PictureBox Pic_Cancelar;
        private System.Windows.Forms.PictureBox Pic_Editar;
        private System.Windows.Forms.PictureBox Pic_Guardar;
        private System.Windows.Forms.DataGridView Dgv_Mantenimiento_hoteleria;
        private System.Windows.Forms.Label Lbl_Id_mantenimiento;
        private System.Windows.Forms.Label Lbl_Id_Salon;
        private System.Windows.Forms.Label Lbl_Id_Habitacion;
        private System.Windows.Forms.Label Lbl_Id_Empleado;
        private System.Windows.Forms.Label Lbl_Tipo_Mantenimiento;
        private System.Windows.Forms.Label Lbl_Desc_Mantenimiento;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_Fecha_Inicio;
        private System.Windows.Forms.Label Lbl_Fecha_Fin;
        private System.Windows.Forms.ComboBox Cbo_Id_Mantenimiento;
        private System.Windows.Forms.ComboBox Cbo_Id_Salon;
        private System.Windows.Forms.ComboBox Cbo_Id_Habitacion;
        private System.Windows.Forms.ComboBox Cbo_Id_Empleado;
        private System.Windows.Forms.TextBox Txt_Tipo_Mantenimiento;
        private System.Windows.Forms.TextBox Txt_Descripcion_Mantenimiento;
        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Inicio;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Fin;
        private System.Windows.Forms.PictureBox Pic_Eliminar;
        private System.Windows.Forms.PictureBox Pic_Salir;
        private System.Windows.Forms.PictureBox Pic_Buscar;
        private System.Windows.Forms.PictureBox Pic_Reporte;
    }
}