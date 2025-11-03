
namespace Capa_Vista_Ordenes
{
    partial class Frm_Ordenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ordenes));
            this.Lbl_Titulo_Ordenes = new System.Windows.Forms.Label();
            this.Lbl_Orden_Compra = new System.Windows.Forms.Label();
            this.Lbl_Id_Banco = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Autorizacion = new System.Windows.Forms.Label();
            this.Lbl_Estado_Autorizacion = new System.Windows.Forms.Label();
            this.Lbl_Monto_Autorizado = new System.Windows.Forms.Label();
            this.Lbl_Autorizado_Por = new System.Windows.Forms.Label();
            this.Dgv_Auto_Ordenes = new System.Windows.Forms.DataGridView();
            this.Lbl_Detalle_Autorizaciones = new System.Windows.Forms.Label();
            this.Btn_Eliminar_Autorizacion = new System.Windows.Forms.Button();
            this.Btn_Modificar_Autorizacion = new System.Windows.Forms.Button();
            this.Btn_Ayuda_Autorizacion = new System.Windows.Forms.Button();
            this.Btn_Imprimir_Autorizacion = new System.Windows.Forms.Button();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtAutorizadoPor = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.Btn_Guardar_Autorizacion = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Auto_Ordenes)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Titulo_Ordenes
            // 
            this.Lbl_Titulo_Ordenes.AutoSize = true;
            this.Lbl_Titulo_Ordenes.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo_Ordenes.Location = new System.Drawing.Point(12, 24);
            this.Lbl_Titulo_Ordenes.Name = "Lbl_Titulo_Ordenes";
            this.Lbl_Titulo_Ordenes.Size = new System.Drawing.Size(484, 35);
            this.Lbl_Titulo_Ordenes.TabIndex = 0;
            this.Lbl_Titulo_Ordenes.Text = "Autorización Ordenes de Compra";
            // 
            // Lbl_Orden_Compra
            // 
            this.Lbl_Orden_Compra.AutoSize = true;
            this.Lbl_Orden_Compra.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Orden_Compra.Location = new System.Drawing.Point(11, 106);
            this.Lbl_Orden_Compra.Name = "Lbl_Orden_Compra";
            this.Lbl_Orden_Compra.Size = new System.Drawing.Size(202, 21);
            this.Lbl_Orden_Compra.TabIndex = 3;
            this.Lbl_Orden_Compra.Text = "ID Orden de Compra:";
            // 
            // Lbl_Id_Banco
            // 
            this.Lbl_Id_Banco.AutoSize = true;
            this.Lbl_Id_Banco.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Banco.Location = new System.Drawing.Point(11, 161);
            this.Lbl_Id_Banco.Name = "Lbl_Id_Banco";
            this.Lbl_Id_Banco.Size = new System.Drawing.Size(94, 21);
            this.Lbl_Id_Banco.TabIndex = 5;
            this.Lbl_Id_Banco.Text = "ID Banco:";
            // 
            // Lbl_Fecha_Autorizacion
            // 
            this.Lbl_Fecha_Autorizacion.AutoSize = true;
            this.Lbl_Fecha_Autorizacion.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Autorizacion.Location = new System.Drawing.Point(11, 213);
            this.Lbl_Fecha_Autorizacion.Name = "Lbl_Fecha_Autorizacion";
            this.Lbl_Fecha_Autorizacion.Size = new System.Drawing.Size(213, 21);
            this.Lbl_Fecha_Autorizacion.TabIndex = 7;
            this.Lbl_Fecha_Autorizacion.Text = "Fecha de Autorización:";
            // 
            // Lbl_Estado_Autorizacion
            // 
            this.Lbl_Estado_Autorizacion.AutoSize = true;
            this.Lbl_Estado_Autorizacion.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado_Autorizacion.Location = new System.Drawing.Point(489, 218);
            this.Lbl_Estado_Autorizacion.Name = "Lbl_Estado_Autorizacion";
            this.Lbl_Estado_Autorizacion.Size = new System.Drawing.Size(76, 21);
            this.Lbl_Estado_Autorizacion.TabIndex = 13;
            this.Lbl_Estado_Autorizacion.Text = "Estado:";
            // 
            // Lbl_Monto_Autorizado
            // 
            this.Lbl_Monto_Autorizado.AutoSize = true;
            this.Lbl_Monto_Autorizado.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Monto_Autorizado.Location = new System.Drawing.Point(489, 163);
            this.Lbl_Monto_Autorizado.Name = "Lbl_Monto_Autorizado";
            this.Lbl_Monto_Autorizado.Size = new System.Drawing.Size(174, 21);
            this.Lbl_Monto_Autorizado.TabIndex = 11;
            this.Lbl_Monto_Autorizado.Text = "Monto Autorizado:";
            // 
            // Lbl_Autorizado_Por
            // 
            this.Lbl_Autorizado_Por.AutoSize = true;
            this.Lbl_Autorizado_Por.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Autorizado_Por.Location = new System.Drawing.Point(489, 107);
            this.Lbl_Autorizado_Por.Name = "Lbl_Autorizado_Por";
            this.Lbl_Autorizado_Por.Size = new System.Drawing.Size(149, 21);
            this.Lbl_Autorizado_Por.TabIndex = 9;
            this.Lbl_Autorizado_Por.Text = "Autorizado por:";
            // 
            // Dgv_Auto_Ordenes
            // 
            this.Dgv_Auto_Ordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Auto_Ordenes.Location = new System.Drawing.Point(12, 345);
            this.Dgv_Auto_Ordenes.Name = "Dgv_Auto_Ordenes";
            this.Dgv_Auto_Ordenes.RowHeadersWidth = 51;
            this.Dgv_Auto_Ordenes.RowTemplate.Height = 24;
            this.Dgv_Auto_Ordenes.Size = new System.Drawing.Size(937, 191);
            this.Dgv_Auto_Ordenes.TabIndex = 16;
            // 
            // Lbl_Detalle_Autorizaciones
            // 
            this.Lbl_Detalle_Autorizaciones.AutoSize = true;
            this.Lbl_Detalle_Autorizaciones.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Detalle_Autorizaciones.Location = new System.Drawing.Point(12, 316);
            this.Lbl_Detalle_Autorizaciones.Name = "Lbl_Detalle_Autorizaciones";
            this.Lbl_Detalle_Autorizaciones.Size = new System.Drawing.Size(431, 21);
            this.Lbl_Detalle_Autorizaciones.TabIndex = 18;
            this.Lbl_Detalle_Autorizaciones.Text = "Detalle Autorizaciones de Ordenes de Compra:";
            // 
            // Btn_Eliminar_Autorizacion
            // 
            this.Btn_Eliminar_Autorizacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar_Autorizacion.Image")));
            this.Btn_Eliminar_Autorizacion.Location = new System.Drawing.Point(774, 23);
            this.Btn_Eliminar_Autorizacion.Name = "Btn_Eliminar_Autorizacion";
            this.Btn_Eliminar_Autorizacion.Size = new System.Drawing.Size(50, 45);
            this.Btn_Eliminar_Autorizacion.TabIndex = 21;
            this.Btn_Eliminar_Autorizacion.UseVisualStyleBackColor = true;
            this.Btn_Eliminar_Autorizacion.Click += new System.EventHandler(this.Btn_Eliminar_Autorizacion_Click);
            // 
            // Btn_Modificar_Autorizacion
            // 
            this.Btn_Modificar_Autorizacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar_Autorizacion.Image")));
            this.Btn_Modificar_Autorizacion.Location = new System.Drawing.Point(718, 23);
            this.Btn_Modificar_Autorizacion.Name = "Btn_Modificar_Autorizacion";
            this.Btn_Modificar_Autorizacion.Size = new System.Drawing.Size(50, 45);
            this.Btn_Modificar_Autorizacion.TabIndex = 20;
            this.Btn_Modificar_Autorizacion.UseVisualStyleBackColor = true;
            this.Btn_Modificar_Autorizacion.Click += new System.EventHandler(this.Btn_Modificar_Autorizacion_Click);
            // 
            // Btn_Ayuda_Autorizacion
            // 
            this.Btn_Ayuda_Autorizacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda_Autorizacion.Image")));
            this.Btn_Ayuda_Autorizacion.Location = new System.Drawing.Point(886, 24);
            this.Btn_Ayuda_Autorizacion.Name = "Btn_Ayuda_Autorizacion";
            this.Btn_Ayuda_Autorizacion.Size = new System.Drawing.Size(50, 45);
            this.Btn_Ayuda_Autorizacion.TabIndex = 23;
            this.Btn_Ayuda_Autorizacion.UseVisualStyleBackColor = true;
            // 
            // Btn_Imprimir_Autorizacion
            // 
            this.Btn_Imprimir_Autorizacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Imprimir_Autorizacion.Image")));
            this.Btn_Imprimir_Autorizacion.Location = new System.Drawing.Point(830, 24);
            this.Btn_Imprimir_Autorizacion.Name = "Btn_Imprimir_Autorizacion";
            this.Btn_Imprimir_Autorizacion.Size = new System.Drawing.Size(50, 45);
            this.Btn_Imprimir_Autorizacion.TabIndex = 22;
            this.Btn_Imprimir_Autorizacion.UseVisualStyleBackColor = true;
            // 
            // txtOrden
            // 
            this.txtOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrden.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrden.Location = new System.Drawing.Point(279, 103);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(192, 25);
            this.txtOrden.TabIndex = 24;
            // 
            // txtMonto
            // 
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonto.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(696, 161);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(192, 25);
            this.txtMonto.TabIndex = 25;
            // 
            // txtAutorizadoPor
            // 
            this.txtAutorizadoPor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutorizadoPor.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutorizadoPor.Location = new System.Drawing.Point(696, 103);
            this.txtAutorizadoPor.Name = "txtAutorizadoPor";
            this.txtAutorizadoPor.Size = new System.Drawing.Size(192, 25);
            this.txtAutorizadoPor.TabIndex = 26;
            // 
            // txtBanco
            // 
            this.txtBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBanco.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanco.Location = new System.Drawing.Point(279, 161);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(192, 25);
            this.txtBanco.TabIndex = 27;
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(696, 216);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(192, 25);
            this.txtEstado.TabIndex = 28;
            // 
            // Btn_Guardar_Autorizacion
            // 
            this.Btn_Guardar_Autorizacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar_Autorizacion.Image")));
            this.Btn_Guardar_Autorizacion.Location = new System.Drawing.Point(662, 24);
            this.Btn_Guardar_Autorizacion.Name = "Btn_Guardar_Autorizacion";
            this.Btn_Guardar_Autorizacion.Size = new System.Drawing.Size(50, 45);
            this.Btn_Guardar_Autorizacion.TabIndex = 30;
            this.Btn_Guardar_Autorizacion.UseVisualStyleBackColor = true;
            this.Btn_Guardar_Autorizacion.Click += new System.EventHandler(this.Btn_Guardar_Autorizacion_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFecha.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(279, 216);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(192, 25);
            this.txtFecha.TabIndex = 31;
            // 
            // Frm_Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 548);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.Btn_Guardar_Autorizacion);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.txtAutorizadoPor);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.Btn_Ayuda_Autorizacion);
            this.Controls.Add(this.Btn_Imprimir_Autorizacion);
            this.Controls.Add(this.Btn_Eliminar_Autorizacion);
            this.Controls.Add(this.Btn_Modificar_Autorizacion);
            this.Controls.Add(this.Lbl_Detalle_Autorizaciones);
            this.Controls.Add(this.Dgv_Auto_Ordenes);
            this.Controls.Add(this.Lbl_Estado_Autorizacion);
            this.Controls.Add(this.Lbl_Monto_Autorizado);
            this.Controls.Add(this.Lbl_Autorizado_Por);
            this.Controls.Add(this.Lbl_Fecha_Autorizacion);
            this.Controls.Add(this.Lbl_Id_Banco);
            this.Controls.Add(this.Lbl_Orden_Compra);
            this.Controls.Add(this.Lbl_Titulo_Ordenes);
            this.Name = "Frm_Ordenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Frm_Ordenes";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Auto_Ordenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo_Ordenes;
        private System.Windows.Forms.Label Lbl_Orden_Compra;
        private System.Windows.Forms.Label Lbl_Id_Banco;
        private System.Windows.Forms.Label Lbl_Fecha_Autorizacion;
        private System.Windows.Forms.Label Lbl_Estado_Autorizacion;
        private System.Windows.Forms.Label Lbl_Monto_Autorizado;
        private System.Windows.Forms.Label Lbl_Autorizado_Por;
        private System.Windows.Forms.DataGridView Dgv_Auto_Ordenes;
        private System.Windows.Forms.Label Lbl_Detalle_Autorizaciones;
        private System.Windows.Forms.Button Btn_Eliminar_Autorizacion;
        private System.Windows.Forms.Button Btn_Modificar_Autorizacion;
        private System.Windows.Forms.Button Btn_Ayuda_Autorizacion;
        private System.Windows.Forms.Button Btn_Imprimir_Autorizacion;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtAutorizadoPor;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button Btn_Guardar_Autorizacion;
        private System.Windows.Forms.TextBox txtFecha;
    }
}