using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Presentacion.Formularios.Proveedores
{
    public partial class FormModificarProveedor : Form
    {

        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        int ID_Empleado;

        public FormModificarProveedor()
        {
            connection = conexion.GetConnection();
            connection.Open();
            InitializeComponent();
            panel1.BackColor = ThemeColor.SecondaryColor;
            panel2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            panel3.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            panel4.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            textBoxCorreo.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxDireccion.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxNombre.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxNumTel.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            button1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            button2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            comboBoxEmpleados.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            checkedListBoxProductos.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
        }



        private int ObtenerNumeroEmpleadosDesdeBaseDeDatos(SqlConnection connection)
        {
            int numEmpleados = 0;
            string query = "SELECT COUNT(*) FROM Proveedores";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                numEmpleados = (int)command.ExecuteScalar();
            }
            return numEmpleados;
        }


        private List<string> ObtenerNombresEmpleadosDesdeBaseDeDatos(SqlConnection connection, int numEmpleados)
        {
            List<string> nombresEmpleados = new List<string>();
            string query = "SELECT Nombre FROM Proveedores";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
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

        private void FormModificarProveedor_Load(object sender, EventArgs e)
        {

            LeerInfoProveedores();
            connection = conexion.GetConnection();
            ObtenerNombresProductosDesdeBaseDeDatos(connection);


        }


        private void ObtenerNombresProductosDesdeBaseDeDatos(SqlConnection connection)
        {

            List<string> nombresEmpleados = new List<string>();
            string query = "SELECT Nombre FROM Productos";
            connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombreEmpleado = reader["Nombre"].ToString();
                        checkedListBoxProductos.Items.Add(nombreEmpleado);
                    }
                }
            }
        }


        private void LeerInfoProveedores()
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
            textBoxDireccion.Text = "";
            textBoxNombre.Text = "";
            textBoxNumTel.Text = "";

        }

        private void comboBoxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = conexion.GetConnection();
                connection.Open();
            }


            for (int i = 0; i < checkedListBoxProductos.Items.Count; i++)
            {
                checkedListBoxProductos.SetItemChecked(i, false);
            }


            var empleadoSeleccionado = (String)comboBoxEmpleados.SelectedItem;

            string query = "SELECT ID_Proveedor, Nombre FROM Proveedores where Nombre = @Nombre; SELECT SCOPE_IDENTITY();";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nombre", empleadoSeleccionado);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBoxNombre.Text = reader.GetString(1);
                    }

                }
                reader.Close();


            }
            query = "SELECT ID_Proveedor from Proveedores where Nombre = @Nombre;";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nombre", empleadoSeleccionado);
                object result = command.ExecuteScalar();
                ID_Empleado = (int)result;

            }

            query = "SELECT Telefono, Correo, Direccion FROM Proveedores_Detalles where ID_Proveedor = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", ID_Empleado);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        textBoxCorreo.Text = reader.GetString(1);
                        textBoxDireccion.Text = reader.GetString(2);
                        textBoxNumTel.Text = reader.GetString(0);

                    }

                }
                reader.Close();
            }

            query = "SELECT P.Nombre FROM Productos P INNER JOIN Catalago_Proveedor ON P.ID_Producto = Catalago_Proveedor.ID_Producto WHERE Catalago_Proveedor.ID_Proveedor = @ID_Proveedor;";
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@ID_Proveedor", ID_Empleado);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        string nombreProducto = reader.GetString(0);

                        for (int i = 0; i < checkedListBoxProductos.Items.Count; i++)
                        {
                            if (checkedListBoxProductos.Items[i].ToString() == nombreProducto)
                            {
                                checkedListBoxProductos.SetItemChecked(i, true);
                            }
                        }



                    }

                }
                reader.Close();
            }














        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = conexion.GetConnection();
                connection.Open();
            }
            int id_cliente;
            string query = "SELECT ID_Proveedor from Proveedores where Nombre = @Nombre;";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                var clienteSeleccionado = (String)comboBoxEmpleados.SelectedItem;
                command.Parameters.AddWithValue("@Nombre", clienteSeleccionado);
                object result = command.ExecuteScalar();
                id_cliente = (int)result;

            }
            query = "DELETE from Catalago_Proveedor where ID_Proveedor = @ID;";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", id_cliente);
                command.ExecuteNonQuery();

            }

            query = "UPDATE Proveedores SET Nombre = @Nombre WHERE ID_Proveedor = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nombre", textBoxNombre.Text);
                command.Parameters.AddWithValue("@ID", id_cliente);
                command.ExecuteNonQuery();
            }
            query = "UPDATE Proveedores_Detalles SET Direccion = @Direccion, Correo=@Correo, Telefono = @Telefono WHERE ID_Proveedor = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@Direccion", textBoxDireccion.Text);
                command.Parameters.AddWithValue("@Correo", textBoxCorreo.Text);
                command.Parameters.AddWithValue("@Telefono", textBoxNumTel.Text);
                command.Parameters.AddWithValue("@ID", id_cliente);






                command.ExecuteNonQuery();
            }

            foreach (var item in checkedListBoxProductos.CheckedItems)
            {

                using (connection = conexion.GetConnection())
                {
                    connection.Open();
                    query = "SELECT ID_Producto FROM Productos where Nombre = @Nombre;";
                    SqlCommand buscarID = new SqlCommand(query, connection);
                    buscarID.Parameters.AddWithValue("@Nombre", item.ToString());
                    int id_producto = (int)buscarID.ExecuteScalar();

                    SqlCommand aggProductos = new SqlCommand("insert into Catalago_Proveedor values (@ID_Proveedor, @ID_Producto);", connection);
                    aggProductos.Parameters.AddWithValue("@ID_Proveedor", id_cliente);
                    aggProductos.Parameters.AddWithValue("@ID_Producto", id_producto);
                    aggProductos.ExecuteNonQuery();
                }



            }


            LeerInfoProveedores();
            MessageBox.Show("Se ha modificado el proveedor correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxProductos_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }
    }
}
