﻿namespace Presentacion.Formularios.Empleados
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
            buttonAgregar = new Button();
            button2 = new Button();
            buttonVolver = new Button();
            label9 = new Label();
            panel2 = new Panel();
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
            panel1.Controls.Add(buttonAgregar);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(buttonVolver);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10065, 655);
            panel1.TabIndex = 0;
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
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(14, 44);
            label9.Name = "label9";
            label9.Size = new Size(396, 45);
            label9.TabIndex = 10;
            label9.Text = "Informacion del empleado";
            // 
            // panel2
            // 
            panel2.Controls.Add(Cargo);
            panel2.Controls.Add(comboBoxCargo);
            panel2.Controls.Add(textBoxCurp);
            panel2.Controls.Add(textBoxCorreo);
            panel2.Controls.Add(textBoxDireccion);
            panel2.Controls.Add(textBoxNumTel);
            panel2.Controls.Add(textBoxName);
            panel2.Location = new Point(14, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(973, 417);
            panel2.TabIndex = 9;
            // 
            // Cargo
            // 
            Cargo.AutoSize = true;
            Cargo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Cargo.ForeColor = SystemColors.ControlLightLight;
            Cargo.Location = new Point(18, 329);
            Cargo.Name = "Cargo";
            Cargo.Size = new Size(95, 37);
            Cargo.TabIndex = 4;
            Cargo.Text = "Cargo:";
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Location = new Point(22, 369);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(267, 23);
            comboBoxCargo.TabIndex = 3;
            // 
            // textBoxCurp
            // 
            textBoxCurp.BorderStyle = BorderStyle.None;
            textBoxCurp.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCurp.ForeColor = Color.WhiteSmoke;
            textBoxCurp.Location = new Point(22, 271);
            textBoxCurp.Name = "textBoxCurp";
            textBoxCurp.Size = new Size(705, 29);
            textBoxCurp.TabIndex = 2;
            textBoxCurp.Text = "CURP";
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BorderStyle = BorderStyle.None;
            textBoxCorreo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCorreo.ForeColor = Color.WhiteSmoke;
            textBoxCorreo.Location = new Point(22, 151);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(705, 29);
            textBoxCorreo.TabIndex = 1;
            textBoxCorreo.Text = "Correo electronico";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.BorderStyle = BorderStyle.None;
            textBoxDireccion.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDireccion.ForeColor = Color.WhiteSmoke;
            textBoxDireccion.Location = new Point(22, 209);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(705, 29);
            textBoxDireccion.TabIndex = 1;
            textBoxDireccion.Text = "Dirección";
            // 
            // textBoxNumTel
            // 
            textBoxNumTel.BorderStyle = BorderStyle.None;
            textBoxNumTel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumTel.ForeColor = Color.WhiteSmoke;
            textBoxNumTel.Location = new Point(22, 95);
            textBoxNumTel.Name = "textBoxNumTel";
            textBoxNumTel.Size = new Size(705, 29);
            textBoxNumTel.TabIndex = 1;
            textBoxNumTel.Text = "Numero telefonico";
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.ForeColor = Color.WhiteSmoke;
            textBoxName.Location = new Point(22, 35);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(705, 28);
            textBoxName.TabIndex = 1;
            textBoxName.Text = "Nombre";
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
    }
}