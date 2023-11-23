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

namespace Presentacion.Formularios.Proveedores
{
    public partial class FormEliminarProveedor : Form
    {

        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();

        public FormEliminarProveedor()
        {
            connection = conexion.GetConnection();
            connection.Open();
            InitializeComponent();
            panel1.BackColor = ThemeColor.SecondaryColor;
            panel2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            panel3.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            textBoxCorreo.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxDireccion.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxNombre.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxNumTel.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            buttonVolver.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            buttonEliminar.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            comboBoxProveedores.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int ObtenerNumeroProveedoresDesdeBaseDeDatos(SqlConnection connection)
        {
            int numEmpleados = 0;
            string query = "SELECT COUNT(*) FROM Proveedores";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                numEmpleados = (int)command.ExecuteScalar();
            }
            return numEmpleados;
        }

        private List<string> ObtenerNombresProveedoresDesdeBaseDeDatos(SqlConnection connection, int numEmpleados)
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

        private void FormEliminarProveedor_Load(object sender, EventArgs e)
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

            using (connection)
            {

                int numEmpleados = ObtenerNumeroProveedoresDesdeBaseDeDatos(connection);


                List<string> nombresCategorias = ObtenerNombresProveedoresDesdeBaseDeDatos(connection, numEmpleados);


                comboBoxProveedores.DataSource = nombresCategorias;
                comboBoxProveedores.DisplayMember = "Nombre";

            }
            connection.Close();
            textBoxCorreo.Text = "";
            textBoxDireccion.Text = "";
            textBoxNombre.Text = "";
            textBoxNumTel.Text = "";
        }

        private void comboBoxProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = conexion.GetConnection();
                connection.Open();
            }

            int ID_Empleado;
            var empleadoSeleccionado = (String)comboBoxProveedores.SelectedItem;

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

            query = "SELECT Direccion, Telefono, Correo FROM Proveedores_Detalles where ID_Proveedor = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", ID_Empleado);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        textBoxCorreo.Text = reader.GetString(2);
                        textBoxDireccion.Text = reader.GetString(0);
                        textBoxNumTel.Text = reader.GetString(1);


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
            string query = "SELECT ID_Proveedor from Proveedores where Nombre = @Nombre;";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                var empleadosSeleccionado = (String)comboBoxProveedores.SelectedItem;
                command.Parameters.AddWithValue("@Nombre", empleadosSeleccionado);
                object result = command.ExecuteScalar();
                id_empleado = (int)result;

            }
            query = "DELETE FROM Proveedores_Detalles Where ID_Proveedor = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@ID", id_empleado);
                command.ExecuteNonQuery();
            }
            query = "DELETE FROM Proveedores Where ID_Proveedor = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@ID", id_empleado);
                command.ExecuteNonQuery();
            }
            LeerInfoProveedores();
            MessageBox.Show("Se ha eliminado al empleado correctamente");
        }
    }
}
