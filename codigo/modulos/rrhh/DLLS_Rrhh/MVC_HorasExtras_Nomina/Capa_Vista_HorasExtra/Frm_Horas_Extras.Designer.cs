// Nombre: Diego Andre Monterroso Rabarique
// Carné: 0901-22-1369
// Fecha de modificación: 2025-11-09
// Descripción: Lógica de negocio para CRUD de Horas_Extras.

namespace Capa_Vista_HorasExtra
{
    partial class Frm_Horas_Extras
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Horas_Extras));
            this.Gpb_HorasExtra = new System.Windows.Forms.GroupBox();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Soli = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Cbo_NombreE = new System.Windows.Forms.ComboBox();
            this.Lbl_NomE = new System.Windows.Forms.Label();
            this.Dvg_HoraE = new System.Windows.Forms.DataGridView();
            this.Pnl_Encabezado = new System.Windows.Forms.Panel();
            this.Lbl_Nomina = new System.Windows.Forms.Label();
            this.Gpb_HorasExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_HoraE)).BeginInit();
            this.Pnl_Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_HorasExtra
            // 
            this.Gpb_HorasExtra.Controls.Add(this.Btn_Eliminar);
            this.Gpb_HorasExtra.Controls.Add(this.Btn_Modificar);
            this.Gpb_HorasExtra.Controls.Add(this.Btn_Soli);
            this.Gpb_HorasExtra.Controls.Add(this.Btn_buscar);
            this.Gpb_HorasExtra.Controls.Add(this.Cbo_NombreE);
            this.Gpb_HorasExtra.Controls.Add(this.Lbl_NomE);
            this.Gpb_HorasExtra.Controls.Add(this.Dvg_HoraE);
            this.Gpb_HorasExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Gpb_HorasExtra.Location = new System.Drawing.Point(3, 86);
            this.Gpb_HorasExtra.Name = "Gpb_HorasExtra";
            this.Gpb_HorasExtra.Size = new System.Drawing.Size(829, 354);
            this.Gpb_HorasExtra.TabIndex = 7;
            this.Gpb_HorasExtra.TabStop = false;
            this.Gpb_HorasExtra.Text = "Horas Extra";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Eliminar.Location = new System.Drawing.Point(665, 24);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(75, 54);
            this.Btn_Eliminar.TabIndex = 13;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 🔹 Vincular evento Click
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Modificar.Location = new System.Drawing.Point(584, 24);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(75, 54);
            this.Btn_Modificar.TabIndex = 12;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            // 🔹 Vincular evento Click
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Soli
            // 
            this.Btn_Soli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_Soli.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Soli.Image")));
            this.Btn_Soli.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Soli.Location = new System.Drawing.Point(503, 24);
            this.Btn_Soli.Name = "Btn_Soli";
            this.Btn_Soli.Size = new System.Drawing.Size(75, 54);
            this.Btn_Soli.TabIndex = 11;
            this.Btn_Soli.Text = "Solicitar";
            this.Btn_Soli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Soli.UseVisualStyleBackColor = true;
            // 🔹 Vincular evento Click
            this.Btn_Soli.Click += new System.EventHandler(this.Btn_Soli_Click);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_buscar.Image")));
            this.Btn_buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_buscar.Location = new System.Drawing.Point(422, 24);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(75, 54);
            this.Btn_buscar.TabIndex = 10;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 🔹 Vincular evento Click
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Cbo_NombreE
            // 
            this.Cbo_NombreE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Cbo_NombreE.FormattingEnabled = true;
            this.Cbo_NombreE.Location = new System.Drawing.Point(246, 39);
            this.Cbo_NombreE.Name = "Cbo_NombreE";
            this.Cbo_NombreE.Size = new System.Drawing.Size(154, 28);
            this.Cbo_NombreE.TabIndex = 9;
            // 
            // Lbl_NomE
            // 
            this.Lbl_NomE.AutoSize = true;
            this.Lbl_NomE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Lbl_NomE.Location = new System.Drawing.Point(16, 39);
            this.Lbl_NomE.Name = "Lbl_NomE";
            this.Lbl_NomE.Size = new System.Drawing.Size(218, 29);
            this.Lbl_NomE.TabIndex = 8;
            this.Lbl_NomE.Text = "Nombre Empleado";
            // 
            // Dvg_HoraE
            // 
            this.Dvg_HoraE.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dvg_HoraE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_HoraE.Location = new System.Drawing.Point(16, 92);
            this.Dvg_HoraE.Name = "Dvg_HoraE";
            this.Dvg_HoraE.RowHeadersWidth = 51;
            this.Dvg_HoraE.Size = new System.Drawing.Size(776, 245);
            this.Dvg_HoraE.TabIndex = 7;
            // 
            // Pnl_Encabezado
            // 
            this.Pnl_Encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Pnl_Encabezado.Controls.Add(this.Lbl_Nomina);
            this.Pnl_Encabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Encabezado.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Encabezado.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_Encabezado.Name = "Pnl_Encabezado";
            this.Pnl_Encabezado.Size = new System.Drawing.Size(901, 81);
            this.Pnl_Encabezado.TabIndex = 6;
            // 
            // Lbl_Nomina
            // 
            this.Lbl_Nomina.AutoSize = true;
            this.Lbl_Nomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Lbl_Nomina.Location = new System.Drawing.Point(26, 27);
            this.Lbl_Nomina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Nomina.Name = "Lbl_Nomina";
            this.Lbl_Nomina.Size = new System.Drawing.Size(109, 29);
            this.Lbl_Nomina.TabIndex = 6;
            this.Lbl_Nomina.Text = "Nominas";
            // 
            // HE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Gpb_HorasExtra);
            this.Controls.Add(this.Pnl_Encabezado);
            this.Name = "HE";
            this.Size = new System.Drawing.Size(901, 472);
            // 🔹 Vincular evento Load

            this.Gpb_HorasExtra.ResumeLayout(false);
            this.Gpb_HorasExtra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_HoraE)).EndInit();
            this.Pnl_Encabezado.ResumeLayout(false);
            this.Pnl_Encabezado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_HorasExtra;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Soli;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.ComboBox Cbo_NombreE;
        private System.Windows.Forms.Label Lbl_NomE;
        private System.Windows.Forms.DataGridView Dvg_HoraE;
        private System.Windows.Forms.Panel Pnl_Encabezado;
        private System.Windows.Forms.Label Lbl_Nomina;
    }
}
