namespace Capa_Vista_CxC
{
    partial class Frm_Recibos
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
            this.splitRecibos = new System.Windows.Forms.SplitContainer();
            this.Dgv_Facturas = new System.Windows.Forms.DataGridView();
            this.colSel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gpb_Buscar = new System.Windows.Forms.GroupBox();
            this.Lbl_BuscarCliente = new System.Windows.Forms.Label();
            this.Txt_BuscarCliente = new System.Windows.Forms.TextBox();
            this.Lbl_Desde = new System.Windows.Forms.Label();
            this.Dtp_Desde = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Hasta = new System.Windows.Forms.Label();
            this.Dtp_Hasta = new System.Windows.Forms.DateTimePicker();
            this.Btn_Filtrar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.gridRecibos = new System.Windows.Forms.DataGridView();
            this.colRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReciboFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReciboCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReciboMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gpb_Recibo = new System.Windows.Forms.GroupBox();
            this.Lbl_NumeroRecibo = new System.Windows.Forms.Label();
            this.Txt_NumeroRecibo = new System.Windows.Forms.TextBox();
            this.Lbl_FechaRecibo = new System.Windows.Forms.Label();
            this.Dtp_FechaRecibo = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Obs = new System.Windows.Forms.Label();
            this.Txt_Obs = new System.Windows.Forms.TextBox();
            this.Btn_NuevoRecibo = new System.Windows.Forms.Button();
            this.Btn_EditarRecibo = new System.Windows.Forms.Button();
            this.Btn_AnularRecibo = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRecibos)).BeginInit();
            this.splitRecibos.Panel1.SuspendLayout();
            this.splitRecibos.Panel2.SuspendLayout();
            this.splitRecibos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Facturas)).BeginInit();
            this.Gpb_Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecibos)).BeginInit();
            this.Gpb_Recibo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRecibos,
            this.mnuAplicarPago,
            this.mnuAntiguedad,
            this.mnuReportes,
            this.mnuCierre,
            this.mnuSalir});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1924, 24);
            this.menu.TabIndex = 0;
            // 
            // mnuRecibos
            // 
            this.mnuRecibos.Name = "mnuRecibos";
            this.mnuRecibos.Size = new System.Drawing.Size(66, 20);
            this.mnuRecibos.Text = "Recibos";
            // 
            // mnuAplicarPago
            // 
            this.mnuAplicarPago.Name = "mnuAplicarPago";
            this.mnuAplicarPago.Size = new System.Drawing.Size(94, 20);
            this.mnuAplicarPago.Text = "Aplicar Pago";
            this.mnuAplicarPago.Click += new System.EventHandler(this.mnuAplicarPago_Click);
            // 
            // mnuAntiguedad
            // 
            this.mnuAntiguedad.Name = "mnuAntiguedad";
            this.mnuAntiguedad.Size = new System.Drawing.Size(88, 20);
            this.mnuAntiguedad.Text = "Antigüedad";
            // 
            // mnuReportes
            // 
            this.mnuReportes.Name = "mnuReportes";
            this.mnuReportes.Size = new System.Drawing.Size(72, 20);
            this.mnuReportes.Text = "Reportes";
            // 
            // mnuCierre
            // 
            this.mnuCierre.Name = "mnuCierre";
            this.mnuCierre.Size = new System.Drawing.Size(105, 20);
            this.mnuCierre.Text = "Cierre de Caja";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(45, 20);
            this.mnuSalir.Text = "Salir";
            // 
            // splitRecibos
            // 
            this.splitRecibos.BackColor = System.Drawing.SystemColors.Control;
            this.splitRecibos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRecibos.Location = new System.Drawing.Point(0, 24);
            this.splitRecibos.Name = "splitRecibos";
            // 
            // splitRecibos.Panel1
            // 
            this.splitRecibos.Panel1.Controls.Add(this.Dgv_Facturas);
            this.splitRecibos.Panel1.Controls.Add(this.Gpb_Buscar);
            // 
            // splitRecibos.Panel2
            // 
            this.splitRecibos.Panel2.Controls.Add(this.gridRecibos);
            this.splitRecibos.Panel2.Controls.Add(this.Gpb_Recibo);
            this.splitRecibos.Size = new System.Drawing.Size(1924, 696);
            this.splitRecibos.SplitterDistance = 1549;
            this.splitRecibos.TabIndex = 1;
            // 
            // Dgv_Facturas
            // 
            this.Dgv_Facturas.AllowUserToAddRows = false;
            this.Dgv_Facturas.AllowUserToDeleteRows = false;
            this.Dgv_Facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Facturas.ColumnHeadersHeight = 29;
            this.Dgv_Facturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSel,
            this.colFactura,
            this.colFecha,
            this.colCliente,
            this.colTotal,
            this.colSaldo});
            this.Dgv_Facturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Facturas.Location = new System.Drawing.Point(0, 85);
            this.Dgv_Facturas.Name = "Dgv_Facturas";
            this.Dgv_Facturas.ReadOnly = true;
            this.Dgv_Facturas.RowHeadersWidth = 51;
            this.Dgv_Facturas.Size = new System.Drawing.Size(1549, 611);
            this.Dgv_Facturas.TabIndex = 0;
            // 
            // colSel
            // 
            this.colSel.HeaderText = "";
            this.colSel.MinimumWidth = 30;
            this.colSel.Name = "colSel";
            this.colSel.ReadOnly = true;
            // 
            // colFactura
            // 
            this.colFactura.HeaderText = "Factura";
            this.colFactura.MinimumWidth = 6;
            this.colFactura.Name = "colFactura";
            this.colFactura.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.MinimumWidth = 6;
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colSaldo
            // 
            this.colSaldo.HeaderText = "Saldo";
            this.colSaldo.MinimumWidth = 6;
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.ReadOnly = true;
            // 
            // Gpb_Buscar
            // 
            this.Gpb_Buscar.BackColor = System.Drawing.SystemColors.Control;
            this.Gpb_Buscar.Controls.Add(this.Lbl_BuscarCliente);
            this.Gpb_Buscar.Controls.Add(this.Txt_BuscarCliente);
            this.Gpb_Buscar.Controls.Add(this.Lbl_Desde);
            this.Gpb_Buscar.Controls.Add(this.Dtp_Desde);
            this.Gpb_Buscar.Controls.Add(this.Lbl_Hasta);
            this.Gpb_Buscar.Controls.Add(this.Dtp_Hasta);
            this.Gpb_Buscar.Controls.Add(this.Btn_Filtrar);
            this.Gpb_Buscar.Controls.Add(this.Btn_Limpiar);
            this.Gpb_Buscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gpb_Buscar.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Gpb_Buscar.Location = new System.Drawing.Point(0, 0);
            this.Gpb_Buscar.Name = "Gpb_Buscar";
            this.Gpb_Buscar.Size = new System.Drawing.Size(1549, 85);
            this.Gpb_Buscar.TabIndex = 1;
            this.Gpb_Buscar.TabStop = false;
            this.Gpb_Buscar.Text = "Filtro de facturas pendientes";
            // 
            // Lbl_BuscarCliente
            // 
            this.Lbl_BuscarCliente.AutoSize = true;
            this.Lbl_BuscarCliente.Location = new System.Drawing.Point(-4, 27);
            this.Lbl_BuscarCliente.Name = "Lbl_BuscarCliente";
            this.Lbl_BuscarCliente.Size = new System.Drawing.Size(53, 16);
            this.Lbl_BuscarCliente.TabIndex = 0;
            this.Lbl_BuscarCliente.Text = "Cliente:";
            // 
            // Txt_BuscarCliente
            // 
            this.Txt_BuscarCliente.Location = new System.Drawing.Point(63, 25);
            this.Txt_BuscarCliente.Name = "Txt_BuscarCliente";
            this.Txt_BuscarCliente.Size = new System.Drawing.Size(220, 23);
            this.Txt_BuscarCliente.TabIndex = 1;
            // 
            // Lbl_Desde
            // 
            this.Lbl_Desde.AutoSize = true;
            this.Lbl_Desde.Location = new System.Drawing.Point(289, 29);
            this.Lbl_Desde.Name = "Lbl_Desde";
            this.Lbl_Desde.Size = new System.Drawing.Size(49, 16);
            this.Lbl_Desde.TabIndex = 2;
            this.Lbl_Desde.Text = "Desde:";
            // 
            // Dtp_Desde
            // 
            this.Dtp_Desde.Location = new System.Drawing.Point(355, 24);
            this.Dtp_Desde.Name = "Dtp_Desde";
            this.Dtp_Desde.Size = new System.Drawing.Size(170, 23);
            this.Dtp_Desde.TabIndex = 3;
            // 
            // Lbl_Hasta
            // 
            this.Lbl_Hasta.AutoSize = true;
            this.Lbl_Hasta.Location = new System.Drawing.Point(531, 27);
            this.Lbl_Hasta.Name = "Lbl_Hasta";
            this.Lbl_Hasta.Size = new System.Drawing.Size(45, 16);
            this.Lbl_Hasta.TabIndex = 4;
            this.Lbl_Hasta.Text = "Hasta:";
            // 
            // Dtp_Hasta
            // 
            this.Dtp_Hasta.Location = new System.Drawing.Point(594, 23);
            this.Dtp_Hasta.Name = "Dtp_Hasta";
            this.Dtp_Hasta.Size = new System.Drawing.Size(170, 23);
            this.Dtp_Hasta.TabIndex = 5;
            // 
            // Btn_Filtrar
            // 
            this.Btn_Filtrar.Enabled = false;
            this.Btn_Filtrar.Location = new System.Drawing.Point(770, 24);
            this.Btn_Filtrar.Name = "Btn_Filtrar";
            this.Btn_Filtrar.Size = new System.Drawing.Size(75, 27);
            this.Btn_Filtrar.TabIndex = 6;
            this.Btn_Filtrar.Text = "Filtrar";
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Enabled = false;
            this.Btn_Limpiar.Location = new System.Drawing.Point(850, 24);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(95, 27);
            this.Btn_Limpiar.TabIndex = 7;
            this.Btn_Limpiar.Text = "Limpiar";
            // 
            // gridRecibos
            // 
            this.gridRecibos.AllowUserToAddRows = false;
            this.gridRecibos.AllowUserToDeleteRows = false;
            this.gridRecibos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRecibos.ColumnHeadersHeight = 29;
            this.gridRecibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRecibo,
            this.colReciboFecha,
            this.colReciboCliente,
            this.colReciboMonto});
            this.gridRecibos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRecibos.Location = new System.Drawing.Point(0, 140);
            this.gridRecibos.Name = "gridRecibos";
            this.gridRecibos.ReadOnly = true;
            this.gridRecibos.RowHeadersWidth = 51;
            this.gridRecibos.Size = new System.Drawing.Size(371, 556);
            this.gridRecibos.TabIndex = 0;
            // 
            // colRecibo
            // 
            this.colRecibo.HeaderText = "Recibo";
            this.colRecibo.MinimumWidth = 6;
            this.colRecibo.Name = "colRecibo";
            this.colRecibo.ReadOnly = true;
            // 
            // colReciboFecha
            // 
            this.colReciboFecha.HeaderText = "Fecha";
            this.colReciboFecha.MinimumWidth = 6;
            this.colReciboFecha.Name = "colReciboFecha";
            this.colReciboFecha.ReadOnly = true;
            // 
            // colReciboCliente
            // 
            this.colReciboCliente.HeaderText = "Cliente";
            this.colReciboCliente.MinimumWidth = 6;
            this.colReciboCliente.Name = "colReciboCliente";
            this.colReciboCliente.ReadOnly = true;
            // 
            // colReciboMonto
            // 
            this.colReciboMonto.HeaderText = "Monto";
            this.colReciboMonto.MinimumWidth = 6;
            this.colReciboMonto.Name = "colReciboMonto";
            this.colReciboMonto.ReadOnly = true;
            // 
            // Gpb_Recibo
            // 
            this.Gpb_Recibo.BackColor = System.Drawing.SystemColors.Control;
            this.Gpb_Recibo.Controls.Add(this.Lbl_NumeroRecibo);
            this.Gpb_Recibo.Controls.Add(this.Txt_NumeroRecibo);
            this.Gpb_Recibo.Controls.Add(this.Lbl_FechaRecibo);
            this.Gpb_Recibo.Controls.Add(this.Dtp_FechaRecibo);
            this.Gpb_Recibo.Controls.Add(this.Lbl_Obs);
            this.Gpb_Recibo.Controls.Add(this.Txt_Obs);
            this.Gpb_Recibo.Controls.Add(this.Btn_NuevoRecibo);
            this.Gpb_Recibo.Controls.Add(this.Btn_EditarRecibo);
            this.Gpb_Recibo.Controls.Add(this.Btn_AnularRecibo);
            this.Gpb_Recibo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gpb_Recibo.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Gpb_Recibo.Location = new System.Drawing.Point(0, 0);
            this.Gpb_Recibo.Name = "Gpb_Recibo";
            this.Gpb_Recibo.Size = new System.Drawing.Size(371, 140);
            this.Gpb_Recibo.TabIndex = 1;
            this.Gpb_Recibo.TabStop = false;
            this.Gpb_Recibo.Text = "Recibo de pago";
            // 
            // Lbl_NumeroRecibo
            // 
            this.Lbl_NumeroRecibo.AutoSize = true;
            this.Lbl_NumeroRecibo.Location = new System.Drawing.Point(10, 28);
            this.Lbl_NumeroRecibo.Name = "Lbl_NumeroRecibo";
            this.Lbl_NumeroRecibo.Size = new System.Drawing.Size(75, 16);
            this.Lbl_NumeroRecibo.TabIndex = 0;
            this.Lbl_NumeroRecibo.Text = "No. Recibo:";
            // 
            // Txt_NumeroRecibo
            // 
            this.Txt_NumeroRecibo.Location = new System.Drawing.Point(135, 26);
            this.Txt_NumeroRecibo.Name = "Txt_NumeroRecibo";
            this.Txt_NumeroRecibo.Size = new System.Drawing.Size(236, 23);
            this.Txt_NumeroRecibo.TabIndex = 1;
            // 
            // Lbl_FechaRecibo
            // 
            this.Lbl_FechaRecibo.AutoSize = true;
            this.Lbl_FechaRecibo.Location = new System.Drawing.Point(10, 60);
            this.Lbl_FechaRecibo.Name = "Lbl_FechaRecibo";
            this.Lbl_FechaRecibo.Size = new System.Drawing.Size(47, 16);
            this.Lbl_FechaRecibo.TabIndex = 2;
            this.Lbl_FechaRecibo.Text = "Fecha:";
            // 
            // Dtp_FechaRecibo
            // 
            this.Dtp_FechaRecibo.Location = new System.Drawing.Point(135, 56);
            this.Dtp_FechaRecibo.Name = "Dtp_FechaRecibo";
            this.Dtp_FechaRecibo.Size = new System.Drawing.Size(236, 23);
            this.Dtp_FechaRecibo.TabIndex = 3;
            // 
            // Lbl_Obs
            // 
            this.Lbl_Obs.AutoSize = true;
            this.Lbl_Obs.Location = new System.Drawing.Point(-4, 91);
            this.Lbl_Obs.Name = "Lbl_Obs";
            this.Lbl_Obs.Size = new System.Drawing.Size(99, 16);
            this.Lbl_Obs.TabIndex = 4;
            this.Lbl_Obs.Text = "Observaciones:";
            // 
            // Txt_Obs
            // 
            this.Txt_Obs.Location = new System.Drawing.Point(135, 89);
            this.Txt_Obs.Multiline = true;
            this.Txt_Obs.Name = "Txt_Obs";
            this.Txt_Obs.Size = new System.Drawing.Size(236, 45);
            this.Txt_Obs.TabIndex = 5;
            // 
            // Btn_NuevoRecibo
            // 
            this.Btn_NuevoRecibo.Enabled = false;
            this.Btn_NuevoRecibo.Location = new System.Drawing.Point(400, 24);
            this.Btn_NuevoRecibo.Name = "Btn_NuevoRecibo";
            this.Btn_NuevoRecibo.Size = new System.Drawing.Size(75, 25);
            this.Btn_NuevoRecibo.TabIndex = 6;
            this.Btn_NuevoRecibo.Text = "Nuevo";
            // 
            // Btn_EditarRecibo
            // 
            this.Btn_EditarRecibo.Enabled = false;
            this.Btn_EditarRecibo.Location = new System.Drawing.Point(480, 24);
            this.Btn_EditarRecibo.Name = "Btn_EditarRecibo";
            this.Btn_EditarRecibo.Size = new System.Drawing.Size(75, 25);
            this.Btn_EditarRecibo.TabIndex = 7;
            this.Btn_EditarRecibo.Text = "Editar";
            // 
            // Btn_AnularRecibo
            // 
            this.Btn_AnularRecibo.Enabled = false;
            this.Btn_AnularRecibo.Location = new System.Drawing.Point(560, 24);
            this.Btn_AnularRecibo.Name = "Btn_AnularRecibo";
            this.Btn_AnularRecibo.Size = new System.Drawing.Size(75, 25);
            this.Btn_AnularRecibo.TabIndex = 8;
            this.Btn_AnularRecibo.Text = "Anular";
            // 
            // Frm_Recibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1924, 720);
            this.Controls.Add(this.splitRecibos);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Rockwell", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Frm_Recibos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas por Cobrar — Recibos (Prototipo)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.splitRecibos.Panel1.ResumeLayout(false);
            this.splitRecibos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRecibos)).EndInit();
            this.splitRecibos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Facturas)).EndInit();
            this.Gpb_Buscar.ResumeLayout(false);
            this.Gpb_Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecibos)).EndInit();
            this.Gpb_Recibo.ResumeLayout(false);
            this.Gpb_Recibo.PerformLayout();
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

        private System.Windows.Forms.SplitContainer splitRecibos;
        private System.Windows.Forms.GroupBox Gpb_Buscar;
        private System.Windows.Forms.Label Lbl_BuscarCliente;
        private System.Windows.Forms.TextBox Txt_BuscarCliente;
        private System.Windows.Forms.Label Lbl_Desde;
        private System.Windows.Forms.DateTimePicker Dtp_Desde;
        private System.Windows.Forms.Label Lbl_Hasta;
        private System.Windows.Forms.DateTimePicker Dtp_Hasta;
        private System.Windows.Forms.Button Btn_Filtrar;
        private System.Windows.Forms.Button Btn_Limpiar;

        private System.Windows.Forms.DataGridView Dgv_Facturas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldo;

        private System.Windows.Forms.DataGridView gridRecibos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReciboFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReciboCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReciboMonto;
        private System.Windows.Forms.GroupBox Gpb_Recibo;
        private System.Windows.Forms.Label Lbl_NumeroRecibo;
        private System.Windows.Forms.TextBox Txt_NumeroRecibo;
        private System.Windows.Forms.Label Lbl_FechaRecibo;
        private System.Windows.Forms.DateTimePicker Dtp_FechaRecibo;
        private System.Windows.Forms.Label Lbl_Obs;
        private System.Windows.Forms.TextBox Txt_Obs;
        private System.Windows.Forms.Button Btn_NuevoRecibo;
        private System.Windows.Forms.Button Btn_EditarRecibo;
        private System.Windows.Forms.Button Btn_AnularRecibo;
    }
}
