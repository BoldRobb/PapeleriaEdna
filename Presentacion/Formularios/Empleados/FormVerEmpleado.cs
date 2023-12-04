using Microsoft.Data.SqlClient;
using System;
using System.Collections;
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
        int ID_Empleado;

        public FormVerEmpleado()
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
            textBoxCargo.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxApellido.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxCURP.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            buttonVolver.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            comboBoxEmpleados.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxEstatus.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            button1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
        }




        private int ObtenerNumeroEmpleadosDesdeBaseDeDatos(SqlConnection connection)
        {
            int numEmpleados = 0;
            string query = "SELECT COUNT(*) FROM Empleados";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                numEmpleados = (int)command.ExecuteScalar();
            }
            return numEmpleados;
        }

        private List<string> ObtenerNombresEmpleadosDesdeBaseDeDatos(SqlConnection connection, int numEmpleados)
        {
            List<string> nombresEmpleados = new List<string>();
            string query = "SELECT Apellido FROM Empleados";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombreEmpleado = reader["Apellido"].ToString();
                        nombresEmpleados.Add(nombreEmpleado);
                    }
                }
            }
            return nombresEmpleados;
        }

        private void FormVerEmpleado_Load(object sender, EventArgs e)
        {
            LeerInfoEmpleados();
            button1.Visible = false;
        }

        private void LeerInfoEmpleados()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = conexion.GetConnection();
                connection.Open();
            }

            using (connection)
            {

                int numEmpleados = ObtenerNumeroEmpleadosDesdeBaseDeDatos(connection);


                List<string> nombresCategorias = ObtenerNombresEmpleadosDesdeBaseDeDatos(connection, numEmpleados);


                comboBoxEmpleados.DataSource = nombresCategorias;
                comboBoxEmpleados.DisplayMember = "Nombre";

            }
            connection.Close();
            textBoxCorreo.Text = "";
            textBoxCURP.Text = "";
            textBoxDireccion.Text = "";
            textBoxNombre.Text = "";
            textBoxNumTel.Text = "";
            textBoxApellido.Text = "";
            textBoxCargo.Text = "";
        }

        private void comboBoxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = conexion.GetConnection();
                connection.Open();
            }

            
            var empleadoSeleccionado = (String)comboBoxEmpleados.SelectedItem;

            string query = "SELECT ID_Empleado, Nombre, Apellido FROM Empleados where Apellido = @Apellido; SELECT SCOPE_IDENTITY();";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Apellido", empleadoSeleccionado);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBoxNombre.Text = reader.GetString(1);
                        textBoxApellido.Text = reader.GetString(2);
                    }

                }
                reader.Close();


            }
            query = "SELECT ID_Empleado from Empleados where Apellido = @Apellido;";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Apellido", empleadoSeleccionado);
                object result = command.ExecuteScalar();
                ID_Empleado = (int)result;

            }

            query = "SELECT Dirección, Telefono, Correo, CURP, Cargo, Estatus FROM Detalles_Empleados where ID_Empleado = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", ID_Empleado);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        textBoxCorreo.Text = reader.GetString(2);
                        textBoxCURP.Text = reader.GetString(3);
                        textBoxDireccion.Text = reader.GetString(0);
                        textBoxNumTel.Text = reader.GetString(1);
                        textBoxCargo.Text = reader.GetString(4);
                        textBoxEstatus.Text = reader.GetString(5);

                    }

                }
                reader.Close();
            }

            if (textBoxEstatus.Text == "Activo")
            {
                button1.Visible = false;
            }
            else if (textBoxEstatus.Text == "Inactivo")
            {
                button1.Visible = true;
            }

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = conexion.GetConnection();
                connection.Open();
            }

            string query = "UPDATE Detalles_Empleados SET Estatus = @Estatus WHERE ID_Empleado = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Estatus", "Activo");
                command.Parameters.AddWithValue("@ID", ID_Empleado);
                command.ExecuteNonQuery();
                MessageBox.Show("Empleado Reactivado.");
                textBoxEstatus.Text="Activo";

                button1.Visible=false;

            }

        }
    }
}
