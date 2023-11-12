namespace Ejercicio_Integrador_N2_ThomasMarino
{
    partial class FormExplorarProductos
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
            GbCategorias = new GroupBox();
            RdbFiltrarVerTodo = new RadioButton();
            RdbFiltrarTecnologia = new RadioButton();
            RdbFiltrarMuebles = new RadioButton();
            RdbFiltrarHerramientas = new RadioButton();
            RdbFiltrarVehiculos = new RadioButton();
            TxbFiltrarNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxbFiltrarPublicador = new TextBox();
            CbFiltrarPrecio = new ComboBox();
            label3 = new Label();
            BtnAplicarFiltros = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            BtnBorrarFiltros = new Button();
            GbCategorias.SuspendLayout();
            SuspendLayout();
            // 
            // GbCategorias
            // 
            GbCategorias.Controls.Add(RdbFiltrarVerTodo);
            GbCategorias.Controls.Add(RdbFiltrarTecnologia);
            GbCategorias.Controls.Add(RdbFiltrarMuebles);
            GbCategorias.Controls.Add(RdbFiltrarHerramientas);
            GbCategorias.Controls.Add(RdbFiltrarVehiculos);
            GbCategorias.ForeColor = Color.White;
            GbCategorias.Location = new Point(12, 2);
            GbCategorias.Name = "GbCategorias";
            GbCategorias.Size = new Size(817, 44);
            GbCategorias.TabIndex = 1;
            GbCategorias.TabStop = false;
            GbCategorias.Text = "Filtrar por categoría:";
            // 
            // RdbFiltrarVerTodo
            // 
            RdbFiltrarVerTodo.AutoSize = true;
            RdbFiltrarVerTodo.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RdbFiltrarVerTodo.ForeColor = Color.White;
            RdbFiltrarVerTodo.Location = new Point(121, 14);
            RdbFiltrarVerTodo.Name = "RdbFiltrarVerTodo";
            RdbFiltrarVerTodo.Size = new Size(94, 24);
            RdbFiltrarVerTodo.TabIndex = 4;
            RdbFiltrarVerTodo.TabStop = true;
            RdbFiltrarVerTodo.Text = "VER TODO";
            RdbFiltrarVerTodo.UseVisualStyleBackColor = true;
            RdbFiltrarVerTodo.Click += RdbFiltrarVerTodo_Click;
            // 
            // RdbFiltrarTecnologia
            // 
            RdbFiltrarTecnologia.AutoSize = true;
            RdbFiltrarTecnologia.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RdbFiltrarTecnologia.ForeColor = SystemColors.Control;
            RdbFiltrarTecnologia.Location = new Point(253, 14);
            RdbFiltrarTecnologia.Name = "RdbFiltrarTecnologia";
            RdbFiltrarTecnologia.Size = new Size(97, 24);
            RdbFiltrarTecnologia.TabIndex = 3;
            RdbFiltrarTecnologia.TabStop = true;
            RdbFiltrarTecnologia.Text = "Tecnología";
            RdbFiltrarTecnologia.UseVisualStyleBackColor = true;
            RdbFiltrarTecnologia.Click += RdbFiltrarTecnologia_Click;
            // 
            // RdbFiltrarMuebles
            // 
            RdbFiltrarMuebles.AutoSize = true;
            RdbFiltrarMuebles.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RdbFiltrarMuebles.ForeColor = Color.White;
            RdbFiltrarMuebles.Location = new Point(403, 14);
            RdbFiltrarMuebles.Name = "RdbFiltrarMuebles";
            RdbFiltrarMuebles.Size = new Size(82, 24);
            RdbFiltrarMuebles.TabIndex = 2;
            RdbFiltrarMuebles.TabStop = true;
            RdbFiltrarMuebles.Text = "Muebles";
            RdbFiltrarMuebles.UseVisualStyleBackColor = true;
            RdbFiltrarMuebles.Click += RdbFiltrarMuebles_Click;
            // 
            // RdbFiltrarHerramientas
            // 
            RdbFiltrarHerramientas.AutoSize = true;
            RdbFiltrarHerramientas.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RdbFiltrarHerramientas.ForeColor = Color.White;
            RdbFiltrarHerramientas.Location = new Point(527, 14);
            RdbFiltrarHerramientas.Name = "RdbFiltrarHerramientas";
            RdbFiltrarHerramientas.Size = new Size(115, 24);
            RdbFiltrarHerramientas.TabIndex = 1;
            RdbFiltrarHerramientas.TabStop = true;
            RdbFiltrarHerramientas.Text = "Herramientas";
            RdbFiltrarHerramientas.UseVisualStyleBackColor = true;
            RdbFiltrarHerramientas.Click += RdbFiltrarHerramientas_Click;
            // 
            // RdbFiltrarVehiculos
            // 
            RdbFiltrarVehiculos.AutoSize = true;
            RdbFiltrarVehiculos.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            RdbFiltrarVehiculos.ForeColor = Color.White;
            RdbFiltrarVehiculos.Location = new Point(696, 14);
            RdbFiltrarVehiculos.Name = "RdbFiltrarVehiculos";
            RdbFiltrarVehiculos.Size = new Size(89, 24);
            RdbFiltrarVehiculos.TabIndex = 0;
            RdbFiltrarVehiculos.TabStop = true;
            RdbFiltrarVehiculos.Text = "Vehiculos";
            RdbFiltrarVehiculos.UseVisualStyleBackColor = true;
            RdbFiltrarVehiculos.Click += RdbFiltrarVehiculos_Click;
            // 
            // TxbFiltrarNombre
            // 
            TxbFiltrarNombre.Location = new Point(12, 96);
            TxbFiltrarNombre.Name = "TxbFiltrarNombre";
            TxbFiltrarNombre.Size = new Size(215, 23);
            TxbFiltrarNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(237, 73);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 4;
            label2.Text = "Publicador:";
            // 
            // TxbFiltrarPublicador
            // 
            TxbFiltrarPublicador.Location = new Point(237, 96);
            TxbFiltrarPublicador.Name = "TxbFiltrarPublicador";
            TxbFiltrarPublicador.Size = new Size(156, 23);
            TxbFiltrarPublicador.TabIndex = 5;
            // 
            // CbFiltrarPrecio
            // 
            CbFiltrarPrecio.DropDownStyle = ComboBoxStyle.DropDownList;
            CbFiltrarPrecio.FormattingEnabled = true;
            CbFiltrarPrecio.Items.AddRange(new object[] { "Ascendente", "Descendente" });
            CbFiltrarPrecio.Location = new Point(403, 96);
            CbFiltrarPrecio.Name = "CbFiltrarPrecio";
            CbFiltrarPrecio.Size = new Size(121, 23);
            CbFiltrarPrecio.TabIndex = 6;
            CbFiltrarPrecio.SelectedIndexChanged += CbFiltrarPrecio_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(403, 73);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 7;
            label3.Text = "Precio:";
            // 
            // BtnAplicarFiltros
            // 
            BtnAplicarFiltros.BackColor = Color.SeaGreen;
            BtnAplicarFiltros.FlatAppearance.BorderColor = Color.White;
            BtnAplicarFiltros.FlatAppearance.BorderSize = 2;
            BtnAplicarFiltros.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            BtnAplicarFiltros.FlatStyle = FlatStyle.Flat;
            BtnAplicarFiltros.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAplicarFiltros.ForeColor = Color.White;
            BtnAplicarFiltros.Location = new Point(616, 90);
            BtnAplicarFiltros.Name = "BtnAplicarFiltros";
            BtnAplicarFiltros.Size = new Size(213, 33);
            BtnAplicarFiltros.TabIndex = 8;
            BtnAplicarFiltros.Text = "Aplicar filtros de busqueda";
            BtnAplicarFiltros.UseVisualStyleBackColor = false;
            BtnAplicarFiltros.Click += BtnAplicarFiltros_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(1, 129);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(839, 376);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // BtnBorrarFiltros
            // 
            BtnBorrarFiltros.BackColor = Color.Gainsboro;
            BtnBorrarFiltros.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            BtnBorrarFiltros.FlatStyle = FlatStyle.Flat;
            BtnBorrarFiltros.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBorrarFiltros.Location = new Point(535, 90);
            BtnBorrarFiltros.Name = "BtnBorrarFiltros";
            BtnBorrarFiltros.Size = new Size(75, 33);
            BtnBorrarFiltros.TabIndex = 10;
            BtnBorrarFiltros.Text = "Borrar";
            BtnBorrarFiltros.UseVisualStyleBackColor = false;
            BtnBorrarFiltros.Click += BtnBorrarFiltros_Click;
            // 
            // FormExplorarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(841, 506);
            Controls.Add(BtnBorrarFiltros);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(BtnAplicarFiltros);
            Controls.Add(label3);
            Controls.Add(CbFiltrarPrecio);
            Controls.Add(TxbFiltrarPublicador);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxbFiltrarNombre);
            Controls.Add(GbCategorias);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormExplorarProductos";
            Text = "FormExplorarProductos";
            Load += FormExplorarProductos_Load;
            GbCategorias.ResumeLayout(false);
            GbCategorias.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox GbCategorias;
        private RadioButton RdbFiltrarVerTodo;
        private RadioButton RdbFiltrarTecnologia;
        private RadioButton RdbFiltrarMuebles;
        private RadioButton RdbFiltrarHerramientas;
        private RadioButton RdbFiltrarVehiculos;
        private TextBox TxbFiltrarNombre;
        private Label label1;
        private Label label2;
        private TextBox TxbFiltrarPublicador;
        private ComboBox CbFiltrarPrecio;
        private Label label3;
        private Button BtnAplicarFiltros;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button BtnBorrarFiltros;
    }
}