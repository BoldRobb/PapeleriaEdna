namespace Presentacion.Formularios.Clientes
{
    partial class FormDeudorPlanes
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
            label1 = new Label();
            panel1 = new Panel();
            textBoxLimite = new TextBox();
            textBoxProximo = new TextBox();
            textBoxCredito = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            buttonVolver = new Button();
            buttonAdd = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 21);
            label1.Name = "label1";
            label1.Size = new Size(189, 30);
            label1.TabIndex = 0;
            label1.Text = "Planes disponibles";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxLimite);
            panel1.Controls.Add(textBoxProximo);
            panel1.Controls.Add(textBoxCredito);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(18, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 188);
            panel1.TabIndex = 1;
            // 
            // textBoxLimite
            // 
            textBoxLimite.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLimite.Location = new Point(220, 76);
            textBoxLimite.Name = "textBoxLimite";
            textBoxLimite.ReadOnly = true;
            textBoxLimite.Size = new Size(226, 29);
            textBoxLimite.TabIndex = 1;
            // 
            // textBoxProximo
            // 
            textBoxProximo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProximo.Location = new Point(220, 136);
            textBoxProximo.Name = "textBoxProximo";
            textBoxProximo.ReadOnly = true;
            textBoxProximo.Size = new Size(226, 29);
            textBoxProximo.TabIndex = 1;
            // 
            // textBoxCredito
            // 
            textBoxCredito.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCredito.Location = new Point(220, 16);
            textBoxCredito.Name = "textBoxCredito";
            textBoxCredito.ReadOnly = true;
            textBoxCredito.Size = new Size(226, 29);
            textBoxCredito.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 79);
            label4.Name = "label4";
            label4.Size = new Size(181, 21);
            label4.TabIndex = 0;
            label4.Text = "Fecha limite de compras:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 139);
            label3.Name = "label3";
            label3.Size = new Size(175, 21);
            label3.TabIndex = 0;
            label3.Text = "Fecha de proximo pago:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 19);
            label2.Name = "label2";
            label2.Size = new Size(200, 21);
            label2.TabIndex = 0;
            label2.Text = "Credito maximo disponible:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cliente Platino", "Cliente Oro", "Cliente Diamante", "Cliente Netherita" });
            comboBox1.Location = new Point(238, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 29);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonVolver
            // 
            buttonVolver.FlatStyle = FlatStyle.Flat;
            buttonVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVolver.ForeColor = Color.White;
            buttonVolver.Location = new Point(18, 283);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(83, 38);
            buttonVolver.TabIndex = 3;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += button1_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Enabled = false;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(450, 283);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(93, 38);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Agregar";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // FormDeudorPlanes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(558, 335);
            Controls.Add(buttonAdd);
            Controls.Add(buttonVolver);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormDeudorPlanes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDeudorPlanes";
            Load += FormDeudorPlanes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox textBoxCredito;
        private TextBox textBoxLimite;
        private TextBox textBoxProximo;
        private Label label4;
        private Label label3;
        private ComboBox comboBox1;
        private Button buttonVolver;
        private Button buttonAdd;
    }
}