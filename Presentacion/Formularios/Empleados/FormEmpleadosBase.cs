using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios.Empleados
{
    public partial class FormEmpleadosBase : Form
    {
        private Form activeForm;
        public FormEmpleadosBase()
        {
            InitializeComponent();
        }
        private void FormEmpleadosBase_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            panel1.BackColor = ThemeColor.SecondaryColor;


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

        private void btnRegProv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Empleados.FormAñadirEmpleado());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Empleados.FormModificarEmpleado());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Empleados.FormVerEmpleado());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Empleados.FormEliminarEmpleado());
        }
    }
}
