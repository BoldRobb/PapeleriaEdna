using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios.Inventario
{
    public partial class FormInventarioBase : Form
    {
        private Form activeForm;
        public FormInventarioBase()
        {
            InitializeComponent();
        }
        private void FormInventarioBase_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AgregarCategoria());
        }


        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ModificarCategoria());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EliminarCategoria());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AgregarProducto());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ModificarProducto());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductosExistencia());
        }

        //CONSULTAR NVENTARIO
        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ConsultarInventario());
        }

        //ELIMINAR PRODUCTO
        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EliminarProducto());
        }

        //PRODUCTOS AGOTADOS
        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductosAgotados());
        }
    }
}
