
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
            this.Dgv_Conciliaciones = new System.Windows.Forms.DataGridView();
            this.Btn_SalirBuscarCB = new System.Windows.Forms.Button();
            this.Btn_AyudaBC = new System.Windows.Forms.Button();
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
            this.Lbl_TituloBuscarCB.Location = new System.Drawing.Point(414, 8);
            this.Lbl_TituloBuscarCB.Name = "Lbl_TituloBuscarCB";
            this.Lbl_TituloBuscarCB.Size = new System.Drawing.Size(457, 38);
            this.Lbl_TituloBuscarCB.TabIndex = 1;
            this.Lbl_TituloBuscarCB.Text = "Buscar Conciliación Bancaria";
            this.Lbl_TituloBuscarCB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Dgv_Conciliaciones
            // 
            this.Dgv_Conciliaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Conciliaciones.Location = new System.Drawing.Point(16, 119);
            this.Dgv_Conciliaciones.Name = "Dgv_Conciliaciones";
            this.Dgv_Conciliaciones.RowHeadersWidth = 51;
            this.Dgv_Conciliaciones.RowTemplate.Height = 24;
            this.Dgv_Conciliaciones.Size = new System.Drawing.Size(1254, 522);
            this.Dgv_Conciliaciones.TabIndex = 20;
            this.Dgv_Conciliaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Conciliaciones_CellContentClick);
            // 
            // Btn_SalirBuscarCB
            // 
            this.Btn_SalirBuscarCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SalirBuscarCB.Image = ((System.Drawing.Image)(resources.GetObject("Btn_SalirBuscarCB.Image")));
            this.Btn_SalirBuscarCB.Location = new System.Drawing.Point(1220, 8);
            this.Btn_SalirBuscarCB.Name = "Btn_SalirBuscarCB";
            this.Btn_SalirBuscarCB.Size = new System.Drawing.Size(50, 50);
            this.Btn_SalirBuscarCB.TabIndex = 22;
            this.Btn_SalirBuscarCB.UseVisualStyleBackColor = true;
            this.Btn_SalirBuscarCB.Click += new System.EventHandler(this.Btn_SalirBuscarCB_Click);
            // 
            // Btn_AyudaBC
            // 
            this.Btn_AyudaBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AyudaBC.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AyudaBC.Image")));
            this.Btn_AyudaBC.Location = new System.Drawing.Point(1164, 8);
            this.Btn_AyudaBC.Name = "Btn_AyudaBC";
            this.Btn_AyudaBC.Size = new System.Drawing.Size(50, 50);
            this.Btn_AyudaBC.TabIndex = 21;
            this.Btn_AyudaBC.UseVisualStyleBackColor = true;
            this.Btn_AyudaBC.Click += new System.EventHandler(this.Btn_AyudaBC_Click);
            // 
            // Btn_ModificarSeleccion
            // 
            this.Btn_ModificarSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ModificarSeleccion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ModificarSeleccion.Image")));
            this.Btn_ModificarSeleccion.Location = new System.Drawing.Point(16, 63);
            this.Btn_ModificarSeleccion.Name = "Btn_ModificarSeleccion";
            this.Btn_ModificarSeleccion.Size = new System.Drawing.Size(50, 50);
            this.Btn_ModificarSeleccion.TabIndex = 17;
            this.Btn_ModificarSeleccion.UseVisualStyleBackColor = true;
            this.Btn_ModificarSeleccion.Click += new System.EventHandler(this.Btn_ModificarSeleccion_Click);
            // 
            // Btn_EliminarCB
            // 
            this.Btn_EliminarCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EliminarCB.Image = ((System.Drawing.Image)(resources.GetObject("Btn_EliminarCB.Image")));
            this.Btn_EliminarCB.Location = new System.Drawing.Point(72, 63);
            this.Btn_EliminarCB.Name = "Btn_EliminarCB";
            this.Btn_EliminarCB.Size = new System.Drawing.Size(50, 50);
            this.Btn_EliminarCB.TabIndex = 18;
            this.Btn_EliminarCB.UseVisualStyleBackColor = true;
            this.Btn_EliminarCB.Click += new System.EventHandler(this.Btn_EliminarCB_Click);
            // 
            // Frm_BuscarConciliacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.Btn_EliminarCB);
            this.Controls.Add(this.Btn_ModificarSeleccion);
            this.Controls.Add(this.Btn_AyudaBC);
            this.Controls.Add(this.Btn_SalirBuscarCB);
            this.Controls.Add(this.Dgv_Conciliaciones);
            this.Controls.Add(this.Lbl_TituloBuscarCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_BuscarConciliacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_BuscarConciliacion";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Conciliaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_TituloBuscarCB;
        private System.Windows.Forms.DataGridView Dgv_Conciliaciones;
        private System.Windows.Forms.Button Btn_SalirBuscarCB;
        private System.Windows.Forms.Button Btn_AyudaBC;
        private System.Windows.Forms.Button Btn_ModificarSeleccion;
        private System.Windows.Forms.Button Btn_EliminarCB;
    }
}