namespace Ejercicio_Integrador_N2_ThomasMarino
{
    partial class FormMisCompras
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
            LblMisCompras = new Label();
            FlpProductosComprados = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // LblMisCompras
            // 
            LblMisCompras.AutoSize = true;
            LblMisCompras.Font = new Font("Franklin Gothic Medium", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblMisCompras.ForeColor = Color.White;
            LblMisCompras.Location = new Point(294, 9);
            LblMisCompras.Name = "LblMisCompras";
            LblMisCompras.Size = new Size(264, 43);
            LblMisCompras.TabIndex = 1;
            LblMisCompras.Text = "MIS COMPRAS";
            // 
            // FlpProductosComprados
            // 
            FlpProductosComprados.AutoScroll = true;
            FlpProductosComprados.Location = new Point(2, 87);
            FlpProductosComprados.Name = "FlpProductosComprados";
            FlpProductosComprados.Size = new Size(854, 446);
            FlpProductosComprados.TabIndex = 2;
            // 
            // FormMisCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(857, 545);
            Controls.Add(FlpProductosComprados);
            Controls.Add(LblMisCompras);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMisCompras";
            Text = "FormMisCompras";
            Load += FormMisCompras_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblMisCompras;
        private FlowLayoutPanel FlpProductosComprados;
    }
}