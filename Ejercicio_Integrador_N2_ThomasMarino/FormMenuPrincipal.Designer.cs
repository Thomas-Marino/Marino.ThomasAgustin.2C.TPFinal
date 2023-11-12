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
            panel4 = new Panel();
            button4 = new Button();
            panel3 = new Panel();
            BtnVentas = new Button();
            panel2 = new Panel();
            BtnExplorarProductos = new Button();
            panel1 = new Panel();
            BtnPublicarProducto = new Button();
            button1 = new Button();
            PanelContenedor = new Panel();
            panel5 = new Panel();
            button2 = new Button();
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
            PanelNavegador.Controls.Add(button2);
            PanelNavegador.Controls.Add(panel4);
            PanelNavegador.Controls.Add(button4);
            PanelNavegador.Controls.Add(panel3);
            PanelNavegador.Controls.Add(BtnVentas);
            PanelNavegador.Controls.Add(panel2);
            PanelNavegador.Controls.Add(BtnExplorarProductos);
            PanelNavegador.Controls.Add(panel1);
            PanelNavegador.Controls.Add(BtnPublicarProducto);
            PanelNavegador.Controls.Add(button1);
            PanelNavegador.Dock = DockStyle.Left;
            PanelNavegador.Location = new Point(0, 44);
            PanelNavegador.Name = "PanelNavegador";
            PanelNavegador.Size = new Size(193, 545);
            PanelNavegador.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.Location = new Point(3, 252);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 39);
            panel4.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(12, 252);
            button4.Name = "button4";
            button4.Size = new Size(175, 39);
            button4.TabIndex = 7;
            button4.Text = "Historial de compras";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Location = new Point(3, 192);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 39);
            panel3.TabIndex = 6;
            // 
            // BtnVentas
            // 
            BtnVentas.BackColor = Color.White;
            BtnVentas.FlatAppearance.BorderColor = Color.Black;
            BtnVentas.FlatAppearance.BorderSize = 2;
            BtnVentas.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            BtnVentas.FlatStyle = FlatStyle.Flat;
            BtnVentas.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVentas.Location = new Point(12, 192);
            BtnVentas.Name = "BtnVentas";
            BtnVentas.Size = new Size(175, 39);
            BtnVentas.TabIndex = 5;
            BtnVentas.Text = "Historial de ventas";
            BtnVentas.UseVisualStyleBackColor = false;
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
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(46, 504);
            button1.Name = "button1";
            button1.Size = new Size(97, 29);
            button1.TabIndex = 0;
            button1.Text = "Cerrar sesión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // panel5
            // 
            panel5.BackColor = Color.IndianRed;
            panel5.Location = new Point(3, 311);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 39);
            panel5.TabIndex = 10;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 311);
            button2.Name = "button2";
            button2.Size = new Size(175, 39);
            button2.TabIndex = 9;
            button2.Text = "Carrito";
            button2.UseVisualStyleBackColor = false;
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
        private Button button1;
        private Button BtnCerrarAplicacion;
        private Panel PanelContenedor;
        private Panel panel1;
        private Button BtnPublicarProducto;
        private Panel panel4;
        private Button button4;
        private Panel panel3;
        private Button BtnVentas;
        private Panel panel2;
        private Button BtnExplorarProductos;
        private Panel panel5;
        private Button button2;
    }
}