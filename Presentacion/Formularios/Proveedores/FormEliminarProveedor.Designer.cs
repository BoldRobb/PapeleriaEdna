namespace Presentacion.Formularios.Proveedores
{
    partial class FormEliminarProveedor
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
            label1 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            comboBoxProveedores = new ComboBox();
            panel1 = new Panel();
            buttonEliminar = new Button();
            buttonVolver = new Button();
            panel3 = new Panel();
            textBoxNumTel = new TextBox();
            label5 = new Label();
            textBoxDireccion = new TextBox();
            textBoxCorreo = new TextBox();
            label10 = new Label();
            label7 = new Label();
            textBoxNombre = new TextBox();
            label4 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 187);
            label1.Name = "label1";
            label1.Size = new Size(260, 32);
            label1.TabIndex = 7;
            label1.Text = "Informacion del cliente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(49, 23);
            label9.Name = "label9";
            label9.Size = new Size(213, 32);
            label9.TabIndex = 8;
            label9.Text = "Seleccionar cliente";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBoxProveedores);
            panel2.Location = new Point(40, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(970, 106);
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
            comboBoxProveedores.ForeColor = SystemColors.Window;
            comboBoxProveedores.FormattingEnabled = true;
            comboBoxProveedores.Location = new Point(16, 32);
            comboBoxProveedores.Name = "comboBoxProveedores";
            comboBoxProveedores.Size = new Size(412, 38);
            comboBoxProveedores.TabIndex = 0;
            comboBoxProveedores.SelectedIndexChanged += comboBoxProveedores_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonEliminar);
            panel1.Controls.Add(buttonVolver);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 655);
            panel1.TabIndex = 11;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEliminar.AutoSize = true;
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEliminar.ForeColor = Color.White;
            buttonEliminar.Location = new Point(911, 573);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(112, 50);
            buttonEliminar.TabIndex = 11;
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
            buttonVolver.Location = new Point(12, 573);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(112, 50);
            buttonVolver.TabIndex = 12;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxNumTel);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textBoxDireccion);
            panel3.Controls.Add(textBoxCorreo);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textBoxNombre);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(40, 222);
            panel3.Name = "panel3";
            panel3.Size = new Size(969, 321);
            panel3.TabIndex = 10;
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
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(8, 17);
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
            // FormEliminarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 616);
            Controls.Add(panel1);
            Name = "FormEliminarProveedor";
            Text = "FormEliminarProveedor";
            Load += FormEliminarProveedor_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label9;
        private Panel panel2;
        private Label label3;
        private ComboBox comboBoxProveedores;
        private Panel panel1;
        private Panel panel3;
        private TextBox textBoxNumTel;
        private Label label5;
        private TextBox textBoxDireccion;
        private TextBox textBoxCorreo;
        private Label label10;
        private Label label7;
        private TextBox textBoxNombre;
        private Label label4;
        private Label label2;
        private Button buttonEliminar;
        private Button buttonVolver;
    }
}