using System;
using System.Windows.Forms;

namespace Capa_Vista_CxC
{
    partial class Frm_Reportes
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
            this.mnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.gpParams = new System.Windows.Forms.GroupBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblCorte = new System.Windows.Forms.Label();
            this.dtpCorte = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCaja = new System.Windows.Forms.Label();
            this.dtpFechaCaja = new System.Windows.Forms.DateTimePicker();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gridReporte = new System.Windows.Forms.DataGridView();
            this.menu.SuspendLayout();
            this.gpParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRecibos,
            this.mnuAplicarPago,
            this.mnuReportes,
            this.mnuSalir});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1200, 24);
            this.menu.TabIndex = 2;
            // 
            // mnuRecibos
            // 
            this.mnuRecibos.Name = "mnuRecibos";
            this.mnuRecibos.Size = new System.Drawing.Size(66, 20);
            this.mnuRecibos.Text = "Recibos";
            this.mnuRecibos.Click += new System.EventHandler(this.mnuRecibos_Click);
            // 
            // mnuAplicarPago
            // 
            this.mnuAplicarPago.Name = "mnuAplicarPago";
            this.mnuAplicarPago.Size = new System.Drawing.Size(94, 20);
            this.mnuAplicarPago.Text = "Aplicar Pago";
            this.mnuAplicarPago.Click += new System.EventHandler(this.mnuAplicarPago_Click);
            // 
            // mnuReportes
            // 
            this.mnuReportes.Name = "mnuReportes";
            this.mnuReportes.Size = new System.Drawing.Size(65, 20);
            this.mnuReportes.Text = "Reportes";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(41, 20);
            this.mnuSalir.Text = "Salir";
            // 
            // gpParams
            // 
            this.gpParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpParams.Controls.Add(this.lblTipo);
            this.gpParams.Controls.Add(this.cboTipo);
            this.gpParams.Controls.Add(this.lblCliente);
            this.gpParams.Controls.Add(this.cboCliente);
            this.gpParams.Controls.Add(this.lblCorte);
            this.gpParams.Controls.Add(this.dtpCorte);
            this.gpParams.Controls.Add(this.lblFechaCaja);
            this.gpParams.Controls.Add(this.dtpFechaCaja);
            this.gpParams.Controls.Add(this.btnVer);
            this.gpParams.Controls.Add(this.btnImprimir);
            this.gpParams.Controls.Add(this.btnExportar);
            this.gpParams.Controls.Add(this.lblTotal);
            this.gpParams.Location = new System.Drawing.Point(12, 32);
            this.gpParams.Name = "gpParams";
            this.gpParams.Size = new System.Drawing.Size(1176, 92);
            this.gpParams.TabIndex = 1;
            this.gpParams.TabStop = false;
            this.gpParams.Text = "Parámetros";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(16, 32);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(37, 16);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Location = new System.Drawing.Point(56, 28);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(220, 24);
            this.cboTipo.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(300, 32);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(53, 16);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente:";
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.Location = new System.Drawing.Point(351, 28);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(240, 24);
            this.cboCliente.TabIndex = 3;
            // 
            // lblCorte
            // 
            this.lblCorte.AutoSize = true;
            this.lblCorte.Location = new System.Drawing.Point(610, 32);
            this.lblCorte.Name = "lblCorte";
            this.lblCorte.Size = new System.Drawing.Size(80, 16);
            this.lblCorte.TabIndex = 4;
            this.lblCorte.Text = "Fecha corte:";
            // 
            // dtpCorte
            // 
            this.dtpCorte.Location = new System.Drawing.Point(685, 28);
            this.dtpCorte.Name = "dtpCorte";
            this.dtpCorte.Size = new System.Drawing.Size(180, 23);
            this.dtpCorte.TabIndex = 5;
            // 
            // lblFechaCaja
            // 
            this.lblFechaCaja.AutoSize = true;
            this.lblFechaCaja.Location = new System.Drawing.Point(300, 61);
            this.lblFechaCaja.Name = "lblFechaCaja";
            this.lblFechaCaja.Size = new System.Drawing.Size(47, 16);
            this.lblFechaCaja.TabIndex = 6;
            this.lblFechaCaja.Text = "Fecha:";
            // 
            // dtpFechaCaja
            // 
            this.dtpFechaCaja.Location = new System.Drawing.Point(351, 57);
            this.dtpFechaCaja.Name = "dtpFechaCaja";
            this.dtpFechaCaja.Size = new System.Drawing.Size(180, 23);
            this.dtpFechaCaja.TabIndex = 7;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(885, 27);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(80, 24);
            this.btnVer.TabIndex = 8;
            this.btnVer.Text = "Ver";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Location = new System.Drawing.Point(994, 27);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 24);
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.Text = "Imprimir";
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.Location = new System.Drawing.Point(1090, 27);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(90, 24);
            this.btnExportar.TabIndex = 10;
            this.btnExportar.Text = "Exportar CSV";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(995, 61);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 11;
            // 
            // gridReporte
            // 
            this.gridReporte.AllowUserToAddRows = false;
            this.gridReporte.AllowUserToDeleteRows = false;
            this.gridReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridReporte.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridReporte.Location = new System.Drawing.Point(12, 134);
            this.gridReporte.Name = "gridReporte";
            this.gridReporte.ReadOnly = true;
            this.gridReporte.RowHeadersVisible = false;
            this.gridReporte.Size = new System.Drawing.Size(1176, 504);
            this.gridReporte.TabIndex = 0;
            // 
            // Frm_Reportes
            // 
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.gridReporte);
            this.Controls.Add(this.gpParams);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menu;
            this.Name = "Frm_Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas por Cobrar — Reportes (Antigüedad / Cierre de Caja)";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.gpParams.ResumeLayout(false);
            this.gpParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnuRecibos;
        private System.Windows.Forms.ToolStripMenuItem mnuAplicarPago;
        private System.Windows.Forms.ToolStripMenuItem mnuReportes;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;

        private System.Windows.Forms.GroupBox gpParams;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblCorte;
        private System.Windows.Forms.DateTimePicker dtpCorte;

        private System.Windows.Forms.Label lblFechaCaja;
        private System.Windows.Forms.DateTimePicker dtpFechaCaja;

        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblTotal;

        private System.Windows.Forms.DataGridView gridReporte;
    }
}
