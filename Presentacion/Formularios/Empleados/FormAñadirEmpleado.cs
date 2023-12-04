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
            textBoxRFC.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            comboBoxCargo.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            comboBoxGenero.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            buttonAgregar.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            buttonVolver.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);



            comboBoxCargo.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxCargo.Items.Add("Gerente");
            comboBoxCargo.Items.Add("Almacenista");
            comboBoxCargo.Items.Add("Encargado de ventas");
            comboBoxCargo.Items.Add("Encargado de compras");
            comboBoxCargo.Items.Add("Personal de limpieza");


            comboBoxGenero.DropDownStyle = ComboBoxStyle.DropDownList;

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
            if (textBoxRFC.Text == "RFC")
            {
                MessageBox.Show("El campo Numero telefonico está vacío");
            }

            if (textBoxRFC.Text != "RFC" && textBoxCorreo.Text != "Correo" && textBoxDireccion.Text != "Direccion" && textBoxNumTel.Text != "Telefono" && textBoxCurp.Text != "CURP" && textBoxName.Text != "Nombre")
            {
                SqlCommand aggCmd = new SqlCommand("insert into Empleados values (@Nombre, @Apellido, @Genero); SELECT SCOPE_IDENTITY();", connection);

                aggCmd.Parameters.AddWithValue("@Nombre", textBoxName.Text);
                aggCmd.Parameters.AddWithValue("@Apellido", textBoxApellido.Text);
                aggCmd.Parameters.AddWithValue("@Genero", (string)comboBoxGenero.SelectedItem);
                object result = aggCmd.ExecuteScalar();
                int id_cliente = Convert.ToInt32(result);

                SqlCommand agg_detallesCmd = new SqlCommand("insert into Detalles_Empleados values (@ID_Empleado, @Cargo, @Correo, @Pago, @Fecba_proximo_pago, @Dirección, @CURP, @Telefono, @RFC)", connection);

                agg_detallesCmd.Parameters.AddWithValue("@ID_Empleado", id_cliente);
                agg_detallesCmd.Parameters.AddWithValue("@Cargo", comboBoxCargo.Text);
                agg_detallesCmd.Parameters.AddWithValue("@Correo", textBoxCorreo.Text);
                agg_detallesCmd.Parameters.AddWithValue("@Pago", 123.123);
                agg_detallesCmd.Parameters.AddWithValue("@Fecba_proximo_pago", "12/12/12");
                agg_detallesCmd.Parameters.AddWithValue("@Dirección", textBoxDireccion.Text);
                agg_detallesCmd.Parameters.AddWithValue("@CURP", textBoxCurp.Text);
                agg_detallesCmd.Parameters.AddWithValue("@Telefono", textBoxNumTel.Text);
                agg_detallesCmd.Parameters.AddWithValue("@RFC", textBoxRFC.Text);
                agg_detallesCmd.ExecuteNonQuery();


                //REGISTRAR USUARIO Y CONTRASEÑA PARA ACCEDER CON SU RESPECTIVA CUENTA
                SqlCommand agg_user = new SqlCommand("insert into Users values (@LoginName, @Password, @FirstName, @LastName, @Position, @Email)", connection);

                //SACAR SOLAMENTE UN NOMBRE DEL TEXTBOX NOMBRES
                string nombre = textBoxName.Text;
                string[] todo = nombre.Split(' ');
                nombre = todo[0];


                agg_user.Parameters.AddWithValue("@LoginName", nombre);
                agg_user.Parameters.AddWithValue("@Password", "abc123456");
                agg_user.Parameters.AddWithValue("@FirstName", textBoxName.Text);
                agg_user.Parameters.AddWithValue("@LastName", textBoxApellido.Text);
                agg_user.Parameters.AddWithValue("@Position", "Administrator");
                agg_user.Parameters.AddWithValue("@Email", textBoxCorreo.Text);

                agg_user.ExecuteNonQuery();

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

        private void textBoxCorreo_Enter(object sender, EventArgs e)
        {
            if (textBoxCorreo.Text == "Correo")
            {
                textBoxCorreo.Text = "";
                textBoxCorreo.ForeColor = Color.Black;

            }
        }

        private void textBoxCorreo_Leave(object sender, EventArgs e)
        {
            if (textBoxCorreo.Text == "")
            {
                textBoxCorreo.Text = "Correo";
                textBoxCorreo.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBoxCorreo.ForeColor = Color.Black;
            }
        }

        private void textBoxDireccion_Enter(object sender, EventArgs e)
        {
            if (textBoxDireccion.Text == "Dirección")
            {
                textBoxDireccion.Text = "";
                textBoxDireccion.ForeColor = Color.Black;

            }
        }

        private void textBoxDireccion_Leave(object sender, EventArgs e)
        {
            if (textBoxDireccion.Text == "")
            {
                textBoxDireccion.Text = "Dirección";
                textBoxDireccion.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBoxDireccion.ForeColor = Color.Black;
            }
        }

        private void textBoxCurp_Enter(object sender, EventArgs e)
        {
            if (textBoxCurp.Text == "CURP")
            {
                textBoxCurp.Text = "";
                textBoxCurp.ForeColor = Color.Black;

            }
        }

        private void textBoxCurp_Leave(object sender, EventArgs e)
        {
            if (textBoxCurp.Text == "")
            {
                textBoxCurp.Text = "CURP";
                textBoxCurp.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBoxCurp.ForeColor = Color.Black;
            }
        }

        private void textBoxRFC_Enter(object sender, EventArgs e)
        {
            if (textBoxRFC.Text == "RFC")
            {
                textBoxRFC.Text = "";
                textBoxRFC.ForeColor = Color.Black;

            }
        }

        private void textBoxRFC_Leave(object sender, EventArgs e)
        {
            if (textBoxRFC.Text == "")
            {
                textBoxRFC.Text = "RFC";
                textBoxRFC.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBoxRFC.ForeColor = Color.Black;
            }
        }
    }
}
