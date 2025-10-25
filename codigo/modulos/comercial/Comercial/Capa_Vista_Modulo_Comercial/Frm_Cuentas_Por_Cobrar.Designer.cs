
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
            this.Tbc_Main = new System.Windows.Forms.TabControl();
            this.tabRecibos = new System.Windows.Forms.TabPage();
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
            this.tabPago = new System.Windows.Forms.TabPage();
            this.gridLineasPago = new System.Windows.Forms.DataGridView();
            this.colLPFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLPCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLPSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLPMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLPMetodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLPRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Lbl_TotalPago = new System.Windows.Forms.Label();
            this.Txt_TotalPago = new System.Windows.Forms.TextBox();
            this.Btn_GuardarPago = new System.Windows.Forms.Button();
            this.Btn_CancelarPago = new System.Windows.Forms.Button();
            this.tabAntiguedad = new System.Windows.Forms.TabPage();
            this.gridAntiguedad = new System.Windows.Forms.DataGridView();
            this.colACliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colA030 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colA3160 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colA6190 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colA90 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colATotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gpb_AntiguedadFiltros = new System.Windows.Forms.GroupBox();
            this.Lbl_Cliente = new System.Windows.Forms.Label();
            this.Cbo_Cliente = new System.Windows.Forms.ComboBox();
            this.Btn_GenerarAntig = new System.Windows.Forms.Button();
            this.tabReportes = new System.Windows.Forms.TabPage();
            this.viewerReporte = new System.Windows.Forms.Panel();
            this.Gpb_Reportes = new System.Windows.Forms.GroupBox();
            this.Lbl_TipoReporte = new System.Windows.Forms.Label();
            this.Cbo_TipoReporte = new System.Windows.Forms.ComboBox();
            this.Lbl_RepDesde = new System.Windows.Forms.Label();
            this.Dtp_RepDesde = new System.Windows.Forms.DateTimePicker();
            this.Lbl_RepHasta = new System.Windows.Forms.Label();
            this.Dtp_RepHasta = new System.Windows.Forms.DateTimePicker();
            this.Btn_VerReporte = new System.Windows.Forms.Button();
            this.tabCierre = new System.Windows.Forms.TabPage();
            this.Gpb_Cierre = new System.Windows.Forms.GroupBox();
            this.Lbl_FechaCierre = new System.Windows.Forms.Label();
            this.Dtp_FechaCierre = new System.Windows.Forms.DateTimePicker();
            this.Lbl_TotalCobrado = new System.Windows.Forms.Label();
            this.Txt_TotalCobrado = new System.Windows.Forms.TextBox();
            this.Btn_PrevisualizarCierre = new System.Windows.Forms.Button();
            this.Btn_CerrarCaja = new System.Windows.Forms.Button();
            this.Tbc_Main.SuspendLayout();
            this.tabRecibos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRecibos)).BeginInit();
            this.splitRecibos.Panel1.SuspendLayout();
            this.splitRecibos.Panel2.SuspendLayout();
            this.splitRecibos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Facturas)).BeginInit();
            this.Gpb_Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecibos)).BeginInit();
            this.Gpb_Recibo.SuspendLayout();
            this.tabPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLineasPago)).BeginInit();
            this.Gpb_Pago.SuspendLayout();
            this.tabAntiguedad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAntiguedad)).BeginInit();
            this.Gpb_AntiguedadFiltros.SuspendLayout();
            this.tabReportes.SuspendLayout();
            this.Gpb_Reportes.SuspendLayout();
            this.tabCierre.SuspendLayout();
            this.Gpb_Cierre.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbc_Main
            // 
            this.Tbc_Main.Controls.Add(this.tabRecibos);
            this.Tbc_Main.Controls.Add(this.tabPago);
            this.Tbc_Main.Controls.Add(this.tabAntiguedad);
            this.Tbc_Main.Controls.Add(this.tabReportes);
            this.Tbc_Main.Controls.Add(this.tabCierre);
            this.Tbc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Main.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbc_Main.Location = new System.Drawing.Point(0, 0);
            this.Tbc_Main.Name = "Tbc_Main";
            this.Tbc_Main.SelectedIndex = 0;
            this.Tbc_Main.Size = new System.Drawing.Size(1375, 760);
            this.Tbc_Main.TabIndex = 0;
            // 
            // tabRecibos
            // 
            this.tabRecibos.Controls.Add(this.splitRecibos);
            this.tabRecibos.Location = new System.Drawing.Point(4, 25);
            this.tabRecibos.Name = "tabRecibos";
            this.tabRecibos.Padding = new System.Windows.Forms.Padding(8);
            this.tabRecibos.Size = new System.Drawing.Size(1367, 731);
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
            this.splitRecibos.Panel1.Controls.Add(this.Dgv_Facturas);
            this.splitRecibos.Panel1.Controls.Add(this.Gpb_Buscar);
            // 
            // splitRecibos.Panel2
            // 
            this.splitRecibos.Panel2.Controls.Add(this.gridRecibos);
            this.splitRecibos.Panel2.Controls.Add(this.Gpb_Recibo);
            this.splitRecibos.Size = new System.Drawing.Size(1351, 715);
            this.splitRecibos.SplitterDistance = 1089;
            this.splitRecibos.TabIndex = 0;
            // 
            // Dgv_Facturas
            // 
            this.Dgv_Facturas.AllowUserToAddRows = false;
            this.Dgv_Facturas.AllowUserToDeleteRows = false;
            this.Dgv_Facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Facturas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Dgv_Facturas.ColumnHeadersHeight = 29;
            this.Dgv_Facturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSel,
            this.colFactura,
            this.colFecha,
            this.colCliente,
            this.colTotal,
            this.colSaldo});
            this.Dgv_Facturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Facturas.Location = new System.Drawing.Point(0, 100);
            this.Dgv_Facturas.Name = "Dgv_Facturas";
            this.Dgv_Facturas.ReadOnly = true;
            this.Dgv_Facturas.RowHeadersWidth = 51;
            this.Dgv_Facturas.Size = new System.Drawing.Size(1089, 615);
            this.Dgv_Facturas.TabIndex = 0;
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
            // Gpb_Buscar
            // 
            this.Gpb_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Gpb_Buscar.Controls.Add(this.Lbl_BuscarCliente);
            this.Gpb_Buscar.Controls.Add(this.Txt_BuscarCliente);
            this.Gpb_Buscar.Controls.Add(this.Lbl_Desde);
            this.Gpb_Buscar.Controls.Add(this.Dtp_Desde);
            this.Gpb_Buscar.Controls.Add(this.Lbl_Hasta);
            this.Gpb_Buscar.Controls.Add(this.Dtp_Hasta);
            this.Gpb_Buscar.Controls.Add(this.Btn_Filtrar);
            this.Gpb_Buscar.Controls.Add(this.Btn_Limpiar);
            this.Gpb_Buscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gpb_Buscar.Location = new System.Drawing.Point(0, 0);
            this.Gpb_Buscar.Name = "Gpb_Buscar";
            this.Gpb_Buscar.Size = new System.Drawing.Size(1089, 100);
            this.Gpb_Buscar.TabIndex = 1;
            this.Gpb_Buscar.TabStop = false;
            this.Gpb_Buscar.Text = "Filtro de facturas pendientes";
            // 
            // Lbl_BuscarCliente
            // 
            this.Lbl_BuscarCliente.AutoSize = true;
            this.Lbl_BuscarCliente.Location = new System.Drawing.Point(16, 28);
            this.Lbl_BuscarCliente.Name = "Lbl_BuscarCliente";
            this.Lbl_BuscarCliente.Size = new System.Drawing.Size(53, 16);
            this.Lbl_BuscarCliente.TabIndex = 0;
            this.Lbl_BuscarCliente.Text = "Cliente:";
            // 
            // Txt_BuscarCliente
            // 
            this.Txt_BuscarCliente.Location = new System.Drawing.Point(84, 25);
            this.Txt_BuscarCliente.Name = "Txt_BuscarCliente";
            this.Txt_BuscarCliente.Size = new System.Drawing.Size(220, 23);
            this.Txt_BuscarCliente.TabIndex = 1;
            // 
            // Lbl_Desde
            // 
            this.Lbl_Desde.AutoSize = true;
            this.Lbl_Desde.Location = new System.Drawing.Point(310, 28);
            this.Lbl_Desde.Name = "Lbl_Desde";
            this.Lbl_Desde.Size = new System.Drawing.Size(49, 16);
            this.Lbl_Desde.TabIndex = 2;
            this.Lbl_Desde.Text = "Desde:";
            // 
            // Dtp_Desde
            // 
            this.Dtp_Desde.Location = new System.Drawing.Point(373, 24);
            this.Dtp_Desde.Name = "Dtp_Desde";
            this.Dtp_Desde.Size = new System.Drawing.Size(180, 23);
            this.Dtp_Desde.TabIndex = 3;
            // 
            // Lbl_Hasta
            // 
            this.Lbl_Hasta.AutoSize = true;
            this.Lbl_Hasta.Location = new System.Drawing.Point(570, 28);
            this.Lbl_Hasta.Name = "Lbl_Hasta";
            this.Lbl_Hasta.Size = new System.Drawing.Size(45, 16);
            this.Lbl_Hasta.TabIndex = 4;
            this.Lbl_Hasta.Text = "Hasta:";
            // 
            // Dtp_Hasta
            // 
            this.Dtp_Hasta.Location = new System.Drawing.Point(637, 22);
            this.Dtp_Hasta.Name = "Dtp_Hasta";
            this.Dtp_Hasta.Size = new System.Drawing.Size(180, 23);
            this.Dtp_Hasta.TabIndex = 5;
            // 
            // Btn_Filtrar
            // 
            this.Btn_Filtrar.Enabled = false;
            this.Btn_Filtrar.Location = new System.Drawing.Point(839, 24);
            this.Btn_Filtrar.Name = "Btn_Filtrar";
            this.Btn_Filtrar.Size = new System.Drawing.Size(75, 28);
            this.Btn_Filtrar.TabIndex = 6;
            this.Btn_Filtrar.Text = "Filtrar";
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Enabled = false;
            this.Btn_Limpiar.Location = new System.Drawing.Point(920, 24);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(75, 28);
            this.Btn_Limpiar.TabIndex = 7;
            this.Btn_Limpiar.Text = "Limpiar";
            // 
            // gridRecibos
            // 
            this.gridRecibos.AllowUserToAddRows = false;
            this.gridRecibos.AllowUserToDeleteRows = false;
            this.gridRecibos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRecibos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            this.gridRecibos.Size = new System.Drawing.Size(258, 585);
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
            this.Gpb_Recibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            this.Gpb_Recibo.Location = new System.Drawing.Point(0, 0);
            this.Gpb_Recibo.Name = "Gpb_Recibo";
            this.Gpb_Recibo.Size = new System.Drawing.Size(258, 130);
            this.Gpb_Recibo.TabIndex = 1;
            this.Gpb_Recibo.TabStop = false;
            this.Gpb_Recibo.Text = "Recibo de pago";
            // 
            // Lbl_NumeroRecibo
            // 
            this.Lbl_NumeroRecibo.AutoSize = true;
            this.Lbl_NumeroRecibo.Location = new System.Drawing.Point(6, 28);
            this.Lbl_NumeroRecibo.Name = "Lbl_NumeroRecibo";
            this.Lbl_NumeroRecibo.Size = new System.Drawing.Size(75, 16);
            this.Lbl_NumeroRecibo.TabIndex = 0;
            this.Lbl_NumeroRecibo.Text = "No. Recibo:";
            // 
            // Txt_NumeroRecibo
            // 
            this.Txt_NumeroRecibo.Location = new System.Drawing.Point(100, 24);
            this.Txt_NumeroRecibo.Name = "Txt_NumeroRecibo";
            this.Txt_NumeroRecibo.Size = new System.Drawing.Size(150, 23);
            this.Txt_NumeroRecibo.TabIndex = 1;
            // 
            // Lbl_FechaRecibo
            // 
            this.Lbl_FechaRecibo.AutoSize = true;
            this.Lbl_FechaRecibo.Location = new System.Drawing.Point(270, 28);
            this.Lbl_FechaRecibo.Name = "Lbl_FechaRecibo";
            this.Lbl_FechaRecibo.Size = new System.Drawing.Size(47, 16);
            this.Lbl_FechaRecibo.TabIndex = 2;
            this.Lbl_FechaRecibo.Text = "Fecha:";
            // 
            // Dtp_FechaRecibo
            // 
            this.Dtp_FechaRecibo.Location = new System.Drawing.Point(320, 24);
            this.Dtp_FechaRecibo.Name = "Dtp_FechaRecibo";
            this.Dtp_FechaRecibo.Size = new System.Drawing.Size(180, 23);
            this.Dtp_FechaRecibo.TabIndex = 3;
            // 
            // Lbl_Obs
            // 
            this.Lbl_Obs.AutoSize = true;
            this.Lbl_Obs.Location = new System.Drawing.Point(3, 65);
            this.Lbl_Obs.Name = "Lbl_Obs";
            this.Lbl_Obs.Size = new System.Drawing.Size(99, 16);
            this.Lbl_Obs.TabIndex = 4;
            this.Lbl_Obs.Text = "Observaciones:";
            // 
            // Txt_Obs
            // 
            this.Txt_Obs.Location = new System.Drawing.Point(100, 65);
            this.Txt_Obs.Multiline = true;
            this.Txt_Obs.Name = "Txt_Obs";
            this.Txt_Obs.Size = new System.Drawing.Size(450, 50);
            this.Txt_Obs.TabIndex = 5;
            // 
            // Btn_NuevoRecibo
            // 
            this.Btn_NuevoRecibo.Enabled = false;
            this.Btn_NuevoRecibo.Location = new System.Drawing.Point(680, 22);
            this.Btn_NuevoRecibo.Name = "Btn_NuevoRecibo";
            this.Btn_NuevoRecibo.Size = new System.Drawing.Size(75, 23);
            this.Btn_NuevoRecibo.TabIndex = 6;
            this.Btn_NuevoRecibo.Text = "Nuevo";
            // 
            // Btn_EditarRecibo
            // 
            this.Btn_EditarRecibo.Enabled = false;
            this.Btn_EditarRecibo.Location = new System.Drawing.Point(760, 22);
            this.Btn_EditarRecibo.Name = "Btn_EditarRecibo";
            this.Btn_EditarRecibo.Size = new System.Drawing.Size(75, 23);
            this.Btn_EditarRecibo.TabIndex = 7;
            this.Btn_EditarRecibo.Text = "Editar";
            // 
            // Btn_AnularRecibo
            // 
            this.Btn_AnularRecibo.Enabled = false;
            this.Btn_AnularRecibo.Location = new System.Drawing.Point(840, 22);
            this.Btn_AnularRecibo.Name = "Btn_AnularRecibo";
            this.Btn_AnularRecibo.Size = new System.Drawing.Size(75, 23);
            this.Btn_AnularRecibo.TabIndex = 8;
            this.Btn_AnularRecibo.Text = "Anular";
            // 
            // tabPago
            // 
            this.tabPago.Controls.Add(this.gridLineasPago);
            this.tabPago.Controls.Add(this.Gpb_Pago);
            this.tabPago.Controls.Add(this.Lbl_TotalPago);
            this.tabPago.Controls.Add(this.Txt_TotalPago);
            this.tabPago.Controls.Add(this.Btn_GuardarPago);
            this.tabPago.Controls.Add(this.Btn_CancelarPago);
            this.tabPago.Location = new System.Drawing.Point(4, 25);
            this.tabPago.Name = "tabPago";
            this.tabPago.Padding = new System.Windows.Forms.Padding(8);
            this.tabPago.Size = new System.Drawing.Size(1367, 731);
            this.tabPago.TabIndex = 1;
            this.tabPago.Text = "Aplicar Pago";
            // 
            // gridLineasPago
            // 
            this.gridLineasPago.AllowUserToAddRows = false;
            this.gridLineasPago.AllowUserToDeleteRows = false;
            this.gridLineasPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLineasPago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            this.gridLineasPago.Size = new System.Drawing.Size(1351, 575);
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
            // Gpb_Pago
            // 
            this.Gpb_Pago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Gpb_Pago.Controls.Add(this.Lbl_Metodo);
            this.Gpb_Pago.Controls.Add(this.Cbo_Metodo);
            this.Gpb_Pago.Controls.Add(this.Lbl_Monto);
            this.Gpb_Pago.Controls.Add(this.Txt_Monto);
            this.Gpb_Pago.Controls.Add(this.Lbl_Referencia);
            this.Gpb_Pago.Controls.Add(this.Txt_Referencia);
            this.Gpb_Pago.Controls.Add(this.Lbl_FechaPago);
            this.Gpb_Pago.Controls.Add(this.Dtp_FechaPago);
            this.Gpb_Pago.Controls.Add(this.Btn_AgregarLineaPago);
            this.Gpb_Pago.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gpb_Pago.Location = new System.Drawing.Point(8, 8);
            this.Gpb_Pago.Name = "Gpb_Pago";
            this.Gpb_Pago.Size = new System.Drawing.Size(1351, 140);
            this.Gpb_Pago.TabIndex = 1;
            this.Gpb_Pago.TabStop = false;
            this.Gpb_Pago.Text = "Detalle de pago";
            // 
            // Lbl_Metodo
            // 
            this.Lbl_Metodo.AutoSize = true;
            this.Lbl_Metodo.Location = new System.Drawing.Point(16, 32);
            this.Lbl_Metodo.Name = "Lbl_Metodo";
            this.Lbl_Metodo.Size = new System.Drawing.Size(56, 16);
            this.Lbl_Metodo.TabIndex = 0;
            this.Lbl_Metodo.Text = "Método:";
            // 
            // Cbo_Metodo
            // 
            this.Cbo_Metodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Metodo.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Transferencia",
            "Criptomoneda"});
            this.Cbo_Metodo.Location = new System.Drawing.Point(88, 28);
            this.Cbo_Metodo.Name = "Cbo_Metodo";
            this.Cbo_Metodo.Size = new System.Drawing.Size(180, 24);
            this.Cbo_Metodo.TabIndex = 1;
            // 
            // Lbl_Monto
            // 
            this.Lbl_Monto.AutoSize = true;
            this.Lbl_Monto.Location = new System.Drawing.Point(280, 32);
            this.Lbl_Monto.Name = "Lbl_Monto";
            this.Lbl_Monto.Size = new System.Drawing.Size(48, 16);
            this.Lbl_Monto.TabIndex = 2;
            this.Lbl_Monto.Text = "Monto:";
            // 
            // Txt_Monto
            // 
            this.Txt_Monto.Location = new System.Drawing.Point(343, 28);
            this.Txt_Monto.Name = "Txt_Monto";
            this.Txt_Monto.Size = new System.Drawing.Size(120, 23);
            this.Txt_Monto.TabIndex = 3;
            // 
            // Lbl_Referencia
            // 
            this.Lbl_Referencia.AutoSize = true;
            this.Lbl_Referencia.Location = new System.Drawing.Point(470, 32);
            this.Lbl_Referencia.Name = "Lbl_Referencia";
            this.Lbl_Referencia.Size = new System.Drawing.Size(74, 16);
            this.Lbl_Referencia.TabIndex = 4;
            this.Lbl_Referencia.Text = "Referencia:";
            // 
            // Txt_Referencia
            // 
            this.Txt_Referencia.Location = new System.Drawing.Point(554, 28);
            this.Txt_Referencia.Name = "Txt_Referencia";
            this.Txt_Referencia.Size = new System.Drawing.Size(220, 23);
            this.Txt_Referencia.TabIndex = 5;
            // 
            // Lbl_FechaPago
            // 
            this.Lbl_FechaPago.AutoSize = true;
            this.Lbl_FechaPago.Location = new System.Drawing.Point(780, 32);
            this.Lbl_FechaPago.Name = "Lbl_FechaPago";
            this.Lbl_FechaPago.Size = new System.Drawing.Size(47, 16);
            this.Lbl_FechaPago.TabIndex = 6;
            this.Lbl_FechaPago.Text = "Fecha:";
            // 
            // Dtp_FechaPago
            // 
            this.Dtp_FechaPago.Location = new System.Drawing.Point(840, 28);
            this.Dtp_FechaPago.Name = "Dtp_FechaPago";
            this.Dtp_FechaPago.Size = new System.Drawing.Size(180, 23);
            this.Dtp_FechaPago.TabIndex = 7;
            // 
            // Btn_AgregarLineaPago
            // 
            this.Btn_AgregarLineaPago.Enabled = false;
            this.Btn_AgregarLineaPago.Location = new System.Drawing.Point(1030, 27);
            this.Btn_AgregarLineaPago.Name = "Btn_AgregarLineaPago";
            this.Btn_AgregarLineaPago.Size = new System.Drawing.Size(75, 23);
            this.Btn_AgregarLineaPago.TabIndex = 8;
            this.Btn_AgregarLineaPago.Text = "Agregar a líneas";
            // 
            // Lbl_TotalPago
            // 
            this.Lbl_TotalPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_TotalPago.Location = new System.Drawing.Point(852, 493);
            this.Lbl_TotalPago.Name = "Lbl_TotalPago";
            this.Lbl_TotalPago.Size = new System.Drawing.Size(100, 23);
            this.Lbl_TotalPago.TabIndex = 2;
            this.Lbl_TotalPago.Text = "Total del pago:";
            // 
            // Txt_TotalPago
            // 
            this.Txt_TotalPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_TotalPago.Location = new System.Drawing.Point(952, 489);
            this.Txt_TotalPago.Name = "Txt_TotalPago";
            this.Txt_TotalPago.ReadOnly = true;
            this.Txt_TotalPago.Size = new System.Drawing.Size(120, 23);
            this.Txt_TotalPago.TabIndex = 3;
            // 
            // Btn_GuardarPago
            // 
            this.Btn_GuardarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_GuardarPago.Enabled = false;
            this.Btn_GuardarPago.Location = new System.Drawing.Point(1082, 487);
            this.Btn_GuardarPago.Name = "Btn_GuardarPago";
            this.Btn_GuardarPago.Size = new System.Drawing.Size(75, 23);
            this.Btn_GuardarPago.TabIndex = 4;
            this.Btn_GuardarPago.Text = "Guardar";
            // 
            // Btn_CancelarPago
            // 
            this.Btn_CancelarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_CancelarPago.Enabled = false;
            this.Btn_CancelarPago.Location = new System.Drawing.Point(992, 487);
            this.Btn_CancelarPago.Name = "Btn_CancelarPago";
            this.Btn_CancelarPago.Size = new System.Drawing.Size(75, 23);
            this.Btn_CancelarPago.TabIndex = 5;
            this.Btn_CancelarPago.Text = "Cancelar";
            // 
            // tabAntiguedad
            // 
            this.tabAntiguedad.Controls.Add(this.gridAntiguedad);
            this.tabAntiguedad.Controls.Add(this.Gpb_AntiguedadFiltros);
            this.tabAntiguedad.Location = new System.Drawing.Point(4, 25);
            this.tabAntiguedad.Name = "tabAntiguedad";
            this.tabAntiguedad.Padding = new System.Windows.Forms.Padding(8);
            this.tabAntiguedad.Size = new System.Drawing.Size(1367, 731);
            this.tabAntiguedad.TabIndex = 2;
            this.tabAntiguedad.Text = "Antigüedad";
            // 
            // gridAntiguedad
            // 
            this.gridAntiguedad.AllowUserToAddRows = false;
            this.gridAntiguedad.AllowUserToDeleteRows = false;
            this.gridAntiguedad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAntiguedad.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            this.gridAntiguedad.Size = new System.Drawing.Size(1351, 635);
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
            // Gpb_AntiguedadFiltros
            // 
            this.Gpb_AntiguedadFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Gpb_AntiguedadFiltros.Controls.Add(this.Lbl_Cliente);
            this.Gpb_AntiguedadFiltros.Controls.Add(this.Cbo_Cliente);
            this.Gpb_AntiguedadFiltros.Controls.Add(this.Btn_GenerarAntig);
            this.Gpb_AntiguedadFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gpb_AntiguedadFiltros.Location = new System.Drawing.Point(8, 8);
            this.Gpb_AntiguedadFiltros.Name = "Gpb_AntiguedadFiltros";
            this.Gpb_AntiguedadFiltros.Size = new System.Drawing.Size(1351, 80);
            this.Gpb_AntiguedadFiltros.TabIndex = 1;
            this.Gpb_AntiguedadFiltros.TabStop = false;
            this.Gpb_AntiguedadFiltros.Text = "Filtros";
            // 
            // Lbl_Cliente
            // 
            this.Lbl_Cliente.AutoSize = true;
            this.Lbl_Cliente.Location = new System.Drawing.Point(16, 34);
            this.Lbl_Cliente.Name = "Lbl_Cliente";
            this.Lbl_Cliente.Size = new System.Drawing.Size(53, 16);
            this.Lbl_Cliente.TabIndex = 0;
            this.Lbl_Cliente.Text = "Cliente:";
            // 
            // Cbo_Cliente
            // 
            this.Cbo_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Cliente.Location = new System.Drawing.Point(87, 30);
            this.Cbo_Cliente.Name = "Cbo_Cliente";
            this.Cbo_Cliente.Size = new System.Drawing.Size(240, 24);
            this.Cbo_Cliente.TabIndex = 1;
            // 
            // Btn_GenerarAntig
            // 
            this.Btn_GenerarAntig.Enabled = false;
            this.Btn_GenerarAntig.Location = new System.Drawing.Point(342, 30);
            this.Btn_GenerarAntig.Name = "Btn_GenerarAntig";
            this.Btn_GenerarAntig.Size = new System.Drawing.Size(75, 23);
            this.Btn_GenerarAntig.TabIndex = 2;
            this.Btn_GenerarAntig.Text = "Generar";
            // 
            // tabReportes
            // 
            this.tabReportes.Controls.Add(this.viewerReporte);
            this.tabReportes.Controls.Add(this.Gpb_Reportes);
            this.tabReportes.Location = new System.Drawing.Point(4, 25);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.Padding = new System.Windows.Forms.Padding(8);
            this.tabReportes.Size = new System.Drawing.Size(1367, 731);
            this.tabReportes.TabIndex = 3;
            this.tabReportes.Text = "Reportes";
            // 
            // viewerReporte
            // 
            this.viewerReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.viewerReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewerReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerReporte.Location = new System.Drawing.Point(8, 118);
            this.viewerReporte.Name = "viewerReporte";
            this.viewerReporte.Size = new System.Drawing.Size(1351, 605);
            this.viewerReporte.TabIndex = 0;
            // 
            // Gpb_Reportes
            // 
            this.Gpb_Reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Gpb_Reportes.Controls.Add(this.Lbl_TipoReporte);
            this.Gpb_Reportes.Controls.Add(this.Cbo_TipoReporte);
            this.Gpb_Reportes.Controls.Add(this.Lbl_RepDesde);
            this.Gpb_Reportes.Controls.Add(this.Dtp_RepDesde);
            this.Gpb_Reportes.Controls.Add(this.Lbl_RepHasta);
            this.Gpb_Reportes.Controls.Add(this.Dtp_RepHasta);
            this.Gpb_Reportes.Controls.Add(this.Btn_VerReporte);
            this.Gpb_Reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gpb_Reportes.Location = new System.Drawing.Point(8, 8);
            this.Gpb_Reportes.Name = "Gpb_Reportes";
            this.Gpb_Reportes.Size = new System.Drawing.Size(1351, 110);
            this.Gpb_Reportes.TabIndex = 1;
            this.Gpb_Reportes.TabStop = false;
            this.Gpb_Reportes.Text = "Parámetros";
            // 
            // Lbl_TipoReporte
            // 
            this.Lbl_TipoReporte.AutoSize = true;
            this.Lbl_TipoReporte.Location = new System.Drawing.Point(16, 34);
            this.Lbl_TipoReporte.Name = "Lbl_TipoReporte";
            this.Lbl_TipoReporte.Size = new System.Drawing.Size(37, 16);
            this.Lbl_TipoReporte.TabIndex = 0;
            this.Lbl_TipoReporte.Text = "Tipo:";
            // 
            // Cbo_TipoReporte
            // 
            this.Cbo_TipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_TipoReporte.Items.AddRange(new object[] {
            "Cobros por fecha",
            "Recibos cancelados",
            "Antigüedad por cliente",
            "Caja diaria"});
            this.Cbo_TipoReporte.Location = new System.Drawing.Point(66, 30);
            this.Cbo_TipoReporte.Name = "Cbo_TipoReporte";
            this.Cbo_TipoReporte.Size = new System.Drawing.Size(260, 24);
            this.Cbo_TipoReporte.TabIndex = 1;
            // 
            // Lbl_RepDesde
            // 
            this.Lbl_RepDesde.AutoSize = true;
            this.Lbl_RepDesde.Location = new System.Drawing.Point(340, 34);
            this.Lbl_RepDesde.Name = "Lbl_RepDesde";
            this.Lbl_RepDesde.Size = new System.Drawing.Size(49, 16);
            this.Lbl_RepDesde.TabIndex = 2;
            this.Lbl_RepDesde.Text = "Desde:";
            // 
            // Dtp_RepDesde
            // 
            this.Dtp_RepDesde.Location = new System.Drawing.Point(403, 30);
            this.Dtp_RepDesde.Name = "Dtp_RepDesde";
            this.Dtp_RepDesde.Size = new System.Drawing.Size(180, 23);
            this.Dtp_RepDesde.TabIndex = 3;
            // 
            // Lbl_RepHasta
            // 
            this.Lbl_RepHasta.AutoSize = true;
            this.Lbl_RepHasta.Location = new System.Drawing.Point(600, 34);
            this.Lbl_RepHasta.Name = "Lbl_RepHasta";
            this.Lbl_RepHasta.Size = new System.Drawing.Size(45, 16);
            this.Lbl_RepHasta.TabIndex = 4;
            this.Lbl_RepHasta.Text = "Hasta:";
            // 
            // Dtp_RepHasta
            // 
            this.Dtp_RepHasta.Location = new System.Drawing.Point(657, 28);
            this.Dtp_RepHasta.Name = "Dtp_RepHasta";
            this.Dtp_RepHasta.Size = new System.Drawing.Size(180, 23);
            this.Dtp_RepHasta.TabIndex = 5;
            // 
            // Btn_VerReporte
            // 
            this.Btn_VerReporte.Enabled = false;
            this.Btn_VerReporte.Location = new System.Drawing.Point(858, 31);
            this.Btn_VerReporte.Name = "Btn_VerReporte";
            this.Btn_VerReporte.Size = new System.Drawing.Size(75, 23);
            this.Btn_VerReporte.TabIndex = 6;
            this.Btn_VerReporte.Text = "Ver";
            // 
            // tabCierre
            // 
            this.tabCierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tabCierre.Controls.Add(this.Gpb_Cierre);
            this.tabCierre.Location = new System.Drawing.Point(4, 25);
            this.tabCierre.Name = "tabCierre";
            this.tabCierre.Padding = new System.Windows.Forms.Padding(8);
            this.tabCierre.Size = new System.Drawing.Size(1367, 731);
            this.tabCierre.TabIndex = 4;
            this.tabCierre.Text = "Cierre de Caja";
            // 
            // Gpb_Cierre
            // 
            this.Gpb_Cierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Gpb_Cierre.Controls.Add(this.Lbl_FechaCierre);
            this.Gpb_Cierre.Controls.Add(this.Dtp_FechaCierre);
            this.Gpb_Cierre.Controls.Add(this.Lbl_TotalCobrado);
            this.Gpb_Cierre.Controls.Add(this.Txt_TotalCobrado);
            this.Gpb_Cierre.Controls.Add(this.Btn_PrevisualizarCierre);
            this.Gpb_Cierre.Controls.Add(this.Btn_CerrarCaja);
            this.Gpb_Cierre.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gpb_Cierre.Location = new System.Drawing.Point(8, 8);
            this.Gpb_Cierre.Name = "Gpb_Cierre";
            this.Gpb_Cierre.Size = new System.Drawing.Size(1351, 130);
            this.Gpb_Cierre.TabIndex = 0;
            this.Gpb_Cierre.TabStop = false;
            this.Gpb_Cierre.Text = "Cierre diario";
            // 
            // Lbl_FechaCierre
            // 
            this.Lbl_FechaCierre.AutoSize = true;
            this.Lbl_FechaCierre.Location = new System.Drawing.Point(16, 34);
            this.Lbl_FechaCierre.Name = "Lbl_FechaCierre";
            this.Lbl_FechaCierre.Size = new System.Drawing.Size(47, 16);
            this.Lbl_FechaCierre.TabIndex = 0;
            this.Lbl_FechaCierre.Text = "Fecha:";
            // 
            // Dtp_FechaCierre
            // 
            this.Dtp_FechaCierre.Location = new System.Drawing.Point(66, 30);
            this.Dtp_FechaCierre.Name = "Dtp_FechaCierre";
            this.Dtp_FechaCierre.Size = new System.Drawing.Size(200, 23);
            this.Dtp_FechaCierre.TabIndex = 1;
            // 
            // Lbl_TotalCobrado
            // 
            this.Lbl_TotalCobrado.AutoSize = true;
            this.Lbl_TotalCobrado.Location = new System.Drawing.Point(290, 34);
            this.Lbl_TotalCobrado.Name = "Lbl_TotalCobrado";
            this.Lbl_TotalCobrado.Size = new System.Drawing.Size(92, 16);
            this.Lbl_TotalCobrado.TabIndex = 2;
            this.Lbl_TotalCobrado.Text = "Total cobrado:";
            // 
            // Txt_TotalCobrado
            // 
            this.Txt_TotalCobrado.Location = new System.Drawing.Point(407, 30);
            this.Txt_TotalCobrado.Name = "Txt_TotalCobrado";
            this.Txt_TotalCobrado.ReadOnly = true;
            this.Txt_TotalCobrado.Size = new System.Drawing.Size(140, 23);
            this.Txt_TotalCobrado.TabIndex = 3;
            // 
            // Btn_PrevisualizarCierre
            // 
            this.Btn_PrevisualizarCierre.Enabled = false;
            this.Btn_PrevisualizarCierre.Location = new System.Drawing.Point(559, 30);
            this.Btn_PrevisualizarCierre.Name = "Btn_PrevisualizarCierre";
            this.Btn_PrevisualizarCierre.Size = new System.Drawing.Size(114, 23);
            this.Btn_PrevisualizarCierre.TabIndex = 4;
            this.Btn_PrevisualizarCierre.Text = "Previsualizar";
            // 
            // Btn_CerrarCaja
            // 
            this.Btn_CerrarCaja.Enabled = false;
            this.Btn_CerrarCaja.Location = new System.Drawing.Point(679, 31);
            this.Btn_CerrarCaja.Name = "Btn_CerrarCaja";
            this.Btn_CerrarCaja.Size = new System.Drawing.Size(75, 23);
            this.Btn_CerrarCaja.TabIndex = 5;
            this.Btn_CerrarCaja.Text = "Cerrar caja";
            // 
            // Frm_Cuentas_Por_Cobrar
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1375, 760);
            this.Controls.Add(this.Tbc_Main);
            this.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Frm_Cuentas_Por_Cobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas por Cobrar (Cobros y Antigüedad) — Prototipo ";
            this.Tbc_Main.ResumeLayout(false);
            this.tabRecibos.ResumeLayout(false);
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
            this.tabPago.ResumeLayout(false);
            this.tabPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLineasPago)).EndInit();
            this.Gpb_Pago.ResumeLayout(false);
            this.Gpb_Pago.PerformLayout();
            this.tabAntiguedad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAntiguedad)).EndInit();
            this.Gpb_AntiguedadFiltros.ResumeLayout(false);
            this.Gpb_AntiguedadFiltros.PerformLayout();
            this.tabReportes.ResumeLayout(false);
            this.Gpb_Reportes.ResumeLayout(false);
            this.Gpb_Reportes.PerformLayout();
            this.tabCierre.ResumeLayout(false);
            this.Gpb_Cierre.ResumeLayout(false);
            this.Gpb_Cierre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tbc_Main;
        private System.Windows.Forms.TabPage tabRecibos;
        private System.Windows.Forms.TabPage tabPago;
        private System.Windows.Forms.TabPage tabAntiguedad;
        private System.Windows.Forms.TabPage tabReportes;
        private System.Windows.Forms.TabPage tabCierre;

        private System.Windows.Forms.SplitContainer splitRecibos;
        private System.Windows.Forms.GroupBox Gpb_Buscar;
        private System.Windows.Forms.TextBox Txt_BuscarCliente;
        private System.Windows.Forms.Label Lbl_BuscarCliente;
        private System.Windows.Forms.DateTimePicker Dtp_Desde;
        private System.Windows.Forms.DateTimePicker Dtp_Hasta;
        private System.Windows.Forms.Label Lbl_Desde;
        private System.Windows.Forms.Label Lbl_Hasta;
        private System.Windows.Forms.Button Btn_Filtrar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.DataGridView Dgv_Facturas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldo;

        private System.Windows.Forms.GroupBox Gpb_Recibo;
        private System.Windows.Forms.TextBox Txt_Obs;
        private System.Windows.Forms.Label Lbl_Obs;
        private System.Windows.Forms.DateTimePicker Dtp_FechaRecibo;
        private System.Windows.Forms.Label Lbl_FechaRecibo;
        private System.Windows.Forms.TextBox Txt_NumeroRecibo;
        private System.Windows.Forms.Label Lbl_NumeroRecibo;
        private System.Windows.Forms.Button Btn_NuevoRecibo;
        private System.Windows.Forms.Button Btn_EditarRecibo;
        private System.Windows.Forms.Button Btn_AnularRecibo;
        private System.Windows.Forms.DataGridView gridRecibos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReciboFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReciboCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReciboMonto;

        private System.Windows.Forms.GroupBox Gpb_Pago;
        private System.Windows.Forms.ComboBox Cbo_Metodo;
        private System.Windows.Forms.Label Lbl_Metodo;
        private System.Windows.Forms.TextBox Txt_Monto;
        private System.Windows.Forms.Label Lbl_Monto;
        private System.Windows.Forms.TextBox Txt_Referencia;
        private System.Windows.Forms.Label Lbl_Referencia;
        private System.Windows.Forms.DateTimePicker Dtp_FechaPago;
        private System.Windows.Forms.Label Lbl_FechaPago;
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

        private System.Windows.Forms.GroupBox Gpb_AntiguedadFiltros;
        private System.Windows.Forms.ComboBox Cbo_Cliente;
        private System.Windows.Forms.Label Lbl_Cliente;
        private System.Windows.Forms.Button Btn_GenerarAntig;
        private System.Windows.Forms.DataGridView gridAntiguedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colACliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colA030;
        private System.Windows.Forms.DataGridViewTextBoxColumn colA3160;
        private System.Windows.Forms.DataGridViewTextBoxColumn colA6190;
        private System.Windows.Forms.DataGridViewTextBoxColumn colA90;
        private System.Windows.Forms.DataGridViewTextBoxColumn colATotal;

        private System.Windows.Forms.GroupBox Gpb_Reportes;
        private System.Windows.Forms.DateTimePicker Dtp_RepDesde;
        private System.Windows.Forms.DateTimePicker Dtp_RepHasta;
        private System.Windows.Forms.Label Lbl_RepDesde;
        private System.Windows.Forms.Label Lbl_RepHasta;
        private System.Windows.Forms.ComboBox Cbo_TipoReporte;
        private System.Windows.Forms.Label Lbl_TipoReporte;
        private System.Windows.Forms.Button Btn_VerReporte;
        private System.Windows.Forms.Panel viewerReporte;

        private System.Windows.Forms.GroupBox Gpb_Cierre;
        private System.Windows.Forms.DateTimePicker Dtp_FechaCierre;
        private System.Windows.Forms.Label Lbl_FechaCierre;
        private System.Windows.Forms.TextBox Txt_TotalCobrado;
        private System.Windows.Forms.Label Lbl_TotalCobrado;
        private System.Windows.Forms.Button Btn_PrevisualizarCierre;
        private System.Windows.Forms.Button Btn_CerrarCaja;
    }
}