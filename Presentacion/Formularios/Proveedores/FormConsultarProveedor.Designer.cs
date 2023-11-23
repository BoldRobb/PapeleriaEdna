namespace Presentacion.Formularios.Proveedores
{
    partial class FormConsultarProveedor
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
            panel2 = new Panel();
            label3 = new Label();
            comboBoxProveedores = new ComboBox();
            textBoxNumTel = new TextBox();
            textBoxNombre = new TextBox();
            panel3 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            textBoxCorreo = new TextBox();
            textBoxDireccion = new TextBox();
            buttonVolver = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBoxProveedores);
            panel2.Location = new Point(25, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(973, 106);
            panel2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 8);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 0;
            label3.Text = "Nombre";
            // 
            // comboBoxProveedores
            // 
            comboBoxProveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProveedores.FlatStyle = FlatStyle.Flat;
            comboBoxProveedores.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxProveedores.ForeColor = Color.White;
            comboBoxProveedores.FormattingEnabled = true;
            comboBoxProveedores.Location = new Point(16, 32);
            comboBoxProveedores.Name = "comboBoxProveedores";
            comboBoxProveedores.Size = new Size(412, 38);
            comboBoxProveedores.TabIndex = 0;
            comboBoxProveedores.SelectedIndexChanged += comboBoxProveedores_SelectedIndexChanged;
            // 
            // textBoxNumTel
            // 
            textBoxNumTel.BorderStyle = BorderStyle.None;
            textBoxNumTel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumTel.ForeColor = Color.WhiteSmoke;
            textBoxNumTel.Location = new Point(16, 152);
            textBoxNumTel.Name = "textBoxNumTel";
            textBoxNumTel.Size = new Size(705, 29);
            textBoxNumTel.TabIndex = 1;
            textBoxNumTel.Text = "Telefono";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.None;
            textBoxNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.ForeColor = Color.WhiteSmoke;
            textBoxNombre.Location = new Point(16, 84);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(705, 28);
            textBoxNombre.TabIndex = 1;
            textBoxNombre.Text = "Nombre";
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBoxCorreo);
            panel3.Controls.Add(textBoxDireccion);
            panel3.Controls.Add(textBoxNumTel);
            panel3.Controls.Add(textBoxNombre);
            panel3.Location = new Point(25, 179);
            panel3.Name = "panel3";
            panel3.Size = new Size(973, 345);
            panel3.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(16, 277);
            label7.Name = "label7";
            label7.Size = new Size(75, 21);
            label7.TabIndex = 15;
            label7.Text = "Dirección";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(16, 207);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 14;
            label6.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 128);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 13;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(16, 60);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 12;
            label4.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(232, 32);
            label1.TabIndex = 11;
            label1.Text = "Datos del proveedor";
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BorderStyle = BorderStyle.None;
            textBoxCorreo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCorreo.ForeColor = Color.WhiteSmoke;
            textBoxCorreo.Location = new Point(16, 231);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(705, 29);
            textBoxCorreo.TabIndex = 1;
            textBoxCorreo.Text = "Correo";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.BorderStyle = BorderStyle.None;
            textBoxDireccion.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDireccion.ForeColor = Color.WhiteSmoke;
            textBoxDireccion.Location = new Point(16, 301);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(705, 29);
            textBoxDireccion.TabIndex = 1;
            textBoxDireccion.Text = "Dirección";
            // 
            // buttonVolver
            // 
            buttonVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonVolver.AutoSize = true;
            buttonVolver.FlatStyle = FlatStyle.Flat;
            buttonVolver.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVolver.ForeColor = Color.White;
            buttonVolver.Location = new Point(12, 542);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(137, 74);
            buttonVolver.TabIndex = 11;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonVolver);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 655);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 19);
            label2.Name = "label2";
            label2.Size = new Size(336, 45);
            label2.TabIndex = 13;
            label2.Text = "Seleccionar Proveedor";
            // 
            // FormConsultarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 616);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormConsultarProveedor";
            Text = "FormConsultarProveedor";
            Load += FormConsultarProveedor_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label3;
        private ComboBox comboBoxProveedores;
        private TextBox textBoxNumTel;
        private TextBox textBoxNombre;
        private Panel panel3;
        private Label label1;
        private TextBox textBoxCorreo;
        private TextBox textBoxDireccion;
        private Button buttonVolver;
        private Panel panel1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}