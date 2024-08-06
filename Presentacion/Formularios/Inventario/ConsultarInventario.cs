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
    public partial class ConsultarInventario : Form
    {
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        private bool dataGridViewConfigurado = false;
        public ConsultarInventario()
        {
            InitializeComponent();
            this.BackColor = ThemeColor.SecondaryColor;
            textBox1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBox1.ForeColor = Color.White;
            dataGridView1.BackgroundColor = ThemeColor.PrimaryColor;
            dataGridView1.DefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            dataGridView1.DefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.2);
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.25);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.1);
            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.15);
            dataGridView1.ForeColor = Color.White;

            dataGridView1.AutoSize = false;
        }

        private void ConsultarInventario_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(textBox1.Text);
        }

        private void CargarProductos(string desc)
        {
            desc = "%" + desc + "%";

            string sql = "SELECT ID_Producto AS ID, Nombre, Precio, Descripcion, Estado_Producto, Cantidad FROM Productos where Descripcion like @Desc or Nombre like @Desc or ID_Producto like @Desc or Estado_Producto like @Desc or Cantidad like @Desc";
            SqlCommand command = new SqlCommand(sql, connection);
            connection = conexion.GetConnection();
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Desc", desc);
            SqlDataAdapter dataadapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "result");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "result";
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 40;
            dataGridView1.Columns[5].Width = 80;
            if (!dataGridViewConfigurado)
            {
                // Configurar el DataGridView
                ConfigurarDataGridView();

                // Marcar que el DataGridView ha sido configurado
                dataGridViewConfigurado = true;
            }
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                fila.Height = 100; // Establece el alto deseado para todas las filas (en este caso, 50 píxeles)
            }

            //Responsabilidad cambiar tiempo JS Rejects a 1, 1600 
        }

        private void ConfigurarDataGridView()
        {
            // Asumiendo que tienes un DataGridView llamado dataGridView1

            // Verificar si la columna ya existe


            // Agregar el evento CellContentClick para manejar los clics en los botones


            // Asegurar que la propiedad AutoGenerateColumns esté establecida en false
            dataGridView1.AutoGenerateColumns = false;

            // Asignar datos a tu DataGridView
            // ...

            // Establecer el alto de las filas (opcional)
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                fila.Height = 30; // Establecer el alto deseado para todas las filas (en este caso, 30 píxeles)
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
