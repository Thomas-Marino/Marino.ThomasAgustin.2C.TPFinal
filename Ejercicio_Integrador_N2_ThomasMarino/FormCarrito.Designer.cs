namespace Ejercicio_Integrador_N2_ThomasMarino
{
    partial class FormCarrito
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
            LblMiCarrito = new Label();
            FlpProductosDelCarrito = new FlowLayoutPanel();
            BtnRealizarCompra = new Button();
            TxbDireccionDeEntrega = new TextBox();
            LblDireccionDeEntrega = new Label();
            SuspendLayout();
            // 
            // LblMiCarrito
            // 
            LblMiCarrito.AutoSize = true;
            LblMiCarrito.Font = new Font("Franklin Gothic Medium", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblMiCarrito.ForeColor = Color.White;
            LblMiCarrito.Location = new Point(311, 9);
            LblMiCarrito.Name = "LblMiCarrito";
            LblMiCarrito.Size = new Size(221, 43);
            LblMiCarrito.TabIndex = 0;
            LblMiCarrito.Text = "MI CARRITO";
            // 
            // FlpProductosDelCarrito
            // 
            FlpProductosDelCarrito.AutoScroll = true;
            FlpProductosDelCarrito.Location = new Point(1, 65);
            FlpProductosDelCarrito.Name = "FlpProductosDelCarrito";
            FlpProductosDelCarrito.Size = new Size(839, 370);
            FlpProductosDelCarrito.TabIndex = 1;
            // 
            // BtnRealizarCompra
            // 
            BtnRealizarCompra.BackColor = Color.SeaGreen;
            BtnRealizarCompra.FlatAppearance.BorderColor = Color.White;
            BtnRealizarCompra.FlatAppearance.BorderSize = 2;
            BtnRealizarCompra.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            BtnRealizarCompra.FlatStyle = FlatStyle.Flat;
            BtnRealizarCompra.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRealizarCompra.ForeColor = Color.White;
            BtnRealizarCompra.Location = new Point(334, 457);
            BtnRealizarCompra.Name = "BtnRealizarCompra";
            BtnRealizarCompra.Size = new Size(183, 43);
            BtnRealizarCompra.TabIndex = 2;
            BtnRealizarCompra.Text = "Realizar compra";
            BtnRealizarCompra.UseVisualStyleBackColor = false;
            BtnRealizarCompra.Click += BtnRealizarCompra_Click;
            // 
            // TxbDireccionDeEntrega
            // 
            TxbDireccionDeEntrega.BackColor = Color.White;
            TxbDireccionDeEntrega.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxbDireccionDeEntrega.Location = new Point(12, 465);
            TxbDireccionDeEntrega.Name = "TxbDireccionDeEntrega";
            TxbDireccionDeEntrega.Size = new Size(229, 29);
            TxbDireccionDeEntrega.TabIndex = 3;
            // 
            // LblDireccionDeEntrega
            // 
            LblDireccionDeEntrega.AutoSize = true;
            LblDireccionDeEntrega.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblDireccionDeEntrega.ForeColor = Color.White;
            LblDireccionDeEntrega.Location = new Point(12, 438);
            LblDireccionDeEntrega.Name = "LblDireccionDeEntrega";
            LblDireccionDeEntrega.Size = new Size(183, 24);
            LblDireccionDeEntrega.TabIndex = 4;
            LblDireccionDeEntrega.Text = "Direccion de entrega:";
            // 
            // FormCarrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(841, 506);
            Controls.Add(LblDireccionDeEntrega);
            Controls.Add(TxbDireccionDeEntrega);
            Controls.Add(BtnRealizarCompra);
            Controls.Add(FlpProductosDelCarrito);
            Controls.Add(LblMiCarrito);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCarrito";
            Text = "FormCarrito";
            Load += FormCarrito_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblMiCarrito;
        private FlowLayoutPanel FlpProductosDelCarrito;
        private Button BtnRealizarCompra;
        private TextBox TxbDireccionDeEntrega;
        private Label LblDireccionDeEntrega;
    }
}