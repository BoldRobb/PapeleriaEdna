using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion.Formularios.Inventario
{
    public partial class AgregarCategoria : Form
    {
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        public static string category_name = "";
        public static string category_description = "";

        public AgregarCategoria()
        {
            connection = conexion.GetConnection();
            InitializeComponent();
            this.BackColor = ThemeColor.SecondaryColor;
            this.FormBorderStyle = FormBorderStyle.None;
            Panel titlePanel = new Panel();
            titlePanel.Dock = DockStyle.Top;
            titlePanel.BackColor = ThemeColor.SecondaryColor;
            titlePanel.Height = 30;
            textBoxDescripcion.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxNombre.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            name_label.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            label2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_label_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            category_name = textBoxNombre.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            category_description = textBoxDescripcion.Text;
        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void return_Click(object sender, EventArgs e)
        {
            this.BackColor = ThemeColor.SecondaryColor;
            this.Close();
        }

        private void AgregarCategoria_Load(object sender, EventArgs e)
        {

            this.ShowIcon = false;
            this.BackColor = ThemeColor.SecondaryColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = ThemeColor.SecondaryColor;

            if (string.IsNullOrWhiteSpace(category_name))
            {
                // Si category_name es nulo o una cadena vacía, muestra un mensaje al usuario
                MessageBox.Show("Por favor, ingrese un nombre para la categoría.");
            }
            else
            {
                using (connection)
                {

                    connection.Open();
                    try
                    {


                        // Crea y ejecuta el comando SQL solo si category_name no es nulo ni una cadena vacía
                        SqlCommand command = new SqlCommand("insert into Categorias values (@Nombre, @Descripción)", connection);
                        command.Parameters.AddWithValue("@Nombre", category_name);
                        command.Parameters.AddWithValue("@Descripción", category_description);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Categoría agregada");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }



        }
    }
}
