
namespace Capa_Vista_Inventario
{
    partial class Frm_Menu_General
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
            this.Ms_Principal = new System.Windows.Forms.MenuStrip();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cxCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cxPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ms_Principal
            // 
            this.Ms_Principal.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ms_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem,
            this.cxCToolStripMenuItem,
            this.cxPToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.ventasFacturasToolStripMenuItem});
            this.Ms_Principal.Location = new System.Drawing.Point(0, 0);
            this.Ms_Principal.Name = "Ms_Principal";
            this.Ms_Principal.Size = new System.Drawing.Size(484, 26);
            this.Ms_Principal.TabIndex = 0;
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // cxCToolStripMenuItem
            // 
            this.cxCToolStripMenuItem.Name = "cxCToolStripMenuItem";
            this.cxCToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.cxCToolStripMenuItem.Text = "CxC";
            this.cxCToolStripMenuItem.Click += new System.EventHandler(this.cxCToolStripMenuItem_Click);
            // 
            // cxPToolStripMenuItem
            // 
            this.cxPToolStripMenuItem.Name = "cxPToolStripMenuItem";
            this.cxPToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.cxPToolStripMenuItem.Text = "CxP";
            this.cxPToolStripMenuItem.Click += new System.EventHandler(this.cxPToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // ventasFacturasToolStripMenuItem
            // 
            this.ventasFacturasToolStripMenuItem.Name = "ventasFacturasToolStripMenuItem";
            this.ventasFacturasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ventasFacturasToolStripMenuItem.Text = "Ventas/Facturas";
            this.ventasFacturasToolStripMenuItem.Click += new System.EventHandler(this.ventasFacturasToolStripMenuItem_Click);
            // 
            // Frm_Menu_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Ms_Principal);
            this.MainMenuStrip = this.Ms_Principal;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Frm_Menu_General";
            this.Text = "Frm_Menu_General";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Ms_Principal.ResumeLayout(false);
            this.Ms_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Ms_Principal;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cxCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cxPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasFacturasToolStripMenuItem;
    }
}