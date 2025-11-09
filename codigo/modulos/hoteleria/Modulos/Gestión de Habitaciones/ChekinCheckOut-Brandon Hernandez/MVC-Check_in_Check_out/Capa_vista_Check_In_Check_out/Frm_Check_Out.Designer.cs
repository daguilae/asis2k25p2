
namespace Capa_vista_Check_In_Check_out
{
    partial class Frm_Check_Out
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Check_Out));
            this.Dgv_Check_Out = new System.Windows.Forms.DataGridView();
            this.Gbp_Titulo = new System.Windows.Forms.GroupBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Gbp_Campos = new System.Windows.Forms.GroupBox();
            this.Cbo_Huesped = new System.Windows.Forms.ComboBox();
            this.Txt_Check_out = new System.Windows.Forms.TextBox();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Dtp_Fecha_CheckOut = new System.Windows.Forms.DateTimePicker();
            this.Lbl_idreserva = new System.Windows.Forms.Label();
            this.Lbl_IdcheckOut = new System.Windows.Forms.Label();
            this.Lbl_Icheck_in = new System.Windows.Forms.Label();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Check_Out)).BeginInit();
            this.Gbp_Titulo.SuspendLayout();
            this.Gbp_Campos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Check_Out
            // 
            this.Dgv_Check_Out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Check_Out.Location = new System.Drawing.Point(27, 285);
            this.Dgv_Check_Out.Name = "Dgv_Check_Out";
            this.Dgv_Check_Out.RowHeadersWidth = 51;
            this.Dgv_Check_Out.RowTemplate.Height = 24;
            this.Dgv_Check_Out.Size = new System.Drawing.Size(1309, 476);
            this.Dgv_Check_Out.TabIndex = 15;
            this.Dgv_Check_Out.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Check_Out_CellClick);
            // 
            // Gbp_Titulo
            // 
            this.Gbp_Titulo.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Gbp_Titulo.Controls.Add(this.Lbl_Titulo);
            this.Gbp_Titulo.Location = new System.Drawing.Point(27, 12);
            this.Gbp_Titulo.Name = "Gbp_Titulo";
            this.Gbp_Titulo.Size = new System.Drawing.Size(366, 80);
            this.Gbp_Titulo.TabIndex = 14;
            this.Gbp_Titulo.TabStop = false;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(138, 41);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(104, 21);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Check Out";
            // 
            // Gbp_Campos
            // 
            this.Gbp_Campos.Controls.Add(this.Cbo_Huesped);
            this.Gbp_Campos.Controls.Add(this.Txt_Check_out);
            this.Gbp_Campos.Controls.Add(this.Lbl_Fecha);
            this.Gbp_Campos.Controls.Add(this.Dtp_Fecha_CheckOut);
            this.Gbp_Campos.Controls.Add(this.Lbl_idreserva);
            this.Gbp_Campos.Controls.Add(this.Lbl_IdcheckOut);
            this.Gbp_Campos.Controls.Add(this.Lbl_Icheck_in);
            this.Gbp_Campos.Location = new System.Drawing.Point(27, 98);
            this.Gbp_Campos.Name = "Gbp_Campos";
            this.Gbp_Campos.Size = new System.Drawing.Size(1309, 170);
            this.Gbp_Campos.TabIndex = 13;
            this.Gbp_Campos.TabStop = false;
            // 
            // Cbo_Huesped
            // 
            this.Cbo_Huesped.FormattingEnabled = true;
            this.Cbo_Huesped.Location = new System.Drawing.Point(232, 76);
            this.Cbo_Huesped.Name = "Cbo_Huesped";
            this.Cbo_Huesped.Size = new System.Drawing.Size(695, 24);
            this.Cbo_Huesped.TabIndex = 8;
            // 
            // Txt_Check_out
            // 
            this.Txt_Check_out.Location = new System.Drawing.Point(37, 80);
            this.Txt_Check_out.Name = "Txt_Check_out";
            this.Txt_Check_out.Size = new System.Drawing.Size(162, 22);
            this.Txt_Check_out.TabIndex = 7;
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(1046, 41);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(56, 20);
            this.Lbl_Fecha.TabIndex = 5;
            this.Lbl_Fecha.Text = "Fecha";
            // 
            // Dtp_Fecha_CheckOut
            // 
            this.Dtp_Fecha_CheckOut.Location = new System.Drawing.Point(957, 80);
            this.Dtp_Fecha_CheckOut.Name = "Dtp_Fecha_CheckOut";
            this.Dtp_Fecha_CheckOut.Size = new System.Drawing.Size(257, 22);
            this.Dtp_Fecha_CheckOut.TabIndex = 4;
            // 
            // Lbl_idreserva
            // 
            this.Lbl_idreserva.AutoSize = true;
            this.Lbl_idreserva.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idreserva.Location = new System.Drawing.Point(530, 29);
            this.Lbl_idreserva.Name = "Lbl_idreserva";
            this.Lbl_idreserva.Size = new System.Drawing.Size(0, 20);
            this.Lbl_idreserva.TabIndex = 3;
            // 
            // Lbl_IdcheckOut
            // 
            this.Lbl_IdcheckOut.AutoSize = true;
            this.Lbl_IdcheckOut.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IdcheckOut.Location = new System.Drawing.Point(47, 41);
            this.Lbl_IdcheckOut.Name = "Lbl_IdcheckOut";
            this.Lbl_IdcheckOut.Size = new System.Drawing.Size(109, 20);
            this.Lbl_IdcheckOut.TabIndex = 1;
            this.Lbl_IdcheckOut.Text = "Id Check out";
            // 
            // Lbl_Icheck_in
            // 
            this.Lbl_Icheck_in.AutoSize = true;
            this.Lbl_Icheck_in.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Icheck_in.Location = new System.Drawing.Point(501, 41);
            this.Lbl_Icheck_in.Name = "Lbl_Icheck_in";
            this.Lbl_Icheck_in.Size = new System.Drawing.Size(80, 20);
            this.Lbl_Icheck_in.TabIndex = 2;
            this.Lbl_Icheck_in.Text = "Check In";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.White;
            this.Btn_Salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Salir.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(1286, 29);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(66, 63);
            this.Btn_Salir.TabIndex = 23;
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.BackColor = System.Drawing.Color.White;
            this.Btn_Reporte.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Reporte.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Reporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(1126, 29);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(76, 68);
            this.Btn_Reporte.TabIndex = 26;
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Reporte.UseVisualStyleBackColor = false;
            this.Btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click);
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.BackColor = System.Drawing.Color.White;
            this.Btn_Ayuda.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Ayuda.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Ayuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(1209, 29);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(69, 68);
            this.Btn_Ayuda.TabIndex = 25;
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Ayuda.UseVisualStyleBackColor = false;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.White;
            this.Btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(941, 29);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(81, 68);
            this.Btn_Eliminar.TabIndex = 24;
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.Color.White;
            this.Btn_Nuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Nuevo.Image")));
            this.Btn_Nuevo.Location = new System.Drawing.Point(696, 29);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(64, 68);
            this.Btn_Nuevo.TabIndex = 20;
            this.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.White;
            this.Btn_Modificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Modificar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Modificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(851, 29);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(74, 68);
            this.Btn_Modificar.TabIndex = 21;
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.White;
            this.Btn_Guardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Guardar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Location = new System.Drawing.Point(767, 29);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(63, 68);
            this.Btn_Guardar.TabIndex = 19;
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.White;
            this.Btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.Image")));
            this.Btn_Cancelar.Location = new System.Drawing.Point(1038, 36);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(71, 54);
            this.Btn_Cancelar.TabIndex = 27;
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Frm_Check_Out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 788);
            this.Controls.Add(this.Dgv_Check_Out);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Gbp_Titulo);
            this.Controls.Add(this.Gbp_Campos);
            this.Name = "Frm_Check_Out";
            this.Text = "Check_Out";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Check_Out)).EndInit();
            this.Gbp_Titulo.ResumeLayout(false);
            this.Gbp_Titulo.PerformLayout();
            this.Gbp_Campos.ResumeLayout(false);
            this.Gbp_Campos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgv_Check_Out;
        private System.Windows.Forms.GroupBox Gbp_Titulo;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.GroupBox Gbp_Campos;
        private System.Windows.Forms.ComboBox Cbo_Huesped;
        private System.Windows.Forms.TextBox Txt_Check_out;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_CheckOut;
        private System.Windows.Forms.Label Lbl_idreserva;
        private System.Windows.Forms.Label Lbl_IdcheckOut;
        private System.Windows.Forms.Label Lbl_Icheck_in;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}