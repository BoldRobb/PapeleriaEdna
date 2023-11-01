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
    public partial class FormClienteNuevo : Form
    {
        public FormClienteNuevo()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            panel1.BackColor = ThemeColor.SecondaryColor;


        }
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClienteNuevo_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
