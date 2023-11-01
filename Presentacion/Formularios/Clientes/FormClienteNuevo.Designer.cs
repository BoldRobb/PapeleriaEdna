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
            buttonCerrar = new Button();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonCerrar);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 616);
            panel1.TabIndex = 0;
            // 
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Button buttonCerrar;
        private Label label1;
    }
}