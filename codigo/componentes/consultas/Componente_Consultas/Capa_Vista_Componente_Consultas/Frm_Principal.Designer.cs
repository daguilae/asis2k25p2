﻿
namespace Capa_Vista_Componente_Consultas
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.btn_ConsultaSimple = new System.Windows.Forms.Button();
            this.btn_ConsultaCompleja = new System.Windows.Forms.Button();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.lbl_Bienvenida = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.lbl_Instrucciones = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ConsultaSimple
            // 
            this.btn_ConsultaSimple.Location = new System.Drawing.Point(330, 101);
            this.btn_ConsultaSimple.Name = "btn_ConsultaSimple";
            this.btn_ConsultaSimple.Size = new System.Drawing.Size(116, 54);
            this.btn_ConsultaSimple.TabIndex = 0;
            this.btn_ConsultaSimple.Text = "Consultas Simples";
            this.btn_ConsultaSimple.UseVisualStyleBackColor = true;
            this.btn_ConsultaSimple.Click += new System.EventHandler(this.btn_ConsultaSimple_Click);
            // 
            // btn_ConsultaCompleja
            // 
            this.btn_ConsultaCompleja.Location = new System.Drawing.Point(330, 170);
            this.btn_ConsultaCompleja.Name = "btn_ConsultaCompleja";
            this.btn_ConsultaCompleja.Size = new System.Drawing.Size(116, 56);
            this.btn_ConsultaCompleja.TabIndex = 1;
            this.btn_ConsultaCompleja.Text = "Consulta Compleja";
            this.btn_ConsultaCompleja.UseVisualStyleBackColor = true;
            this.btn_ConsultaCompleja.Click += new System.EventHandler(this.btn_ConsultaCompleja_Click);
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.Location = new System.Drawing.Point(347, 318);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(75, 50);
            this.btn_Ayuda.TabIndex = 2;
            this.btn_Ayuda.Text = "Ayuda";
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // lbl_Bienvenida
            // 
            this.lbl_Bienvenida.AutoSize = true;
            this.lbl_Bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bienvenida.Location = new System.Drawing.Point(316, 23);
            this.lbl_Bienvenida.Name = "lbl_Bienvenida";
            this.lbl_Bienvenida.Size = new System.Drawing.Size(156, 25);
            this.lbl_Bienvenida.TabIndex = 3;
            this.lbl_Bienvenida.Text = "BIENVENIDO!";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(723, 0);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerrar.TabIndex = 4;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // lbl_Instrucciones
            // 
            this.lbl_Instrucciones.AutoSize = true;
            this.lbl_Instrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instrucciones.Location = new System.Drawing.Point(247, 65);
            this.lbl_Instrucciones.Name = "lbl_Instrucciones";
            this.lbl_Instrucciones.Size = new System.Drawing.Size(304, 20);
            this.lbl_Instrucciones.TabIndex = 5;
            this.lbl_Instrucciones.Text = "Por favor, selecciona una de las opciones.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(330, 244);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(116, 56);
            this.Btn_editar.TabIndex = 7;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Instrucciones);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.lbl_Bienvenida);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.btn_ConsultaCompleja);
            this.Controls.Add(this.btn_ConsultaSimple);
            this.Name = "Frm_Principal";
            this.Text = "Frm_Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ConsultaSimple;
        private System.Windows.Forms.Button btn_ConsultaCompleja;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Label lbl_Bienvenida;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label lbl_Instrucciones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_editar;
    }
}