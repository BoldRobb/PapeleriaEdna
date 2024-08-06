using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios.Ventas
{
    public partial class FormVentasBase : Form
    {
        public FormVentasBase()
        {
            InitializeComponent();
        }
        private void FormVentasBase_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            panel1.BackColor = ThemeColor.SecondaryColor;


        }
<<<<<<< Updated upstream
=======
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

        private void buttonAddVent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Ventas.FormVentaNueva());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Ventas.FormVerVentas());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Ventas.FormReporte());
        }
>>>>>>> Stashed changes
    }
}
