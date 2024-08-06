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
    public partial class FormDeudorNuevo : Form
    {
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        int id_cliente;
        public FormDeudorNuevo()
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

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = conexion.GetConnection();
                connection.Open();
            }


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

        private void FormDeudorNuevo_Load(object sender, EventArgs e)
        {
            LeerInfoClientes();
        }
        private List<string> ObtenerNombresClientesDesdeBaseDeDatos(SqlConnection connection)
        {
            List<string> nombresClientes = new List<string>();
            string query = "SELECT Apellido FROM Clientes WHERE NOT EXISTS (" +
                "SELECT 1 FROM Cliente_Deudor WHERE Cliente_Deudor.ID_Cliente = Clientes.ID_Cliente)";

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


                List<string> nombresCategorias = ObtenerNombresClientesDesdeBaseDeDatos(connection);

                comboBoxClientes.DataSource = nombresCategorias;
                comboBoxClientes.DisplayMember = "Apellidos";

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

        private void buttonSeguir_Click(object sender, EventArgs e)
        {
            float credito;
            string plan;
            DateTime prox;
            FormDeudorPlanes planes = new FormDeudorPlanes();
            if (planes.ShowDialog(this) == DialogResult.OK)
            {
                credito = planes.credito;
                plan = planes.opc;
                prox = planes.prox;
                using (connection = conexion.GetConnection())
                {
                    connection.Open();
                    SqlCommand agg_detallesCmd = new SqlCommand("insert into Cliente_Deudor values (@ID, @monto_total, @monto_disp,@monto_prox, @prox_pago, @estado, @comentarios)", connection);

                    agg_detallesCmd.Parameters.AddWithValue("@ID", id_cliente);
                    agg_detallesCmd.Parameters.AddWithValue("@monto_total", credito);
                    agg_detallesCmd.Parameters.AddWithValue("@monto_disp", credito);
                    agg_detallesCmd.Parameters.AddWithValue("@prox_pago", prox);
                    agg_detallesCmd.Parameters.AddWithValue("@monto_prox", 0);
                    agg_detallesCmd.Parameters.AddWithValue("@estado", plan);
                    agg_detallesCmd.Parameters.AddWithValue("@comentarios", plan);
                    agg_detallesCmd.ExecuteNonQuery();
                }
                MessageBox.Show("Plan agregado exitosamente");
                LeerInfoClientes();
            }
            else
            {
                MessageBox.Show("No se asigno plan crediticio correctamente");
            }

        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
