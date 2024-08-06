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

namespace Presentacion.Formularios.Ventas
{
    public partial class FormVenta_Info : Form
    {
        bool clienteSeleccionado;
        bool opcionPago;
        bool credit;

        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        public FormVenta_Info()
        {
            InitializeComponent();
            this.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.3);
            panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.1);
            comboBoxClientes.BackColor = ThemeColor.SecondaryColor;
            comboBoxClientes.ForeColor = Color.White;
        }

        private void FormVenta_Info_Load(object sender, EventArgs e)
        {
            LeerInfoClientes();
        }
        private List<string> ObtenerNombresClientesDesdeBaseDeDatos(SqlConnection connection)
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


                List<string> nombresCategorias = ObtenerNombresClientesDesdeBaseDeDatos(connection);


                comboBoxClientes.DataSource = nombresCategorias;
                comboBoxClientes.DisplayMember = "Apellidos";

            }
            connection.Close();

        }

        private void buttonRealizar_Click(object sender, EventArgs e)
        {
            if (credit)
            {
                if (VerificarCredito())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El cliente seleccionado no cuenta con un plan de credito vigente");
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            clienteSeleccionado = true;
            if (clienteSeleccionado && opcionPago)
            {
                buttonRealizar.Enabled = true;
            }
        }

        private void radioButtonContado_CheckedChanged(object sender, EventArgs e)
        {
            credit = false;
            opcionPago = true;
            if (clienteSeleccionado && opcionPago)
            {
                buttonRealizar.Enabled = true;
            }

        }

        private void radioButtonCredito_CheckedChanged(object sender, EventArgs e)
        {
            credit = true;
            opcionPago = true;
            if (clienteSeleccionado && opcionPago)
            {
                buttonRealizar.Enabled = true;
            }
            
        }
        private bool VerificarCredito()
        {
            connection=conexion.GetConnection();
            connection.Open();
            int id_cliente;
            string empl = (string)comboBoxClientes.SelectedItem;
           string query = "SELECT ID_Cliente from Clientes where Apellido = @Apellido;";
            string estado;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Apellido", empl);
                object result = command.ExecuteScalar();
                id_cliente = (int)result;

            }
            query = "SELECT CASE WHEN EXISTS (SELECT 1 FROM cliente_deudor WHERE id_cliente = @id) THEN 'Deudor' ELSE 'No Deudor' END AS estado_deudor";
            using (SqlCommand commando = new SqlCommand(query, connection))
            {
                
                commando.Parameters.AddWithValue("@id", id_cliente);
                
                estado = (string)commando.ExecuteScalar();


            }
            if(estado == "Deudor")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
