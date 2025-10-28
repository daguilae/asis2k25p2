
namespace Capa_Vista_Nominas
{
    partial class Vacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vacaciones));
            this.Gpb_Vacaciones = new System.Windows.Forms.GroupBox();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Soli = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Dvg_HoraE = new System.Windows.Forms.DataGridView();
            this.Lbl_NomE = new System.Windows.Forms.Label();
            this.Cbo_NombreE = new System.Windows.Forms.ComboBox();
            this.Gpb_Vacaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_HoraE)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_Vacaciones
            // 
            this.Gpb_Vacaciones.Controls.Add(this.Btn_Eliminar);
            this.Gpb_Vacaciones.Controls.Add(this.Btn_Modificar);
            this.Gpb_Vacaciones.Controls.Add(this.Btn_Soli);
            this.Gpb_Vacaciones.Controls.Add(this.Btn_buscar);
            this.Gpb_Vacaciones.Controls.Add(this.Cbo_NombreE);
            this.Gpb_Vacaciones.Controls.Add(this.Lbl_NomE);
            this.Gpb_Vacaciones.Controls.Add(this.Dvg_HoraE);
            this.Gpb_Vacaciones.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Vacaciones.Location = new System.Drawing.Point(12, 12);
            this.Gpb_Vacaciones.Name = "Gpb_Vacaciones";
            this.Gpb_Vacaciones.Size = new System.Drawing.Size(829, 354);
            this.Gpb_Vacaciones.TabIndex = 1;
            this.Gpb_Vacaciones.TabStop = false;
            this.Gpb_Vacaciones.Text = "Vacaciones";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Eliminar.Location = new System.Drawing.Point(665, 24);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(75, 54);
            this.Btn_Eliminar.TabIndex = 13;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Modificar.Location = new System.Drawing.Point(584, 24);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(75, 54);
            this.Btn_Modificar.TabIndex = 12;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // Btn_Soli
            // 
            this.Btn_Soli.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Soli.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Soli.Image")));
            this.Btn_Soli.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Soli.Location = new System.Drawing.Point(503, 24);
            this.Btn_Soli.Name = "Btn_Soli";
            this.Btn_Soli.Size = new System.Drawing.Size(75, 54);
            this.Btn_Soli.TabIndex = 11;
            this.Btn_Soli.Text = "Solicitar";
            this.Btn_Soli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Soli.UseVisualStyleBackColor = true;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_buscar.Image")));
            this.Btn_buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_buscar.Location = new System.Drawing.Point(422, 24);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(75, 54);
            this.Btn_buscar.TabIndex = 10;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Dvg_HoraE
            // 
            this.Dvg_HoraE.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dvg_HoraE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_HoraE.Location = new System.Drawing.Point(16, 92);
            this.Dvg_HoraE.Name = "Dvg_HoraE";
            this.Dvg_HoraE.Size = new System.Drawing.Size(776, 245);
            this.Dvg_HoraE.TabIndex = 7;
            // 
            // Lbl_NomE
            // 
            this.Lbl_NomE.AutoSize = true;
            this.Lbl_NomE.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomE.Location = new System.Drawing.Point(16, 39);
            this.Lbl_NomE.Name = "Lbl_NomE";
            this.Lbl_NomE.Size = new System.Drawing.Size(224, 27);
            this.Lbl_NomE.TabIndex = 8;
            this.Lbl_NomE.Text = "Nombre Empleado";
            // 
            // Cbo_NombreE
            // 
            this.Cbo_NombreE.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_NombreE.FormattingEnabled = true;
            this.Cbo_NombreE.Location = new System.Drawing.Point(246, 39);
            this.Cbo_NombreE.Name = "Cbo_NombreE";
            this.Cbo_NombreE.Size = new System.Drawing.Size(154, 27);
            this.Cbo_NombreE.TabIndex = 9;
            // 
            // Vacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 385);
            this.Controls.Add(this.Gpb_Vacaciones);
            this.Name = "Vacaciones";
            this.Text = "Vacaciones";
            this.Gpb_Vacaciones.ResumeLayout(false);
            this.Gpb_Vacaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_HoraE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_Vacaciones;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Soli;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.DataGridView Dvg_HoraE;
        private System.Windows.Forms.ComboBox Cbo_NombreE;
        private System.Windows.Forms.Label Lbl_NomE;
    }
}