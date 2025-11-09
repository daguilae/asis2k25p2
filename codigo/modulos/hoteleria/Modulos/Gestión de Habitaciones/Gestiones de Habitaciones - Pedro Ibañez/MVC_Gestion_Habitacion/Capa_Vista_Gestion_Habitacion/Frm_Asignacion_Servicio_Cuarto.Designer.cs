
namespace Capa_Vista_Gestion_Habitacion
{
    partial class Frm_Asignacion_Servicio_Cuarto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Asignacion_Servicio_Cuarto));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.PictureBox();
            this.Cbo_NumHabitaciones = new System.Windows.Forms.ComboBox();
            this.Cbo_Servicios = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Asignar = new System.Windows.Forms.Button();
            this.DGV_Asignaciones = new System.Windows.Forms.DataGridView();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_recargar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Asignaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num.Habitación:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 36);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(586, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "MODULO HOTELERIA - Asignacion servicios a Habitaciones";
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir.BackgroundImage")));
            this.btn_salir.Location = new System.Drawing.Point(962, 3);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(31, 32);
            this.btn_salir.TabIndex = 24;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Cbo_NumHabitaciones
            // 
            this.Cbo_NumHabitaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_NumHabitaciones.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_NumHabitaciones.FormattingEnabled = true;
            this.Cbo_NumHabitaciones.Location = new System.Drawing.Point(169, 80);
            this.Cbo_NumHabitaciones.Name = "Cbo_NumHabitaciones";
            this.Cbo_NumHabitaciones.Size = new System.Drawing.Size(220, 24);
            this.Cbo_NumHabitaciones.TabIndex = 3;
            // 
            // Cbo_Servicios
            // 
            this.Cbo_Servicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Servicios.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Servicios.FormattingEnabled = true;
            this.Cbo_Servicios.Location = new System.Drawing.Point(549, 81);
            this.Cbo_Servicios.Name = "Cbo_Servicios";
            this.Cbo_Servicios.Size = new System.Drawing.Size(220, 24);
            this.Cbo_Servicios.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Servicios";
            // 
            // btn_Asignar
            // 
            this.btn_Asignar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Asignar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Asignar.Image")));
            this.btn_Asignar.Location = new System.Drawing.Point(792, 52);
            this.btn_Asignar.Name = "btn_Asignar";
            this.btn_Asignar.Size = new System.Drawing.Size(78, 78);
            this.btn_Asignar.TabIndex = 6;
            this.btn_Asignar.Text = "ASIGNAR";
            this.btn_Asignar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Asignar.UseVisualStyleBackColor = true;
            this.btn_Asignar.Click += new System.EventHandler(this.btn_Asignar_Click);
            // 
            // DGV_Asignaciones
            // 
            this.DGV_Asignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Asignaciones.Location = new System.Drawing.Point(110, 140);
            this.DGV_Asignaciones.Name = "DGV_Asignaciones";
            this.DGV_Asignaciones.Size = new System.Drawing.Size(591, 298);
            this.DGV_Asignaciones.TabIndex = 7;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(887, 52);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(78, 78);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "REMOVER";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(792, 140);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(78, 78);
            this.btn_buscar.TabIndex = 9;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_reporte
            // 
            this.btn_reporte.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_reporte.Image")));
            this.btn_reporte.Location = new System.Drawing.Point(887, 139);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(78, 78);
            this.btn_reporte.TabIndex = 10;
            this.btn_reporte.Text = "REPORTE";
            this.btn_reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_reporte.UseVisualStyleBackColor = true;
            // 
            // btn_recargar
            // 
            this.btn_recargar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recargar.Image = ((System.Drawing.Image)(resources.GetObject("btn_recargar.Image")));
            this.btn_recargar.Location = new System.Drawing.Point(832, 224);
            this.btn_recargar.Name = "btn_recargar";
            this.btn_recargar.Size = new System.Drawing.Size(102, 78);
            this.btn_recargar.TabIndex = 11;
            this.btn_recargar.Text = "RECARGAR";
            this.btn_recargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_recargar.UseVisualStyleBackColor = true;
            this.btn_recargar.Click += new System.EventHandler(this.btn_recargar_Click);
            // 
            // Frm_Asignacion_Servicio_Cuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 515);
            this.Controls.Add(this.btn_recargar);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.DGV_Asignaciones);
            this.Controls.Add(this.btn_Asignar);
            this.Controls.Add(this.Cbo_Servicios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cbo_NumHabitaciones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Asignacion_Servicio_Cuarto";
            this.Text = "Frm_Asignacion_Servicio_Cuarto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Asignaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbo_NumHabitaciones;
        private System.Windows.Forms.ComboBox Cbo_Servicios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Asignar;
        private System.Windows.Forms.DataGridView DGV_Asignaciones;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_recargar;
    }
}