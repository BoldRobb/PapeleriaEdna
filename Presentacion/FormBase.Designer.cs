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
            panel1 = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(41, 32, 74);
            panelMenu.Controls.Add(buttonLogout);
            panelMenu.Controls.Add(buttonEmpleados);
            panelMenu.Controls.Add(buttonEgresos);
            panelMenu.Controls.Add(buttonVentas);
            panelMenu.Controls.Add(buttonProveedores);
            panelMenu.Controls.Add(buttonInventario);
            panelMenu.Controls.Add(buttonClientes);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(215, 443);
            panelMenu.TabIndex = 0;
            // 
            // buttonLogout
            // 
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogout.ForeColor = Color.MistyRose;
            buttonLogout.Image = (Image)resources.GetObject("buttonLogout.Image");
            buttonLogout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogout.Location = new Point(0, 395);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(215, 45);
            buttonLogout.TabIndex = 1;
            buttonLogout.Text = "Log-Out";
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
            buttonEmpleados.ForeColor = Color.MistyRose;
            buttonEmpleados.Image = (Image)resources.GetObject("buttonEmpleados.Image");
            buttonEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEmpleados.Location = new Point(0, 326);
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
            buttonEgresos.ForeColor = Color.MistyRose;
            buttonEgresos.Image = (Image)resources.GetObject("buttonEgresos.Image");
            buttonEgresos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEgresos.Location = new Point(0, 275);
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
            buttonVentas.ForeColor = Color.MistyRose;
            buttonVentas.Image = (Image)resources.GetObject("buttonVentas.Image");
            buttonVentas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonVentas.Location = new Point(0, 224);
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
            buttonProveedores.ForeColor = Color.MistyRose;
            buttonProveedores.Image = (Image)resources.GetObject("buttonProveedores.Image");
            buttonProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProveedores.Location = new Point(0, 173);
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
            buttonInventario.Location = new Point(0, 122);
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
            buttonClientes.ForeColor = Color.MistyRose;
            buttonClientes.Image = (Image)resources.GetObject("buttonClientes.Image");
            buttonClientes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClientes.Location = new Point(0, 71);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(215, 45);
            buttonClientes.TabIndex = 1;
            buttonClientes.Text = "  Clientes";
            buttonClientes.TextAlign = ContentAlignment.MiddleLeft;
            buttonClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonClientes.UseVisualStyleBackColor = true;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 32, 51);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 75);
            panel1.TabIndex = 0;
            // 
            // FormBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 443);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBase";
            Text = "FormBase";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private Button buttonClientes;
        private Button buttonProveedores;
        private Button buttonInventario;
        private Button buttonEgresos;
        private Button buttonVentas;
        private Button buttonEmpleados;
        private Button buttonLogout;
    }
}