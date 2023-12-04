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
    public partial class FormModificarEmpleado : Form
    {

        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();

        public FormModificarEmpleado()
        {
            connection = conexion.GetConnection();
            connection.Open();
            InitializeComponent();
            panel1.BackColor = ThemeColor.SecondaryColor;
            panel2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            textBoxNombre.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxApellido.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxNumTel.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxCorreo.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxDireccion.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxCURP.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            buttonActualizar.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            buttonVolver.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            comboBoxEmpleados.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            comboBoxCargo.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            comboBoxGenero.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);



            comboBoxCargo.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxCargo.Items.Add("Administrador");
            comboBoxCargo.Items.Add("Gerente");
            comboBoxCargo.Items.Add("Encargado de Recursos Humanos");
            comboBoxCargo.Items.Add("Almacenista");
            comboBoxCargo.Items.Add("Encargado de ventas");
            comboBoxCargo.Items.Add("Encargado de compras");
            comboBoxCargo.Items.Add("Personal de limpieza");


            comboBoxGenero.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxGenero.Items.Add("Femenino");
            comboBoxGenero.Items.Add("Masculino");
            comboBoxGenero.Items.Add("Otro");



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


        private void FormModificarEmpleado_Load(object sender, EventArgs e)
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

                    }

                }


                reader.Close();

            }


            /* 
             
            comboBoxCargo.Items.Add("Administrador");
            comboBoxCargo.Items.Add("Gerente");
            comboBoxCargo.Items.Add("Encargado de Recursos Humanos");
            comboBoxCargo.Items.Add("Almacenista");
            comboBoxCargo.Items.Add("Encargado de ventas");
            comboBoxCargo.Items.Add("Encargado de compras");
            comboBoxCargo.Items.Add("Personal de limpieza");
             
             */

            query = "SELECT Cargo From Detalles_Empleados WHERE ID_Empleado = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", ID_Empleado);

                string valorCargo = (string)command.ExecuteScalar();

                if (valorCargo == "Administrador")
                {
                    comboBoxCargo.SelectedIndex = 0;
                }
                else if (valorCargo == "Gerente")
                {
                    comboBoxCargo.SelectedIndex = 1;
                }
                else if (valorCargo == "Encargado de Recursos Humanos")
                {
                    comboBoxCargo.SelectedIndex = 2;
                }
                else if (valorCargo == "Almacenista")
                {
                    comboBoxCargo.SelectedIndex = 3;
                }
                else if (valorCargo == "Encargado de ventas")
                {
                    comboBoxCargo.SelectedIndex = 4;
                }
                else if (valorCargo == "Encargado de compras")
                {
                    comboBoxCargo.SelectedIndex = 5;
                }
                else if (valorCargo == "Personal de limpieza")
                {
                    comboBoxCargo.SelectedIndex = 6;
                }
            }




            query = "SELECT Genero From Empleados WHERE ID_Empleado = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", ID_Empleado);

                string valorCargo = (string)command.ExecuteScalar();

                if (valorCargo == "Femenino            ")
                {
                    comboBoxGenero.SelectedIndex = 0;
                }
                else if (valorCargo == "Masculino           ")
                {
                    comboBoxGenero.SelectedIndex = 1;
                }
                else if (valorCargo == "Otro                ")
                {
                    comboBoxGenero.SelectedIndex = 2;
                }
                else
                {
                    MessageBox.Show(valorCargo);
                }
            }


        }



        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = conexion.GetConnection();
                connection.Open();
            }
            int id_cliente;
            string query = "SELECT ID_Empleado from Empleados where Apellido = @Apellido;";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                var clienteSeleccionado = (String)comboBoxEmpleados.SelectedItem;
                command.Parameters.AddWithValue("@Apellido", clienteSeleccionado);
                object result = command.ExecuteScalar();
                id_cliente = (int)result;

            }
            query = "UPDATE Empleados SET Nombre = @Nombre, Apellido=@Apellidos, Genero=@Genero WHERE ID_Empleado = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nombre", textBoxNombre.Text);
                command.Parameters.AddWithValue("@Apellidos", textBoxApellido.Text);
                command.Parameters.AddWithValue("@Genero", comboBoxGenero.Text);
                command.Parameters.AddWithValue("@ID", id_cliente);
                command.ExecuteNonQuery();
            }
            query = "UPDATE Detalles_Empleados SET Dirección = @Direccion, Correo=@Correo, Telefono = @Telefono, CURP = @CURP, Cargo=@Cargo WHERE ID_Empleado = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@Direccion", textBoxDireccion.Text);
                command.Parameters.AddWithValue("@Correo", textBoxCorreo.Text);
                command.Parameters.AddWithValue("@Telefono", textBoxNumTel.Text);
                command.Parameters.AddWithValue("@CURP", textBoxCURP.Text);
                command.Parameters.AddWithValue("@Cargo", comboBoxCargo.Text);
                command.Parameters.AddWithValue("@ID", id_cliente);




                command.ExecuteNonQuery();
            }
            LeerInfoEmpleados();
            MessageBox.Show("Se ha modificado el empleado correctamente");
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
