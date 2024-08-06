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

namespace Presentacion.Formularios.Ventas
{
    public partial class FormVentaNueva : Form
    {
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        public FormVentaNueva()
        {
            InitializeComponent();
            this.BackColor = ThemeColor.SecondaryColor;
            dataGridView1.BackgroundColor = ThemeColor.SecondaryColor;
            dataGridView1.DefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            dataGridView1.DefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.2);
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.25);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.1);
            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.15);
            panel1.BackColor = ThemeColor.PrimaryColor;
            panel2.BackColor = ThemeColor.PrimaryColor;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(textBox1.Text);

        }

        private void FormVentaNueva_Load(object sender, EventArgs e)
        {
            CargarProductos("");
        }

        private void CargarProductos(string desc)
        {
            desc = "%" + desc + "%";

            string sql = "SELECT Imagen, ID_Producto AS ID, Nombre, Precio, Descripcion FROM Productos where Descripcion like @Desc or Nombre like @Desc or ID_Producto like @Desc";
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
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[3].Width = 60;
            ConfigurarDataGridView();
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
            if (dataGridView1.Columns["Añadir"] == null)
            {
                // La columna no existe, entonces la agregamos
                AgregarColumnaBoton();
            }

            // Agregar el evento CellContentClick para manejar los clics en los botones
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;

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

        private void AgregarColumnaBoton()
        {
            // Crear una columna de botones
            DataGridViewButtonColumn columnaBoton = new DataGridViewButtonColumn();
            columnaBoton.HeaderText = "Añadir";
            columnaBoton.Text = "Añadir";
            columnaBoton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(columnaBoton);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Manejar el clic en el botón
            if (e.ColumnIndex == dataGridView1.Columns["Acciones"].Index && e.RowIndex >= 0)
            {

            }
        }

    }
}
