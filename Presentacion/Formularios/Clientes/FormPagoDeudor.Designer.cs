namespace Presentacion.Formularios.Clientes
{
    partial class FormPagoDeudor
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
            panel1 = new Panel();
            textBoxDisponible = new TextBox();
            textBoxPago = new TextBox();
            textBoxMinimo = new TextBox();
            labelCambio = new Label();
            labelPago = new Label();
            labelSubtotal = new Label();
            buttonRealizar = new Button();
            buttonAtras = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxDisponible);
            panel1.Controls.Add(textBoxPago);
            panel1.Controls.Add(textBoxMinimo);
            panel1.Controls.Add(labelCambio);
            panel1.Controls.Add(labelPago);
            panel1.Controls.Add(labelSubtotal);
            panel1.Location = new Point(23, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 235);
            panel1.TabIndex = 6;
            // 
            // textBoxDisponible
            // 
            textBoxDisponible.BorderStyle = BorderStyle.None;
            textBoxDisponible.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDisponible.ForeColor = Color.White;
            textBoxDisponible.Location = new Point(238, 148);
            textBoxDisponible.Name = "textBoxDisponible";
            textBoxDisponible.ReadOnly = true;
            textBoxDisponible.Size = new Size(268, 29);
            textBoxDisponible.TabIndex = 1;
            // 
            // textBoxPago
            // 
            textBoxPago.BorderStyle = BorderStyle.None;
            textBoxPago.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPago.ForeColor = Color.White;
            textBoxPago.Location = new Point(238, 93);
            textBoxPago.Name = "textBoxPago";
            textBoxPago.Size = new Size(268, 29);
            textBoxPago.TabIndex = 1;
            textBoxPago.TextChanged += textBoxPago_TextChanged;
            // 
            // textBoxMinimo
            // 
            textBoxMinimo.BorderStyle = BorderStyle.None;
            textBoxMinimo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMinimo.ForeColor = Color.White;
            textBoxMinimo.Location = new Point(238, 34);
            textBoxMinimo.Name = "textBoxMinimo";
            textBoxMinimo.ReadOnly = true;
            textBoxMinimo.Size = new Size(268, 29);
            textBoxMinimo.TabIndex = 1;
            // 
            // labelCambio
            // 
            labelCambio.AutoSize = true;
            labelCambio.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelCambio.ForeColor = Color.White;
            labelCambio.Location = new Point(29, 148);
            labelCambio.Name = "labelCambio";
            labelCambio.Size = new Size(203, 30);
            labelCambio.TabIndex = 0;
            labelCambio.Text = "Credito disponible: $";
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
            labelSubtotal.Size = new Size(157, 30);
            labelSubtotal.TabIndex = 0;
            labelSubtotal.Text = "Pago minimo: $";
            // 
            // buttonRealizar
            // 
            buttonRealizar.Enabled = false;
            buttonRealizar.FlatStyle = FlatStyle.Flat;
            buttonRealizar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRealizar.ForeColor = Color.White;
            buttonRealizar.Location = new Point(469, 276);
            buttonRealizar.Name = "buttonRealizar";
            buttonRealizar.Size = new Size(103, 47);
            buttonRealizar.TabIndex = 4;
            buttonRealizar.Text = "Realizar";
            buttonRealizar.UseVisualStyleBackColor = true;
            buttonRealizar.Click += buttonRealizar_Click;
            // 
            // buttonAtras
            // 
            buttonAtras.FlatStyle = FlatStyle.Flat;
            buttonAtras.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAtras.ForeColor = Color.White;
            buttonAtras.Location = new Point(12, 276);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(103, 47);
            buttonAtras.TabIndex = 5;
            buttonAtras.Text = "Atras";
            buttonAtras.UseVisualStyleBackColor = true;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // FormPagoDeudor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(585, 342);
            Controls.Add(panel1);
            Controls.Add(buttonRealizar);
            Controls.Add(buttonAtras);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPagoDeudor";
            Text = "FormPago";
            Load += FormPagoDeudor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxDisponible;
        private TextBox textBoxPago;
        private TextBox textBoxMinimo;
        private Label labelCambio;
        private Label labelPago;
        private Label labelSubtotal;
        private Button buttonRealizar;
        private Button buttonAtras;
    }
}