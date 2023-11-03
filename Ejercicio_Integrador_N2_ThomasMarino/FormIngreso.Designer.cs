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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Free_Sample_By_Wix;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(246, 303);
            button1.Name = "button1";
            button1.Size = new Size(115, 30);
            button1.TabIndex = 1;
            button1.Text = "Crear cuenta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(173, 104);
            textBox1.MaximumSize = new Size(500, 500);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 35);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(173, 175);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(283, 35);
            textBox2.TabIndex = 4;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(-1, 51);
            label4.Name = "label4";
            label4.Size = new Size(667, 16);
            label4.TabIndex = 7;
            label4.Text = "------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(204, 9);
            label5.Name = "label5";
            label5.Size = new Size(305, 34);
            label5.TabIndex = 8;
            label5.Text = "Bienvenido a Delivered";
            // 
            // button2
            // 
            button2.Location = new Point(260, 216);
            button2.Name = "button2";
            button2.Size = new Size(88, 32);
            button2.TabIndex = 9;
            button2.Text = "Ingresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(622, 338);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "FormIngreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso a Delivered";
            FormClosing += FormIngreso_FormClosing;
            Load += FormIngreso_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
    }
}