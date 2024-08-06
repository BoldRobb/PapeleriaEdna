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

namespace Presentacion.Formularios.Egresos
{
    public partial class PagoProveedores : Form
    {
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        int id_proveedor;
        int id_pedido;
        DateTime fechafin;
        string Desc;
        public PagoProveedores()
        {
            InitializeComponent();
            this.BackColor = ThemeColor.SecondaryColor;
            panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            comboBoxProveedores.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            comboBoxProveedores.ForeColor = Color.White;
            textBoxTotal.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxTotal.ForeColor = Color.White;
            textBoxDescripcion.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxDescripcion.ForeColor = Color.White;
            comboBoxPagos.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            comboBoxPagos.ForeColor = Color.White;
        }

        private void PagoProveedores_Load(object sender, EventArgs e)
        {
            LeerInfoProveedores();
        }
        private void LeerInfoProveedores()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = conexion.GetConnection();
                connection.Open();
            }

            using (connection = conexion.GetConnection())
            {

                List<string> nombresCategorias = ObtenerNombresEmpleadosDesdeBaseDeDatos(connection);


                comboBoxProveedores.DataSource = nombresCategorias;
                comboBoxProveedores.DisplayMember = "Nombre";

            }


        }

        private List<string> ObtenerNombresEmpleadosDesdeBaseDeDatos(SqlConnection connection)
        {
            List<string> nombresEmpleados = new List<string>();
            string query = "SELECT Nombre FROM Proveedores";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombreEmpleado = reader["Nombre"].ToString();
                        nombresEmpleados.Add(nombreEmpleado);
                    }
                }
            }
            return nombresEmpleados;
        }
        private List<string> ObtenerPedidosDesdeBaseDeDatos(SqlConnection connection, int id)
        {
            List<string> nombresEmpleados = new List<string>();
            string query = "SELECT ID_Pedido FROM Pedidos_proveedor WHERE Estado_Pedido = 'Sin pagar' AND ID_Proveedor = @ID";

            using (SqlCommand command = new SqlCommand(query, connection = conexion.GetConnection()))
            {
                command.Parameters.AddWithValue("@ID", id_proveedor);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombreEmpleado = reader["ID_Pedido"].ToString();
                        nombresEmpleados.Add(nombreEmpleado);
                    }
                }
            }
            return nombresEmpleados;
        }
        private void LeerInfoPagos(string nombreProveedor)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = conexion.GetConnection();
                connection.Open();
            }
            using (connection = conexion.GetConnection())
            {
                connection.Open();
                string query = "SELECT ID_Proveedor FROM Proveedores WHERE Nombre = @Nombre";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombreProveedor);
                    id_proveedor = (int)command.ExecuteScalar();
                }
            }
            using (connection)
            {


                List<string> nombresCategorias = ObtenerPedidosDesdeBaseDeDatos(connection, id_proveedor);


                comboBoxPagos.DataSource = nombresCategorias;
                comboBoxPagos.DisplayMember = "Nombre";

            }


        }
        private void comboBoxProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            LeerInfoPagos(comboBoxProveedores.Text);
        }

        private void comboBoxPagos_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_pedido = int.Parse(comboBoxPagos.Text);
            using (connection = conexion.GetConnection())
            {
                connection.Open();
                string query = "SELECT monto FROM Pedidos_Proveedor WHERE ID_Pedido = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id_pedido);
                    textBoxTotal.Text = ((double)command.ExecuteScalar()).ToString();
                }
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            using (connection = conexion.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Pedidos_Proveedor SET Fecha_pago = @Fecha, estado_pedido = 'Pagado', Descripcion = @Descripcion WHERE ID_Pedido = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Fecha", fechafin);
                    command.Parameters.AddWithValue("@Descripcion", Desc);
                    command.Parameters.AddWithValue("@ID", id_pedido);
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Pago registrado en el sistema");
            textBoxDescripcion.Text = "";
            textBoxTotal.Text = "";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            fechafin = monthCalendar1.SelectionStart;
        }

        private void textBoxDescripcion_TextChanged(object sender, EventArgs e)
        {
            Desc = textBoxDescripcion.Text;
        }
    }
}
