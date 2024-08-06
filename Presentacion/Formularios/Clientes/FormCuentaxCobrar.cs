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
    public partial class FormCuentaxCobrar : Form
    {
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        int id_cliente;
        double disponiblenuevo;
        public FormCuentaxCobrar()
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
            textBoxCredito.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxPago.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            FormPagoDeudor pago = new FormPagoDeudor(id_cliente);
            if(pago.ShowDialog(this)== DialogResult.OK )
            {
                double pagado;
                pagado = pago.pago;
                disponiblenuevo += pagado;
                string query = "UPDATE Cliente_Deudor SET monto_disp = @NuevoMonto where Id_Cliente = @ID";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NuevoMonto", disponiblenuevo);
                    command.Parameters.AddWithValue("@ID", id_cliente);

                }
                MessageBox.Show("Pago realizado con exito");
            }
            else
            {
                MessageBox.Show("El pago no se ha realizado correctamente");
            }
        }


        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonPago.Enabled = true;
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
            query = "SELECT Monto_disp, Prox_pago FROM Cliente_Deudor where ID_Cliente = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", id_cliente);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        disponiblenuevo = reader.GetDouble(0);
                        textBoxCredito.Text = reader.GetDouble(0).ToString();
                        string texto = reader.GetDateTime(1).ToString();
                        texto = texto.Substring(0, 11);
                        textBoxPago.Text = texto;
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

        private void FormCuentaxCobrar_Load(object sender, EventArgs e)
        {
            LeerInfoClientes();
        }
    }
}
