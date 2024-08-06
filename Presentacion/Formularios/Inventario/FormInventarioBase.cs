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
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.Show();
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
