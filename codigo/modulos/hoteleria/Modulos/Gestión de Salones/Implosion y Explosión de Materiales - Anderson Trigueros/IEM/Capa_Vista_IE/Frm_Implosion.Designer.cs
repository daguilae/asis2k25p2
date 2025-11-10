
namespace Capa_Vista_IE
{
    partial class Frm_Implosion
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
            this.Lbl_Platillo = new System.Windows.Forms.Label();
            this.Cbo_Platillos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_IngresoCantidad = new System.Windows.Forms.Label();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Btn_Consulta = new System.Windows.Forms.Button();
            this.Lstv_Receta = new System.Windows.Forms.ListView();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Gpb_Filtros = new System.Windows.Forms.GroupBox();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Btn_OrdenCompra = new System.Windows.Forms.Button();
            this.Gpb_Filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Platillo
            // 
            this.Lbl_Platillo.AutoSize = true;
            this.Lbl_Platillo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Platillo.Location = new System.Drawing.Point(25, 36);
            this.Lbl_Platillo.Name = "Lbl_Platillo";
            this.Lbl_Platillo.Size = new System.Drawing.Size(268, 20);
            this.Lbl_Platillo.TabIndex = 1;
            this.Lbl_Platillo.Text = "Seleccione el platillo a consultar:";
            // 
            // Cbo_Platillos
            // 
            this.Cbo_Platillos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Platillos.FormattingEnabled = true;
            this.Cbo_Platillos.Location = new System.Drawing.Point(29, 59);
            this.Cbo_Platillos.Name = "Cbo_Platillos";
            this.Cbo_Platillos.Size = new System.Drawing.Size(359, 28);
            this.Cbo_Platillos.TabIndex = 2;
            this.Cbo_Platillos.SelectedIndexChanged += new System.EventHandler(this.pro_Cbo_Platillos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // Lbl_IngresoCantidad
            // 
            this.Lbl_IngresoCantidad.AutoSize = true;
            this.Lbl_IngresoCantidad.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IngresoCantidad.Location = new System.Drawing.Point(413, 36);
            this.Lbl_IngresoCantidad.Name = "Lbl_IngresoCantidad";
            this.Lbl_IngresoCantidad.Size = new System.Drawing.Size(255, 20);
            this.Lbl_IngresoCantidad.TabIndex = 5;
            this.Lbl_IngresoCantidad.Text = "Cantidad de platillos a producir";
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cantidad.Location = new System.Drawing.Point(417, 59);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(347, 27);
            this.Txt_Cantidad.TabIndex = 6;
            // 
            // Btn_Consulta
            // 
            this.Btn_Consulta.BackColor = System.Drawing.Color.AliceBlue;
            this.Btn_Consulta.FlatAppearance.BorderSize = 0;
            this.Btn_Consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Consulta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consulta.Location = new System.Drawing.Point(784, 55);
            this.Btn_Consulta.Name = "Btn_Consulta";
            this.Btn_Consulta.Size = new System.Drawing.Size(186, 31);
            this.Btn_Consulta.TabIndex = 7;
            this.Btn_Consulta.Text = "Consultar";
            this.Btn_Consulta.UseVisualStyleBackColor = false;
            this.Btn_Consulta.Click += new System.EventHandler(this.pro_Btn_Consulta_Click);
            // 
            // Lstv_Receta
            // 
            this.Lstv_Receta.HideSelection = false;
            this.Lstv_Receta.Location = new System.Drawing.Point(26, 196);
            this.Lstv_Receta.Name = "Lstv_Receta";
            this.Lstv_Receta.Size = new System.Drawing.Size(987, 267);
            this.Lstv_Receta.TabIndex = 8;
            this.Lstv_Receta.UseCompatibleStateImageBehavior = false;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lbl_Titulo.Location = new System.Drawing.Point(19, 9);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(560, 38);
            this.Lbl_Titulo.TabIndex = 1;
            this.Lbl_Titulo.Text = "Implosión y Explosión de Materiales";
            // 
            // Gpb_Filtros
            // 
            this.Gpb_Filtros.Controls.Add(this.Txt_Cantidad);
            this.Gpb_Filtros.Controls.Add(this.Lbl_IngresoCantidad);
            this.Gpb_Filtros.Controls.Add(this.Btn_Consulta);
            this.Gpb_Filtros.Controls.Add(this.label2);
            this.Gpb_Filtros.Controls.Add(this.Cbo_Platillos);
            this.Gpb_Filtros.Controls.Add(this.Lbl_Platillo);
            this.Gpb_Filtros.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Filtros.Location = new System.Drawing.Point(26, 65);
            this.Gpb_Filtros.Name = "Gpb_Filtros";
            this.Gpb_Filtros.Size = new System.Drawing.Size(987, 114);
            this.Gpb_Filtros.TabIndex = 9;
            this.Gpb_Filtros.TabStop = false;
            this.Gpb_Filtros.Text = "Consultar Disponibilidad de Inventario";
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado.Location = new System.Drawing.Point(205, 487);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(588, 20);
            this.Lbl_Resultado.TabIndex = 10;
            this.Lbl_Resultado.Text = "El inventario es insuficiente para producir la cantidad de platillos indicada";
            // 
            // Btn_OrdenCompra
            // 
            this.Btn_OrdenCompra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Btn_OrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OrdenCompra.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OrdenCompra.Location = new System.Drawing.Point(342, 520);
            this.Btn_OrdenCompra.Name = "Btn_OrdenCompra";
            this.Btn_OrdenCompra.Size = new System.Drawing.Size(265, 38);
            this.Btn_OrdenCompra.TabIndex = 11;
            this.Btn_OrdenCompra.Text = "Generar Orden de Compra";
            this.Btn_OrdenCompra.UseVisualStyleBackColor = false;
            this.Btn_OrdenCompra.Click += new System.EventHandler(this.pro_Btn_OrdenCompra_Click);
            // 
            // Frm_Implosion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 601);
            this.Controls.Add(this.Btn_OrdenCompra);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Lstv_Receta);
            this.Controls.Add(this.Gpb_Filtros);
            this.Name = "Frm_Implosion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Implosion";
            this.Load += new System.EventHandler(this.pro_Frm_Implosion_Load);
            this.Gpb_Filtros.ResumeLayout(false);
            this.Gpb_Filtros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Platillo;
        private System.Windows.Forms.ComboBox Cbo_Platillos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_IngresoCantidad;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.Button Btn_Consulta;
        private System.Windows.Forms.ListView Lstv_Receta;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.GroupBox Gpb_Filtros;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.Button Btn_OrdenCompra;
    }
}