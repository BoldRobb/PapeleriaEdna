using Presentacion.Formularios.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios.Egresos
{
    public partial class FormEgresosBase : Form
    {
        private Form activeForm;
        public FormEgresosBase()
        {

            InitializeComponent();
        }
        private void FormEgresosBase_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }
        private void LoadTheme()
        {
            panel1.BackColor = ThemeColor.SecondaryColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PagosFijos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PagoEmpleados());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EliminarRegistro());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ConsultarRegistro());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GenerarReporte());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PagoProveedores());
        }
    }
}
