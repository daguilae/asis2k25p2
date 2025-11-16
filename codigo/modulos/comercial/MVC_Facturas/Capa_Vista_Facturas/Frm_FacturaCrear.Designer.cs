using System.Windows.Forms;
using System.Drawing;

namespace Capa_Vista_Facturas
{
    partial class Frm_FacturaCrear
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;

        private GroupBox Gpb_Cliente;
        private Label Lbl_Nombre;
        private Label Lbl_Apellido;
        private TextBox Txt_Nombre;
        private TextBox Txt_Apellido;

        private Label Lbl_TipoDoc;
        private ComboBox Cbo_TipoDoc;
        private Label Lbl_Documento;
        private TextBox Txt_Documento;

        private Label Lbl_Fecha;
        private DateTimePicker Dtp_Fecha;

        private GroupBox Gpb_Factura;
        private Label Lbl_Total;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FacturaCrear));
            this.Gpb_Cliente = new System.Windows.Forms.GroupBox();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Lbl_Apellido = new System.Windows.Forms.Label();
            this.Txt_Apellido = new System.Windows.Forms.TextBox();
            this.Lbl_TipoDoc = new System.Windows.Forms.Label();
            this.Cbo_TipoDoc = new System.Windows.Forms.ComboBox();
            this.Lbl_Documento = new System.Windows.Forms.Label();
            this.Txt_Documento = new System.Windows.Forms.TextBox();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Gpb_Factura = new System.Windows.Forms.GroupBox();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.Dgv_Detalle = new System.Windows.Forms.DataGridView();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Gpb_Cliente.SuspendLayout();
            this.Gpb_Factura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb_Cliente
            // 
            this.Gpb_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpb_Cliente.Controls.Add(this.Lbl_Nombre);
            this.Gpb_Cliente.Controls.Add(this.Txt_Nombre);
            this.Gpb_Cliente.Controls.Add(this.Lbl_Apellido);
            this.Gpb_Cliente.Controls.Add(this.Txt_Apellido);
            this.Gpb_Cliente.Controls.Add(this.Lbl_TipoDoc);
            this.Gpb_Cliente.Controls.Add(this.Cbo_TipoDoc);
            this.Gpb_Cliente.Controls.Add(this.Lbl_Documento);
            this.Gpb_Cliente.Controls.Add(this.Txt_Documento);
            this.Gpb_Cliente.Controls.Add(this.Lbl_Fecha);
            this.Gpb_Cliente.Controls.Add(this.Dtp_Fecha);
            this.Gpb_Cliente.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Cliente.Location = new System.Drawing.Point(16, 12);
            this.Gpb_Cliente.Name = "Gpb_Cliente";
            this.Gpb_Cliente.Size = new System.Drawing.Size(848, 150);
            this.Gpb_Cliente.TabIndex = 0;
            this.Gpb_Cliente.TabStop = false;
            this.Gpb_Cliente.Text = "Datos del Cliente";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(24, 32);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(78, 20);
            this.Lbl_Nombre.TabIndex = 0;
            this.Lbl_Nombre.Text = "Nombre:";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(108, 29);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(240, 27);
            this.Txt_Nombre.TabIndex = 0;
            // 
            // Lbl_Apellido
            // 
            this.Lbl_Apellido.AutoSize = true;
            this.Lbl_Apellido.Location = new System.Drawing.Point(385, 31);
            this.Lbl_Apellido.Name = "Lbl_Apellido";
            this.Lbl_Apellido.Size = new System.Drawing.Size(81, 20);
            this.Lbl_Apellido.TabIndex = 1;
            this.Lbl_Apellido.Text = "Apellido:";
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Location = new System.Drawing.Point(472, 29);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(240, 27);
            this.Txt_Apellido.TabIndex = 1;
            // 
            // Lbl_TipoDoc
            // 
            this.Lbl_TipoDoc.AutoSize = true;
            this.Lbl_TipoDoc.Location = new System.Drawing.Point(24, 81);
            this.Lbl_TipoDoc.Name = "Lbl_TipoDoc";
            this.Lbl_TipoDoc.Size = new System.Drawing.Size(105, 20);
            this.Lbl_TipoDoc.TabIndex = 2;
            this.Lbl_TipoDoc.Text = "Documento:";
            // 
            // Cbo_TipoDoc
            // 
            this.Cbo_TipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_TipoDoc.Items.AddRange(new object[] {
            "NIT",
            "CF"});
            this.Cbo_TipoDoc.Location = new System.Drawing.Point(145, 77);
            this.Cbo_TipoDoc.Name = "Cbo_TipoDoc";
            this.Cbo_TipoDoc.Size = new System.Drawing.Size(80, 28);
            this.Cbo_TipoDoc.TabIndex = 2;
            this.Cbo_TipoDoc.SelectedIndexChanged += new System.EventHandler(this.Cbo_TipoDoc_SelectedIndexChanged);
            // 
            // Lbl_Documento
            // 
            this.Lbl_Documento.AutoSize = true;
            this.Lbl_Documento.Location = new System.Drawing.Point(231, 79);
            this.Lbl_Documento.Name = "Lbl_Documento";
            this.Lbl_Documento.Size = new System.Drawing.Size(78, 20);
            this.Lbl_Documento.TabIndex = 3;
            this.Lbl_Documento.Text = "NIT / CF:";
            // 
            // Txt_Documento
            // 
            this.Txt_Documento.Location = new System.Drawing.Point(324, 73);
            this.Txt_Documento.Name = "Txt_Documento";
            this.Txt_Documento.Size = new System.Drawing.Size(220, 27);
            this.Txt_Documento.TabIndex = 3;
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Location = new System.Drawing.Point(550, 77);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(61, 20);
            this.Lbl_Fecha.TabIndex = 4;
            this.Lbl_Fecha.Text = "Fecha:";
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.Dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_Fecha.Location = new System.Drawing.Point(617, 74);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(180, 27);
            this.Dtp_Fecha.TabIndex = 4;
            // 
            // Gpb_Factura
            // 
            this.Gpb_Factura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpb_Factura.Controls.Add(this.Lbl_Total);
            this.Gpb_Factura.Controls.Add(this.Txt_Total);
            this.Gpb_Factura.Controls.Add(this.Dgv_Detalle);
            this.Gpb_Factura.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Factura.Location = new System.Drawing.Point(16, 172);
            this.Gpb_Factura.Name = "Gpb_Factura";
            this.Gpb_Factura.Size = new System.Drawing.Size(848, 300);
            this.Gpb_Factura.TabIndex = 1;
            this.Gpb_Factura.TabStop = false;
            this.Gpb_Factura.Text = "Resumen de Factura";
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Location = new System.Drawing.Point(24, 32);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(145, 20);
            this.Lbl_Total.TabIndex = 0;
            this.Lbl_Total.Text = "Total a Pagar (Q):";
            // 
            // Txt_Total
            // 
            this.Txt_Total.Location = new System.Drawing.Point(140, 28);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.ReadOnly = true;
            this.Txt_Total.Size = new System.Drawing.Size(120, 27);
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
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Frm_FacturaCrear
            // 
            this.AcceptButton = this.Btn_Guardar;
            this.ClientSize = new System.Drawing.Size(880, 560);
            this.Controls.Add(this.Gpb_Cliente);
            this.Controls.Add(this.Gpb_Factura);
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
            this.Gpb_Cliente.ResumeLayout(false);
            this.Gpb_Cliente.PerformLayout();
            this.Gpb_Factura.ResumeLayout(false);
            this.Gpb_Factura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
