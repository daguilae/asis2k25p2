
namespace Capa_Vista_Modulo_Comercial
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
            // 
            this.Btn_Orden.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_Orden.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Orden.Name = "Btn_Orden";
            this.Btn_Orden.Size = new System.Drawing.Size(163, 24);
            this.Btn_Orden.Text = "Orrden de Compra";
            this.Btn_Orden.Click += new System.EventHandler(this.Btn_Orden_Click);
            // 
            // Btn_FacturaProveedor
            // 
            this.Btn_FacturaProveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_FacturaProveedor.Image = ((System.Drawing.Image)(resources.GetObject("Btn_FacturaProveedor.Image")));
            this.Btn_FacturaProveedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_FacturaProveedor.Name = "Btn_FacturaProveedor";
            this.Btn_FacturaProveedor.Size = new System.Drawing.Size(166, 24);
            this.Btn_FacturaProveedor.Text = "Facturas Proveedor";
            this.Btn_FacturaProveedor.Click += new System.EventHandler(this.Btn_FacturaProveedor_Click);
            // 
            // Btn_Notas
            // 
            this.Btn_Notas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_Notas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Notas.Image")));
            this.Btn_Notas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Notas.Name = "Btn_Notas";
            this.Btn_Notas.Size = new System.Drawing.Size(180, 24);
            this.Btn_Notas.Text = "Notas Credito/Debito";
            this.Btn_Notas.Click += new System.EventHandler(this.Btn_Notas_Click);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(151, 24);
            this.Btn_Reporte.Text = "Reporte Compras";
            this.Btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click);
            // 
            // Btn_Contabilidad
            // 
            this.Btn_Contabilidad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_Contabilidad.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Contabilidad.Image")));
            this.Btn_Contabilidad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Contabilidad.Name = "Btn_Contabilidad";
            this.Btn_Contabilidad.Size = new System.Drawing.Size(163, 24);
            this.Btn_Contabilidad.Text = "Envio Contabilidad";
            this.Btn_Contabilidad.Click += new System.EventHandler(this.Btn_Contabilidad_Click);
            // 
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