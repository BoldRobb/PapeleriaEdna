namespace Presentacion.Formularios.Inventario
{
    partial class AgregarCategoria
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
            name_label = new Label();
            label2 = new Label();
            textBoxDescripcion = new TextBox();
            textBoxNombre = new TextBox();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            name_label.ForeColor = SystemColors.ControlLightLight;
            name_label.Location = new Point(31, 32);
            name_label.Name = "name_label";
            name_label.Size = new Size(258, 30);
            name_label.TabIndex = 0;
            name_label.Text = "Nombre de la categoria";
            name_label.Click += name_label_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(31, 142);
            label2.Name = "label2";
            label2.Size = new Size(134, 30);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            label2.Click += label2_Click;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.BackColor = SystemColors.Menu;
            textBoxDescripcion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescripcion.ForeColor = Color.White;
            textBoxDescripcion.Location = new Point(71, 260);
            textBoxDescripcion.Margin = new Padding(3, 2, 3, 2);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(763, 227);
            textBoxDescripcion.TabIndex = 2;
            textBoxDescripcion.TextChanged += textBox1_TextChanged;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = SystemColors.Menu;
            textBoxNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.ForeColor = Color.White;
            textBoxNombre.Location = new Point(71, 160);
            textBoxNombre.Margin = new Padding(3, 2, 3, 2);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(763, 27);
            textBoxNombre.TabIndex = 3;
            textBoxNombre.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(23, 557);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(141, 47);
            button2.TabIndex = 5;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += return_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(896, 558);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(141, 47);
            button1.TabIndex = 6;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(name_label);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(40, 86);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 434);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 52);
            label1.Name = "label1";
            label1.Size = new Size(270, 30);
            label1.TabIndex = 8;
            label1.Text = "Agregar nueva categoria";
            // 
            // AgregarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1049, 616);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxDescripcion);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AgregarCategoria";
            Text = "Agregar Categoria";
            Load += AgregarCategoria_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_label;
        private Label label2;
        private TextBox textBoxDescripcion;
        private TextBox textBoxNombre;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Label label1;
    }
}