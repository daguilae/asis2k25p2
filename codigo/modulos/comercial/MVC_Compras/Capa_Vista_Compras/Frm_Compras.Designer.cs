
namespace Capa_Vista_Compras
{
     partial class Frm_Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Compras));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Orden = new System.Windows.Forms.ToolStripButton();
            this.Btn_FacturaProveedor = new System.Windows.Forms.ToolStripButton();
            this.Btn_Notas = new System.Windows.Forms.ToolStripButton();
            this.Btn_Reporte = new System.Windows.Forms.ToolStripButton();
            this.Btn_Contabilidad = new System.Windows.Forms.ToolStripButton();
            this.Btn_Salir = new System.Windows.Forms.ToolStripButton();
            this.Pnl_Contenido = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Orden,
            this.Btn_FacturaProveedor,
            this.Btn_Notas,
            this.Btn_Reporte,
            this.Btn_Contabilidad,
            this.Btn_Salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(896, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "tool_Compras";
            // 
            // Btn_Orden
 
            // Btn_Salir
            // 
            this.Btn_Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(48, 24);
            this.Btn_Salir.Text = "Salir";
            // 
            // Pnl_Contenido
            // 
            this.Pnl_Contenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Pnl_Contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Contenido.Location = new System.Drawing.Point(0, 27);
            this.Pnl_Contenido.Name = "Pnl_Contenido";
            this.Pnl_Contenido.Size = new System.Drawing.Size(896, 423);
            this.Pnl_Contenido.TabIndex = 1;
            // 
            // Frm_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.Pnl_Contenido);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_Compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Orden_Compra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Orden;
        private System.Windows.Forms.ToolStripButton Btn_FacturaProveedor;
        private System.Windows.Forms.ToolStripButton Btn_Notas;
        private System.Windows.Forms.ToolStripButton Btn_Reporte;
        private System.Windows.Forms.ToolStripButton Btn_Contabilidad;
        private System.Windows.Forms.ToolStripButton Btn_Salir;
        private System.Windows.Forms.Panel Pnl_Contenido;
    }
}