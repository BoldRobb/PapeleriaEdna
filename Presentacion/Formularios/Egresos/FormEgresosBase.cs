using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios.Egresos
{
    public partial class FormEgresosBase : Form
    {
        public FormEgresosBase()
        {
            InitializeComponent();
        }
        private void FormEgresosBase_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            panel1.BackColor = ThemeColor.SecondaryColor;
        }
    }
}
