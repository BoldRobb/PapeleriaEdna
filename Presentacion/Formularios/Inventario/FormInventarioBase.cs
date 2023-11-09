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

        private void button1_Click(object sender, EventArgs e)
        {
            EliminarCategoria eliminatecategory = new EliminarCategoria();
            eliminatecategory.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarCategoria modifyCategory = new ModificarCategoria();
            modifyCategory.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AgregarCategoria addCategory = new AgregarCategoria();
            addCategory.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AgregarProducto addProduct = new AgregarProducto();
            addProduct.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ModificarProducto modifyProduct = new ModificarProducto();
            modifyProduct.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ProductosExistencia seeProductsE = new ProductosExistencia();
            seeProductsE.Show();
        }
    }
}
