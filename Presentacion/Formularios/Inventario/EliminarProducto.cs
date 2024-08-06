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
    public partial class EliminarProducto : Form
    {
        public string productName;
        public string cantidad;
        public string selectedCategory;
        public string categoryName;
        public string precio;
        public string description;
        public string selectedProduct;
        public int categoryID;
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        public EliminarProducto()
        {
            connection = conexion.GetConnection();
            InitializeComponent();
            this.BackColor = ThemeColor.SecondaryColor;
            panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            comboBox1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            comboBox2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            label1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            label2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);

        }

        private void EliminarProducto_Load(object sender, EventArgs e)
        {
            using (connection)
            {
                connection.Open();


                int numCategorias = ObtenerNumeroCategoriasDesdeBaseDeDatos(connection);


                List<string> nombresCategorias = ObtenerNombresCategoriasDesdeBaseDeDatos(connection, numCategorias);
                List<string> nombresCategorias2 = ObtenerNombresCategoriasDesdeBaseDeDatos(connection, numCategorias);


                comboBox1.DataSource = nombresCategorias;
                comboBox1.DisplayMember = "Nombre";



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar el producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verifica la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // El usuario ha confirmado, procede con la eliminación
                string query = "DELETE FROM Productos WHERE Nombre = @Nombre";

                using (SqlConnection connection = conexion.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", productName); // Establece el valor del parámetro @Nombre

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto eliminado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el producto");
                        }
                    }
                }

                // Cierra el formulario actual
                this.Close();
            }
            else
            {
                // El usuario ha cancelado, no se realiza ninguna acción
                MessageBox.Show("Operación cancelada por el usuario");
            }
        }


        //categoria
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (connection)
            {
                connection = conexion.GetConnection();
                connection.Open();
                if (comboBox1.SelectedItem != null)
                {
                    selectedCategory = comboBox1.SelectedItem.ToString();
                    categoryID = GetCategoryID(selectedCategory);
                    List<string> nombresProductos = GetProductNamesByCategoryID(categoryID);

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

        //producto
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = comboBox2.SelectedItem.ToString();
            productName = selectedProduct;

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


            using (connection)
            {
                connection = conexion.GetConnection();
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

        private List<string> GetProductNamesByCategoryID(int categoryID)
        {
            List<string> productNames = new List<string>();

            using (connection)
            {
                connection = conexion.GetConnection();
                connection.Open();

                string query = "SELECT Nombre FROM productos WHERE ID_Categoria = @CategoryID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryID", categoryID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Agrega los nombres de los productos a la lista
                            string productName = reader["Nombre"].ToString();
                            productNames.Add(productName);
                        }
                    }
                }
            }

            return productNames;
        }

        private void DeleteProductByName(string productName)
        {




        }

    }
}
