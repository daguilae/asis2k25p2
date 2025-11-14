namespace Capa_Vista_Anticipos_Nomina
{
    partial class Frm_Anticipos_Nomina
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

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.Pnl_Encabezado = new System.Windows.Forms.Panel();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Gpb_anticipos = new System.Windows.Forms.GroupBox();
            this.Lbl_NombreEmpleado = new System.Windows.Forms.Label();
            this.Btn_solicitar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Dgv_anticipos = new System.Windows.Forms.DataGridView();
            this.Pnl_Encabezado.SuspendLayout();
            this.Gpb_anticipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_anticipos)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(234, 50);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(318, 35);
            this.cboEmpleado.TabIndex = 4;
            // 
            // Pnl_Encabezado
            // 
            this.Pnl_Encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Pnl_Encabezado.Controls.Add(this.Lbl_Titulo);
            this.Pnl_Encabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Encabezado.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Encabezado.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_Encabezado.Name = "Pnl_Encabezado";
            this.Pnl_Encabezado.Size = new System.Drawing.Size(949, 62);
            this.Pnl_Encabezado.TabIndex = 15;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Lbl_Titulo.Location = new System.Drawing.Point(61, 15);
            this.Lbl_Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(111, 29);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Anticipos";
            // 
            // Gpb_anticipos
            // 
            this.Gpb_anticipos.Controls.Add(this.Lbl_NombreEmpleado);
            this.Gpb_anticipos.Controls.Add(this.Btn_solicitar);
            this.Gpb_anticipos.Controls.Add(this.Btn_modificar);
            this.Gpb_anticipos.Controls.Add(this.Btn_eliminar);
            this.Gpb_anticipos.Controls.Add(this.Dgv_anticipos);
            this.Gpb_anticipos.Controls.Add(this.cboEmpleado);
            this.Gpb_anticipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Gpb_anticipos.Location = new System.Drawing.Point(66, 86);
            this.Gpb_anticipos.Name = "Gpb_anticipos";
            this.Gpb_anticipos.Size = new System.Drawing.Size(829, 466);
            this.Gpb_anticipos.TabIndex = 14;
            this.Gpb_anticipos.TabStop = false;
            this.Gpb_anticipos.Text = "Anticipos";
            // 
            // Lbl_NombreEmpleado
            // 
            this.Lbl_NombreEmpleado.AutoSize = true;
            this.Lbl_NombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Lbl_NombreEmpleado.Location = new System.Drawing.Point(10, 56);
            this.Lbl_NombreEmpleado.Name = "Lbl_NombreEmpleado";
            this.Lbl_NombreEmpleado.Size = new System.Drawing.Size(218, 29);
            this.Lbl_NombreEmpleado.TabIndex = 1;
            this.Lbl_NombreEmpleado.Text = "Nombre Empleado";
            // 
            // Btn_solicitar
            // 
            this.Btn_solicitar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_solicitar.Image = global::Capa_Vista_Anticipos_Nomina.Properties.Resources.add_insert_new_plus_button_icon_142943;
            this.Btn_solicitar.Location = new System.Drawing.Point(558, 28);
            this.Btn_solicitar.Name = "Btn_solicitar";
            this.Btn_solicitar.Size = new System.Drawing.Size(71, 63);
            this.Btn_solicitar.TabIndex = 4;
            this.Btn_solicitar.Text = "Solicitar";
            this.Btn_solicitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_solicitar.UseVisualStyleBackColor = true;
            this.Btn_solicitar.Click += new System.EventHandler(this.Btn_solicitar_Click);
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_modificar.Image = global::Capa_Vista_Anticipos_Nomina.Properties.Resources.compose_edit_modify_icon_177770;
            this.Btn_modificar.Location = new System.Drawing.Point(635, 28);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(79, 63);
            this.Btn_modificar.TabIndex = 5;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_modificar.UseVisualStyleBackColor = true;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_eliminar.Image = global::Capa_Vista_Anticipos_Nomina.Properties.Resources.delete_remove_trash_icon_177304;
            this.Btn_eliminar.Location = new System.Drawing.Point(720, 28);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(71, 63);
            this.Btn_eliminar.TabIndex = 6;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Dgv_anticipos
            // 
            this.Dgv_anticipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_anticipos.Location = new System.Drawing.Point(15, 97);
            this.Dgv_anticipos.Name = "Dgv_anticipos";
            this.Dgv_anticipos.RowHeadersWidth = 62;
            this.Dgv_anticipos.Size = new System.Drawing.Size(776, 318);
            this.Dgv_anticipos.TabIndex = 0;
            // 
            // Frm_Anticipos_Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pnl_Encabezado);
            this.Controls.Add(this.Gpb_anticipos);
            this.Name = "Frm_Anticipos_Nomina";
            this.Size = new System.Drawing.Size(949, 583);
            this.Pnl_Encabezado.ResumeLayout(false);
            this.Pnl_Encabezado.PerformLayout();
            this.Gpb_anticipos.ResumeLayout(false);
            this.Gpb_anticipos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_anticipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.Panel Pnl_Encabezado;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.GroupBox Gpb_anticipos;
        private System.Windows.Forms.Label Lbl_NombreEmpleado;
        private System.Windows.Forms.Button Btn_solicitar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.DataGridView Dgv_anticipos;
    }
}
