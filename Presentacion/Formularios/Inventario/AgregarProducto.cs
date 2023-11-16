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
        public int categoryID, ProveedorID;
        public string categoryIDCad, ProveedorIDCad;
        public string productName;
        public string productPrice;
        public string productDescription;
        public string selectedCategory;
        private byte[] imgBytes;
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        public AgregarProducto()
        {
            connection = conexion.GetConnection();
            InitializeComponent();
            this.BackColor = ThemeColor.SecondaryColor;
            panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            textBox1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBox2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBox3.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            buttonIMG.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            button1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            button2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            textBoxPath.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            comboBox1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            comboBox2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
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

        private List<string> ObtenerNombresProveedoresDesdeBaseDeDatos(SqlConnection connection, int numCategorias)
        {
            List<string> nombresProveedores = new List<string>();
            string query = "SELECT Nombre FROM Proveedores";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombreProveedor = reader["Nombre"].ToString();
                        nombresProveedores.Add(nombreProveedor);
                    }
                }
            }
            return nombresProveedores;
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
        private int ObtenerNumeroProveedoresDesdeBaseDeDatos(SqlConnection connection)
        {
            int numCategorias = 0;
            string query = "SELECT COUNT(*) FROM Proveedores";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                numCategorias = (int)command.ExecuteScalar();
            }
            return numCategorias;
        }


        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            using (connection)
            {
                connection.Open();


                int numCategorias = ObtenerNumeroCategoriasDesdeBaseDeDatos(connection);
                int numProveedores = ObtenerNumeroProveedoresDesdeBaseDeDatos(connection);

                List<string> nombresCategorias = ObtenerNombresCategoriasDesdeBaseDeDatos(connection, numCategorias);
                List<string> nombresProveedores = ObtenerNombresProveedoresDesdeBaseDeDatos(connection, numProveedores);

                comboBox1.DataSource = nombresCategorias;
                comboBox1.DisplayMember = "Nombre";

                comboBox2.DataSource = nombresProveedores;
                comboBox2.DisplayMember = "Nombre";
            }
        }

        //AGREGAR PRODUCTO
        private void button1_Click(object sender, EventArgs e)
        {
            string cantidad = "0";
            string productStatus = "N";
            try
            {
                using (connection = conexion.GetConnection())
                {
                    connection.Open();

                    string query = "INSERT INTO productos (Nombre, Precio, ID_Categoria, Descripcion, Estado_Producto, Cantidad, Imagen, ID_Proveedor) VALUES (@Nombre, @Precio,@ID_Categoria, " +
                        "@Descripcion, @Estado_Producto, @Cantidad, @Imagen, @ID_Proveedor)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", productName);
                        command.Parameters.AddWithValue("@Precio", productPrice);
                        command.Parameters.AddWithValue("@ID_Categoria", categoryIDCad);
                        command.Parameters.AddWithValue("@Descripcion", productDescription);
                        command.Parameters.AddWithValue("@Estado_Producto", productStatus);
                        command.Parameters.AddWithValue("@Cantidad", cantidad);
                        command.Parameters.AddWithValue("@Imagen", imgBytes);
                        command.Parameters.AddWithValue("@ID_Proveedor", ProveedorIDCad);


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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                
            }
            
        }

        //SALIR
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private int GetProveedorID(string categoryName)
        {
            ProveedorID = 0;


            using (connection = conexion.GetConnection())
            {
                connection.Open();

                string query = "SELECT ID_Proveedor FROM Proveedores WHERE nombre = @Nombre";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", categoryName);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // Si se encontró un resultado, asigna el ID de la categoría a la variable categoryID
                        ProveedorID = Convert.ToInt32(result);
                    }
                }
            }

            return ProveedorID;
        }


        private void buttonIMG_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Imagenes|*.jpg;*.png;*.gif";
            openFileDialog1.InitialDirectory = @"C:\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtenemos la ruta de la imagen seleccionada
                string filePath = openFileDialog1.FileName;

                textBoxPath.Text = filePath;

                Image img = Image.FromFile(filePath);

                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imgBytes = ms.ToArray();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                selectedCategory = comboBox2.SelectedItem.ToString();
                ProveedorID = GetProveedorID(selectedCategory);
            }
            else
            {
                selectedCategory = null; // Si no hay selección válida, puedes establecer la variable como nula
            }

            ProveedorIDCad = categoryID.ToString();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == " Nombre")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = " Nombre";
                textBox1.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == " Precio")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = " Precio";
                textBox2.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                textBox2.ForeColor = Color.Black;
            }
        }
    }
}
