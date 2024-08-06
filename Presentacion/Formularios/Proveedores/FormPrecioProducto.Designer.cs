namespace Presentacion.Formularios.Proveedores
{
    partial class FormPrecioProducto
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
            components = new System.ComponentModel.Container();
            buttonRealizar = new Button();
            panel1 = new Panel();
            textBoxProducto = new TextBox();
            label2 = new Label();
            textBoxPrecio = new TextBox();
            labelSubtotal = new Label();
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // buttonRealizar
            // 
            buttonRealizar.Enabled = false;
            buttonRealizar.FlatStyle = FlatStyle.Flat;
            buttonRealizar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRealizar.ForeColor = Color.White;
            buttonRealizar.Location = new Point(470, 270);
            buttonRealizar.Name = "buttonRealizar";
            buttonRealizar.Size = new Size(103, 47);
            buttonRealizar.TabIndex = 1;
            buttonRealizar.Text = "Realizar";
            buttonRealizar.UseVisualStyleBackColor = true;
            buttonRealizar.Click += buttonRealizar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxProducto);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxPrecio);
            panel1.Controls.Add(labelSubtotal);
            panel1.Location = new Point(24, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 203);
            panel1.TabIndex = 3;
            // 
            // textBoxProducto
            // 
            textBoxProducto.BorderStyle = BorderStyle.None;
            textBoxProducto.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProducto.ForeColor = Color.White;
            textBoxProducto.Location = new Point(159, 30);
            textBoxProducto.Name = "textBoxProducto";
            textBoxProducto.ReadOnly = true;
            textBoxProducto.Size = new Size(250, 29);
            textBoxProducto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 29);
            label2.Name = "label2";
            label2.Size = new Size(102, 30);
            label2.TabIndex = 0;
            label2.Text = "Producto:";
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.BorderStyle = BorderStyle.None;
            textBoxPrecio.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrecio.ForeColor = Color.White;
            textBoxPrecio.Location = new Point(159, 121);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(250, 29);
            textBoxPrecio.TabIndex = 1;
            textBoxPrecio.TextChanged += textBoxPrecio_TextChanged;
            // 
            // labelSubtotal
            // 
            labelSubtotal.AutoSize = true;
            labelSubtotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelSubtotal.ForeColor = Color.White;
            labelSubtotal.Location = new Point(23, 104);
            labelSubtotal.Name = "labelSubtotal";
            labelSubtotal.Size = new Size(105, 60);
            labelSubtotal.TabIndex = 0;
            labelSubtotal.Text = "Precio de \ncompra:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(236, 25);
            label1.TabIndex = 4;
            label1.Text = "Agrerar precio al producto";
            // 
            // FormPrecioProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(585, 334);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(buttonRealizar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrecioProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrecioProducto";
            Load += FormPrecioProducto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRealizar;
        private Panel panel1;
        private Label labelSubtotal;
        private TextBox textBoxPrecio;
        private TextBox textBoxProducto;
        private Label label2;
        private Label label1;
        private BindingSource bindingSource1;
    }
}