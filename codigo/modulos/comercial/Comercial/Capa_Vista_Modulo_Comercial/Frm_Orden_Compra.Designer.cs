
namespace Capa_Vista_Modulo_Comercial
{
    partial class Frm_Orden_Compra
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
            this.Cbo_Proveedor = new System.Windows.Forms.ComboBox();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.Gpb_Datos_Orden = new System.Windows.Forms.GroupBox();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Proveedor = new System.Windows.Forms.Label();
            this.Gpb_Detalle = new System.Windows.Forms.GroupBox();
            this.Btn_EliminarProduc = new System.Windows.Forms.Button();
            this.Btn_AgregarProduc = new System.Windows.Forms.Button();
            this.Dgv_Detalle = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_Aplicaciones = new System.Windows.Forms.Panel();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Aprobar = new System.Windows.Forms.Button();
            this.Btn_Anular = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Gpb_Datos_Orden.SuspendLayout();
            this.Gpb_Detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle)).BeginInit();
            this.Pnl_Aplicaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cbo_Proveedor
            // 
            this.Cbo_Proveedor.FormattingEnabled = true;
            this.Cbo_Proveedor.Location = new System.Drawing.Point(192, 50);
            this.Cbo_Proveedor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Cbo_Proveedor.Name = "Cbo_Proveedor";
            this.Cbo_Proveedor.Size = new System.Drawing.Size(321, 28);
            this.Cbo_Proveedor.TabIndex = 0;
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Location = new System.Drawing.Point(637, 47);
            this.Dtp_Fecha.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(542, 27);
            this.Dtp_Fecha.TabIndex = 1;
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Location = new System.Drawing.Point(192, 105);
            this.Txt_Estado.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.ReadOnly = true;
            this.Txt_Estado.Size = new System.Drawing.Size(241, 27);
            this.Txt_Estado.TabIndex = 2;
            // 
            // Txt_Total
            // 
            this.Txt_Total.Location = new System.Drawing.Point(637, 100);
            this.Txt_Total.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.ReadOnly = true;
            this.Txt_Total.Size = new System.Drawing.Size(160, 27);
            this.Txt_Total.TabIndex = 3;
            this.Txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Gpb_Datos_Orden
            // 
            this.Gpb_Datos_Orden.Controls.Add(this.Lbl_Total);
            this.Gpb_Datos_Orden.Controls.Add(this.Lbl_Estado);
            this.Gpb_Datos_Orden.Controls.Add(this.Lbl_Fecha);
            this.Gpb_Datos_Orden.Controls.Add(this.Lbl_Proveedor);
            this.Gpb_Datos_Orden.Controls.Add(this.Cbo_Proveedor);
            this.Gpb_Datos_Orden.Controls.Add(this.Txt_Total);
            this.Gpb_Datos_Orden.Controls.Add(this.Dtp_Fecha);
            this.Gpb_Datos_Orden.Controls.Add(this.Txt_Estado);
            this.Gpb_Datos_Orden.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Datos_Orden.Location = new System.Drawing.Point(31, 31);
            this.Gpb_Datos_Orden.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Gpb_Datos_Orden.Name = "Gpb_Datos_Orden";
            this.Gpb_Datos_Orden.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Gpb_Datos_Orden.Size = new System.Drawing.Size(1349, 172);
            this.Gpb_Datos_Orden.TabIndex = 4;
            this.Gpb_Datos_Orden.TabStop = false;
            this.Gpb_Datos_Orden.Text = "Datos de la Orden de Compra";
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Location = new System.Drawing.Point(536, 105);
            this.Lbl_Total.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(48, 20);
            this.Lbl_Total.TabIndex = 7;
            this.Lbl_Total.Text = "Total";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Location = new System.Drawing.Point(31, 110);
            this.Lbl_Estado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(62, 20);
            this.Lbl_Estado.TabIndex = 6;
            this.Lbl_Estado.Text = "Estado";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Location = new System.Drawing.Point(536, 55);
            this.Lbl_Fecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(56, 20);
            this.Lbl_Fecha.TabIndex = 5;
            this.Lbl_Fecha.Text = "Fecha";
            // 
            // Lbl_Proveedor
            // 
            this.Lbl_Proveedor.AutoSize = true;
            this.Lbl_Proveedor.Location = new System.Drawing.Point(31, 55);
            this.Lbl_Proveedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_Proveedor.Name = "Lbl_Proveedor";
            this.Lbl_Proveedor.Size = new System.Drawing.Size(92, 20);
            this.Lbl_Proveedor.TabIndex = 4;
            this.Lbl_Proveedor.Text = "Proveedor";
            // 
            // Gpb_Detalle
            // 
            this.Gpb_Detalle.Controls.Add(this.Btn_EliminarProduc);
            this.Gpb_Detalle.Controls.Add(this.Btn_AgregarProduc);
            this.Gpb_Detalle.Controls.Add(this.Dgv_Detalle);
            this.Gpb_Detalle.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Detalle.Location = new System.Drawing.Point(31, 219);
            this.Gpb_Detalle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Gpb_Detalle.Name = "Gpb_Detalle";
            this.Gpb_Detalle.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Gpb_Detalle.Size = new System.Drawing.Size(1349, 449);
            this.Gpb_Detalle.TabIndex = 5;
            this.Gpb_Detalle.TabStop = false;
            this.Gpb_Detalle.Text = "Detalle Compra";
            // 
            // Btn_EliminarProduc
            // 
            this.Btn_EliminarProduc.Location = new System.Drawing.Point(291, 375);
            this.Btn_EliminarProduc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_EliminarProduc.Name = "Btn_EliminarProduc";
            this.Btn_EliminarProduc.Size = new System.Drawing.Size(265, 47);
            this.Btn_EliminarProduc.TabIndex = 2;
            this.Btn_EliminarProduc.Text = "Eliminar Producto";
            this.Btn_EliminarProduc.UseVisualStyleBackColor = true;
            // 
            // Btn_AgregarProduc
            // 
            this.Btn_AgregarProduc.Location = new System.Drawing.Point(31, 375);
            this.Btn_AgregarProduc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_AgregarProduc.Name = "Btn_AgregarProduc";
            this.Btn_AgregarProduc.Size = new System.Drawing.Size(258, 47);
            this.Btn_AgregarProduc.TabIndex = 1;
            this.Btn_AgregarProduc.Text = "Agregar Producto";
            this.Btn_AgregarProduc.UseVisualStyleBackColor = true;
            // 
            // Dgv_Detalle
            // 
            this.Dgv_Detalle.AllowUserToAddRows = false;
            this.Dgv_Detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Detalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.producto,
            this.cantidad,
            this.precio_unit,
            this.subtotal});
            this.Dgv_Detalle.Location = new System.Drawing.Point(31, 47);
            this.Dgv_Detalle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Dgv_Detalle.Name = "Dgv_Detalle";
            this.Dgv_Detalle.RowHeadersWidth = 51;
            this.Dgv_Detalle.RowTemplate.Height = 24;
            this.Dgv_Detalle.Size = new System.Drawing.Size(1265, 311);
            this.Dgv_Detalle.TabIndex = 0;
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "ID";
            this.id_producto.MinimumWidth = 6;
            this.id_producto.Name = "id_producto";
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            // 
            // precio_unit
            // 
            this.precio_unit.HeaderText = "Precio Unitario";
            this.precio_unit.MinimumWidth = 6;
            this.precio_unit.Name = "precio_unit";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // Pnl_Aplicaciones
            // 
            this.Pnl_Aplicaciones.Controls.Add(this.Btn_Cancelar);
            this.Pnl_Aplicaciones.Controls.Add(this.Btn_Aprobar);
            this.Pnl_Aplicaciones.Controls.Add(this.Btn_Anular);
            this.Pnl_Aplicaciones.Controls.Add(this.Btn_Editar);
            this.Pnl_Aplicaciones.Controls.Add(this.Btn_Guardar);
            this.Pnl_Aplicaciones.Controls.Add(this.Btn_Nuevo);
            this.Pnl_Aplicaciones.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Pnl_Aplicaciones.Location = new System.Drawing.Point(31, 672);
            this.Pnl_Aplicaciones.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Pnl_Aplicaciones.Name = "Pnl_Aplicaciones";
            this.Pnl_Aplicaciones.Size = new System.Drawing.Size(1349, 94);
            this.Pnl_Aplicaciones.TabIndex = 6;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(1019, 20);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(161, 47);
            this.Btn_Cancelar.TabIndex = 5;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Aprobar
            // 
            this.Btn_Aprobar.Location = new System.Drawing.Point(842, 20);
            this.Btn_Aprobar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_Aprobar.Name = "Btn_Aprobar";
            this.Btn_Aprobar.Size = new System.Drawing.Size(161, 47);
            this.Btn_Aprobar.TabIndex = 4;
            this.Btn_Aprobar.Text = "Aprobar";
            this.Btn_Aprobar.UseVisualStyleBackColor = true;
            // 
            // Btn_Anular
            // 
            this.Btn_Anular.Location = new System.Drawing.Point(663, 20);
            this.Btn_Anular.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_Anular.Name = "Btn_Anular";
            this.Btn_Anular.Size = new System.Drawing.Size(161, 47);
            this.Btn_Anular.TabIndex = 3;
            this.Btn_Anular.Text = "Anular";
            this.Btn_Anular.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Location = new System.Drawing.Point(484, 20);
            this.Btn_Editar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(161, 47);
            this.Btn_Editar.TabIndex = 2;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(304, 20);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(161, 47);
            this.Btn_Guardar.TabIndex = 1;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Location = new System.Drawing.Point(127, 20);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(161, 47);
            this.Btn_Nuevo.TabIndex = 0;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // Frm_Orden_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1412, 936);
            this.Controls.Add(this.Pnl_Aplicaciones);
            this.Controls.Add(this.Gpb_Detalle);
            this.Controls.Add(this.Gpb_Datos_Orden);
            this.Font = new System.Drawing.Font("Rockwell", 13F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimumSize = new System.Drawing.Size(1381, 878);
            this.Name = "Frm_Orden_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Orden_Compra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Gpb_Datos_Orden.ResumeLayout(false);
            this.Gpb_Datos_Orden.PerformLayout();
            this.Gpb_Detalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle)).EndInit();
            this.Pnl_Aplicaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbo_Proveedor;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.GroupBox Gpb_Datos_Orden;
        private System.Windows.Forms.Label Lbl_Proveedor;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.GroupBox Gpb_Detalle;
        private System.Windows.Forms.DataGridView Dgv_Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewComboBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Button Btn_EliminarProduc;
        private System.Windows.Forms.Button Btn_AgregarProduc;
        private System.Windows.Forms.Panel Pnl_Aplicaciones;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Aprobar;
        private System.Windows.Forms.Button Btn_Anular;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Nuevo;
    }
}