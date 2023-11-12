using Microsoft.Data.SqlClient;
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
    public partial class FormEliminarEmpleado : Form
    {

        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();

        public FormEliminarEmpleado()
        {
            connection = conexion.GetConnection();
            connection.Open();
            InitializeComponent();
            panel1.BackColor = ThemeColor.SecondaryColor;
            panel3.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            panel2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            textBoxCorreo.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxDireccion.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxNombre.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxNumTel.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            buttonVolver.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            buttonEliminar.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
