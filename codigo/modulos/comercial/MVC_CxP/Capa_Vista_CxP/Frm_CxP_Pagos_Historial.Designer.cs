// Frm_CxP_Pagos_Historial.Designer.cs
namespace Capa_Vista_CxP
{
    partial class Frm_CxP_Pagos_Historial
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
            this.gbpFiltros = new System.Windows.Forms.GroupBox();
            this.lblOrden = new System.Windows.Forms.Label();
            this.cboOrdenar = new System.Windows.Forms.ComboBox();
            this.lblMontoHasta = new System.Windows.Forms.Label();
            this.lblMontoDesde = new System.Windows.Forms.Label();
            this.nudMontoHasta = new System.Windows.Forms.NumericUpDown();
            this.nudMontoDesde = new System.Windows.Forms.NumericUpDown();
            this.chkHasta = new System.Windows.Forms.CheckBox();
            this.chkDesde = new System.Windows.Forms.CheckBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalPagado = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbpFiltros
            // 
            this.gbpFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbpFiltros.Controls.Add(this.lblOrden);
            this.gbpFiltros.Controls.Add(this.cboOrdenar);
            this.gbpFiltros.Controls.Add(this.lblMontoHasta);
            this.gbpFiltros.Controls.Add(this.lblMontoDesde);
            this.gbpFiltros.Controls.Add(this.nudMontoHasta);
            this.gbpFiltros.Controls.Add(this.nudMontoDesde);
            this.gbpFiltros.Controls.Add(this.chkHasta);
            this.gbpFiltros.Controls.Add(this.chkDesde);
            this.gbpFiltros.Controls.Add(this.lblHasta);
            this.gbpFiltros.Controls.Add(this.lblDesde);
            this.gbpFiltros.Controls.Add(this.dtpHasta);
            this.gbpFiltros.Controls.Add(this.dtpDesde);
            this.gbpFiltros.Controls.Add(this.btnBuscar);
            this.gbpFiltros.Controls.Add(this.btnLimpiar);
            this.gbpFiltros.Controls.Add(this.btnExportar);
            this.gbpFiltros.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpFiltros.Location = new System.Drawing.Point(12, 12);
            this.gbpFiltros.Name = "gbpFiltros";
            this.gbpFiltros.Padding = new System.Windows.Forms.Padding(8);
            this.gbpFiltros.Size = new System.Drawing.Size(1038, 118);
            this.gbpFiltros.TabIndex = 0;
            this.gbpFiltros.TabStop = false;
            this.gbpFiltros.Text = "Filtros";
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Location = new System.Drawing.Point(528, 80);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(112, 20);
            this.lblOrden.TabIndex = 10;
            this.lblOrden.Text = "Ordenar por:";
            // 
            // cboOrdenar
            // 
            this.cboOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenar.FormattingEnabled = true;
            this.cboOrdenar.Items.AddRange(new object[] {
            "Fecha (recientes primero)",
            "Fecha (antiguas primero)",
            "Monto (mayor a menor)",
            "Monto (menor a mayor)"});
            this.cboOrdenar.Location = new System.Drawing.Point(646, 80);
            this.cboOrdenar.MaximumSize = new System.Drawing.Size(980, 0);
            this.cboOrdenar.Name = "cboOrdenar";
            this.cboOrdenar.Size = new System.Drawing.Size(252, 28);
            this.cboOrdenar.TabIndex = 11;
            // 
            // lblMontoHasta
            // 
            this.lblMontoHasta.AutoSize = true;
            this.lblMontoHasta.Location = new System.Drawing.Point(270, 80);
            this.lblMontoHasta.Name = "lblMontoHasta";
            this.lblMontoHasta.Size = new System.Drawing.Size(109, 20);
            this.lblMontoHasta.TabIndex = 8;
            this.lblMontoHasta.Text = "Monto hasta:";
            // 
            // lblMontoDesde
            // 
            this.lblMontoDesde.AutoSize = true;
            this.lblMontoDesde.Location = new System.Drawing.Point(16, 80);
            this.lblMontoDesde.Name = "lblMontoDesde";
            this.lblMontoDesde.Size = new System.Drawing.Size(116, 20);
            this.lblMontoDesde.TabIndex = 6;
            this.lblMontoDesde.Text = "Monto desde:";
            // 
            // nudMontoHasta
            // 
            this.nudMontoHasta.DecimalPlaces = 2;
            this.nudMontoHasta.Location = new System.Drawing.Point(385, 80);
            this.nudMontoHasta.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudMontoHasta.Name = "nudMontoHasta";
            this.nudMontoHasta.Size = new System.Drawing.Size(120, 27);
            this.nudMontoHasta.TabIndex = 9;
            this.nudMontoHasta.ThousandsSeparator = true;
            // 
            // nudMontoDesde
            // 
            this.nudMontoDesde.DecimalPlaces = 2;
            this.nudMontoDesde.Location = new System.Drawing.Point(138, 78);
            this.nudMontoDesde.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudMontoDesde.Name = "nudMontoDesde";
            this.nudMontoDesde.Size = new System.Drawing.Size(120, 27);
            this.nudMontoDesde.TabIndex = 7;
            this.nudMontoDesde.ThousandsSeparator = true;
            // 
            // chkHasta
            // 
            this.chkHasta.AutoSize = true;
            this.chkHasta.Location = new System.Drawing.Point(835, 33);
            this.chkHasta.Name = "chkHasta";
            this.chkHasta.Size = new System.Drawing.Size(18, 17);
            this.chkHasta.TabIndex = 5;
            this.chkHasta.UseVisualStyleBackColor = true;
            // 
            // chkDesde
            // 
            this.chkDesde.AutoSize = true;
            this.chkDesde.Location = new System.Drawing.Point(422, 29);
            this.chkDesde.Name = "chkDesde";
            this.chkDesde.Size = new System.Drawing.Size(18, 17);
            this.chkDesde.TabIndex = 2;
            this.chkDesde.UseVisualStyleBackColor = true;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(478, 31);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(106, 20);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Fecha hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(57, 30);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(113, 20);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Fecha desde:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "dddd, dd MMMM yyyy";
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(590, 27);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(228, 27);
            this.dtpHasta.TabIndex = 4;
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "dddd, dd MMMM yyyy";
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(188, 26);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(228, 27);
            this.dtpDesde.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(939, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 28);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(939, 50);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 28);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.Location = new System.Drawing.Point(939, 78);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(85, 29);
            this.btnExportar.TabIndex = 14;
            this.btnExportar.Text = "Exportar…";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Location = new System.Drawing.Point(12, 136);
            this.dgvPagos.MultiSelect = false;
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            this.dgvPagos.RowHeadersVisible = false;
            this.dgvPagos.RowHeadersWidth = 51;
            this.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.Size = new System.Drawing.Size(1038, 417);
            this.dgvPagos.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRegistros,
            this.lblTotalPagado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 607);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1062, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblRegistros
            // 
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(85, 20);
            this.lblRegistros.Text = "Registros: 0";
            // 
            // lblTotalPagado
            // 
            this.lblTotalPagado.Name = "lblTotalPagado";
            this.lblTotalPagado.Size = new System.Drawing.Size(132, 20);
            this.lblTotalPagado.Text = "Total pagado: 0.00";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(965, 559);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(85, 24);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Frm_CxP_Pagos_Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 633);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.gbpFiltros);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 680);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1080, 680);
            this.Name = "Frm_CxP_Pagos_Historial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CxP — Historial de pagos a proveedores";
            this.gbpFiltros.ResumeLayout(false);
            this.gbpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbpFiltros;
        private System.Windows.Forms.Label lblDesde;
        public System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        public System.Windows.Forms.DateTimePicker dtpHasta;
        public System.Windows.Forms.CheckBox chkDesde;
        public System.Windows.Forms.CheckBox chkHasta;

        private System.Windows.Forms.Label lblMontoDesde;
        private System.Windows.Forms.Label lblMontoHasta;
        public System.Windows.Forms.NumericUpDown nudMontoDesde;
        public System.Windows.Forms.NumericUpDown nudMontoHasta;

        private System.Windows.Forms.Label lblOrden;
        public System.Windows.Forms.ComboBox cboOrdenar;

        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Button btnLimpiar;
        public System.Windows.Forms.Button btnExportar;

        public System.Windows.Forms.DataGridView dgvPagos;

        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lblRegistros;
        public System.Windows.Forms.ToolStripStatusLabel lblTotalPagado;

        public System.Windows.Forms.Button btnCerrar;
    }
}
