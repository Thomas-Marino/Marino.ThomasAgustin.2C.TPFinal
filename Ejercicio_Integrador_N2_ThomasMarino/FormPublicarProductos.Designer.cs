namespace Ejercicio_Integrador_N2_ThomasMarino
{
    partial class FormPublicarProductos
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
            label1 = new Label();
            CbCategoríaProducto = new ComboBox();
            TxbNombreProducto = new TextBox();
            TxbPrecioProducto = new TextBox();
            TxbStockProducto = new TextBox();
            BtnAltaDeProducto = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(114, 44);
            label1.Name = "label1";
            label1.Size = new Size(647, 81);
            label1.TabIndex = 0;
            label1.Text = "ALTA DE PRODUCTOS";
            // 
            // CbCategoríaProducto
            // 
            CbCategoríaProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            CbCategoríaProducto.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CbCategoríaProducto.FormattingEnabled = true;
            CbCategoríaProducto.Items.AddRange(new object[] { "Muebles", "Tecnología", "Herramientas", "Vehiculos" });
            CbCategoríaProducto.Location = new Point(171, 188);
            CbCategoríaProducto.Name = "CbCategoríaProducto";
            CbCategoríaProducto.Size = new Size(202, 38);
            CbCategoríaProducto.TabIndex = 1;
            // 
            // TxbNombreProducto
            // 
            TxbNombreProducto.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxbNombreProducto.Location = new Point(171, 147);
            TxbNombreProducto.Name = "TxbNombreProducto";
            TxbNombreProducto.Size = new Size(534, 35);
            TxbNombreProducto.TabIndex = 2;
            TxbNombreProducto.TextChanged += TxbNombreProducto_TextChanged;
            // 
            // TxbPrecioProducto
            // 
            TxbPrecioProducto.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxbPrecioProducto.Location = new Point(171, 232);
            TxbPrecioProducto.Name = "TxbPrecioProducto";
            TxbPrecioProducto.Size = new Size(159, 35);
            TxbPrecioProducto.TabIndex = 3;
            TxbPrecioProducto.TextChanged += TxbPrecioProducto_TextChanged;
            // 
            // TxbStockProducto
            // 
            TxbStockProducto.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxbStockProducto.Location = new Point(171, 273);
            TxbStockProducto.Name = "TxbStockProducto";
            TxbStockProducto.Size = new Size(113, 35);
            TxbStockProducto.TabIndex = 4;
            TxbStockProducto.TextChanged += TxbStockProducto_TextChanged;
            // 
            // BtnAltaDeProducto
            // 
            BtnAltaDeProducto.BackColor = Color.SeaGreen;
            BtnAltaDeProducto.FlatAppearance.BorderColor = Color.SeaGreen;
            BtnAltaDeProducto.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            BtnAltaDeProducto.FlatStyle = FlatStyle.Flat;
            BtnAltaDeProducto.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAltaDeProducto.ForeColor = Color.White;
            BtnAltaDeProducto.Location = new Point(300, 419);
            BtnAltaDeProducto.Name = "BtnAltaDeProducto";
            BtnAltaDeProducto.Size = new Size(259, 46);
            BtnAltaDeProducto.TabIndex = 5;
            BtnAltaDeProducto.Text = "Publicar producto.";
            BtnAltaDeProducto.UseVisualStyleBackColor = false;
            BtnAltaDeProducto.Click += BtnAltaDeProducto_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 150);
            label2.Name = "label2";
            label2.Size = new Size(134, 30);
            label2.TabIndex = 6;
            label2.Text = "PRODUCTO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 191);
            label3.Name = "label3";
            label3.Size = new Size(137, 30);
            label3.TabIndex = 7;
            label3.Text = "CATEGORÍA:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(34, 235);
            label4.Name = "label4";
            label4.Size = new Size(96, 30);
            label4.TabIndex = 8;
            label4.Text = "PRECIO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(34, 276);
            label5.Name = "label5";
            label5.Size = new Size(89, 30);
            label5.TabIndex = 9;
            label5.Text = "STOCK:";
            // 
            // FormPublicarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(857, 545);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnAltaDeProducto);
            Controls.Add(TxbStockProducto);
            Controls.Add(TxbPrecioProducto);
            Controls.Add(TxbNombreProducto);
            Controls.Add(CbCategoríaProducto);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPublicarProductos";
            Text = "FormPublicarProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox CbCategoríaProducto;
        private TextBox TxbNombreProducto;
        private TextBox TxbPrecioProducto;
        private TextBox TxbStockProducto;
        private Button BtnAltaDeProducto;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}