﻿using Microsoft.Data.SqlClient;
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
        public string cantidad;
        public string selectedCategory;
        public string categoryName;
        public string precio;
        public string description;
        public string selectedProduct;
        public int categoryID;
        public SqlCommand command;
        public SqlConnection connection;
        string connectionString = "Server=KevinMN27\\SQLEXPRESS;DataBase=Papeleria; integrated security= true;Encrypt=False";
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void EliminarProducto_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
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

        }

        //categoria
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
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

        //producto
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = comboBox2.SelectedItem.ToString();
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                

            }
        }
        private List<string> ObtenerNombresProductosEstadoEYCategoria(SqlConnection connection, int categoryID)
        {
            List<string> nombresProductos = new List<string>();

            string query = "SELECT Nombre FROM Productos WHERE Estado_Producto = 'E' AND ID_Categoria = @CategoryID";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CategoryID", categoryID);

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


    }
}
