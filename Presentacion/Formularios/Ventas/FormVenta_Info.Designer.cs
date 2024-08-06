namespace Presentacion.Formularios.Ventas
{
    partial class FormVenta_Info
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
            buttonAtras = new Button();
            buttonRealizar = new Button();
            panel1 = new Panel();
            radioButtonCredito = new RadioButton();
            radioButtonContado = new RadioButton();
            comboBoxClientes = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAtras
            // 
            buttonAtras.FlatStyle = FlatStyle.Flat;
            buttonAtras.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAtras.ForeColor = Color.White;
            buttonAtras.Location = new Point(34, 160);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(103, 47);
            buttonAtras.TabIndex = 0;
            buttonAtras.Text = "Atras";
            buttonAtras.UseVisualStyleBackColor = true;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // buttonRealizar
            // 
            buttonRealizar.Enabled = false;
            buttonRealizar.FlatStyle = FlatStyle.Flat;
            buttonRealizar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRealizar.ForeColor = Color.White;
            buttonRealizar.Location = new Point(606, 160);
            buttonRealizar.Name = "buttonRealizar";
            buttonRealizar.Size = new Size(103, 47);
            buttonRealizar.TabIndex = 0;
            buttonRealizar.Text = "Realizar";
            buttonRealizar.UseVisualStyleBackColor = true;
            buttonRealizar.Click += buttonRealizar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButtonCredito);
            panel1.Controls.Add(radioButtonContado);
            panel1.Controls.Add(comboBoxClientes);
            panel1.Location = new Point(12, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 84);
            panel1.TabIndex = 1;
            // 
            // radioButtonCredito
            // 
            radioButtonCredito.AutoSize = true;
            radioButtonCredito.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonCredito.ForeColor = Color.White;
            radioButtonCredito.Location = new Point(516, 41);
            radioButtonCredito.Name = "radioButtonCredito";
            radioButtonCredito.Size = new Size(131, 25);
            radioButtonCredito.TabIndex = 1;
            radioButtonCredito.TabStop = true;
            radioButtonCredito.Text = "Venta a credito";
            radioButtonCredito.UseVisualStyleBackColor = true;
            radioButtonCredito.CheckedChanged += radioButtonCredito_CheckedChanged;
            // 
            // radioButtonContado
            // 
            radioButtonContado.AutoSize = true;
            radioButtonContado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonContado.ForeColor = Color.White;
            radioButtonContado.Location = new Point(516, 10);
            radioButtonContado.Name = "radioButtonContado";
            radioButtonContado.Size = new Size(139, 25);
            radioButtonContado.TabIndex = 1;
            radioButtonContado.TabStop = true;
            radioButtonContado.Text = "Venta a contado";
            radioButtonContado.UseVisualStyleBackColor = true;
            radioButtonContado.CheckedChanged += radioButtonContado_CheckedChanged;
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClientes.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(22, 22);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(443, 38);
            comboBoxClientes.TabIndex = 0;
            comboBoxClientes.SelectedIndexChanged += comboBoxClientes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(213, 32);
            label1.TabIndex = 2;
            label1.Text = "Seleccionar cliente";
            // 
            // FormVenta_Info
            // 
            AcceptButton = buttonRealizar;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonAtras;
            ClientSize = new Size(742, 230);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(buttonRealizar);
            Controls.Add(buttonAtras);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "FormVenta_Info";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVenta_Info";
            TopMost = true;
            Load += FormVenta_Info_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAtras;
        private Button buttonRealizar;
        private Panel panel1;
        private Label label1;
        public ComboBox comboBoxClientes;
        public RadioButton radioButtonCredito;
        public RadioButton radioButtonContado;
    }
}