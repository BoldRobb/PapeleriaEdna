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
    public partial class EliminarCategoria : Form
    {
        public string selectedCategory;
        public SqlCommand command;
        public SqlConnection connection;
        private Button button1;
        string connectionString = "Server=KevinMN27\\SQLEXPRESS;DataBase=Papeleria; integrated security= true;Encrypt=False";



        public EliminarCategoria()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                selectedCategory = comboBox1.SelectedItem.ToString();
            }
            else
            {
                selectedCategory = null; // Si no hay selección válida, puedes establecer la variable como nula
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

        private void button2_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM Categorias WHERE Nombre = @Nombre";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", selectedCategory); // Establece el valor del parámetro @Nombre

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // El registro se eliminó correctamente.
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = ThemeColor.SecondaryColor;
            this.Close();
        }
    }


}





