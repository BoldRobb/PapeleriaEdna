namespace Presentacion.Formularios.Ventas
{
    partial class FormVentaPago
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
            buttonRealizar = new Button();
            buttonAtras = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            textBoxCambio = new TextBox();
            textBoxPago = new TextBox();
            textBoxSubtotal = new TextBox();
            label1 = new Label();
            labelCambio = new Label();
            labelPago = new Label();
            labelSubtotal = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonRealizar
            // 
            buttonRealizar.Enabled = false;
            buttonRealizar.FlatStyle = FlatStyle.Flat;
            buttonRealizar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRealizar.ForeColor = Color.White;
            buttonRealizar.Location = new Point(470, 363);
            buttonRealizar.Name = "buttonRealizar";
            buttonRealizar.Size = new Size(103, 47);
            buttonRealizar.TabIndex = 1;
            buttonRealizar.Text = "Realizar";
            buttonRealizar.UseVisualStyleBackColor = true;
            buttonRealizar.Click += buttonRealizar_Click;
            // 
            // buttonAtras
            // 
            buttonAtras.FlatStyle = FlatStyle.Flat;
            buttonAtras.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAtras.ForeColor = Color.White;
            buttonAtras.Location = new Point(12, 363);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(103, 47);
            buttonAtras.TabIndex = 2;
            buttonAtras.Text = "Atras";
            buttonAtras.UseVisualStyleBackColor = true;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBoxCambio);
            panel1.Controls.Add(textBoxPago);
            panel1.Controls.Add(textBoxSubtotal);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelCambio);
            panel1.Controls.Add(labelPago);
            panel1.Controls.Add(labelSubtotal);
            panel1.Location = new Point(24, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 312);
            panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(165, 201);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 97);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBoxCambio
            // 
            textBoxCambio.BorderStyle = BorderStyle.None;
            textBoxCambio.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCambio.ForeColor = Color.White;
            textBoxCambio.Location = new Point(165, 149);
            textBoxCambio.Name = "textBoxCambio";
            textBoxCambio.ReadOnly = true;
            textBoxCambio.Size = new Size(250, 29);
            textBoxCambio.TabIndex = 1;
            // 
            // textBoxPago
            // 
            textBoxPago.BorderStyle = BorderStyle.None;
            textBoxPago.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPago.ForeColor = Color.White;
            textBoxPago.Location = new Point(165, 93);
            textBoxPago.Name = "textBoxPago";
            textBoxPago.Size = new Size(250, 29);
            textBoxPago.TabIndex = 1;
            textBoxPago.TextChanged += textBoxPago_TextChanged;
            // 
            // textBoxSubtotal
            // 
            textBoxSubtotal.BorderStyle = BorderStyle.None;
            textBoxSubtotal.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSubtotal.ForeColor = Color.White;
            textBoxSubtotal.Location = new Point(165, 34);
            textBoxSubtotal.Name = "textBoxSubtotal";
            textBoxSubtotal.ReadOnly = true;
            textBoxSubtotal.Size = new Size(250, 29);
            textBoxSubtotal.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 200);
            label1.Name = "label1";
            label1.Size = new Size(130, 30);
            label1.TabIndex = 0;
            label1.Text = "Comentarios";
            // 
            // labelCambio
            // 
            labelCambio.AutoSize = true;
            labelCambio.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelCambio.ForeColor = Color.White;
            labelCambio.Location = new Point(29, 148);
            labelCambio.Name = "labelCambio";
            labelCambio.Size = new Size(106, 30);
            labelCambio.TabIndex = 0;
            labelCambio.Text = "Cambio: $";
            // 
            // labelPago
            // 
            labelPago.AutoSize = true;
            labelPago.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPago.ForeColor = Color.White;
            labelPago.Location = new Point(29, 92);
            labelPago.Name = "labelPago";
            labelPago.Size = new Size(81, 30);
            labelPago.TabIndex = 0;
            labelPago.Text = "Pago: $";
            // 
            // labelSubtotal
            // 
            labelSubtotal.AutoSize = true;
            labelSubtotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelSubtotal.ForeColor = Color.White;
            labelSubtotal.Location = new Point(29, 33);
            labelSubtotal.Name = "labelSubtotal";
            labelSubtotal.Size = new Size(112, 30);
            labelSubtotal.TabIndex = 0;
            labelSubtotal.Text = "Subtotal: $";
            // 
            // FormVentaPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(585, 422);
            Controls.Add(panel1);
            Controls.Add(buttonRealizar);
            Controls.Add(buttonAtras);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVentaPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVentaPago";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRealizar;
        private Button buttonAtras;
        private Panel panel1;
        private Label labelSubtotal;
        private TextBox textBoxCambio;
        private TextBox textBoxPago;
        private TextBox textBoxSubtotal;
        private Label labelCambio;
        private Label labelPago;
        private TextBox textBox1;
        private Label label1;
    }
}