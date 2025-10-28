
namespace Capa_Vista_Nominas
{
    partial class Anticipos
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
            this.Dgv_anticipo = new System.Windows.Forms.DataGridView();
            this.Lbl_NombreEmpleado = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Gpb_anticipos = new System.Windows.Forms.GroupBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_solicitar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_anticipo)).BeginInit();
            this.Gpb_anticipos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_anticipo
            // 
            this.Dgv_anticipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_anticipo.Location = new System.Drawing.Point(15, 97);
            this.Dgv_anticipo.Name = "Dgv_anticipo";
            this.Dgv_anticipo.Size = new System.Drawing.Size(776, 318);
            this.Dgv_anticipo.TabIndex = 0;
            // 
            // Lbl_NombreEmpleado
            // 
            this.Lbl_NombreEmpleado.AutoSize = true;
            this.Lbl_NombreEmpleado.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_NombreEmpleado.Location = new System.Drawing.Point(10, 56);
            this.Lbl_NombreEmpleado.Name = "Lbl_NombreEmpleado";
            this.Lbl_NombreEmpleado.Size = new System.Drawing.Size(224, 27);
            this.Lbl_NombreEmpleado.TabIndex = 1;
            this.Lbl_NombreEmpleado.Text = "Nombre Empleado";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(251, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 35);
            this.comboBox1.TabIndex = 2;
            // 
            // Gpb_anticipos
            // 
            this.Gpb_anticipos.Controls.Add(this.Lbl_NombreEmpleado);
            this.Gpb_anticipos.Controls.Add(this.comboBox1);
            this.Gpb_anticipos.Controls.Add(this.Btn_buscar);
            this.Gpb_anticipos.Controls.Add(this.Btn_solicitar);
            this.Gpb_anticipos.Controls.Add(this.Btn_modificar);
            this.Gpb_anticipos.Controls.Add(this.Btn_eliminar);
            this.Gpb_anticipos.Controls.Add(this.Dgv_anticipo);
            this.Gpb_anticipos.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Gpb_anticipos.Location = new System.Drawing.Point(12, 23);
            this.Gpb_anticipos.Name = "Gpb_anticipos";
            this.Gpb_anticipos.Size = new System.Drawing.Size(807, 442);
            this.Gpb_anticipos.TabIndex = 7;
            this.Gpb_anticipos.TabStop = false;
            this.Gpb_anticipos.Text = "Anticipos";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_buscar.Image = global::Capa_Vista_Nominas.Properties.Resources.android_search_icon_icons_com_50501;
            this.Btn_buscar.Location = new System.Drawing.Point(481, 28);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(71, 63);
            this.Btn_buscar.TabIndex = 3;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_solicitar
            // 
            this.Btn_solicitar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_solicitar.Image = global::Capa_Vista_Nominas.Properties.Resources.add_insert_new_plus_button_icon_142943;
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
            this.Btn_modificar.Image = global::Capa_Vista_Nominas.Properties.Resources.compose_edit_modify_icon_177770;
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
            this.Btn_eliminar.Image = global::Capa_Vista_Nominas.Properties.Resources.delete_remove_trash_icon_177304;
            this.Btn_eliminar.Location = new System.Drawing.Point(720, 28);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(71, 63);
            this.Btn_eliminar.TabIndex = 6;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Anticipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 493);
            this.Controls.Add(this.Gpb_anticipos);
            this.Name = "Anticipos";
            this.Text = "Anticipos";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_anticipo)).EndInit();
            this.Gpb_anticipos.ResumeLayout(false);
            this.Gpb_anticipos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_anticipo;
        private System.Windows.Forms.Label Lbl_NombreEmpleado;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Btn_solicitar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.GroupBox Gpb_anticipos;
    }
}