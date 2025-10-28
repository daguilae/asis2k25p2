
namespace Capa_Vista_Nominas
{
    partial class CrearPuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearPuesto));
            this.Gpb_CrearPuesto = new System.Windows.Forms.GroupBox();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Txt_Puesto = new System.Windows.Forms.TextBox();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Lbl_NombrePuesto = new System.Windows.Forms.Label();
            this.Txt_Rango = new System.Windows.Forms.TextBox();
            this.Lbl_RangoS = new System.Windows.Forms.Label();
            this.Cbo_Departamento = new System.Windows.Forms.ComboBox();
            this.Lbl_Departamento = new System.Windows.Forms.Label();
            this.Gpb_CrearPuesto.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_CrearPuesto
            // 
            this.Gpb_CrearPuesto.Controls.Add(this.Lbl_Departamento);
            this.Gpb_CrearPuesto.Controls.Add(this.Cbo_Departamento);
            this.Gpb_CrearPuesto.Controls.Add(this.Txt_Rango);
            this.Gpb_CrearPuesto.Controls.Add(this.Lbl_RangoS);
            this.Gpb_CrearPuesto.Controls.Add(this.Txt_Descripcion);
            this.Gpb_CrearPuesto.Controls.Add(this.Txt_Puesto);
            this.Gpb_CrearPuesto.Controls.Add(this.Btn_Regresar);
            this.Gpb_CrearPuesto.Controls.Add(this.Btn_Guardar);
            this.Gpb_CrearPuesto.Controls.Add(this.Lbl_Descripcion);
            this.Gpb_CrearPuesto.Controls.Add(this.Lbl_NombrePuesto);
            this.Gpb_CrearPuesto.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_CrearPuesto.Location = new System.Drawing.Point(12, 12);
            this.Gpb_CrearPuesto.Name = "Gpb_CrearPuesto";
            this.Gpb_CrearPuesto.Size = new System.Drawing.Size(1011, 403);
            this.Gpb_CrearPuesto.TabIndex = 11;
            this.Gpb_CrearPuesto.TabStop = false;
            this.Gpb_CrearPuesto.Text = "Crear Puestos";
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descripcion.Location = new System.Drawing.Point(246, 185);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(598, 92);
            this.Txt_Descripcion.TabIndex = 17;
            // 
            // Txt_Puesto
            // 
            this.Txt_Puesto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Puesto.Location = new System.Drawing.Point(17, 132);
            this.Txt_Puesto.Multiline = true;
            this.Txt_Puesto.Name = "Txt_Puesto";
            this.Txt_Puesto.Size = new System.Drawing.Size(300, 25);
            this.Txt_Puesto.TabIndex = 16;
            this.Txt_Puesto.TextChanged += new System.EventHandler(this.Txt_Puesto_TextChanged);
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Regresar.Image")));
            this.Btn_Regresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Regresar.Location = new System.Drawing.Point(555, 314);
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
            this.Btn_Guardar.Location = new System.Drawing.Point(460, 314);
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
            this.Lbl_Descripcion.Location = new System.Drawing.Point(136, 188);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(94, 17);
            this.Lbl_Descripcion.TabIndex = 8;
            this.Lbl_Descripcion.Text = "Descripción";
            // 
            // Lbl_NombrePuesto
            // 
            this.Lbl_NombrePuesto.AutoSize = true;
            this.Lbl_NombrePuesto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NombrePuesto.Location = new System.Drawing.Point(33, 103);
            this.Lbl_NombrePuesto.Name = "Lbl_NombrePuesto";
            this.Lbl_NombrePuesto.Size = new System.Drawing.Size(147, 17);
            this.Lbl_NombrePuesto.TabIndex = 7;
            this.Lbl_NombrePuesto.Text = "Nombre Del Puesto";
            this.Lbl_NombrePuesto.Click += new System.EventHandler(this.Lbl_NombrePuesto_Click);
            // 
            // Txt_Rango
            // 
            this.Txt_Rango.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Rango.Location = new System.Drawing.Point(355, 132);
            this.Txt_Rango.Multiline = true;
            this.Txt_Rango.Name = "Txt_Rango";
            this.Txt_Rango.Size = new System.Drawing.Size(300, 25);
            this.Txt_Rango.TabIndex = 19;
            // 
            // Lbl_RangoS
            // 
            this.Lbl_RangoS.AutoSize = true;
            this.Lbl_RangoS.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RangoS.Location = new System.Drawing.Point(371, 103);
            this.Lbl_RangoS.Name = "Lbl_RangoS";
            this.Lbl_RangoS.Size = new System.Drawing.Size(132, 17);
            this.Lbl_RangoS.TabIndex = 18;
            this.Lbl_RangoS.Text = "Rango del Salario";
            // 
            // Cbo_Departamento
            // 
            this.Cbo_Departamento.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Departamento.FormattingEnabled = true;
            this.Cbo_Departamento.Location = new System.Drawing.Point(742, 132);
            this.Cbo_Departamento.Name = "Cbo_Departamento";
            this.Cbo_Departamento.Size = new System.Drawing.Size(197, 25);
            this.Cbo_Departamento.TabIndex = 20;
            // 
            // Lbl_Departamento
            // 
            this.Lbl_Departamento.AutoSize = true;
            this.Lbl_Departamento.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Departamento.Location = new System.Drawing.Point(754, 103);
            this.Lbl_Departamento.Name = "Lbl_Departamento";
            this.Lbl_Departamento.Size = new System.Drawing.Size(109, 17);
            this.Lbl_Departamento.TabIndex = 21;
            this.Lbl_Departamento.Text = "Departamento";
            // 
            // CrearPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 429);
            this.Controls.Add(this.Gpb_CrearPuesto);
            this.Name = "CrearPuesto";
            this.Text = "CrearPuesto";
            this.Gpb_CrearPuesto.ResumeLayout(false);
            this.Gpb_CrearPuesto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_CrearPuesto;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.TextBox Txt_Puesto;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.Label Lbl_NombrePuesto;
        private System.Windows.Forms.TextBox Txt_Rango;
        private System.Windows.Forms.Label Lbl_RangoS;
        private System.Windows.Forms.Label Lbl_Departamento;
        private System.Windows.Forms.ComboBox Cbo_Departamento;
    }
}