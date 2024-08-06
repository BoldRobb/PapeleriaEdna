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
using System.Collections.Generic;
using Presentacion.Formularios.Ventas;

namespace Presentacion.Formularios.Proveedores
{
    public partial class FormRegistrarProvedor : Form
    {

        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        int id_cliente;

        public FormRegistrarProvedor()
        {
            connection = conexion.GetConnection();
            connection.Open();
            InitializeComponent();
            panel1.BackColor = ThemeColor.SecondaryColor;
            panel2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            panel3.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            textBoxNombre.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxNumTel.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxCorreo.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxDireccion.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            buttonAgregar.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            buttonVolver.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            checkedListBoxProductos.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "Nombre")
            {
                MessageBox.Show("El campo Nombre está vacío");
            }
            if (textBoxCorreo.Text == "Correo")
            {
                MessageBox.Show("El campo Correo está vacío");
            }
            if (textBoxDireccion.Text == "Dirección")
            {
                MessageBox.Show("El campo Dirección está vacío");
            }
            if (textBoxNumTel.Text == "Telefono")
            {
                MessageBox.Show("El campo Numero telefonico está vacío");
            }


            if (textBoxCorreo.Text != "Correo" && textBoxDireccion.Text != "Direccion" && textBoxNumTel.Text != "Telefono" && textBoxNombre.Text != "Nombre")
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection = conexion.GetConnection();
                    connection.Open();
                }

                SqlCommand aggCmd = new SqlCommand("insert into Proveedores values (@Nombre); SELECT SCOPE_IDENTITY();", connection);



                aggCmd.Parameters.AddWithValue("@Nombre", textBoxNombre.Text);
                object result = aggCmd.ExecuteScalar();
                id_cliente = Convert.ToInt32(result);

                SqlCommand agg_detallesCmd = new SqlCommand("insert into Proveedores_Detalles values (@ID_Proveedor, @Direccion, @Telefono, @Correo)", connection);

                agg_detallesCmd.Parameters.AddWithValue("@ID_Proveedor", id_cliente);
                agg_detallesCmd.Parameters.AddWithValue("@Direccion", textBoxDireccion.Text);
                agg_detallesCmd.Parameters.AddWithValue("@Correo", textBoxCorreo.Text);
                agg_detallesCmd.Parameters.AddWithValue("@Telefono", textBoxNumTel.Text);




                agg_detallesCmd.ExecuteNonQuery();
                MessageBox.Show("Cliente agregado correctamente");
                textBoxCorreo.Text = "Correo";
                textBoxDireccion.Text = "Dirección";
                textBoxNombre.Text = "Nombre";
                textBoxNumTel.Text = "Telefono";

            }
            else
            {
                MessageBox.Show("Fallo al agregar el Proveedor");
            }




            //AGREGAR PRODUCTO AL PROVEEDOR----------------

            List<string> productosCheck = new List<string>();

            foreach (var item in checkedListBoxProductos.CheckedItems)
            {
                
                using (connection = conexion.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT ID_Producto FROM Productos where Nombre = @Nombre;";
                    SqlCommand buscarID = new SqlCommand(query, connection);
                    buscarID.Parameters.AddWithValue("@Nombre", item.ToString());
                    int id_producto = (int)buscarID.ExecuteScalar();
                    FormPrecioProducto producto = new FormPrecioProducto(id_producto);
                    
                    if (producto.ShowDialog(this) == DialogResult.OK)
                    {
                        SqlCommand aggProductos = new SqlCommand("insert into Catalago_Proveedor values (@ID_Proveedor, @ID_Producto, @Precio);", connection);
                        aggProductos.Parameters.AddWithValue("@ID_Proveedor", id_cliente);
                        aggProductos.Parameters.AddWithValue("@ID_Producto", id_producto);
                        aggProductos.Parameters.AddWithValue("@Precio", producto.precioProducto);
                        aggProductos.ExecuteNonQuery();
                    }

                }



            }

        }

        private void textBoxNombre_Enter(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "Nombre")
            {
                textBoxNombre.Text = "";
                textBoxNombre.ForeColor = Color.Black;

            }
        }

        private void textBoxNombre_Leave(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "")
            {
                textBoxNombre.Text = "Nombre";
                textBoxNombre.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBoxNombre.ForeColor = Color.Black;
            }
        }

        private void textBoxNumTel_Enter(object sender, EventArgs e)
        {
            if (textBoxNumTel.Text == "Telefono")
            {
                textBoxNumTel.Text = "";
                textBoxNumTel.ForeColor = Color.Black;

            }
        }

        private void textBoxNumTel_Leave(object sender, EventArgs e)
        {
            if (textBoxNumTel.Text == "")
            {
                textBoxNumTel.Text = "Telefono";
                textBoxNumTel.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBoxNumTel.ForeColor = Color.Black;
            }
        }

        private void textBoxCorreo_Enter(object sender, EventArgs e)
        {
            if (textBoxCorreo.Text == "Correo")
            {
                textBoxCorreo.Text = "";
                textBoxCorreo.ForeColor = Color.Black;

            }
        }

        private void textBoxCorreo_Leave(object sender, EventArgs e)
        {
            if (textBoxCorreo.Text == "")
            {
                textBoxCorreo.Text = "Correo";
                textBoxCorreo.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBoxNumTel.ForeColor = Color.Black;
            }
        }

        private void textBoxDireccion_Enter(object sender, EventArgs e)
        {
            if (textBoxDireccion.Text == "Dirección")
            {
                textBoxDireccion.Text = "";
                textBoxDireccion.ForeColor = Color.Black;

            }
        }

        private void textBoxDireccion_Leave(object sender, EventArgs e)
        {
            if (textBoxDireccion.Text == "")
            {
                textBoxDireccion.Text = "Dirección";
                textBoxDireccion.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBoxDireccion.ForeColor = Color.Black;
            }
        }

        private void checkedListBoxProductos_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }


        private void ObtenerNombresEmpleadosDesdeBaseDeDatos(SqlConnection connection)
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





        private void FormRegistrarProvedor_Load(object sender, EventArgs e)
        {

            connection = conexion.GetConnection();
            ObtenerNombresEmpleadosDesdeBaseDeDatos(connection);




        }
    }
}
