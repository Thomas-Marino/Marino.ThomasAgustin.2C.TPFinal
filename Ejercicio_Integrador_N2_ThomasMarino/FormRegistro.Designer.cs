namespace Ejercicio_Integrador_N2_ThomasMarino
{
    partial class FormRegistro
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
            BtnCrearCuenta = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxbNombre = new TextBox();
            TxbApellido = new TextBox();
            TxbDNI = new TextBox();
            TxbUsuario = new TextBox();
            TxbContraseña = new TextBox();
            pictureBox1 = new PictureBox();
            BtnVolver = new Button();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnCrearCuenta
            // 
            BtnCrearCuenta.Location = new Point(189, 345);
            BtnCrearCuenta.Name = "BtnCrearCuenta";
            BtnCrearCuenta.Size = new Size(130, 33);
            BtnCrearCuenta.TabIndex = 0;
            BtnCrearCuenta.Text = "Crear cuenta";
            BtnCrearCuenta.UseVisualStyleBackColor = true;
            BtnCrearCuenta.Click += BtnCrearCuenta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 102);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(398, 102);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 171);
            label3.Name = "label3";
            label3.Size = new Size(38, 21);
            label3.TabIndex = 3;
            label3.Text = "DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 238);
            label4.Name = "label4";
            label4.Size = new Size(206, 21);
            label4.TabIndex = 4;
            label4.Text = "Usuario (max 15 caracteres):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(398, 238);
            label5.Name = "label5";
            label5.Size = new Size(224, 21);
            label5.TabIndex = 5;
            label5.Text = "Contraseña (3 a 12 caracteres):";
            // 
            // TxbNombre
            // 
            TxbNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxbNombre.Location = new Point(38, 126);
            TxbNombre.Name = "TxbNombre";
            TxbNombre.Size = new Size(244, 33);
            TxbNombre.TabIndex = 6;
            // 
            // TxbApellido
            // 
            TxbApellido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxbApellido.Location = new Point(398, 126);
            TxbApellido.Name = "TxbApellido";
            TxbApellido.Size = new Size(244, 33);
            TxbApellido.TabIndex = 7;
            // 
            // TxbDNI
            // 
            TxbDNI.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxbDNI.Location = new Point(38, 195);
            TxbDNI.Name = "TxbDNI";
            TxbDNI.Size = new Size(163, 33);
            TxbDNI.TabIndex = 8;
            // 
            // TxbUsuario
            // 
            TxbUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxbUsuario.Location = new Point(38, 261);
            TxbUsuario.Name = "TxbUsuario";
            TxbUsuario.Size = new Size(244, 33);
            TxbUsuario.TabIndex = 9;
            // 
            // TxbContraseña
            // 
            TxbContraseña.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxbContraseña.Location = new Point(398, 261);
            TxbContraseña.Name = "TxbContraseña";
            TxbContraseña.Size = new Size(244, 33);
            TxbContraseña.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Free_Sample_By_Wix;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // BtnVolver
            // 
            BtnVolver.Location = new Point(348, 345);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(137, 33);
            BtnVolver.TabIndex = 12;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = true;
            BtnVolver.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Impact", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(-1, 42);
            label6.Name = "label6";
            label6.Size = new Size(787, 16);
            label6.TabIndex = 13;
            label6.Text = "------------------------------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(202, 8);
            label7.Name = "label7";
            label7.Size = new Size(408, 34);
            label7.TabIndex = 14;
            label7.Text = "Crear una cuenta en Delivered.";
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 385);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(BtnVolver);
            Controls.Add(pictureBox1);
            Controls.Add(TxbContraseña);
            Controls.Add(TxbUsuario);
            Controls.Add(TxbDNI);
            Controls.Add(TxbApellido);
            Controls.Add(TxbNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnCrearCuenta);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Creacion de cuenta en Delivered";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCrearCuenta;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxbNombre;
        private TextBox TxbApellido;
        private TextBox TxbDNI;
        private TextBox TxbUsuario;
        private TextBox TxbContraseña;
        private PictureBox pictureBox1;
        private Button BtnVolver;
        private Label label6;
        private Label label7;
    }
}