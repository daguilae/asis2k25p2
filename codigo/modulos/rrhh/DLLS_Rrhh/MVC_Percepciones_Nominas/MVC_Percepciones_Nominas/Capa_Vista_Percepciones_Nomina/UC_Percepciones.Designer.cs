
namespace Capa_Vista_Percepciones_Nomina
{
    partial class Form_Percep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Percep));
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cbo_NoNomina = new System.Windows.Forms.ComboBox();
            this.Cbo_Empleado = new System.Windows.Forms.ComboBox();
            this.Cbo_ConceptoNomina = new System.Windows.Forms.ComboBox();
            this.Txt_Valor = new System.Windows.Forms.TextBox();
            this.Dvg_Detalle = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Location = new System.Drawing.Point(730, 13);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(40, 42);
            this.Btn_Guardar.TabIndex = 0;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. Nómina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Concepto de Nómina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(584, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor";
            // 
            // Cbo_NoNomina
            // 
            this.Cbo_NoNomina.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_NoNomina.FormattingEnabled = true;
            this.Cbo_NoNomina.Location = new System.Drawing.Point(42, 114);
            this.Cbo_NoNomina.Name = "Cbo_NoNomina";
            this.Cbo_NoNomina.Size = new System.Drawing.Size(145, 24);
            this.Cbo_NoNomina.TabIndex = 5;
            // 
            // Cbo_Empleado
            // 
            this.Cbo_Empleado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Empleado.FormattingEnabled = true;
            this.Cbo_Empleado.Location = new System.Drawing.Point(215, 112);
            this.Cbo_Empleado.Name = "Cbo_Empleado";
            this.Cbo_Empleado.Size = new System.Drawing.Size(145, 24);
            this.Cbo_Empleado.TabIndex = 6;
            // 
            // Cbo_ConceptoNomina
            // 
            this.Cbo_ConceptoNomina.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_ConceptoNomina.FormattingEnabled = true;
            this.Cbo_ConceptoNomina.Location = new System.Drawing.Point(397, 112);
            this.Cbo_ConceptoNomina.Name = "Cbo_ConceptoNomina";
            this.Cbo_ConceptoNomina.Size = new System.Drawing.Size(149, 24);
            this.Cbo_ConceptoNomina.TabIndex = 7;
            // 
            // Txt_Valor
            // 
            this.Txt_Valor.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Valor.Location = new System.Drawing.Point(587, 113);
            this.Txt_Valor.Name = "Txt_Valor";
            this.Txt_Valor.Size = new System.Drawing.Size(142, 23);
            this.Txt_Valor.TabIndex = 8;
            // 
            // Dvg_Detalle
            // 
            this.Dvg_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_Detalle.Location = new System.Drawing.Point(33, 151);
            this.Dvg_Detalle.Name = "Dvg_Detalle";
            this.Dvg_Detalle.Size = new System.Drawing.Size(737, 203);
            this.Dvg_Detalle.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Registro de Percepciones";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(651, 16);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(58, 36);
            this.Btn_Eliminar.TabIndex = 11;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Form_Percep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(47)))), ((int)(((byte)(149)))));
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dvg_Detalle);
            this.Controls.Add(this.Txt_Valor);
            this.Controls.Add(this.Cbo_ConceptoNomina);
            this.Controls.Add(this.Cbo_Empleado);
            this.Controls.Add(this.Cbo_NoNomina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Guardar);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form_Percep";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Detalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cbo_NoNomina;
        private System.Windows.Forms.ComboBox Cbo_Empleado;
        private System.Windows.Forms.ComboBox Cbo_ConceptoNomina;
        private System.Windows.Forms.TextBox Txt_Valor;
        private System.Windows.Forms.DataGridView Dvg_Detalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Eliminar;
    }
}