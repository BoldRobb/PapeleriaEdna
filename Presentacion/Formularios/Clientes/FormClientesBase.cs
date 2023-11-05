using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios.Clientes
{
    public partial class FormClientesBase : Form
    {
        private Form activeForm;
        public FormClientesBase()
        {

            InitializeComponent();
        }

        private void FormClientesBase_Load(object sender, EventArgs e)
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

        private void buttonAggCli_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Clientes.FormClienteNuevo());
        }

        private void buttonDelClie_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Clientes.FormEliminarCliente());
        }

        private void buttonModClie_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Clientes.FormModificarCliente());
        }

        private void buttonVerClie_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Clientes.FormVerClientes());
        }

        private void buttonAggDeud_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Clientes.FormDeudorNuevo());
        }

        private void buttonDelDeud_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Clientes.FormEliminarDeudor());
        }

        private void buttonModDeud_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Clientes.FormModificarDeudor());
        }

        private void buttonVerDeud_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Clientes.FormVerDeudores());
        }



    }
}
