namespace Presentacion.Formularios.Empleados
{
    partial class FormEmpleadosBase
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
            btnRegProv = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnRegProv);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 616);
            panel1.TabIndex = 0;
            // 
            // btnRegProv
            // 
            btnRegProv.Anchor = AnchorStyles.None;
            btnRegProv.FlatAppearance.BorderColor = Color.White;
            btnRegProv.FlatAppearance.BorderSize = 0;
            btnRegProv.FlatStyle = FlatStyle.Flat;
            btnRegProv.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegProv.ForeColor = SystemColors.Window;
            btnRegProv.ImageAlign = ContentAlignment.TopCenter;
            btnRegProv.Location = new Point(0, 12);
            btnRegProv.Name = "btnRegProv";
            btnRegProv.Size = new Size(1049, 101);
            btnRegProv.TabIndex = 1;
            btnRegProv.Text = "Registrar empleado";
            btnRegProv.TextAlign = ContentAlignment.BottomCenter;
            btnRegProv.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Window;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(3, 119);
            button1.Name = "button1";
            button1.Size = new Size(1049, 101);
            button1.TabIndex = 2;
            button1.Text = "Modificar empleado";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Window;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(0, 258);
            button2.Name = "button2";
            button2.Size = new Size(1049, 101);
            button2.TabIndex = 3;
            button2.Text = "Ver empledos";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Window;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(0, 365);
            button3.Name = "button3";
            button3.Size = new Size(1049, 101);
            button3.TabIndex = 4;
            button3.Text = "Eliminar empleado";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // FormEmpleadosBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 616);
            Controls.Add(panel1);
            Name = "FormEmpleadosBase";
            Text = "Empleados";
            Load += FormEmpleadosBase_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnRegProv;
    }
}