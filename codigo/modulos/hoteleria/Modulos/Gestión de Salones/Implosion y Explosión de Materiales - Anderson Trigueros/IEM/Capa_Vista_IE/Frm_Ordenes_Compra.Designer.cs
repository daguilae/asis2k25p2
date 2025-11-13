
namespace Capa_Vista_IE
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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Dgv_Ordenes = new System.Windows.Forms.DataGridView();
            this.Txt_Orden = new System.Windows.Forms.TextBox();
            this.Txt_Producto = new System.Windows.Forms.TextBox();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Lbl_NoOrden = new System.Windows.Forms.Label();
            this.Lbl_Producto = new System.Windows.Forms.Label();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ordenes)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lbl_Titulo.Location = new System.Drawing.Point(323, 41);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(314, 38);
            this.Lbl_Titulo.TabIndex = 3;
            this.Lbl_Titulo.Text = "Ordenes de Compra";
            // 
            // Dgv_Ordenes
            // 
            this.Dgv_Ordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Ordenes.Location = new System.Drawing.Point(28, 185);
            this.Dgv_Ordenes.Name = "Dgv_Ordenes";
            this.Dgv_Ordenes.RowHeadersWidth = 51;
            this.Dgv_Ordenes.RowTemplate.Height = 24;
            this.Dgv_Ordenes.Size = new System.Drawing.Size(927, 321);
            this.Dgv_Ordenes.TabIndex = 4;
            this.Dgv_Ordenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pro_Dgv_Ordenes_CellClick);
            // 
            // Txt_Orden
            // 
            this.Txt_Orden.Location = new System.Drawing.Point(210, 127);
            this.Txt_Orden.Name = "Txt_Orden";
            this.Txt_Orden.ReadOnly = true;
            this.Txt_Orden.Size = new System.Drawing.Size(150, 22);
            this.Txt_Orden.TabIndex = 5;
            // 
            // Txt_Producto
            // 
            this.Txt_Producto.Location = new System.Drawing.Point(390, 127);
            this.Txt_Producto.Name = "Txt_Producto";
            this.Txt_Producto.ReadOnly = true;
            this.Txt_Producto.Size = new System.Drawing.Size(235, 22);
            this.Txt_Producto.TabIndex = 6;
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Location = new System.Drawing.Point(642, 127);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(161, 22);
            this.Txt_Cantidad.TabIndex = 7;
            // 
            // Lbl_NoOrden
            // 
            this.Lbl_NoOrden.AutoSize = true;
            this.Lbl_NoOrden.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NoOrden.Location = new System.Drawing.Point(206, 104);
            this.Lbl_NoOrden.Name = "Lbl_NoOrden";
            this.Lbl_NoOrden.Size = new System.Drawing.Size(91, 20);
            this.Lbl_NoOrden.TabIndex = 9;
            this.Lbl_NoOrden.Text = "No. Orden";
            // 
            // Lbl_Producto
            // 
            this.Lbl_Producto.AutoSize = true;
            this.Lbl_Producto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Producto.Location = new System.Drawing.Point(386, 104);
            this.Lbl_Producto.Name = "Lbl_Producto";
            this.Lbl_Producto.Size = new System.Drawing.Size(80, 20);
            this.Lbl_Producto.TabIndex = 10;
            this.Lbl_Producto.Text = "Producto";
            // 
            // Lbl_Cantidad
            // 
            this.Lbl_Cantidad.AutoSize = true;
            this.Lbl_Cantidad.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cantidad.Location = new System.Drawing.Point(652, 104);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(80, 20);
            this.Lbl_Cantidad.TabIndex = 11;
            this.Lbl_Cantidad.Text = "Cantidad";
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.White;
            this.Btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(789, 22);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(53, 46);
            this.Btn_Modificar.TabIndex = 12;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.pro_Btn_modificar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(848, 22);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(48, 46);
            this.Btn_Eliminar.TabIndex = 13;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.pro_Btn_Eliminar_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.Color.White;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar.Image")));
            this.Btn_Limpiar.Location = new System.Drawing.Point(902, 22);
            this.Btn_Limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(53, 46);
            this.Btn_Limpiar.TabIndex = 14;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.pro_Btn_Limpiar_Click);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.BackColor = System.Drawing.Color.White;
            this.Btn_Reporte.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Reporte.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Reporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(727, 23);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(56, 46);
            this.Btn_Reporte.TabIndex = 162;
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Reporte.UseVisualStyleBackColor = false;
            this.Btn_Reporte.Click += new System.EventHandler(this.pro_Btn_Reporte_Click);
            // 
            // Frm_Ordenes_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 547);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Lbl_Cantidad);
            this.Controls.Add(this.Lbl_Producto);
            this.Controls.Add(this.Lbl_NoOrden);
            this.Controls.Add(this.Txt_Cantidad);
            this.Controls.Add(this.Txt_Producto);
            this.Controls.Add(this.Txt_Orden);
            this.Controls.Add(this.Dgv_Ordenes);
            this.Controls.Add(this.Lbl_Titulo);
            this.Name = "Frm_Ordenes_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Ordenes_Compra";
            this.Load += new System.EventHandler(this.pro_Frm_Ordenes_Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Ordenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.DataGridView Dgv_Ordenes;
        private System.Windows.Forms.TextBox Txt_Orden;
        private System.Windows.Forms.TextBox Txt_Producto;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.Label Lbl_NoOrden;
        private System.Windows.Forms.Label Lbl_Producto;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Reporte;
    }
}