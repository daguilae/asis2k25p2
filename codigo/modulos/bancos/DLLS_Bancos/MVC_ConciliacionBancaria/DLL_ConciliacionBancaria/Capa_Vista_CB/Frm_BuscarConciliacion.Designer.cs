
namespace Capa_Vista_CB
{
    partial class Frm_BuscarConciliacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuscarConciliacion));
            this.Lbl_TituloBuscarCB = new System.Windows.Forms.Label();
            this.Cbo_MesBuscarCB = new System.Windows.Forms.ComboBox();
            this.Lbl_MesBuscarCB = new System.Windows.Forms.Label();
            this.Cbo_BancosBuscarCB = new System.Windows.Forms.ComboBox();
            this.Lbl_BuscarCB = new System.Windows.Forms.Label();
            this.Lbl_anioBuscarCB = new System.Windows.Forms.Label();
            this.Dgv_Conciliaciones = new System.Windows.Forms.DataGridView();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_SalirBuscarCB = new System.Windows.Forms.Button();
            this.Btn_AyudaBC = new System.Windows.Forms.Button();
            this.Btn_BuscarCB = new System.Windows.Forms.Button();
            this.Cbo_AnioBuscarCB = new System.Windows.Forms.ComboBox();
            this.Btn_ModificarSeleccion = new System.Windows.Forms.Button();
            this.Btn_EliminarCB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Conciliaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_TituloBuscarCB
            // 
            this.Lbl_TituloBuscarCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_TituloBuscarCB.AutoSize = true;
            this.Lbl_TituloBuscarCB.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TituloBuscarCB.Location = new System.Drawing.Point(255, 9);
            this.Lbl_TituloBuscarCB.Name = "Lbl_TituloBuscarCB";
            this.Lbl_TituloBuscarCB.Size = new System.Drawing.Size(457, 38);
            this.Lbl_TituloBuscarCB.TabIndex = 1;
            this.Lbl_TituloBuscarCB.Text = "Buscar Conciliación Bancaria";
            this.Lbl_TituloBuscarCB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Cbo_MesBuscarCB
            // 
            this.Cbo_MesBuscarCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_MesBuscarCB.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_MesBuscarCB.FormattingEnabled = true;
            this.Cbo_MesBuscarCB.Location = new System.Drawing.Point(85, 124);
            this.Cbo_MesBuscarCB.Name = "Cbo_MesBuscarCB";
            this.Cbo_MesBuscarCB.Size = new System.Drawing.Size(316, 28);
            this.Cbo_MesBuscarCB.TabIndex = 10;
            this.Cbo_MesBuscarCB.SelectedIndexChanged += new System.EventHandler(this.Cbo_MesBuscarCB_SelectedIndexChanged);
            // 
            // Lbl_MesBuscarCB
            // 
            this.Lbl_MesBuscarCB.AutoSize = true;
            this.Lbl_MesBuscarCB.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MesBuscarCB.Location = new System.Drawing.Point(11, 127);
            this.Lbl_MesBuscarCB.Name = "Lbl_MesBuscarCB";
            this.Lbl_MesBuscarCB.Size = new System.Drawing.Size(52, 20);
            this.Lbl_MesBuscarCB.TabIndex = 9;
            this.Lbl_MesBuscarCB.Text = "Mes:";
            // 
            // Cbo_BancosBuscarCB
            // 
            this.Cbo_BancosBuscarCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_BancosBuscarCB.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_BancosBuscarCB.FormattingEnabled = true;
            this.Cbo_BancosBuscarCB.Location = new System.Drawing.Point(85, 80);
            this.Cbo_BancosBuscarCB.Name = "Cbo_BancosBuscarCB";
            this.Cbo_BancosBuscarCB.Size = new System.Drawing.Size(316, 28);
            this.Cbo_BancosBuscarCB.TabIndex = 8;
            this.Cbo_BancosBuscarCB.SelectedIndexChanged += new System.EventHandler(this.Cbo_BancosBuscarCB_SelectedIndexChanged);
            // 
            // Lbl_BuscarCB
            // 
            this.Lbl_BuscarCB.AutoSize = true;
            this.Lbl_BuscarCB.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BuscarCB.Location = new System.Drawing.Point(11, 83);
            this.Lbl_BuscarCB.Name = "Lbl_BuscarCB";
            this.Lbl_BuscarCB.Size = new System.Drawing.Size(68, 20);
            this.Lbl_BuscarCB.TabIndex = 7;
            this.Lbl_BuscarCB.Text = "Banco:";
            // 
            // Lbl_anioBuscarCB
            // 
            this.Lbl_anioBuscarCB.AutoSize = true;
            this.Lbl_anioBuscarCB.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_anioBuscarCB.Location = new System.Drawing.Point(600, 114);
            this.Lbl_anioBuscarCB.Name = "Lbl_anioBuscarCB";
            this.Lbl_anioBuscarCB.Size = new System.Drawing.Size(48, 20);
            this.Lbl_anioBuscarCB.TabIndex = 42;
            this.Lbl_anioBuscarCB.Text = "Año:";
            // 
            // Dgv_Conciliaciones
            // 
            this.Dgv_Conciliaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Conciliaciones.Location = new System.Drawing.Point(16, 225);
            this.Dgv_Conciliaciones.Name = "Dgv_Conciliaciones";
            this.Dgv_Conciliaciones.RowHeadersWidth = 51;
            this.Dgv_Conciliaciones.RowTemplate.Height = 24;
            this.Dgv_Conciliaciones.Size = new System.Drawing.Size(954, 416);
            this.Dgv_Conciliaciones.TabIndex = 44;
            this.Dgv_Conciliaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Conciliaciones_CellContentClick);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(72, 166);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(50, 50);
            this.Btn_Reporte.TabIndex = 45;
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            this.Btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click);
            // 
            // Btn_SalirBuscarCB
            // 
            this.Btn_SalirBuscarCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SalirBuscarCB.Image = ((System.Drawing.Image)(resources.GetObject("Btn_SalirBuscarCB.Image")));
            this.Btn_SalirBuscarCB.Location = new System.Drawing.Point(920, 9);
            this.Btn_SalirBuscarCB.Name = "Btn_SalirBuscarCB";
            this.Btn_SalirBuscarCB.Size = new System.Drawing.Size(50, 50);
            this.Btn_SalirBuscarCB.TabIndex = 46;
            this.Btn_SalirBuscarCB.UseVisualStyleBackColor = true;
            this.Btn_SalirBuscarCB.Click += new System.EventHandler(this.Btn_SalirBuscarCB_Click);
            // 
            // Btn_AyudaBC
            // 
            this.Btn_AyudaBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AyudaBC.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AyudaBC.Image")));
            this.Btn_AyudaBC.Location = new System.Drawing.Point(864, 9);
            this.Btn_AyudaBC.Name = "Btn_AyudaBC";
            this.Btn_AyudaBC.Size = new System.Drawing.Size(50, 50);
            this.Btn_AyudaBC.TabIndex = 47;
            this.Btn_AyudaBC.UseVisualStyleBackColor = true;
            this.Btn_AyudaBC.Click += new System.EventHandler(this.Btn_AyudaBC_Click);
            // 
            // Btn_BuscarCB
            // 
            this.Btn_BuscarCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BuscarCB.Image = ((System.Drawing.Image)(resources.GetObject("Btn_BuscarCB.Image")));
            this.Btn_BuscarCB.Location = new System.Drawing.Point(16, 166);
            this.Btn_BuscarCB.Name = "Btn_BuscarCB";
            this.Btn_BuscarCB.Size = new System.Drawing.Size(50, 50);
            this.Btn_BuscarCB.TabIndex = 48;
            this.Btn_BuscarCB.UseVisualStyleBackColor = true;
            this.Btn_BuscarCB.Click += new System.EventHandler(this.Btn_BuscarCB_Click);
            // 
            // Cbo_AnioBuscarCB
            // 
            this.Cbo_AnioBuscarCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_AnioBuscarCB.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_AnioBuscarCB.FormattingEnabled = true;
            this.Cbo_AnioBuscarCB.Location = new System.Drawing.Point(654, 111);
            this.Cbo_AnioBuscarCB.Name = "Cbo_AnioBuscarCB";
            this.Cbo_AnioBuscarCB.Size = new System.Drawing.Size(316, 28);
            this.Cbo_AnioBuscarCB.TabIndex = 49;
            this.Cbo_AnioBuscarCB.SelectedIndexChanged += new System.EventHandler(this.Cbo_AnioBuscarCB_SelectedIndexChanged);
            // 
            // Btn_ModificarSeleccion
            // 
            this.Btn_ModificarSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ModificarSeleccion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ModificarSeleccion.Image")));
            this.Btn_ModificarSeleccion.Location = new System.Drawing.Point(128, 166);
            this.Btn_ModificarSeleccion.Name = "Btn_ModificarSeleccion";
            this.Btn_ModificarSeleccion.Size = new System.Drawing.Size(50, 50);
            this.Btn_ModificarSeleccion.TabIndex = 50;
            this.Btn_ModificarSeleccion.UseVisualStyleBackColor = true;
            this.Btn_ModificarSeleccion.Click += new System.EventHandler(this.Btn_ModificarSeleccion_Click);
            // 
            // Btn_EliminarCB
            // 
            this.Btn_EliminarCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EliminarCB.Image = ((System.Drawing.Image)(resources.GetObject("Btn_EliminarCB.Image")));
            this.Btn_EliminarCB.Location = new System.Drawing.Point(184, 166);
            this.Btn_EliminarCB.Name = "Btn_EliminarCB";
            this.Btn_EliminarCB.Size = new System.Drawing.Size(50, 50);
            this.Btn_EliminarCB.TabIndex = 51;
            this.Btn_EliminarCB.UseVisualStyleBackColor = true;
            this.Btn_EliminarCB.Click += new System.EventHandler(this.Btn_EliminarCB_Click);
            // 
            // Frm_BuscarConciliacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.Btn_EliminarCB);
            this.Controls.Add(this.Btn_ModificarSeleccion);
            this.Controls.Add(this.Cbo_AnioBuscarCB);
            this.Controls.Add(this.Btn_BuscarCB);
            this.Controls.Add(this.Btn_AyudaBC);
            this.Controls.Add(this.Btn_SalirBuscarCB);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Dgv_Conciliaciones);
            this.Controls.Add(this.Lbl_anioBuscarCB);
            this.Controls.Add(this.Cbo_MesBuscarCB);
            this.Controls.Add(this.Lbl_MesBuscarCB);
            this.Controls.Add(this.Cbo_BancosBuscarCB);
            this.Controls.Add(this.Lbl_BuscarCB);
            this.Controls.Add(this.Lbl_TituloBuscarCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_BuscarConciliacion";
            this.Text = "Frm_BuscarConciliacion";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Conciliaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_TituloBuscarCB;
        private System.Windows.Forms.ComboBox Cbo_MesBuscarCB;
        private System.Windows.Forms.Label Lbl_MesBuscarCB;
        private System.Windows.Forms.ComboBox Cbo_BancosBuscarCB;
        private System.Windows.Forms.Label Lbl_BuscarCB;
        private System.Windows.Forms.Label Lbl_anioBuscarCB;
        private System.Windows.Forms.DataGridView Dgv_Conciliaciones;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_SalirBuscarCB;
        private System.Windows.Forms.Button Btn_AyudaBC;
        private System.Windows.Forms.Button Btn_BuscarCB;
        private System.Windows.Forms.ComboBox Cbo_AnioBuscarCB;
        private System.Windows.Forms.Button Btn_ModificarSeleccion;
        private System.Windows.Forms.Button Btn_EliminarCB;
    }
}