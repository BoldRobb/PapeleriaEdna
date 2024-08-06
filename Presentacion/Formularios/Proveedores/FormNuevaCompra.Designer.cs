using System.Windows.Forms;

namespace Presentacion.Formularios.Proveedores
{
    partial class FormNuevaCompra
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
            buttonAñadir = new Button();
            comboBoxProductos = new ComboBox();
            label2 = new Label();
            comboBoxProveedores = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            labelTotal = new Label();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonAñadir);
            panel1.Controls.Add(comboBoxProductos);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxProveedores);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(32, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 100);
            panel1.TabIndex = 0;
            // 
            // buttonAñadir
            // 
            buttonAñadir.Enabled = false;
            buttonAñadir.FlatStyle = FlatStyle.Flat;
            buttonAñadir.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAñadir.ForeColor = Color.White;
            buttonAñadir.Location = new Point(835, 32);
            buttonAñadir.Name = "buttonAñadir";
            buttonAñadir.Size = new Size(109, 44);
            buttonAñadir.TabIndex = 2;
            buttonAñadir.Text = "Añadir";
            buttonAñadir.UseVisualStyleBackColor = true;
            buttonAñadir.Click += buttonAñadir_Click;
            // 
            // comboBoxProductos
            // 
            comboBoxProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProductos.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxProductos.FormattingEnabled = true;
            comboBoxProductos.Location = new Point(405, 43);
            comboBoxProductos.Name = "comboBoxProductos";
            comboBoxProductos.Size = new Size(338, 33);
            comboBoxProductos.TabIndex = 1;
            comboBoxProductos.SelectedIndexChanged += comboBoxProductos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(405, 15);
            label2.Name = "label2";
            label2.Size = new Size(191, 25);
            label2.TabIndex = 0;
            label2.Text = "Seleccionar producto";
            // 
            // comboBoxProveedores
            // 
            comboBoxProveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProveedores.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxProveedores.FormattingEnabled = true;
            comboBoxProveedores.Location = new Point(17, 43);
            comboBoxProveedores.Name = "comboBoxProveedores";
            comboBoxProveedores.Size = new Size(365, 33);
            comboBoxProveedores.TabIndex = 1;
            comboBoxProveedores.SelectedIndexChanged += comboBoxProveedores_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(201, 25);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar proveedor";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Producto, Cantidad, Subtotal });
            dataGridView1.Location = new Point(11, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(942, 330);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.ForeColor = Color.White;
            labelTotal.Location = new Point(693, 518);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(82, 30);
            labelTotal.TabIndex = 2;
            labelTotal.Text = "Total: $";
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(933, 557);
            button2.Name = "button2";
            button2.Size = new Size(104, 47);
            button2.TabIndex = 4;
            button2.Text = "Siguiente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 557);
            button1.Name = "button1";
            button1.Size = new Size(103, 47);
            button1.TabIndex = 5;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(32, 147);
            panel2.Name = "panel2";
            panel2.Size = new Size(963, 368);
            panel2.TabIndex = 6;
            // 
            // FormNuevaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1049, 616);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelTotal);
            Controls.Add(panel1);
            Name = "FormNuevaCompra";
            Text = "FormNuevaCompra";
            Load += FormNuevaCompra_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonAñadir;
        private ComboBox comboBoxProductos;
        private Label label2;
        private ComboBox comboBoxProveedores;
        private Label label1;
        private DataGridView dataGridView1;
        private Label labelTotal;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private Button button2;
        private Button button1;
        private Panel panel2;
    }
}