namespace Presentacion
{
    partial class FormBase : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            panelMenu = new Panel();
            buttonLogout = new Button();
            buttonEmpleados = new Button();
            buttonEgresos = new Button();
            buttonVentas = new Button();
            buttonProveedores = new Button();
            buttonInventario = new Button();
            buttonClientes = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            labelMail = new Label();
            labelPosition = new Label();
            labelUser = new Label();
            panelTitle = new Panel();
            buttonCerrar = new Button();
            buttonTamaño = new Button();
            buttonCloseChild = new Button();
            buttonMinimizar = new Button();
            labelTitle = new Label();
            panelChilds = new Panel();
            pictureBoxLogo = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitle.SuspendLayout();
            panelChilds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(46, 71, 86);
            panelMenu.Controls.Add(buttonLogout);
            panelMenu.Controls.Add(buttonEmpleados);
            panelMenu.Controls.Add(buttonEgresos);
            panelMenu.Controls.Add(buttonVentas);
            panelMenu.Controls.Add(buttonProveedores);
            panelMenu.Controls.Add(buttonInventario);
            panelMenu.Controls.Add(buttonClientes);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(215, 720);
            panelMenu.TabIndex = 0;
            // 
            // buttonLogout
            // 
            buttonLogout.Dock = DockStyle.Bottom;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogout.ForeColor = Color.WhiteSmoke;
            buttonLogout.Image = (Image)resources.GetObject("buttonLogout.Image");
            buttonLogout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogout.Location = new Point(0, 670);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(215, 50);
            buttonLogout.TabIndex = 1;
            buttonLogout.Text = "  Cerrar sesión";
            buttonLogout.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonEmpleados
            // 
            buttonEmpleados.FlatAppearance.BorderSize = 0;
            buttonEmpleados.FlatStyle = FlatStyle.Flat;
            buttonEmpleados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEmpleados.ForeColor = Color.WhiteSmoke;
            buttonEmpleados.Image = (Image)resources.GetObject("buttonEmpleados.Image");
            buttonEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEmpleados.Location = new Point(0, 384);
            buttonEmpleados.Name = "buttonEmpleados";
            buttonEmpleados.Size = new Size(215, 45);
            buttonEmpleados.TabIndex = 1;
            buttonEmpleados.Text = "  Empleados";
            buttonEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            buttonEmpleados.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEmpleados.UseVisualStyleBackColor = true;
            buttonEmpleados.Click += buttonEmpleados_Click;
            // 
            // buttonEgresos
            // 
            buttonEgresos.FlatAppearance.BorderSize = 0;
            buttonEgresos.FlatStyle = FlatStyle.Flat;
            buttonEgresos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEgresos.ForeColor = Color.WhiteSmoke;
            buttonEgresos.Image = (Image)resources.GetObject("buttonEgresos.Image");
            buttonEgresos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEgresos.Location = new Point(0, 333);
            buttonEgresos.Name = "buttonEgresos";
            buttonEgresos.Size = new Size(215, 45);
            buttonEgresos.TabIndex = 1;
            buttonEgresos.Text = "  Egresos";
            buttonEgresos.TextAlign = ContentAlignment.MiddleLeft;
            buttonEgresos.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEgresos.UseVisualStyleBackColor = true;
            buttonEgresos.Click += buttonEgresos_Click;
            // 
            // buttonVentas
            // 
            buttonVentas.FlatAppearance.BorderSize = 0;
            buttonVentas.FlatStyle = FlatStyle.Flat;
            buttonVentas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVentas.ForeColor = Color.WhiteSmoke;
            buttonVentas.Image = (Image)resources.GetObject("buttonVentas.Image");
            buttonVentas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonVentas.Location = new Point(0, 282);
            buttonVentas.Name = "buttonVentas";
            buttonVentas.Size = new Size(215, 45);
            buttonVentas.TabIndex = 1;
            buttonVentas.Text = "  Ventas";
            buttonVentas.TextAlign = ContentAlignment.MiddleLeft;
            buttonVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonVentas.UseVisualStyleBackColor = true;
            buttonVentas.Click += buttonVentas_Click;
            // 
            // buttonProveedores
            // 
            buttonProveedores.FlatAppearance.BorderSize = 0;
            buttonProveedores.FlatStyle = FlatStyle.Flat;
            buttonProveedores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProveedores.ForeColor = Color.WhiteSmoke;
            buttonProveedores.Image = (Image)resources.GetObject("buttonProveedores.Image");
            buttonProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProveedores.Location = new Point(0, 231);
            buttonProveedores.Name = "buttonProveedores";
            buttonProveedores.Size = new Size(215, 45);
            buttonProveedores.TabIndex = 1;
            buttonProveedores.Text = "  Proveedores";
            buttonProveedores.TextAlign = ContentAlignment.MiddleLeft;
            buttonProveedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonProveedores.UseVisualStyleBackColor = true;
            buttonProveedores.Click += buttonProveedores_Click;
            // 
            // buttonInventario
            // 
            buttonInventario.FlatAppearance.BorderSize = 0;
            buttonInventario.FlatStyle = FlatStyle.Flat;
            buttonInventario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInventario.ForeColor = Color.WhiteSmoke;
            buttonInventario.Image = (Image)resources.GetObject("buttonInventario.Image");
            buttonInventario.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInventario.Location = new Point(0, 180);
            buttonInventario.Name = "buttonInventario";
            buttonInventario.Size = new Size(215, 45);
            buttonInventario.TabIndex = 1;
            buttonInventario.Text = "  Inventario";
            buttonInventario.TextAlign = ContentAlignment.MiddleLeft;
            buttonInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonInventario.UseVisualStyleBackColor = true;
            buttonInventario.Click += buttonInventario_Click;
            // 
            // buttonClientes
            // 
            buttonClientes.FlatAppearance.BorderSize = 0;
            buttonClientes.FlatStyle = FlatStyle.Flat;
            buttonClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClientes.ForeColor = Color.WhiteSmoke;
            buttonClientes.Image = (Image)resources.GetObject("buttonClientes.Image");
            buttonClientes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClientes.Location = new Point(0, 129);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(215, 45);
            buttonClientes.TabIndex = 1;
            buttonClientes.Text = "  Clientes";
            buttonClientes.TextAlign = ContentAlignment.MiddleLeft;
            buttonClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonClientes.UseVisualStyleBackColor = true;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(22, 38, 46);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Controls.Add(labelMail);
            panelLogo.Controls.Add(labelPosition);
            panelLogo.Controls.Add(labelUser);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(215, 123);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMail.ForeColor = Color.WhiteSmoke;
            labelMail.Location = new Point(12, 95);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(89, 20);
            labelMail.TabIndex = 0;
            labelMail.Text = "Informacion";
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPosition.ForeColor = Color.WhiteSmoke;
            labelPosition.Location = new Point(88, 48);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(77, 17);
            labelPosition.TabIndex = 0;
            labelPosition.Text = "Informacion";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelUser.ForeColor = Color.WhiteSmoke;
            labelUser.Location = new Point(88, 21);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(77, 17);
            labelUser.TabIndex = 0;
            labelUser.Text = "Informacion";
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(60, 122, 137);
            panelTitle.Controls.Add(buttonCerrar);
            panelTitle.Controls.Add(buttonTamaño);
            panelTitle.Controls.Add(buttonCloseChild);
            panelTitle.Controls.Add(buttonMinimizar);
            panelTitle.Controls.Add(labelTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(215, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1065, 65);
            panelTitle.TabIndex = 1;
            panelTitle.MouseDown += panelTitle_MouseDown;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Anchor = AnchorStyles.Right;
            buttonCerrar.FlatAppearance.BorderSize = 0;
            buttonCerrar.FlatStyle = FlatStyle.Flat;
            buttonCerrar.Image = (Image)resources.GetObject("buttonCerrar.Image");
            buttonCerrar.Location = new Point(1035, 5);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(21, 21);
            buttonCerrar.TabIndex = 9;
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += buttonCerrar_Click_1;
            // 
            // buttonTamaño
            // 
            buttonTamaño.Anchor = AnchorStyles.Right;
            buttonTamaño.FlatAppearance.BorderSize = 0;
            buttonTamaño.FlatStyle = FlatStyle.Flat;
            buttonTamaño.Image = (Image)resources.GetObject("buttonTamaño.Image");
            buttonTamaño.Location = new Point(1001, 5);
            buttonTamaño.Name = "buttonTamaño";
            buttonTamaño.Size = new Size(21, 21);
            buttonTamaño.TabIndex = 10;
            buttonTamaño.UseVisualStyleBackColor = true;
            buttonTamaño.Click += buttonTamaño_Click_1;
            // 
            // buttonCloseChild
            // 
            buttonCloseChild.FlatAppearance.BorderSize = 0;
            buttonCloseChild.FlatStyle = FlatStyle.Flat;
            buttonCloseChild.Image = (Image)resources.GetObject("buttonCloseChild.Image");
            buttonCloseChild.Location = new Point(6, 12);
            buttonCloseChild.Name = "buttonCloseChild";
            buttonCloseChild.Size = new Size(46, 41);
            buttonCloseChild.TabIndex = 10;
            buttonCloseChild.UseVisualStyleBackColor = true;
            buttonCloseChild.Click += buttonCloseChild_Click;
            // 
            // buttonMinimizar
            // 
            buttonMinimizar.Anchor = AnchorStyles.Right;
            buttonMinimizar.FlatAppearance.BorderSize = 0;
            buttonMinimizar.FlatStyle = FlatStyle.Flat;
            buttonMinimizar.Image = (Image)resources.GetObject("buttonMinimizar.Image");
            buttonMinimizar.Location = new Point(965, 5);
            buttonMinimizar.Name = "buttonMinimizar";
            buttonMinimizar.Size = new Size(21, 21);
            buttonMinimizar.TabIndex = 10;
            buttonMinimizar.UseVisualStyleBackColor = true;
            buttonMinimizar.Click += buttonMinimizar_Click_1;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(489, 19);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(123, 30);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Bienvenido";
            // 
            // panelChilds
            // 
            panelChilds.BackColor = Color.FromArgb(233, 234, 239);
            panelChilds.Controls.Add(pictureBoxLogo);
            panelChilds.Dock = DockStyle.Fill;
            panelChilds.Location = new Point(215, 65);
            panelChilds.Name = "panelChilds";
            panelChilds.Size = new Size(1065, 655);
            panelChilds.TabIndex = 2;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.None;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(307, 252);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(450, 152);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // FormBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1280, 720);
            Controls.Add(panelChilds);
            Controls.Add(panelTitle);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBase";
            Load += FormBase_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            panelChilds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button buttonClientes;
        private Button buttonProveedores;
        private Button buttonInventario;
        private Button buttonEgresos;
        private Button buttonVentas;
        private Button buttonEmpleados;
        private Button buttonLogout;
        private Panel panelTitle;
        private Label labelTitle;
        private Label labelUser;
        private Panel panelChilds;
        private Button buttonCerrar;
        private Button buttonTamaño;
        private Button buttonMinimizar;
        private Button buttonCloseChild;
        private Label labelMail;
        private Label labelPosition;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxLogo;
    }
}