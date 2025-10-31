
namespace Capa_Vista_Facturas
{
    partial class Frm_Detalle_Factura
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
            this.grpEncabezado = new System.Windows.Forms.GroupBox();
            this.lblEstadoV = new System.Windows.Forms.Label();
            this.lblTotalV = new System.Windows.Forms.Label();
            this.lblMonedaV = new System.Windows.Forms.Label();
            this.lblNitV = new System.Windows.Forms.Label();
            this.lblClienteV = new System.Windows.Forms.Label();
            this.lblFechaV = new System.Windows.Forms.Label();
            this.lblNumeroV = new System.Windows.Forms.Label();
            this.lblSerieV = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grpEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEncabezado
            // 
            this.grpEncabezado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEncabezado.Controls.Add(this.lblEstadoV);
            this.grpEncabezado.Controls.Add(this.lblTotalV);
            this.grpEncabezado.Controls.Add(this.lblMonedaV);
            this.grpEncabezado.Controls.Add(this.lblNitV);
            this.grpEncabezado.Controls.Add(this.lblClienteV);
            this.grpEncabezado.Controls.Add(this.lblFechaV);
            this.grpEncabezado.Controls.Add(this.lblNumeroV);
            this.grpEncabezado.Controls.Add(this.lblSerieV);
            this.grpEncabezado.Controls.Add(this.lblEstado);
            this.grpEncabezado.Controls.Add(this.lblTotal);
            this.grpEncabezado.Controls.Add(this.lblMoneda);
            this.grpEncabezado.Controls.Add(this.lblNit);
            this.grpEncabezado.Controls.Add(this.lblCliente);
            this.grpEncabezado.Controls.Add(this.lblFecha);
            this.grpEncabezado.Controls.Add(this.lblNumero);
            this.grpEncabezado.Controls.Add(this.lblSerie);
            this.grpEncabezado.Location = new System.Drawing.Point(16, 15);
            this.grpEncabezado.Margin = new System.Windows.Forms.Padding(4);
            this.grpEncabezado.Name = "grpEncabezado";
            this.grpEncabezado.Padding = new System.Windows.Forms.Padding(4);
            this.grpEncabezado.Size = new System.Drawing.Size(1013, 145);
            this.grpEncabezado.TabIndex = 0;
            this.grpEncabezado.TabStop = false;
            this.grpEncabezado.Text = "Encabezado";
            // 
            // lblEstadoV
            // 
            this.lblEstadoV.AutoSize = true;
            this.lblEstadoV.Location = new System.Drawing.Point(573, 112);
            this.lblEstadoV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoV.Name = "lblEstadoV";
            this.lblEstadoV.Size = new System.Drawing.Size(13, 17);
            this.lblEstadoV.TabIndex = 0;
            this.lblEstadoV.Text = "-";
            // 
            // lblTotalV
            // 
            this.lblTotalV.AutoSize = true;
            this.lblTotalV.Location = new System.Drawing.Point(573, 84);
            this.lblTotalV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalV.Name = "lblTotalV";
            this.lblTotalV.Size = new System.Drawing.Size(13, 17);
            this.lblTotalV.TabIndex = 1;
            this.lblTotalV.Text = "-";
            // 
            // lblMonedaV
            // 
            this.lblMonedaV.AutoSize = true;
            this.lblMonedaV.Location = new System.Drawing.Point(573, 55);
            this.lblMonedaV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonedaV.Name = "lblMonedaV";
            this.lblMonedaV.Size = new System.Drawing.Size(13, 17);
            this.lblMonedaV.TabIndex = 2;
            this.lblMonedaV.Text = "-";
            // 
            // lblNitV
            // 
            this.lblNitV.AutoSize = true;
            this.lblNitV.Location = new System.Drawing.Point(573, 27);
            this.lblNitV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNitV.Name = "lblNitV";
            this.lblNitV.Size = new System.Drawing.Size(13, 17);
            this.lblNitV.TabIndex = 3;
            this.lblNitV.Text = "-";
            // 
            // lblClienteV
            // 
            this.lblClienteV.AutoSize = true;
            this.lblClienteV.Location = new System.Drawing.Point(120, 112);
            this.lblClienteV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteV.Name = "lblClienteV";
            this.lblClienteV.Size = new System.Drawing.Size(13, 17);
            this.lblClienteV.TabIndex = 4;
            this.lblClienteV.Text = "-";
            // 
            // lblFechaV
            // 
            this.lblFechaV.AutoSize = true;
            this.lblFechaV.Location = new System.Drawing.Point(120, 84);
            this.lblFechaV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaV.Name = "lblFechaV";
            this.lblFechaV.Size = new System.Drawing.Size(13, 17);
            this.lblFechaV.TabIndex = 5;
            this.lblFechaV.Text = "-";
            // 
            // lblNumeroV
            // 
            this.lblNumeroV.AutoSize = true;
            this.lblNumeroV.Location = new System.Drawing.Point(120, 55);
            this.lblNumeroV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroV.Name = "lblNumeroV";
            this.lblNumeroV.Size = new System.Drawing.Size(13, 17);
            this.lblNumeroV.TabIndex = 6;
            this.lblNumeroV.Text = "-";
            // 
            // lblSerieV
            // 
            this.lblSerieV.AutoSize = true;
            this.lblSerieV.Location = new System.Drawing.Point(120, 27);
            this.lblSerieV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerieV.Name = "lblSerieV";
            this.lblSerieV.Size = new System.Drawing.Size(13, 17);
            this.lblSerieV.TabIndex = 7;
            this.lblSerieV.Text = "-";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(480, 112);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 17);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(480, 84);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total:";
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(480, 55);
            this.lblMoneda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(63, 17);
            this.lblMoneda.TabIndex = 10;
            this.lblMoneda.Text = "Moneda:";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Location = new System.Drawing.Point(480, 27);
            this.lblNit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(34, 17);
            this.lblNit.TabIndex = 11;
            this.lblNit.Text = "NIT:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(21, 112);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(55, 17);
            this.lblCliente.TabIndex = 12;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(21, 84);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 17);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(21, 55);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 17);
            this.lblNumero.TabIndex = 14;
            this.lblNumero.Text = "Número:";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(21, 27);
            this.lblSerie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(45, 17);
            this.lblSerie.TabIndex = 15;
            this.lblSerie.Text = "Serie:";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colProducto,
            this.colCantidad,
            this.colPrecio,
            this.colTotal});
            this.dgvDetalle.Location = new System.Drawing.Point(16, 180);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(1013, 437);
            this.dgvDetalle.TabIndex = 1;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 90;
            // 
            // colProducto
            // 
            this.colProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 6;
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 90;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 90;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 90;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(896, 628);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(133, 32);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Frm_Detalle_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1045, 674);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.grpEncabezado);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(954, 543);
            this.Name = "Frm_Detalle_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle de Factura";
            this.grpEncabezado.ResumeLayout(false);
            this.grpEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEncabezado;
        private System.Windows.Forms.Label lblSerie; private System.Windows.Forms.Label lblNumero; private System.Windows.Forms.Label lblFecha; private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNit; private System.Windows.Forms.Label lblMoneda; private System.Windows.Forms.Label lblTotal; private System.Windows.Forms.Label lblEstado;

        internal System.Windows.Forms.Label lblSerieV; internal System.Windows.Forms.Label lblNumeroV; internal System.Windows.Forms.Label lblFechaV; internal System.Windows.Forms.Label lblClienteV;
        internal System.Windows.Forms.Label lblNitV; internal System.Windows.Forms.Label lblMonedaV; internal System.Windows.Forms.Label lblTotalV; internal System.Windows.Forms.Label lblEstadoV;

        internal System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        internal System.Windows.Forms.Button btnCerrar;
    }
}