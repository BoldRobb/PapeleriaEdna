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
            textBoxApellido.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxCargo.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxCURP.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxDireccion.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxNombre.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxNumTel.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            buttonVolver.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            buttonEliminar.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            comboBoxEmpleados.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
        }


        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

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

        private void FormEliminarEmpleados_Load(object sender, EventArgs e)
        {
            LeerInfoEmpleados();
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

            int ID_Empleado;
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

            query = "SELECT Dirección, Telefono, Correo, CURP, Cargo FROM Detalles_Empleados where ID_Empleado = @ID";
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

                    }

                }
                reader.Close();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = conexion.GetConnection();
                connection.Open();
            }
            int id_empleado;
            string query = "SELECT ID_Empleado from Empleados where Apellido = @Apellido;";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                var empleadosSeleccionado = (String)comboBoxEmpleados.SelectedItem;
                command.Parameters.AddWithValue("@Apellido", empleadosSeleccionado);
                object result = command.ExecuteScalar();
                id_empleado = (int)result;

            }
            query = "DELETE FROM Detalles_Empleados Where ID_Empleado = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@ID", id_empleado);
                command.ExecuteNonQuery();
            }
            query = "DELETE FROM Empleados Where ID_Empleado = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@ID", id_empleado);
                command.ExecuteNonQuery();
            }
            LeerInfoEmpleados();
            MessageBox.Show("Se ha eliminado al empleado correctamente");
        }



    }
}
