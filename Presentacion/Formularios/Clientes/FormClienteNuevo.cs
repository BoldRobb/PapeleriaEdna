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

namespace Presentacion.Formularios.Clientes
{
    public partial class FormClienteNuevo : Form
    {
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();

        public FormClienteNuevo()
        {
            connection = conexion.GetConnection();
            connection.Open();
            InitializeComponent();
            panel1.BackColor = ThemeColor.SecondaryColor;
            panel2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            panel3.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            textBoxApellidos.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxCURP.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxRFC.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxCorreo.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxName.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxApellidos.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxDireccion.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxTelefono.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            buttonAgregar.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            buttonVolver.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
        }



        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            labelApellido.Visible = false;
            labelCURP.Visible = false;
            labelRFC.Visible = false;
            labelTelefono.Visible = false;
            labelNombre.Visible = false;
            labelDireccion.Visible = false;
            labelCorreo.Visible = false;
            if (textBoxName.Text == " Nombre")
            {
                labelNombre.Text = "Favor de rellenar el campo";
                labelNombre.Visible = true;
            }
            if (textBoxRFC.Text == " RFC")
            {
                labelRFC.Text = "Favor de rellenar el campo";
                labelRFC.Visible = true;
            }
            if (textBoxApellidos.Text == " Apellidos")
            {
                labelApellido.Text = "Favor de rellenar el campo";
                labelApellido.Visible = true;
            }
            if (textBoxCURP.Text == " CURP")
            {
                labelCURP.Text = "Favor de rellenar el campo";
                labelCURP.Visible = true;
            }
            if (textBoxTelefono.Text == " Telefono")
            {
                labelTelefono.Text = "Favor de rellenar el campo";
                labelTelefono.Visible = true;
            }
            if (textBoxDireccion.Text == " Direccion")
            {
                labelDireccion.Text = "Favor de rellenar el campo";
                labelDireccion.Visible = true;
            }
            if (textBoxCorreo.Text == " Correo")
            {
                labelCorreo.Text = "Favor de rellenar el campo";
                labelCorreo.Visible = true;
            }
            if (textBoxCorreo.Text != " Correo" && textBoxDireccion.Text != " Direccion" && textBoxTelefono.Text != " Telefono" && textBoxCURP.Text != " CURP" && textBoxApellidos.Text != " Apellidos"
                && textBoxRFC.Text != " RFC" && textBoxName.Text != " Nombre")
            {
                SqlCommand aggCmd = new SqlCommand("insert into Clientes values (@Nombre, @Apellido); SELECT SCOPE_IDENTITY();", connection);

                aggCmd.Parameters.AddWithValue("@Nombre", textBoxName.Text);
                aggCmd.Parameters.AddWithValue("@Apellido", textBoxApellidos.Text);
                object result = aggCmd.ExecuteScalar();
                int id_cliente = Convert.ToInt32(result);

                SqlCommand agg_detallesCmd = new SqlCommand("insert into Cliente_Detalles values (@ID, @Direccion, @Telefono, @Correo, @CURP, @RFC)", connection);

                agg_detallesCmd.Parameters.AddWithValue("@ID", id_cliente);
                agg_detallesCmd.Parameters.AddWithValue("@Direccion", textBoxDireccion.Text);
                agg_detallesCmd.Parameters.AddWithValue("@Telefono", textBoxTelefono.Text);
                agg_detallesCmd.Parameters.AddWithValue("@Correo", textBoxCorreo.Text);
                agg_detallesCmd.Parameters.AddWithValue("@CURP", textBoxCURP.Text);
                agg_detallesCmd.Parameters.AddWithValue("@RFC", textBoxRFC.Text);

                agg_detallesCmd.ExecuteNonQuery();
                MessageBox.Show("Cliente agregado correctamente");
                textBoxApellidos.Text = " Apellidos";
                textBoxCorreo.Text = " Correo";
                textBoxCURP.Text = " CURP";
                textBoxDireccion.Text = " Direccion";
                textBoxName.Text = " Nombre";
                textBoxRFC.Text = " RFC";
                textBoxTelefono.Text = " Telefono";

            }
            else
            {
                MessageBox.Show("Fallo al agregar el cliente");
            }

        }


        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == " Nombre")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;

            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = " Nombre";
                textBoxName.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBoxName.ForeColor = Color.Black;
            }
        }

        private void textBoxApellidos_Enter(object sender, EventArgs e)
        {
            if (textBoxApellidos.Text == " Apellidos")
            {
                textBoxApellidos.Text = "";
                textBoxApellidos.ForeColor = Color.Black;

            }
        }

        private void textBoxApellidos_Leave(object sender, EventArgs e)
        {
            if (textBoxApellidos.Text == "")
            {
                textBoxApellidos.Text = " Apellidos";
                textBoxApellidos.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBoxApellidos.ForeColor = Color.Black;
            }
        }
        private void textBoxRFC_Enter(object sender, EventArgs e)
        {
            if (textBoxRFC.Text == " RFC")
            {
                textBoxRFC.Text = "";
                textBoxRFC.ForeColor = Color.Black;

            }
        }

        private void textBoxRFC_Leave(object sender, EventArgs e)
        {
            if (textBoxRFC.Text == "")
            {
                textBoxRFC.Text = " RFC";
                textBoxRFC.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBoxRFC.ForeColor = Color.Black;
            }
        }
        private void textBoxCURP_Enter(object sender, EventArgs e)
        {
            if (textBoxCURP.Text == " CURP")
            {
                textBoxCURP.Text = "";
                textBoxCURP.ForeColor = Color.Black;

            }
        }

        private void textBoxCURP_Leave(object sender, EventArgs e)
        {
            if (textBoxCURP.Text == "")
            {
                textBoxCURP.Text = " CURP";
                textBoxCURP.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBoxCURP.ForeColor = Color.Black;
            }
        }
        private void textBoxDireccion_Enter(object sender, EventArgs e)
        {
            if (textBoxDireccion.Text == " Direccion")
            {
                textBoxDireccion.Text = "";
                textBoxDireccion.ForeColor = Color.Black;

            }
        }

        private void textBoxDireccion_Leave(object sender, EventArgs e)
        {
            if (textBoxDireccion.Text == "")
            {
                textBoxDireccion.Text = " Direccion";
                textBoxDireccion.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBoxDireccion.ForeColor = Color.Black;
            }
        }
        private void textBoxTelefono_Enter(object sender, EventArgs e)
        {
            if (textBoxTelefono.Text == " Telefono")
            {
                textBoxTelefono.Text = "";
                textBoxTelefono.ForeColor = Color.Black;

            }
        }

        private void textBoxTelefono_Leave(object sender, EventArgs e)
        {
            if (textBoxTelefono.Text == "")
            {
                textBoxTelefono.Text = " Telefono";
                textBoxTelefono.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBoxTelefono.ForeColor = Color.Black;
            }
        }
        private void textBoxCorreo_Enter(object sender, EventArgs e)
        {
            if (textBoxCorreo.Text == " Correo")
            {
                textBoxCorreo.Text = "";
                textBoxCorreo.ForeColor = Color.Black;

            }
        }

        private void textBoxCorreo_Leave(object sender, EventArgs e)
        {
            if (textBoxCorreo.Text == "")
            {
                textBoxCorreo.Text = " Correo";
                textBoxCorreo.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBoxCorreo.ForeColor = Color.Black;
            }
        }
    }
}
