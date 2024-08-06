namespace Presentacion.Formularios.Egresos
{
    partial class PagoProveedores
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
            label3 = new Label();
            panel1 = new Panel();
            textBoxTotal = new TextBox();
            label7 = new Label();
            label5 = new Label();
            textBoxDescripcion = new TextBox();
            label6 = new Label();
            label2 = new Label();
            monthCalendar1 = new MonthCalendar();
            label4 = new Label();
            comboBoxPagos = new ComboBox();
            comboBoxProveedores = new ComboBox();
            buttonVolver = new Button();
            buttonRegistrar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 40);
            label3.Name = "label3";
            label3.Size = new Size(344, 30);
            label3.TabIndex = 17;
            label3.Text = "Registro de pago a proveedores";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxTotal);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxDescripcion);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBoxPagos);
            panel1.Controls.Add(comboBoxProveedores);
            panel1.Location = new Point(34, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 421);
            panel1.TabIndex = 18;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTotal.Location = new Point(25, 116);
            textBoxTotal.Margin = new Padding(3, 2, 3, 2);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(307, 32);
            textBoxTotal.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(25, 86);
            label7.Name = "label7";
            label7.Size = new Size(52, 25);
            label7.TabIndex = 9;
            label7.Text = "Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(406, 178);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 13;
            label5.Text = "Descripcion";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescripcion.Location = new Point(406, 208);
            textBoxDescripcion.Margin = new Padding(3, 2, 3, 2);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(486, 181);
            textBoxDescripcion.TabIndex = 12;
            textBoxDescripcion.TextChanged += textBoxDescripcion_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(406, 19);
            label6.Name = "label6";
            label6.Size = new Size(160, 25);
            label6.TabIndex = 10;
            label6.Text = "Pagos pendientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 19);
            label2.Name = "label2";
            label2.Size = new Size(221, 25);
            label2.TabIndex = 10;
            label2.Text = "Seleccione un proveedor";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(25, 227);
            monthCalendar1.Margin = new Padding(8, 7, 8, 7);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 197);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 6;
            label4.Text = "Fecha del pago";
            // 
            // comboBoxPagos
            // 
            comboBoxPagos.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPagos.FormattingEnabled = true;
            comboBoxPagos.Location = new Point(406, 49);
            comboBoxPagos.Margin = new Padding(3, 2, 3, 2);
            comboBoxPagos.Name = "comboBoxPagos";
            comboBoxPagos.Size = new Size(372, 33);
            comboBoxPagos.TabIndex = 11;
            comboBoxPagos.SelectedIndexChanged += comboBoxPagos_SelectedIndexChanged;
            // 
            // comboBoxProveedores
            // 
            comboBoxProveedores.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxProveedores.FormattingEnabled = true;
            comboBoxProveedores.Location = new Point(25, 49);
            comboBoxProveedores.Margin = new Padding(3, 2, 3, 2);
            comboBoxProveedores.Name = "comboBoxProveedores";
            comboBoxProveedores.Size = new Size(307, 33);
            comboBoxProveedores.TabIndex = 11;
            comboBoxProveedores.SelectedIndexChanged += comboBoxProveedores_SelectedIndexChanged;
            // 
            // buttonVolver
            // 
            buttonVolver.FlatStyle = FlatStyle.Flat;
            buttonVolver.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVolver.ForeColor = Color.White;
            buttonVolver.Location = new Point(12, 553);
            buttonVolver.Margin = new Padding(3, 2, 3, 2);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(152, 52);
            buttonVolver.TabIndex = 16;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.FlatStyle = FlatStyle.Flat;
            buttonRegistrar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistrar.ForeColor = Color.White;
            buttonRegistrar.Location = new Point(885, 553);
            buttonRegistrar.Margin = new Padding(3, 2, 3, 2);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(152, 52);
            buttonRegistrar.TabIndex = 15;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = true;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // PagoProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1049, 616);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(buttonVolver);
            Controls.Add(buttonRegistrar);
            Name = "PagoProveedores";
            Text = "PagoProveedores";
            Load += PagoProveedores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel panel1;
        private Label label5;
        private TextBox textBoxDescripcion;
        private Label label2;
        private MonthCalendar monthCalendar1;
        private Label label4;
        private ComboBox comboBoxProveedores;
        private Button buttonVolver;
        private Button buttonRegistrar;
        private TextBox textBoxTotal;
        private Label label7;
        private Label label6;
        private ComboBox comboBoxPagos;
    }
}