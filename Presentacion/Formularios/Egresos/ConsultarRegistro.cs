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

namespace Presentacion.Formularios.Egresos
{
    public partial class ConsultarRegistro : Form
    {
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        private bool dataGridViewConfigurado = false;
        public int option;
        public string optionCad;
        public ConsultarRegistro()
        {
            InitializeComponent();

            comboBox1.Items.Add("Renta");
            comboBox1.Items.Add("Luz");
            comboBox1.Items.Add("Agua");
            comboBox1.Items.Add("Internet");
            comboBox1.Items.Add("Pago de empleados");
            comboBox1.Items.Add("Pago a proveedores");
            connection = conexion.GetConnection();
        }

        private void ConsultarRegistro_Load(object sender, EventArgs e)
        {
            this.BackColor = ThemeColor.SecondaryColor;
            comboBox1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            dataGridView1.BackgroundColor = ThemeColor.PrimaryColor;
            dataGridView1.DefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            dataGridView1.DefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.2);
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.25);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.1);
            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.15);

            dataGridView1.AutoSize = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            optionCad = comboBox1.SelectedItem.ToString();



            if (optionCad == "Renta")
            {
                option = 1;
                CargarPagosFijos(optionCad);
            }
            else if (optionCad == "Luz")
            {
                option = 1;
                CargarPagosFijos(optionCad);
            }
            else if (optionCad == "Agua")
            {
                option = 1;
                CargarPagosFijos(optionCad);
            }
            else if (optionCad == "Internet")
            {
                option = 1;
                CargarPagosFijos(optionCad);
            }
            else if (optionCad == "Pago de empleados")
            {
                option = 2;
                CargarPagoEmpleados();
            }
            else if (optionCad == "Pago a proveedores")
            {
                option = 3;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarPagosFijos(string optionCad)
        {
            optionCad = "%" + optionCad + "%";

            string sql = "SELECT Tipo, Fecha, Monto, Descripcion FROM PagosFijos WHERE Tipo LIKE @option";

            SqlCommand command = new SqlCommand(sql, connection);
            connection = conexion.GetConnection();
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@option", optionCad);

            SqlDataAdapter dataadapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();

            connection.Open();
            dataadapter.Fill(ds, "result");
            connection.Close();

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "result";

            // Ajusta el ancho de las columnas según sea necesario
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 300;

            if (!dataGridViewConfigurado)
            {
                // Configurar el DataGridView
                ConfigurarDataGridView();

                // Marcar que el DataGridView ha sido configurado
                dataGridViewConfigurado = true;
            }

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                fila.Height = 100; // Establece el alto deseado para todas las filas (en este caso, 100 píxeles)
            }

            // Responsabilidad cambiar tiempo JS Rejects a 1, 1600
        }

        private void CargarPagoEmpleados()
        {
            optionCad = "%" + optionCad + "%";

            string sql = "SELECT Monto, Fecha, Descripcion, ID_Empleado FROM PagoEmpleados";

            SqlCommand command = new SqlCommand(sql, connection);
            connection = conexion.GetConnection();
            command = new SqlCommand(sql, connection);


            SqlDataAdapter dataadapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();

            connection.Open();
            dataadapter.Fill(ds, "result");
            connection.Close();

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "result";

            // Ajusta el ancho de las columnas según sea necesario
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 80;

            if (!dataGridViewConfigurado)
            {
                // Configurar el DataGridView
                ConfigurarDataGridView();

                // Marcar que el DataGridView ha sido configurado
                dataGridViewConfigurado = true;
            }

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                fila.Height = 100; // Establece el alto deseado para todas las filas (en este caso, 100 píxeles)
            }
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
