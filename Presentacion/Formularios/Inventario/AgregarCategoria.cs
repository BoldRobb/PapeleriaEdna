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

namespace Presentacion.Formularios.Inventario
{
    public partial class AgregarCategoria : Form
    {
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        public static string category_name;
        public static string category_description;

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

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_label_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            category_name = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            category_description = textBox1.Text;
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

            connection.Open();
            try
            {

                SqlCommand command = new SqlCommand("insert into Categorias values (@Nombre, @Descripción)", connection);
                command.Parameters.AddWithValue("@Nombre", category_name);
                command.Parameters.AddWithValue("@Descripción", category_description);
                command.ExecuteNonQuery();
                MessageBox.Show("Categoria agregada");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
