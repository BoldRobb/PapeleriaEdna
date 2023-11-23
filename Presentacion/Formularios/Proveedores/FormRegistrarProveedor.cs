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

namespace Presentacion.Formularios.Proveedores
{
    public partial class FormRegistrarProvedor : Form
    {

        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();

        public FormRegistrarProvedor()
        {
            connection = conexion.GetConnection();
            connection.Open();
            InitializeComponent();
            panel1.BackColor = ThemeColor.SecondaryColor;
            panel2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            textBoxNombre.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxNumTel.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxCorreo.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxDireccion.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            buttonAgregar.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            buttonVolver.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "Nombre")
            {
                MessageBox.Show("El campo Nombre está vacío");
            }
            if (textBoxCorreo.Text == "Correo")
            {
                MessageBox.Show("El campo Correo está vacío");
            }
            if (textBoxDireccion.Text == "Dirección")
            {
                MessageBox.Show("El campo Dirección está vacío");
            }
            if (textBoxNumTel.Text == "Telefono")
            {
                MessageBox.Show("El campo Numero telefonico está vacío");
            }


            if (textBoxCorreo.Text != "Correo" && textBoxDireccion.Text != "Direccion" && textBoxNumTel.Text != "Telefono" && textBoxNombre.Text != "Nombre")
            {
                SqlCommand aggCmd = new SqlCommand("insert into Proveedores values (@Nombre); SELECT SCOPE_IDENTITY();", connection);

                aggCmd.Parameters.AddWithValue("@Nombre", textBoxNombre.Text);
                object result = aggCmd.ExecuteScalar();
                int id_cliente = Convert.ToInt32(result);

                SqlCommand agg_detallesCmd = new SqlCommand("insert into Proveedores_Detalles values (@ID_Proveedor, @Direccion, @Telefono, @Correo)", connection);

                agg_detallesCmd.Parameters.AddWithValue("@ID_Proveedor", id_cliente);
                agg_detallesCmd.Parameters.AddWithValue("@Direccion", textBoxDireccion.Text);
                agg_detallesCmd.Parameters.AddWithValue("@Correo", textBoxCorreo.Text);
                agg_detallesCmd.Parameters.AddWithValue("@Telefono", textBoxNumTel.Text);




                agg_detallesCmd.ExecuteNonQuery();
                MessageBox.Show("Cliente agregado correctamente");
                textBoxCorreo.Text = "Correo";
                textBoxDireccion.Text = "Direccion";
                textBoxNombre.Text = "Nombre";
                textBoxNumTel.Text = "Telefono";

            }
            else
            {
                MessageBox.Show("Fallo al agregar el Proveedor");
            }

        }

        private void textBoxNombre_Enter(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "Nombre")
            {
                textBoxNombre.Text = "";
                textBoxNombre.ForeColor = Color.Black;

            }
        }

        private void textBoxNombre_Leave(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "")
            {
                textBoxNombre.Text = "Nombre";
                textBoxNombre.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBoxNombre.ForeColor = Color.Black;
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
                textBoxNumTel.ForeColor = Color.Black;
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
    }
}
