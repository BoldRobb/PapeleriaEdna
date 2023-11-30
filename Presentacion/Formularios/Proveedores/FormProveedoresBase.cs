using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios.Proveedores
{
    public partial class FormProveedoresBase : Form
    {
        private Form activeForm;
        public FormProveedoresBase()
        {
            InitializeComponent();
        }
        private void FormProveedoresBase_Load(object sender, EventArgs e)
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
            OpenChildForm(new Formularios.Proveedores.FormRegistrarProvedor());
        }

        private void btnEliProv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Proveedores.FormEliminarProveedor());
        }

        private void btnConProv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Proveedores.FormConsultarProveedor());
        }

        private void btnModProv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Proveedores.FormModificarProveedor());
        }
    }
}
