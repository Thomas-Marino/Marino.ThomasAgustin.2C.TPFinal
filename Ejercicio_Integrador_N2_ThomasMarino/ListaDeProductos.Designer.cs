namespace Ejercicio_Integrador_N2_ThomasMarino
{
    partial class ListaDeProductos
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

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            PbImagenProducto = new PictureBox();
            PanelImagen = new Panel();
            LblNombreProducto = new Label();
            LblPrecioProducto = new Label();
            LblStockProducto = new Label();
            LblPublicadorProducto = new Label();
            BtnAñadirAlCarrito = new Button();
            NUDCantidadProductoDeseada = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)PbImagenProducto).BeginInit();
            PanelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUDCantidadProductoDeseada).BeginInit();
            SuspendLayout();
            // 
            // PbImagenProducto
            // 
            PbImagenProducto.BackColor = Color.White;
            PbImagenProducto.Location = new Point(26, 13);
            PbImagenProducto.Name = "PbImagenProducto";
            PbImagenProducto.Size = new Size(169, 117);
            PbImagenProducto.SizeMode = PictureBoxSizeMode.CenterImage;
            PbImagenProducto.TabIndex = 0;
            PbImagenProducto.TabStop = false;
            // 
            // PanelImagen
            // 
            PanelImagen.BackColor = Color.Gainsboro;
            PanelImagen.Controls.Add(PbImagenProducto);
            PanelImagen.Dock = DockStyle.Left;
            PanelImagen.Location = new Point(0, 0);
            PanelImagen.Name = "PanelImagen";
            PanelImagen.Size = new Size(224, 142);
            PanelImagen.TabIndex = 1;
            // 
            // LblNombreProducto
            // 
            LblNombreProducto.AutoSize = true;
            LblNombreProducto.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblNombreProducto.Location = new Point(244, 13);
            LblNombreProducto.Name = "LblNombreProducto";
            LblNombreProducto.Size = new Size(200, 24);
            LblNombreProducto.TabIndex = 2;
            LblNombreProducto.Text = "Nombre del producto";
            // 
            // LblPrecioProducto
            // 
            LblPrecioProducto.AutoSize = true;
            LblPrecioProducto.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblPrecioProducto.Location = new Point(244, 52);
            LblPrecioProducto.Name = "LblPrecioProducto";
            LblPrecioProducto.Size = new Size(186, 24);
            LblPrecioProducto.TabIndex = 3;
            LblPrecioProducto.Text = "Precio del producto";
            // 
            // LblStockProducto
            // 
            LblStockProducto.AutoSize = true;
            LblStockProducto.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblStockProducto.Location = new Point(244, 76);
            LblStockProducto.Name = "LblStockProducto";
            LblStockProducto.Size = new Size(180, 24);
            LblStockProducto.TabIndex = 4;
            LblStockProducto.Text = "Stock del producto";
            // 
            // LblPublicadorProducto
            // 
            LblPublicadorProducto.AutoSize = true;
            LblPublicadorProducto.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblPublicadorProducto.Location = new Point(244, 110);
            LblPublicadorProducto.Name = "LblPublicadorProducto";
            LblPublicadorProducto.Size = new Size(163, 20);
            LblPublicadorProducto.TabIndex = 5;
            LblPublicadorProducto.Text = "Publicador del producto";
            // 
            // BtnAñadirAlCarrito
            // 
            BtnAñadirAlCarrito.BackColor = Color.SeaGreen;
            BtnAñadirAlCarrito.FlatAppearance.BorderColor = Color.White;
            BtnAñadirAlCarrito.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            BtnAñadirAlCarrito.FlatStyle = FlatStyle.Flat;
            BtnAñadirAlCarrito.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAñadirAlCarrito.ForeColor = Color.White;
            BtnAñadirAlCarrito.Location = new Point(656, 52);
            BtnAñadirAlCarrito.Name = "BtnAñadirAlCarrito";
            BtnAñadirAlCarrito.Size = new Size(138, 32);
            BtnAñadirAlCarrito.TabIndex = 6;
            BtnAñadirAlCarrito.Text = "Añadir al carrito";
            BtnAñadirAlCarrito.UseVisualStyleBackColor = false;
            BtnAñadirAlCarrito.Click += BtnAñadirAlCarrito_Click;
            // 
            // NUDCantidadProductoDeseada
            // 
            NUDCantidadProductoDeseada.BackColor = Color.Gainsboro;
            NUDCantidadProductoDeseada.Location = new Point(688, 23);
            NUDCantidadProductoDeseada.Name = "NUDCantidadProductoDeseada";
            NUDCantidadProductoDeseada.ReadOnly = true;
            NUDCantidadProductoDeseada.Size = new Size(75, 23);
            NUDCantidadProductoDeseada.TabIndex = 7;
            NUDCantidadProductoDeseada.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ListaDeProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(NUDCantidadProductoDeseada);
            Controls.Add(BtnAñadirAlCarrito);
            Controls.Add(LblPublicadorProducto);
            Controls.Add(LblStockProducto);
            Controls.Add(LblPrecioProducto);
            Controls.Add(LblNombreProducto);
            Controls.Add(PanelImagen);
            Name = "ListaDeProductos";
            Size = new Size(813, 142);
            ((System.ComponentModel.ISupportInitialize)PbImagenProducto).EndInit();
            PanelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NUDCantidadProductoDeseada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PbImagenProducto;
        private Panel PanelImagen;
        private Label LblNombreProducto;
        private Label LblPrecioProducto;
        private Label LblStockProducto;
        private Label LblPublicadorProducto;
        private Button BtnAñadirAlCarrito;
        private NumericUpDown NUDCantidadProductoDeseada;
    }
}
