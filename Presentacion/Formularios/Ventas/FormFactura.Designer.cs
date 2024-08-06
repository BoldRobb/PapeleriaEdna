namespace Presentacion.Formularios.Ventas
{
    partial class FormFactura
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
            folderBrowserDialog1 = new FolderBrowserDialog();
            textBox1 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            buttonRealizar = new Button();
            buttonVolver = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(90, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(405, 29);
            textBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(217, 30);
            button1.Name = "button1";
            button1.Size = new Size(101, 29);
            button1.TabIndex = 12;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 70);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 10;
            label5.Text = "Ruta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 30);
            label4.Name = "label4";
            label4.Size = new Size(181, 25);
            label4.TabIndex = 11;
            label4.Text = "Seleccionar carpeta:";
            // 
            // buttonRealizar
            // 
            buttonRealizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRealizar.AutoSize = true;
            buttonRealizar.Enabled = false;
            buttonRealizar.FlatStyle = FlatStyle.Flat;
            buttonRealizar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRealizar.ForeColor = Color.White;
            buttonRealizar.Location = new Point(453, 133);
            buttonRealizar.Name = "buttonRealizar";
            buttonRealizar.Size = new Size(103, 50);
            buttonRealizar.TabIndex = 14;
            buttonRealizar.Text = "Generar";
            buttonRealizar.UseVisualStyleBackColor = true;
            buttonRealizar.Click += buttonRealizar_Click;
            // 
            // buttonVolver
            // 
            buttonVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonVolver.AutoSize = true;
            buttonVolver.FlatStyle = FlatStyle.Flat;
            buttonVolver.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVolver.ForeColor = Color.White;
            buttonVolver.Location = new Point(-493, 115);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(103, 50);
            buttonVolver.TabIndex = 15;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.AutoSize = true;
            buttonBack.Enabled = false;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(12, 133);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(103, 50);
            buttonBack.TabIndex = 14;
            buttonBack.Text = "Volver";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // FormFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(568, 195);
            Controls.Add(buttonBack);
            Controls.Add(buttonRealizar);
            Controls.Add(buttonVolver);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFactura";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormFactura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBox1;
        private Button button1;
        private Label label5;
        private Label label4;
        private Button buttonRealizar;
        private Button buttonVolver;
        private Button buttonBack;
    }
}