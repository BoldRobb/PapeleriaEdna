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
            buttonActualizar = new Button();
            buttonVolver = new Button();
            Cargo = new Label();
            comboBoxCargo = new ComboBox();
            label2 = new Label();
            textBoxCurp = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            comboBoxEmpleados = new ComboBox();
            textBoxCorreo = new TextBox();
            textBoxName = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxNumTel = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonActualizar);
            panel1.Controls.Add(buttonVolver);
            panel1.Controls.Add(Cargo);
            panel1.Controls.Add(comboBoxCargo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxCurp);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBoxCorreo);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(textBoxDireccion);
            panel1.Controls.Add(textBoxNumTel);
            panel1.Location = new Point(-8, -19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 655);
            panel1.TabIndex = 3;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonActualizar.ForeColor = SystemColors.ControlLightLight;
            buttonActualizar.Location = new Point(817, 279);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(192, 92);
            buttonActualizar.TabIndex = 18;
            buttonActualizar.Text = "Volver";
            buttonActualizar.UseVisualStyleBackColor = true;
            // 
            // buttonVolver
            // 
            buttonVolver.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVolver.ForeColor = SystemColors.ControlLightLight;
            buttonVolver.Location = new Point(872, 565);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(179, 63);
            buttonVolver.TabIndex = 17;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            // 
            // Cargo
            // 
            Cargo.AutoSize = true;
            Cargo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Cargo.ForeColor = SystemColors.ControlLightLight;
            Cargo.Location = new Point(26, 501);
            Cargo.Name = "Cargo";
            Cargo.Size = new Size(95, 37);
            Cargo.TabIndex = 11;
            Cargo.Text = "Cargo:";
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Location = new Point(30, 541);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(267, 23);
            comboBoxCargo.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 33);
            label2.Name = "label2";
            label2.Size = new Size(333, 45);
            label2.TabIndex = 15;
            label2.Text = "Seleccionar empleado";
            // 
            // textBoxCurp
            // 
            textBoxCurp.BorderStyle = BorderStyle.None;
            textBoxCurp.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCurp.ForeColor = Color.WhiteSmoke;
            textBoxCurp.Location = new Point(30, 443);
            textBoxCurp.Name = "textBoxCurp";
            textBoxCurp.Size = new Size(705, 29);
            textBoxCurp.TabIndex = 9;
            textBoxCurp.Text = "CURP";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBoxEmpleados);
            panel2.Location = new Point(26, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(970, 106);
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
            comboBoxEmpleados.FormattingEnabled = true;
            comboBoxEmpleados.Location = new Point(16, 32);
            comboBoxEmpleados.Name = "comboBoxEmpleados";
            comboBoxEmpleados.Size = new Size(412, 38);
            comboBoxEmpleados.TabIndex = 0;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BorderStyle = BorderStyle.None;
            textBoxCorreo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCorreo.ForeColor = Color.WhiteSmoke;
            textBoxCorreo.Location = new Point(30, 323);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(705, 29);
            textBoxCorreo.TabIndex = 5;
            textBoxCorreo.Text = "Correo electronico";
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.ForeColor = Color.WhiteSmoke;
            textBoxName.Location = new Point(30, 207);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(705, 28);
            textBoxName.TabIndex = 8;
            textBoxName.Text = "Nombre";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.BorderStyle = BorderStyle.None;
            textBoxDireccion.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDireccion.ForeColor = Color.WhiteSmoke;
            textBoxDireccion.Location = new Point(30, 381);
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
            textBoxNumTel.Location = new Point(30, 267);
            textBoxNumTel.Name = "textBoxNumTel";
            textBoxNumTel.Size = new Size(705, 29);
            textBoxNumTel.TabIndex = 7;
            textBoxNumTel.Text = "Numero telefonico";
            // 
            // FormModificarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 616);
            Controls.Add(panel1);
            Name = "FormModificarEmpleado";
            Text = "FormModificarEmpleado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonActualizar;
        private Button buttonVolver;
        private Label Cargo;
        private ComboBox comboBoxCargo;
        private Label label2;
        private TextBox textBoxCurp;
        private Panel panel2;
        private Label label3;
        private ComboBox comboBoxEmpleados;
        private TextBox textBoxCorreo;
        private TextBox textBoxName;
        private TextBox textBoxDireccion;
        private TextBox textBoxNumTel;
    }
}