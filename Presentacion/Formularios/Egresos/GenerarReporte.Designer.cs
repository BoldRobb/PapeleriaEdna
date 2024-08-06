namespace Presentacion.Formularios.Egresos
{
    partial class GenerarReporte
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
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            monthCalendar1 = new MonthCalendar();
            monthCalendar2 = new MonthCalendar();
            textBox1 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            buttonRealizar = new Button();
            buttonVolver = new Button();
            label1 = new Label();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(632, 108);
            label3.Name = "label3";
            label3.Size = new Size(33, 25);
            label3.TabIndex = 7;
            label3.Text = "Al:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(75, 108);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 6;
            label2.Text = "Del:";
            // 
            // panel1
            // 
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(monthCalendar2);
            panel1.Location = new Point(55, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 218);
            panel1.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.ControlText;
            monthCalendar1.Location = new Point(20, 24);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.TitleBackColor = Color.Yellow;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(577, 24);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 1;
            monthCalendar2.DateChanged += monthCalendar2_DateChanged;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(109, 427);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(405, 29);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(237, 387);
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
            label5.Location = new Point(50, 427);
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
            label4.Location = new Point(50, 387);
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
            buttonRealizar.Location = new Point(450, 554);
            buttonRealizar.Name = "buttonRealizar";
            buttonRealizar.Size = new Size(112, 50);
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
            buttonVolver.Location = new Point(12, 554);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(112, 50);
            buttonVolver.TabIndex = 15;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 33);
            label1.Name = "label1";
            label1.Size = new Size(283, 30);
            label1.TabIndex = 16;
            label1.Text = "Generar reporte de egresos";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.AutoSize = true;
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(838, 554);
            button2.Name = "button2";
            button2.Size = new Size(112, 50);
            button2.TabIndex = 17;
            button2.Text = "Generar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(422, 526);
            label6.Name = "label6";
            label6.Size = new Size(173, 25);
            label6.TabIndex = 18;
            label6.Text = "Reporte pagos fijos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(790, 526);
            label7.Name = "label7";
            label7.Size = new Size(222, 25);
            label7.TabIndex = 19;
            label7.Text = "Reporte pago empleados";
            // 
            // GenerarReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1049, 616);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(buttonRealizar);
            Controls.Add(buttonVolver);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GenerarReporte";
            Text = "GenerarReporte";
            Load += GenerarReporte_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Panel panel1;
        private MonthCalendar monthCalendar1;
        private MonthCalendar monthCalendar2;
        private TextBox textBox1;
        private Button button1;
        private Label label5;
        private Label label4;
        private Button buttonRealizar;
        private Button buttonVolver;
        private Label label1;
        private Button button2;
        private Label label6;
        private Label label7;
    }
}