
namespace Capa_Vista_CB
{
    partial class Frm_ConciliacionBancaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConciliacionBancaria));
            this.Lbl_TituloBC = new System.Windows.Forms.Label();
            this.Lbl_Banco = new System.Windows.Forms.Label();
            this.Cbo_Bancos = new System.Windows.Forms.ComboBox();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Dtp_FechaConciliacion = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Mes = new System.Windows.Forms.Label();
            this.Cbo_Mes = new System.Windows.Forms.ComboBox();
            this.Lbl_anio = new System.Windows.Forms.Label();
            this.Txt_Anio = new System.Windows.Forms.TextBox();
            this.Gpb_Encabezado = new System.Windows.Forms.GroupBox();
            this.Lbl_SaldoLibros = new System.Windows.Forms.Label();
            this.Lbl_Diferencia = new System.Windows.Forms.Label();
            this.Lbl_Observaciones = new System.Windows.Forms.Label();
            this.Lbl_SaldoBanco = new System.Windows.Forms.Label();
            this.Txt_SaldoLibros = new System.Windows.Forms.TextBox();
            this.Txt_SaldoBanco = new System.Windows.Forms.TextBox();
            this.Txt_Diferencias = new System.Windows.Forms.TextBox();
            this.Txt_Observaciones = new System.Windows.Forms.TextBox();
            this.Btn_LimpiarCampos = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_BuscarConciliacion = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Lbl_Cuenta = new System.Windows.Forms.Label();
            this.Cbo_Cuenta = new System.Windows.Forms.ComboBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Chk_Estado = new System.Windows.Forms.CheckBox();
            this.Gpb_Fin = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Lbl_TituloBC
            // 
            this.Lbl_TituloBC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_TituloBC.AutoSize = true;
            this.Lbl_TituloBC.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TituloBC.Location = new System.Drawing.Point(430, 9);
            this.Lbl_TituloBC.Name = "Lbl_TituloBC";
            this.Lbl_TituloBC.Size = new System.Drawing.Size(347, 38);
            this.Lbl_TituloBC.TabIndex = 0;
            this.Lbl_TituloBC.Text = "Conciliación Bancaria";
            this.Lbl_TituloBC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_Banco
            // 
            this.Lbl_Banco.AutoSize = true;
            this.Lbl_Banco.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Banco.Location = new System.Drawing.Point(12, 153);
            this.Lbl_Banco.Name = "Lbl_Banco";
            this.Lbl_Banco.Size = new System.Drawing.Size(68, 20);
            this.Lbl_Banco.TabIndex = 1;
            this.Lbl_Banco.Text = "Banco:";
            // 
            // Cbo_Bancos
            // 
            this.Cbo_Bancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_Bancos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Bancos.FormattingEnabled = true;
            this.Cbo_Bancos.Location = new System.Drawing.Point(96, 150);
            this.Cbo_Bancos.Name = "Cbo_Bancos";
            this.Cbo_Bancos.Size = new System.Drawing.Size(316, 28);
            this.Cbo_Bancos.TabIndex = 2;
            this.Cbo_Bancos.SelectedIndexChanged += new System.EventHandler(this.Cbo_Bancos_SelectedIndexChanged);
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(769, 150);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(67, 20);
            this.Lbl_Fecha.TabIndex = 3;
            this.Lbl_Fecha.Text = "Fecha:";
            // 
            // Dtp_FechaConciliacion
            // 
            this.Dtp_FechaConciliacion.CalendarFont = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaConciliacion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaConciliacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaConciliacion.Location = new System.Drawing.Point(842, 145);
            this.Dtp_FechaConciliacion.Name = "Dtp_FechaConciliacion";
            this.Dtp_FechaConciliacion.Size = new System.Drawing.Size(316, 27);
            this.Dtp_FechaConciliacion.TabIndex = 4;
            this.Dtp_FechaConciliacion.ValueChanged += new System.EventHandler(this.Dtp_FechaConciliacion_ValueChanged);
            // 
            // Lbl_Mes
            // 
            this.Lbl_Mes.AutoSize = true;
            this.Lbl_Mes.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mes.Location = new System.Drawing.Point(784, 187);
            this.Lbl_Mes.Name = "Lbl_Mes";
            this.Lbl_Mes.Size = new System.Drawing.Size(52, 20);
            this.Lbl_Mes.TabIndex = 5;
            this.Lbl_Mes.Text = "Mes:";
            // 
            // Cbo_Mes
            // 
            this.Cbo_Mes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_Mes.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Mes.FormattingEnabled = true;
            this.Cbo_Mes.Location = new System.Drawing.Point(842, 185);
            this.Cbo_Mes.Name = "Cbo_Mes";
            this.Cbo_Mes.Size = new System.Drawing.Size(316, 28);
            this.Cbo_Mes.TabIndex = 5;
            this.Cbo_Mes.SelectedIndexChanged += new System.EventHandler(this.Cbo_Mes_SelectedIndexChanged);
            // 
            // Lbl_anio
            // 
            this.Lbl_anio.AutoSize = true;
            this.Lbl_anio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_anio.Location = new System.Drawing.Point(788, 219);
            this.Lbl_anio.Name = "Lbl_anio";
            this.Lbl_anio.Size = new System.Drawing.Size(48, 20);
            this.Lbl_anio.TabIndex = 7;
            this.Lbl_anio.Text = "Año:";
            // 
            // Txt_Anio
            // 
            this.Txt_Anio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Anio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Anio.Location = new System.Drawing.Point(842, 219);
            this.Txt_Anio.Name = "Txt_Anio";
            this.Txt_Anio.Size = new System.Drawing.Size(316, 20);
            this.Txt_Anio.TabIndex = 6;
            this.Txt_Anio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Anio.TextChanged += new System.EventHandler(this.Txt_Anio_TextChanged);
            // 
            // Gpb_Encabezado
            // 
            this.Gpb_Encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(76)))));
            this.Gpb_Encabezado.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Encabezado.Location = new System.Drawing.Point(12, 107);
            this.Gpb_Encabezado.Name = "Gpb_Encabezado";
            this.Gpb_Encabezado.Size = new System.Drawing.Size(1146, 25);
            this.Gpb_Encabezado.TabIndex = 9;
            this.Gpb_Encabezado.TabStop = false;
            this.Gpb_Encabezado.Text = "Encabezado de Conciliación";
            // 
            // Lbl_SaldoLibros
            // 
            this.Lbl_SaldoLibros.AutoSize = true;
            this.Lbl_SaldoLibros.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SaldoLibros.Location = new System.Drawing.Point(14, 281);
            this.Lbl_SaldoLibros.Name = "Lbl_SaldoLibros";
            this.Lbl_SaldoLibros.Size = new System.Drawing.Size(120, 20);
            this.Lbl_SaldoLibros.TabIndex = 10;
            this.Lbl_SaldoLibros.Text = "Saldo Libros:";
            // 
            // Lbl_Diferencia
            // 
            this.Lbl_Diferencia.AutoSize = true;
            this.Lbl_Diferencia.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Diferencia.Location = new System.Drawing.Point(578, 263);
            this.Lbl_Diferencia.Name = "Lbl_Diferencia";
            this.Lbl_Diferencia.Size = new System.Drawing.Size(106, 20);
            this.Lbl_Diferencia.TabIndex = 11;
            this.Lbl_Diferencia.Text = "Diferencia:";
            // 
            // Lbl_Observaciones
            // 
            this.Lbl_Observaciones.AutoSize = true;
            this.Lbl_Observaciones.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Observaciones.Location = new System.Drawing.Point(12, 331);
            this.Lbl_Observaciones.Name = "Lbl_Observaciones";
            this.Lbl_Observaciones.Size = new System.Drawing.Size(144, 20);
            this.Lbl_Observaciones.TabIndex = 12;
            this.Lbl_Observaciones.Text = "Observaciones:";
            // 
            // Lbl_SaldoBanco
            // 
            this.Lbl_SaldoBanco.AutoSize = true;
            this.Lbl_SaldoBanco.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SaldoBanco.Location = new System.Drawing.Point(14, 249);
            this.Lbl_SaldoBanco.Name = "Lbl_SaldoBanco";
            this.Lbl_SaldoBanco.Size = new System.Drawing.Size(114, 20);
            this.Lbl_SaldoBanco.TabIndex = 14;
            this.Lbl_SaldoBanco.Text = "SaldoBanco:";
            // 
            // Txt_SaldoLibros
            // 
            this.Txt_SaldoLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_SaldoLibros.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SaldoLibros.Location = new System.Drawing.Point(140, 281);
            this.Txt_SaldoLibros.Name = "Txt_SaldoLibros";
            this.Txt_SaldoLibros.Size = new System.Drawing.Size(349, 20);
            this.Txt_SaldoLibros.TabIndex = 8;
            this.Txt_SaldoLibros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_SaldoLibros.TextChanged += new System.EventHandler(this.Txt_SaldoLibros_TextChanged);
            // 
            // Txt_SaldoBanco
            // 
            this.Txt_SaldoBanco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_SaldoBanco.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SaldoBanco.Location = new System.Drawing.Point(134, 249);
            this.Txt_SaldoBanco.Name = "Txt_SaldoBanco";
            this.Txt_SaldoBanco.Size = new System.Drawing.Size(349, 20);
            this.Txt_SaldoBanco.TabIndex = 7;
            this.Txt_SaldoBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_SaldoBanco.TextChanged += new System.EventHandler(this.Txt_SaldoBanco_TextChanged);
            // 
            // Txt_Diferencias
            // 
            this.Txt_Diferencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Diferencias.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Diferencias.Location = new System.Drawing.Point(690, 263);
            this.Txt_Diferencias.Name = "Txt_Diferencias";
            this.Txt_Diferencias.Size = new System.Drawing.Size(316, 20);
            this.Txt_Diferencias.TabIndex = 9;
            this.Txt_Diferencias.TabStop = false;
            this.Txt_Diferencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_Diferencias.TextChanged += new System.EventHandler(this.Txt_Diferencias_TextChanged);
            // 
            // Txt_Observaciones
            // 
            this.Txt_Observaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Observaciones.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Observaciones.Location = new System.Drawing.Point(164, 331);
            this.Txt_Observaciones.Name = "Txt_Observaciones";
            this.Txt_Observaciones.Size = new System.Drawing.Size(985, 20);
            this.Txt_Observaciones.TabIndex = 10;
            this.Txt_Observaciones.TextChanged += new System.EventHandler(this.Txt_Observaciones_TextChanged);
            // 
            // Btn_LimpiarCampos
            // 
            this.Btn_LimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LimpiarCampos.Image = ((System.Drawing.Image)(resources.GetObject("Btn_LimpiarCampos.Image")));
            this.Btn_LimpiarCampos.Location = new System.Drawing.Point(124, 51);
            this.Btn_LimpiarCampos.Name = "Btn_LimpiarCampos";
            this.Btn_LimpiarCampos.Size = new System.Drawing.Size(50, 50);
            this.Btn_LimpiarCampos.TabIndex = 14;
            this.Btn_LimpiarCampos.UseVisualStyleBackColor = true;
            this.Btn_LimpiarCampos.Click += new System.EventHandler(this.Btn_LimpiarCampos_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Font = new System.Drawing.Font("Rockwell", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Location = new System.Drawing.Point(12, 51);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(50, 50);
            this.Btn_Guardar.TabIndex = 12;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_BuscarConciliacion
            // 
            this.Btn_BuscarConciliacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BuscarConciliacion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_BuscarConciliacion.Image")));
            this.Btn_BuscarConciliacion.Location = new System.Drawing.Point(68, 51);
            this.Btn_BuscarConciliacion.Name = "Btn_BuscarConciliacion";
            this.Btn_BuscarConciliacion.Size = new System.Drawing.Size(50, 50);
            this.Btn_BuscarConciliacion.TabIndex = 13;
            this.Btn_BuscarConciliacion.UseVisualStyleBackColor = true;
            this.Btn_BuscarConciliacion.Click += new System.EventHandler(this.Btn_BuscarConciliacion_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(1108, 8);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(50, 50);
            this.Btn_Salir.TabIndex = 16;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(1052, 8);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(50, 50);
            this.Btn_Ayuda.TabIndex = 15;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            this.Btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // Lbl_Cuenta
            // 
            this.Lbl_Cuenta.AutoSize = true;
            this.Lbl_Cuenta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cuenta.Location = new System.Drawing.Point(14, 188);
            this.Lbl_Cuenta.Name = "Lbl_Cuenta";
            this.Lbl_Cuenta.Size = new System.Drawing.Size(76, 20);
            this.Lbl_Cuenta.TabIndex = 47;
            this.Lbl_Cuenta.Text = "Cuenta:";
            // 
            // Cbo_Cuenta
            // 
            this.Cbo_Cuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_Cuenta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Cuenta.FormattingEnabled = true;
            this.Cbo_Cuenta.Location = new System.Drawing.Point(96, 185);
            this.Cbo_Cuenta.Name = "Cbo_Cuenta";
            this.Cbo_Cuenta.Size = new System.Drawing.Size(316, 28);
            this.Cbo_Cuenta.TabIndex = 3;
            this.Cbo_Cuenta.SelectedIndexChanged += new System.EventHandler(this.Cbo_Cuenta_SelectedIndexChanged);
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(12, 380);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(72, 20);
            this.Lbl_Estado.TabIndex = 13;
            this.Lbl_Estado.Text = "Estado:";
            // 
            // Chk_Estado
            // 
            this.Chk_Estado.AutoSize = true;
            this.Chk_Estado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_Estado.Location = new System.Drawing.Point(96, 380);
            this.Chk_Estado.Name = "Chk_Estado";
            this.Chk_Estado.Size = new System.Drawing.Size(156, 24);
            this.Chk_Estado.TabIndex = 11;
            this.Chk_Estado.Text = "Activa / Inactiva";
            this.Chk_Estado.UseVisualStyleBackColor = true;
            this.Chk_Estado.CheckedChanged += new System.EventHandler(this.Chk_Estado_CheckedChanged);
            // 
            // Gpb_Fin
            // 
            this.Gpb_Fin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(76)))));
            this.Gpb_Fin.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Fin.Location = new System.Drawing.Point(9, 416);
            this.Gpb_Fin.Name = "Gpb_Fin";
            this.Gpb_Fin.Size = new System.Drawing.Size(1140, 25);
            this.Gpb_Fin.TabIndex = 12;
            this.Gpb_Fin.TabStop = false;
            // 
            // Frm_ConciliacionBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1182, 453);
            this.Controls.Add(this.Gpb_Fin);
            this.Controls.Add(this.Cbo_Cuenta);
            this.Controls.Add(this.Lbl_Cuenta);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_BuscarConciliacion);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_LimpiarCampos);
            this.Controls.Add(this.Chk_Estado);
            this.Controls.Add(this.Txt_Observaciones);
            this.Controls.Add(this.Txt_Diferencias);
            this.Controls.Add(this.Txt_SaldoBanco);
            this.Controls.Add(this.Txt_SaldoLibros);
            this.Controls.Add(this.Lbl_SaldoBanco);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.Lbl_Observaciones);
            this.Controls.Add(this.Lbl_Diferencia);
            this.Controls.Add(this.Lbl_SaldoLibros);
            this.Controls.Add(this.Gpb_Encabezado);
            this.Controls.Add(this.Txt_Anio);
            this.Controls.Add(this.Lbl_anio);
            this.Controls.Add(this.Cbo_Mes);
            this.Controls.Add(this.Lbl_Mes);
            this.Controls.Add(this.Dtp_FechaConciliacion);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.Cbo_Bancos);
            this.Controls.Add(this.Lbl_Banco);
            this.Controls.Add(this.Lbl_TituloBC);
            this.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_ConciliacionBancaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ConciliacionBancaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_TituloBC;
        private System.Windows.Forms.Label Lbl_Banco;
        private System.Windows.Forms.ComboBox Cbo_Bancos;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.DateTimePicker Dtp_FechaConciliacion;
        private System.Windows.Forms.Label Lbl_Mes;
        private System.Windows.Forms.ComboBox Cbo_Mes;
        private System.Windows.Forms.Label Lbl_anio;
        private System.Windows.Forms.TextBox Txt_Anio;
        private System.Windows.Forms.GroupBox Gpb_Encabezado;
        private System.Windows.Forms.Label Lbl_SaldoLibros;
        private System.Windows.Forms.Label Lbl_Diferencia;
        private System.Windows.Forms.Label Lbl_Observaciones;
        private System.Windows.Forms.Label Lbl_SaldoBanco;
        private System.Windows.Forms.TextBox Txt_SaldoLibros;
        private System.Windows.Forms.TextBox Txt_SaldoBanco;
        private System.Windows.Forms.TextBox Txt_Diferencias;
        private System.Windows.Forms.TextBox Txt_Observaciones;
        private System.Windows.Forms.Button Btn_LimpiarCampos;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_BuscarConciliacion;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Label Lbl_Cuenta;
        private System.Windows.Forms.ComboBox Cbo_Cuenta;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.CheckBox Chk_Estado;
        private System.Windows.Forms.GroupBox Gpb_Fin;
    }
}