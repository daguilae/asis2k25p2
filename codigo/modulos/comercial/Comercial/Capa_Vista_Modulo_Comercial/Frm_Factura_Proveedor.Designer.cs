
namespace Capa_Vista_Modulo_Comercial
{
    partial class Frm_Factura_Proveedor
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
            this.Gpb_DatosFactura = new System.Windows.Forms.GroupBox();
            this.Txt_TotalFactura = new System.Windows.Forms.TextBox();
            this.Lbl_TotalFactura = new System.Windows.Forms.Label();
            this.Txt_Numerofactura = new System.Windows.Forms.TextBox();
            this.Lbl_NumeroFactura = new System.Windows.Forms.Label();
            this.Dtp_FechaFactura = new System.Windows.Forms.DateTimePicker();
            this.Lbl_FechaFactura = new System.Windows.Forms.Label();
            this.Cbo_OrdenCompra = new System.Windows.Forms.ComboBox();
            this.Lbl_OrdenCompra = new System.Windows.Forms.Label();
            this.Cbo_Proveedor = new System.Windows.Forms.ComboBox();
            this.Lbl_Proveedor = new System.Windows.Forms.Label();
            this.Gpb_DetalleFactura = new System.Windows.Forms.GroupBox();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Dgv_DetalleFactura = new System.Windows.Forms.DataGridView();
            this.id_prducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciounit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_AccionesFactura = new System.Windows.Forms.Panel();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Anular = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Gpb_DatosFactura.SuspendLayout();
            this.Gpb_DetalleFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DetalleFactura)).BeginInit();
            this.Pnl_AccionesFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_DatosFactura
            // 
            this.Gpb_DatosFactura.Controls.Add(this.Txt_TotalFactura);
            this.Gpb_DatosFactura.Controls.Add(this.Lbl_TotalFactura);
            this.Gpb_DatosFactura.Controls.Add(this.Txt_Numerofactura);
            this.Gpb_DatosFactura.Controls.Add(this.Lbl_NumeroFactura);
            this.Gpb_DatosFactura.Controls.Add(this.Dtp_FechaFactura);
            this.Gpb_DatosFactura.Controls.Add(this.Lbl_FechaFactura);
            this.Gpb_DatosFactura.Controls.Add(this.Cbo_OrdenCompra);
            this.Gpb_DatosFactura.Controls.Add(this.Lbl_OrdenCompra);
            this.Gpb_DatosFactura.Controls.Add(this.Cbo_Proveedor);
            this.Gpb_DatosFactura.Controls.Add(this.Lbl_Proveedor);
            this.Gpb_DatosFactura.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Gpb_DatosFactura.Location = new System.Drawing.Point(32, 31);
            this.Gpb_DatosFactura.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Gpb_DatosFactura.Name = "Gpb_DatosFactura";
            this.Gpb_DatosFactura.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Gpb_DatosFactura.Size = new System.Drawing.Size(1349, 203);
            this.Gpb_DatosFactura.TabIndex = 0;
            this.Gpb_DatosFactura.TabStop = false;
            this.Gpb_DatosFactura.Text = "Datos de la Factura Proveedor";
            // 
            // Txt_TotalFactura
            // 
            this.Txt_TotalFactura.Location = new System.Drawing.Point(1129, 112);
            this.Txt_TotalFactura.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Txt_TotalFactura.Name = "Txt_TotalFactura";
            this.Txt_TotalFactura.ReadOnly = true;
            this.Txt_TotalFactura.Size = new System.Drawing.Size(192, 27);
            this.Txt_TotalFactura.TabIndex = 14;
            this.Txt_TotalFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Lbl_TotalFactura
            // 
            this.Lbl_TotalFactura.AutoSize = true;
            this.Lbl_TotalFactura.Location = new System.Drawing.Point(1048, 120);
            this.Lbl_TotalFactura.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_TotalFactura.Name = "Lbl_TotalFactura";
            this.Lbl_TotalFactura.Size = new System.Drawing.Size(48, 20);
            this.Lbl_TotalFactura.TabIndex = 13;
            this.Lbl_TotalFactura.Text = "Total";
            // 
            // Txt_Numerofactura
            // 
            this.Txt_Numerofactura.Location = new System.Drawing.Point(793, 112);
            this.Txt_Numerofactura.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Txt_Numerofactura.Name = "Txt_Numerofactura";
            this.Txt_Numerofactura.Size = new System.Drawing.Size(241, 27);
            this.Txt_Numerofactura.TabIndex = 12;
            // 
            // Lbl_NumeroFactura
            // 
            this.Lbl_NumeroFactura.AutoSize = true;
            this.Lbl_NumeroFactura.Location = new System.Drawing.Point(536, 117);
            this.Lbl_NumeroFactura.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_NumeroFactura.Name = "Lbl_NumeroFactura";
            this.Lbl_NumeroFactura.Size = new System.Drawing.Size(98, 20);
            this.Lbl_NumeroFactura.TabIndex = 11;
            this.Lbl_NumeroFactura.Text = "No. Factura";
            // 
            // Dtp_FechaFactura
            // 
            this.Dtp_FechaFactura.Location = new System.Drawing.Point(234, 109);
            this.Dtp_FechaFactura.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Dtp_FechaFactura.Name = "Dtp_FechaFactura";
            this.Dtp_FechaFactura.Size = new System.Drawing.Size(241, 27);
            this.Dtp_FechaFactura.TabIndex = 10;
            // 
            // Lbl_FechaFactura
            // 
            this.Lbl_FechaFactura.AutoSize = true;
            this.Lbl_FechaFactura.Location = new System.Drawing.Point(32, 117);
            this.Lbl_FechaFactura.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_FechaFactura.Name = "Lbl_FechaFactura";
            this.Lbl_FechaFactura.Size = new System.Drawing.Size(118, 20);
            this.Lbl_FechaFactura.TabIndex = 9;
            this.Lbl_FechaFactura.Text = "Fecha Factura";
            // 
            // Cbo_OrdenCompra
            // 
            this.Cbo_OrdenCompra.FormattingEnabled = true;
            this.Cbo_OrdenCompra.Location = new System.Drawing.Point(793, 50);
            this.Cbo_OrdenCompra.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Cbo_OrdenCompra.Name = "Cbo_OrdenCompra";
            this.Cbo_OrdenCompra.Size = new System.Drawing.Size(322, 28);
            this.Cbo_OrdenCompra.TabIndex = 8;
            // 
            // Lbl_OrdenCompra
            // 
            this.Lbl_OrdenCompra.AutoSize = true;
            this.Lbl_OrdenCompra.Location = new System.Drawing.Point(536, 55);
            this.Lbl_OrdenCompra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_OrdenCompra.Name = "Lbl_OrdenCompra";
            this.Lbl_OrdenCompra.Size = new System.Drawing.Size(152, 20);
            this.Lbl_OrdenCompra.TabIndex = 7;
            this.Lbl_OrdenCompra.Text = "Orden de Compra";
            // 
            // Cbo_Proveedor
            // 
            this.Cbo_Proveedor.FormattingEnabled = true;
            this.Cbo_Proveedor.Location = new System.Drawing.Point(192, 50);
            this.Cbo_Proveedor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Cbo_Proveedor.Name = "Cbo_Proveedor";
            this.Cbo_Proveedor.Size = new System.Drawing.Size(322, 28);
            this.Cbo_Proveedor.TabIndex = 6;
            // 
            // Lbl_Proveedor
            // 
            this.Lbl_Proveedor.AutoSize = true;
            this.Lbl_Proveedor.Location = new System.Drawing.Point(32, 55);
            this.Lbl_Proveedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_Proveedor.Name = "Lbl_Proveedor";
            this.Lbl_Proveedor.Size = new System.Drawing.Size(92, 20);
            this.Lbl_Proveedor.TabIndex = 5;
            this.Lbl_Proveedor.Text = "Proveedor";
            // 
            // Gpb_DetalleFactura
            // 
            this.Gpb_DetalleFactura.Controls.Add(this.Btn_Eliminar);
            this.Gpb_DetalleFactura.Controls.Add(this.Btn_Agregar);
            this.Gpb_DetalleFactura.Controls.Add(this.Dgv_DetalleFactura);
            this.Gpb_DetalleFactura.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_DetalleFactura.Location = new System.Drawing.Point(32, 250);
            this.Gpb_DetalleFactura.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Gpb_DetalleFactura.Name = "Gpb_DetalleFactura";
            this.Gpb_DetalleFactura.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Gpb_DetalleFactura.Size = new System.Drawing.Size(1349, 428);
            this.Gpb_DetalleFactura.TabIndex = 1;
            this.Gpb_DetalleFactura.TabStop = false;
            this.Gpb_DetalleFactura.Text = "Detalle de Productos Facturados";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(306, 367);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(263, 47);
            this.Btn_Eliminar.TabIndex = 2;
            this.Btn_Eliminar.Text = "Eliminar Producto";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Location = new System.Drawing.Point(32, 367);
            this.Btn_Agregar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(263, 47);
            this.Btn_Agregar.TabIndex = 1;
            this.Btn_Agregar.Text = "Agregar Producto";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // Dgv_DetalleFactura
            // 
            this.Dgv_DetalleFactura.AllowUserToAddRows = false;
            this.Dgv_DetalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_DetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_prducto,
            this.producto,
            this.cantidad,
            this.preciounit,
            this.subtotal});
            this.Dgv_DetalleFactura.Location = new System.Drawing.Point(32, 47);
            this.Dgv_DetalleFactura.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Dgv_DetalleFactura.Name = "Dgv_DetalleFactura";
            this.Dgv_DetalleFactura.RowHeadersWidth = 51;
            this.Dgv_DetalleFactura.RowTemplate.Height = 24;
            this.Dgv_DetalleFactura.Size = new System.Drawing.Size(1284, 312);
            this.Dgv_DetalleFactura.TabIndex = 0;
            // 
            // id_prducto
            // 
            this.id_prducto.HeaderText = "ID";
            this.id_prducto.MinimumWidth = 6;
            this.id_prducto.Name = "id_prducto";
            this.id_prducto.ReadOnly = true;
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
            // preciounit
            // 
            this.preciounit.HeaderText = "Precio Unitario";
            this.preciounit.MinimumWidth = 6;
            this.preciounit.Name = "preciounit";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // Pnl_AccionesFactura
            // 
            this.Pnl_AccionesFactura.Controls.Add(this.Btn_Cancelar);
            this.Pnl_AccionesFactura.Controls.Add(this.Btn_Anular);
            this.Pnl_AccionesFactura.Controls.Add(this.Btn_Editar);
            this.Pnl_AccionesFactura.Controls.Add(this.Btn_Guardar);
            this.Pnl_AccionesFactura.Controls.Add(this.Btn_Nuevo);
            this.Pnl_AccionesFactura.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_AccionesFactura.Location = new System.Drawing.Point(32, 688);
            this.Pnl_AccionesFactura.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Pnl_AccionesFactura.Name = "Pnl_AccionesFactura";
            this.Pnl_AccionesFactura.Size = new System.Drawing.Size(1349, 94);
            this.Pnl_AccionesFactura.TabIndex = 2;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(916, 23);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(162, 47);
            this.Btn_Cancelar.TabIndex = 6;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Anular
            // 
            this.Btn_Anular.Location = new System.Drawing.Point(738, 23);
            this.Btn_Anular.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_Anular.Name = "Btn_Anular";
            this.Btn_Anular.Size = new System.Drawing.Size(162, 47);
            this.Btn_Anular.TabIndex = 4;
            this.Btn_Anular.Text = "Anular";
            this.Btn_Anular.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Location = new System.Drawing.Point(559, 23);
            this.Btn_Editar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(162, 47);
            this.Btn_Editar.TabIndex = 3;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(380, 23);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(162, 47);
            this.Btn_Guardar.TabIndex = 2;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Location = new System.Drawing.Point(202, 23);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(162, 47);
            this.Btn_Nuevo.TabIndex = 1;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // Frm_Factura_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1410, 811);
            this.Controls.Add(this.Pnl_AccionesFactura);
            this.Controls.Add(this.Gpb_DetalleFactura);
            this.Controls.Add(this.Gpb_DatosFactura);
            this.Font = new System.Drawing.Font("Rockwell", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Frm_Factura_Proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Factura_Proveedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Gpb_DatosFactura.ResumeLayout(false);
            this.Gpb_DatosFactura.PerformLayout();
            this.Gpb_DetalleFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DetalleFactura)).EndInit();
            this.Pnl_AccionesFactura.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_DatosFactura;
        private System.Windows.Forms.Label Lbl_Proveedor;
        private System.Windows.Forms.ComboBox Cbo_Proveedor;
        private System.Windows.Forms.ComboBox Cbo_OrdenCompra;
        private System.Windows.Forms.Label Lbl_OrdenCompra;
        private System.Windows.Forms.DateTimePicker Dtp_FechaFactura;
        private System.Windows.Forms.Label Lbl_FechaFactura;
        private System.Windows.Forms.TextBox Txt_TotalFactura;
        private System.Windows.Forms.Label Lbl_TotalFactura;
        private System.Windows.Forms.TextBox Txt_Numerofactura;
        private System.Windows.Forms.Label Lbl_NumeroFactura;
        private System.Windows.Forms.GroupBox Gpb_DetalleFactura;
        private System.Windows.Forms.DataGridView Dgv_DetalleFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prducto;
        private System.Windows.Forms.DataGridViewComboBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciounit;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Panel Pnl_AccionesFactura;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Anular;
        private System.Windows.Forms.Button Btn_Cancelar;
    }
}