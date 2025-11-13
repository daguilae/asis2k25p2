
namespace Capa_Vista_Facturas
{
    partial class Frm_Venta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pnl_Producto = new System.Windows.Forms.Panel();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Txt_Efectivo = new System.Windows.Forms.TextBox();
            this.Txt_IngresoCantidad = new System.Windows.Forms.TextBox();
            this.Cbo_Producto = new System.Windows.Forms.ComboBox();
            this.Lbl_IngresoDevolucion = new System.Windows.Forms.Label();
            this.Lbl_Devolucion = new System.Windows.Forms.Label();
            this.Lbl_Efectivo = new System.Windows.Forms.Label();
            this.Lbl_TotalPagar = new System.Windows.Forms.Label();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Lbl_IngresoNombre = new System.Windows.Forms.Label();
            this.Lbl_IngresoCodigo = new System.Windows.Forms.Label();
            this.Lbl_IngresoPrecio = new System.Windows.Forms.Label();
            this.Lbl_Precio = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Lbl_Codigo = new System.Windows.Forms.Label();
            this.Lbl_Producto = new System.Windows.Forms.Label();
            this.Dgv_Lista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Vender = new System.Windows.Forms.Button();
            this.Lbl_Factura = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listadoDeFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pnl_Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Lista)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Producto
            // 
            this.Pnl_Producto.BackColor = System.Drawing.Color.White;
            this.Pnl_Producto.Controls.Add(this.Btn_Eliminar);
            this.Pnl_Producto.Controls.Add(this.Btn_Agregar);
            this.Pnl_Producto.Controls.Add(this.Txt_Efectivo);
            this.Pnl_Producto.Controls.Add(this.Txt_IngresoCantidad);
            this.Pnl_Producto.Controls.Add(this.Cbo_Producto);
            this.Pnl_Producto.Controls.Add(this.Lbl_IngresoDevolucion);
            this.Pnl_Producto.Controls.Add(this.Lbl_Devolucion);
            this.Pnl_Producto.Controls.Add(this.Lbl_Efectivo);
            this.Pnl_Producto.Controls.Add(this.Lbl_TotalPagar);
            this.Pnl_Producto.Controls.Add(this.Lbl_Total);
            this.Pnl_Producto.Controls.Add(this.Lbl_Cantidad);
            this.Pnl_Producto.Controls.Add(this.Lbl_IngresoNombre);
            this.Pnl_Producto.Controls.Add(this.Lbl_IngresoCodigo);
            this.Pnl_Producto.Controls.Add(this.Lbl_IngresoPrecio);
            this.Pnl_Producto.Controls.Add(this.Lbl_Precio);
            this.Pnl_Producto.Controls.Add(this.Lbl_Nombre);
            this.Pnl_Producto.Controls.Add(this.Lbl_Codigo);
            this.Pnl_Producto.Controls.Add(this.Lbl_Producto);
            this.Pnl_Producto.Controls.Add(this.Dgv_Lista);
            this.Pnl_Producto.Location = new System.Drawing.Point(50, 85);
            this.Pnl_Producto.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_Producto.Name = "Pnl_Producto";
            this.Pnl_Producto.Size = new System.Drawing.Size(699, 604);
            this.Pnl_Producto.TabIndex = 0;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Eliminar.Location = new System.Drawing.Point(476, 152);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(181, 74);
            this.Btn_Eliminar.TabIndex = 18;
            this.Btn_Eliminar.Text = "ELIMINAR";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Agregar.Location = new System.Drawing.Point(476, 60);
            this.Btn_Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(181, 74);
            this.Btn_Agregar.TabIndex = 17;
            this.Btn_Agregar.Text = "AGREGAR";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // Txt_Efectivo
            // 
            this.Txt_Efectivo.Location = new System.Drawing.Point(280, 541);
            this.Txt_Efectivo.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Efectivo.Name = "Txt_Efectivo";
            this.Txt_Efectivo.Size = new System.Drawing.Size(124, 27);
            this.Txt_Efectivo.TabIndex = 16;
            // 
            // Txt_IngresoCantidad
            // 
            this.Txt_IngresoCantidad.Location = new System.Drawing.Point(240, 209);
            this.Txt_IngresoCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_IngresoCantidad.Name = "Txt_IngresoCantidad";
            this.Txt_IngresoCantidad.Size = new System.Drawing.Size(124, 27);
            this.Txt_IngresoCantidad.TabIndex = 15;
            // 
            // Cbo_Producto
            // 
            this.Cbo_Producto.FormattingEnabled = true;
            this.Cbo_Producto.Items.AddRange(new object[] {
            "Desayunos",
            "Almuerzos",
            "Cenas",
            "Bebidas",
            "Licores",
            "Postres"});
            this.Cbo_Producto.Location = new System.Drawing.Point(229, 22);
            this.Cbo_Producto.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Producto.Name = "Cbo_Producto";
            this.Cbo_Producto.Size = new System.Drawing.Size(234, 28);
            this.Cbo_Producto.TabIndex = 14;
            // 
            // Lbl_IngresoDevolucion
            // 
            this.Lbl_IngresoDevolucion.AutoSize = true;
            this.Lbl_IngresoDevolucion.Location = new System.Drawing.Point(533, 541);
            this.Lbl_IngresoDevolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IngresoDevolucion.Name = "Lbl_IngresoDevolucion";
            this.Lbl_IngresoDevolucion.Size = new System.Drawing.Size(15, 20);
            this.Lbl_IngresoDevolucion.TabIndex = 13;
            this.Lbl_IngresoDevolucion.Text = "-";
            // 
            // Lbl_Devolucion
            // 
            this.Lbl_Devolucion.AutoSize = true;
            this.Lbl_Devolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Devolucion.Location = new System.Drawing.Point(487, 505);
            this.Lbl_Devolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Devolucion.Name = "Lbl_Devolucion";
            this.Lbl_Devolucion.Size = new System.Drawing.Size(113, 17);
            this.Lbl_Devolucion.TabIndex = 12;
            this.Lbl_Devolucion.Text = "DEVOLUCIÓN:";
            // 
            // Lbl_Efectivo
            // 
            this.Lbl_Efectivo.AutoSize = true;
            this.Lbl_Efectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Efectivo.Location = new System.Drawing.Point(305, 505);
            this.Lbl_Efectivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Efectivo.Name = "Lbl_Efectivo";
            this.Lbl_Efectivo.Size = new System.Drawing.Size(88, 17);
            this.Lbl_Efectivo.TabIndex = 11;
            this.Lbl_Efectivo.Text = "EFECTIVO:";
            // 
            // Lbl_TotalPagar
            // 
            this.Lbl_TotalPagar.AutoSize = true;
            this.Lbl_TotalPagar.Location = new System.Drawing.Point(151, 541);
            this.Lbl_TotalPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_TotalPagar.Name = "Lbl_TotalPagar";
            this.Lbl_TotalPagar.Size = new System.Drawing.Size(15, 20);
            this.Lbl_TotalPagar.TabIndex = 10;
            this.Lbl_TotalPagar.Text = "-";
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total.Location = new System.Drawing.Point(96, 505);
            this.Lbl_Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(137, 17);
            this.Lbl_Total.TabIndex = 9;
            this.Lbl_Total.Text = "TOTAL A PAGAR:";
            // 
            // Lbl_Cantidad
            // 
            this.Lbl_Cantidad.AutoSize = true;
            this.Lbl_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cantidad.Location = new System.Drawing.Point(96, 209);
            this.Lbl_Cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(90, 17);
            this.Lbl_Cantidad.TabIndex = 8;
            this.Lbl_Cantidad.Text = "CANTIDAD:";
            // 
            // Lbl_IngresoNombre
            // 
            this.Lbl_IngresoNombre.AutoSize = true;
            this.Lbl_IngresoNombre.Location = new System.Drawing.Point(236, 117);
            this.Lbl_IngresoNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IngresoNombre.Name = "Lbl_IngresoNombre";
            this.Lbl_IngresoNombre.Size = new System.Drawing.Size(15, 20);
            this.Lbl_IngresoNombre.TabIndex = 7;
            this.Lbl_IngresoNombre.Text = "-";
            // 
            // Lbl_IngresoCodigo
            // 
            this.Lbl_IngresoCodigo.AutoSize = true;
            this.Lbl_IngresoCodigo.Location = new System.Drawing.Point(236, 76);
            this.Lbl_IngresoCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IngresoCodigo.Name = "Lbl_IngresoCodigo";
            this.Lbl_IngresoCodigo.Size = new System.Drawing.Size(15, 20);
            this.Lbl_IngresoCodigo.TabIndex = 6;
            this.Lbl_IngresoCodigo.Text = "-";
            // 
            // Lbl_IngresoPrecio
            // 
            this.Lbl_IngresoPrecio.AutoSize = true;
            this.Lbl_IngresoPrecio.Location = new System.Drawing.Point(236, 161);
            this.Lbl_IngresoPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IngresoPrecio.Name = "Lbl_IngresoPrecio";
            this.Lbl_IngresoPrecio.Size = new System.Drawing.Size(15, 20);
            this.Lbl_IngresoPrecio.TabIndex = 5;
            this.Lbl_IngresoPrecio.Text = "-";
            // 
            // Lbl_Precio
            // 
            this.Lbl_Precio.AutoSize = true;
            this.Lbl_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Precio.Location = new System.Drawing.Point(96, 161);
            this.Lbl_Precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Precio.Name = "Lbl_Precio";
            this.Lbl_Precio.Size = new System.Drawing.Size(70, 17);
            this.Lbl_Precio.TabIndex = 4;
            this.Lbl_Precio.Text = "PRECIO:";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.Location = new System.Drawing.Point(96, 117);
            this.Lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(79, 17);
            this.Lbl_Nombre.TabIndex = 3;
            this.Lbl_Nombre.Text = "NOMBRE:";
            // 
            // Lbl_Codigo
            // 
            this.Lbl_Codigo.AutoSize = true;
            this.Lbl_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Codigo.Location = new System.Drawing.Point(96, 76);
            this.Lbl_Codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Codigo.Name = "Lbl_Codigo";
            this.Lbl_Codigo.Size = new System.Drawing.Size(74, 17);
            this.Lbl_Codigo.TabIndex = 2;
            this.Lbl_Codigo.Text = "CODIGO:";
            // 
            // Lbl_Producto
            // 
            this.Lbl_Producto.AutoSize = true;
            this.Lbl_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Producto.Location = new System.Drawing.Point(96, 28);
            this.Lbl_Producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Producto.Name = "Lbl_Producto";
            this.Lbl_Producto.Size = new System.Drawing.Size(100, 17);
            this.Lbl_Producto.TabIndex = 1;
            this.Lbl_Producto.Text = "PRODUCTO:";
            // 
            // Dgv_Lista
            // 
            this.Dgv_Lista.AllowUserToAddRows = false;
            this.Dgv_Lista.AllowUserToDeleteRows = false;
            this.Dgv_Lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Lista.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.Dgv_Lista.Location = new System.Drawing.Point(32, 258);
            this.Dgv_Lista.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Lista.Name = "Dgv_Lista";
            this.Dgv_Lista.ReadOnly = true;
            this.Dgv_Lista.RowHeadersVisible = false;
            this.Dgv_Lista.RowHeadersWidth = 51;
            this.Dgv_Lista.RowTemplate.Height = 24;
            this.Dgv_Lista.Size = new System.Drawing.Size(644, 212);
            this.Dgv_Lista.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CODIGO";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PRODUCTO";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PRECIO";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CANTIDAD";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TOTAL";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Btn_Vender
            // 
            this.Btn_Vender.BackColor = System.Drawing.Color.White;
            this.Btn_Vender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Vender.Location = new System.Drawing.Point(279, 697);
            this.Btn_Vender.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Vender.Name = "Btn_Vender";
            this.Btn_Vender.Size = new System.Drawing.Size(271, 80);
            this.Btn_Vender.TabIndex = 1;
            this.Btn_Vender.Text = "VENDER";
            this.Btn_Vender.UseVisualStyleBackColor = false;
            // 
            // Lbl_Factura
            // 
            this.Lbl_Factura.AutoSize = true;
            this.Lbl_Factura.BackColor = System.Drawing.Color.Silver;
            this.Lbl_Factura.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Factura.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Factura.Location = new System.Drawing.Point(349, 31);
            this.Lbl_Factura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Factura.Name = "Lbl_Factura";
            this.Lbl_Factura.Size = new System.Drawing.Size(164, 50);
            this.Lbl_Factura.TabIndex = 2;
            this.Lbl_Factura.Text = "VENTA";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeFacturaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(801, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listadoDeFacturaToolStripMenuItem
            // 
            this.listadoDeFacturaToolStripMenuItem.Name = "listadoDeFacturaToolStripMenuItem";
            this.listadoDeFacturaToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.listadoDeFacturaToolStripMenuItem.Text = "Listado de Factura";
            this.listadoDeFacturaToolStripMenuItem.Click += new System.EventHandler(this.listadoDeFacturaToolStripMenuItem_Click);
            // 
            // Frm_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(801, 825);
            this.Controls.Add(this.Lbl_Factura);
            this.Controls.Add(this.Btn_Vender);
            this.Controls.Add(this.Pnl_Producto);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel San Carlos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Pnl_Producto.ResumeLayout(false);
            this.Pnl_Producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Lista)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Producto;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.TextBox Txt_Efectivo;
        private System.Windows.Forms.TextBox Txt_IngresoCantidad;
        private System.Windows.Forms.ComboBox Cbo_Producto;
        private System.Windows.Forms.Label Lbl_IngresoDevolucion;
        private System.Windows.Forms.Label Lbl_Devolucion;
        private System.Windows.Forms.Label Lbl_Efectivo;
        private System.Windows.Forms.Label Lbl_TotalPagar;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.Label Lbl_IngresoNombre;
        private System.Windows.Forms.Label Lbl_IngresoCodigo;
        private System.Windows.Forms.Label Lbl_IngresoPrecio;
        private System.Windows.Forms.Label Lbl_Precio;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Label Lbl_Codigo;
        private System.Windows.Forms.Label Lbl_Producto;
        private System.Windows.Forms.DataGridView Dgv_Lista;
        private System.Windows.Forms.Button Btn_Vender;
        private System.Windows.Forms.Label Lbl_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listadoDeFacturaToolStripMenuItem;
    }
}

