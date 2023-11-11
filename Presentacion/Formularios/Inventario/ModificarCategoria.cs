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

    public partial class ModificarCategoria : Form
    {

        public string selectedCategory;
        public string categoryDescription;
        public string categoryName;
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        public ModificarCategoria()
        {
            InitializeComponent();
        }

        //BOTON MODIFICAR
        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedCategory != null)
            {
                // Realizar una consulta SQL para actualizar la categoría seleccionada
                using (connection)
                {
                    connection.Open();

                    string query = "UPDATE Categorias SET Nombre = @Nombre, Descripción = @Descripción WHERE Nombre = @SelectedCategory";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", categoryName);
                        command.Parameters.AddWithValue("@Descripción", categoryDescription);
                        command.Parameters.AddWithValue("@SelectedCategory", selectedCategory);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Categoría actualizada correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la categoría para actualizar.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado una categoría para actualizar.");
            }
        }

        //BOTON REGRESAR
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            categoryName = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            categoryDescription = textBox2.Text;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                selectedCategory = comboBox1.SelectedItem.ToString();

                // Realizar una consulta para obtener la descripción y el nombre de la categoría seleccionada
                using (connection = conexion.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT Nombre, Descripción FROM Categorias WHERE Nombre = @Nombre";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", selectedCategory);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                categoryName = reader["Nombre"].ToString();
                                categoryDescription = reader["Descripción"].ToString();

                                // Asignar los valores a los TextBox
                                textBox1.Text = categoryName;
                                textBox2.Text = categoryDescription;
                            }
                        }
                    }
                }
            }
            else
            {
                selectedCategory = null;
                categoryName = null;
                categoryDescription = null;
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
        }

        private void ModificarCategoria_Load(object sender, EventArgs e)
        {
            using (connection = conexion.GetConnection())
            {
                connection.Open();


                int numCategorias = ObtenerNumeroCategoriasDesdeBaseDeDatos(connection);


                List<string> nombresCategorias = ObtenerNombresCategoriasDesdeBaseDeDatos(connection, numCategorias);


                comboBox1.DataSource = nombresCategorias;
                comboBox1.DisplayMember = "Nombre";
            }
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
    }
}
