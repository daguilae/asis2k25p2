
namespace Capa_Vista_Nominas
{
    partial class CrearDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearDepartamento));
            this.Gpb_CrearDepa = new System.Windows.Forms.GroupBox();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Lbl_NombreDepa = new System.Windows.Forms.Label();
            this.Txt_Depa = new System.Windows.Forms.TextBox();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Gpb_CrearDepa.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_CrearDepa
            // 
            this.Gpb_CrearDepa.Controls.Add(this.Txt_Descripcion);
            this.Gpb_CrearDepa.Controls.Add(this.Txt_Depa);
            this.Gpb_CrearDepa.Controls.Add(this.Btn_Regresar);
            this.Gpb_CrearDepa.Controls.Add(this.Btn_Guardar);
            this.Gpb_CrearDepa.Controls.Add(this.Lbl_Descripcion);
            this.Gpb_CrearDepa.Controls.Add(this.Lbl_NombreDepa);
            this.Gpb_CrearDepa.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_CrearDepa.Location = new System.Drawing.Point(12, 12);
            this.Gpb_CrearDepa.Name = "Gpb_CrearDepa";
            this.Gpb_CrearDepa.Size = new System.Drawing.Size(769, 358);
            this.Gpb_CrearDepa.TabIndex = 10;
            this.Gpb_CrearDepa.TabStop = false;
            this.Gpb_CrearDepa.Text = "Crear Departamentos";
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Regresar.Image")));
            this.Btn_Regresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Regresar.Location = new System.Drawing.Point(455, 271);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(89, 60);
            this.Btn_Regresar.TabIndex = 13;
            this.Btn_Regresar.Text = "Regresar";
            this.Btn_Regresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Regresar.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Guardar.Location = new System.Drawing.Point(360, 271);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(89, 60);
            this.Btn_Guardar.TabIndex = 12;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Descripcion.Location = new System.Drawing.Point(36, 145);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(94, 17);
            this.Lbl_Descripcion.TabIndex = 8;
            this.Lbl_Descripcion.Text = "Descripción";
            // 
            // Lbl_NombreDepa
            // 
            this.Lbl_NombreDepa.AutoSize = true;
            this.Lbl_NombreDepa.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NombreDepa.Location = new System.Drawing.Point(38, 86);
            this.Lbl_NombreDepa.Name = "Lbl_NombreDepa";
            this.Lbl_NombreDepa.Size = new System.Drawing.Size(200, 17);
            this.Lbl_NombreDepa.TabIndex = 7;
            this.Lbl_NombreDepa.Text = "Nombre Del Departamento";
            // 
            // Txt_Depa
            // 
            this.Txt_Depa.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Depa.Location = new System.Drawing.Point(244, 83);
            this.Txt_Depa.Multiline = true;
            this.Txt_Depa.Name = "Txt_Depa";
            this.Txt_Depa.Size = new System.Drawing.Size(300, 25);
            this.Txt_Depa.TabIndex = 16;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descripcion.Location = new System.Drawing.Point(146, 142);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(598, 92);
            this.Txt_Descripcion.TabIndex = 17;
            // 
            // CrearDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 390);
            this.Controls.Add(this.Gpb_CrearDepa);
            this.Name = "CrearDepartamento";
            this.Text = "CrearDepartamento";
            this.Gpb_CrearDepa.ResumeLayout(false);
            this.Gpb_CrearDepa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_CrearDepa;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.Label Lbl_NombreDepa;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.TextBox Txt_Depa;
    }
}