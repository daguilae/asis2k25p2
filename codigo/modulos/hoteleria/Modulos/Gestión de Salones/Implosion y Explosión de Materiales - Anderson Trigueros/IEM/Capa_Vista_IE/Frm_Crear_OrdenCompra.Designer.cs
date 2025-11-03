
namespace Capa_Vista_IE
{
    partial class Frm_Crear_OrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Crear_OrdenCompra));
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Dgv_ListadoCompra = new System.Windows.Forms.DataGridView();
            this.Pic_Cancelar = new System.Windows.Forms.PictureBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListadoCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lbl_Titulo.Location = new System.Drawing.Point(209, 66);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(332, 29);
            this.Lbl_Titulo.TabIndex = 2;
            this.Lbl_Titulo.Text = "Generar Orden de Compra";
            // 
            // Dgv_ListadoCompra
            // 
            this.Dgv_ListadoCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ListadoCompra.Location = new System.Drawing.Point(121, 114);
            this.Dgv_ListadoCompra.Name = "Dgv_ListadoCompra";
            this.Dgv_ListadoCompra.RowHeadersWidth = 51;
            this.Dgv_ListadoCompra.RowTemplate.Height = 24;
            this.Dgv_ListadoCompra.Size = new System.Drawing.Size(548, 270);
            this.Dgv_ListadoCompra.TabIndex = 3;
            // 
            // Pic_Cancelar
            // 
            this.Pic_Cancelar.BackColor = System.Drawing.Color.White;
            this.Pic_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Cancelar.Image")));
            this.Pic_Cancelar.Location = new System.Drawing.Point(627, 11);
            this.Pic_Cancelar.Name = "Pic_Cancelar";
            this.Pic_Cancelar.Size = new System.Drawing.Size(53, 46);
            this.Pic_Cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pic_Cancelar.TabIndex = 5;
            this.Pic_Cancelar.TabStop = false;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.White;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(568, 11);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(53, 46);
            this.Btn_guardar.TabIndex = 6;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            // 
            // Frm_Crear_OrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Pic_Cancelar);
            this.Controls.Add(this.Dgv_ListadoCompra);
            this.Controls.Add(this.Lbl_Titulo);
            this.Name = "Frm_Crear_OrdenCompra";
            this.Text = "Frm_Crear_OrdenCompra";
            this.Load += new System.EventHandler(this.Frm_Crear_OrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListadoCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.DataGridView Dgv_ListadoCompra;
        private System.Windows.Forms.PictureBox Pic_Cancelar;
        private System.Windows.Forms.Button Btn_guardar;
    }
}