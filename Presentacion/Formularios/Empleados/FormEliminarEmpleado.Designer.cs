namespace Presentacion.Formularios.Empleados
{
    partial class FormEliminarEmpleado
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
            panel3 = new Panel();
            label3 = new Label();
            comboBoxEmpleados = new ComboBox();
            panel2 = new Panel();
            textBoxCargo = new TextBox();
            label11 = new Label();
            textBoxApellido = new TextBox();
            label9 = new Label();
            textBoxCURP = new TextBox();
            label6 = new Label();
            textBoxNumTel = new TextBox();
            label5 = new Label();
            textBoxDireccion = new TextBox();
            textBoxCorreo = new TextBox();
            label10 = new Label();
            label7 = new Label();
            textBoxNombre = new TextBox();
            label4 = new Label();
            label2 = new Label();
            buttonEliminar = new Button();
            buttonVolver = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label8 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(comboBoxEmpleados);
            panel3.Location = new Point(16, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(970, 106);
            panel3.TabIndex = 13;
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
            // panel2
            // 
            panel2.Controls.Add(textBoxCargo);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBoxApellido);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBoxCURP);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBoxNumTel);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBoxDireccion);
            panel2.Controls.Add(textBoxCorreo);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBoxNombre);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(16, 188);
            panel2.Name = "panel2";
            panel2.Size = new Size(969, 386);
            panel2.TabIndex = 14;
            // 
            // textBoxCargo
            // 
            textBoxCargo.BorderStyle = BorderStyle.None;
            textBoxCargo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCargo.ForeColor = Color.White;
            textBoxCargo.Location = new Point(462, 112);
            textBoxCargo.Name = "textBoxCargo";
            textBoxCargo.ReadOnly = true;
            textBoxCargo.Size = new Size(400, 26);
            textBoxCargo.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(462, 88);
            label11.Name = "label11";
            label11.Size = new Size(52, 21);
            label11.TabIndex = 8;
            label11.Text = "Cargo";
            // 
            // textBoxApellido
            // 
            textBoxApellido.BorderStyle = BorderStyle.None;
            textBoxApellido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxApellido.ForeColor = Color.White;
            textBoxApellido.Location = new Point(462, 41);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.ReadOnly = true;
            textBoxApellido.Size = new Size(400, 26);
            textBoxApellido.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(462, 17);
            label9.Name = "label9";
            label9.Size = new Size(67, 21);
            label9.TabIndex = 6;
            label9.Text = "Apellido";
            // 
            // textBoxCURP
            // 
            textBoxCURP.BorderStyle = BorderStyle.None;
            textBoxCURP.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCURP.ForeColor = Color.White;
            textBoxCURP.Location = new Point(8, 352);
            textBoxCURP.Name = "textBoxCURP";
            textBoxCURP.ReadOnly = true;
            textBoxCURP.Size = new Size(400, 26);
            textBoxCURP.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(8, 316);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 4;
            label6.Text = "CURP";
            // 
            // textBoxNumTel
            // 
            textBoxNumTel.BorderStyle = BorderStyle.None;
            textBoxNumTel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumTel.ForeColor = Color.White;
            textBoxNumTel.Location = new Point(8, 128);
            textBoxNumTel.Name = "textBoxNumTel";
            textBoxNumTel.ReadOnly = true;
            textBoxNumTel.Size = new Size(400, 26);
            textBoxNumTel.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(8, 88);
            label5.Name = "label5";
            label5.Size = new Size(129, 21);
            label5.TabIndex = 2;
            label5.Text = "Numero telefono";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.BorderStyle = BorderStyle.None;
            textBoxDireccion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDireccion.ForeColor = Color.White;
            textBoxDireccion.Location = new Point(8, 287);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.ReadOnly = true;
            textBoxDireccion.Size = new Size(400, 26);
            textBoxDireccion.TabIndex = 1;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BorderStyle = BorderStyle.None;
            textBoxCorreo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCorreo.ForeColor = Color.White;
            textBoxCorreo.Location = new Point(8, 206);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.ReadOnly = true;
            textBoxCorreo.Size = new Size(400, 26);
            textBoxCorreo.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(8, 251);
            label10.Name = "label10";
            label10.Size = new Size(75, 21);
            label10.TabIndex = 0;
            label10.Text = "Direccion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(8, 166);
            label7.Name = "label7";
            label7.Size = new Size(58, 21);
            label7.TabIndex = 0;
            label7.Text = "Correo";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.None;
            textBoxNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.ForeColor = Color.White;
            textBoxNombre.Location = new Point(8, 41);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.ReadOnly = true;
            textBoxNombre.Size = new Size(400, 26);
            textBoxNombre.TabIndex = 1;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
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
            // buttonEliminar
            // 
            buttonEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEliminar.AutoSize = true;
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEliminar.ForeColor = Color.White;
            buttonEliminar.Location = new Point(897, 580);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(101, 42);
            buttonEliminar.TabIndex = 13;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonVolver
            // 
            buttonVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonVolver.AutoSize = true;
            buttonVolver.FlatStyle = FlatStyle.Flat;
            buttonVolver.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVolver.ForeColor = Color.White;
            buttonVolver.Location = new Point(16, 580);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(100, 42);
            buttonVolver.TabIndex = 14;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonEliminar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonVolver);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 655);
            panel1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(32, 153);
            label1.Name = "label1";
            label1.Size = new Size(296, 32);
            label1.TabIndex = 1;
            label1.Text = "Informacion del empleado";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(30, 9);
            label8.Name = "label8";
            label8.Size = new Size(249, 32);
            label8.TabIndex = 0;
            label8.Text = "Seleccionar empleado";
            // 
            // FormEliminarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 616);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormEliminarEmpleado";
            Text = "FormEliminarEmpleado";
            Load += FormEliminarEmpleados_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label label3;
        private ComboBox comboBoxEmpleados;
        private Panel panel2;
        private TextBox textBoxNumTel;
        private Label label5;
        private TextBox textBoxDireccion;
        private TextBox textBoxCorreo;
        private Label label10;
        private Label label7;
        private TextBox textBoxNombre;
        private Label label4;
        private Label label2;
        private TextBox textBoxCURP;
        private Label label6;
        private Button buttonEliminar;
        private Button buttonVolver;
        private Panel panel1;
        private Label label1;
        private Label label8;
        private TextBox textBoxApellido;
        private Label label9;
        private TextBox textBoxCargo;
        private Label label11;
    }
}