
namespace Capa_Vista_Produccion
{
    partial class Frm_Reportes_RoomService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reportes_RoomService));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pnl_Superior = new System.Windows.Forms.Panel();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Room_Service_Reporte = new System.Windows.Forms.Label();
            this.Lbl_Id_Habitacion = new System.Windows.Forms.Label();
            this.Lbl_Id_huesped = new System.Windows.Forms.Label();
            this.Txt_Id_Habitacion = new System.Windows.Forms.TextBox();
            this.Txt_Id_Huesped = new System.Windows.Forms.TextBox();
            this.Dgv_Room_Service = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pnl_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Room_Service)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(769, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Pnl_Superior
            // 
            this.Pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.Pnl_Superior.Controls.Add(this.Lbl_Titulo);
            this.Pnl_Superior.Controls.Add(this.pictureBox1);
            this.Pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Superior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_Superior.Name = "Pnl_Superior";
            this.Pnl_Superior.Size = new System.Drawing.Size(800, 64);
            this.Pnl_Superior.TabIndex = 122;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Titulo.Location = new System.Drawing.Point(14, 12);
            this.Lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(319, 35);
            this.Lbl_Titulo.TabIndex = 2;
            this.Lbl_Titulo.Text = "MODULO HOTELERIA";
            // 
            // Lbl_Room_Service_Reporte
            // 
            this.Lbl_Room_Service_Reporte.AutoSize = true;
            this.Lbl_Room_Service_Reporte.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Room_Service_Reporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Room_Service_Reporte.Location = new System.Drawing.Point(16, 92);
            this.Lbl_Room_Service_Reporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Room_Service_Reporte.Name = "Lbl_Room_Service_Reporte";
            this.Lbl_Room_Service_Reporte.Size = new System.Drawing.Size(249, 21);
            this.Lbl_Room_Service_Reporte.TabIndex = 141;
            this.Lbl_Room_Service_Reporte.Text = "ROOM SERVICE REPORTES";
            // 
            // Lbl_Id_Habitacion
            // 
            this.Lbl_Id_Habitacion.AutoSize = true;
            this.Lbl_Id_Habitacion.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Habitacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Id_Habitacion.Location = new System.Drawing.Point(433, 150);
            this.Lbl_Id_Habitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id_Habitacion.Name = "Lbl_Id_Habitacion";
            this.Lbl_Id_Habitacion.Size = new System.Drawing.Size(185, 21);
            this.Lbl_Id_Habitacion.TabIndex = 145;
            this.Lbl_Id_Habitacion.Text = "ID de la Habitacion:";
            // 
            // Lbl_Id_huesped
            // 
            this.Lbl_Id_huesped.AutoSize = true;
            this.Lbl_Id_huesped.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_huesped.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Id_huesped.Location = new System.Drawing.Point(16, 151);
            this.Lbl_Id_huesped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id_huesped.Name = "Lbl_Id_huesped";
            this.Lbl_Id_huesped.Size = new System.Drawing.Size(181, 20);
            this.Lbl_Id_huesped.TabIndex = 144;
            this.Lbl_Id_huesped.Text = "Nombre del Huesped:";
            // 
            // Txt_Id_Habitacion
            // 
            this.Txt_Id_Habitacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Id_Habitacion.Location = new System.Drawing.Point(437, 188);
            this.Txt_Id_Habitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Id_Habitacion.Name = "Txt_Id_Habitacion";
            this.Txt_Id_Habitacion.Size = new System.Drawing.Size(193, 22);
            this.Txt_Id_Habitacion.TabIndex = 143;
            // 
            // Txt_Id_Huesped
            // 
            this.Txt_Id_Huesped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Id_Huesped.Location = new System.Drawing.Point(19, 188);
            this.Txt_Id_Huesped.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Id_Huesped.Name = "Txt_Id_Huesped";
            this.Txt_Id_Huesped.Size = new System.Drawing.Size(245, 22);
            this.Txt_Id_Huesped.TabIndex = 142;
            // 
            // Dgv_Room_Service
            // 
            this.Dgv_Room_Service.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Room_Service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Room_Service.Location = new System.Drawing.Point(20, 231);
            this.Dgv_Room_Service.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_Room_Service.Name = "Dgv_Room_Service";
            this.Dgv_Room_Service.RowHeadersWidth = 51;
            this.Dgv_Room_Service.RowTemplate.Height = 24;
            this.Dgv_Room_Service.Size = new System.Drawing.Size(758, 317);
            this.Dgv_Room_Service.TabIndex = 146;
            // 
            // Frm_Reportes_RoomService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.Dgv_Room_Service);
            this.Controls.Add(this.Lbl_Id_Habitacion);
            this.Controls.Add(this.Lbl_Id_huesped);
            this.Controls.Add(this.Txt_Id_Habitacion);
            this.Controls.Add(this.Txt_Id_Huesped);
            this.Controls.Add(this.Lbl_Room_Service_Reporte);
            this.Controls.Add(this.Pnl_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Reportes_RoomService";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pnl_Superior.ResumeLayout(false);
            this.Pnl_Superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Room_Service)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Pnl_Superior;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Room_Service_Reporte;
        private System.Windows.Forms.Label Lbl_Id_Habitacion;
        private System.Windows.Forms.Label Lbl_Id_huesped;
        private System.Windows.Forms.TextBox Txt_Id_Habitacion;
        private System.Windows.Forms.TextBox Txt_Id_Huesped;
        private System.Windows.Forms.DataGridView Dgv_Room_Service;
    }
}