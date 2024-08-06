namespace Presentacion.Formularios.Proveedores
{
    partial class FormProveedoresBase
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
            btnModProv = new Button();
            btnConProv = new Button();
            buttonCompra = new Button();
            btnEliProv = new Button();
            btnRegProv = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnModProv);
            panel1.Controls.Add(btnConProv);
            panel1.Controls.Add(buttonCompra);
            panel1.Controls.Add(btnEliProv);
            panel1.Controls.Add(btnRegProv);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 616);
            panel1.TabIndex = 0;
            // 
            // btnModProv
            // 
            btnModProv.Anchor = AnchorStyles.None;
            btnModProv.FlatAppearance.BorderColor = Color.White;
            btnModProv.FlatAppearance.BorderSize = 0;
            btnModProv.FlatStyle = FlatStyle.Flat;
            btnModProv.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModProv.ForeColor = SystemColors.Window;
            btnModProv.ImageAlign = ContentAlignment.TopCenter;
            btnModProv.Location = new Point(3, 256);
            btnModProv.Name = "btnModProv";
            btnModProv.Size = new Size(1049, 106);
            btnModProv.TabIndex = 1;
            btnModProv.Text = "Modificar proveedor";
            btnModProv.TextAlign = ContentAlignment.BottomCenter;
            btnModProv.UseVisualStyleBackColor = true;
            btnModProv.Click += btnModProv_Click;
            // 
            // btnConProv
            // 
            btnConProv.Anchor = AnchorStyles.None;
            btnConProv.FlatAppearance.BorderColor = Color.White;
            btnConProv.FlatAppearance.BorderSize = 0;
            btnConProv.FlatStyle = FlatStyle.Flat;
            btnConProv.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConProv.ForeColor = SystemColors.Window;
            btnConProv.ImageAlign = ContentAlignment.TopCenter;
            btnConProv.Location = new Point(0, 136);
            btnConProv.Name = "btnConProv";
            btnConProv.Size = new Size(1046, 114);
            btnConProv.TabIndex = 0;
            btnConProv.Text = "Consultar proveedores";
            btnConProv.TextAlign = ContentAlignment.BottomCenter;
            btnConProv.UseVisualStyleBackColor = true;
            btnConProv.Click += btnConProv_Click;
            // 
            // buttonCompra
            // 
            buttonCompra.Anchor = AnchorStyles.None;
            buttonCompra.FlatAppearance.BorderColor = Color.White;
            buttonCompra.FlatAppearance.BorderSize = 0;
            buttonCompra.FlatStyle = FlatStyle.Flat;
            buttonCompra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCompra.ForeColor = SystemColors.Window;
            buttonCompra.ImageAlign = ContentAlignment.TopCenter;
            buttonCompra.Location = new Point(0, 480);
            buttonCompra.Name = "buttonCompra";
            buttonCompra.Size = new Size(1049, 106);
            buttonCompra.TabIndex = 0;
            buttonCompra.Text = "Registrar nueva compra";
            buttonCompra.TextAlign = ContentAlignment.BottomCenter;
            buttonCompra.UseVisualStyleBackColor = true;
            buttonCompra.Click += buttonCompra_Click;
            // 
            // btnEliProv
            // 
            btnEliProv.Anchor = AnchorStyles.None;
            btnEliProv.FlatAppearance.BorderColor = Color.White;
            btnEliProv.FlatAppearance.BorderSize = 0;
            btnEliProv.FlatStyle = FlatStyle.Flat;
            btnEliProv.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliProv.ForeColor = SystemColors.Window;
            btnEliProv.ImageAlign = ContentAlignment.TopCenter;
            btnEliProv.Location = new Point(0, 368);
            btnEliProv.Name = "btnEliProv";
            btnEliProv.Size = new Size(1049, 106);
            btnEliProv.TabIndex = 0;
            btnEliProv.Text = "Eliminar proveedor";
            btnEliProv.TextAlign = ContentAlignment.BottomCenter;
            btnEliProv.UseVisualStyleBackColor = true;
            btnEliProv.Click += btnEliProv_Click;
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
            btnRegProv.Location = new Point(0, 29);
            btnRegProv.Name = "btnRegProv";
            btnRegProv.Size = new Size(1049, 101);
            btnRegProv.TabIndex = 0;
            btnRegProv.Text = "Registrar proveedor";
            btnRegProv.TextAlign = ContentAlignment.BottomCenter;
            btnRegProv.UseVisualStyleBackColor = true;
            btnRegProv.Click += btnRegProv_Click;
            // 
            // FormProveedoresBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 616);
            Controls.Add(panel1);
            Name = "FormProveedoresBase";
            Text = "Proveedores";
            Load += FormProveedoresBase_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRegProv;
        private Button btnConProv;
        private Button btnEliProv;
        private Button btnModProv;
        private Button buttonCompra;
    }
}