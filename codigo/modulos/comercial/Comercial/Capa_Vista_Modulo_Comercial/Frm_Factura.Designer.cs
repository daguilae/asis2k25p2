
namespace Capa_Vista_Modulo_Comercial
{
    partial class Frm_Factura
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Ingresar = new System.Windows.Forms.ToolStripButton();
            this.Btn_Refrescar = new System.Windows.Forms.ToolStripButton();
            this.Btn_Cancelar = new System.Windows.Forms.ToolStripButton();
            this.Btn_Salir = new System.Windows.Forms.ToolStripButton();
            this.Gpb_Generador = new System.Windows.Forms.GroupBox();
            this.Cbo_Moneda = new System.Windows.Forms.ComboBox();
            this.Txt_Impuesto = new System.Windows.Forms.TextBox();
            this.Txt_Factor = new System.Windows.Forms.TextBox();
            this.Lbl_Impuesto = new System.Windows.Forms.Label();
            this.Lbl_Factor = new System.Windows.Forms.Label();
            this.Lbl_Cliente = new System.Windows.Forms.Label();
            this.Txt_Cliente = new System.Windows.Forms.TextBox();
            this.Txt_Serie = new System.Windows.Forms.TextBox();
            this.Dtp_FechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Lbl_FechaVencimiento = new System.Windows.Forms.Label();
            this.Lbl_Moneda = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Serie = new System.Windows.Forms.Label();
            this.Gpb_Producto = new System.Windows.Forms.GroupBox();
            this.Btn_Quitar = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Txt_PrecioU = new System.Windows.Forms.TextBox();
            this.Txt_Costo = new System.Windows.Forms.TextBox();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Txt_Medida = new System.Windows.Forms.TextBox();
            this.Txt_Almacen = new System.Windows.Forms.TextBox();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Lbl_PrecioU = new System.Windows.Forms.Label();
            this.Lbl_Costo = new System.Windows.Forms.Label();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Lbl_Medida = new System.Windows.Forms.Label();
            this.Lbl_Almacen = new System.Windows.Forms.Label();
            this.Lbl_Codigo = new System.Windows.Forms.Label();
            this.Dgv_Detalle = new System.Windows.Forms.DataGridView();
            this.Clm_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Costo_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Precio_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_Detalle = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.Gpb_Generador.SuspendLayout();
            this.Gpb_Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Ingresar,
            this.Btn_Refrescar,
            this.Btn_Cancelar,
            this.Btn_Salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1047, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(66, 24);
            this.Btn_Ingresar.Text = "Ingresar";
            // 
            // Btn_Refrescar
            // 
            this.Btn_Refrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_Refrescar.Name = "Btn_Refrescar";
            this.Btn_Refrescar.Size = new System.Drawing.Size(74, 24);
            this.Btn_Refrescar.Text = "Refrescar";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(70, 24);
            this.Btn_Cancelar.Text = "Cancelar";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(42, 24);
            this.Btn_Salir.Text = "Salir";
            // 
            // Gpb_Generador
            // 
            this.Gpb_Generador.Controls.Add(this.Cbo_Moneda);
            this.Gpb_Generador.Controls.Add(this.Txt_Impuesto);
            this.Gpb_Generador.Controls.Add(this.Txt_Factor);
            this.Gpb_Generador.Controls.Add(this.Lbl_Impuesto);
            this.Gpb_Generador.Controls.Add(this.Lbl_Factor);
            this.Gpb_Generador.Controls.Add(this.Lbl_Cliente);
            this.Gpb_Generador.Controls.Add(this.Txt_Cliente);
            this.Gpb_Generador.Controls.Add(this.Txt_Serie);
            this.Gpb_Generador.Controls.Add(this.Dtp_FechaVencimiento);
            this.Gpb_Generador.Controls.Add(this.Dtp_Fecha);
            this.Gpb_Generador.Controls.Add(this.Lbl_FechaVencimiento);
            this.Gpb_Generador.Controls.Add(this.Lbl_Moneda);
            this.Gpb_Generador.Controls.Add(this.Lbl_Fecha);
            this.Gpb_Generador.Controls.Add(this.Lbl_Serie);
            this.Gpb_Generador.Location = new System.Drawing.Point(12, 48);
            this.Gpb_Generador.Name = "Gpb_Generador";
            this.Gpb_Generador.Size = new System.Drawing.Size(904, 233);
            this.Gpb_Generador.TabIndex = 1;
            this.Gpb_Generador.TabStop = false;
            this.Gpb_Generador.Text = "Generar Factura";
            // 
            // Cbo_Moneda
            // 
            this.Cbo_Moneda.FormattingEnabled = true;
            this.Cbo_Moneda.Location = new System.Drawing.Point(82, 109);
            this.Cbo_Moneda.Name = "Cbo_Moneda";
            this.Cbo_Moneda.Size = new System.Drawing.Size(121, 24);
            this.Cbo_Moneda.TabIndex = 13;
            // 
            // Txt_Impuesto
            // 
            this.Txt_Impuesto.Location = new System.Drawing.Point(98, 172);
            this.Txt_Impuesto.Name = "Txt_Impuesto";
            this.Txt_Impuesto.Size = new System.Drawing.Size(100, 22);
            this.Txt_Impuesto.TabIndex = 12;
            // 
            // Txt_Factor
            // 
            this.Txt_Factor.Location = new System.Drawing.Point(598, 118);
            this.Txt_Factor.Name = "Txt_Factor";
            this.Txt_Factor.Size = new System.Drawing.Size(100, 22);
            this.Txt_Factor.TabIndex = 11;
            // 
            // Lbl_Impuesto
            // 
            this.Lbl_Impuesto.AutoSize = true;
            this.Lbl_Impuesto.Location = new System.Drawing.Point(16, 175);
            this.Lbl_Impuesto.Name = "Lbl_Impuesto";
            this.Lbl_Impuesto.Size = new System.Drawing.Size(65, 17);
            this.Lbl_Impuesto.TabIndex = 10;
            this.Lbl_Impuesto.Text = "Impuesto";
            // 
            // Lbl_Factor
            // 
            this.Lbl_Factor.AutoSize = true;
            this.Lbl_Factor.Location = new System.Drawing.Point(528, 118);
            this.Lbl_Factor.Name = "Lbl_Factor";
            this.Lbl_Factor.Size = new System.Drawing.Size(48, 17);
            this.Lbl_Factor.TabIndex = 9;
            this.Lbl_Factor.Text = "Factor";
            // 
            // Lbl_Cliente
            // 
            this.Lbl_Cliente.AutoSize = true;
            this.Lbl_Cliente.Location = new System.Drawing.Point(225, 116);
            this.Lbl_Cliente.Name = "Lbl_Cliente";
            this.Lbl_Cliente.Size = new System.Drawing.Size(51, 17);
            this.Lbl_Cliente.TabIndex = 8;
            this.Lbl_Cliente.Text = "Cliente";
            // 
            // Txt_Cliente
            // 
            this.Txt_Cliente.Location = new System.Drawing.Point(290, 113);
            this.Txt_Cliente.Name = "Txt_Cliente";
            this.Txt_Cliente.Size = new System.Drawing.Size(100, 22);
            this.Txt_Cliente.TabIndex = 7;
            // 
            // Txt_Serie
            // 
            this.Txt_Serie.Location = new System.Drawing.Point(73, 44);
            this.Txt_Serie.Name = "Txt_Serie";
            this.Txt_Serie.Size = new System.Drawing.Size(100, 22);
            this.Txt_Serie.TabIndex = 6;
            // 
            // Dtp_FechaVencimiento
            // 
            this.Dtp_FechaVencimiento.Location = new System.Drawing.Point(679, 51);
            this.Dtp_FechaVencimiento.Name = "Dtp_FechaVencimiento";
            this.Dtp_FechaVencimiento.Size = new System.Drawing.Size(200, 22);
            this.Dtp_FechaVencimiento.TabIndex = 5;
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Location = new System.Drawing.Point(290, 47);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(200, 22);
            this.Dtp_Fecha.TabIndex = 4;
            // 
            // Lbl_FechaVencimiento
            // 
            this.Lbl_FechaVencimiento.AutoSize = true;
            this.Lbl_FechaVencimiento.Location = new System.Drawing.Point(528, 51);
            this.Lbl_FechaVencimiento.Name = "Lbl_FechaVencimiento";
            this.Lbl_FechaVencimiento.Size = new System.Drawing.Size(128, 17);
            this.Lbl_FechaVencimiento.TabIndex = 3;
            this.Lbl_FechaVencimiento.Text = "Fecha Vencimiento";
            // 
            // Lbl_Moneda
            // 
            this.Lbl_Moneda.AutoSize = true;
            this.Lbl_Moneda.Location = new System.Drawing.Point(16, 113);
            this.Lbl_Moneda.Name = "Lbl_Moneda";
            this.Lbl_Moneda.Size = new System.Drawing.Size(59, 17);
            this.Lbl_Moneda.TabIndex = 2;
            this.Lbl_Moneda.Text = "Moneda";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Location = new System.Drawing.Point(225, 47);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(47, 17);
            this.Lbl_Fecha.TabIndex = 1;
            this.Lbl_Fecha.Text = "Fecha";
            // 
            // Lbl_Serie
            // 
            this.Lbl_Serie.AutoSize = true;
            this.Lbl_Serie.Location = new System.Drawing.Point(16, 47);
            this.Lbl_Serie.Name = "Lbl_Serie";
            this.Lbl_Serie.Size = new System.Drawing.Size(41, 17);
            this.Lbl_Serie.TabIndex = 0;
            this.Lbl_Serie.Text = "Serie";
            // 
            // Gpb_Producto
            // 
            this.Gpb_Producto.Controls.Add(this.Btn_Quitar);
            this.Gpb_Producto.Controls.Add(this.Btn_Aceptar);
            this.Gpb_Producto.Controls.Add(this.Txt_PrecioU);
            this.Gpb_Producto.Controls.Add(this.Txt_Costo);
            this.Gpb_Producto.Controls.Add(this.Txt_Cantidad);
            this.Gpb_Producto.Controls.Add(this.Txt_Medida);
            this.Gpb_Producto.Controls.Add(this.Txt_Almacen);
            this.Gpb_Producto.Controls.Add(this.Txt_Codigo);
            this.Gpb_Producto.Controls.Add(this.Lbl_PrecioU);
            this.Gpb_Producto.Controls.Add(this.Lbl_Costo);
            this.Gpb_Producto.Controls.Add(this.Lbl_Cantidad);
            this.Gpb_Producto.Controls.Add(this.Lbl_Medida);
            this.Gpb_Producto.Controls.Add(this.Lbl_Almacen);
            this.Gpb_Producto.Controls.Add(this.Lbl_Codigo);
            this.Gpb_Producto.Location = new System.Drawing.Point(12, 299);
            this.Gpb_Producto.Name = "Gpb_Producto";
            this.Gpb_Producto.Size = new System.Drawing.Size(904, 255);
            this.Gpb_Producto.TabIndex = 2;
            this.Gpb_Producto.TabStop = false;
            this.Gpb_Producto.Text = "Producto";
            // 
            // Btn_Quitar
            // 
            this.Btn_Quitar.Location = new System.Drawing.Point(482, 167);
            this.Btn_Quitar.Name = "Btn_Quitar";
            this.Btn_Quitar.Size = new System.Drawing.Size(174, 57);
            this.Btn_Quitar.TabIndex = 14;
            this.Btn_Quitar.Text = "Quitar";
            this.Btn_Quitar.UseVisualStyleBackColor = true;
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Location = new System.Drawing.Point(170, 167);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(174, 57);
            this.Btn_Aceptar.TabIndex = 13;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // Txt_PrecioU
            // 
            this.Txt_PrecioU.Location = new System.Drawing.Point(705, 109);
            this.Txt_PrecioU.Name = "Txt_PrecioU";
            this.Txt_PrecioU.Size = new System.Drawing.Size(100, 22);
            this.Txt_PrecioU.TabIndex = 12;
            // 
            // Txt_Costo
            // 
            this.Txt_Costo.Location = new System.Drawing.Point(579, 109);
            this.Txt_Costo.Name = "Txt_Costo";
            this.Txt_Costo.Size = new System.Drawing.Size(100, 22);
            this.Txt_Costo.TabIndex = 11;
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Location = new System.Drawing.Point(442, 109);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(100, 22);
            this.Txt_Cantidad.TabIndex = 10;
            // 
            // Txt_Medida
            // 
            this.Txt_Medida.Location = new System.Drawing.Point(307, 109);
            this.Txt_Medida.Name = "Txt_Medida";
            this.Txt_Medida.Size = new System.Drawing.Size(100, 22);
            this.Txt_Medida.TabIndex = 9;
            // 
            // Txt_Almacen
            // 
            this.Txt_Almacen.Location = new System.Drawing.Point(141, 109);
            this.Txt_Almacen.Name = "Txt_Almacen";
            this.Txt_Almacen.Size = new System.Drawing.Size(100, 22);
            this.Txt_Almacen.TabIndex = 8;
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(0, 109);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(100, 22);
            this.Txt_Codigo.TabIndex = 7;
            // 
            // Lbl_PrecioU
            // 
            this.Lbl_PrecioU.AutoSize = true;
            this.Lbl_PrecioU.Location = new System.Drawing.Point(702, 56);
            this.Lbl_PrecioU.Name = "Lbl_PrecioU";
            this.Lbl_PrecioU.Size = new System.Drawing.Size(101, 17);
            this.Lbl_PrecioU.TabIndex = 6;
            this.Lbl_PrecioU.Text = "Precio Unitario";
            // 
            // Lbl_Costo
            // 
            this.Lbl_Costo.AutoSize = true;
            this.Lbl_Costo.Location = new System.Drawing.Point(588, 56);
            this.Lbl_Costo.Name = "Lbl_Costo";
            this.Lbl_Costo.Size = new System.Drawing.Size(80, 17);
            this.Lbl_Costo.TabIndex = 5;
            this.Lbl_Costo.Text = "Costo Total";
            // 
            // Lbl_Cantidad
            // 
            this.Lbl_Cantidad.AutoSize = true;
            this.Lbl_Cantidad.Location = new System.Drawing.Point(458, 56);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(64, 17);
            this.Lbl_Cantidad.TabIndex = 4;
            this.Lbl_Cantidad.Text = "Cantidad";
            // 
            // Lbl_Medida
            // 
            this.Lbl_Medida.AutoSize = true;
            this.Lbl_Medida.Location = new System.Drawing.Point(304, 56);
            this.Lbl_Medida.Name = "Lbl_Medida";
            this.Lbl_Medida.Size = new System.Drawing.Size(115, 17);
            this.Lbl_Medida.TabIndex = 3;
            this.Lbl_Medida.Text = "Medida Producto";
            // 
            // Lbl_Almacen
            // 
            this.Lbl_Almacen.AutoSize = true;
            this.Lbl_Almacen.Location = new System.Drawing.Point(167, 56);
            this.Lbl_Almacen.Name = "Lbl_Almacen";
            this.Lbl_Almacen.Size = new System.Drawing.Size(62, 17);
            this.Lbl_Almacen.TabIndex = 2;
            this.Lbl_Almacen.Text = "Almacen";
            // 
            // Lbl_Codigo
            // 
            this.Lbl_Codigo.AutoSize = true;
            this.Lbl_Codigo.Location = new System.Drawing.Point(16, 56);
            this.Lbl_Codigo.Name = "Lbl_Codigo";
            this.Lbl_Codigo.Size = new System.Drawing.Size(52, 17);
            this.Lbl_Codigo.TabIndex = 1;
            this.Lbl_Codigo.Text = "Codigo";
            // 
            // Dgv_Detalle
            // 
            this.Dgv_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Detalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clm_Codigo,
            this.Clm_Producto,
            this.Clm_Cantidad,
            this.Clm_Costo_Total,
            this.Clm_Precio_Total});
            this.Dgv_Detalle.Location = new System.Drawing.Point(13, 655);
            this.Dgv_Detalle.Name = "Dgv_Detalle";
            this.Dgv_Detalle.RowHeadersWidth = 51;
            this.Dgv_Detalle.RowTemplate.Height = 24;
            this.Dgv_Detalle.Size = new System.Drawing.Size(697, 195);
            this.Dgv_Detalle.TabIndex = 3;
            // 
            // Clm_Codigo
            // 
            this.Clm_Codigo.HeaderText = "Codigo";
            this.Clm_Codigo.MinimumWidth = 6;
            this.Clm_Codigo.Name = "Clm_Codigo";
            this.Clm_Codigo.Width = 125;
            // 
            // Clm_Producto
            // 
            this.Clm_Producto.HeaderText = "Producto";
            this.Clm_Producto.MinimumWidth = 6;
            this.Clm_Producto.Name = "Clm_Producto";
            this.Clm_Producto.Width = 125;
            // 
            // Clm_Cantidad
            // 
            this.Clm_Cantidad.HeaderText = "Cantidad";
            this.Clm_Cantidad.MinimumWidth = 6;
            this.Clm_Cantidad.Name = "Clm_Cantidad";
            this.Clm_Cantidad.Width = 125;
            // 
            // Clm_Costo_Total
            // 
            this.Clm_Costo_Total.HeaderText = "Costo Total";
            this.Clm_Costo_Total.MinimumWidth = 6;
            this.Clm_Costo_Total.Name = "Clm_Costo_Total";
            this.Clm_Costo_Total.Width = 125;
            // 
            // Clm_Precio_Total
            // 
            this.Clm_Precio_Total.HeaderText = "Precio Total";
            this.Clm_Precio_Total.MinimumWidth = 6;
            this.Clm_Precio_Total.Name = "Clm_Precio_Total";
            this.Clm_Precio_Total.Width = 125;
            // 
            // Lbl_Detalle
            // 
            this.Lbl_Detalle.AutoSize = true;
            this.Lbl_Detalle.Location = new System.Drawing.Point(12, 609);
            this.Lbl_Detalle.Name = "Lbl_Detalle";
            this.Lbl_Detalle.Size = new System.Drawing.Size(149, 17);
            this.Lbl_Detalle.TabIndex = 4;
            this.Lbl_Detalle.Text = "Detalle De Movimiento";
            // 
            // Frm_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1047, 873);
            this.Controls.Add(this.Lbl_Detalle);
            this.Controls.Add(this.Dgv_Detalle);
            this.Controls.Add(this.Gpb_Producto);
            this.Controls.Add(this.Gpb_Generador);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_Factura";
            this.Text = "Frm_Factura";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Gpb_Generador.ResumeLayout(false);
            this.Gpb_Generador.PerformLayout();
            this.Gpb_Producto.ResumeLayout(false);
            this.Gpb_Producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Btn_Ingresar;
        private System.Windows.Forms.ToolStripButton Btn_Refrescar;
        private System.Windows.Forms.ToolStripButton Btn_Cancelar;
        private System.Windows.Forms.ToolStripButton Btn_Salir;
        private System.Windows.Forms.GroupBox Gpb_Generador;
        private System.Windows.Forms.ComboBox Cbo_Moneda;
        private System.Windows.Forms.TextBox Txt_Impuesto;
        private System.Windows.Forms.TextBox Txt_Factor;
        private System.Windows.Forms.Label Lbl_Impuesto;
        private System.Windows.Forms.Label Lbl_Factor;
        private System.Windows.Forms.Label Lbl_Cliente;
        private System.Windows.Forms.TextBox Txt_Cliente;
        private System.Windows.Forms.TextBox Txt_Serie;
        private System.Windows.Forms.DateTimePicker Dtp_FechaVencimiento;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        private System.Windows.Forms.Label Lbl_FechaVencimiento;
        private System.Windows.Forms.Label Lbl_Moneda;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_Serie;
        private System.Windows.Forms.GroupBox Gpb_Producto;
        private System.Windows.Forms.Button Btn_Quitar;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.TextBox Txt_PrecioU;
        private System.Windows.Forms.TextBox Txt_Costo;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.TextBox Txt_Medida;
        private System.Windows.Forms.TextBox Txt_Almacen;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Label Lbl_PrecioU;
        private System.Windows.Forms.Label Lbl_Costo;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.Label Lbl_Medida;
        private System.Windows.Forms.Label Lbl_Almacen;
        private System.Windows.Forms.Label Lbl_Codigo;
        private System.Windows.Forms.DataGridView Dgv_Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Costo_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Precio_Total;
        private System.Windows.Forms.Label Lbl_Detalle;
    }
}