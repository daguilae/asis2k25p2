using System;
using System.Windows.Forms;
namespace Capa_Vista_CxP
{
    partial class Frm_CxP_Pagos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gpbPago = new System.Windows.Forms.GroupBox();
            this.lblFactura = new System.Windows.Forms.Label();
            this.cboFactura = new System.Windows.Forms.ComboBox();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.grpTipoPago = new System.Windows.Forms.GroupBox();
            this.rdbPagoTotal = new System.Windows.Forms.RadioButton();
            this.rdbPagoParcial = new System.Windows.Forms.RadioButton();
            this.lblTotalFactura = new System.Windows.Forms.Label();
            this.lblTotalFacturaV = new System.Windows.Forms.Label();
            this.lblPendiente = new System.Windows.Forms.Label();
            this.lblPendienteV = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.nudMontoPagar = new System.Windows.Forms.NumericUpDown();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnIrReporte = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Btn_Historial = new System.Windows.Forms.Button();
            this.gpbPago.SuspendLayout();
            this.grpTipoPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbPago
            // 
            this.gpbPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbPago.Controls.Add(this.lblFactura);
            this.gpbPago.Controls.Add(this.cboFactura);
            this.gpbPago.Controls.Add(this.btnVerDetalle);
            this.gpbPago.Controls.Add(this.grpTipoPago);
            this.gpbPago.Controls.Add(this.lblTotalFactura);
            this.gpbPago.Controls.Add(this.lblTotalFacturaV);
            this.gpbPago.Controls.Add(this.lblPendiente);
            this.gpbPago.Controls.Add(this.lblPendienteV);
            this.gpbPago.Controls.Add(this.lblMonto);
            this.gpbPago.Controls.Add(this.nudMontoPagar);
            this.gpbPago.Controls.Add(this.lblFecha);
            this.gpbPago.Controls.Add(this.dtpFechaPago);
            this.gpbPago.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPago.Location = new System.Drawing.Point(12, 12);
            this.gpbPago.Name = "gpbPago";
            this.gpbPago.Padding = new System.Windows.Forms.Padding(8);
            this.gpbPago.Size = new System.Drawing.Size(989, 481);
            this.gpbPago.TabIndex = 0;
            this.gpbPago.TabStop = false;
            this.gpbPago.Text = "Registro de pago de factura a proveedor";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(11, 49);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(153, 21);
            this.lblFactura.TabIndex = 0;
            this.lblFactura.Text = "Factura a pagar:";
            // 
            // cboFactura
            // 
            this.cboFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFactura.FormattingEnabled = true;
            this.cboFactura.Location = new System.Drawing.Point(170, 49);
            this.cboFactura.Name = "cboFactura";
            this.cboFactura.Size = new System.Drawing.Size(360, 28);
            this.cboFactura.TabIndex = 1;
            this.cboFactura.SelectedIndexChanged += new System.EventHandler(this.cboFactura_SelectedIndexChanged);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Location = new System.Drawing.Point(551, 49);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(147, 28);
            this.btnVerDetalle.TabIndex = 2;
            this.btnVerDetalle.Text = "Ver detalle…";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // grpTipoPago
            // 
            this.grpTipoPago.Controls.Add(this.rdbPagoTotal);
            this.grpTipoPago.Controls.Add(this.rdbPagoParcial);
            this.grpTipoPago.Location = new System.Drawing.Point(505, 108);
            this.grpTipoPago.Name = "grpTipoPago";
            this.grpTipoPago.Size = new System.Drawing.Size(193, 55);
            this.grpTipoPago.TabIndex = 3;
            this.grpTipoPago.TabStop = false;
            this.grpTipoPago.Text = "Tipo de pago";
            // 
            // rdbPagoTotal
            // 
            this.rdbPagoTotal.AutoSize = true;
            this.rdbPagoTotal.Location = new System.Drawing.Point(106, 24);
            this.rdbPagoTotal.Name = "rdbPagoTotal";
            this.rdbPagoTotal.Size = new System.Drawing.Size(75, 25);
            this.rdbPagoTotal.TabIndex = 1;
            this.rdbPagoTotal.Text = "Total";
            this.rdbPagoTotal.UseVisualStyleBackColor = true;
            this.rdbPagoTotal.CheckedChanged += new System.EventHandler(this.rdbPagoTotal_CheckedChanged);
            // 
            // rdbPagoParcial
            // 
            this.rdbPagoParcial.AutoSize = true;
            this.rdbPagoParcial.Checked = true;
            this.rdbPagoParcial.Location = new System.Drawing.Point(8, 24);
            this.rdbPagoParcial.Name = "rdbPagoParcial";
            this.rdbPagoParcial.Size = new System.Drawing.Size(92, 25);
            this.rdbPagoParcial.TabIndex = 0;
            this.rdbPagoParcial.TabStop = true;
            this.rdbPagoParcial.Text = "Parcial";
            this.rdbPagoParcial.UseVisualStyleBackColor = true;
            this.rdbPagoParcial.CheckedChanged += new System.EventHandler(this.rdbPagoParcial_CheckedChanged);
            // 
            // lblTotalFactura
            // 
            this.lblTotalFactura.AutoSize = true;
            this.lblTotalFactura.Location = new System.Drawing.Point(11, 90);
            this.lblTotalFactura.Name = "lblTotalFactura";
            this.lblTotalFactura.Size = new System.Drawing.Size(126, 21);
            this.lblTotalFactura.TabIndex = 4;
            this.lblTotalFactura.Text = "Total factura:";
            // 
            // lblTotalFacturaV
            // 
            this.lblTotalFacturaV.AutoSize = true;
            this.lblTotalFacturaV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalFacturaV.Location = new System.Drawing.Point(143, 94);
            this.lblTotalFacturaV.Name = "lblTotalFacturaV";
            this.lblTotalFacturaV.Size = new System.Drawing.Size(40, 17);
            this.lblTotalFacturaV.TabIndex = 5;
            this.lblTotalFacturaV.Text = "0.00";
            // 
            // lblPendiente
            // 
            this.lblPendiente.AutoSize = true;
            this.lblPendiente.Location = new System.Drawing.Point(11, 120);
            this.lblPendiente.Name = "lblPendiente";
            this.lblPendiente.Size = new System.Drawing.Size(161, 21);
            this.lblPendiente.TabIndex = 6;
            this.lblPendiente.Text = "Saldo pendiente:";
            // 
            // lblPendienteV
            // 
            this.lblPendienteV.AutoSize = true;
            this.lblPendienteV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPendienteV.Location = new System.Drawing.Point(178, 124);
            this.lblPendienteV.Name = "lblPendienteV";
            this.lblPendienteV.Size = new System.Drawing.Size(40, 17);
            this.lblPendienteV.TabIndex = 7;
            this.lblPendienteV.Text = "0.00";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(708, 128);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(144, 21);
            this.lblMonto.TabIndex = 8;
            this.lblMonto.Text = "Monto a pagar:";
            // 
            // nudMontoPagar
            // 
            this.nudMontoPagar.DecimalPlaces = 2;
            this.nudMontoPagar.Location = new System.Drawing.Point(858, 124);
            this.nudMontoPagar.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudMontoPagar.Name = "nudMontoPagar";
            this.nudMontoPagar.Size = new System.Drawing.Size(120, 29);
            this.nudMontoPagar.TabIndex = 9;
            this.nudMontoPagar.ThousandsSeparator = true;
            this.nudMontoPagar.ValueChanged += new System.EventHandler(this.nudMontoPagar_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(11, 184);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(118, 21);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha pago:";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.CustomFormat = "dddd, dd MMMM yyyy";
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPago.Location = new System.Drawing.Point(135, 184);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(305, 29);
            this.dtpFechaPago.TabIndex = 11;
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(711, 499);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(125, 28);
            this.btnPagar.TabIndex = 1;
            this.btnPagar.Text = "Registrar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnIrReporte
            // 
            this.btnIrReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIrReporte.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrReporte.Location = new System.Drawing.Point(842, 499);
            this.btnIrReporte.Name = "btnIrReporte";
            this.btnIrReporte.Size = new System.Drawing.Size(159, 28);
            this.btnIrReporte.TabIndex = 2;
            this.btnIrReporte.Text = "Ir al reporte";
            this.btnIrReporte.UseVisualStyleBackColor = true;
            this.btnIrReporte.Click += new System.EventHandler(this.btnIrReporte_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(12, 499);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 28);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Btn_Historial
            // 
            this.Btn_Historial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Historial.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Historial.Location = new System.Drawing.Point(573, 499);
            this.Btn_Historial.Name = "Btn_Historial";
            this.Btn_Historial.Size = new System.Drawing.Size(125, 28);
            this.Btn_Historial.TabIndex = 4;
            this.Btn_Historial.Text = "Historial";
            this.Btn_Historial.UseVisualStyleBackColor = true;
            this.Btn_Historial.Click += new System.EventHandler(this.Btn_Historial_Click);
            // 
            // Frm_CxP_Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 539);
            this.Controls.Add(this.Btn_Historial);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIrReporte);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.gpbPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CxP_Pagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CxP — Pagos de Facturas";
            this.gpbPago.ResumeLayout(false);
            this.gpbPago.PerformLayout();
            this.grpTipoPago.ResumeLayout(false);
            this.grpTipoPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPago;
        private System.Windows.Forms.Label lblFactura;
        public System.Windows.Forms.ComboBox cboFactura;
        private System.Windows.Forms.Button btnVerDetalle;

        private System.Windows.Forms.GroupBox grpTipoPago;
        public System.Windows.Forms.RadioButton rdbPagoTotal;
        public System.Windows.Forms.RadioButton rdbPagoParcial;

        private System.Windows.Forms.Label lblTotalFactura;
        public System.Windows.Forms.Label lblTotalFacturaV;
        private System.Windows.Forms.Label lblPendiente;
        public System.Windows.Forms.Label lblPendienteV;

        private System.Windows.Forms.Label lblMonto;
        public System.Windows.Forms.NumericUpDown nudMontoPagar;

        private System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.DateTimePicker dtpFechaPago;

        public System.Windows.Forms.Button btnPagar;
        public System.Windows.Forms.Button btnIrReporte;
        public System.Windows.Forms.Button btnCancelar;

        private System.Windows.Forms.ErrorProvider errorProvider1;
        public Button Btn_Historial;
    }
}