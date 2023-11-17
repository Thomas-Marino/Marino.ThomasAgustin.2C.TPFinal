namespace Ejercicio_Integrador_N2_ThomasMarino
{
    partial class ListaDeProductosComprados
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
            LblPrecioUnitarioProducto = new Label();
            LblPublicadorProducto = new Label();
            LblCantidadProductoDeseada = new Label();
            LblPrecioTotalProducto = new Label();
            LblNombreProductoAñadido = new Label();
            PanelImagen = new Panel();
            PbImagenProductoDeseado = new PictureBox();
            LblFechaDeCompra = new Label();
            PanelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbImagenProductoDeseado).BeginInit();
            SuspendLayout();
            // 
            // LblPrecioUnitarioProducto
            // 
            LblPrecioUnitarioProducto.AutoSize = true;
            LblPrecioUnitarioProducto.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblPrecioUnitarioProducto.Location = new Point(241, 38);
            LblPrecioUnitarioProducto.Name = "LblPrecioUnitarioProducto";
            LblPrecioUnitarioProducto.Size = new Size(143, 24);
            LblPrecioUnitarioProducto.TabIndex = 18;
            LblPrecioUnitarioProducto.Text = "Precio unitario";
            // 
            // LblPublicadorProducto
            // 
            LblPublicadorProducto.AutoSize = true;
            LblPublicadorProducto.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblPublicadorProducto.Location = new Point(241, 111);
            LblPublicadorProducto.Name = "LblPublicadorProducto";
            LblPublicadorProducto.Size = new Size(163, 20);
            LblPublicadorProducto.TabIndex = 16;
            LblPublicadorProducto.Text = "Publicador del producto";
            // 
            // LblCantidadProductoDeseada
            // 
            LblCantidadProductoDeseada.AutoSize = true;
            LblCantidadProductoDeseada.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblCantidadProductoDeseada.Location = new Point(241, 62);
            LblCantidadProductoDeseada.Name = "LblCantidadProductoDeseada";
            LblCantidadProductoDeseada.Size = new Size(172, 24);
            LblCantidadProductoDeseada.TabIndex = 15;
            LblCantidadProductoDeseada.Text = "Cantidad deseada";
            // 
            // LblPrecioTotalProducto
            // 
            LblPrecioTotalProducto.AutoSize = true;
            LblPrecioTotalProducto.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblPrecioTotalProducto.Location = new Point(241, 85);
            LblPrecioTotalProducto.Name = "LblPrecioTotalProducto";
            LblPrecioTotalProducto.Size = new Size(115, 24);
            LblPrecioTotalProducto.TabIndex = 14;
            LblPrecioTotalProducto.Text = "Precio total";
            // 
            // LblNombreProductoAñadido
            // 
            LblNombreProductoAñadido.AutoSize = true;
            LblNombreProductoAñadido.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblNombreProductoAñadido.Location = new Point(241, 14);
            LblNombreProductoAñadido.Name = "LblNombreProductoAñadido";
            LblNombreProductoAñadido.Size = new Size(200, 24);
            LblNombreProductoAñadido.TabIndex = 13;
            LblNombreProductoAñadido.Text = "Nombre del producto";
            // 
            // PanelImagen
            // 
            PanelImagen.BackColor = Color.Gainsboro;
            PanelImagen.Controls.Add(PbImagenProductoDeseado);
            PanelImagen.Dock = DockStyle.Left;
            PanelImagen.Location = new Point(0, 0);
            PanelImagen.Name = "PanelImagen";
            PanelImagen.Size = new Size(224, 142);
            PanelImagen.TabIndex = 12;
            // 
            // PbImagenProductoDeseado
            // 
            PbImagenProductoDeseado.BackColor = Color.White;
            PbImagenProductoDeseado.Location = new Point(26, 13);
            PbImagenProductoDeseado.Name = "PbImagenProductoDeseado";
            PbImagenProductoDeseado.Size = new Size(169, 117);
            PbImagenProductoDeseado.SizeMode = PictureBoxSizeMode.CenterImage;
            PbImagenProductoDeseado.TabIndex = 0;
            PbImagenProductoDeseado.TabStop = false;
            // 
            // LblFechaDeCompra
            // 
            LblFechaDeCompra.AutoSize = true;
            LblFechaDeCompra.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblFechaDeCompra.Location = new Point(507, 111);
            LblFechaDeCompra.Name = "LblFechaDeCompra";
            LblFechaDeCompra.Size = new Size(120, 20);
            LblFechaDeCompra.TabIndex = 19;
            LblFechaDeCompra.Text = "Fecha de compra";
            // 
            // ListaDeProductosComprados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(LblFechaDeCompra);
            Controls.Add(LblPrecioUnitarioProducto);
            Controls.Add(LblPublicadorProducto);
            Controls.Add(LblCantidadProductoDeseada);
            Controls.Add(LblPrecioTotalProducto);
            Controls.Add(LblNombreProductoAñadido);
            Controls.Add(PanelImagen);
            Name = "ListaDeProductosComprados";
            Size = new Size(813, 142);
            PanelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbImagenProductoDeseado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblPrecioUnitarioProducto;
        private Label LblPublicadorProducto;
        private Label LblCantidadProductoDeseada;
        private Label LblPrecioTotalProducto;
        private Label LblNombreProductoAñadido;
        private Panel PanelImagen;
        private PictureBox PbImagenProductoDeseado;
        private Label LblFechaDeCompra;
    }
}
