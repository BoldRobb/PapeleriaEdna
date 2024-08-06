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
            this.BackColor = ThemeColor.SecondaryColor;
            this.FormBorderStyle = FormBorderStyle.None;
            comboBoxCategorias.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            comboBoxCategorias2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            comboBoxProducto.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxDescripcion.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxNombre.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxPrecio.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            button1.BackColor = ThemeColor.SecondaryColor;
            button2.BackColor = ThemeColor.SecondaryColor;
            panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            label1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            label2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            label3.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            label4.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            label5.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            label6.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {
            using (connection = conexion.GetConnection())
            {
                connection.Open();


                int numCategorias = ObtenerNumeroCategoriasDesdeBaseDeDatos(connection);


                List<string> nombresCategorias = ObtenerNombresCategoriasDesdeBaseDeDatos(connection, numCategorias);
                List<string> nombresCategorias2 = ObtenerNombresCategoriasDesdeBaseDeDatos(connection, numCategorias);


                comboBoxCategorias.DataSource = nombresCategorias;
                comboBoxCategorias.DisplayMember = "Nombre";
                comboBoxCategorias2.DataSource = nombresCategorias2;


            }
        }

        //CATEGORIA
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (connection = conexion.GetConnection())
            {
                connection.Open();
                if (comboBoxCategorias.SelectedItem != null)
                {
                    selectedCategory = comboBoxCategorias.SelectedItem.ToString();
                    categoryID = GetCategoryID(selectedCategory);
                    List<string> nombresProductos = ObtenerNombresProductosPorCategoria(connection, categoryID);

                    // Cargar la lista de productos correspondientes a la categoría seleccionada

                    // Actualizar el origen de datos del comboBox2
                    comboBoxProducto.DataSource = nombresProductos;
                    comboBoxProducto.DisplayMember = "Nombre"; // Asegúrate de que el nombre de la propiedad sea correcto
                    comboBoxCategorias2.SelectedItem = comboBoxCategorias.SelectedItem;
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
            selectedProduct = comboBoxProducto.SelectedItem.ToString();
            productName = selectedProduct;
            using (connection = conexion.GetConnection())
            {
                connection.Open();
                precio = ObtenerPrecioProducto(connection, selectedProduct);
                description = ObtenerDescripcionProducto(connection, selectedProduct);
                textBoxPrecio.Text = precio;
                textBoxDescripcion.Text = description;
                textBoxNombre.Text = productName;

            }

        }

        //MODIFICAR CATEGORIA
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryName = comboBoxCategorias2.SelectedItem.ToString();
            categoryID = GetCategoryID(categoryName);
        }

        //NOMBRE
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            productName = textBoxNombre.Text;
        }

        //PRECIO
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            precio = textBoxPrecio.Text;
        }

        //DESCRIPCION
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            description = textBoxDescripcion.Text;
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
            this.Close();
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

            using (connection = conexion.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@ID_Categoria", idCategory);

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
