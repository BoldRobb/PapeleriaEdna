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
    public partial class FormEliminarDeudor : Form
    {
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        int id_cliente;
        public FormEliminarDeudor()
        {
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

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string query = "SELECT monto_prox FROM Cliente_Deudor where ID_Cliente = @ID";
            double deuda;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", id_cliente);

                deuda = (double)command.ExecuteScalar();


            }
            if(deuda == 0)
            {
                if (MessageBox.Show("¿Desea Eliminar del plan de credito al cliente?", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "DELETE FROM Cliente_Deudor Where ID_Cliente = @ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ID", id_cliente);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("El plan ha sido eliminado con exito");
                    LeerInfoClientes();
                }
            }
            else
            {
                MessageBox.Show("El cliente cuenta con una deuda de: " + deuda + "; Favor de realizar el pago antes de eliminar");
            }
        }

        private void FormEliminarDeudor_Load(object sender, EventArgs e)
        {
            LeerInfoClientes();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEliminar.Enabled = true;
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = conexion.GetConnection();
                connection.Open();
            }


            var clienteSeleccionado = (String)comboBoxClientes.SelectedItem;

            string query = "SELECT ID_Cliente, Nombre, Apellido FROM Clientes where Apellido = @Apellido; SELECT SCOPE_IDENTITY();";
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
        private List<string> ObtenerNombresClientesDesdeBaseDeDatos(SqlConnection connection)
        {
            List<string> nombresClientes = new List<string>();
            string query = "SELECT clientes.Apellido FROM clientes INNER JOIN cliente_deudor ON clientes.id_cliente = cliente_deudor.id_cliente;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombreCliente = reader["Apellido"].ToString();
                        nombresClientes.Add(nombreCliente);
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


                List<string> nombresCategorias = ObtenerNombresClientesDesdeBaseDeDatos(connection);


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
    }
}
