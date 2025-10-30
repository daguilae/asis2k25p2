namespace Capa_Vista_CxC
{
    partial class Frm_AplicarPago
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mnuRecibos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAplicarPago = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAntiguedad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCierre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();

            this.Gpb_Pago = new System.Windows.Forms.GroupBox();
            this.Lbl_Metodo = new System.Windows.Forms.Label();
            this.Cbo_Metodo = new System.Windows.Forms.ComboBox();
            this.Lbl_Monto = new System.Windows.Forms.Label();
            this.Txt_Monto = new System.Windows.Forms.TextBox();
            this.Lbl_Referencia = new System.Windows.Forms.Label();
            this.Txt_Referencia = new System.Windows.Forms.TextBox();
            this.Lbl_FechaPago = new System.Windows.Forms.Label();
            this.Dtp_FechaPago = new System.Windows.Forms.DateTimePicker();
            this.Btn_AgregarLineaPago = new System.Windows.Forms.Button();

            this.gridLineasPago = new System.Windows.Forms.DataGridView();
            this.colLPFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLPCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLPSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLPMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLPMetodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLPRef = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.Lbl_TotalPago = new System.Windows.Forms.Label();
            this.Txt_TotalPago = new System.Windows.Forms.TextBox();
            this.Btn_GuardarPago = new System.Windows.Forms.Button();
            this.Btn_CancelarPago = new System.Windows.Forms.Button();

            this.menu.SuspendLayout();
            this.Gpb_Pago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLineasPago)).BeginInit();
            this.SuspendLayout();

            // MenuStrip
            this.menu.BackColor = System.Drawing.Color.FromArgb(192, 192, 0);
            this.menu.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuRecibos, this.mnuAplicarPago, this.mnuAntiguedad, this.mnuReportes, this.mnuCierre, this.mnuSalir
            });
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1200, 24);
            this.menu.TabIndex = 0;

            this.mnuRecibos.Text = "Recibos";
            this.mnuAplicarPago.Text = "Aplicar Pago";
            this.mnuAntiguedad.Text = "Antigüedad";
            this.mnuReportes.Text = "Reportes";
            this.mnuCierre.Text = "Cierre de Caja";
            this.mnuSalir.Text = "Salir";

            // Gpb_Pago
            this.Gpb_Pago.BackColor = System.Drawing.Color.FromArgb(192, 192, 0);
            this.Gpb_Pago.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gpb_Pago.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Gpb_Pago.Text = "Detalle de pago";
            this.Gpb_Pago.Height = 140;

            this.Lbl_Metodo.AutoSize = true;
            this.Lbl_Metodo.Location = new System.Drawing.Point(16, 34);
            this.Lbl_Metodo.Text = "Método:";
            this.Cbo_Metodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Metodo.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia", "Criptomoneda" });
            this.Cbo_Metodo.Location = new System.Drawing.Point(80, 30);
            this.Cbo_Metodo.Size = new System.Drawing.Size(170, 24);

            this.Lbl_Monto.AutoSize = true;
            this.Lbl_Monto.Location = new System.Drawing.Point(270, 34);
            this.Lbl_Monto.Text = "Monto:";
            this.Txt_Monto.Location = new System.Drawing.Point(325, 30);
            this.Txt_Monto.Size = new System.Drawing.Size(120, 23);

            this.Lbl_Referencia.AutoSize = true;
            this.Lbl_Referencia.Location = new System.Drawing.Point(455, 34);
            this.Lbl_Referencia.Text = "Referencia:";
            this.Txt_Referencia.Location = new System.Drawing.Point(535, 30);
            this.Txt_Referencia.Size = new System.Drawing.Size(210, 23);

            this.Lbl_FechaPago.AutoSize = true;
            this.Lbl_FechaPago.Location = new System.Drawing.Point(755, 34);
            this.Lbl_FechaPago.Text = "Fecha:";
            this.Dtp_FechaPago.Location = new System.Drawing.Point(805, 30);
            this.Dtp_FechaPago.Size = new System.Drawing.Size(170, 23);

            this.Btn_AgregarLineaPago.Enabled = false;
            this.Btn_AgregarLineaPago.Location = new System.Drawing.Point(990, 29);
            this.Btn_AgregarLineaPago.Size = new System.Drawing.Size(110, 25);
            this.Btn_AgregarLineaPago.Text = "Agregar a líneas";

            this.Gpb_Pago.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.Lbl_Metodo, this.Cbo_Metodo, this.Lbl_Monto, this.Txt_Monto,
                this.Lbl_Referencia, this.Txt_Referencia, this.Lbl_FechaPago, this.Dtp_FechaPago,
                this.Btn_AgregarLineaPago
            });

            // gridLineasPago
            this.gridLineasPago.AllowUserToAddRows = false;
            this.gridLineasPago.AllowUserToDeleteRows = false;
            this.gridLineasPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLineasPago.BackgroundColor = System.Drawing.Color.FromArgb(192, 192, 0);
            this.gridLineasPago.ColumnHeadersHeight = 29;
            this.gridLineasPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLineasPago.ReadOnly = true;
            this.gridLineasPago.Location = new System.Drawing.Point(0, 164);
            this.gridLineasPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colLPFactura, this.colLPCliente, this.colLPSaldo, this.colLPMonto, this.colLPMetodo, this.colLPRef
            });

            this.colLPFactura.HeaderText = "Factura";
            this.colLPCliente.HeaderText = "Cliente";
            this.colLPSaldo.HeaderText = "Saldo";
            this.colLPMonto.HeaderText = "Monto";
            this.colLPMetodo.HeaderText = "Método";
            this.colLPRef.HeaderText = "Referencia";

            // Bottom controls (Total + Botones)
            this.Lbl_TotalPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_TotalPago.Location = new System.Drawing.Point(740, 680);
            this.Lbl_TotalPago.Size = new System.Drawing.Size(110, 23);
            this.Lbl_TotalPago.Text = "Total del pago:";

            this.Txt_TotalPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_TotalPago.Location = new System.Drawing.Point(850, 677);
            this.Txt_TotalPago.ReadOnly = true;
            this.Txt_TotalPago.Size = new System.Drawing.Size(120, 23);

            this.Btn_CancelarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_CancelarPago.Enabled = false;
            this.Btn_CancelarPago.Location = new System.Drawing.Point(980, 676);
            this.Btn_CancelarPago.Size = new System.Drawing.Size(85, 25);
            this.Btn_CancelarPago.Text = "Cancelar";

            this.Btn_GuardarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_GuardarPago.Enabled = false;
            this.Btn_GuardarPago.Location = new System.Drawing.Point(1070, 676);
            this.Btn_GuardarPago.Size = new System.Drawing.Size(85, 25);
            this.Btn_GuardarPago.Text = "Guardar";

            // Frm_AplicarPago
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(192, 192, 0);
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.gridLineasPago);
            this.Controls.Add(this.Lbl_TotalPago);
            this.Controls.Add(this.Txt_TotalPago);
            this.Controls.Add(this.Btn_CancelarPago);
            this.Controls.Add(this.Btn_GuardarPago);
            this.Controls.Add(this.Gpb_Pago);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Rockwell", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Frm_AplicarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas por Cobrar — Aplicar Pago (Prototipo)";

            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.Gpb_Pago.ResumeLayout(false);
            this.Gpb_Pago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLineasPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnuRecibos;
        private System.Windows.Forms.ToolStripMenuItem mnuAplicarPago;
        private System.Windows.Forms.ToolStripMenuItem mnuAntiguedad;
        private System.Windows.Forms.ToolStripMenuItem mnuReportes;
        private System.Windows.Forms.ToolStripMenuItem mnuCierre;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;

        private System.Windows.Forms.GroupBox Gpb_Pago;
        private System.Windows.Forms.Label Lbl_Metodo;
        private System.Windows.Forms.ComboBox Cbo_Metodo;
        private System.Windows.Forms.Label Lbl_Monto;
        private System.Windows.Forms.TextBox Txt_Monto;
        private System.Windows.Forms.Label Lbl_Referencia;
        private System.Windows.Forms.TextBox Txt_Referencia;
        private System.Windows.Forms.Label Lbl_FechaPago;
        private System.Windows.Forms.DateTimePicker Dtp_FechaPago;
        private System.Windows.Forms.Button Btn_AgregarLineaPago;

        private System.Windows.Forms.DataGridView gridLineasPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLPFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLPCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLPSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLPMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLPMetodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLPRef;

        private System.Windows.Forms.Label Lbl_TotalPago;
        private System.Windows.Forms.TextBox Txt_TotalPago;
        private System.Windows.Forms.Button Btn_GuardarPago;
        private System.Windows.Forms.Button Btn_CancelarPago;
    }
}
