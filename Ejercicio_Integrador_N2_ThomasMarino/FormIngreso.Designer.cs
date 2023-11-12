namespace Ejercicio_Integrador_N2_ThomasMarino
{
    partial class FormIngreso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            BtnCrearCuenta = new Button();
            label1 = new Label();
            TxbLoginUsuario = new TextBox();
            TxbLoginContraseña = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            BtnIngresar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Free_Sample_By_Wix;
            pictureBox1.Location = new Point(-1, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnCrearCuenta
            // 
            BtnCrearCuenta.Location = new Point(246, 303);
            BtnCrearCuenta.Name = "BtnCrearCuenta";
            BtnCrearCuenta.Size = new Size(115, 30);
            BtnCrearCuenta.TabIndex = 1;
            BtnCrearCuenta.Text = "Crear cuenta";
            BtnCrearCuenta.UseVisualStyleBackColor = true;
            BtnCrearCuenta.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(204, 274);
            label1.Name = "label1";
            label1.Size = new Size(191, 26);
            label1.TabIndex = 2;
            label1.Text = "No tienes cuenta?";
            // 
            // TxbLoginUsuario
            // 
            TxbLoginUsuario.Anchor = AnchorStyles.None;
            TxbLoginUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxbLoginUsuario.Location = new Point(173, 104);
            TxbLoginUsuario.MaximumSize = new Size(500, 500);
            TxbLoginUsuario.Name = "TxbLoginUsuario";
            TxbLoginUsuario.Size = new Size(283, 35);
            TxbLoginUsuario.TabIndex = 3;
            // 
            // TxbLoginContraseña
            // 
            TxbLoginContraseña.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxbLoginContraseña.Location = new Point(173, 175);
            TxbLoginContraseña.Name = "TxbLoginContraseña";
            TxbLoginContraseña.PasswordChar = '*';
            TxbLoginContraseña.Size = new Size(283, 35);
            TxbLoginContraseña.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(173, 80);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 5;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(173, 151);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 6;
            label3.Text = "Contraseña:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(197, 8);
            label5.Name = "label5";
            label5.Size = new Size(305, 34);
            label5.TabIndex = 8;
            label5.Text = "Bienvenido a Delivered";
            // 
            // BtnIngresar
            // 
            BtnIngresar.Location = new Point(260, 216);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(88, 32);
            BtnIngresar.TabIndex = 9;
            BtnIngresar.Text = "Ingresar";
            BtnIngresar.UseVisualStyleBackColor = true;
            BtnIngresar.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 44);
            panel1.TabIndex = 10;
            // 
            // FormIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(622, 338);
            Controls.Add(panel1);
            Controls.Add(BtnIngresar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxbLoginContraseña);
            Controls.Add(TxbLoginUsuario);
            Controls.Add(label1);
            Controls.Add(BtnCrearCuenta);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormIngreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso a Delivered";
            FormClosing += FormIngreso_FormClosing;
            Load += FormIngreso_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnCrearCuenta;
        private Label label1;
        private TextBox TxbLoginUsuario;
        private TextBox TxbLoginContraseña;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button BtnIngresar;
        private Panel panel1;
    }
}