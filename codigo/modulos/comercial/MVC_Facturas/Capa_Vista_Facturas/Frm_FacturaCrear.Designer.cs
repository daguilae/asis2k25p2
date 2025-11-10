using System.Windows.Forms;
using System.Drawing;

namespace Capa_Vista_Facturas
{
    partial class Frm_FacturaCrear
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;

        private GroupBox grpCliente;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox Txt_Nombre;
        private TextBox Txt_Apellido;

        private Label lblTipoDoc;
        private ComboBox Cbo_TipoDoc;
        private Label lblDocumento;
        private TextBox Txt_Documento;

        private Label lblFecha;
        private DateTimePicker Dtp_Fecha;

        private GroupBox grpFactura;
        private Label lblTotal;
        private TextBox Txt_Total;
        private DataGridView Dgv_Detalle;

        private Button Btn_Guardar;
        private Button Btn_Imprimir;
        private Button Btn_Cancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Frm_FacturaCrear));
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.Txt_Apellido = new System.Windows.Forms.TextBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.Cbo_TipoDoc = new System.Windows.Forms.ComboBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.Txt_Documento = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.grpFactura = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.Dgv_Detalle = new System.Windows.Forms.DataGridView();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.grpCliente.SuspendLayout();
            this.grpFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCliente
            // 
            this.grpCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCliente.Controls.Add(this.lblNombre);
            this.grpCliente.Controls.Add(this.Txt_Nombre);
            this.grpCliente.Controls.Add(this.lblApellido);
            this.grpCliente.Controls.Add(this.Txt_Apellido);
            this.grpCliente.Controls.Add(this.lblTipoDoc);
            this.grpCliente.Controls.Add(this.Cbo_TipoDoc);
            this.grpCliente.Controls.Add(this.lblDocumento);
            this.grpCliente.Controls.Add(this.Txt_Documento);
            this.grpCliente.Controls.Add(this.lblFecha);
            this.grpCliente.Controls.Add(this.Dtp_Fecha);
            this.grpCliente.Location = new System.Drawing.Point(16, 12);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(848, 150);
            this.grpCliente.TabIndex = 0;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Datos del Cliente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(100, 28);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(240, 22);
            this.Txt_Nombre.TabIndex = 0;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(360, 32);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 17);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Location = new System.Drawing.Point(430, 28);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(240, 22);
            this.Txt_Apellido.TabIndex = 1;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(24, 72);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(84, 17);
            this.lblTipoDoc.TabIndex = 2;
            this.lblTipoDoc.Text = "Documento:";
            // 
            // Cbo_TipoDoc
            // 
            this.Cbo_TipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_TipoDoc.Items.AddRange(new object[] { "NIT", "CF" });
            this.Cbo_TipoDoc.Location = new System.Drawing.Point(100, 68);
            this.Cbo_TipoDoc.Name = "Cbo_TipoDoc";
            this.Cbo_TipoDoc.Size = new System.Drawing.Size(80, 24);
            this.Cbo_TipoDoc.TabIndex = 2;
            this.Cbo_TipoDoc.SelectedIndexChanged += new System.EventHandler(this.Cbo_TipoDoc_SelectedIndexChanged);
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(200, 72);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(63, 17);
            this.lblDocumento.TabIndex = 3;
            this.lblDocumento.Text = "NIT / CF:";
            // 
            // Txt_Documento
            // 
            this.Txt_Documento.Location = new System.Drawing.Point(260, 68);
            this.Txt_Documento.Name = "Txt_Documento";
            this.Txt_Documento.Size = new System.Drawing.Size(220, 22);
            this.Txt_Documento.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(500, 72);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 17);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.Dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_Fecha.Location = new System.Drawing.Point(550, 68);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(180, 22);
            this.Dtp_Fecha.TabIndex = 4;
            // 
            // grpFactura
            // 
            this.grpFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFactura.Controls.Add(this.lblTotal);
            this.grpFactura.Controls.Add(this.Txt_Total);
            this.grpFactura.Controls.Add(this.Dgv_Detalle);
            this.grpFactura.Location = new System.Drawing.Point(16, 172);
            this.grpFactura.Name = "grpFactura";
            this.grpFactura.Size = new System.Drawing.Size(848, 300);
            this.grpFactura.TabIndex = 1;
            this.grpFactura.TabStop = false;
            this.grpFactura.Text = "Resumen de Factura";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(24, 32);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(123, 17);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total a Pagar (Q):";
            // 
            // Txt_Total
            // 
            this.Txt_Total.Location = new System.Drawing.Point(140, 28);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.ReadOnly = true;
            this.Txt_Total.Size = new System.Drawing.Size(120, 22);
            this.Txt_Total.TabIndex = 1;
            this.Txt_Total.TabStop = false;
            // 
            // Dgv_Detalle
            // 
            this.Dgv_Detalle.AllowUserToAddRows = false;
            this.Dgv_Detalle.AllowUserToDeleteRows = false;
            this.Dgv_Detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Detalle.ColumnHeadersHeight = 29;
            this.Dgv_Detalle.Location = new System.Drawing.Point(24, 64);
            this.Dgv_Detalle.Name = "Dgv_Detalle";
            this.Dgv_Detalle.ReadOnly = true;
            this.Dgv_Detalle.RowHeadersWidth = 51;
            this.Dgv_Detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Detalle.Size = new System.Drawing.Size(800, 216);
            this.Dgv_Detalle.TabIndex = 2;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(430, 488);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(110, 36);
            this.Btn_Guardar.TabIndex = 5;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.Location = new System.Drawing.Point(550, 488);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(110, 36);
            this.Btn_Imprimir.TabIndex = 6;
            this.Btn_Imprimir.Text = "Imprimir";
            this.Btn_Imprimir.UseVisualStyleBackColor = true;
            this.Btn_Imprimir.Click += new System.EventHandler(this.Btn_Imprimir_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(670, 488);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(110, 36);
            this.Btn_Cancelar.TabIndex = 7;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            //    this.Btn_Cancelar.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "Factura";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(900, 700);
            this.printPreviewDialog1.Enabled = true;
          //  this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Frm_FacturaCrear
            // 
            this.AcceptButton = this.Btn_Guardar;
            this.ClientSize = new System.Drawing.Size(880, 560);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.grpFactura);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Imprimir);
            this.Controls.Add(this.Btn_Cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_FacturaCrear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear Factura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_FacturaCrear_Load);
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpFactura.ResumeLayout(false);
            this.grpFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
