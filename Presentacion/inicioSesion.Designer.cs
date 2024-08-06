namespace Presentacion
{
    partial class inicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicioSesion));
            panel1 = new Panel();
            labelmsgerror = new Label();
            panel2 = new Panel();
            buttonCerrar = new Button();
            buttonMinimizar = new Button();
            txtpass = new TextBox();
            txtuser = new TextBox();
            label3 = new Label();
            label2 = new Label();
            buttonIniciar = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 71, 86);
            panel1.Controls.Add(labelmsgerror);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtpass);
            panel1.Controls.Add(txtuser);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonIniciar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 393);
            panel1.TabIndex = 0;
            // 
            // labelmsgerror
            // 
            labelmsgerror.AutoSize = true;
            labelmsgerror.ForeColor = SystemColors.ButtonFace;
            labelmsgerror.Location = new Point(133, 252);
            labelmsgerror.Name = "labelmsgerror";
            labelmsgerror.Size = new Size(81, 15);
            labelmsgerror.TabIndex = 7;
            labelmsgerror.Text = "Error Message";
            labelmsgerror.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(60, 122, 137);
            panel2.Controls.Add(buttonCerrar);
            panel2.Controls.Add(buttonMinimizar);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(438, 25);
            panel2.TabIndex = 6;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // buttonCerrar
            // 
            buttonCerrar.FlatAppearance.BorderSize = 0;
            buttonCerrar.FlatStyle = FlatStyle.Flat;
            buttonCerrar.Image = (Image)resources.GetObject("buttonCerrar.Image");
            buttonCerrar.Location = new Point(413, 1);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(21, 21);
            buttonCerrar.TabIndex = 8;
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // buttonMinimizar
            // 
            buttonMinimizar.FlatAppearance.BorderSize = 0;
            buttonMinimizar.FlatStyle = FlatStyle.Flat;
            buttonMinimizar.Image = (Image)resources.GetObject("buttonMinimizar.Image");
            buttonMinimizar.Location = new Point(386, 1);
            buttonMinimizar.Name = "buttonMinimizar";
            buttonMinimizar.Size = new Size(21, 21);
            buttonMinimizar.TabIndex = 8;
            buttonMinimizar.UseVisualStyleBackColor = true;
            buttonMinimizar.Click += buttonMinimizar_Click;
            // 
            // txtpass
            // 
            txtpass.ForeColor = Color.Silver;
            txtpass.ImeMode = ImeMode.Disable;
            txtpass.Location = new Point(133, 209);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(164, 23);
            txtpass.TabIndex = 4;
            txtpass.Text = "Contraseña";
            txtpass.Enter += txtPass_Enter;
            txtpass.Leave += txtPass_Leave;
            // 
            // txtuser
            // 
            txtuser.ForeColor = Color.Silver;
            txtuser.Location = new Point(133, 130);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(164, 23);
            txtuser.TabIndex = 4;
            txtuser.Text = "Usuario";
            txtuser.Enter += txtUser_Enter;
            txtuser.Leave += txtUser_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(133, 173);
            label3.Name = "label3";
            label3.Size = new Size(118, 30);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(133, 94);
            label2.Name = "label2";
            label2.Size = new Size(83, 30);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // buttonIniciar
            // 
            buttonIniciar.FlatStyle = FlatStyle.Flat;
            buttonIniciar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIniciar.ForeColor = Color.White;
            buttonIniciar.Location = new Point(110, 298);
            buttonIniciar.Name = "buttonIniciar";
            buttonIniciar.Size = new Size(215, 56);
            buttonIniciar.TabIndex = 2;
            buttonIniciar.Text = "Iniciar sesión";
            buttonIniciar.UseVisualStyleBackColor = true;
            buttonIniciar.Click += buttonIniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(120, 46);
            label1.Name = "label1";
            label1.Size = new Size(199, 37);
            label1.TabIndex = 1;
            label1.Text = "Inicio de sesión";
            // 
            // inicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 392);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "inicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtpass;
        private TextBox txtuser;
        private Label label3;
        private Label label2;
        private Button buttonIniciar;
        private Label label1;
        private Panel panel2;
        private Label labelmsgerror;
        private Button buttonMinimizar;
        private Button buttonCerrar;
    }
}