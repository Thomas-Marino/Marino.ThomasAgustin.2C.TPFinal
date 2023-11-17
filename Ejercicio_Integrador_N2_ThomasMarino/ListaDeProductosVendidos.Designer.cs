namespace Ejercicio_Integrador_N2_ThomasMarino
{
    partial class ListaDeProductosVendidos
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
            LblFechaDeVenta = new Label();
            LblPrecioUnitarioProducto = new Label();
            LblCompradorProducto = new Label();
            LblCantidadProductoVendido = new Label();
            LblPrecioTotalProducto = new Label();
            LblNombreProductoVendido = new Label();
            PanelImagen = new Panel();
            PbImagenProductoDeseado = new PictureBox();
            PanelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbImagenProductoDeseado).BeginInit();
            SuspendLayout();
            // 
            // LblFechaDeVenta
            // 
            LblFechaDeVenta.AutoSize = true;
            LblFechaDeVenta.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblFechaDeVenta.Location = new Point(496, 110);
            LblFechaDeVenta.Name = "LblFechaDeVenta";
            LblFechaDeVenta.Size = new Size(108, 20);
            LblFechaDeVenta.TabIndex = 26;
            LblFechaDeVenta.Text = "Fecha de venta";
            // 
            // LblPrecioUnitarioProducto
            // 
            LblPrecioUnitarioProducto.AutoSize = true;
            LblPrecioUnitarioProducto.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblPrecioUnitarioProducto.Location = new Point(230, 37);
            LblPrecioUnitarioProducto.Name = "LblPrecioUnitarioProducto";
            LblPrecioUnitarioProducto.Size = new Size(143, 24);
            LblPrecioUnitarioProducto.TabIndex = 25;
            LblPrecioUnitarioProducto.Text = "Precio unitario";
            // 
            // LblCompradorProducto
            // 
            LblCompradorProducto.AutoSize = true;
            LblCompradorProducto.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblCompradorProducto.Location = new Point(230, 110);
            LblCompradorProducto.Name = "LblCompradorProducto";
            LblCompradorProducto.Size = new Size(165, 20);
            LblCompradorProducto.TabIndex = 24;
            LblCompradorProducto.Text = "Comprador del producto";
            // 
            // LblCantidadProductoVendido
            // 
            LblCantidadProductoVendido.AutoSize = true;
            LblCantidadProductoVendido.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblCantidadProductoVendido.Location = new Point(230, 61);
            LblCantidadProductoVendido.Name = "LblCantidadProductoVendido";
            LblCantidadProductoVendido.Size = new Size(166, 24);
            LblCantidadProductoVendido.TabIndex = 23;
            LblCantidadProductoVendido.Text = "Cantidad vendida";
            // 
            // LblPrecioTotalProducto
            // 
            LblPrecioTotalProducto.AutoSize = true;
            LblPrecioTotalProducto.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblPrecioTotalProducto.Location = new Point(230, 84);
            LblPrecioTotalProducto.Name = "LblPrecioTotalProducto";
            LblPrecioTotalProducto.Size = new Size(115, 24);
            LblPrecioTotalProducto.TabIndex = 22;
            LblPrecioTotalProducto.Text = "Precio total";
            // 
            // LblNombreProductoVendido
            // 
            LblNombreProductoVendido.AutoSize = true;
            LblNombreProductoVendido.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblNombreProductoVendido.Location = new Point(230, 13);
            LblNombreProductoVendido.Name = "LblNombreProductoVendido";
            LblNombreProductoVendido.Size = new Size(200, 24);
            LblNombreProductoVendido.TabIndex = 21;
            LblNombreProductoVendido.Text = "Nombre del producto";
            // 
            // PanelImagen
            // 
            PanelImagen.BackColor = Color.Gainsboro;
            PanelImagen.Controls.Add(PbImagenProductoDeseado);
            PanelImagen.Dock = DockStyle.Left;
            PanelImagen.Location = new Point(0, 0);
            PanelImagen.Name = "PanelImagen";
            PanelImagen.Size = new Size(224, 142);
            PanelImagen.TabIndex = 20;
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
            // ListaDeProductosVendidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(LblFechaDeVenta);
            Controls.Add(LblPrecioUnitarioProducto);
            Controls.Add(LblCompradorProducto);
            Controls.Add(LblCantidadProductoVendido);
            Controls.Add(LblPrecioTotalProducto);
            Controls.Add(LblNombreProductoVendido);
            Controls.Add(PanelImagen);
            Name = "ListaDeProductosVendidos";
            Size = new Size(813, 142);
            PanelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbImagenProductoDeseado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblFechaDeVenta;
        private Label LblPrecioUnitarioProducto;
        private Label LblCompradorProducto;
        private Label LblCantidadProductoVendido;
        private Label LblPrecioTotalProducto;
        private Label LblNombreProductoVendido;
        private Panel PanelImagen;
        private PictureBox PbImagenProductoDeseado;
    }
}
