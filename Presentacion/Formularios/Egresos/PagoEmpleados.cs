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
using Microsoft.Data.SqlClient;

namespace Presentacion.Formularios.Egresos
{
    public partial class PagoEmpleados : Form
    {
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        public int idEmpleado;
        public float monto;
        public string fechaCad;
        public string description;
        public PagoEmpleados()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            connection = conexion.GetConnection();
            this.BackColor = ThemeColor.SecondaryColor;
            panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            comboBox1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            comboBox1.ForeColor = Color.White;
            textBox2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBox2.ForeColor = Color.White;
            textBox1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBox1.ForeColor = Color.White;
        }

        private void PagoEmpleados_Load(object sender, EventArgs e)
        {
            CargarDatosComboBox();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = monthCalendar1.SelectionRange.Start;
            fechaCad = fechaSeleccionada.ToString("yyyy-MM-dd");
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si hay un elemento seleccionado en el ComboBox
            if (comboBox1.SelectedItem != null)
            {
                // Obtener el nombre completo seleccionado en el ComboBox
                ComboBoxItem selectedItem = (ComboBoxItem)comboBox1.SelectedItem;
                string nombreCompletoSeleccionado = selectedItem.Text;

                // Obtener el ID_Empleado correspondiente utilizando la función
                idEmpleado = ObtenerIdEmpleadoDesdeBaseDeDatos(nombreCompletoSeleccionado);

                // Realizar acciones adicionales según el ID_Empleado seleccionado
                monto = ObtenerSueldoDesdeDetallesEmpleados(idEmpleado);
                textBox1.Text = monto.ToString();
            }
        }

        private void CargarDatosComboBox()
        {
            // Conexión a la base de datos (ajusta la cadena de conexión según tu configuración)
            using (connection)
            {
                connection.Open();

                // Consulta SQL para obtener los nombres y apellidos de los empleados
                string query = "SELECT [ID_Empleado], [Nombre], [Apellido] FROM [Papeleria].[dbo].[Empleados]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Limpiar el ComboBox antes de agregar nuevos elementos
                        comboBox1.Items.Clear();

                        // Iterar a través de los resultados y agregarlos al ComboBox
                        while (reader.Read())
                        {
                            // Concatenar nombre y apellido en una sola cadena
                            string nombreCompleto = $"{reader["Nombre"]} {reader["Apellido"]}";

                            // Agregar la cadena al ComboBox y usar el ID_Empleado como valor asociado
                            comboBox1.Items.Add(new ComboBoxItem(nombreCompleto, reader["ID_Empleado"].ToString()));
                        }
                    }
                }
            }
        }

        private int ObtenerIdEmpleadoDesdeBaseDeDatos(string nombreCompleto)
        {
            using (connection = conexion.GetConnection())
            {
                connection.Open();

                // Consulta SQL para obtener el ID_Empleado según el nombre y apellido
                string query = "SELECT [ID_Empleado] FROM [Papeleria].[dbo].[Empleados] WHERE CONCAT([Nombre], ' ', [Apellido]) = @NombreCompleto";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        // Manejo de error o valor predeterminado si no se encuentra el ID_Empleado
                        return -1; // O cualquier otro valor que tenga sentido en tu aplicación
                    }
                }
            }
        }

        private float ObtenerSueldoDesdeDetallesEmpleados(int idEmpleado)
        {
            using (connection = conexion.GetConnection())
            {
                connection.Open();

                // Consulta SQL para obtener el sueldo del empleado según el ID_Empleado en Detalles_Empleados
                string query = "SELECT [Pago] FROM [Papeleria].[dbo].[Detalles_Empleados] WHERE [ID_Empleado] = @IdEmpleado";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToSingle(result);
                    }
                    else
                    {
                        // Manejo de error o valor predeterminado si no se encuentra el sueldo
                        return 0.0F; // O cualquier otro valor que tenga sentido en tu aplicación
                    }
                }
            }
        }



        // Clase simple para almacenar un par de valores (nombre y valor) en el ComboBox
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public ComboBoxItem(string text, string value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (connection = conexion.GetConnection())
            {
                connection.Open();
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO PagoEmpleados (Monto, Descripcion, ID_Empleado, Fecha) VALUES (@Monto, @Descripcion, @ID, @Fecha)", connection);
                    command.Parameters.AddWithValue("@Monto", monto);
                    command.Parameters.AddWithValue("@Descripcion", description);
                    command.Parameters.AddWithValue("@ID", idEmpleado);
                    command.Parameters.AddWithValue("@Fecha", fechaCad);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Pago fijo agregado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            description = textBox2.Text;
        }
    }
}
