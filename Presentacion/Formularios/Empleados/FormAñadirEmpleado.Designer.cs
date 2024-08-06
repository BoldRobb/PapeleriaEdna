namespace Presentacion.Formularios.Empleados
{
    partial class FormAñadirEmpleado
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
            label9 = new Label();
            buttonAgregar = new Button();
            button2 = new Button();
            buttonVolver = new Button();
            panel2 = new Panel();
            textBoxRFC = new TextBox();
            comboBoxGenero = new ComboBox();
            label1 = new Label();
            textBoxApellido = new TextBox();
            Cargo = new Label();
            comboBoxCargo = new ComboBox();
            textBoxCurp = new TextBox();
            textBoxCorreo = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxNumTel = new TextBox();
            textBoxName = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(buttonAgregar);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(buttonVolver);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10065, 655);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(14, 9);
            label9.Name = "label9";
            label9.Size = new Size(396, 45);
            label9.TabIndex = 10;
            label9.Text = "Informacion del empleado";
            // 
            // buttonAgregar
            // 
            buttonAgregar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregar.ForeColor = SystemColors.ControlLightLight;
            buttonAgregar.Location = new Point(805, 533);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(182, 71);
            buttonAgregar.TabIndex = 13;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(4941, 292);
            button2.Name = "button2";
            button2.Size = new Size(182, 71);
            button2.TabIndex = 12;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonVolver
            // 
            buttonVolver.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVolver.ForeColor = SystemColors.ControlLightLight;
            buttonVolver.Location = new Point(32, 533);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(182, 71);
            buttonVolver.TabIndex = 11;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxRFC);
            panel2.Controls.Add(comboBoxGenero);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBoxApellido);
            panel2.Controls.Add(Cargo);
            panel2.Controls.Add(comboBoxCargo);
            panel2.Controls.Add(textBoxCurp);
            panel2.Controls.Add(textBoxCorreo);
            panel2.Controls.Add(textBoxDireccion);
            panel2.Controls.Add(textBoxNumTel);
            panel2.Controls.Add(textBoxName);
            panel2.Location = new Point(14, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(973, 461);
            panel2.TabIndex = 9;
            // 
            // textBoxRFC
            // 
            textBoxRFC.BorderStyle = BorderStyle.None;
            textBoxRFC.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRFC.ForeColor = Color.WhiteSmoke;
            textBoxRFC.Location = new Point(18, 345);
            textBoxRFC.Name = "textBoxRFC";
            textBoxRFC.Size = new Size(705, 29);
            textBoxRFC.TabIndex = 8;
            textBoxRFC.Text = "RFC";
            textBoxRFC.Enter += textBoxRFC_Enter;
            textBoxRFC.Leave += textBoxRFC_Leave;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FlatStyle = FlatStyle.Flat;
            comboBoxGenero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxGenero.ForeColor = SystemColors.Window;
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Location = new Point(791, 181);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(156, 29);
            comboBoxGenero.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(816, 141);
            label1.Name = "label1";
            label1.Size = new Size(110, 37);
            label1.TabIndex = 6;
            label1.Text = "Genero:";
            // 
            // textBoxApellido
            // 
            textBoxApellido.BorderStyle = BorderStyle.None;
            textBoxApellido.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxApellido.ForeColor = Color.WhiteSmoke;
            textBoxApellido.Location = new Point(18, 80);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(705, 29);
            textBoxApellido.TabIndex = 5;
            textBoxApellido.Text = "Apellidos";
            textBoxApellido.Enter += textBoxApellido_Enter;
            textBoxApellido.Leave += textBoxApellido_Leave;
            // 
            // Cargo
            // 
            Cargo.AutoSize = true;
            Cargo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Cargo.ForeColor = SystemColors.ControlLightLight;
            Cargo.Location = new Point(18, 389);
            Cargo.Name = "Cargo";
            Cargo.Size = new Size(95, 37);
            Cargo.TabIndex = 4;
            Cargo.Text = "Cargo:";
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.FlatStyle = FlatStyle.Flat;
            comboBoxCargo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCargo.ForeColor = SystemColors.Window;
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Location = new Point(18, 429);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(267, 29);
            comboBoxCargo.TabIndex = 3;
            // 
            // textBoxCurp
            // 
            textBoxCurp.BorderStyle = BorderStyle.None;
            textBoxCurp.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCurp.ForeColor = Color.WhiteSmoke;
            textBoxCurp.Location = new Point(18, 298);
            textBoxCurp.Name = "textBoxCurp";
            textBoxCurp.Size = new Size(705, 29);
            textBoxCurp.TabIndex = 2;
            textBoxCurp.Text = "CURP";
            textBoxCurp.Enter += textBoxCurp_Enter;
            textBoxCurp.Leave += textBoxCurp_Leave;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BorderStyle = BorderStyle.None;
            textBoxCorreo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCorreo.ForeColor = Color.WhiteSmoke;
            textBoxCorreo.Location = new Point(18, 189);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(705, 29);
            textBoxCorreo.TabIndex = 1;
            textBoxCorreo.Text = "Correo";
            textBoxCorreo.Enter += textBoxCorreo_Enter;
            textBoxCorreo.Leave += textBoxCorreo_Leave;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.BorderStyle = BorderStyle.None;
            textBoxDireccion.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDireccion.ForeColor = Color.WhiteSmoke;
            textBoxDireccion.Location = new Point(18, 243);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(705, 29);
            textBoxDireccion.TabIndex = 1;
            textBoxDireccion.Text = "Dirección";
            textBoxDireccion.Enter += textBoxDireccion_Enter;
            textBoxDireccion.Leave += textBoxDireccion_Leave;
            // 
            // textBoxNumTel
            // 
            textBoxNumTel.BorderStyle = BorderStyle.None;
            textBoxNumTel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumTel.ForeColor = Color.WhiteSmoke;
            textBoxNumTel.Location = new Point(18, 137);
            textBoxNumTel.Name = "textBoxNumTel";
            textBoxNumTel.Size = new Size(705, 29);
            textBoxNumTel.TabIndex = 1;
            textBoxNumTel.Text = "Telefono";
            textBoxNumTel.Enter += textBoxNumTel_Enter;
            textBoxNumTel.Leave += textBoxNumTel_Leave;
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.ForeColor = Color.WhiteSmoke;
            textBoxName.Location = new Point(18, 31);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(705, 28);
            textBoxName.TabIndex = 1;
            textBoxName.Text = "Nombre";
            textBoxName.Enter += textBoxName_Enter;
            textBoxName.Leave += textBoxName_Leave;
            // 
            // FormAñadirEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 616);
            Controls.Add(panel1);
            Name = "FormAñadirEmpleado";
            Text = "FormAñadirEmpleado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Panel panel2;
        private TextBox textBoxCurp;
        private TextBox textBoxCorreo;
        private TextBox textBoxDireccion;
        private TextBox textBoxNumTel;
        private TextBox textBoxName;
        private Label Cargo;
        private ComboBox comboBoxCargo;
        private Button buttonVolver;
        private Button buttonAgregar;
        private Button button2;
        private ComboBox comboBoxGenero;
        private Label label1;
        private TextBox textBoxApellido;
        private TextBox textBoxRFC;
    }
}