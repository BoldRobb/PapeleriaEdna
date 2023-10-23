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
    }
}
