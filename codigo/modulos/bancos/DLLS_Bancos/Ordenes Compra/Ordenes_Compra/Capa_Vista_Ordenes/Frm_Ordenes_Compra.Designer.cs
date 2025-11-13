
namespace Capa_Vista_Ordenes
{
    partial class Frm_Ordenes_Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ordenes_Compra));
            this.Btn_Agregar_Autorizacion = new System.Windows.Forms.Button();
            this.Btn_Ayuda_Autorizacion = new System.Windows.Forms.Button();
            this.Btn_Eliminar_Autorizacion = new System.Windows.Forms.Button();
            this.Btn_Actualizar_Autorizacion = new System.Windows.Forms.Button();
            this.Lbl_Titulo_Ordenes = new System.Windows.Forms.Label();
            this.Cbo_Id_Orden = new System.Windows.Forms.ComboBox();
            this.Cbo_Id_Banco = new System.Windows.Forms.ComboBox();
            this.Cbo_Id_Empleado = new System.Windows.Forms.ComboBox();
            this.Cbo_Id_Estado = new System.Windows.Forms.ComboBox();
            this.Txt_Id_Autorizacion = new System.Windows.Forms.TextBox();
            this.Dtp_dFecha_Autorizacion = new System.Windows.Forms.DateTimePicker();
            this.Nud_deMonto_Autorizado = new System.Windows.Forms.NumericUpDown();
            this.Txt_sObservaciones = new System.Windows.Forms.TextBox();
            this.Lbl_Id_Autorizacion = new System.Windows.Forms.Label();
            this.Lbl_Id_Orden = new System.Windows.Forms.Label();
            this.Lbl_Banco = new System.Windows.Forms.Label();
            this.Lbl_Empleado = new System.Windows.Forms.Label();
            this.Lbl_dFecha = new System.Windows.Forms.Label();
            this.Lbl_deMonto = new System.Windows.Forms.Label();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_sObservaciones = new System.Windows.Forms.Label();
            this.Dgv_Auto_Ordenes = new System.Windows.Forms.DataGridView();
            this.Lbl_Detalle = new System.Windows.Forms.Label();

            this.Btn_Limpiar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.Nud_deMonto_Autorizado)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Auto_Ordenes)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Agregar_Autorizacion
            // 
            this.Btn_Agregar_Autorizacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Autorizacion.Image")));

            this.Btn_Agregar_Autorizacion.Location = new System.Drawing.Point(684, 19);

            this.Btn_Agregar_Autorizacion.Name = "Btn_Agregar_Autorizacion";
            this.Btn_Agregar_Autorizacion.Size = new System.Drawing.Size(50, 45);
            this.Btn_Agregar_Autorizacion.TabIndex = 36;
            this.Btn_Agregar_Autorizacion.UseVisualStyleBackColor = true;
            this.Btn_Agregar_Autorizacion.Click += new System.EventHandler(this.Btn_Agregar_Autorizacion_Click);
            // 
            // Btn_Ayuda_Autorizacion
            // 
            this.Btn_Ayuda_Autorizacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda_Autorizacion.Image")));

            this.Btn_Ayuda_Autorizacion.Location = new System.Drawing.Point(908, 18);

            this.Btn_Ayuda_Autorizacion.Name = "Btn_Ayuda_Autorizacion";
            this.Btn_Ayuda_Autorizacion.Size = new System.Drawing.Size(50, 45);
            this.Btn_Ayuda_Autorizacion.TabIndex = 35;
            this.Btn_Ayuda_Autorizacion.UseVisualStyleBackColor = true;
            this.Btn_Ayuda_Autorizacion.Click += new System.EventHandler(this.Btn_Ayuda_Autorizacion_Click);
            // 

            // Btn_Eliminar_Autorizacion
            // 
            this.Btn_Eliminar_Autorizacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar_Autorizacion.Image")));
            this.Btn_Eliminar_Autorizacion.Location = new System.Drawing.Point(796, 18);

            this.Btn_Eliminar_Autorizacion.Name = "Btn_Eliminar_Autorizacion";
            this.Btn_Eliminar_Autorizacion.Size = new System.Drawing.Size(50, 45);
            this.Btn_Eliminar_Autorizacion.TabIndex = 33;
            this.Btn_Eliminar_Autorizacion.UseVisualStyleBackColor = true;
            this.Btn_Eliminar_Autorizacion.Click += new System.EventHandler(this.Btn_Eliminar_Autorizacion_Click);
            // 
            // Btn_Actualizar_Autorizacion
            // 
            this.Btn_Actualizar_Autorizacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Actualizar_Autorizacion.Image")));

            this.Btn_Actualizar_Autorizacion.Location = new System.Drawing.Point(740, 18);

            this.Btn_Actualizar_Autorizacion.Name = "Btn_Actualizar_Autorizacion";
            this.Btn_Actualizar_Autorizacion.Size = new System.Drawing.Size(50, 45);
            this.Btn_Actualizar_Autorizacion.TabIndex = 32;
            this.Btn_Actualizar_Autorizacion.UseVisualStyleBackColor = true;
            this.Btn_Actualizar_Autorizacion.Click += new System.EventHandler(this.Btn_Actualizar_Autorizacion_Click);
            // 
            // Lbl_Titulo_Ordenes
            // 
            this.Lbl_Titulo_Ordenes.AutoSize = true;
            this.Lbl_Titulo_Ordenes.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo_Ordenes.Location = new System.Drawing.Point(12, 18);
            this.Lbl_Titulo_Ordenes.Name = "Lbl_Titulo_Ordenes";
            this.Lbl_Titulo_Ordenes.Size = new System.Drawing.Size(484, 35);
            this.Lbl_Titulo_Ordenes.TabIndex = 31;
            this.Lbl_Titulo_Ordenes.Text = "Autorización Ordenes de Compra";
            // 
            // Cbo_Id_Orden
            // 
            this.Cbo_Id_Orden.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Id_Orden.FormattingEnabled = true;

            this.Cbo_Id_Orden.Location = new System.Drawing.Point(276, 176);
            this.Cbo_Id_Orden.Name = "Cbo_Id_Orden";
            this.Cbo_Id_Orden.Size = new System.Drawing.Size(185, 28);

            this.Cbo_Id_Orden.TabIndex = 37;
            // 
            // Cbo_Id_Banco
            // 
            this.Cbo_Id_Banco.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Id_Banco.FormattingEnabled = true;

            this.Cbo_Id_Banco.Location = new System.Drawing.Point(276, 245);
            this.Cbo_Id_Banco.Name = "Cbo_Id_Banco";
            this.Cbo_Id_Banco.Size = new System.Drawing.Size(185, 28);

            this.Cbo_Id_Banco.TabIndex = 38;
            // 
            // Cbo_Id_Empleado
            // 
            this.Cbo_Id_Empleado.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Id_Empleado.FormattingEnabled = true;

            this.Cbo_Id_Empleado.Location = new System.Drawing.Point(774, 107);
            this.Cbo_Id_Empleado.Name = "Cbo_Id_Empleado";
            this.Cbo_Id_Empleado.Size = new System.Drawing.Size(185, 28);

            this.Cbo_Id_Empleado.TabIndex = 39;
            // 
            // Cbo_Id_Estado
            // 
            this.Cbo_Id_Estado.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Id_Estado.FormattingEnabled = true;

            this.Cbo_Id_Estado.Location = new System.Drawing.Point(276, 308);
            this.Cbo_Id_Estado.Name = "Cbo_Id_Estado";
            this.Cbo_Id_Estado.Size = new System.Drawing.Size(185, 28);

            this.Cbo_Id_Estado.TabIndex = 40;
            // 
            // Txt_Id_Autorizacion
            // 
            this.Txt_Id_Autorizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Id_Autorizacion.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.Txt_Id_Autorizacion.Location = new System.Drawing.Point(276, 108);
            this.Txt_Id_Autorizacion.Name = "Txt_Id_Autorizacion";
            this.Txt_Id_Autorizacion.Size = new System.Drawing.Size(185, 29);

            this.Txt_Id_Autorizacion.TabIndex = 41;
            // 
            // Dtp_dFecha_Autorizacion
            // 

            this.Dtp_dFecha_Autorizacion.CalendarFont = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_dFecha_Autorizacion.Location = new System.Drawing.Point(774, 178);
            this.Dtp_dFecha_Autorizacion.Name = "Dtp_dFecha_Autorizacion";
            this.Dtp_dFecha_Autorizacion.Size = new System.Drawing.Size(185, 22);
            this.Dtp_dFecha_Autorizacion.TabIndex = 42;

            // 
            // Nud_deMonto_Autorizado
            // 

            this.Nud_deMonto_Autorizado.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nud_deMonto_Autorizado.Location = new System.Drawing.Point(774, 242);
            this.Nud_deMonto_Autorizado.Name = "Nud_deMonto_Autorizado";
            this.Nud_deMonto_Autorizado.Size = new System.Drawing.Size(185, 29);
            this.Nud_deMonto_Autorizado.TabIndex = 43;

            // 
            // Txt_sObservaciones
            // 

            this.Txt_sObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_sObservaciones.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_sObservaciones.Location = new System.Drawing.Point(774, 309);
            this.Txt_sObservaciones.Name = "Txt_sObservaciones";
            this.Txt_sObservaciones.Size = new System.Drawing.Size(185, 29);
            this.Txt_sObservaciones.TabIndex = 44;

            // 
            // Lbl_Id_Autorizacion
            // 
            this.Lbl_Id_Autorizacion.AutoSize = true;
            this.Lbl_Id_Autorizacion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.Lbl_Id_Autorizacion.Location = new System.Drawing.Point(14, 111);

            this.Lbl_Id_Autorizacion.Name = "Lbl_Id_Autorizacion";
            this.Lbl_Id_Autorizacion.Size = new System.Drawing.Size(185, 22);
            this.Lbl_Id_Autorizacion.TabIndex = 45;
            this.Lbl_Id_Autorizacion.Text = "ID de Autorizacion:";
            // 
            // Lbl_Id_Orden
            // 
            this.Lbl_Id_Orden.AutoSize = true;
            this.Lbl_Id_Orden.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.Lbl_Id_Orden.Location = new System.Drawing.Point(14, 178);

            this.Lbl_Id_Orden.Name = "Lbl_Id_Orden";
            this.Lbl_Id_Orden.Size = new System.Drawing.Size(239, 22);
            this.Lbl_Id_Orden.TabIndex = 46;
            this.Lbl_Id_Orden.Text = "ID de Orden de Compra:";
            // 
            // Lbl_Banco
            // 
            this.Lbl_Banco.AutoSize = true;
            this.Lbl_Banco.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.Lbl_Banco.Location = new System.Drawing.Point(14, 243);

            this.Lbl_Banco.Name = "Lbl_Banco";
            this.Lbl_Banco.Size = new System.Drawing.Size(179, 22);
            this.Lbl_Banco.TabIndex = 47;
            this.Lbl_Banco.Text = "Nombre de Banco:";
            // 
            // Lbl_Empleado
            // 
            this.Lbl_Empleado.AutoSize = true;
            this.Lbl_Empleado.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.Lbl_Empleado.Location = new System.Drawing.Point(504, 108);

            this.Lbl_Empleado.Name = "Lbl_Empleado";
            this.Lbl_Empleado.Size = new System.Drawing.Size(219, 22);
            this.Lbl_Empleado.TabIndex = 48;
            this.Lbl_Empleado.Text = "Nombre de Empleado:";
            // 
            // Lbl_dFecha
            // 

            this.Lbl_dFecha.AutoSize = true;
            this.Lbl_dFecha.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_dFecha.Location = new System.Drawing.Point(505, 173);
            this.Lbl_dFecha.Name = "Lbl_dFecha";
            this.Lbl_dFecha.Size = new System.Drawing.Size(218, 22);
            this.Lbl_dFecha.TabIndex = 49;
            this.Lbl_dFecha.Text = "Fecha de Autorizacion:";

            // 
            // Lbl_deMonto
            // 

            this.Lbl_deMonto.AutoSize = true;
            this.Lbl_deMonto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_deMonto.Location = new System.Drawing.Point(505, 243);
            this.Lbl_deMonto.Name = "Lbl_deMonto";
            this.Lbl_deMonto.Size = new System.Drawing.Size(178, 22);
            this.Lbl_deMonto.TabIndex = 50;
            this.Lbl_deMonto.Text = "Monto Autorizado:";

            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.Lbl_Estado.Location = new System.Drawing.Point(14, 311);

            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(172, 22);
            this.Lbl_Estado.TabIndex = 51;
            this.Lbl_Estado.Text = "Estado de Orden:";
            // 
            // Lbl_sObservaciones
            // 

            this.Lbl_sObservaciones.AutoSize = true;
            this.Lbl_sObservaciones.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sObservaciones.Location = new System.Drawing.Point(505, 306);
            this.Lbl_sObservaciones.Name = "Lbl_sObservaciones";
            this.Lbl_sObservaciones.Size = new System.Drawing.Size(153, 22);
            this.Lbl_sObservaciones.TabIndex = 52;
            this.Lbl_sObservaciones.Text = "Observaciones:";

            // 
            // Dgv_Auto_Ordenes
            // 
            this.Dgv_Auto_Ordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Auto_Ordenes.Location = new System.Drawing.Point(18, 410);
            this.Dgv_Auto_Ordenes.Name = "Dgv_Auto_Ordenes";
            this.Dgv_Auto_Ordenes.RowHeadersWidth = 51;
            this.Dgv_Auto_Ordenes.RowTemplate.Height = 24;

            this.Dgv_Auto_Ordenes.Size = new System.Drawing.Size(941, 180);

            this.Dgv_Auto_Ordenes.TabIndex = 53;
            // 
            // Lbl_Detalle
            // 
            this.Lbl_Detalle.AutoSize = true;
            this.Lbl_Detalle.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Detalle.Location = new System.Drawing.Point(14, 385);
            this.Lbl_Detalle.Name = "Lbl_Detalle";
            this.Lbl_Detalle.Size = new System.Drawing.Size(221, 22);
            this.Lbl_Detalle.TabIndex = 54;
            this.Lbl_Detalle.Text = "Detalle Autorizaciones:";
            // 

            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar.Image")));
            this.Btn_Limpiar.Location = new System.Drawing.Point(852, 19);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(50, 45);
            this.Btn_Limpiar.TabIndex = 55;
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 

            // Frm_Ordenes_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(980, 602);
            this.Controls.Add(this.Btn_Limpiar);

            this.Controls.Add(this.Lbl_Detalle);
            this.Controls.Add(this.Dgv_Auto_Ordenes);
            this.Controls.Add(this.Lbl_sObservaciones);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.Lbl_deMonto);
            this.Controls.Add(this.Lbl_dFecha);
            this.Controls.Add(this.Lbl_Empleado);
            this.Controls.Add(this.Lbl_Banco);
            this.Controls.Add(this.Lbl_Id_Orden);
            this.Controls.Add(this.Lbl_Id_Autorizacion);
            this.Controls.Add(this.Txt_sObservaciones);
            this.Controls.Add(this.Nud_deMonto_Autorizado);
            this.Controls.Add(this.Dtp_dFecha_Autorizacion);
            this.Controls.Add(this.Txt_Id_Autorizacion);
            this.Controls.Add(this.Cbo_Id_Estado);
            this.Controls.Add(this.Cbo_Id_Empleado);
            this.Controls.Add(this.Cbo_Id_Banco);
            this.Controls.Add(this.Cbo_Id_Orden);
            this.Controls.Add(this.Btn_Agregar_Autorizacion);
            this.Controls.Add(this.Btn_Ayuda_Autorizacion);
            this.Controls.Add(this.Btn_Eliminar_Autorizacion);
            this.Controls.Add(this.Btn_Actualizar_Autorizacion);
            this.Controls.Add(this.Lbl_Titulo_Ordenes);
            this.Name = "Frm_Ordenes_Compra";
            this.Text = "Frm_Ordenes_Compra";

            this.Load += new System.EventHandler(this.Frm_Ordenes_Compra_Load_1);

            ((System.ComponentModel.ISupportInitialize)(this.Nud_deMonto_Autorizado)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Auto_Ordenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Agregar_Autorizacion;
        private System.Windows.Forms.Button Btn_Ayuda_Autorizacion;
        private System.Windows.Forms.Button Btn_Eliminar_Autorizacion;
        private System.Windows.Forms.Button Btn_Actualizar_Autorizacion;
        private System.Windows.Forms.Label Lbl_Titulo_Ordenes;
        private System.Windows.Forms.ComboBox Cbo_Id_Orden;
        private System.Windows.Forms.ComboBox Cbo_Id_Banco;
        private System.Windows.Forms.ComboBox Cbo_Id_Empleado;
        private System.Windows.Forms.ComboBox Cbo_Id_Estado;
        private System.Windows.Forms.TextBox Txt_Id_Autorizacion;
        private System.Windows.Forms.DateTimePicker Dtp_dFecha_Autorizacion;
        private System.Windows.Forms.NumericUpDown Nud_deMonto_Autorizado;
        private System.Windows.Forms.TextBox Txt_sObservaciones;
        private System.Windows.Forms.Label Lbl_Id_Autorizacion;
        private System.Windows.Forms.Label Lbl_Id_Orden;
        private System.Windows.Forms.Label Lbl_Banco;
        private System.Windows.Forms.Label Lbl_Empleado;
        private System.Windows.Forms.Label Lbl_dFecha;
        private System.Windows.Forms.Label Lbl_deMonto;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_sObservaciones;
        private System.Windows.Forms.DataGridView Dgv_Auto_Ordenes;
        private System.Windows.Forms.Label Lbl_Detalle;

        private System.Windows.Forms.Button Btn_Limpiar;

    }
}