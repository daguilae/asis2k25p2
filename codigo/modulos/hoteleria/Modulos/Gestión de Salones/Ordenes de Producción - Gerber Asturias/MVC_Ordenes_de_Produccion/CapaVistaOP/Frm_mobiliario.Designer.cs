
namespace CapaVistaOP
{
    partial class Frm_mobiliario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_mobiliario));
            this.Pnl_Superior = new System.Windows.Forms.Panel();
            this.Lbl_Modulo_Hoteleria = new System.Windows.Forms.Label();
            this.Lbl_Mobiliario = new System.Windows.Forms.Label();
            this.Lbl_Id_Mobiliario = new System.Windows.Forms.Label();
            this.Txt_Id_Mobiliario = new System.Windows.Forms.TextBox();
            this.Lbl_Mobiliario1 = new System.Windows.Forms.Label();
            this.Txt_Mobiliario = new System.Windows.Forms.TextBox();
            this.Dgv_Mobiliario = new System.Windows.Forms.DataGridView();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Pnl_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Mobiliario)).BeginInit();
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
            this.Pnl_Superior.TabIndex = 100;
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
            // Lbl_Mobiliario
            // 
            this.Lbl_Mobiliario.AutoSize = true;
            this.Lbl_Mobiliario.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mobiliario.Location = new System.Drawing.Point(29, 68);
            this.Lbl_Mobiliario.Name = "Lbl_Mobiliario";
            this.Lbl_Mobiliario.Size = new System.Drawing.Size(120, 21);
            this.Lbl_Mobiliario.TabIndex = 107;
            this.Lbl_Mobiliario.Text = "MOBILIARIO";
            this.Lbl_Mobiliario.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lbl_Id_Mobiliario
            // 
            this.Lbl_Id_Mobiliario.AutoSize = true;
            this.Lbl_Id_Mobiliario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Mobiliario.Location = new System.Drawing.Point(29, 115);
            this.Lbl_Id_Mobiliario.Name = "Lbl_Id_Mobiliario";
            this.Lbl_Id_Mobiliario.Size = new System.Drawing.Size(109, 20);
            this.Lbl_Id_Mobiliario.TabIndex = 118;
            this.Lbl_Id_Mobiliario.Text = "Id mobiliario";
            // 
            // Txt_Id_Mobiliario
            // 
            this.Txt_Id_Mobiliario.BackColor = System.Drawing.Color.White;
            this.Txt_Id_Mobiliario.Location = new System.Drawing.Point(179, 115);
            this.Txt_Id_Mobiliario.Name = "Txt_Id_Mobiliario";
            this.Txt_Id_Mobiliario.Size = new System.Drawing.Size(200, 22);
            this.Txt_Id_Mobiliario.TabIndex = 119;
            // 
            // Lbl_Mobiliario1
            // 
            this.Lbl_Mobiliario1.AutoSize = true;
            this.Lbl_Mobiliario1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mobiliario1.Location = new System.Drawing.Point(29, 162);
            this.Lbl_Mobiliario1.Name = "Lbl_Mobiliario1";
            this.Lbl_Mobiliario1.Size = new System.Drawing.Size(90, 20);
            this.Lbl_Mobiliario1.TabIndex = 121;
            this.Lbl_Mobiliario1.Text = "Mobiliario";
            // 
            // Txt_Mobiliario
            // 
            this.Txt_Mobiliario.BackColor = System.Drawing.Color.White;
            this.Txt_Mobiliario.Location = new System.Drawing.Point(179, 162);
            this.Txt_Mobiliario.Name = "Txt_Mobiliario";
            this.Txt_Mobiliario.Size = new System.Drawing.Size(200, 22);
            this.Txt_Mobiliario.TabIndex = 122;
            // 
            // Dgv_Mobiliario
            // 
            this.Dgv_Mobiliario.AllowUserToAddRows = false;
            this.Dgv_Mobiliario.AllowUserToDeleteRows = false;
            this.Dgv_Mobiliario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Mobiliario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Mobiliario.Location = new System.Drawing.Point(30, 244);
            this.Dgv_Mobiliario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_Mobiliario.Name = "Dgv_Mobiliario";
            this.Dgv_Mobiliario.ReadOnly = true;
            this.Dgv_Mobiliario.RowHeadersWidth = 51;
            this.Dgv_Mobiliario.RowTemplate.Height = 24;
            this.Dgv_Mobiliario.Size = new System.Drawing.Size(841, 342);
            this.Dgv_Mobiliario.TabIndex = 123;
            this.Dgv_Mobiliario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmobiliario_CellContentClick);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackColor = System.Drawing.Color.White;
            this.Btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Editar.Image")));
            this.Btn_Editar.Location = new System.Drawing.Point(809, 68);
            this.Btn_Editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(53, 46);
            this.Btn_Editar.TabIndex = 130;
            this.Btn_Editar.UseVisualStyleBackColor = false;
            this.Btn_Editar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(750, 68);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(53, 46);
            this.Btn_Eliminar.TabIndex = 129;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.White;
            this.Btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Location = new System.Drawing.Point(691, 68);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(53, 46);
            this.Btn_Guardar.TabIndex = 128;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(632, 70);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(53, 46);
            this.Btn_Reporte.TabIndex = 131;
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            this.Btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click);
            // 
            // Frm_mobiliario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 597);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Dgv_Mobiliario);
            this.Controls.Add(this.Txt_Mobiliario);
            this.Controls.Add(this.Lbl_Mobiliario1);
            this.Controls.Add(this.Txt_Id_Mobiliario);
            this.Controls.Add(this.Lbl_Id_Mobiliario);
            this.Controls.Add(this.Lbl_Mobiliario);
            this.Controls.Add(this.Pnl_Superior);
            this.Name = "Frm_mobiliario";
            this.Text = "Frm_mobiliario";
            this.Pnl_Superior.ResumeLayout(false);
            this.Pnl_Superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Mobiliario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Superior;
        private System.Windows.Forms.Label Lbl_Modulo_Hoteleria;
        private System.Windows.Forms.Label Lbl_Mobiliario;
        private System.Windows.Forms.Label Lbl_Id_Mobiliario;
        private System.Windows.Forms.TextBox Txt_Id_Mobiliario;
        private System.Windows.Forms.Label Lbl_Mobiliario1;
        private System.Windows.Forms.TextBox Txt_Mobiliario;
        private System.Windows.Forms.DataGridView Dgv_Mobiliario;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Reporte;
    }
}