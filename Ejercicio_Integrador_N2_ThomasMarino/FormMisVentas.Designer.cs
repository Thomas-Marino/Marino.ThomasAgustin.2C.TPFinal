namespace Ejercicio_Integrador_N2_ThomasMarino
{
    partial class FormMisVentas
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
            LblMisVentas = new Label();
            FlpProductosVendidos = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // LblMisVentas
            // 
            LblMisVentas.AutoSize = true;
            LblMisVentas.Font = new Font("Franklin Gothic Medium", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblMisVentas.ForeColor = Color.White;
            LblMisVentas.Location = new Point(286, 9);
            LblMisVentas.Name = "LblMisVentas";
            LblMisVentas.Size = new Size(224, 43);
            LblMisVentas.TabIndex = 2;
            LblMisVentas.Text = "MIS VENTAS";
            // 
            // FlpProductosVendidos
            // 
            FlpProductosVendidos.AutoScroll = true;
            FlpProductosVendidos.Location = new Point(2, 76);
            FlpProductosVendidos.Name = "FlpProductosVendidos";
            FlpProductosVendidos.Size = new Size(854, 446);
            FlpProductosVendidos.TabIndex = 3;
            // 
            // FormMisVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(857, 545);
            Controls.Add(FlpProductosVendidos);
            Controls.Add(LblMisVentas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMisVentas";
            Text = "FormMisVentas";
            Load += FormMisVentas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblMisVentas;
        private FlowLayoutPanel FlpProductosVendidos;
    }
}