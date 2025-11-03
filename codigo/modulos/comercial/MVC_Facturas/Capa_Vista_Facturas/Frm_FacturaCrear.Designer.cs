using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace Capa_Vista_Facturas
{
    partial class Frm_FacturaCrear
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;

        // Controles
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
            this.components = new System.ComponentModel.Container();

            this.grpCliente = new GroupBox();
            this.lblNombre = new Label();
            this.lblApellido = new Label();
            this.Txt_Nombre = new TextBox();
            this.Txt_Apellido = new TextBox();

            this.lblTipoDoc = new Label();
            this.Cbo_TipoDoc = new ComboBox();
            this.lblDocumento = new Label();
            this.Txt_Documento = new TextBox();

            this.lblFecha = new Label();
            this.Dtp_Fecha = new DateTimePicker();

            this.grpFactura = new GroupBox();
            this.lblTotal = new Label();
            this.Txt_Total = new TextBox();
            this.Dgv_Detalle = new DataGridView();

            this.Btn_Guardar = new Button();
            this.Btn_Imprimir = new Button();
            this.Btn_Cancelar = new Button();

            // ======== PrintDocument ========
            this.printDocument1 = new PrintDocument();
            this.printDocument1.DocumentName = "Factura";
            this.printDocument1.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);

            // ======== PrintPreviewDialog ========
            this.printPreviewDialog1 = new PrintPreviewDialog();
            this.printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            this.printPreviewDialog1.ClientSize = new Size(900, 700);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // No seteamos Icon para evitar dependencia de resources.

            // ===== Form =====
            this.SuspendLayout();
            this.Text = "Crear Factura";
            this.StartPosition = FormStartPosition.CenterParent;
            this.ClientSize = new Size(880, 560);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Eventos del form
            this.Load += new System.EventHandler(this.Frm_FacturaCrear_Load);
            this.AcceptButton = this.Btn_Guardar;

            // ======== grpCliente ========
            this.grpCliente.Text = "Datos del Cliente";
            this.grpCliente.Location = new Point(16, 12);
            this.grpCliente.Size = new Size(848, 150);
            this.grpCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Nombre
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Location = new Point(24, 32);
            this.lblNombre.AutoSize = true;

            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Location = new Point(100, 28);
            this.Txt_Nombre.Size = new Size(240, 23);
            this.Txt_Nombre.TabIndex = 0;

            // Apellido
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.Location = new Point(360, 32);
            this.lblApellido.AutoSize = true;

            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Location = new Point(430, 28);
            this.Txt_Apellido.Size = new Size(240, 23);
            this.Txt_Apellido.TabIndex = 1;

            // Tipo Doc
            this.lblTipoDoc.Text = "Documento:";
            this.lblTipoDoc.Location = new Point(24, 72);
            this.lblTipoDoc.AutoSize = true;

            this.Cbo_TipoDoc.Name = "Cbo_TipoDoc";
            this.Cbo_TipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Cbo_TipoDoc.Location = new Point(100, 68);
            this.Cbo_TipoDoc.Size = new Size(80, 23);
            this.Cbo_TipoDoc.TabIndex = 2;
            this.Cbo_TipoDoc.Items.AddRange(new object[] { "NIT", "CF" });
            this.Cbo_TipoDoc.SelectedIndexChanged += new System.EventHandler(this.Cbo_TipoDoc_SelectedIndexChanged);

            // Documento (NIT / CF)
            this.lblDocumento.Text = "NIT / CF:";
            this.lblDocumento.Location = new Point(200, 72);
            this.lblDocumento.AutoSize = true;

            this.Txt_Documento.Name = "Txt_Documento";
            this.Txt_Documento.Location = new Point(260, 68);
            this.Txt_Documento.Size = new Size(220, 23);
            this.Txt_Documento.TabIndex = 3;

            // Fecha
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.Location = new Point(500, 72);
            this.lblFecha.AutoSize = true;

            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Format = DateTimePickerFormat.Custom;
            this.Dtp_Fecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.Dtp_Fecha.Location = new Point(550, 68);
            this.Dtp_Fecha.Size = new Size(180, 23);
            this.Dtp_Fecha.TabIndex = 4;

            // Add controls to grpCliente
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

            // ======== grpFactura ========
            this.grpFactura.Text = "Resumen de Factura";
            this.grpFactura.Location = new Point(16, 172);
            this.grpFactura.Size = new Size(848, 300);
            this.grpFactura.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Total
            this.lblTotal.Text = "Total a Pagar (Q):";
            this.lblTotal.Location = new Point(24, 32);
            this.lblTotal.AutoSize = true;

            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.Location = new Point(140, 28);
            this.Txt_Total.Size = new Size(120, 23);
            this.Txt_Total.ReadOnly = true;
            this.Txt_Total.TabStop = false;

            // Dgv Detalle (solo lectura)
            this.Dgv_Detalle.Name = "Dgv_Detalle";
            this.Dgv_Detalle.Location = new Point(24, 64);
            this.Dgv_Detalle.Size = new Size(800, 216);
            this.Dgv_Detalle.AllowUserToAddRows = false;
            this.Dgv_Detalle.AllowUserToDeleteRows = false;
            this.Dgv_Detalle.ReadOnly = true;
            this.Dgv_Detalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.grpFactura.Controls.Add(this.lblTotal);
            this.grpFactura.Controls.Add(this.Txt_Total);
            this.grpFactura.Controls.Add(this.Dgv_Detalle);

            // ======== Botones ========
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new Size(110, 36);
            this.Btn_Guardar.Location = new Point(430, 488);
            this.Btn_Guardar.TabIndex = 5;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);

            this.Btn_Imprimir.Text = "Imprimir";
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new Size(110, 36);
            this.Btn_Imprimir.Location = new Point(550, 488);
            this.Btn_Imprimir.TabIndex = 6;
            this.Btn_Imprimir.Click += new System.EventHandler(this.Btn_Imprimir_Click);

            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new Size(110, 36);
            this.Btn_Cancelar.Location = new Point(670, 488);
            this.Btn_Cancelar.TabIndex = 7;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);

            // ======== Add al Form ========
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.grpFactura);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Imprimir);
            this.Controls.Add(this.Btn_Cancelar);

            this.ResumeLayout(false);
        }
    }
}
