using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios.Proveedores
{
    public partial class FormNuevaCompra : Form
    {
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        int id_proveedor;
        double total;
        public FormNuevaCompra()
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
            comboBoxProductos.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.2);
            comboBoxProveedores.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.2);
            comboBoxProveedores.ForeColor = Color.White;
            comboBoxProductos.ForeColor = Color.White;
        }

        private void FormNuevaCompra_Load(object sender, EventArgs e)
        {
            LeerInfoProveedores();
        }
        private void LeerInfoProveedores()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = conexion.GetConnection();
                connection.Open();
            }

            using (connection = conexion.GetConnection())
            {

                List<string> nombresCategorias = ObtenerNombresEmpleadosDesdeBaseDeDatos(connection);


                comboBoxProveedores.DataSource = nombresCategorias;
                comboBoxProveedores.DisplayMember = "Nombre";

            }


        }
        private void LeerInfoProductos(string nombreProveedor)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = conexion.GetConnection();
                connection.Open();
            }
            using (connection = conexion.GetConnection())
            {
                connection.Open();
                string query = "SELECT ID_Proveedor FROM Proveedores WHERE Nombre = @Nombre";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombreProveedor);
                    id_proveedor = (int)command.ExecuteScalar();
                }
            }
            using (connection)
            {


                List<string> nombresCategorias = ObtenerProductosProveedoresDesdeBaseDeDatos(connection, id_proveedor);


                comboBoxProductos.DataSource = nombresCategorias;
                comboBoxProductos.DisplayMember = "Nombre";

            }


        }

        private List<string> ObtenerNombresEmpleadosDesdeBaseDeDatos(SqlConnection connection)
        {
            List<string> nombresEmpleados = new List<string>();
            string query = "SELECT Nombre FROM Proveedores";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombreEmpleado = reader["Nombre"].ToString();
                        nombresEmpleados.Add(nombreEmpleado);
                    }
                }
            }
            return nombresEmpleados;
        }
        private List<string> ObtenerProductosProveedoresDesdeBaseDeDatos(SqlConnection connection, int ID_Empleado)
        {
            List<string> nombresProductos = new List<string>();
            string query = "SELECT P.Nombre FROM Productos P INNER JOIN Catalago_Proveedor ON P.ID_Producto = Catalago_Proveedor.ID_Producto WHERE Catalago_Proveedor.ID_Proveedor = @ID_Proveedor;";
            using (SqlCommand command = new SqlCommand(query, connection = conexion.GetConnection()))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ID_Proveedor", ID_Empleado);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        string nombreProducto = reader.GetString(0);
                        nombresProductos.Add(nombreProducto);

                    }


                }

                reader.Close();
            }
            return nombresProductos;
        }
        private void comboBoxProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = false;
            dataGridView1.Rows.Clear();
            LeerInfoProductos(comboBoxProveedores.Text);
        }

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAñadir.Enabled = true;
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            string nombre = comboBoxProductos.Text;
            if (ExisteValorEspecificoEnColumna(nombre, "Producto"))
            {
                MessageBox.Show("Producto ya existente en la compra");
            }
            else
            {
                InsertarFilaEnPrimeraPosicion(comboBoxProductos.Text, 1, ConseguirPrecioProductoConNombre(ConseguirIDProductoConNombre(comboBoxProductos.Text)));
            }

        }
        private int ConseguirIDProductoConNombre(string nombre)
        {
            int id = 0;

            string query = "SELECT ID_producto FROM Productos WHERE Nombre = @Nombre";
            using (SqlCommand command = new SqlCommand(query, connection = conexion.GetConnection()))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Nombre", nombre);
                id = (int)command.ExecuteScalar();
            }



            return id;
        }
        private double ConseguirPrecioProductoConNombre(int id)
        {
            double precio = 0;

            string query = "SELECT Precio FROM Catalago_Proveedor WHERE ID_Producto = @ID";
            using (SqlCommand command = new SqlCommand(query, connection = conexion.GetConnection()))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ID", id);
                precio = (double)command.ExecuteScalar();
            }



            return precio;
        }

        private void InsertarFilaEnPrimeraPosicion(string a1, int a2, double a3)
        {
            button2.Enabled = true;
            if (a2 != 0)
            {
                DataGridViewRow nuevaFila = new DataGridViewRow();

                // Crear celdas para la nueva fila (ajusta según la cantidad y tipo de columnas en tu DataGridView)
                DataGridViewTextBoxCell celda1 = new DataGridViewTextBoxCell();
                celda1.Value = a1;  // Puedes asignar valores a las celdas según tus necesidades
                DataGridViewTextBoxCell celda2 = new DataGridViewTextBoxCell();
                celda2.Value = a2;
                DataGridViewTextBoxCell celda3 = new DataGridViewTextBoxCell();
                celda3.Value = a3;
                // Agregar las celdas a la nueva fila
                nuevaFila.Cells.Add(celda1);
                nuevaFila.Cells.Add(celda2);
                nuevaFila.Cells.Add(celda3);

                // Insertar la nueva fila en la primera posición
                dataGridView1.Rows.Insert(0, nuevaFila);
            }
            else
            {

            }
            double suma = 0;

            // Iterar a través de las filas del DataGridView
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                // Obtener el valor de la celda en la columna específica
                object valorCelda = fila.Cells["Subtotal"].Value;

                // Verificar si el valor de la celda no es nulo
                if (valorCelda != null)
                {
                    // Intentar convertir el valor a decimal y sumarlo
                    if (double.TryParse(valorCelda.ToString(), out double valorDecimal))
                    {
                        suma += valorDecimal;
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            labelTotal.Text = "Total: " + suma + "$";
            total = suma;


        }
        private bool ExisteValorEspecificoEnColumna(string valorEspecifico, string nombreColumna)
        {
            // Supongamos que tienes un DataGridView llamado dataGridView1

            // Iterar a través de las filas del DataGridView
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                // Obtener el valor de la celda en la columna específica
                object valorCelda = fila.Cells[nombreColumna].Value;

                // Verificar si el valor es igual al valor específico
                if (valorCelda != null && valorCelda.ToString() == valorEspecifico)
                {
                    return true; // El valor específico se encuentra en al menos una fila
                }
            }

            return false; // El valor específico no se encuentra en ninguna fila
        }
        private void EliminarFilaPorProducto(string productoAEliminar)
        {
            // Supongamos que tienes un DataGridView llamado dataGridView1

            // Iterar a través de las filas del DataGridView
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                // Obtener el valor de la celda en la columna "Producto"
                object valorCeldaProducto = fila.Cells["Producto"].Value;

                // Verificar si el valor de la celda "Producto" coincide con el producto que queremos eliminar
                if (valorCeldaProducto != null && valorCeldaProducto.ToString() == productoAEliminar)
                {
                    // Eliminar la fila
                    dataGridView1.Rows.Remove(fila);
                    return; // Terminar el bucle después de eliminar la primera ocurrencia del producto
                }
            }

            // Si no se encuentra ninguna fila que cumpla la condición, puedes mostrar un mensaje o realizar otras acciones según tus necesidades
            MessageBox.Show($"No se encontró ninguna fila con el producto {productoAEliminar}");
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la modificación se realizó en una celda de interés (por ejemplo, en la columna "Producto")
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Cantidad")
            {

                // Obtener la fila modificada

                string valorProducto = (string)dataGridView1.Rows[e.RowIndex].Cells["Producto"].Value;
                double valorPrecio = ConseguirPrecioProductoConNombre(ConseguirIDProductoConNombre(valorProducto));
                int valorCelda = int.Parse((string)dataGridView1.Rows[e.RowIndex].Cells["Cantidad"].Value);

                EliminarFilaPorProducto(valorProducto);
                InsertarFilaEnPrimeraPosicion(valorProducto, valorCelda, valorCelda * valorPrecio);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_pedido;
            string query = "INSERT INTO Pedidos_Proveedor VALUES (@ID_Proveedor, @Fecha, @Estado, @Monto, @Fecha_pago, @desc); SELECT SCOPE_IDENTITY();";
            using (SqlCommand command = new SqlCommand(query, connection = conexion.GetConnection()))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ID_Proveedor", id_proveedor);
                command.Parameters.AddWithValue("@Fecha", DateTime.Now);
                command.Parameters.AddWithValue("@Estado", "Sin pagar");
                command.Parameters.AddWithValue("@Monto", total);
                command.Parameters.AddWithValue("@Fecha_pago", DateTime.Now);
                command.Parameters.AddWithValue("@desc", " ");
                object result = command.ExecuteScalar();
                id_pedido = Convert.ToInt32(result);
            }
            query = "INSERT INTO Pedidos_Detalles VALUES (@ID_Pedido,@ID_Producto,@Cantidad, @Subtotal)";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                object valorCeldaNombre = row.Cells["Producto"].Value;
                object valorCeldaCantidad = row.Cells["Cantidad"].Value;
                object valorCeldaSubtotal = row.Cells["Subtotal"].Value;
                using (SqlCommand command = new SqlCommand(query, connection = conexion.GetConnection()))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@ID_Pedido", id_pedido);
                    command.Parameters.AddWithValue("@ID_Producto", ConseguirIDProductoConNombre((string)valorCeldaNombre));
                    command.Parameters.AddWithValue("@Cantidad", (int)valorCeldaCantidad);
                    command.Parameters.AddWithValue("@Subtotal", (double)valorCeldaSubtotal);
                    command.ExecuteNonQuery();
                }
            }
            dataGridView1.Rows.Clear();
            MessageBox.Show("Compra agregada con exito");


        }
    }
}
