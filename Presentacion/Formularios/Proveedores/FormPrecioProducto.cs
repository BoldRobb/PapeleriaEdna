using Azure;
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

namespace Presentacion.Formularios.Proveedores
{
    public partial class FormPrecioProducto : Form
    {
        int id_producto;
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        public double precioProducto;
        public FormPrecioProducto(int id)
        {
            id_producto = id;
            InitializeComponent();
            this.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.3);
            panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.1);
            this.textBoxPrecio.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.1);
            this.textBoxProducto.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.1);
        }

        private void FormPrecioProducto_Load(object sender, EventArgs e)
        {
            using (connection = conexion.GetConnection())
            {
                connection.Open();
                string query = "SELECT Nombre FROM Productos WHERE Id_Producto = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id_producto);
                    textBoxProducto.Text = (string)command.ExecuteScalar();
                }
            }
        }

        private void buttonRealizar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBoxPrecio_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxPrecio.Text, out _))
            {
                buttonRealizar.Enabled = true;
                precioProducto= double.Parse(textBoxPrecio.Text);
            }
            else
            {
                MessageBox.Show("Favor de ingresar una cantidad valida");
            }
        }
    }
}
