namespace Presentacion.Formularios.Clientes
{
    partial class FormDeudorNuevo
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
<<<<<<< Updated upstream
            SuspendLayout();
            // 
=======
            label9 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            comboBoxClientes = new ComboBox();
            panel2 = new Panel();
            textBoxRFC = new TextBox();
            textBoxCorreo = new TextBox();
            textBoxApellidos = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxCURP = new TextBox();
            label10 = new Label();
            textBoxTelefono = new TextBox();
            label7 = new Label();
            label11 = new Label();
            textBoxNombre = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonAtras = new Button();
            buttonSeguir = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(31, 25);
            label9.Name = "label9";
            label9.Size = new Size(213, 32);
            label9.TabIndex = 6;
            label9.Text = "Seleccionar cliente";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBoxClientes);
            panel1.Location = new Point(31, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 95);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 8);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 0;
            label3.Text = "Apellidos";
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClientes.FlatStyle = FlatStyle.Flat;
            comboBoxClientes.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(16, 32);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(412, 38);
            comboBoxClientes.TabIndex = 0;
            comboBoxClientes.SelectedIndexChanged += comboBoxClientes_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxRFC);
            panel2.Controls.Add(textBoxCorreo);
            panel2.Controls.Add(textBoxApellidos);
            panel2.Controls.Add(textBoxDireccion);
            panel2.Controls.Add(textBoxCURP);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBoxTelefono);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBoxNombre);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(31, 196);
            panel2.Name = "panel2";
            panel2.Size = new Size(969, 244);
            panel2.TabIndex = 8;
            // 
            // textBoxRFC
            // 
            textBoxRFC.BorderStyle = BorderStyle.None;
            textBoxRFC.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRFC.ForeColor = Color.White;
            textBoxRFC.Location = new Point(503, 149);
            textBoxRFC.Name = "textBoxRFC";
            textBoxRFC.ReadOnly = true;
            textBoxRFC.Size = new Size(400, 26);
            textBoxRFC.TabIndex = 1;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BorderStyle = BorderStyle.None;
            textBoxCorreo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCorreo.ForeColor = Color.White;
            textBoxCorreo.Location = new Point(503, 96);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.ReadOnly = true;
            textBoxCorreo.Size = new Size(400, 26);
            textBoxCorreo.TabIndex = 1;
            // 
            // textBoxApellidos
            // 
            textBoxApellidos.BorderStyle = BorderStyle.None;
            textBoxApellidos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxApellidos.ForeColor = Color.White;
            textBoxApellidos.Location = new Point(503, 41);
            textBoxApellidos.Name = "textBoxApellidos";
            textBoxApellidos.ReadOnly = true;
            textBoxApellidos.Size = new Size(400, 26);
            textBoxApellidos.TabIndex = 1;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.BorderStyle = BorderStyle.None;
            textBoxDireccion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDireccion.ForeColor = Color.White;
            textBoxDireccion.Location = new Point(14, 202);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.ReadOnly = true;
            textBoxDireccion.Size = new Size(889, 26);
            textBoxDireccion.TabIndex = 1;
            // 
            // textBoxCURP
            // 
            textBoxCURP.BorderStyle = BorderStyle.None;
            textBoxCURP.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCURP.ForeColor = Color.White;
            textBoxCURP.Location = new Point(14, 149);
            textBoxCURP.Name = "textBoxCURP";
            textBoxCURP.ReadOnly = true;
            textBoxCURP.Size = new Size(400, 26);
            textBoxCURP.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(503, 125);
            label10.Name = "label10";
            label10.Size = new Size(38, 21);
            label10.TabIndex = 0;
            label10.Text = "RFC";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.BorderStyle = BorderStyle.None;
            textBoxTelefono.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTelefono.ForeColor = Color.White;
            textBoxTelefono.Location = new Point(14, 96);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.ReadOnly = true;
            textBoxTelefono.Size = new Size(400, 26);
            textBoxTelefono.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(503, 72);
            label7.Name = "label7";
            label7.Size = new Size(58, 21);
            label7.TabIndex = 0;
            label7.Text = "Correo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(14, 178);
            label11.Name = "label11";
            label11.Size = new Size(75, 21);
            label11.TabIndex = 0;
            label11.Text = "Direccion";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.None;
            textBoxNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.ForeColor = Color.White;
            textBoxNombre.Location = new Point(14, 41);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.ReadOnly = true;
            textBoxNombre.Size = new Size(400, 26);
            textBoxNombre.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(14, 125);
            label8.Name = "label8";
            label8.Size = new Size(50, 21);
            label8.TabIndex = 0;
            label8.Text = "CURP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(503, 17);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 0;
            label5.Text = "Apellidos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 72);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 0;
            label6.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 17);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 0;
            label4.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 17);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 161);
            label1.Name = "label1";
            label1.Size = new Size(260, 32);
            label1.TabIndex = 7;
            label1.Text = "Informacion del cliente";
            // 
            // buttonAtras
            // 
            buttonAtras.FlatStyle = FlatStyle.Flat;
            buttonAtras.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAtras.ForeColor = Color.White;
            buttonAtras.Location = new Point(12, 546);
            buttonAtras.Name = "buttonAtras";
            buttonAtras.Size = new Size(101, 58);
            buttonAtras.TabIndex = 9;
            buttonAtras.Text = "Atras";
            buttonAtras.UseVisualStyleBackColor = true;
            buttonAtras.Click += buttonAtras_Click;
            // 
            // buttonSeguir
            // 
            buttonSeguir.FlatStyle = FlatStyle.Flat;
            buttonSeguir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSeguir.ForeColor = Color.White;
            buttonSeguir.Location = new Point(937, 546);
            buttonSeguir.Name = "buttonSeguir";
            buttonSeguir.Size = new Size(100, 58);
            buttonSeguir.TabIndex = 9;
            buttonSeguir.Text = "Escoger plan";
            buttonSeguir.UseVisualStyleBackColor = true;
            buttonSeguir.Click += buttonSeguir_Click;
            // 
>>>>>>> Stashed changes
            // FormDeudorNuevo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 616);
<<<<<<< Updated upstream
            Name = "FormDeudorNuevo";
            Text = "FormDeudorNuevo";
=======
            Controls.Add(buttonSeguir);
            Controls.Add(buttonAtras);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(panel1);
            Name = "FormDeudorNuevo";
            Text = "FormDeudorNuevo";
            Load += FormDeudorNuevo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
>>>>>>> Stashed changes
            ResumeLayout(false);
        }

        #endregion
<<<<<<< Updated upstream
=======

        private Label label9;
        private Panel panel1;
        private Label label3;
        private ComboBox comboBoxClientes;
        private Panel panel2;
        private TextBox textBoxRFC;
        private TextBox textBoxCorreo;
        private TextBox textBoxApellidos;
        private TextBox textBoxDireccion;
        private TextBox textBoxCURP;
        private Label label10;
        private TextBox textBoxTelefono;
        private Label label7;
        private Label label11;
        private TextBox textBoxNombre;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button buttonAtras;
        private Button buttonSeguir;
>>>>>>> Stashed changes
    }
}