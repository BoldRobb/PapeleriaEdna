namespace Presentacion.Formularios.Proveedores
{
    partial class FormRegistrarProvedor
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
            panel2 = new Panel();
            textBoxCorreo = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxNumTel = new TextBox();
            textBoxNombre = new TextBox();
            buttonVolver = new Button();
            buttonAgregar = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            checkedListBoxProductos = new CheckedListBox();
            label9 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxCorreo);
            panel2.Controls.Add(textBoxDireccion);
            panel2.Controls.Add(textBoxNumTel);
            panel2.Controls.Add(textBoxNombre);
            panel2.Location = new Point(12, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(595, 236);
            panel2.TabIndex = 4;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BorderStyle = BorderStyle.None;
            textBoxCorreo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCorreo.ForeColor = Color.WhiteSmoke;
            textBoxCorreo.Location = new Point(12, 122);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(563, 29);
            textBoxCorreo.TabIndex = 1;
            textBoxCorreo.Text = "Correo";
            textBoxCorreo.Enter += textBoxCorreo_Enter;
            textBoxCorreo.Leave += textBoxCorreo_Leave;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.BorderStyle = BorderStyle.None;
            textBoxDireccion.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDireccion.ForeColor = Color.WhiteSmoke;
            textBoxDireccion.Location = new Point(12, 176);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(563, 29);
            textBoxDireccion.TabIndex = 1;
            textBoxDireccion.Text = "Dirección";
            textBoxDireccion.Enter += textBoxDireccion_Enter;
            textBoxDireccion.Leave += textBoxDireccion_Leave;
            // 
            // textBoxNumTel
            // 
            textBoxNumTel.BorderStyle = BorderStyle.None;
            textBoxNumTel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumTel.ForeColor = Color.WhiteSmoke;
            textBoxNumTel.Location = new Point(12, 68);
            textBoxNumTel.Name = "textBoxNumTel";
            textBoxNumTel.Size = new Size(563, 29);
            textBoxNumTel.TabIndex = 1;
            textBoxNumTel.Text = "Telefono";
            textBoxNumTel.Enter += textBoxNumTel_Enter;
            textBoxNumTel.Leave += textBoxNumTel_Leave;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.None;
            textBoxNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.ForeColor = Color.WhiteSmoke;
            textBoxNombre.Location = new Point(12, 18);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(563, 28);
            textBoxNombre.TabIndex = 1;
            textBoxNombre.Text = "Nombre";
            textBoxNombre.Enter += textBoxNombre_Enter;
            textBoxNombre.Leave += textBoxNombre_Leave;
            // 
            // buttonVolver
            // 
            buttonVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonVolver.AutoSize = true;
            buttonVolver.FlatStyle = FlatStyle.Flat;
            buttonVolver.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVolver.ForeColor = Color.White;
            buttonVolver.Location = new Point(33, 514);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(176, 94);
            buttonVolver.TabIndex = 5;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAgregar.AutoSize = true;
            buttonAgregar.FlatStyle = FlatStyle.Flat;
            buttonAgregar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregar.ForeColor = Color.White;
            buttonAgregar.Location = new Point(844, 516);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(177, 91);
            buttonAgregar.TabIndex = 6;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(buttonAgregar);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(buttonVolver);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 655);
            panel1.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Controls.Add(checkedListBoxProductos);
            panel3.Location = new Point(646, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(357, 457);
            panel3.TabIndex = 9;
            // 
            // checkedListBoxProductos
            // 
            checkedListBoxProductos.ForeColor = SystemColors.Window;
            checkedListBoxProductos.FormattingEnabled = true;
            checkedListBoxProductos.Location = new Point(23, 18);
            checkedListBoxProductos.Name = "checkedListBoxProductos";
            checkedListBoxProductos.Size = new Size(312, 418);
            checkedListBoxProductos.TabIndex = 10;
            checkedListBoxProductos.ItemCheck += checkedListBoxProductos_ItemCheck;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(33, 57);
            label9.Name = "label9";
            label9.Size = new Size(400, 45);
            label9.TabIndex = 8;
            label9.Text = "Informacion del proveedor";
            // 
            // FormRegistrarProvedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 616);
            Controls.Add(panel1);
            Name = "FormRegistrarProvedor";
            Text = "FormRegistrarProveedor";
            Load += FormRegistrarProvedor_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TextBox textBoxCorreo;
        private TextBox textBoxDireccion;
        private TextBox textBoxNumTel;
        private TextBox textBoxNombre;
        private Button buttonVolver;
        private Button buttonAgregar;
        private Panel panel1;
        private Label label9;
        private Panel panel3;
        private CheckedListBox checkedListBoxProductos;
    }
}