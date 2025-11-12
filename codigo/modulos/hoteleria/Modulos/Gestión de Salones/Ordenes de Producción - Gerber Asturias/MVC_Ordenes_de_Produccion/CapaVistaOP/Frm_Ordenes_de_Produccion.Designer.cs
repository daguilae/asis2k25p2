
namespace CapaVistaOP
{
    partial class Frm_Ordenes_de_Produccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ordenes_de_Produccion));
            this.Pnl_Superior = new System.Windows.Forms.Panel();
            this.Lbl_Modulo_Hoteleria = new System.Windows.Forms.Label();
            this.Lbl_Ordenes_Produccion = new System.Windows.Forms.Label();
            this.Txt_Id_OP = new System.Windows.Forms.TextBox();
            this.Lbl_Id_Orden_Produccion = new System.Windows.Forms.Label();
            this.Dgv_OP = new System.Windows.Forms.DataGridView();
            this.Lbl_Fecha_Solicitud = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Registro = new System.Windows.Forms.Label();
            this.Dtp_Fecha_Solicitud = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Fecha_Registro = new System.Windows.Forms.DateTimePicker();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Pnl_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_OP)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Superior
            // 
            this.Pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.Pnl_Superior.Controls.Add(this.Lbl_Modulo_Hoteleria);
            this.Pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Superior.Name = "Pnl_Superior";
            this.Pnl_Superior.Size = new System.Drawing.Size(895, 50);
            this.Pnl_Superior.TabIndex = 99;
            // 
            // Lbl_Modulo_Hoteleria
            // 
            this.Lbl_Modulo_Hoteleria.AutoSize = true;
            this.Lbl_Modulo_Hoteleria.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Modulo_Hoteleria.Location = new System.Drawing.Point(27, 9);
            this.Lbl_Modulo_Hoteleria.Name = "Lbl_Modulo_Hoteleria";
            this.Lbl_Modulo_Hoteleria.Size = new System.Drawing.Size(252, 35);
            this.Lbl_Modulo_Hoteleria.TabIndex = 104;
            this.Lbl_Modulo_Hoteleria.Text = "Módulo hotelería";
            // 
            // Lbl_Ordenes_Produccion
            // 
            this.Lbl_Ordenes_Produccion.AutoSize = true;
            this.Lbl_Ordenes_Produccion.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ordenes_Produccion.Location = new System.Drawing.Point(29, 69);
            this.Lbl_Ordenes_Produccion.Name = "Lbl_Ordenes_Produccion";
            this.Lbl_Ordenes_Produccion.Size = new System.Drawing.Size(261, 21);
            this.Lbl_Ordenes_Produccion.TabIndex = 106;
            this.Lbl_Ordenes_Produccion.Text = "ORDENES DE PRODUCCIÓN";
            this.Lbl_Ordenes_Produccion.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txt_Id_OP
            // 
            this.Txt_Id_OP.BackColor = System.Drawing.Color.White;
            this.Txt_Id_OP.Location = new System.Drawing.Point(251, 125);
            this.Txt_Id_OP.Name = "Txt_Id_OP";
            this.Txt_Id_OP.Size = new System.Drawing.Size(200, 22);
            this.Txt_Id_OP.TabIndex = 118;
            // 
            // Lbl_Id_Orden_Produccion
            // 
            this.Lbl_Id_Orden_Produccion.AutoSize = true;
            this.Lbl_Id_Orden_Produccion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Orden_Produccion.Location = new System.Drawing.Point(29, 125);
            this.Lbl_Id_Orden_Produccion.Name = "Lbl_Id_Orden_Produccion";
            this.Lbl_Id_Orden_Produccion.Size = new System.Drawing.Size(193, 20);
            this.Lbl_Id_Orden_Produccion.TabIndex = 117;
            this.Lbl_Id_Orden_Produccion.Text = "Id orden de produccion";
            // 
            // Dgv_OP
            // 
            this.Dgv_OP.AllowUserToAddRows = false;
            this.Dgv_OP.AllowUserToDeleteRows = false;
            this.Dgv_OP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_OP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_OP.Location = new System.Drawing.Point(33, 282);
            this.Dgv_OP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_OP.Name = "Dgv_OP";
            this.Dgv_OP.ReadOnly = true;
            this.Dgv_OP.RowHeadersWidth = 51;
            this.Dgv_OP.RowTemplate.Height = 24;
            this.Dgv_OP.Size = new System.Drawing.Size(823, 295);
            this.Dgv_OP.TabIndex = 119;
            this.Dgv_OP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOP_CellContentClick);
            // 
            // Lbl_Fecha_Solicitud
            // 
            this.Lbl_Fecha_Solicitud.AutoSize = true;
            this.Lbl_Fecha_Solicitud.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Solicitud.Location = new System.Drawing.Point(29, 176);
            this.Lbl_Fecha_Solicitud.Name = "Lbl_Fecha_Solicitud";
            this.Lbl_Fecha_Solicitud.Size = new System.Drawing.Size(151, 20);
            this.Lbl_Fecha_Solicitud.TabIndex = 120;
            this.Lbl_Fecha_Solicitud.Text = "Fecha de solicitud";
            // 
            // Lbl_Fecha_Registro
            // 
            this.Lbl_Fecha_Registro.AutoSize = true;
            this.Lbl_Fecha_Registro.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Registro.Location = new System.Drawing.Point(29, 219);
            this.Lbl_Fecha_Registro.Name = "Lbl_Fecha_Registro";
            this.Lbl_Fecha_Registro.Size = new System.Drawing.Size(146, 20);
            this.Lbl_Fecha_Registro.TabIndex = 122;
            this.Lbl_Fecha_Registro.Text = "Fecha de registro";
            // 
            // Dtp_Fecha_Solicitud
            // 
            this.Dtp_Fecha_Solicitud.Location = new System.Drawing.Point(251, 176);
            this.Dtp_Fecha_Solicitud.Name = "Dtp_Fecha_Solicitud";
            this.Dtp_Fecha_Solicitud.Size = new System.Drawing.Size(200, 22);
            this.Dtp_Fecha_Solicitud.TabIndex = 123;
            // 
            // Dtp_Fecha_Registro
            // 
            this.Dtp_Fecha_Registro.Location = new System.Drawing.Point(251, 219);
            this.Dtp_Fecha_Registro.Name = "Dtp_Fecha_Registro";
            this.Dtp_Fecha_Registro.Size = new System.Drawing.Size(200, 22);
            this.Dtp_Fecha_Registro.TabIndex = 124;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackColor = System.Drawing.Color.White;
            this.Btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Editar.Image")));
            this.Btn_Editar.Location = new System.Drawing.Point(815, 69);
            this.Btn_Editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(53, 46);
            this.Btn_Editar.TabIndex = 127;
            this.Btn_Editar.UseVisualStyleBackColor = false;
            this.Btn_Editar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(756, 69);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(53, 46);
            this.Btn_Eliminar.TabIndex = 126;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.White;
            this.Btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Location = new System.Drawing.Point(697, 69);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(53, 46);
            this.Btn_Guardar.TabIndex = 125;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(639, 69);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(52, 46);
            this.Btn_Reporte.TabIndex = 128;
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            this.Btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click);
            // 
            // Frm_Ordenes_de_Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 597);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Dtp_Fecha_Registro);
            this.Controls.Add(this.Dtp_Fecha_Solicitud);
            this.Controls.Add(this.Lbl_Fecha_Registro);
            this.Controls.Add(this.Lbl_Fecha_Solicitud);
            this.Controls.Add(this.Dgv_OP);
            this.Controls.Add(this.Txt_Id_OP);
            this.Controls.Add(this.Lbl_Id_Orden_Produccion);
            this.Controls.Add(this.Lbl_Ordenes_Produccion);
            this.Controls.Add(this.Pnl_Superior);
            this.Name = "Frm_Ordenes_de_Produccion";
            this.Text = "Frm_Ordenes_de_Produccion";
            this.Pnl_Superior.ResumeLayout(false);
            this.Pnl_Superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_OP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Superior;
        private System.Windows.Forms.Label Lbl_Modulo_Hoteleria;
        private System.Windows.Forms.Label Lbl_Ordenes_Produccion;
        private System.Windows.Forms.TextBox Txt_Id_OP;
        private System.Windows.Forms.Label Lbl_Id_Orden_Produccion;
        private System.Windows.Forms.DataGridView Dgv_OP;
        private System.Windows.Forms.Label Lbl_Fecha_Solicitud;
        private System.Windows.Forms.Label Lbl_Fecha_Registro;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Solicitud;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Registro;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Reporte;
    }
}