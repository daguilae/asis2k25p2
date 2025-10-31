
namespace Capa_Vista_CxP
{
    partial class Frm_CxP_navegación
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
            this.Ms_CxP_Navegacion = new System.Windows.Forms.MenuStrip();
            this.gestionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicaciónDePagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_CxP_Navegacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ms_CxP_Navegacion
            // 
            this.Ms_CxP_Navegacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Ms_CxP_Navegacion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Ms_CxP_Navegacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionesToolStripMenuItem,
            this.aplicaciónDePagosToolStripMenuItem,
            this.historialesToolStripMenuItem});
            this.Ms_CxP_Navegacion.Location = new System.Drawing.Point(0, 0);
            this.Ms_CxP_Navegacion.Name = "Ms_CxP_Navegacion";
            this.Ms_CxP_Navegacion.Size = new System.Drawing.Size(762, 29);
            this.Ms_CxP_Navegacion.TabIndex = 0;
            this.Ms_CxP_Navegacion.Text = "menuStrip1";
            // 
            // gestionesToolStripMenuItem
            // 
            this.gestionesToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionesToolStripMenuItem.Name = "gestionesToolStripMenuItem";
            this.gestionesToolStripMenuItem.Size = new System.Drawing.Size(113, 25);
            this.gestionesToolStripMenuItem.Text = "Gestiones";
            // 
            // aplicaciónDePagosToolStripMenuItem
            // 
            this.aplicaciónDePagosToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aplicaciónDePagosToolStripMenuItem.Name = "aplicaciónDePagosToolStripMenuItem";
            this.aplicaciónDePagosToolStripMenuItem.Size = new System.Drawing.Size(206, 25);
            this.aplicaciónDePagosToolStripMenuItem.Text = "Aplicación de pagos";
            // 
            // historialesToolStripMenuItem
            // 
            this.historialesToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historialesToolStripMenuItem.Name = "historialesToolStripMenuItem";
            this.historialesToolStripMenuItem.Size = new System.Drawing.Size(119, 25);
            this.historialesToolStripMenuItem.Text = "Historiales";
            // 
            // Frm_CxP_navegación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(762, 483);
            this.Controls.Add(this.Ms_CxP_Navegacion);
            this.MainMenuStrip = this.Ms_CxP_Navegacion;
            this.Name = "Frm_CxP_navegación";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CxP_navegación";
            this.Ms_CxP_Navegacion.ResumeLayout(false);
            this.Ms_CxP_Navegacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Ms_CxP_Navegacion;
        private System.Windows.Forms.ToolStripMenuItem gestionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicaciónDePagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialesToolStripMenuItem;
    }
}