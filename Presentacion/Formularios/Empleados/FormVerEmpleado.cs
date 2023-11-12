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
    public partial class FormVerEmpleado : Form
    {
        
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();

        public FormVerEmpleado()
        {
            connection = conexion.GetConnection();
            connection.Open();
            InitializeComponent();
            panel1.BackColor = ThemeColor.SecondaryColor;
            panel2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            textBoxName.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxNumTel.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxCorreo.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxDireccion.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxCurp.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            buttonVolver.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
        }
    }
}
