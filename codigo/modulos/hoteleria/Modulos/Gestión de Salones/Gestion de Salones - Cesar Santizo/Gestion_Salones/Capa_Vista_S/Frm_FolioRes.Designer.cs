
namespace Capa_Vista_S
{
    partial class Frm_FolioRes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FolioRes));
            this.Lbl_MetodoPago = new System.Windows.Forms.Label();
            this.Lbl_EstadoPago = new System.Windows.Forms.Label();
            this.Txt_PagoTotal = new System.Windows.Forms.TextBox();
            this.Lbl_Pagototal = new System.Windows.Forms.Label();
            this.Dtp_FechaPago = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fechapago = new System.Windows.Forms.Label();
            this.salonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Hotel = new System.Windows.Forms.Label();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Folio = new System.Windows.Forms.Label();
            this.Dvg_Folios = new System.Windows.Forms.DataGridView();
            this.Pnl_Superior = new System.Windows.Forms.Panel();
            this.Msp_Menu = new System.Windows.Forms.MenuStrip();
            this.Lbl_Reserva = new System.Windows.Forms.Label();
            this.Cbo_Reservacion = new System.Windows.Forms.ComboBox();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Cbo_Metodo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Folios)).BeginInit();
            this.Pnl_Superior.SuspendLayout();
            this.Msp_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_MetodoPago
            // 
            this.Lbl_MetodoPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_MetodoPago.AutoSize = true;
            this.Lbl_MetodoPago.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_MetodoPago.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_MetodoPago.Location = new System.Drawing.Point(418, 198);
            this.Lbl_MetodoPago.Name = "Lbl_MetodoPago";
            this.Lbl_MetodoPago.Size = new System.Drawing.Size(115, 17);
            this.Lbl_MetodoPago.TabIndex = 181;
            this.Lbl_MetodoPago.Text = "Metodo De Pago";
            // 
            // Lbl_EstadoPago
            // 
            this.Lbl_EstadoPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_EstadoPago.AutoSize = true;
            this.Lbl_EstadoPago.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_EstadoPago.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_EstadoPago.Location = new System.Drawing.Point(420, 160);
            this.Lbl_EstadoPago.Name = "Lbl_EstadoPago";
            this.Lbl_EstadoPago.Size = new System.Drawing.Size(113, 17);
            this.Lbl_EstadoPago.TabIndex = 179;
            this.Lbl_EstadoPago.Text = "Estado Del Pago";
            // 
            // Txt_PagoTotal
            // 
            this.Txt_PagoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_PagoTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_PagoTotal.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_PagoTotal.Location = new System.Drawing.Point(162, 200);
            this.Txt_PagoTotal.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_PagoTotal.Name = "Txt_PagoTotal";
            this.Txt_PagoTotal.Size = new System.Drawing.Size(200, 23);
            this.Txt_PagoTotal.TabIndex = 178;
            // 
            // Lbl_Pagototal
            // 
            this.Lbl_Pagototal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Pagototal.AutoSize = true;
            this.Lbl_Pagototal.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Pagototal.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Pagototal.Location = new System.Drawing.Point(14, 200);
            this.Lbl_Pagototal.Name = "Lbl_Pagototal";
            this.Lbl_Pagototal.Size = new System.Drawing.Size(75, 17);
            this.Lbl_Pagototal.TabIndex = 177;
            this.Lbl_Pagototal.Text = "Pago Total";
            // 
            // Dtp_FechaPago
            // 
            this.Dtp_FechaPago.Checked = false;
            this.Dtp_FechaPago.Location = new System.Drawing.Point(162, 243);
            this.Dtp_FechaPago.Name = "Dtp_FechaPago";
            this.Dtp_FechaPago.Size = new System.Drawing.Size(200, 20);
            this.Dtp_FechaPago.TabIndex = 176;
            this.Dtp_FechaPago.Value = new System.DateTime(2025, 10, 31, 19, 11, 16, 0);
            // 
            // Lbl_Fechapago
            // 
            this.Lbl_Fechapago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Fechapago.AutoSize = true;
            this.Lbl_Fechapago.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Fechapago.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Fechapago.Location = new System.Drawing.Point(14, 246);
            this.Lbl_Fechapago.Name = "Lbl_Fechapago";
            this.Lbl_Fechapago.Size = new System.Drawing.Size(104, 17);
            this.Lbl_Fechapago.TabIndex = 175;
            this.Lbl_Fechapago.Text = "Fecha De Pago";
            // 
            // salonesToolStripMenuItem
            // 
            this.salonesToolStripMenuItem.Name = "salonesToolStripMenuItem";
            this.salonesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.salonesToolStripMenuItem.Text = "Salones";
            this.salonesToolStripMenuItem.Click += new System.EventHandler(this.salonesToolStripMenuItem_Click);
            // 
            // Lbl_Hotel
            // 
            this.Lbl_Hotel.AutoSize = true;
            this.Lbl_Hotel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Hotel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Hotel.Location = new System.Drawing.Point(21, 11);
            this.Lbl_Hotel.Name = "Lbl_Hotel";
            this.Lbl_Hotel.Size = new System.Drawing.Size(223, 23);
            this.Lbl_Hotel.TabIndex = 2;
            this.Lbl_Hotel.Text = "MODULO HOTELERIA";
            this.Lbl_Hotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_modificar.BackColor = System.Drawing.Color.White;
            this.Btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_modificar.Image")));
            this.Btn_modificar.Location = new System.Drawing.Point(855, 87);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(40, 37);
            this.Btn_modificar.TabIndex = 159;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click_1);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_eliminar.BackColor = System.Drawing.Color.White;
            this.Btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar.Image")));
            this.Btn_eliminar.Location = new System.Drawing.Point(811, 87);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(40, 37);
            this.Btn_eliminar.TabIndex = 158;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click_1);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_guardar.BackColor = System.Drawing.Color.White;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(767, 87);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(40, 37);
            this.Btn_guardar.TabIndex = 157;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click_1);
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Fecha.Location = new System.Drawing.Point(12, 211);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(0, 17);
            this.Lbl_Fecha.TabIndex = 154;
            // 
            // Lbl_Folio
            // 
            this.Lbl_Folio.AutoSize = true;
            this.Lbl_Folio.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Folio.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Folio.Location = new System.Drawing.Point(12, 97);
            this.Lbl_Folio.Name = "Lbl_Folio";
            this.Lbl_Folio.Size = new System.Drawing.Size(350, 27);
            this.Lbl_Folio.TabIndex = 153;
            this.Lbl_Folio.Text = "Datos De Folio, Reservaciones";
            // 
            // Dvg_Folios
            // 
            this.Dvg_Folios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dvg_Folios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_Folios.Location = new System.Drawing.Point(12, 329);
            this.Dvg_Folios.Name = "Dvg_Folios";
            this.Dvg_Folios.RowHeadersWidth = 51;
            this.Dvg_Folios.Size = new System.Drawing.Size(901, 293);
            this.Dvg_Folios.TabIndex = 152;
            this.Dvg_Folios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvg_Folios_CellClick);
            // 
            // Pnl_Superior
            // 
            this.Pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.Pnl_Superior.Controls.Add(this.Lbl_Hotel);
            this.Pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Superior.Location = new System.Drawing.Point(0, 24);
            this.Pnl_Superior.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_Superior.Name = "Pnl_Superior";
            this.Pnl_Superior.Size = new System.Drawing.Size(925, 52);
            this.Pnl_Superior.TabIndex = 151;
            // 
            // Msp_Menu
            // 
            this.Msp_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.Msp_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salonesToolStripMenuItem});
            this.Msp_Menu.Location = new System.Drawing.Point(0, 0);
            this.Msp_Menu.Name = "Msp_Menu";
            this.Msp_Menu.Size = new System.Drawing.Size(925, 24);
            this.Msp_Menu.TabIndex = 172;
            this.Msp_Menu.Text = "Msp_Menu";
            // 
            // Lbl_Reserva
            // 
            this.Lbl_Reserva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Reserva.AutoSize = true;
            this.Lbl_Reserva.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Reserva.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Reserva.Location = new System.Drawing.Point(14, 161);
            this.Lbl_Reserva.Name = "Lbl_Reserva";
            this.Lbl_Reserva.Size = new System.Drawing.Size(59, 17);
            this.Lbl_Reserva.TabIndex = 184;
            this.Lbl_Reserva.Text = "Reserva";
            // 
            // Cbo_Reservacion
            // 
            this.Cbo_Reservacion.FormattingEnabled = true;
            this.Cbo_Reservacion.Location = new System.Drawing.Point(162, 160);
            this.Cbo_Reservacion.Name = "Cbo_Reservacion";
            this.Cbo_Reservacion.Size = new System.Drawing.Size(200, 21);
            this.Cbo_Reservacion.TabIndex = 183;
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Location = new System.Drawing.Point(583, 157);
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(200, 21);
            this.Cbo_Estado.TabIndex = 185;
            // 
            // Cbo_Metodo
            // 
            this.Cbo_Metodo.FormattingEnabled = true;
            this.Cbo_Metodo.Location = new System.Drawing.Point(583, 197);
            this.Cbo_Metodo.Name = "Cbo_Metodo";
            this.Cbo_Metodo.Size = new System.Drawing.Size(200, 21);
            this.Cbo_Metodo.TabIndex = 186;
            // 
            // Frm_FolioRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 634);
            this.Controls.Add(this.Cbo_Metodo);
            this.Controls.Add(this.Cbo_Estado);
            this.Controls.Add(this.Lbl_Reserva);
            this.Controls.Add(this.Cbo_Reservacion);
            this.Controls.Add(this.Lbl_MetodoPago);
            this.Controls.Add(this.Lbl_EstadoPago);
            this.Controls.Add(this.Txt_PagoTotal);
            this.Controls.Add(this.Lbl_Pagototal);
            this.Controls.Add(this.Dtp_FechaPago);
            this.Controls.Add(this.Lbl_Fechapago);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.Lbl_Folio);
            this.Controls.Add(this.Dvg_Folios);
            this.Controls.Add(this.Pnl_Superior);
            this.Controls.Add(this.Msp_Menu);
            this.Name = "Frm_FolioRes";
            this.Text = "Frm_FolioRes";
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Folios)).EndInit();
            this.Pnl_Superior.ResumeLayout(false);
            this.Pnl_Superior.PerformLayout();
            this.Msp_Menu.ResumeLayout(false);
            this.Msp_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_MetodoPago;
        private System.Windows.Forms.Label Lbl_EstadoPago;
        private System.Windows.Forms.TextBox Txt_PagoTotal;
        private System.Windows.Forms.Label Lbl_Pagototal;
        private System.Windows.Forms.DateTimePicker Dtp_FechaPago;
        private System.Windows.Forms.Label Lbl_Fechapago;
        private System.Windows.Forms.ToolStripMenuItem salonesToolStripMenuItem;
        private System.Windows.Forms.Label Lbl_Hotel;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_Folio;
        private System.Windows.Forms.DataGridView Dvg_Folios;
        private System.Windows.Forms.Panel Pnl_Superior;
        private System.Windows.Forms.MenuStrip Msp_Menu;
        private System.Windows.Forms.Label Lbl_Reserva;
        private System.Windows.Forms.ComboBox Cbo_Reservacion;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.ComboBox Cbo_Metodo;
    }
}