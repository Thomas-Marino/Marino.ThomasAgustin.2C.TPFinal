namespace Ejercicio_Integrador_N2_ThomasMarino
{
    partial class FormMenuPrincipal
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
            PanelSuperior = new Panel();
            BtnCerrarAplicacion = new Button();
            LblSaludo = new Label();
            pictureBox1 = new PictureBox();
            PanelNavegador = new Panel();
            panel5 = new Panel();
            BtnVerCarrito = new Button();
            panel4 = new Panel();
            BtnMisCompras = new Button();
            panel3 = new Panel();
            BtnMisVentas = new Button();
            panel2 = new Panel();
            BtnExplorarProductos = new Button();
            panel1 = new Panel();
            BtnPublicarProducto = new Button();
            BtnCerrarSesion = new Button();
            PanelContenedor = new Panel();
            PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelNavegador.SuspendLayout();
            SuspendLayout();
            // 
            // PanelSuperior
            // 
            PanelSuperior.BackColor = Color.WhiteSmoke;
            PanelSuperior.BorderStyle = BorderStyle.FixedSingle;
            PanelSuperior.Controls.Add(BtnCerrarAplicacion);
            PanelSuperior.Controls.Add(LblSaludo);
            PanelSuperior.Controls.Add(pictureBox1);
            PanelSuperior.Dock = DockStyle.Top;
            PanelSuperior.Location = new Point(0, 0);
            PanelSuperior.Name = "PanelSuperior";
            PanelSuperior.Size = new Size(1050, 44);
            PanelSuperior.TabIndex = 11;
            // 
            // BtnCerrarAplicacion
            // 
            BtnCerrarAplicacion.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnCerrarAplicacion.FlatStyle = FlatStyle.Flat;
            BtnCerrarAplicacion.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCerrarAplicacion.Location = new Point(1010, -1);
            BtnCerrarAplicacion.Name = "BtnCerrarAplicacion";
            BtnCerrarAplicacion.Size = new Size(39, 43);
            BtnCerrarAplicacion.TabIndex = 13;
            BtnCerrarAplicacion.Text = "X";
            BtnCerrarAplicacion.UseVisualStyleBackColor = true;
            BtnCerrarAplicacion.Click += BtnCerrarAplicacion_Click;
            // 
            // LblSaludo
            // 
            LblSaludo.AutoSize = true;
            LblSaludo.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblSaludo.Location = new Point(198, 18);
            LblSaludo.Name = "LblSaludo";
            LblSaludo.Size = new Size(133, 24);
            LblSaludo.TabIndex = 13;
            LblSaludo.Text = "Label Saludo.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Free_Sample_By_Wix;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // PanelNavegador
            // 
            PanelNavegador.BackColor = SystemColors.ControlLight;
            PanelNavegador.Controls.Add(panel5);
            PanelNavegador.Controls.Add(BtnVerCarrito);
            PanelNavegador.Controls.Add(panel4);
            PanelNavegador.Controls.Add(BtnMisCompras);
            PanelNavegador.Controls.Add(panel3);
            PanelNavegador.Controls.Add(BtnMisVentas);
            PanelNavegador.Controls.Add(panel2);
            PanelNavegador.Controls.Add(BtnExplorarProductos);
            PanelNavegador.Controls.Add(panel1);
            PanelNavegador.Controls.Add(BtnPublicarProducto);
            PanelNavegador.Controls.Add(BtnCerrarSesion);
            PanelNavegador.Dock = DockStyle.Left;
            PanelNavegador.Location = new Point(0, 44);
            PanelNavegador.Name = "PanelNavegador";
            PanelNavegador.Size = new Size(193, 545);
            PanelNavegador.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.BackColor = Color.IndianRed;
            panel5.Location = new Point(3, 189);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 39);
            panel5.TabIndex = 10;
            // 
            // BtnVerCarrito
            // 
            BtnVerCarrito.BackColor = Color.White;
            BtnVerCarrito.FlatAppearance.BorderColor = Color.Black;
            BtnVerCarrito.FlatAppearance.BorderSize = 2;
            BtnVerCarrito.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            BtnVerCarrito.FlatStyle = FlatStyle.Flat;
            BtnVerCarrito.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVerCarrito.Location = new Point(12, 189);
            BtnVerCarrito.Name = "BtnVerCarrito";
            BtnVerCarrito.Size = new Size(175, 39);
            BtnVerCarrito.TabIndex = 9;
            BtnVerCarrito.Text = "Carrito";
            BtnVerCarrito.UseVisualStyleBackColor = false;
            BtnVerCarrito.Click += BtnVerCarrito_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.Location = new Point(3, 248);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 39);
            panel4.TabIndex = 8;
            // 
            // BtnMisCompras
            // 
            BtnMisCompras.BackColor = Color.White;
            BtnMisCompras.FlatAppearance.BorderColor = Color.Black;
            BtnMisCompras.FlatAppearance.BorderSize = 2;
            BtnMisCompras.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            BtnMisCompras.FlatStyle = FlatStyle.Flat;
            BtnMisCompras.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMisCompras.Location = new Point(12, 248);
            BtnMisCompras.Name = "BtnMisCompras";
            BtnMisCompras.Size = new Size(175, 39);
            BtnMisCompras.TabIndex = 7;
            BtnMisCompras.Text = "Mis compras";
            BtnMisCompras.UseVisualStyleBackColor = false;
            BtnMisCompras.Click += BtnMisCompras_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Location = new Point(3, 307);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 39);
            panel3.TabIndex = 6;
            // 
            // BtnMisVentas
            // 
            BtnMisVentas.BackColor = Color.White;
            BtnMisVentas.FlatAppearance.BorderColor = Color.Black;
            BtnMisVentas.FlatAppearance.BorderSize = 2;
            BtnMisVentas.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            BtnMisVentas.FlatStyle = FlatStyle.Flat;
            BtnMisVentas.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMisVentas.Location = new Point(12, 307);
            BtnMisVentas.Name = "BtnMisVentas";
            BtnMisVentas.Size = new Size(175, 39);
            BtnMisVentas.TabIndex = 5;
            BtnMisVentas.Text = "Mis Ventas";
            BtnMisVentas.UseVisualStyleBackColor = false;
            BtnMisVentas.Click += BtnMisVentas_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Location = new Point(3, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 39);
            panel2.TabIndex = 4;
            // 
            // BtnExplorarProductos
            // 
            BtnExplorarProductos.BackColor = Color.White;
            BtnExplorarProductos.FlatAppearance.BorderColor = Color.Black;
            BtnExplorarProductos.FlatAppearance.BorderSize = 2;
            BtnExplorarProductos.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            BtnExplorarProductos.FlatStyle = FlatStyle.Flat;
            BtnExplorarProductos.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnExplorarProductos.Location = new Point(12, 133);
            BtnExplorarProductos.Name = "BtnExplorarProductos";
            BtnExplorarProductos.Size = new Size(175, 39);
            BtnExplorarProductos.TabIndex = 3;
            BtnExplorarProductos.Text = "Explorar productos";
            BtnExplorarProductos.UseVisualStyleBackColor = false;
            BtnExplorarProductos.Click += BtnExplorarProductos_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Location = new Point(3, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 39);
            panel1.TabIndex = 2;
            // 
            // BtnPublicarProducto
            // 
            BtnPublicarProducto.BackColor = Color.White;
            BtnPublicarProducto.FlatAppearance.BorderColor = Color.Black;
            BtnPublicarProducto.FlatAppearance.BorderSize = 2;
            BtnPublicarProducto.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            BtnPublicarProducto.FlatStyle = FlatStyle.Flat;
            BtnPublicarProducto.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPublicarProducto.Location = new Point(12, 71);
            BtnPublicarProducto.Name = "BtnPublicarProducto";
            BtnPublicarProducto.Size = new Size(175, 39);
            BtnPublicarProducto.TabIndex = 1;
            BtnPublicarProducto.Text = "Publicar un producto";
            BtnPublicarProducto.UseVisualStyleBackColor = false;
            BtnPublicarProducto.Click += BtnPublicarProducto_Click;
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.FlatAppearance.BorderSize = 2;
            BtnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnCerrarSesion.FlatStyle = FlatStyle.Flat;
            BtnCerrarSesion.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCerrarSesion.Location = new Point(46, 504);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Size = new Size(97, 29);
            BtnCerrarSesion.TabIndex = 0;
            BtnCerrarSesion.Text = "Cerrar sesión";
            BtnCerrarSesion.UseVisualStyleBackColor = true;
            BtnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = SystemColors.ControlDark;
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(193, 44);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(857, 545);
            PanelContenedor.TabIndex = 13;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 589);
            Controls.Add(PanelContenedor);
            Controls.Add(PanelNavegador);
            Controls.Add(PanelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuPrincipal";
            Load += FormMenuPrincipal_Load;
            PanelSuperior.ResumeLayout(false);
            PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelNavegador.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelSuperior;
        private PictureBox pictureBox1;
        private Label LblSaludo;
        private Panel PanelNavegador;
        private Button BtnCerrarSesion;
        private Button BtnCerrarAplicacion;
        private Panel PanelContenedor;
        private Panel panel1;
        private Button BtnPublicarProducto;
        private Panel panel4;
        private Button BtnMisCompras;
        private Panel panel2;
        private Button BtnExplorarProductos;
        private Panel panel5;
        private Button BtnVerCarrito;
        private Panel panel3;
        private Button BtnMisVentas;
    }
}