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

namespace Presentacion.Formularios.Inventario
{
    public partial class ProductosExistencia : Form
    {
        public string cantidad;
        public string selectedCategory;
        public string categoryName;
        public string precio;
        public string description;
        public string selectedProduct;
        public int categoryID;
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        public ProductosExistencia()
        {
            connection = conexion.GetConnection();
            InitializeComponent();
        }

        //CATEGORIA
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (connection = conexion.GetConnection())
            {
                connection.Open();
                if (comboBox1.SelectedItem != null)
                {
                    selectedCategory = comboBox1.SelectedItem.ToString();
                    categoryID = GetCategoryID(selectedCategory);
                    List<string> nombresProductos = ObtenerNombresProductosEstadoEYCategoria(connection, categoryID);

                    // Cargar la lista de productos correspondientes a la categoría seleccionada

                    // Actualizar el origen de datos del comboBox2
                    comboBox2.DataSource = nombresProductos;
                    comboBox2.DisplayMember = "Nombre"; // Asegúrate de que el nombre de la propiedad sea correcto

                }

                else
                {
                    selectedCategory = null; // Si no hay selección válida, puedes establecer la variable como nula
                }




            }
        }

        //PRODUCTO
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = comboBox2.SelectedItem.ToString();

            using (connection = conexion.GetConnection())
            {
                connection.Open();
                precio = ObtenerPrecioProducto(connection, selectedProduct);
                description = ObtenerDescripcionProducto(connection, selectedProduct);
                cantidad = ObtenerCantidadProducto(connection, selectedProduct);
                textBox2.Text = cantidad;
                textBox3.Text = description;
                textBox1.Text = precio;

            }
        }

        //PRECIO
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //CANTIDAD
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //DESCRIPCION
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductosExistencia_Load(object sender, EventArgs e)
        {
            using (connection = conexion.GetConnection())
            {
                connection.Open();


                int numCategorias = ObtenerNumeroCategoriasDesdeBaseDeDatos(connection);


                List<string> nombresCategorias = ObtenerNombresCategoriasDesdeBaseDeDatos(connection, numCategorias);
                List<string> nombresCategorias2 = ObtenerNombresCategoriasDesdeBaseDeDatos(connection, numCategorias);


                comboBox1.DataSource = nombresCategorias;
                comboBox1.DisplayMember = "Nombre";
                this.BackColor = ThemeColor.SecondaryColor;
                comboBox1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
                comboBox2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
                textBox1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
                textBox2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
                textBox3.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
                panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
                label1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
                label2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
                label3.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
                label4.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
                label5.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);


            }
        }





        //categoria

        private List<string> ObtenerNombresProductosEstadoEYCategoria(SqlConnection connection, int categoryID)
        {
            List<string> nombresProductos = new List<string>();

            string query = "SELECT Nombre FROM Productos WHERE Estado_Producto = 'E' AND ID_Categoria = @CategoryID";
            connection = conexion.GetConnection();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CategoryID", categoryID);
                connection.Open();
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

        private List<string> ObtenerNombresCategoriasDesdeBaseDeDatos(SqlConnection connection, int numCategorias)
        {
            List<string> nombresCategorias = new List<string>();
            string query = "SELECT Nombre FROM categorias";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombreCategoria = reader["Nombre"].ToString();
                        nombresCategorias.Add(nombreCategoria);
                    }
                }
            }
            return nombresCategorias;
        }

        private int ObtenerNumeroCategoriasDesdeBaseDeDatos(SqlConnection connection)
        {
            int numCategorias = 0;
            string query = "SELECT COUNT(*) FROM categorias";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                numCategorias = (int)command.ExecuteScalar();
            }
            return numCategorias;
        }

        private int GetCategoryID(string categoryName)
        {
            categoryID = 0;


            using (connection = conexion.GetConnection())
            {
                connection.Open();

                string query = "SELECT ID_Categoria FROM categorias WHERE nombre = @Nombre";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", categoryName);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // Si se encontró un resultado, asigna el ID de la categoría a la variable categoryID
                        categoryID = Convert.ToInt32(result);
                    }
                }
            }

            return categoryID;
        }

        private string ObtenerCantidadProducto(SqlConnection connection, string selectedProduct)
        {
            string cantidad = "0"; // Valor por defecto en caso de que no se encuentre el producto

            string query = "SELECT Cantidad FROM Productos WHERE Nombre = @SelectedProduct";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SelectedProduct", selectedProduct);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    cantidad = result.ToString();
                }

                return cantidad;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
