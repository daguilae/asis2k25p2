
namespace Capa_Vista_MH
{
    partial class Frm_ObjetosPerdidos
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
            this.Dtp_Fecha_Encontrado = new System.Windows.Forms.DateTimePicker();
            this.Txt_Descripcion_Objeto = new System.Windows.Forms.TextBox();
            this.Txt_Nombre_Objeto = new System.Windows.Forms.TextBox();
            this.Cbo_Id_Mantenimiento = new System.Windows.Forms.ComboBox();
            this.Cbo_Id_FolioHabitacion = new System.Windows.Forms.ComboBox();
            this.Cbo_Id_FolioSalon = new System.Windows.Forms.ComboBox();
            this.Cbo_Id_Objeto = new System.Windows.Forms.ComboBox();
            this.Lbl_Fecha_Enc = new System.Windows.Forms.Label();
            this.Lbl_Tipo_obj = new System.Windows.Forms.Label();
            this.Lbl_Desc_objeto = new System.Windows.Forms.Label();
            this.Lbl_Nombre_obj = new System.Windows.Forms.Label();
            this.Lbl_Id_Huesped = new System.Windows.Forms.Label();
            this.Lbl_Id_FolioS = new System.Windows.Forms.Label();
            this.Lbl_Id_FolioH = new System.Windows.Forms.Label();
            this.Lbl_Id_Mantenimiento = new System.Windows.Forms.Label();
            this.Lbl_Id_Objeto = new System.Windows.Forms.Label();
            this.Dgv_Objeto_Perdido = new System.Windows.Forms.DataGridView();
            this.Lbl_Objetos_Perdidos = new System.Windows.Forms.Label();
            this.Pic_Salir = new System.Windows.Forms.PictureBox();
            this.Pic_Reporte = new System.Windows.Forms.PictureBox();
            this.Pic_Buscar = new System.Windows.Forms.PictureBox();
            this.Pic_Eliminar = new System.Windows.Forms.PictureBox();
            this.Pic_Guardar = new System.Windows.Forms.PictureBox();
            this.Pic_Editar = new System.Windows.Forms.PictureBox();
            this.Pic_Cancelar = new System.Windows.Forms.PictureBox();
            this.Lbl_Entregado = new System.Windows.Forms.Label();
            this.Chk_Entregado = new System.Windows.Forms.CheckBox();
            this.Txt_Tipo_Objeto = new System.Windows.Forms.TextBox();
            this.Cbo_Id_Huesped = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Objeto_Perdido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Reporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtp_Fecha_Encontrado
            // 
            this.Dtp_Fecha_Encontrado.Location = new System.Drawing.Point(820, 367);
            this.Dtp_Fecha_Encontrado.Name = "Dtp_Fecha_Encontrado";
            this.Dtp_Fecha_Encontrado.Size = new System.Drawing.Size(210, 22);
            this.Dtp_Fecha_Encontrado.TabIndex = 146;
            this.Dtp_Fecha_Encontrado.ValueChanged += new System.EventHandler(this.Dtp_Fecha_Encontrado_ValueChanged);
            // 
            // Txt_Descripcion_Objeto
            // 
            this.Txt_Descripcion_Objeto.Location = new System.Drawing.Point(820, 203);
            this.Txt_Descripcion_Objeto.Name = "Txt_Descripcion_Objeto";
            this.Txt_Descripcion_Objeto.Size = new System.Drawing.Size(210, 22);
            this.Txt_Descripcion_Objeto.TabIndex = 144;
            this.Txt_Descripcion_Objeto.TextChanged += new System.EventHandler(this.Txt_Descripcion_Objeto_TextChanged);
            // 
            // Txt_Nombre_Objeto
            // 
            this.Txt_Nombre_Objeto.Location = new System.Drawing.Point(487, 369);
            this.Txt_Nombre_Objeto.Name = "Txt_Nombre_Objeto";
            this.Txt_Nombre_Objeto.Size = new System.Drawing.Size(210, 22);
            this.Txt_Nombre_Objeto.TabIndex = 143;
            this.Txt_Nombre_Objeto.TextChanged += new System.EventHandler(this.Txt_Nombre_Objeto_TextChanged);
            // 
            // Cbo_Id_Mantenimiento
            // 
            this.Cbo_Id_Mantenimiento.FormattingEnabled = true;
            this.Cbo_Id_Mantenimiento.Location = new System.Drawing.Point(487, 203);
            this.Cbo_Id_Mantenimiento.Name = "Cbo_Id_Mantenimiento";
            this.Cbo_Id_Mantenimiento.Size = new System.Drawing.Size(210, 24);
            this.Cbo_Id_Mantenimiento.TabIndex = 141;
            this.Cbo_Id_Mantenimiento.SelectedIndexChanged += new System.EventHandler(this.Cbo_Id_Mantenimiento_SelectedIndexChanged);
            // 
            // Cbo_Id_FolioHabitacion
            // 
            this.Cbo_Id_FolioHabitacion.FormattingEnabled = true;
            this.Cbo_Id_FolioHabitacion.Location = new System.Drawing.Point(130, 367);
            this.Cbo_Id_FolioHabitacion.Name = "Cbo_Id_FolioHabitacion";
            this.Cbo_Id_FolioHabitacion.Size = new System.Drawing.Size(210, 24);
            this.Cbo_Id_FolioHabitacion.TabIndex = 140;
            this.Cbo_Id_FolioHabitacion.SelectedIndexChanged += new System.EventHandler(this.Cbo_Id_FolioHabitacion_SelectedIndexChanged);
            // 
            // Cbo_Id_FolioSalon
            // 
            this.Cbo_Id_FolioSalon.FormattingEnabled = true;
            this.Cbo_Id_FolioSalon.Location = new System.Drawing.Point(130, 286);
            this.Cbo_Id_FolioSalon.Name = "Cbo_Id_FolioSalon";
            this.Cbo_Id_FolioSalon.Size = new System.Drawing.Size(210, 24);
            this.Cbo_Id_FolioSalon.TabIndex = 139;
            this.Cbo_Id_FolioSalon.SelectedIndexChanged += new System.EventHandler(this.Cbo_Id_FolioSalon_SelectedIndexChanged);
            // 
            // Cbo_Id_Objeto
            // 
            this.Cbo_Id_Objeto.FormattingEnabled = true;
            this.Cbo_Id_Objeto.Location = new System.Drawing.Point(130, 203);
            this.Cbo_Id_Objeto.Name = "Cbo_Id_Objeto";
            this.Cbo_Id_Objeto.Size = new System.Drawing.Size(210, 24);
            this.Cbo_Id_Objeto.TabIndex = 138;
            this.Cbo_Id_Objeto.SelectedIndexChanged += new System.EventHandler(this.Cbo_Id_Objeto_SelectedIndexChanged);
            // 
            // Lbl_Fecha_Enc
            // 
            this.Lbl_Fecha_Enc.AutoSize = true;
            this.Lbl_Fecha_Enc.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_Fecha_Enc.Location = new System.Drawing.Point(816, 332);
            this.Lbl_Fecha_Enc.Name = "Lbl_Fecha_Enc";
            this.Lbl_Fecha_Enc.Size = new System.Drawing.Size(151, 20);
            this.Lbl_Fecha_Enc.TabIndex = 137;
            this.Lbl_Fecha_Enc.Text = "Fecha Encontrado";
            // 
            // Lbl_Tipo_obj
            // 
            this.Lbl_Tipo_obj.AutoSize = true;
            this.Lbl_Tipo_obj.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_Tipo_obj.Location = new System.Drawing.Point(816, 247);
            this.Lbl_Tipo_obj.Name = "Lbl_Tipo_obj";
            this.Lbl_Tipo_obj.Size = new System.Drawing.Size(126, 20);
            this.Lbl_Tipo_obj.TabIndex = 136;
            this.Lbl_Tipo_obj.Text = "Tipo de Objeto";
            // 
            // Lbl_Desc_objeto
            // 
            this.Lbl_Desc_objeto.AutoSize = true;
            this.Lbl_Desc_objeto.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_Desc_objeto.Location = new System.Drawing.Point(816, 167);
            this.Lbl_Desc_objeto.Name = "Lbl_Desc_objeto";
            this.Lbl_Desc_objeto.Size = new System.Drawing.Size(186, 20);
            this.Lbl_Desc_objeto.TabIndex = 135;
            this.Lbl_Desc_objeto.Text = "Descripcion de Objeto";
            // 
            // Lbl_Nombre_obj
            // 
            this.Lbl_Nombre_obj.AutoSize = true;
            this.Lbl_Nombre_obj.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_Nombre_obj.Location = new System.Drawing.Point(483, 334);
            this.Lbl_Nombre_obj.Name = "Lbl_Nombre_obj";
            this.Lbl_Nombre_obj.Size = new System.Drawing.Size(151, 20);
            this.Lbl_Nombre_obj.TabIndex = 134;
            this.Lbl_Nombre_obj.Text = "Nombre de objeto";
            // 
            // Lbl_Id_Huesped
            // 
            this.Lbl_Id_Huesped.AutoSize = true;
            this.Lbl_Id_Huesped.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_Id_Huesped.Location = new System.Drawing.Point(483, 249);
            this.Lbl_Id_Huesped.Name = "Lbl_Id_Huesped";
            this.Lbl_Id_Huesped.Size = new System.Drawing.Size(141, 20);
            this.Lbl_Id_Huesped.TabIndex = 133;
            this.Lbl_Id_Huesped.Text = "Codigo Huesped";
            // 
            // Lbl_Id_FolioS
            // 
            this.Lbl_Id_FolioS.AutoSize = true;
            this.Lbl_Id_FolioS.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_FolioS.Location = new System.Drawing.Point(135, 247);
            this.Lbl_Id_FolioS.Name = "Lbl_Id_FolioS";
            this.Lbl_Id_FolioS.Size = new System.Drawing.Size(205, 20);
            this.Lbl_Id_FolioS.TabIndex = 132;
            this.Lbl_Id_FolioS.Text = "Codigo de Folio de Salon";
            // 
            // Lbl_Id_FolioH
            // 
            this.Lbl_Id_FolioH.AutoSize = true;
            this.Lbl_Id_FolioH.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_Id_FolioH.Location = new System.Drawing.Point(126, 334);
            this.Lbl_Id_FolioH.Name = "Lbl_Id_FolioH";
            this.Lbl_Id_FolioH.Size = new System.Drawing.Size(244, 20);
            this.Lbl_Id_FolioH.TabIndex = 131;
            this.Lbl_Id_FolioH.Text = "Codigo de Folio de habitacion";
            // 
            // Lbl_Id_Mantenimiento
            // 
            this.Lbl_Id_Mantenimiento.AutoSize = true;
            this.Lbl_Id_Mantenimiento.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_Id_Mantenimiento.Location = new System.Drawing.Point(483, 171);
            this.Lbl_Id_Mantenimiento.Name = "Lbl_Id_Mantenimiento";
            this.Lbl_Id_Mantenimiento.Size = new System.Drawing.Size(214, 20);
            this.Lbl_Id_Mantenimiento.TabIndex = 130;
            this.Lbl_Id_Mantenimiento.Text = "Codigo de Mantenimiento";
            // 
            // Lbl_Id_Objeto
            // 
            this.Lbl_Id_Objeto.AutoSize = true;
            this.Lbl_Id_Objeto.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_Id_Objeto.Location = new System.Drawing.Point(126, 169);
            this.Lbl_Id_Objeto.Name = "Lbl_Id_Objeto";
            this.Lbl_Id_Objeto.Size = new System.Drawing.Size(149, 20);
            this.Lbl_Id_Objeto.TabIndex = 129;
            this.Lbl_Id_Objeto.Text = "Codigo de Objeto";
            // 
            // Dgv_Objeto_Perdido
            // 
            this.Dgv_Objeto_Perdido.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dgv_Objeto_Perdido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Objeto_Perdido.Location = new System.Drawing.Point(39, 413);
            this.Dgv_Objeto_Perdido.Name = "Dgv_Objeto_Perdido";
            this.Dgv_Objeto_Perdido.ReadOnly = true;
            this.Dgv_Objeto_Perdido.RowHeadersWidth = 51;
            this.Dgv_Objeto_Perdido.RowTemplate.Height = 24;
            this.Dgv_Objeto_Perdido.Size = new System.Drawing.Size(1216, 279);
            this.Dgv_Objeto_Perdido.TabIndex = 128;
            this.Dgv_Objeto_Perdido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Objeto_Perdido_CellContentClick);
            // 
            // Lbl_Objetos_Perdidos
            // 
            this.Lbl_Objetos_Perdidos.AutoSize = true;
            this.Lbl_Objetos_Perdidos.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Objetos_Perdidos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Objetos_Perdidos.Location = new System.Drawing.Point(483, 59);
            this.Lbl_Objetos_Perdidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Objetos_Perdidos.Name = "Lbl_Objetos_Perdidos";
            this.Lbl_Objetos_Perdidos.Size = new System.Drawing.Size(257, 35);
            this.Lbl_Objetos_Perdidos.TabIndex = 124;
            this.Lbl_Objetos_Perdidos.Text = "Objetos Perdidos";
            // 
            // Pic_Salir
            // 
            this.Pic_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Salir.Image = global::Capa_Vista_MH.Properties.Resources.icono_cancelar;
            this.Pic_Salir.Location = new System.Drawing.Point(1242, 5);
            this.Pic_Salir.Name = "Pic_Salir";
            this.Pic_Salir.Size = new System.Drawing.Size(42, 42);
            this.Pic_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Salir.TabIndex = 149;
            this.Pic_Salir.TabStop = false;
            this.Pic_Salir.Click += new System.EventHandler(this.Pic_Salir_Click);
            // 
            // Pic_Reporte
            // 
            this.Pic_Reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Reporte.Image = global::Capa_Vista_MH.Properties.Resources.icono_imprimir;
            this.Pic_Reporte.Location = new System.Drawing.Point(1101, 95);
            this.Pic_Reporte.Name = "Pic_Reporte";
            this.Pic_Reporte.Size = new System.Drawing.Size(42, 42);
            this.Pic_Reporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Reporte.TabIndex = 150;
            this.Pic_Reporte.TabStop = false;
            // 
            // Pic_Buscar
            // 
            this.Pic_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Buscar.Image = global::Capa_Vista_MH.Properties.Resources.icono_buscar;
            this.Pic_Buscar.Location = new System.Drawing.Point(869, 95);
            this.Pic_Buscar.Name = "Pic_Buscar";
            this.Pic_Buscar.Size = new System.Drawing.Size(42, 42);
            this.Pic_Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Buscar.TabIndex = 148;
            this.Pic_Buscar.TabStop = false;
            this.Pic_Buscar.Click += new System.EventHandler(this.Pic_Buscar_Click);
            // 
            // Pic_Eliminar
            // 
            this.Pic_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Eliminar.Image = global::Capa_Vista_MH.Properties.Resources.icono_eliminar;
            this.Pic_Eliminar.Location = new System.Drawing.Point(1042, 95);
            this.Pic_Eliminar.Name = "Pic_Eliminar";
            this.Pic_Eliminar.Size = new System.Drawing.Size(42, 42);
            this.Pic_Eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Eliminar.TabIndex = 147;
            this.Pic_Eliminar.TabStop = false;
            this.Pic_Eliminar.Click += new System.EventHandler(this.Pic_Eliminar_Click);
            // 
            // Pic_Guardar
            // 
            this.Pic_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Guardar.Image = global::Capa_Vista_MH.Properties.Resources.icono_guardar;
            this.Pic_Guardar.Location = new System.Drawing.Point(926, 95);
            this.Pic_Guardar.Name = "Pic_Guardar";
            this.Pic_Guardar.Size = new System.Drawing.Size(42, 42);
            this.Pic_Guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Guardar.TabIndex = 127;
            this.Pic_Guardar.TabStop = false;
            this.Pic_Guardar.Click += new System.EventHandler(this.Pic_Guardar_Click);
            // 
            // Pic_Editar
            // 
            this.Pic_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Editar.Image = global::Capa_Vista_MH.Properties.Resources.icono_modificar;
            this.Pic_Editar.Location = new System.Drawing.Point(985, 95);
            this.Pic_Editar.Name = "Pic_Editar";
            this.Pic_Editar.Size = new System.Drawing.Size(42, 42);
            this.Pic_Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Editar.TabIndex = 126;
            this.Pic_Editar.TabStop = false;
            this.Pic_Editar.Click += new System.EventHandler(this.Pic_Editar_Click);
            // 
            // Pic_Cancelar
            // 
            this.Pic_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Cancelar.Image = global::Capa_Vista_MH.Properties.Resources.icono_limpiar__1_;
            this.Pic_Cancelar.Location = new System.Drawing.Point(1161, 95);
            this.Pic_Cancelar.Name = "Pic_Cancelar";
            this.Pic_Cancelar.Size = new System.Drawing.Size(42, 42);
            this.Pic_Cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Cancelar.TabIndex = 125;
            this.Pic_Cancelar.TabStop = false;
            this.Pic_Cancelar.Click += new System.EventHandler(this.Pic_Cancelar_Click);
            // 
            // Lbl_Entregado
            // 
            this.Lbl_Entregado.AutoSize = true;
            this.Lbl_Entregado.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_Entregado.Location = new System.Drawing.Point(1097, 169);
            this.Lbl_Entregado.Name = "Lbl_Entregado";
            this.Lbl_Entregado.Size = new System.Drawing.Size(91, 20);
            this.Lbl_Entregado.TabIndex = 151;
            this.Lbl_Entregado.Text = "Entregado";
            // 
            // Chk_Entregado
            // 
            this.Chk_Entregado.AutoSize = true;
            this.Chk_Entregado.Location = new System.Drawing.Point(1137, 207);
            this.Chk_Entregado.Name = "Chk_Entregado";
            this.Chk_Entregado.Size = new System.Drawing.Size(18, 17);
            this.Chk_Entregado.TabIndex = 152;
            this.Chk_Entregado.UseVisualStyleBackColor = true;
            this.Chk_Entregado.CheckedChanged += new System.EventHandler(this.Chk_Entregado_CheckedChanged);
            // 
            // Txt_Tipo_Objeto
            // 
            this.Txt_Tipo_Objeto.Location = new System.Drawing.Point(817, 288);
            this.Txt_Tipo_Objeto.Name = "Txt_Tipo_Objeto";
            this.Txt_Tipo_Objeto.Size = new System.Drawing.Size(210, 22);
            this.Txt_Tipo_Objeto.TabIndex = 153;
            this.Txt_Tipo_Objeto.TextChanged += new System.EventHandler(this.Txt_Tipo_Objeto_TextChanged);
            // 
            // Cbo_Id_Huesped
            // 
            this.Cbo_Id_Huesped.FormattingEnabled = true;
            this.Cbo_Id_Huesped.Location = new System.Drawing.Point(487, 286);
            this.Cbo_Id_Huesped.Name = "Cbo_Id_Huesped";
            this.Cbo_Id_Huesped.Size = new System.Drawing.Size(210, 24);
            this.Cbo_Id_Huesped.TabIndex = 154;
            this.Cbo_Id_Huesped.SelectedIndexChanged += new System.EventHandler(this.Cbo_Id_Huesped_SelectedIndexChanged);
            // 
            // Frm_ObjetosPerdidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 733);
            this.ControlBox = false;
            this.Controls.Add(this.Cbo_Id_Huesped);
            this.Controls.Add(this.Txt_Tipo_Objeto);
            this.Controls.Add(this.Chk_Entregado);
            this.Controls.Add(this.Lbl_Entregado);
            this.Controls.Add(this.Pic_Salir);
            this.Controls.Add(this.Pic_Reporte);
            this.Controls.Add(this.Pic_Buscar);
            this.Controls.Add(this.Pic_Eliminar);
            this.Controls.Add(this.Dtp_Fecha_Encontrado);
            this.Controls.Add(this.Txt_Descripcion_Objeto);
            this.Controls.Add(this.Txt_Nombre_Objeto);
            this.Controls.Add(this.Cbo_Id_Mantenimiento);
            this.Controls.Add(this.Cbo_Id_FolioHabitacion);
            this.Controls.Add(this.Cbo_Id_FolioSalon);
            this.Controls.Add(this.Cbo_Id_Objeto);
            this.Controls.Add(this.Lbl_Fecha_Enc);
            this.Controls.Add(this.Lbl_Tipo_obj);
            this.Controls.Add(this.Lbl_Desc_objeto);
            this.Controls.Add(this.Lbl_Nombre_obj);
            this.Controls.Add(this.Lbl_Id_Huesped);
            this.Controls.Add(this.Lbl_Id_FolioS);
            this.Controls.Add(this.Lbl_Id_FolioH);
            this.Controls.Add(this.Lbl_Id_Mantenimiento);
            this.Controls.Add(this.Lbl_Id_Objeto);
            this.Controls.Add(this.Dgv_Objeto_Perdido);
            this.Controls.Add(this.Pic_Guardar);
            this.Controls.Add(this.Pic_Editar);
            this.Controls.Add(this.Pic_Cancelar);
            this.Controls.Add(this.Lbl_Objetos_Perdidos);
            this.Name = "Frm_ObjetosPerdidos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ObjetosPerdidos";
            this.Load += new System.EventHandler(this.Frm_ObjetosPerdidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Objeto_Perdido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Reporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Salir;
        private System.Windows.Forms.PictureBox Pic_Reporte;
        private System.Windows.Forms.PictureBox Pic_Buscar;
        private System.Windows.Forms.PictureBox Pic_Eliminar;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Encontrado;
        private System.Windows.Forms.TextBox Txt_Descripcion_Objeto;
        private System.Windows.Forms.TextBox Txt_Nombre_Objeto;
        private System.Windows.Forms.ComboBox Cbo_Id_Mantenimiento;
        private System.Windows.Forms.ComboBox Cbo_Id_FolioHabitacion;
        private System.Windows.Forms.ComboBox Cbo_Id_FolioSalon;
        private System.Windows.Forms.ComboBox Cbo_Id_Objeto;
        private System.Windows.Forms.Label Lbl_Fecha_Enc;
        private System.Windows.Forms.Label Lbl_Tipo_obj;
        private System.Windows.Forms.Label Lbl_Desc_objeto;
        private System.Windows.Forms.Label Lbl_Nombre_obj;
        private System.Windows.Forms.Label Lbl_Id_Huesped;
        private System.Windows.Forms.Label Lbl_Id_FolioS;
        private System.Windows.Forms.Label Lbl_Id_FolioH;
        private System.Windows.Forms.Label Lbl_Id_Mantenimiento;
        private System.Windows.Forms.Label Lbl_Id_Objeto;
        private System.Windows.Forms.DataGridView Dgv_Objeto_Perdido;
        private System.Windows.Forms.PictureBox Pic_Guardar;
        private System.Windows.Forms.PictureBox Pic_Editar;
        private System.Windows.Forms.PictureBox Pic_Cancelar;
        private System.Windows.Forms.Label Lbl_Objetos_Perdidos;
        private System.Windows.Forms.Label Lbl_Entregado;
        private System.Windows.Forms.CheckBox Chk_Entregado;
        private System.Windows.Forms.TextBox Txt_Tipo_Objeto;
        private System.Windows.Forms.ComboBox Cbo_Id_Huesped;
    }
}