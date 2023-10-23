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

        private void button1_Click(object sender, EventArgs e)
        {
            FormClienteNuevo formClienteNuevo = new FormClienteNuevo();
            formClienteNuevo.ShowDialog();
        }
    }
}
