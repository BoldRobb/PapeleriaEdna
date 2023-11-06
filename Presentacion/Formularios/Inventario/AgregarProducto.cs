using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
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
    public partial class AgregarProducto : Form
    {
        public int categoryID;
        public string categoryIDCad;
        public string productName;
        public string productPrice;
        public string productDescription;
        public string selectedCategory;
        public SqlCommand command;
        public SqlConnection connection;
        string connectionString = "Server=DESKTOP-D6EMB4F\\SQLEXPRESS;DataBase=Papeleria; integrated security= true;Encrypt=False";
        public AgregarProducto()
        {
            InitializeComponent();
        }

        //CATEGORIAS
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                selectedCategory = comboBox1.SelectedItem.ToString();
                categoryID = GetCategoryID(selectedCategory);
            }
            else
            {
                selectedCategory = null; // Si no hay selección válida, puedes establecer la variable como nula
            }
            textBox4.Text = categoryID.ToString();
            categoryIDCad = categoryID.ToString();
        }

        //NOMBRE PRODUCTO
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            productName = textBox1.Text;
        }

        //PRECIO PRODUCTO
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            productPrice = textBox2.Text;
        }

        //DESCRIPCION
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            productDescription = textBox3.Text;

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



        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                int numCategorias = ObtenerNumeroCategoriasDesdeBaseDeDatos(connection);


                List<string> nombresCategorias = ObtenerNombresCategoriasDesdeBaseDeDatos(connection, numCategorias);


                comboBox1.DataSource = nombresCategorias;
                comboBox1.DisplayMember = "Nombre";
            }
        }

        //AGREGAR PRODUCTO
        private void button1_Click(object sender, EventArgs e)
        {
            string cantidad = "0";
            string productStatus = "N";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO productos (Nombre, Precio, ID_Categoria, Descripcion, Estado_Producto, Cantidad) VALUES (@Nombre, @Precio,@ID_Categoria, @Descripcion, @Estado_Producto, @Cantidad)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", productName);
                    command.Parameters.AddWithValue("@Precio", productPrice);
                    command.Parameters.AddWithValue("@ID_Categoria", categoryIDCad);
                    command.Parameters.AddWithValue("@Descripcion", productDescription);
                    command.Parameters.AddWithValue("@Estado_Producto", productStatus);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto agregado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el producto.");
                    }
                }
            }
        }

        //SALIR
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private int GetCategoryID(string categoryName)
        {
            categoryID = 0;


            using (SqlConnection connection = new SqlConnection(connectionString))
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
