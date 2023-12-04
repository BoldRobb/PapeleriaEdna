namespace Presentacion.Formularios.Empleados
{
    partial class FormModificarEmpleado
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
            comboBoxGenero = new ComboBox();
            label1 = new Label();
            buttonActualizar = new Button();
            buttonVolver = new Button();
            textBoxApellido = new TextBox();
            Cargo = new Label();
            comboBoxCargo = new ComboBox();
            label2 = new Label();
            textBoxCURP = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            comboBoxEmpleados = new ComboBox();
            textBoxCorreo = new TextBox();
            textBoxNombre = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxNumTel = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBoxGenero);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonActualizar);
            panel1.Controls.Add(buttonVolver);
            panel1.Controls.Add(textBoxApellido);
            panel1.Controls.Add(Cargo);
            panel1.Controls.Add(comboBoxCargo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxCURP);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBoxCorreo);
            panel1.Controls.Add(textBoxNombre);
            panel1.Controls.Add(textBoxDireccion);
            panel1.Controls.Add(textBoxNumTel);
            panel1.Location = new Point(-8, -19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 673);
            panel1.TabIndex = 3;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FlatStyle = FlatStyle.Flat;
            comboBoxGenero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxGenero.ForeColor = SystemColors.Window;
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Location = new Point(384, 544);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(180, 29);
            comboBoxGenero.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(384, 504);
            label1.Name = "label1";
            label1.Size = new Size(110, 37);
            label1.TabIndex = 22;
            label1.Text = "Genero:";
            // 
            // buttonActualizar
            // 
            buttonActualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonActualizar.AutoSize = true;
            buttonActualizar.FlatStyle = FlatStyle.Flat;
            buttonActualizar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonActualizar.ForeColor = Color.White;
            buttonActualizar.Location = new Point(932, 591);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(113, 50);
            buttonActualizar.TabIndex = 20;
            buttonActualizar.Text = "Modificar";
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // buttonVolver
            // 
            buttonVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonVolver.AutoSize = true;
            buttonVolver.FlatStyle = FlatStyle.Flat;
            buttonVolver.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVolver.ForeColor = Color.White;
            buttonVolver.Location = new Point(30, 591);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(112, 50);
            buttonVolver.TabIndex = 21;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // textBoxApellido
            // 
            textBoxApellido.BorderStyle = BorderStyle.None;
            textBoxApellido.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxApellido.ForeColor = Color.WhiteSmoke;
            textBoxApellido.Location = new Point(30, 235);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(705, 29);
            textBoxApellido.TabIndex = 19;
            textBoxApellido.Text = "Apellidos";
            // 
            // Cargo
            // 
            Cargo.AutoSize = true;
            Cargo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Cargo.ForeColor = SystemColors.ControlLightLight;
            Cargo.Location = new Point(26, 504);
            Cargo.Name = "Cargo";
            Cargo.Size = new Size(95, 37);
            Cargo.TabIndex = 11;
            Cargo.Text = "Cargo:";
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.DropDownWidth = 180;
            comboBoxCargo.FlatStyle = FlatStyle.Flat;
            comboBoxCargo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCargo.ForeColor = SystemColors.Window;
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Location = new Point(26, 544);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(267, 29);
            comboBoxCargo.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 19);
            label2.Name = "label2";
            label2.Size = new Size(333, 45);
            label2.TabIndex = 15;
            label2.Text = "Seleccionar empleado";
            // 
            // textBoxCURP
            // 
            textBoxCURP.BorderStyle = BorderStyle.None;
            textBoxCURP.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCURP.ForeColor = Color.WhiteSmoke;
            textBoxCURP.Location = new Point(30, 460);
            textBoxCURP.Name = "textBoxCURP";
            textBoxCURP.Size = new Size(705, 29);
            textBoxCURP.TabIndex = 9;
            textBoxCURP.Text = "CURP";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBoxEmpleados);
            panel2.Location = new Point(26, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(886, 85);
            panel2.TabIndex = 14;
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
            // comboBoxEmpleados
            // 
            comboBoxEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmpleados.FlatStyle = FlatStyle.Flat;
            comboBoxEmpleados.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxEmpleados.ForeColor = SystemColors.Window;
            comboBoxEmpleados.FormattingEnabled = true;
            comboBoxEmpleados.Location = new Point(16, 32);
            comboBoxEmpleados.Name = "comboBoxEmpleados";
            comboBoxEmpleados.Size = new Size(412, 38);
            comboBoxEmpleados.TabIndex = 0;
            comboBoxEmpleados.SelectedIndexChanged += comboBoxEmpleados_SelectedIndexChanged;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BorderStyle = BorderStyle.None;
            textBoxCorreo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCorreo.ForeColor = Color.WhiteSmoke;
            textBoxCorreo.Location = new Point(30, 347);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(705, 29);
            textBoxCorreo.TabIndex = 5;
            textBoxCorreo.Text = "Correo";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.None;
            textBoxNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.ForeColor = Color.WhiteSmoke;
            textBoxNombre.Location = new Point(30, 181);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(705, 28);
            textBoxNombre.TabIndex = 8;
            textBoxNombre.Text = "Nombre";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.BorderStyle = BorderStyle.None;
            textBoxDireccion.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDireccion.ForeColor = Color.WhiteSmoke;
            textBoxDireccion.Location = new Point(30, 402);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(705, 29);
            textBoxDireccion.TabIndex = 6;
            textBoxDireccion.Text = "Dirección";
            // 
            // textBoxNumTel
            // 
            textBoxNumTel.BorderStyle = BorderStyle.None;
            textBoxNumTel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumTel.ForeColor = Color.WhiteSmoke;
            textBoxNumTel.Location = new Point(30, 291);
            textBoxNumTel.Name = "textBoxNumTel";
            textBoxNumTel.Size = new Size(705, 29);
            textBoxNumTel.TabIndex = 7;
            textBoxNumTel.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 157);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 24;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 212);
            label5.Name = "label5";
            label5.Size = new Size(67, 21);
            label5.TabIndex = 25;
            label5.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(30, 267);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 26;
            label6.Text = "Telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(30, 323);
            label7.Name = "label7";
            label7.Size = new Size(58, 21);
            label7.TabIndex = 27;
            label7.Text = "Correo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(30, 379);
            label8.Name = "label8";
            label8.Size = new Size(75, 21);
            label8.TabIndex = 28;
            label8.Text = "Dirección";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(30, 436);
            label9.Name = "label9";
            label9.Size = new Size(50, 21);
            label9.TabIndex = 29;
            label9.Text = "CURP";
            // 
            // FormModificarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 616);
            Controls.Add(panel1);
            Name = "FormModificarEmpleado";
            Text = "FormModificarEmpleado";
            Load += FormModificarEmpleado_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Cargo;
        private ComboBox comboBoxCargo;
        private Label label2;
        private TextBox textBoxCURP;
        private Panel panel2;
        private Label label3;
        private ComboBox comboBoxEmpleados;
        private TextBox textBoxCorreo;
        private TextBox textBoxNombre;
        private TextBox textBoxDireccion;
        private TextBox textBoxNumTel;
        private TextBox textBoxApellido;
        private Button buttonActualizar;
        private Button buttonVolver;
        private ComboBox comboBoxGenero;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}