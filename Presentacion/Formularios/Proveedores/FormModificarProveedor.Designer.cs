namespace Presentacion.Formularios.Proveedores
{
    partial class FormModificarProveedor
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
            buttonActualizar = new Button();
            buttonVolver = new Button();
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            comboBoxEmpleados = new ComboBox();
            panel1 = new Panel();
            panel4 = new Panel();
            checkedListBoxProductos = new CheckedListBox();
            panel3 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            textBoxCorreo = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxNumTel = new TextBox();
            textBoxNombre = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonActualizar
            // 
            buttonActualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonActualizar.AutoSize = true;
            buttonActualizar.FlatStyle = FlatStyle.Flat;
            buttonActualizar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonActualizar.ForeColor = Color.White;
            buttonActualizar.Location = new Point(1826, 1165);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(113, 50);
            buttonActualizar.TabIndex = 20;
            buttonActualizar.Text = "Modificar";
            buttonActualizar.UseVisualStyleBackColor = true;
            // 
            // buttonVolver
            // 
            buttonVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonVolver.AutoSize = true;
            buttonVolver.FlatStyle = FlatStyle.Flat;
            buttonVolver.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVolver.ForeColor = Color.White;
            buttonVolver.Location = new Point(30, 1165);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(112, 50);
            buttonVolver.TabIndex = 21;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 52);
            label2.Name = "label2";
            label2.Size = new Size(337, 45);
            label2.TabIndex = 15;
            label2.Text = "Seleccionar proveedor";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBoxEmpleados);
            panel2.Location = new Point(40, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 85);
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
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(buttonActualizar);
            panel1.Controls.Add(buttonVolver);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-9, -32);
            panel1.Name = "panel1";
            panel1.Size = new Size(1094, 674);
            panel1.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(checkedListBoxProductos);
            panel4.Location = new Point(668, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(347, 451);
            panel4.TabIndex = 27;
            // 
            // checkedListBoxProductos
            // 
            checkedListBoxProductos.ForeColor = SystemColors.Window;
            checkedListBoxProductos.FormattingEnabled = true;
            checkedListBoxProductos.Location = new Point(19, 18);
            checkedListBoxProductos.Name = "checkedListBoxProductos";
            checkedListBoxProductos.Size = new Size(306, 418);
            checkedListBoxProductos.TabIndex = 10;
            checkedListBoxProductos.ItemCheck += checkedListBoxProductos_ItemCheck;
            checkedListBoxProductos.SelectedIndexChanged += checkedListBoxProductos_SelectedIndexChanged;
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
            panel3.Location = new Point(40, 206);
            panel3.Name = "panel3";
            panel3.Size = new Size(579, 345);
            panel3.TabIndex = 26;
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
            textBoxCorreo.Size = new Size(549, 29);
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
            textBoxDireccion.Size = new Size(549, 29);
            textBoxDireccion.TabIndex = 1;
            textBoxDireccion.Text = "Dirección";
            // 
            // textBoxNumTel
            // 
            textBoxNumTel.BorderStyle = BorderStyle.None;
            textBoxNumTel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumTel.ForeColor = Color.WhiteSmoke;
            textBoxNumTel.Location = new Point(16, 152);
            textBoxNumTel.Name = "textBoxNumTel";
            textBoxNumTel.Size = new Size(549, 29);
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
            textBoxNombre.Size = new Size(549, 28);
            textBoxNombre.TabIndex = 1;
            textBoxNombre.Text = "Nombre";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(923, 571);
            button1.Name = "button1";
            button1.Size = new Size(125, 65);
            button1.TabIndex = 24;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.AutoSize = true;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(21, 571);
            button2.Name = "button2";
            button2.Size = new Size(124, 65);
            button2.TabIndex = 25;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormModificarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 616);
            Controls.Add(panel1);
            Name = "FormModificarProveedor";
            Text = "FormModificarProveedor";
            Load += FormModificarProveedor_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonActualizar;
        private Button buttonVolver;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private ComboBox comboBoxEmpleados;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Panel panel3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox textBoxCorreo;
        private TextBox textBoxDireccion;
        private TextBox textBoxNumTel;
        private TextBox textBoxNombre;
        private Panel panel4;
        private CheckedListBox checkedListBoxProductos;
    }
}