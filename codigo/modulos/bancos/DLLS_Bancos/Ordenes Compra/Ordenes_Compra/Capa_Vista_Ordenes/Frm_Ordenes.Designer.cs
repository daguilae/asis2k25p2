
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
            this.Lbl_Id_Autorizacion = new System.Windows.Forms.Label();
            this.Txt_Id_Autorizacion = new System.Windows.Forms.TextBox();
            this.Lbl_Orden_Compra = new System.Windows.Forms.Label();
            this.Lbl_Id_Banco = new System.Windows.Forms.Label();
            this.Txt_Fecha_Autorizacion = new System.Windows.Forms.TextBox();
            this.Lbl_Fecha_Autorizacion = new System.Windows.Forms.Label();
            this.Lbl_Estado_Autorizacion = new System.Windows.Forms.Label();
            this.Lbl_Monto_Autorizado = new System.Windows.Forms.Label();
            this.Txt_Autorizado_Por = new System.Windows.Forms.TextBox();
            this.Lbl_Autorizado_Por = new System.Windows.Forms.Label();
            this.Txt_Monto_Autorizado = new System.Windows.Forms.TextBox();
            this.Dgv_Auto_Ordenes = new System.Windows.Forms.DataGridView();
            this.Btn_Agregar_Autorizacion = new System.Windows.Forms.Button();
            this.Lbl_Detalle_Autorizaciones = new System.Windows.Forms.Label();
            this.Btn_Guardar_Autorizacion = new System.Windows.Forms.Button();
            this.Btn_Eliminar_Autorizacion = new System.Windows.Forms.Button();
            this.Btn_Modificar_Autorizacion = new System.Windows.Forms.Button();
            this.Btn_Ayuda_Autorizacion = new System.Windows.Forms.Button();
            this.Btn_Imprimir_Autorizacion = new System.Windows.Forms.Button();
            this.Btn_Consultar_Autorizaciones = new System.Windows.Forms.Button();
            this.Txt_Id_Orden = new System.Windows.Forms.TextBox();
            this.Txt_Id_Banco = new System.Windows.Forms.TextBox();
            this.Txt_Estado_Autorizacion = new System.Windows.Forms.TextBox();
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
            // Lbl_Id_Autorizacion
            // 
            this.Lbl_Id_Autorizacion.AutoSize = true;
            this.Lbl_Id_Autorizacion.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Autorizacion.Location = new System.Drawing.Point(12, 92);
            this.Lbl_Id_Autorizacion.Name = "Lbl_Id_Autorizacion";
            this.Lbl_Id_Autorizacion.Size = new System.Drawing.Size(153, 21);
            this.Lbl_Id_Autorizacion.TabIndex = 1;
            this.Lbl_Id_Autorizacion.Text = "ID Autorización:";
            // 
            // Txt_Id_Autorizacion
            // 
            this.Txt_Id_Autorizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Id_Autorizacion.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Id_Autorizacion.Location = new System.Drawing.Point(241, 87);
            this.Txt_Id_Autorizacion.Name = "Txt_Id_Autorizacion";
            this.Txt_Id_Autorizacion.Size = new System.Drawing.Size(218, 29);
            this.Txt_Id_Autorizacion.TabIndex = 2;
            // 
            // Lbl_Orden_Compra
            // 
            this.Lbl_Orden_Compra.AutoSize = true;
            this.Lbl_Orden_Compra.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Orden_Compra.Location = new System.Drawing.Point(12, 142);
            this.Lbl_Orden_Compra.Name = "Lbl_Orden_Compra";
            this.Lbl_Orden_Compra.Size = new System.Drawing.Size(202, 21);
            this.Lbl_Orden_Compra.TabIndex = 3;
            this.Lbl_Orden_Compra.Text = "ID Orden de Compra:";
            // 
            // Lbl_Id_Banco
            // 
            this.Lbl_Id_Banco.AutoSize = true;
            this.Lbl_Id_Banco.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Banco.Location = new System.Drawing.Point(12, 197);
            this.Lbl_Id_Banco.Name = "Lbl_Id_Banco";
            this.Lbl_Id_Banco.Size = new System.Drawing.Size(94, 21);
            this.Lbl_Id_Banco.TabIndex = 5;
            this.Lbl_Id_Banco.Text = "ID Banco:";
            // 
            // Txt_Fecha_Autorizacion
            // 
            this.Txt_Fecha_Autorizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Fecha_Autorizacion.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Fecha_Autorizacion.Location = new System.Drawing.Point(241, 246);
            this.Txt_Fecha_Autorizacion.Name = "Txt_Fecha_Autorizacion";
            this.Txt_Fecha_Autorizacion.Size = new System.Drawing.Size(218, 29);
            this.Txt_Fecha_Autorizacion.TabIndex = 8;
            // 
            // Lbl_Fecha_Autorizacion
            // 
            this.Lbl_Fecha_Autorizacion.AutoSize = true;
            this.Lbl_Fecha_Autorizacion.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Autorizacion.Location = new System.Drawing.Point(12, 249);
            this.Lbl_Fecha_Autorizacion.Name = "Lbl_Fecha_Autorizacion";
            this.Lbl_Fecha_Autorizacion.Size = new System.Drawing.Size(213, 21);
            this.Lbl_Fecha_Autorizacion.TabIndex = 7;
            this.Lbl_Fecha_Autorizacion.Text = "Fecha de Autorización:";
            // 
            // Lbl_Estado_Autorizacion
            // 
            this.Lbl_Estado_Autorizacion.AutoSize = true;
            this.Lbl_Estado_Autorizacion.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado_Autorizacion.Location = new System.Drawing.Point(489, 197);
            this.Lbl_Estado_Autorizacion.Name = "Lbl_Estado_Autorizacion";
            this.Lbl_Estado_Autorizacion.Size = new System.Drawing.Size(76, 21);
            this.Lbl_Estado_Autorizacion.TabIndex = 13;
            this.Lbl_Estado_Autorizacion.Text = "Estado:";
            // 
            // Lbl_Monto_Autorizado
            // 
            this.Lbl_Monto_Autorizado.AutoSize = true;
            this.Lbl_Monto_Autorizado.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Monto_Autorizado.Location = new System.Drawing.Point(489, 142);
            this.Lbl_Monto_Autorizado.Name = "Lbl_Monto_Autorizado";
            this.Lbl_Monto_Autorizado.Size = new System.Drawing.Size(174, 21);
            this.Lbl_Monto_Autorizado.TabIndex = 11;
            this.Lbl_Monto_Autorizado.Text = "Monto Autorizado:";
            // 
            // Txt_Autorizado_Por
            // 
            this.Txt_Autorizado_Por.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Autorizado_Por.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Autorizado_Por.Location = new System.Drawing.Point(718, 87);
            this.Txt_Autorizado_Por.Name = "Txt_Autorizado_Por";
            this.Txt_Autorizado_Por.Size = new System.Drawing.Size(218, 29);
            this.Txt_Autorizado_Por.TabIndex = 10;
            // 
            // Lbl_Autorizado_Por
            // 
            this.Lbl_Autorizado_Por.AutoSize = true;
            this.Lbl_Autorizado_Por.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Autorizado_Por.Location = new System.Drawing.Point(489, 92);
            this.Lbl_Autorizado_Por.Name = "Lbl_Autorizado_Por";
            this.Lbl_Autorizado_Por.Size = new System.Drawing.Size(149, 21);
            this.Lbl_Autorizado_Por.TabIndex = 9;
            this.Lbl_Autorizado_Por.Text = "Autorizado por:";
            // 
            // Txt_Monto_Autorizado
            // 
            this.Txt_Monto_Autorizado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Monto_Autorizado.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Monto_Autorizado.Location = new System.Drawing.Point(718, 140);
            this.Txt_Monto_Autorizado.Name = "Txt_Monto_Autorizado";
            this.Txt_Monto_Autorizado.Size = new System.Drawing.Size(218, 29);
            this.Txt_Monto_Autorizado.TabIndex = 15;
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
            // Btn_Agregar_Autorizacion
            // 
            this.Btn_Agregar_Autorizacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Autorizacion.Image")));
            this.Btn_Agregar_Autorizacion.Location = new System.Drawing.Point(606, 23);
            this.Btn_Agregar_Autorizacion.Name = "Btn_Agregar_Autorizacion";
            this.Btn_Agregar_Autorizacion.Size = new System.Drawing.Size(50, 45);
            this.Btn_Agregar_Autorizacion.TabIndex = 17;
            this.Btn_Agregar_Autorizacion.UseVisualStyleBackColor = true;
            this.Btn_Agregar_Autorizacion.Click += new System.EventHandler(this.Btn_Agregar_Autorizacion_Click);
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
            // Btn_Guardar_Autorizacion
            // 
            this.Btn_Guardar_Autorizacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar_Autorizacion.Image")));
            this.Btn_Guardar_Autorizacion.Location = new System.Drawing.Point(662, 23);
            this.Btn_Guardar_Autorizacion.Name = "Btn_Guardar_Autorizacion";
            this.Btn_Guardar_Autorizacion.Size = new System.Drawing.Size(50, 45);
            this.Btn_Guardar_Autorizacion.TabIndex = 19;
            this.Btn_Guardar_Autorizacion.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar_Autorizacion
            // 
            this.Btn_Eliminar_Autorizacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar_Autorizacion.Image")));
            this.Btn_Eliminar_Autorizacion.Location = new System.Drawing.Point(774, 23);
            this.Btn_Eliminar_Autorizacion.Name = "Btn_Eliminar_Autorizacion";
            this.Btn_Eliminar_Autorizacion.Size = new System.Drawing.Size(50, 45);
            this.Btn_Eliminar_Autorizacion.TabIndex = 21;
            this.Btn_Eliminar_Autorizacion.UseVisualStyleBackColor = true;
            // 
            // Btn_Modificar_Autorizacion
            // 
            this.Btn_Modificar_Autorizacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar_Autorizacion.Image")));
            this.Btn_Modificar_Autorizacion.Location = new System.Drawing.Point(718, 23);
            this.Btn_Modificar_Autorizacion.Name = "Btn_Modificar_Autorizacion";
            this.Btn_Modificar_Autorizacion.Size = new System.Drawing.Size(50, 45);
            this.Btn_Modificar_Autorizacion.TabIndex = 20;
            this.Btn_Modificar_Autorizacion.UseVisualStyleBackColor = true;
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
            // Btn_Consultar_Autorizaciones
            // 
            this.Btn_Consultar_Autorizaciones.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consultar_Autorizaciones.Location = new System.Drawing.Point(820, 306);
            this.Btn_Consultar_Autorizaciones.Name = "Btn_Consultar_Autorizaciones";
            this.Btn_Consultar_Autorizaciones.Size = new System.Drawing.Size(116, 31);
            this.Btn_Consultar_Autorizaciones.TabIndex = 24;
            this.Btn_Consultar_Autorizaciones.Text = "Consultar";
            this.Btn_Consultar_Autorizaciones.UseVisualStyleBackColor = true;
            this.Btn_Consultar_Autorizaciones.Click += new System.EventHandler(this.Btn_Consultar_Autorizaciones_Click);
            // 
            // Txt_Id_Orden
            // 
            this.Txt_Id_Orden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Id_Orden.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Id_Orden.Location = new System.Drawing.Point(241, 140);
            this.Txt_Id_Orden.Name = "Txt_Id_Orden";
            this.Txt_Id_Orden.Size = new System.Drawing.Size(218, 29);
            this.Txt_Id_Orden.TabIndex = 25;
            // 
            // Txt_Id_Banco
            // 
            this.Txt_Id_Banco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Id_Banco.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Id_Banco.Location = new System.Drawing.Point(241, 195);
            this.Txt_Id_Banco.Name = "Txt_Id_Banco";
            this.Txt_Id_Banco.Size = new System.Drawing.Size(218, 29);
            this.Txt_Id_Banco.TabIndex = 26;
            // 
            // Txt_Estado_Autorizacion
            // 
            this.Txt_Estado_Autorizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Estado_Autorizacion.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Estado_Autorizacion.Location = new System.Drawing.Point(718, 195);
            this.Txt_Estado_Autorizacion.Name = "Txt_Estado_Autorizacion";
            this.Txt_Estado_Autorizacion.Size = new System.Drawing.Size(218, 29);
            this.Txt_Estado_Autorizacion.TabIndex = 27;
            // 
            // Frm_Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 548);
            this.Controls.Add(this.Txt_Estado_Autorizacion);
            this.Controls.Add(this.Txt_Id_Banco);
            this.Controls.Add(this.Txt_Id_Orden);
            this.Controls.Add(this.Btn_Consultar_Autorizaciones);
            this.Controls.Add(this.Btn_Ayuda_Autorizacion);
            this.Controls.Add(this.Btn_Imprimir_Autorizacion);
            this.Controls.Add(this.Btn_Eliminar_Autorizacion);
            this.Controls.Add(this.Btn_Modificar_Autorizacion);
            this.Controls.Add(this.Btn_Guardar_Autorizacion);
            this.Controls.Add(this.Lbl_Detalle_Autorizaciones);
            this.Controls.Add(this.Btn_Agregar_Autorizacion);
            this.Controls.Add(this.Dgv_Auto_Ordenes);
            this.Controls.Add(this.Txt_Monto_Autorizado);
            this.Controls.Add(this.Lbl_Estado_Autorizacion);
            this.Controls.Add(this.Lbl_Monto_Autorizado);
            this.Controls.Add(this.Txt_Autorizado_Por);
            this.Controls.Add(this.Lbl_Autorizado_Por);
            this.Controls.Add(this.Txt_Fecha_Autorizacion);
            this.Controls.Add(this.Lbl_Fecha_Autorizacion);
            this.Controls.Add(this.Lbl_Id_Banco);
            this.Controls.Add(this.Lbl_Orden_Compra);
            this.Controls.Add(this.Txt_Id_Autorizacion);
            this.Controls.Add(this.Lbl_Id_Autorizacion);
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
        private System.Windows.Forms.Label Lbl_Id_Autorizacion;
        private System.Windows.Forms.TextBox Txt_Id_Autorizacion;
        private System.Windows.Forms.Label Lbl_Orden_Compra;
        private System.Windows.Forms.Label Lbl_Id_Banco;
        private System.Windows.Forms.TextBox Txt_Fecha_Autorizacion;
        private System.Windows.Forms.Label Lbl_Fecha_Autorizacion;
        private System.Windows.Forms.Label Lbl_Estado_Autorizacion;
        private System.Windows.Forms.Label Lbl_Monto_Autorizado;
        private System.Windows.Forms.TextBox Txt_Autorizado_Por;
        private System.Windows.Forms.Label Lbl_Autorizado_Por;
        private System.Windows.Forms.TextBox Txt_Monto_Autorizado;
        private System.Windows.Forms.DataGridView Dgv_Auto_Ordenes;
        private System.Windows.Forms.Button Btn_Agregar_Autorizacion;
        private System.Windows.Forms.Label Lbl_Detalle_Autorizaciones;
        private System.Windows.Forms.Button Btn_Guardar_Autorizacion;
        private System.Windows.Forms.Button Btn_Eliminar_Autorizacion;
        private System.Windows.Forms.Button Btn_Modificar_Autorizacion;
        private System.Windows.Forms.Button Btn_Ayuda_Autorizacion;
        private System.Windows.Forms.Button Btn_Imprimir_Autorizacion;
        private System.Windows.Forms.Button Btn_Consultar_Autorizaciones;
        private System.Windows.Forms.TextBox Txt_Id_Orden;
        private System.Windows.Forms.TextBox Txt_Id_Banco;
        private System.Windows.Forms.TextBox Txt_Estado_Autorizacion;
    }
}