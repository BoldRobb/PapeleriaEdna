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
    public partial class FormModificarCliente : Form
    {
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        public FormModificarCliente()
        {
            connection = conexion.GetConnection();
            InitializeComponent();
            this.BackColor = ThemeColor.SecondaryColor;
            panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            panel2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            comboBoxClientes.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxApellidos.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxNombre.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxCURP.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxRFC.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxCorreo.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxDireccion.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxTelefono.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
        }
        private int ObtenerNumeroClientesDesdeBaseDeDatos(SqlConnection connection)
        {
            int numClientes = 0;
            string query = "SELECT COUNT(*) FROM Clientes";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                numClientes = (int)command.ExecuteScalar();
            }
            return numClientes;
        }

        private List<string> ObtenerNombresClientesDesdeBaseDeDatos(SqlConnection connection, int numClientes)
        {
            List<string> nombresClientes = new List<string>();
            string query = "SELECT Apellido FROM Clientes";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombreCategoria = reader["Apellido"].ToString();
                        nombresClientes.Add(nombreCategoria);
                    }
                }
            }
            return nombresClientes;
        }
        private void LeerInfoClientes()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = conexion.GetConnection();
                connection.Open();
            }

            using (connection)
            {


                int numClientes = ObtenerNumeroClientesDesdeBaseDeDatos(connection);


                List<string> nombresCategorias = ObtenerNombresClientesDesdeBaseDeDatos(connection, numClientes);


                comboBoxClientes.DataSource = nombresCategorias;
                comboBoxClientes.DisplayMember = "Nombre";

            }
            connection.Close();
            textBoxApellidos.Text = "";
            textBoxCorreo.Text = "";
            textBoxCURP.Text = "";
            textBoxDireccion.Text = "";
            textBoxNombre.Text = "";
            textBoxRFC.Text = "";
            textBoxTelefono.Text = "";
        }
        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = conexion.GetConnection();
                connection.Open();
            }

            int id_cliente;
            var clienteSeleccionado = (String)comboBoxClientes.SelectedItem;

            string query = "SELECT ID_Cliente, Nombre, Apellido FROM Clientes where Apellido = @Apellido";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Apellido", clienteSeleccionado);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBoxNombre.Text = reader.GetString(1);
                        textBoxApellidos.Text = reader.GetString(2);
                    }

                }
                reader.Close();


            }
            query = "SELECT ID_Cliente from Clientes where Apellido = @Apellido;";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Apellido", clienteSeleccionado);
                object result = command.ExecuteScalar();
                id_cliente = (int)result;

            }

            query = "SELECT Direccion, Telefono, Correo, CURP, RFC FROM Cliente_Detalles where ID_Cliente = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", id_cliente);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBoxDireccion.Text = reader.GetString(0);
                        textBoxTelefono.Text = reader.GetString(1);
                        textBoxCorreo.Text = reader.GetString(2);
                        textBoxCURP.Text = reader.GetString(3);
                        textBoxRFC.Text = reader.GetString(4);
                    }

                }
                reader.Close();
            }
        }

        private void FormModificarCliente_Load(object sender, EventArgs e)
        {
            LeerInfoClientes();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = conexion.GetConnection();
                connection.Open();
            }
            int id_cliente;
            string query = "SELECT ID_Cliente from Clientes where Apellido = @Apellido;";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                var clienteSeleccionado = (String)comboBoxClientes.SelectedItem;
                command.Parameters.AddWithValue("@Apellido", clienteSeleccionado);
                object result = command.ExecuteScalar();
                id_cliente = (int)result;

            }
            query = "UPDATE Clientes SET Nombre = @Nombre, Apellido=@Apellidos WHERE ID_Cliente = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nombre", textBoxNombre.Text);
                command.Parameters.AddWithValue("@Apellidos", textBoxApellidos.Text);
                command.Parameters.AddWithValue("@ID", id_cliente);
                command.ExecuteNonQuery();
            }
            query = "UPDATE Cliente_Detalles SET Direccion = @Direccion, Correo=@Correo, Telefono = @Telefono, CURP = @CURP, RFC = @RFC WHERE ID_Cliente = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@Direccion", textBoxDireccion.Text);
                command.Parameters.AddWithValue("@Correo", textBoxCorreo.Text);
                command.Parameters.AddWithValue("@Telefono", textBoxTelefono.Text);
                command.Parameters.AddWithValue("@CURP", textBoxCURP.Text);
                command.Parameters.AddWithValue("@RFC", textBoxRFC.Text);
                command.Parameters.AddWithValue("@ID", id_cliente);
                command.ExecuteNonQuery();
            }
            LeerInfoClientes();
            MessageBox.Show("Se ha modificado el cliente correctamente");
        }
    }
}
