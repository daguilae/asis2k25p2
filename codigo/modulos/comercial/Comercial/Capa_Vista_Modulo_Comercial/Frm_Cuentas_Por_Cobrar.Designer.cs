
namespace Capa_Vista_Modulo_Comercial
{
    partial class Frm_Cuentas_Por_Cobrar
    {
        /// <summary> Limpieza de recursos. </summary>
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabRecibos = new System.Windows.Forms.TabPage();
            this.splitRecibos = new System.Windows.Forms.SplitContainer();
            this.gridFacturas = new System.Windows.Forms.DataGridView();
            this.colSel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gridRecibos = new System.Windows.Forms.DataGridView();
            this.colRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReciboFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReciboCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReciboMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpRecibo = new System.Windows.Forms.GroupBox();
            this.lblNumeroRecibo = new System.Windows.Forms.Label();
            this.txtNumeroRecibo = new System.Windows.Forms.TextBox();
            this.lblFechaRecibo = new System.Windows.Forms.Label();
            this.dtpFechaRecibo = new System.Windows.Forms.DateTimePicker();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.btnNuevoRecibo = new System.Windows.Forms.Button();
            this.btnEditarRecibo = new System.Windows.Forms.Button();
            this.btnAnularRecibo = new System.Windows.Forms.Button();
            this.tabPago = new System.Windows.Forms.TabPage();
            this.gridLineasPago = new System.Windows.Forms.DataGridView();
            this.colLPFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLPCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLPSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLPMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLPMetodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLPRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPago = new System.Windows.Forms.GroupBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.cmbMetodo = new System.Windows.Forms.ComboBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarLineaPago = new System.Windows.Forms.Button();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.txtTotalPago = new System.Windows.Forms.TextBox();
            this.btnGuardarPago = new System.Windows.Forms.Button();
            this.btnCancelarPago = new System.Windows.Forms.Button();
            this.tabAntiguedad = new System.Windows.Forms.TabPage();
            this.gridAntiguedad = new System.Windows.Forms.DataGridView();
            this.colACliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colA030 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colA3160 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colA6190 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colA90 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colATotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAntiguedadFiltros = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnGenerarAntig = new System.Windows.Forms.Button();
            this.tabReportes = new System.Windows.Forms.TabPage();
            this.viewerReporte = new System.Windows.Forms.Panel();
            this.grpReportes = new System.Windows.Forms.GroupBox();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.cmbTipoReporte = new System.Windows.Forms.ComboBox();
            this.lblRepDesde = new System.Windows.Forms.Label();
            this.dtpRepDesde = new System.Windows.Forms.DateTimePicker();
            this.lblRepHasta = new System.Windows.Forms.Label();
            this.dtpRepHasta = new System.Windows.Forms.DateTimePicker();
            this.btnVerReporte = new System.Windows.Forms.Button();
            this.tabCierre = new System.Windows.Forms.TabPage();
            this.grpCierre = new System.Windows.Forms.GroupBox();
            this.lblFechaCierre = new System.Windows.Forms.Label();
            this.dtpFechaCierre = new System.Windows.Forms.DateTimePicker();
            this.lblTotalCobrado = new System.Windows.Forms.Label();
            this.txtTotalCobrado = new System.Windows.Forms.TextBox();
            this.btnPrevisualizarCierre = new System.Windows.Forms.Button();
            this.btnCerrarCaja = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabRecibos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRecibos)).BeginInit();
            this.splitRecibos.Panel1.SuspendLayout();
            this.splitRecibos.Panel2.SuspendLayout();
            this.splitRecibos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).BeginInit();
            this.grpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecibos)).BeginInit();
            this.grpRecibo.SuspendLayout();
            this.tabPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLineasPago)).BeginInit();
            this.grpPago.SuspendLayout();
            this.tabAntiguedad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAntiguedad)).BeginInit();
            this.grpAntiguedadFiltros.SuspendLayout();
            this.tabReportes.SuspendLayout();
            this.grpReportes.SuspendLayout();
            this.tabCierre.SuspendLayout();
            this.grpCierre.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabRecibos);
            this.tabMain.Controls.Add(this.tabPago);
            this.tabMain.Controls.Add(this.tabAntiguedad);
            this.tabMain.Controls.Add(this.tabReportes);
            this.tabMain.Controls.Add(this.tabCierre);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1375, 760);
            this.tabMain.TabIndex = 0;
            // 
            // tabRecibos
            // 
            this.tabRecibos.Controls.Add(this.splitRecibos);
            this.tabRecibos.Location = new System.Drawing.Point(4, 29);
            this.tabRecibos.Name = "tabRecibos";
            this.tabRecibos.Padding = new System.Windows.Forms.Padding(8);
            this.tabRecibos.Size = new System.Drawing.Size(1367, 727);
            this.tabRecibos.TabIndex = 0;
            this.tabRecibos.Text = "Recibos";
            // 
            // splitRecibos
            // 
            this.splitRecibos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRecibos.Location = new System.Drawing.Point(8, 8);
            this.splitRecibos.Name = "splitRecibos";
            // 
            // splitRecibos.Panel1
            // 
            this.splitRecibos.Panel1.Controls.Add(this.gridFacturas);
            this.splitRecibos.Panel1.Controls.Add(this.grpBuscar);
            // 
            // splitRecibos.Panel2
            // 
            this.splitRecibos.Panel2.Controls.Add(this.gridRecibos);
            this.splitRecibos.Panel2.Controls.Add(this.grpRecibo);
            this.splitRecibos.Size = new System.Drawing.Size(1351, 711);
            this.splitRecibos.SplitterDistance = 1089;
            this.splitRecibos.TabIndex = 0;
            // 
            // gridFacturas
            // 
            this.gridFacturas.AllowUserToAddRows = false;
            this.gridFacturas.AllowUserToDeleteRows = false;
            this.gridFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFacturas.ColumnHeadersHeight = 29;
            this.gridFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSel,
            this.colFactura,
            this.colFecha,
            this.colCliente,
            this.colTotal,
            this.colSaldo});
            this.gridFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFacturas.Location = new System.Drawing.Point(0, 100);
            this.gridFacturas.Name = "gridFacturas";
            this.gridFacturas.ReadOnly = true;
            this.gridFacturas.RowHeadersWidth = 51;
            this.gridFacturas.Size = new System.Drawing.Size(1089, 611);
            this.gridFacturas.TabIndex = 0;
            // 
            // colSel
            // 
            this.colSel.HeaderText = "";
            this.colSel.MinimumWidth = 6;
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
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.lblBuscarCliente);
            this.grpBuscar.Controls.Add(this.txtBuscarCliente);
            this.grpBuscar.Controls.Add(this.lblDesde);
            this.grpBuscar.Controls.Add(this.dtpDesde);
            this.grpBuscar.Controls.Add(this.lblHasta);
            this.grpBuscar.Controls.Add(this.dtpHasta);
            this.grpBuscar.Controls.Add(this.btnFiltrar);
            this.grpBuscar.Controls.Add(this.btnLimpiar);
            this.grpBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBuscar.Location = new System.Drawing.Point(0, 0);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(1089, 100);
            this.grpBuscar.TabIndex = 1;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Filtro de facturas pendientes";
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.Location = new System.Drawing.Point(16, 28);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(58, 20);
            this.lblBuscarCliente.TabIndex = 0;
            this.lblBuscarCliente.Text = "Cliente:";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(70, 24);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(220, 27);
            this.txtBuscarCliente.TabIndex = 1;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(310, 28);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(54, 20);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(360, 24);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(180, 27);
            this.dtpDesde.TabIndex = 3;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(560, 28);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(50, 20);
            this.lblHasta.TabIndex = 4;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(610, 24);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(180, 27);
            this.dtpHasta.TabIndex = 5;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Enabled = false;
            this.btnFiltrar.Location = new System.Drawing.Point(810, 23);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 28);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(890, 23);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 28);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
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
            this.gridRecibos.Location = new System.Drawing.Point(0, 130);
            this.gridRecibos.Name = "gridRecibos";
            this.gridRecibos.ReadOnly = true;
            this.gridRecibos.RowHeadersWidth = 51;
            this.gridRecibos.Size = new System.Drawing.Size(258, 581);
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
            // grpRecibo
            // 
            this.grpRecibo.Controls.Add(this.lblNumeroRecibo);
            this.grpRecibo.Controls.Add(this.txtNumeroRecibo);
            this.grpRecibo.Controls.Add(this.lblFechaRecibo);
            this.grpRecibo.Controls.Add(this.dtpFechaRecibo);
            this.grpRecibo.Controls.Add(this.lblObs);
            this.grpRecibo.Controls.Add(this.txtObs);
            this.grpRecibo.Controls.Add(this.btnNuevoRecibo);
            this.grpRecibo.Controls.Add(this.btnEditarRecibo);
            this.grpRecibo.Controls.Add(this.btnAnularRecibo);
            this.grpRecibo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpRecibo.Location = new System.Drawing.Point(0, 0);
            this.grpRecibo.Name = "grpRecibo";
            this.grpRecibo.Size = new System.Drawing.Size(258, 130);
            this.grpRecibo.TabIndex = 1;
            this.grpRecibo.TabStop = false;
            this.grpRecibo.Text = "Recibo de pago";
            // 
            // lblNumeroRecibo
            // 
            this.lblNumeroRecibo.AutoSize = true;
            this.lblNumeroRecibo.Location = new System.Drawing.Point(6, 28);
            this.lblNumeroRecibo.Name = "lblNumeroRecibo";
            this.lblNumeroRecibo.Size = new System.Drawing.Size(85, 20);
            this.lblNumeroRecibo.TabIndex = 0;
            this.lblNumeroRecibo.Text = "No. Recibo:";
            // 
            // txtNumeroRecibo
            // 
            this.txtNumeroRecibo.Location = new System.Drawing.Point(100, 24);
            this.txtNumeroRecibo.Name = "txtNumeroRecibo";
            this.txtNumeroRecibo.Size = new System.Drawing.Size(150, 27);
            this.txtNumeroRecibo.TabIndex = 1;
            // 
            // lblFechaRecibo
            // 
            this.lblFechaRecibo.AutoSize = true;
            this.lblFechaRecibo.Location = new System.Drawing.Point(270, 28);
            this.lblFechaRecibo.Name = "lblFechaRecibo";
            this.lblFechaRecibo.Size = new System.Drawing.Size(50, 20);
            this.lblFechaRecibo.TabIndex = 2;
            this.lblFechaRecibo.Text = "Fecha:";
            // 
            // dtpFechaRecibo
            // 
            this.dtpFechaRecibo.Location = new System.Drawing.Point(320, 24);
            this.dtpFechaRecibo.Name = "dtpFechaRecibo";
            this.dtpFechaRecibo.Size = new System.Drawing.Size(180, 27);
            this.dtpFechaRecibo.TabIndex = 3;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(3, 65);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(108, 20);
            this.lblObs.TabIndex = 4;
            this.lblObs.Text = "Observaciones:";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(100, 65);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(450, 50);
            this.txtObs.TabIndex = 5;
            // 
            // btnNuevoRecibo
            // 
            this.btnNuevoRecibo.Enabled = false;
            this.btnNuevoRecibo.Location = new System.Drawing.Point(680, 22);
            this.btnNuevoRecibo.Name = "btnNuevoRecibo";
            this.btnNuevoRecibo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoRecibo.TabIndex = 6;
            this.btnNuevoRecibo.Text = "Nuevo";
            // 
            // btnEditarRecibo
            // 
            this.btnEditarRecibo.Enabled = false;
            this.btnEditarRecibo.Location = new System.Drawing.Point(760, 22);
            this.btnEditarRecibo.Name = "btnEditarRecibo";
            this.btnEditarRecibo.Size = new System.Drawing.Size(75, 23);
            this.btnEditarRecibo.TabIndex = 7;
            this.btnEditarRecibo.Text = "Editar";
            // 
            // btnAnularRecibo
            // 
            this.btnAnularRecibo.Enabled = false;
            this.btnAnularRecibo.Location = new System.Drawing.Point(840, 22);
            this.btnAnularRecibo.Name = "btnAnularRecibo";
            this.btnAnularRecibo.Size = new System.Drawing.Size(75, 23);
            this.btnAnularRecibo.TabIndex = 8;
            this.btnAnularRecibo.Text = "Anular";
            // 
            // tabPago
            // 
            this.tabPago.Controls.Add(this.gridLineasPago);
            this.tabPago.Controls.Add(this.grpPago);
            this.tabPago.Controls.Add(this.lblTotalPago);
            this.tabPago.Controls.Add(this.txtTotalPago);
            this.tabPago.Controls.Add(this.btnGuardarPago);
            this.tabPago.Controls.Add(this.btnCancelarPago);
            this.tabPago.Location = new System.Drawing.Point(4, 29);
            this.tabPago.Name = "tabPago";
            this.tabPago.Padding = new System.Windows.Forms.Padding(8);
            this.tabPago.Size = new System.Drawing.Size(192, 67);
            this.tabPago.TabIndex = 1;
            this.tabPago.Text = "Aplicar Pago";
            // 
            // gridLineasPago
            // 
            this.gridLineasPago.AllowUserToAddRows = false;
            this.gridLineasPago.AllowUserToDeleteRows = false;
            this.gridLineasPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLineasPago.ColumnHeadersHeight = 29;
            this.gridLineasPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLPFactura,
            this.colLPCliente,
            this.colLPSaldo,
            this.colLPMonto,
            this.colLPMetodo,
            this.colLPRef});
            this.gridLineasPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLineasPago.Location = new System.Drawing.Point(8, 148);
            this.gridLineasPago.Name = "gridLineasPago";
            this.gridLineasPago.ReadOnly = true;
            this.gridLineasPago.RowHeadersWidth = 51;
            this.gridLineasPago.Size = new System.Drawing.Size(176, 0);
            this.gridLineasPago.TabIndex = 0;
            // 
            // colLPFactura
            // 
            this.colLPFactura.HeaderText = "Factura";
            this.colLPFactura.MinimumWidth = 6;
            this.colLPFactura.Name = "colLPFactura";
            this.colLPFactura.ReadOnly = true;
            // 
            // colLPCliente
            // 
            this.colLPCliente.HeaderText = "Cliente";
            this.colLPCliente.MinimumWidth = 6;
            this.colLPCliente.Name = "colLPCliente";
            this.colLPCliente.ReadOnly = true;
            // 
            // colLPSaldo
            // 
            this.colLPSaldo.HeaderText = "Saldo";
            this.colLPSaldo.MinimumWidth = 6;
            this.colLPSaldo.Name = "colLPSaldo";
            this.colLPSaldo.ReadOnly = true;
            // 
            // colLPMonto
            // 
            this.colLPMonto.HeaderText = "Monto";
            this.colLPMonto.MinimumWidth = 6;
            this.colLPMonto.Name = "colLPMonto";
            this.colLPMonto.ReadOnly = true;
            // 
            // colLPMetodo
            // 
            this.colLPMetodo.HeaderText = "Método";
            this.colLPMetodo.MinimumWidth = 6;
            this.colLPMetodo.Name = "colLPMetodo";
            this.colLPMetodo.ReadOnly = true;
            // 
            // colLPRef
            // 
            this.colLPRef.HeaderText = "Referencia";
            this.colLPRef.MinimumWidth = 6;
            this.colLPRef.Name = "colLPRef";
            this.colLPRef.ReadOnly = true;
            // 
            // grpPago
            // 
            this.grpPago.Controls.Add(this.lblMetodo);
            this.grpPago.Controls.Add(this.cmbMetodo);
            this.grpPago.Controls.Add(this.lblMonto);
            this.grpPago.Controls.Add(this.txtMonto);
            this.grpPago.Controls.Add(this.lblReferencia);
            this.grpPago.Controls.Add(this.txtReferencia);
            this.grpPago.Controls.Add(this.lblFechaPago);
            this.grpPago.Controls.Add(this.dtpFechaPago);
            this.grpPago.Controls.Add(this.btnAgregarLineaPago);
            this.grpPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPago.Location = new System.Drawing.Point(8, 8);
            this.grpPago.Name = "grpPago";
            this.grpPago.Size = new System.Drawing.Size(176, 140);
            this.grpPago.TabIndex = 1;
            this.grpPago.TabStop = false;
            this.grpPago.Text = "Detalle de pago";
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(16, 32);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(65, 20);
            this.lblMetodo.TabIndex = 0;
            this.lblMetodo.Text = "Método:";
            // 
            // cmbMetodo
            // 
            this.cmbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodo.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Transferencia",
            "Criptomoneda"});
            this.cmbMetodo.Location = new System.Drawing.Point(76, 28);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.Size = new System.Drawing.Size(180, 28);
            this.cmbMetodo.TabIndex = 1;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(280, 32);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(56, 20);
            this.lblMonto.TabIndex = 2;
            this.lblMonto.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(332, 28);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(120, 27);
            this.txtMonto.TabIndex = 3;
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Location = new System.Drawing.Point(470, 32);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(82, 20);
            this.lblReferencia.TabIndex = 4;
            this.lblReferencia.Text = "Referencia:";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(540, 28);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(220, 27);
            this.txtReferencia.TabIndex = 5;
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(780, 32);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(50, 20);
            this.lblFechaPago.TabIndex = 6;
            this.lblFechaPago.Text = "Fecha:";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(830, 28);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(180, 27);
            this.dtpFechaPago.TabIndex = 7;
            // 
            // btnAgregarLineaPago
            // 
            this.btnAgregarLineaPago.Enabled = false;
            this.btnAgregarLineaPago.Location = new System.Drawing.Point(1030, 27);
            this.btnAgregarLineaPago.Name = "btnAgregarLineaPago";
            this.btnAgregarLineaPago.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarLineaPago.TabIndex = 8;
            this.btnAgregarLineaPago.Text = "Agregar a líneas";
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPago.Location = new System.Drawing.Point(852, 497);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(100, 23);
            this.lblTotalPago.TabIndex = 2;
            this.lblTotalPago.Text = "Total del pago:";
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPago.Location = new System.Drawing.Point(952, 493);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.ReadOnly = true;
            this.txtTotalPago.Size = new System.Drawing.Size(120, 27);
            this.txtTotalPago.TabIndex = 3;
            // 
            // btnGuardarPago
            // 
            this.btnGuardarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarPago.Enabled = false;
            this.btnGuardarPago.Location = new System.Drawing.Point(1082, 491);
            this.btnGuardarPago.Name = "btnGuardarPago";
            this.btnGuardarPago.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarPago.TabIndex = 4;
            this.btnGuardarPago.Text = "Guardar";
            // 
            // btnCancelarPago
            // 
            this.btnCancelarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarPago.Enabled = false;
            this.btnCancelarPago.Location = new System.Drawing.Point(992, 491);
            this.btnCancelarPago.Name = "btnCancelarPago";
            this.btnCancelarPago.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarPago.TabIndex = 5;
            this.btnCancelarPago.Text = "Cancelar";
            // 
            // tabAntiguedad
            // 
            this.tabAntiguedad.Controls.Add(this.gridAntiguedad);
            this.tabAntiguedad.Controls.Add(this.grpAntiguedadFiltros);
            this.tabAntiguedad.Location = new System.Drawing.Point(4, 29);
            this.tabAntiguedad.Name = "tabAntiguedad";
            this.tabAntiguedad.Padding = new System.Windows.Forms.Padding(8);
            this.tabAntiguedad.Size = new System.Drawing.Size(192, 67);
            this.tabAntiguedad.TabIndex = 2;
            this.tabAntiguedad.Text = "Antigüedad";
            // 
            // gridAntiguedad
            // 
            this.gridAntiguedad.AllowUserToAddRows = false;
            this.gridAntiguedad.AllowUserToDeleteRows = false;
            this.gridAntiguedad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAntiguedad.ColumnHeadersHeight = 29;
            this.gridAntiguedad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colACliente,
            this.colA030,
            this.colA3160,
            this.colA6190,
            this.colA90,
            this.colATotal});
            this.gridAntiguedad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAntiguedad.Location = new System.Drawing.Point(8, 88);
            this.gridAntiguedad.Name = "gridAntiguedad";
            this.gridAntiguedad.ReadOnly = true;
            this.gridAntiguedad.RowHeadersWidth = 51;
            this.gridAntiguedad.Size = new System.Drawing.Size(176, 0);
            this.gridAntiguedad.TabIndex = 0;
            // 
            // colACliente
            // 
            this.colACliente.HeaderText = "Cliente";
            this.colACliente.MinimumWidth = 6;
            this.colACliente.Name = "colACliente";
            this.colACliente.ReadOnly = true;
            // 
            // colA030
            // 
            this.colA030.HeaderText = "0–30";
            this.colA030.MinimumWidth = 6;
            this.colA030.Name = "colA030";
            this.colA030.ReadOnly = true;
            // 
            // colA3160
            // 
            this.colA3160.HeaderText = "31–60";
            this.colA3160.MinimumWidth = 6;
            this.colA3160.Name = "colA3160";
            this.colA3160.ReadOnly = true;
            // 
            // colA6190
            // 
            this.colA6190.HeaderText = "61–90";
            this.colA6190.MinimumWidth = 6;
            this.colA6190.Name = "colA6190";
            this.colA6190.ReadOnly = true;
            // 
            // colA90
            // 
            this.colA90.HeaderText = ">90";
            this.colA90.MinimumWidth = 6;
            this.colA90.Name = "colA90";
            this.colA90.ReadOnly = true;
            // 
            // colATotal
            // 
            this.colATotal.HeaderText = "Total";
            this.colATotal.MinimumWidth = 6;
            this.colATotal.Name = "colATotal";
            this.colATotal.ReadOnly = true;
            // 
            // grpAntiguedadFiltros
            // 
            this.grpAntiguedadFiltros.Controls.Add(this.lblCliente);
            this.grpAntiguedadFiltros.Controls.Add(this.cmbCliente);
            this.grpAntiguedadFiltros.Controls.Add(this.btnGenerarAntig);
            this.grpAntiguedadFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpAntiguedadFiltros.Location = new System.Drawing.Point(8, 8);
            this.grpAntiguedadFiltros.Name = "grpAntiguedadFiltros";
            this.grpAntiguedadFiltros.Size = new System.Drawing.Size(176, 80);
            this.grpAntiguedadFiltros.TabIndex = 1;
            this.grpAntiguedadFiltros.TabStop = false;
            this.grpAntiguedadFiltros.Text = "Filtros";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(16, 34);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Location = new System.Drawing.Point(70, 30);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(240, 28);
            this.cmbCliente.TabIndex = 1;
            // 
            // btnGenerarAntig
            // 
            this.btnGenerarAntig.Enabled = false;
            this.btnGenerarAntig.Location = new System.Drawing.Point(330, 29);
            this.btnGenerarAntig.Name = "btnGenerarAntig";
            this.btnGenerarAntig.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarAntig.TabIndex = 2;
            this.btnGenerarAntig.Text = "Generar";
            // 
            // tabReportes
            // 
            this.tabReportes.Controls.Add(this.viewerReporte);
            this.tabReportes.Controls.Add(this.grpReportes);
            this.tabReportes.Location = new System.Drawing.Point(4, 29);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.Padding = new System.Windows.Forms.Padding(8);
            this.tabReportes.Size = new System.Drawing.Size(192, 67);
            this.tabReportes.TabIndex = 3;
            this.tabReportes.Text = "Reportes";
            // 
            // viewerReporte
            // 
            this.viewerReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewerReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerReporte.Location = new System.Drawing.Point(8, 118);
            this.viewerReporte.Name = "viewerReporte";
            this.viewerReporte.Size = new System.Drawing.Size(176, 0);
            this.viewerReporte.TabIndex = 0;
            // 
            // grpReportes
            // 
            this.grpReportes.Controls.Add(this.lblTipoReporte);
            this.grpReportes.Controls.Add(this.cmbTipoReporte);
            this.grpReportes.Controls.Add(this.lblRepDesde);
            this.grpReportes.Controls.Add(this.dtpRepDesde);
            this.grpReportes.Controls.Add(this.lblRepHasta);
            this.grpReportes.Controls.Add(this.dtpRepHasta);
            this.grpReportes.Controls.Add(this.btnVerReporte);
            this.grpReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpReportes.Location = new System.Drawing.Point(8, 8);
            this.grpReportes.Name = "grpReportes";
            this.grpReportes.Size = new System.Drawing.Size(176, 110);
            this.grpReportes.TabIndex = 1;
            this.grpReportes.TabStop = false;
            this.grpReportes.Text = "Parámetros";
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.AutoSize = true;
            this.lblTipoReporte.Location = new System.Drawing.Point(16, 34);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(42, 20);
            this.lblTipoReporte.TabIndex = 0;
            this.lblTipoReporte.Text = "Tipo:";
            // 
            // cmbTipoReporte
            // 
            this.cmbTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoReporte.Items.AddRange(new object[] {
            "Cobros por fecha",
            "Recibos cancelados",
            "Antigüedad por cliente",
            "Caja diaria"});
            this.cmbTipoReporte.Location = new System.Drawing.Point(56, 30);
            this.cmbTipoReporte.Name = "cmbTipoReporte";
            this.cmbTipoReporte.Size = new System.Drawing.Size(260, 28);
            this.cmbTipoReporte.TabIndex = 1;
            // 
            // lblRepDesde
            // 
            this.lblRepDesde.AutoSize = true;
            this.lblRepDesde.Location = new System.Drawing.Point(340, 34);
            this.lblRepDesde.Name = "lblRepDesde";
            this.lblRepDesde.Size = new System.Drawing.Size(54, 20);
            this.lblRepDesde.TabIndex = 2;
            this.lblRepDesde.Text = "Desde:";
            // 
            // dtpRepDesde
            // 
            this.dtpRepDesde.Location = new System.Drawing.Point(390, 30);
            this.dtpRepDesde.Name = "dtpRepDesde";
            this.dtpRepDesde.Size = new System.Drawing.Size(180, 27);
            this.dtpRepDesde.TabIndex = 3;
            // 
            // lblRepHasta
            // 
            this.lblRepHasta.AutoSize = true;
            this.lblRepHasta.Location = new System.Drawing.Point(590, 34);
            this.lblRepHasta.Name = "lblRepHasta";
            this.lblRepHasta.Size = new System.Drawing.Size(50, 20);
            this.lblRepHasta.TabIndex = 4;
            this.lblRepHasta.Text = "Hasta:";
            // 
            // dtpRepHasta
            // 
            this.dtpRepHasta.Location = new System.Drawing.Point(640, 30);
            this.dtpRepHasta.Name = "dtpRepHasta";
            this.dtpRepHasta.Size = new System.Drawing.Size(180, 27);
            this.dtpRepHasta.TabIndex = 5;
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.Enabled = false;
            this.btnVerReporte.Location = new System.Drawing.Point(840, 29);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(75, 23);
            this.btnVerReporte.TabIndex = 6;
            this.btnVerReporte.Text = "Ver";
            // 
            // tabCierre
            // 
            this.tabCierre.Controls.Add(this.grpCierre);
            this.tabCierre.Location = new System.Drawing.Point(4, 29);
            this.tabCierre.Name = "tabCierre";
            this.tabCierre.Padding = new System.Windows.Forms.Padding(8);
            this.tabCierre.Size = new System.Drawing.Size(192, 67);
            this.tabCierre.TabIndex = 4;
            this.tabCierre.Text = "Cierre de Caja";
            // 
            // grpCierre
            // 
            this.grpCierre.Controls.Add(this.lblFechaCierre);
            this.grpCierre.Controls.Add(this.dtpFechaCierre);
            this.grpCierre.Controls.Add(this.lblTotalCobrado);
            this.grpCierre.Controls.Add(this.txtTotalCobrado);
            this.grpCierre.Controls.Add(this.btnPrevisualizarCierre);
            this.grpCierre.Controls.Add(this.btnCerrarCaja);
            this.grpCierre.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCierre.Location = new System.Drawing.Point(8, 8);
            this.grpCierre.Name = "grpCierre";
            this.grpCierre.Size = new System.Drawing.Size(176, 130);
            this.grpCierre.TabIndex = 0;
            this.grpCierre.TabStop = false;
            this.grpCierre.Text = "Cierre diario";
            // 
            // lblFechaCierre
            // 
            this.lblFechaCierre.AutoSize = true;
            this.lblFechaCierre.Location = new System.Drawing.Point(16, 34);
            this.lblFechaCierre.Name = "lblFechaCierre";
            this.lblFechaCierre.Size = new System.Drawing.Size(50, 20);
            this.lblFechaCierre.TabIndex = 0;
            this.lblFechaCierre.Text = "Fecha:";
            // 
            // dtpFechaCierre
            // 
            this.dtpFechaCierre.Location = new System.Drawing.Point(66, 30);
            this.dtpFechaCierre.Name = "dtpFechaCierre";
            this.dtpFechaCierre.Size = new System.Drawing.Size(200, 27);
            this.dtpFechaCierre.TabIndex = 1;
            // 
            // lblTotalCobrado
            // 
            this.lblTotalCobrado.AutoSize = true;
            this.lblTotalCobrado.Location = new System.Drawing.Point(290, 34);
            this.lblTotalCobrado.Name = "lblTotalCobrado";
            this.lblTotalCobrado.Size = new System.Drawing.Size(105, 20);
            this.lblTotalCobrado.TabIndex = 2;
            this.lblTotalCobrado.Text = "Total cobrado:";
            // 
            // txtTotalCobrado
            // 
            this.txtTotalCobrado.Location = new System.Drawing.Point(380, 30);
            this.txtTotalCobrado.Name = "txtTotalCobrado";
            this.txtTotalCobrado.ReadOnly = true;
            this.txtTotalCobrado.Size = new System.Drawing.Size(140, 27);
            this.txtTotalCobrado.TabIndex = 3;
            // 
            // btnPrevisualizarCierre
            // 
            this.btnPrevisualizarCierre.Enabled = false;
            this.btnPrevisualizarCierre.Location = new System.Drawing.Point(540, 29);
            this.btnPrevisualizarCierre.Name = "btnPrevisualizarCierre";
            this.btnPrevisualizarCierre.Size = new System.Drawing.Size(75, 23);
            this.btnPrevisualizarCierre.TabIndex = 4;
            this.btnPrevisualizarCierre.Text = "Previsualizar";
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.Enabled = false;
            this.btnCerrarCaja.Location = new System.Drawing.Point(640, 29);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarCaja.TabIndex = 5;
            this.btnCerrarCaja.Text = "Cerrar caja";
            // 
            // Frm_Cuentas_Por_Cobrar
            // 
            this.ClientSize = new System.Drawing.Size(1375, 760);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Frm_Cuentas_Por_Cobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas por Cobrar (Cobros y Antigüedad) — Prototipo UI";
            this.tabMain.ResumeLayout(false);
            this.tabRecibos.ResumeLayout(false);
            this.splitRecibos.Panel1.ResumeLayout(false);
            this.splitRecibos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRecibos)).EndInit();
            this.splitRecibos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).EndInit();
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecibos)).EndInit();
            this.grpRecibo.ResumeLayout(false);
            this.grpRecibo.PerformLayout();
            this.tabPago.ResumeLayout(false);
            this.tabPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLineasPago)).EndInit();
            this.grpPago.ResumeLayout(false);
            this.grpPago.PerformLayout();
            this.tabAntiguedad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAntiguedad)).EndInit();
            this.grpAntiguedadFiltros.ResumeLayout(false);
            this.grpAntiguedadFiltros.PerformLayout();
            this.tabReportes.ResumeLayout(false);
            this.grpReportes.ResumeLayout(false);
            this.grpReportes.PerformLayout();
            this.tabCierre.ResumeLayout(false);
            this.grpCierre.ResumeLayout(false);
            this.grpCierre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabRecibos;
        private System.Windows.Forms.TabPage tabPago;
        private System.Windows.Forms.TabPage tabAntiguedad;
        private System.Windows.Forms.TabPage tabReportes;
        private System.Windows.Forms.TabPage tabCierre;

        private System.Windows.Forms.SplitContainer splitRecibos;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label lblBuscarCliente;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView gridFacturas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldo;

        private System.Windows.Forms.GroupBox grpRecibo;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.DateTimePicker dtpFechaRecibo;
        private System.Windows.Forms.Label lblFechaRecibo;
        private System.Windows.Forms.TextBox txtNumeroRecibo;
        private System.Windows.Forms.Label lblNumeroRecibo;
        private System.Windows.Forms.Button btnNuevoRecibo;
        private System.Windows.Forms.Button btnEditarRecibo;
        private System.Windows.Forms.Button btnAnularRecibo;
        private System.Windows.Forms.DataGridView gridRecibos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReciboFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReciboCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReciboMonto;

        private System.Windows.Forms.GroupBox grpPago;
        private System.Windows.Forms.ComboBox cmbMetodo;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Button btnAgregarLineaPago;
        private System.Windows.Forms.DataGridView gridLineasPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLPFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLPCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLPSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLPMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLPMetodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLPRef;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.TextBox txtTotalPago;
        private System.Windows.Forms.Button btnGuardarPago;
        private System.Windows.Forms.Button btnCancelarPago;

        private System.Windows.Forms.GroupBox grpAntiguedadFiltros;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnGenerarAntig;
        private System.Windows.Forms.DataGridView gridAntiguedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colACliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colA030;
        private System.Windows.Forms.DataGridViewTextBoxColumn colA3160;
        private System.Windows.Forms.DataGridViewTextBoxColumn colA6190;
        private System.Windows.Forms.DataGridViewTextBoxColumn colA90;
        private System.Windows.Forms.DataGridViewTextBoxColumn colATotal;

        private System.Windows.Forms.GroupBox grpReportes;
        private System.Windows.Forms.DateTimePicker dtpRepDesde;
        private System.Windows.Forms.DateTimePicker dtpRepHasta;
        private System.Windows.Forms.Label lblRepDesde;
        private System.Windows.Forms.Label lblRepHasta;
        private System.Windows.Forms.ComboBox cmbTipoReporte;
        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.Button btnVerReporte;
        private System.Windows.Forms.Panel viewerReporte;

        private System.Windows.Forms.GroupBox grpCierre;
        private System.Windows.Forms.DateTimePicker dtpFechaCierre;
        private System.Windows.Forms.Label lblFechaCierre;
        private System.Windows.Forms.TextBox txtTotalCobrado;
        private System.Windows.Forms.Label lblTotalCobrado;
        private System.Windows.Forms.Button btnPrevisualizarCierre;
        private System.Windows.Forms.Button btnCerrarCaja;
    }
}