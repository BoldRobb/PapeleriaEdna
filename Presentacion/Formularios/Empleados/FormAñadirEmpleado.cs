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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion.Formularios.Empleados
{
    public partial class FormAñadirEmpleado : Form
    {

        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();

        public FormAñadirEmpleado()
        {
            connection = conexion.GetConnection();
            connection.Open();
            InitializeComponent();
            panel1.BackColor = ThemeColor.SecondaryColor;
            panel2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            textBoxName.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxNumTel.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxCorreo.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxApellido.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxDireccion.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxCurp.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            buttonAgregar.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            buttonVolver.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);

            comboBoxCargo.Items.Add("Gerente");
            comboBoxCargo.Items.Add("Almacenista");
            comboBoxCargo.Items.Add("Encargado de ventas");
            comboBoxCargo.Items.Add("Encargado de compras");
            comboBoxCargo.Items.Add("Personal de limpieza");

            comboBoxGenero.Items.Add("Femenino");
            comboBoxGenero.Items.Add("Masculino");
            comboBoxGenero.Items.Add("Otro");


        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {


            if (textBoxName.Text == "Nombre")
            {
                MessageBox.Show("El campo Nombre está vacío");
            }
            if (textBoxCorreo.Text == "Correo electronico")
            {
                MessageBox.Show("El campo Correo está vacío");
            }
            if (textBoxCurp.Text == "CURP")
            {
                MessageBox.Show("El campo CURP está vacío");
            }
            if (textBoxDireccion.Text == "Dirección")
            {
                MessageBox.Show("El campo Dirección está vacío");
            }
            if (textBoxNumTel.Text == "Numero telefonico")
            {
                MessageBox.Show("El campo Numero telefonico está vacío");
            }

            if (textBoxCorreo.Text != " Correo" && textBoxDireccion.Text != " Direccion" && textBoxNumTel.Text != " Telefono" && textBoxCurp.Text != " CURP" && textBoxName.Text != " Nombre")
            {
                SqlCommand aggCmd = new SqlCommand("insert into Empleados values (@Nombre, @Apellido, @Genero); SELECT SCOPE_IDENTITY();", connection);

                aggCmd.Parameters.AddWithValue("@Nombre", textBoxName.Text);
                aggCmd.Parameters.AddWithValue("@Apellido", textBoxApellido.Text);
                aggCmd.Parameters.AddWithValue("@Genero", comboBoxGenero.Text);
                object result = aggCmd.ExecuteScalar();
                int id_cliente = Convert.ToInt32(result);

                SqlCommand agg_detallesCmd = new SqlCommand("insert into Detalles_Empleados values (@ID_Empleado, @Cargo, @Correo, @Pago, @Fecba_proximo_pago, @Dirección, @CURP, @Telefono)", connection);

                agg_detallesCmd.Parameters.AddWithValue("@ID_Empleado", id_cliente);
                agg_detallesCmd.Parameters.AddWithValue("@Cargo", comboBoxCargo.Text);
                agg_detallesCmd.Parameters.AddWithValue("@Correo", textBoxCorreo.Text);
                agg_detallesCmd.Parameters.AddWithValue("@Pago", 123.123);
                agg_detallesCmd.Parameters.AddWithValue("@Fecba_proximo_pago", "12/12/12");
                agg_detallesCmd.Parameters.AddWithValue("@Dirección", textBoxDireccion.Text);
                agg_detallesCmd.Parameters.AddWithValue("@CURP", textBoxCurp.Text);
                agg_detallesCmd.Parameters.AddWithValue("@Telefono", textBoxNumTel.Text);




                agg_detallesCmd.ExecuteNonQuery();
                MessageBox.Show("Cliente agregado correctamente");
                textBoxApellido.Text = " Apellidos";
                textBoxCorreo.Text = " Correo";
                textBoxCurp.Text = " CURP";
                textBoxDireccion.Text = " Direccion";
                textBoxName.Text = " Nombre";
                textBoxNumTel.Text = " Telefono";

            }
            else
            {
                MessageBox.Show("Fallo al agregar el cliente");
            }




        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Nombre")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;

            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = "Nombre";
                textBoxName.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBoxName.ForeColor = Color.Black;
            }
        }

        private void textBoxApellido_Enter(object sender, EventArgs e)
        {
            if (textBoxApellido.Text == "Apellidos")
            {
                textBoxApellido.Text = "";
                textBoxApellido.ForeColor = Color.Black;

            }
        }

        private void textBoxApellido_Leave(object sender, EventArgs e)
        {
            if (textBoxApellido.Text == "")
            {
                textBoxApellido.Text = "Apellidos";
                textBoxApellido.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBoxApellido.ForeColor = Color.Black;
            }
        }

        private void textBoxNumTel_Enter(object sender, EventArgs e)
        {
            if (textBoxNumTel.Text == "Telefono")
            {
                textBoxNumTel.Text = "";
                textBoxNumTel.ForeColor = Color.Black;

            }
        }

        private void textBoxNumTel_Leave(object sender, EventArgs e)
        {
            if (textBoxNumTel.Text == "")
            {
                textBoxNumTel.Text = "Telefono";
                textBoxNumTel.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBoxNumTel.ForeColor = Color.Black;
            }
        }
    }
}
