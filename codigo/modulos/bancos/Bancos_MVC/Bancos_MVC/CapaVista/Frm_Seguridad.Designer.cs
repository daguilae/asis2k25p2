namespace Capa_Vista_Bancos
{
    partial class Frm_Seguridad
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Aplicacion = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesOTransaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Bitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.conciliaciónBancariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generaciónDePólizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibilidadDiariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorizaciónOrdenesDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generaciónChequesDePlanillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesBancariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pnl_Superior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Pic_Cerrar = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Pnl_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 477);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(3, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1069, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.catálogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 47);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(0, 503);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 1069, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1641, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "MenuStrip";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 10F);
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Salir";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // catálogosToolStripMenuItem
            // 
            this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem1,
            this.usuariosToolStripMenuItem,
            this.perfilesToolStripMenuItem,
            this.modulosToolStripMenuItem,
            this.Btn_Aplicacion,
            this.operacionesOTransaccionesToolStripMenuItem});
            this.catálogosToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 10F);
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.catálogosToolStripMenuItem.Text = "Catálogos";
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(325, 26);
            this.empleadosToolStripMenuItem1.Text = "Bancos";
            this.empleadosToolStripMenuItem1.Click += new System.EventHandler(this.empleadosToolStripMenuItem1_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.usuariosToolStripMenuItem.Text = "Monedas";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // perfilesToolStripMenuItem
            // 
            this.perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            this.perfilesToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.perfilesToolStripMenuItem.Text = "Tipo de Cambio";
            this.perfilesToolStripMenuItem.Click += new System.EventHandler(this.perfilesToolStripMenuItem_Click_1);
            // 
            // modulosToolStripMenuItem
            // 
            this.modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            this.modulosToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.modulosToolStripMenuItem.Text = "Cuentas Bancarias";
            this.modulosToolStripMenuItem.Click += new System.EventHandler(this.modulosToolStripMenuItem_Click);
            // 
            // Btn_Aplicacion
            // 
            this.Btn_Aplicacion.Name = "Btn_Aplicacion";
            this.Btn_Aplicacion.Size = new System.Drawing.Size(325, 26);
            this.Btn_Aplicacion.Text = "Tipo de Pago";
            this.Btn_Aplicacion.Click += new System.EventHandler(this.Btn_Aplicacion_Click_1);
            // 
            // operacionesOTransaccionesToolStripMenuItem
            // 
            this.operacionesOTransaccionesToolStripMenuItem.Name = "operacionesOTransaccionesToolStripMenuItem";
            this.operacionesOTransaccionesToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.operacionesOTransaccionesToolStripMenuItem.Text = "Operaciones o transacciones ";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Bitacora,
            this.conciliaciónBancariaToolStripMenuItem,
            this.generaciónDePólizaToolStripMenuItem,
            this.disponibilidadDiariaToolStripMenuItem,
            this.autorizaciónOrdenesDeComprasToolStripMenuItem,
            this.generaciónChequesDePlanillaToolStripMenuItem,
            this.reportesBancariosToolStripMenuItem});
            this.procesosToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 10F);
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // Btn_Bitacora
            // 
            this.Btn_Bitacora.Name = "Btn_Bitacora";
            this.Btn_Bitacora.Size = new System.Drawing.Size(365, 26);
            this.Btn_Bitacora.Text = "Movimientos Bancarios";
            this.Btn_Bitacora.Click += new System.EventHandler(this.Btn_Bitacora_Click);
            // 
            // conciliaciónBancariaToolStripMenuItem
            // 
            this.conciliaciónBancariaToolStripMenuItem.Name = "conciliaciónBancariaToolStripMenuItem";
            this.conciliaciónBancariaToolStripMenuItem.Size = new System.Drawing.Size(365, 26);
            this.conciliaciónBancariaToolStripMenuItem.Text = "Conciliación Bancaria";
            this.conciliaciónBancariaToolStripMenuItem.Click += new System.EventHandler(this.conciliaciónBancariaToolStripMenuItem_Click);
            // 
            // generaciónDePólizaToolStripMenuItem
            // 
            this.generaciónDePólizaToolStripMenuItem.Name = "generaciónDePólizaToolStripMenuItem";
            this.generaciónDePólizaToolStripMenuItem.Size = new System.Drawing.Size(365, 26);
            this.generaciónDePólizaToolStripMenuItem.Text = "Generación de Póliza";
            this.generaciónDePólizaToolStripMenuItem.Click += new System.EventHandler(this.generaciónDePólizaToolStripMenuItem_Click);
            // 
            // disponibilidadDiariaToolStripMenuItem
            // 
            this.disponibilidadDiariaToolStripMenuItem.Name = "disponibilidadDiariaToolStripMenuItem";
            this.disponibilidadDiariaToolStripMenuItem.Size = new System.Drawing.Size(365, 26);
            this.disponibilidadDiariaToolStripMenuItem.Text = "Disponibilidad Diaria";
            // 
            // autorizaciónOrdenesDeComprasToolStripMenuItem
            // 
            this.autorizaciónOrdenesDeComprasToolStripMenuItem.Name = "autorizaciónOrdenesDeComprasToolStripMenuItem";
            this.autorizaciónOrdenesDeComprasToolStripMenuItem.Size = new System.Drawing.Size(365, 26);
            this.autorizaciónOrdenesDeComprasToolStripMenuItem.Text = "Autorización Ordenes de Compras";
            this.autorizaciónOrdenesDeComprasToolStripMenuItem.Click += new System.EventHandler(this.autorizaciónOrdenesDeComprasToolStripMenuItem_Click);
            // 
            // generaciónChequesDePlanillaToolStripMenuItem
            // 
            this.generaciónChequesDePlanillaToolStripMenuItem.Name = "generaciónChequesDePlanillaToolStripMenuItem";
            this.generaciónChequesDePlanillaToolStripMenuItem.Size = new System.Drawing.Size(365, 26);
            this.generaciónChequesDePlanillaToolStripMenuItem.Text = "Generación Cheques de Planilla";
            // 
            // reportesBancariosToolStripMenuItem
            // 
            this.reportesBancariosToolStripMenuItem.Name = "reportesBancariosToolStripMenuItem";
            this.reportesBancariosToolStripMenuItem.Size = new System.Drawing.Size(365, 26);
            this.reportesBancariosToolStripMenuItem.Text = "Reportes Bancarios";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem});
            this.herramientasToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 10F);
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.herramientasToolStripMenuItem.Text = "&Herramientas";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.optionsToolStripMenuItem.Text = "&Opciones";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // Pnl_Superior
            // 
            this.Pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(76)))));
            this.Pnl_Superior.Controls.Add(this.label1);
            this.Pnl_Superior.Controls.Add(this.Pic_Cerrar);
            this.Pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Superior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_Superior.Name = "Pnl_Superior";
            this.Pnl_Superior.Size = new System.Drawing.Size(1069, 44);
            this.Pnl_Superior.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bancos";
            // 
            // Pic_Cerrar
            // 
            this.Pic_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pic_Cerrar.Image = global::Capa_Vista_Bancos.Properties.Resources.Cancel_icon_icons_com_73703;
            this.Pic_Cerrar.Location = new System.Drawing.Point(1032, 0);
            this.Pic_Cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pic_Cerrar.Name = "Pic_Cerrar";
            this.Pic_Cerrar.Size = new System.Drawing.Size(37, 44);
            this.Pic_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Cerrar.TabIndex = 0;
            this.Pic_Cerrar.TabStop = false;
            this.Pic_Cerrar.Click += new System.EventHandler(this.Pic_Cerrar_Click);
            // 
            // Frm_Seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 503);
            this.Controls.Add(this.Pnl_Superior);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_Seguridad";
            this.Text = "frmSeguridad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Pnl_Superior.ResumeLayout(false);
            this.Pnl_Superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Btn_Aplicacion;
        private System.Windows.Forms.ToolStripMenuItem Btn_Bitacora;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.Panel Pnl_Superior;
        private System.Windows.Forms.PictureBox Pic_Cerrar;
        private System.Windows.Forms.ToolStripMenuItem conciliaciónBancariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generaciónDePólizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disponibilidadDiariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorizaciónOrdenesDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generaciónChequesDePlanillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesBancariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesOTransaccionesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}
