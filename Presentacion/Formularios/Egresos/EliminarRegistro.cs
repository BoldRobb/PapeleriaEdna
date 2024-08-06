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

namespace Presentacion.Formularios.Egresos
{
    public partial class EliminarRegistro : Form
    {
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        private bool dataGridViewConfigurado = false;
        public string optionCad;
        public string fechaCadena;
        public int option;
        public EliminarRegistro()
        {
            InitializeComponent();
            comboBox1.Items.Add("Renta");
            comboBox1.Items.Add("Luz");
            comboBox1.Items.Add("Agua");
            comboBox1.Items.Add("Internet");
            comboBox1.Items.Add("Pago de empleados");
            comboBox1.Items.Add("Pago a proveedores");
            connection = conexion.GetConnection();
            this.BackColor = ThemeColor.SecondaryColor;
            comboBox1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            comboBox1.ForeColor = Color.White;
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

        private void EliminarRegistro_Load(object sender, EventArgs e)
        {

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
            DateTime fechaSeleccionada = monthCalendar1.SelectionRange.Start;
            fechaCadena = fechaSeleccionada.ToString("yyyy-MM-dd");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica la opción seleccionada
                if (option == 1)
                {
                    // Confirmar antes de eliminar
                    if (MessageBox.Show("¿Está seguro de que desea eliminar el registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        EliminarRegPagoFijo(fechaCadena, optionCad);
                    }
                }
                else if (option == 2)
                {
                    // Confirmar antes de eliminar
                    if (MessageBox.Show("¿Está seguro de que desea eliminar el registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        EliminarRegistroPagoEmpleados(fechaCadena);
                    }
                }
                else if (option == 3)
                {
                    // Confirmar antes de eliminar
                    if (MessageBox.Show("¿Está seguro de que desea eliminar el registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //GGS;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar el registro: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 200;

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

        private void EliminarRegPagoFijo(string fechaCadena, string optionCad)
        {
            try
            {
                // Construye la cadena SQL para eliminar el registro
                string sql = "DELETE FROM PagosFijos WHERE Fecha = @Fecha AND Tipo = @Tipo";

                // Crea el comando SQL
                SqlCommand command = new SqlCommand(sql, connection);
                connection = conexion.GetConnection();
                command = new SqlCommand(sql, connection);

                // Agrega los parámetros
                command.Parameters.AddWithValue("@Fecha", fechaCadena);
                command.Parameters.AddWithValue("@Tipo", optionCad);

                // Abre la conexión y ejecuta la consulta de eliminación
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                // Verifica si se eliminó algún registro
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registro eliminado exitosamente.");
                    // Vuelve a cargar los datos en el DataGridView después de la eliminación
                    CargarPagosFijos(optionCad);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún registro para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar el registro: " + ex.Message);
            }
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



        private void EliminarRegistroPagoEmpleados(string fechaSeleccionada)
        {
            try
            {
                // Convierte la fecha a formato de cadena


                // Construye la cadena SQL para eliminar el registro
                string sql = "DELETE FROM PagoEmpleados WHERE Fecha = @Fecha";

                // Crea el comando SQL
                SqlCommand command = new SqlCommand(sql, connection);
                connection = conexion.GetConnection();
                command = new SqlCommand(sql, connection);

                // Agrega el parámetro
                command.Parameters.AddWithValue("@Fecha", fechaCadena);

                // Abre la conexión y ejecuta la consulta de eliminación
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                // Verifica si se eliminó algún registro
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registro eliminado exitosamente.");
                    // Vuelve a cargar los datos en el DataGridView después de la eliminación
                    CargarPagoEmpleados();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún registro para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar el registro: " + ex.Message);
            }
        }
    }


}
