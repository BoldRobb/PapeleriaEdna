using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion.Formularios.Inventario
{
    public partial class ModificarProducto : Form
    {
        public string categoryName;
        public string precio;
        public string description;
        public string selectedProduct;
        public int categoryID;
        public string categoryIDCad;
        public string productName;
        public string productPrice;
        public string productDescription;
        public string selectedCategory;
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        public ModificarProducto()
        {
            connection = conexion.GetConnection();
            InitializeComponent();
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {
            using (connection = conexion.GetConnection())
            {
                connection.Open();


                int numCategorias = ObtenerNumeroCategoriasDesdeBaseDeDatos(connection);


                List<string> nombresCategorias = ObtenerNombresCategoriasDesdeBaseDeDatos(connection, numCategorias);
                List<string> nombresCategorias2 = ObtenerNombresCategoriasDesdeBaseDeDatos(connection, numCategorias);


                comboBox1.DataSource = nombresCategorias;
                comboBox1.DisplayMember = "Nombre";
                comboBox3.DataSource = nombresCategorias2;
                

            }
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
                    List<string> nombresProductos = ObtenerNombresProductosPorCategoria(connection, categoryID);

                    // Cargar la lista de productos correspondientes a la categoría seleccionada

                    // Actualizar el origen de datos del comboBox2
                    comboBox2.DataSource = nombresProductos;
                    comboBox2.DisplayMember = "Nombre"; // Asegúrate de que el nombre de la propiedad sea correcto
                    comboBox3.SelectedItem = comboBox1.SelectedItem;
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
            productName = selectedProduct;
            using (connection)
            {
                connection.Open();
                precio = ObtenerPrecioProducto(connection, selectedProduct);
                description = ObtenerDescripcionProducto(connection, selectedProduct);
                textBox2.Text = precio;
                textBox3.Text = description;
                textBox1.Text = precio;

            }

        }

        //MODIFICAR CATEGORIA
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryName = comboBox3.SelectedItem.ToString();
            categoryID = GetCategoryID(categoryName);
        }

        //NOMBRE
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            productName = textBox1.Text;
        }

        //PRECIO
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            precio = textBox2.Text;
        }

        //DESCRIPCION
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            description = textBox3.Text;
        }

        //MODIFICAR PRODCUTO
        private void button1_Click(object sender, EventArgs e)
        {
            using (connection = conexion.GetConnection())
            {
                connection.Open();

                // Verificar que se haya seleccionado un producto
                
                    // Verificar que el nombre del producto y el precio no estén en blanco
                    if (!string.IsNullOrEmpty(productName) && !string.IsNullOrEmpty(precio))
                    {
                        // Query de actualización
                        string query = "UPDATE Productos SET Nombre = @NuevoNombre, Precio = @Precio,ID_Categoria = @IDCategoria, Descripcion = @Descripcion WHERE Nombre = @ViejoNombre";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ViejoNombre", selectedProduct);
                            command.Parameters.AddWithValue("@NuevoNombre", productName);
                            command.Parameters.AddWithValue("@Precio", precio);
                            command.Parameters.AddWithValue("@IDCategoria", categoryID);
                            command.Parameters.AddWithValue("@Descripcion", description);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Producto actualizado exitosamente.");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar el producto.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete el nombre y el precio antes de actualizar.");
                    }
                
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

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

        private List<string> ObtenerNombresProductosPorCategoria(SqlConnection connection, int idCategory)
        {
            List<string> nombresProductos = new List<string>();
            string query = "SELECT Nombre FROM Productos WHERE ID_Categoria = @ID_Categoria";
            connection = conexion.GetConnection();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID_Categoria", idCategory);
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

        





    }
}
