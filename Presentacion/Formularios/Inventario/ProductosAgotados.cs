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

namespace Presentacion.Formularios.Inventario
{
    public partial class ProductosAgotados : Form
    {
        public string categoryName;
        public string precio;
        public string description;
        public string selectedProduct;
        public int categoryID;
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        public ProductosAgotados()
        {
            connection = conexion.GetConnection();
            InitializeComponent();
        }

        private void ProductosAgotados_Load(object sender, EventArgs e)
        {
            using (connection)
            {
                connection.Open();

                List<string> nombresProductos = ObtenerNombresProductosEstadoN(connection);

                comboBox1.DataSource = nombresProductos;
                comboBox1.DisplayMember = "Nombre";



            }
        }

        //LISTA PRODUCTOS
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = comboBox1.SelectedItem.ToString();
            using (connection)
            {
                connection.Open();

                precio = ObtenerPrecioProducto(connection, selectedProduct);
                description = ObtenerDescripcionProducto(connection, selectedProduct);
                categoryID = ObtenerIDCategoriaProducto(connection, selectedProduct);
                categoryName = ObtenerNombreCategoriaPorID(connection, categoryID);
                textBox1.Text = precio;
                textBox2.Text = categoryName;
                textBox3.Text = description;


            }
        }

        //PRECIO PRODUCTO
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //CATEGORIA
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //DESCRIPCION
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private string ObtenerPrecioProducto(SqlConnection connection, string selectedProduct)
        {
            string precio = "0"; // Valor por defecto en caso de que no se encuentre el producto

            string query = "SELECT Precio FROM Productos WHERE Nombre = @SelectedProduct";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SelectedProduct", selectedProduct);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    precio = result.ToString();
                }

                return precio;
            }
        }

        private string ObtenerDescripcionProducto(SqlConnection connection, string selectedProduct)
        {
            string descripcion = string.Empty; // Valor por defecto

            string query = "SELECT Descripcion FROM Productos WHERE Nombre = @SelectedProduct";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SelectedProduct", selectedProduct);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    descripcion = result.ToString();
                }

                return descripcion;
            }
        }

        private int ObtenerIDCategoriaProducto(SqlConnection connection, string selectedProduct)
        {
            int idCategoria = -1; // Valor por defecto

            string query = "SELECT ID_Categoria FROM Productos WHERE Nombre = @SelectedProduct";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SelectedProduct", selectedProduct);

                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out idCategoria))
                {
                    return idCategoria;
                }

                return -1; // Valor por defecto si no se encontró el ID_Categoria
            }
        }

        private string ObtenerNombreCategoriaPorID(SqlConnection connection, int idCategoria)
        {
            string nombreCategoria = string.Empty; // Valor por defecto

            string query = "SELECT Nombre FROM Categorias WHERE ID_Categoria = @IDCategoria";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@IDCategoria", idCategoria);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    nombreCategoria = result.ToString();
                }

                return nombreCategoria;
            }
        }

        private List<string> ObtenerNombresProductosEstadoN(SqlConnection connection)
        {
            List<string> nombresProductos = new List<string>();

            string query = "SELECT Nombre FROM Productos WHERE Estado_Producto = 'N'";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombreProducto = reader["Nombre"].ToString();
                        nombresProductos.Add(nombreProducto);
                    }
                }
            }

            return nombresProductos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
