namespace Presentacion.Formularios.Clientes
{
    partial class FormClienteNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClienteNuevo));
            panel1 = new Panel();
<<<<<<< HEAD
            buttonCerrar = new Button();
            label3 = new Label();
            label1 = new Label();
=======
            panel3 = new Panel();
            textBoxCorreo = new TextBox();
            labelCorreo = new Label();
            labelTelefono = new Label();
            labelDireccion = new Label();
            textBoxTelefono = new TextBox();
            textBoxDireccion = new TextBox();
            panel2 = new Panel();
            labelRFC = new Label();
            labelCURP = new Label();
            labelApellido = new Label();
            labelNombre = new Label();
            textBoxCURP = new TextBox();
            textBoxRFC = new TextBox();
            textBoxApellidos = new TextBox();
            textBoxName = new TextBox();
            buttonAgregar = new Button();
            buttonVolver = new Button();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
>>>>>>> 8d033578ec3bad25fa404d37997316218703345b
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
<<<<<<< HEAD
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonCerrar);
            panel1.Controls.Add(label3);
=======
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonAgregar);
            panel1.Controls.Add(buttonVolver);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label9);
>>>>>>> 8d033578ec3bad25fa404d37997316218703345b
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 616);
            panel1.TabIndex = 0;
            // 
<<<<<<< HEAD
            // buttonCerrar
            // 
            buttonCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCerrar.FlatAppearance.BorderSize = 0;
            buttonCerrar.FlatStyle = FlatStyle.Flat;
            buttonCerrar.Image = (Image)resources.GetObject("buttonCerrar.Image");
            buttonCerrar.Location = new Point(974, 12);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(63, 60);
            buttonCerrar.TabIndex = 10;
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 12);
            label3.Name = "label3";
            label3.Size = new Size(365, 36);
            label3.TabIndex = 2;
            label3.Text = "Agregar un cliente nuevo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 79);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 11;
            label1.Text = "Nombres";
            // 
=======
            // panel3
            // 
            panel3.Controls.Add(textBoxCorreo);
            panel3.Controls.Add(labelCorreo);
            panel3.Controls.Add(labelTelefono);
            panel3.Controls.Add(labelDireccion);
            panel3.Controls.Add(textBoxTelefono);
            panel3.Controls.Add(textBoxDireccion);
            panel3.Location = new Point(29, 350);
            panel3.Name = "panel3";
            panel3.Size = new Size(973, 183);
            panel3.TabIndex = 4;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BorderStyle = BorderStyle.None;
            textBoxCorreo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCorreo.ForeColor = Color.WhiteSmoke;
            textBoxCorreo.Location = new Point(22, 142);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(705, 29);
            textBoxCorreo.TabIndex = 1;
            textBoxCorreo.Text = " Correo";
            textBoxCorreo.Enter += textBoxCorreo_Enter;
            textBoxCorreo.Leave += textBoxCorreo_Leave;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(22, 124);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(38, 15);
            labelCorreo.TabIndex = 2;
            labelCorreo.Text = "label3";
            labelCorreo.Visible = false;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(22, 69);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(38, 15);
            labelTelefono.TabIndex = 2;
            labelTelefono.Text = "label3";
            labelTelefono.Visible = false;
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(22, 9);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(38, 15);
            labelDireccion.TabIndex = 2;
            labelDireccion.Text = "label3";
            labelDireccion.Visible = false;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.BorderStyle = BorderStyle.None;
            textBoxTelefono.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTelefono.ForeColor = Color.WhiteSmoke;
            textBoxTelefono.Location = new Point(22, 87);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(312, 29);
            textBoxTelefono.TabIndex = 1;
            textBoxTelefono.Text = " Telefono";
            textBoxTelefono.Enter += textBoxTelefono_Enter;
            textBoxTelefono.Leave += textBoxTelefono_Leave;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.BorderStyle = BorderStyle.None;
            textBoxDireccion.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDireccion.ForeColor = Color.WhiteSmoke;
            textBoxDireccion.Location = new Point(22, 27);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(705, 29);
            textBoxDireccion.TabIndex = 1;
            textBoxDireccion.Text = " Direccion";
            textBoxDireccion.Enter += textBoxDireccion_Enter;
            textBoxDireccion.Leave += textBoxDireccion_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelRFC);
            panel2.Controls.Add(labelCURP);
            panel2.Controls.Add(labelApellido);
            panel2.Controls.Add(labelNombre);
            panel2.Controls.Add(textBoxCURP);
            panel2.Controls.Add(textBoxRFC);
            panel2.Controls.Add(textBoxApellidos);
            panel2.Controls.Add(textBoxName);
            panel2.Location = new Point(29, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(973, 255);
            panel2.TabIndex = 3;
            // 
            // labelRFC
            // 
            labelRFC.AutoSize = true;
            labelRFC.Location = new Point(383, 133);
            labelRFC.Name = "labelRFC";
            labelRFC.Size = new Size(38, 15);
            labelRFC.TabIndex = 2;
            labelRFC.Text = "label3";
            labelRFC.Visible = false;
            // 
            // labelCURP
            // 
            labelCURP.AutoSize = true;
            labelCURP.Location = new Point(22, 133);
            labelCURP.Name = "labelCURP";
            labelCURP.Size = new Size(38, 15);
            labelCURP.TabIndex = 2;
            labelCURP.Text = "label3";
            labelCURP.Visible = false;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(22, 77);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(38, 15);
            labelApellido.TabIndex = 2;
            labelApellido.Text = "label3";
            labelApellido.Visible = false;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(22, 17);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(38, 15);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "label3";
            labelNombre.Visible = false;
            // 
            // textBoxCURP
            // 
            textBoxCURP.BorderStyle = BorderStyle.None;
            textBoxCURP.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCURP.ForeColor = Color.WhiteSmoke;
            textBoxCURP.Location = new Point(22, 151);
            textBoxCURP.Name = "textBoxCURP";
            textBoxCURP.Size = new Size(312, 29);
            textBoxCURP.TabIndex = 1;
            textBoxCURP.Text = " CURP";
            textBoxCURP.Enter += textBoxCURP_Enter;
            textBoxCURP.Leave += textBoxCURP_Leave;
            // 
            // textBoxRFC
            // 
            textBoxRFC.BorderStyle = BorderStyle.None;
            textBoxRFC.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRFC.ForeColor = Color.WhiteSmoke;
            textBoxRFC.Location = new Point(383, 151);
            textBoxRFC.Name = "textBoxRFC";
            textBoxRFC.Size = new Size(344, 29);
            textBoxRFC.TabIndex = 1;
            textBoxRFC.Text = " RFC";
            textBoxRFC.Enter += textBoxRFC_Enter;
            textBoxRFC.Leave += textBoxRFC_Leave;
            // 
            // textBoxApellidos
            // 
            textBoxApellidos.BorderStyle = BorderStyle.None;
            textBoxApellidos.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxApellidos.ForeColor = Color.WhiteSmoke;
            textBoxApellidos.Location = new Point(22, 95);
            textBoxApellidos.Name = "textBoxApellidos";
            textBoxApellidos.Size = new Size(705, 29);
            textBoxApellidos.TabIndex = 1;
            textBoxApellidos.Text = " Apellidos";
            textBoxApellidos.Enter += textBoxApellidos_Enter;
            textBoxApellidos.Leave += textBoxApellidos_Leave;
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
            textBoxName.Text = " Nombre";
            textBoxName.Enter += textBoxName_Enter;
            textBoxName.Leave += textBoxName_Leave;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAgregar.AutoSize = true;
            buttonAgregar.FlatStyle = FlatStyle.Flat;
            buttonAgregar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregar.ForeColor = Color.White;
            buttonAgregar.Location = new Point(890, 539);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(112, 50);
            buttonAgregar.TabIndex = 2;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonVolver
            // 
            buttonVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonVolver.AutoSize = true;
            buttonVolver.FlatStyle = FlatStyle.Flat;
            buttonVolver.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVolver.ForeColor = Color.White;
            buttonVolver.Location = new Point(29, 539);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(112, 50);
            buttonVolver.TabIndex = 2;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 280);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 315);
            label1.Name = "label1";
            label1.Size = new Size(275, 32);
            label1.TabIndex = 0;
            label1.Text = "Informacion de contacto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(49, 15);
            label9.Name = "label9";
            label9.Size = new Size(238, 32);
            label9.TabIndex = 0;
            label9.Text = "Informacion Personal";
            // 
>>>>>>> 8d033578ec3bad25fa404d37997316218703345b
            // FormClienteNuevo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 616);
            Controls.Add(panel1);
            Name = "FormClienteNuevo";
            Text = "Agregar Cliente";
            Load += FormClienteNuevo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
<<<<<<< HEAD
        private Label label3;
        private Button buttonCerrar;
=======
        private Button buttonVolver;
        private Button buttonAgregar;
        private Panel panel2;
        private Label label9;
        private TextBox textBoxApellidos;
        private TextBox textBoxName;
        private Panel panel3;
        private TextBox textBoxCorreo;
        private TextBox textBoxTelefono;
        private TextBox textBoxDireccion;
        private Label label2;
>>>>>>> 8d033578ec3bad25fa404d37997316218703345b
        private Label label1;
        private TextBox textBoxCURP;
        private TextBox textBoxRFC;
        private Label labelCorreo;
        private Label labelTelefono;
        private Label labelDireccion;
        private Label labelRFC;
        private Label labelCURP;
        private Label labelApellido;
        private Label labelNombre;
    }
}