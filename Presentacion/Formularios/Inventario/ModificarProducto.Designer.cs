namespace Presentacion.Formularios.Inventario
{
    partial class ModificarProducto
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
            comboBoxCategorias = new ComboBox();
            comboBoxProducto = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBoxNombre = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBoxPrecio = new TextBox();
            comboBoxCategorias2 = new ComboBox();
            textBoxDescripcion = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxCategorias
            // 
            comboBoxCategorias.FlatStyle = FlatStyle.Flat;
            comboBoxCategorias.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCategorias.ForeColor = Color.White;
            comboBoxCategorias.FormattingEnabled = true;
            comboBoxCategorias.Location = new Point(64, 156);
            comboBoxCategorias.Name = "comboBoxCategorias";
            comboBoxCategorias.Size = new Size(248, 29);
            comboBoxCategorias.TabIndex = 0;
            comboBoxCategorias.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBoxProducto
            // 
            comboBoxProducto.FlatStyle = FlatStyle.Flat;
            comboBoxProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxProducto.ForeColor = Color.White;
            comboBoxProducto.FormattingEnabled = true;
            comboBoxProducto.Location = new Point(343, 88);
            comboBoxProducto.Margin = new Padding(3, 2, 3, 2);
            comboBoxProducto.Name = "comboBoxProducto";
            comboBoxProducto.Size = new Size(248, 29);
            comboBoxProducto.TabIndex = 1;
            comboBoxProducto.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 118);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 2;
            label1.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(343, 42);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 3;
            label2.Text = "Producto";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.None;
            textBoxNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.ForeColor = Color.White;
            textBoxNombre.Location = new Point(37, 202);
            textBoxNombre.Margin = new Padding(3, 2, 3, 2);
            textBoxNombre.Multiline = true;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(242, 27);
            textBoxNombre.TabIndex = 4;
            textBoxNombre.Text = "Nombre";
            textBoxNombre.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(886, 551);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(151, 54);
            button1.TabIndex = 5;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 551);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(132, 54);
            button2.TabIndex = 6;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.BorderStyle = BorderStyle.None;
            textBoxPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrecio.ForeColor = Color.White;
            textBoxPrecio.Location = new Point(376, 265);
            textBoxPrecio.Margin = new Padding(3, 2, 3, 2);
            textBoxPrecio.Multiline = true;
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(242, 32);
            textBoxPrecio.TabIndex = 7;
            textBoxPrecio.Text = "Precio";
            textBoxPrecio.TextChanged += textBox2_TextChanged;
            // 
            // comboBoxCategorias2
            // 
            comboBoxCategorias2.FlatStyle = FlatStyle.Flat;
            comboBoxCategorias2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCategorias2.ForeColor = Color.White;
            comboBoxCategorias2.FormattingEnabled = true;
            comboBoxCategorias2.Location = new Point(37, 313);
            comboBoxCategorias2.Margin = new Padding(3, 2, 3, 2);
            comboBoxCategorias2.Name = "comboBoxCategorias2";
            comboBoxCategorias2.Size = new Size(242, 29);
            comboBoxCategorias2.TabIndex = 8;
            comboBoxCategorias2.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.BorderStyle = BorderStyle.None;
            textBoxDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescripcion.ForeColor = Color.White;
            textBoxDescripcion.Location = new Point(690, 156);
            textBoxDescripcion.Margin = new Padding(3, 2, 3, 2);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(314, 254);
            textBoxDescripcion.TabIndex = 9;
            textBoxDescripcion.Text = "Descripcion";
            textBoxDescripcion.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(37, 164);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 10;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(376, 228);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 11;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 273);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 12;
            label5.Text = "Nueva Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(690, 118);
            label6.Name = "label6";
            label6.Size = new Size(116, 25);
            label6.TabIndex = 13;
            label6.Text = "Descripcion";
            label6.Click += label6_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxCategorias2);
            panel1.Controls.Add(textBoxNombre);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBoxProducto);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(33, 68);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 400);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(33, 35);
            label7.Name = "label7";
            label7.Size = new Size(260, 30);
            label7.TabIndex = 15;
            label7.Text = "Informacion del producto";
            // 
            // ModificarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1049, 616);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxPrecio);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBoxCategorias);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ModificarProducto";
            Text = "ModificarProducto";
            Load += ModificarProducto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCategorias;
        private ComboBox comboBoxProducto;
        private Label label1;
        private Label label2;
        private TextBox textBoxNombre;
        private Button button1;
        private Button button2;
        private TextBox textBoxPrecio;
        private ComboBox comboBoxCategorias2;
        private TextBox textBoxDescripcion;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Label label7;
    }
}