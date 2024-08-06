namespace Presentacion.Formularios.Ventas
{
    partial class FormReporte
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
            monthCalendar1 = new MonthCalendar();
            monthCalendar2 = new MonthCalendar();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            buttonVolver = new Button();
            buttonRealizar = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.ControlText;
            monthCalendar1.Location = new Point(9, 9);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.TitleBackColor = Color.Yellow;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(575, 9);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 1;
            monthCalendar2.DateChanged += monthCalendar2_DateChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 71);
            label1.Name = "label1";
            label1.Size = new Size(189, 30);
            label1.TabIndex = 2;
            label1.Text = "Reporte de ventas";
            // 
            // panel1
            // 
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(monthCalendar2);
            panel1.Location = new Point(60, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 188);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(69, 117);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 4;
            label2.Text = "Del:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(635, 117);
            label3.Name = "label3";
            label3.Size = new Size(33, 25);
            label3.TabIndex = 4;
            label3.Text = "Al:";
            // 
            // buttonVolver
            // 
            buttonVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonVolver.AutoSize = true;
            buttonVolver.FlatStyle = FlatStyle.Flat;
            buttonVolver.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVolver.ForeColor = Color.White;
            buttonVolver.Location = new Point(12, 593);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(112, 50);
            buttonVolver.TabIndex = 6;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // buttonRealizar
            // 
            buttonRealizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRealizar.AutoSize = true;
            buttonRealizar.Enabled = false;
            buttonRealizar.FlatStyle = FlatStyle.Flat;
            buttonRealizar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRealizar.ForeColor = Color.White;
            buttonRealizar.Location = new Point(941, 593);
            buttonRealizar.Name = "buttonRealizar";
            buttonRealizar.Size = new Size(112, 50);
            buttonRealizar.TabIndex = 6;
            buttonRealizar.Text = "Generar";
            buttonRealizar.UseVisualStyleBackColor = true;
            buttonRealizar.Click += buttonRealizar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(69, 380);
            label4.Name = "label4";
            label4.Size = new Size(181, 25);
            label4.TabIndex = 7;
            label4.Text = "Seleccionar carpeta:";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(256, 380);
            button1.Name = "button1";
            button1.Size = new Size(101, 29);
            button1.TabIndex = 8;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(69, 420);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 7;
            label5.Text = "Ruta:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(129, 420);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(405, 29);
            textBox1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 519);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 10;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(624, 507);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 11;
            label7.Text = "label7";
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1065, 655);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(buttonRealizar);
            Controls.Add(buttonVolver);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReporte";
            Text = "FormReporte";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private MonthCalendar monthCalendar2;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Button buttonVolver;
        private Button buttonRealizar;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label4;
        private Button button1;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private Label label7;
    }
}