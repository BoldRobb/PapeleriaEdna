using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Presentacion.Formularios.Ventas
{
    public partial class FormVentaNueva : Form
    {
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        private bool dataGridViewConfigurado = false;
        private double subtotal;
        String nombreCliente;
        string nombre, apellido, direccion, telefono, correo, rfc, curp;
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
            dataGridView2.BackgroundColor = ThemeColor.SecondaryColor;
            dataGridView2.DefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            dataGridView2.DefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.2);
            dataGridView2.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.25);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.RowsDefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.1);
            dataGridView2.RowsDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.15);
            textBox1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBox1.ForeColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(textBox1.Text);

        }

        private void FormVentaNueva_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
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
        private string ObtenerValorCelda(string index)
        {
            // Verificar si hay al menos una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la primera fila seleccionada (puedes ajustar esto según tus necesidades)
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                // Verificar si la celda que te interesa existe
                if (filaSeleccionada.Cells[index] != null)
                {
                    // Obtener el valor de la celda específica
                    object valorCelda = filaSeleccionada.Cells[index].Value;
                    string valor = (string)valorCelda;
                    // Verificar si el valor no es nulo
                    if (valorCelda != null)
                    {
                        // Realizar la operación con el valor
                        return valor;
                    }
                    else
                    {
                        return "0";
                    }
                }
                else
                {
                    return "0";
                }
            }
            else
            {
                return "0";
            }
        }

        private double ObtenerPrecioCelda(string index)
        {
            // Supongamos que tienes un DataGridView llamado dataGridView1

            // Verificar si hay al menos una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la primera fila seleccionada (puedes ajustar esto según tus necesidades)
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                // Verificar si la celda que te interesa existe
                if (filaSeleccionada.Cells[index] != null)
                {
                    // Obtener el valor de la celda específica
                    object valorCelda = filaSeleccionada.Cells[index].Value;
                    double valor = (double)valorCelda;
                    // Verificar si el valor no es nulo
                    if (valorCelda != null)
                    {
                        // Realizar la operación con el valor
                        return valor;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Manejar el clic en el botón
            if (e.ColumnIndex == 5)
            {
                /*
                 Obtengo Nombre Y precio
                Si no existe, insertar id, cantidad 1 y precio normal
                Si existe, no insertar pero modificar cantidad a 2 y cambiar el precio por la cantidad|
                
                 */
                string nombre = ObtenerValorCelda("Nombre");
                double precio = ObtenerPrecioCelda("Precio");
                if (nombre != "0")
                {

                    if (ExisteValorEspecificoEnColumna(nombre, "Producto"))
                    {
                        int cant = ObtenerCantidadPorNombre(nombre) + 1;
                        EliminarFilaPorProducto(nombre);
                        InsertarFilaEnPrimeraPosicion(nombre, cant, precio * cant);

                    }
                    else
                    {
                        InsertarFilaEnPrimeraPosicion(nombre, 1, precio);
                    }


                }
            }
        }
        private void InsertarFilaEnPrimeraPosicion(string a1, int a2, double a3)
        {
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
                dataGridView2.Rows.Insert(0, nuevaFila);
            }
            else
            {

            }
            double suma = 0;

            // Iterar a través de las filas del DataGridView
            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                // Obtener el valor de la celda en la columna específica
                object valorCelda = fila.Cells["Precio"].Value;

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
            subtotal = suma;
            labelSubtotal.Text = "Subtotal: " + suma + "$";

        }
        private bool ExisteValorEspecificoEnColumna(string valorEspecifico, string nombreColumna)
        {
            // Supongamos que tienes un DataGridView llamado dataGridView1

            // Iterar a través de las filas del DataGridView
            foreach (DataGridViewRow fila in dataGridView2.Rows)
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
        private int ObtenerCantidadPorNombre(string nombreABuscar)
        {
            // Supongamos que tienes un DataGridView llamado dataGridView1

            // Iterar a través de las filas del DataGridView
            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                // Obtener el valor de la celda en la columna "Nombre"
                object valorCeldaNombre = fila.Cells["Producto"].Value;

                // Verificar si el valor de la celda "Nombre" coincide con el nombre que estamos buscando
                if (valorCeldaNombre != null && valorCeldaNombre.ToString() == nombreABuscar)
                {
                    // Si encontramos la fila con el nombre buscado, obtener el valor de la columna "Cantidad"
                    object valorCeldaCantidad = fila.Cells["Cantidad"].Value;

                    // Verificar si el valor de la celda "Cantidad" no es nulo
                    if (valorCeldaCantidad != null)
                    {
                        // Convertir el valor a un entero (o al tipo de datos correspondiente)
                        int cantidad = Convert.ToInt32(valorCeldaCantidad);
                        return cantidad;
                    }
                }
            }

            // Si no se encuentra ninguna fila que cumpla la condición, puedes devolver un valor predeterminado o lanzar una excepción según tus necesidades
            return -1; // Por ejemplo, devolver -1 si no se encuentra ninguna fila con el nombre especificado
        }
        private void EliminarFilaPorProducto(string productoAEliminar)
        {
            // Supongamos que tienes un DataGridView llamado dataGridView1

            // Iterar a través de las filas del DataGridView
            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                // Obtener el valor de la celda en la columna "Producto"
                object valorCeldaProducto = fila.Cells["Producto"].Value;

                // Verificar si el valor de la celda "Producto" coincide con el producto que queremos eliminar
                if (valorCeldaProducto != null && valorCeldaProducto.ToString() == productoAEliminar)
                {
                    // Eliminar la fila
                    dataGridView2.Rows.Remove(fila);
                    return; // Terminar el bucle después de eliminar la primera ocurrencia del producto
                }
            }

            // Si no se encuentra ninguna fila que cumpla la condición, puedes mostrar un mensaje o realizar otras acciones según tus necesidades
            MessageBox.Show($"No se encontró ninguna fila con el producto {productoAEliminar}");
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la modificación se realizó en una celda de interés (por ejemplo, en la columna "Producto")
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dataGridView2.Columns[e.ColumnIndex].Name == "Cantidad")
            {

                // Obtener la fila modificada

                string valorProducto = (string)dataGridView2.Rows[e.RowIndex].Cells["Producto"].Value;
                double valorPrecio = ObtenerPrecioPorNombre(valorProducto);
                int valorCelda = int.Parse((string)dataGridView2.Rows[e.RowIndex].Cells["Cantidad"].Value);

                EliminarFilaPorProducto(valorProducto);
                InsertarFilaEnPrimeraPosicion(valorProducto, valorCelda, valorCelda * valorPrecio);

            }
            double suma = 0;

            // Iterar a través de las filas del DataGridView
            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                // Obtener el valor de la celda en la columna específica
                object valorCelda = fila.Cells["Precio"].Value;

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
            labelSubtotal.Text = "Subtotal: " + suma + "$";
            subtotal = suma;
        }
        private double ObtenerPrecioPorNombre(string nombreProducto)
        {
            // Supongamos que tienes un DataGridView llamado dataGridViewProductos

            // Iterar a través de las filas del DataGridView
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                // Obtener el valor de la celda en la columna "Nombre"
                object valorCeldaNombre = fila.Cells["Nombre"].Value;

                // Verificar si el valor de la celda "Nombre" coincide con el nombre del producto que estamos buscando
                if (valorCeldaNombre != null && valorCeldaNombre.ToString() == nombreProducto)
                {
                    // Obtener el valor de la celda en la columna "Precio"
                    object valorCeldaPrecio = fila.Cells["Precio"].Value;

                    // Verificar si el valor de la celda "Precio" no es nulo
                    if (valorCeldaPrecio != null)
                    {
                        // Convertir el valor a decimal (o al tipo de datos correspondiente)
                        double precio = (double)valorCeldaPrecio;
                        return precio;
                    }
                }
            }

            // Si no se encuentra ninguna fila que cumpla la condición, puedes devolver un valor predeterminado o lanzar una excepción según tus necesidades
            return -1; // Por ejemplo, devolver -1 si no se encuentra ninguna fila con el nombre especificado
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Manejar el clic en el botón
            if (e.ColumnIndex == 3)
            {
                /*
                 Elimino la row que se selecciono
                
                 */
                string valorProducto = (string)dataGridView2.Rows[e.RowIndex].Cells["Producto"].Value;
                EliminarFilaPorProducto(valorProducto);
                double suma = 0;
                foreach (DataGridViewRow fila in dataGridView2.Rows)
                {
                    // Obtener el valor de la celda en la columna específica
                    object valorCelda = fila.Cells["Precio"].Value;

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
                labelSubtotal.Text = "Subtotal: " + suma + "$";
                subtotal = suma;
            }
        }
        private int ObtenerIDPorNombre(string nombreProducto)
        {
            // Supongamos que tienes un DataGridView llamado dataGridViewProductos

            // Iterar a través de las filas del DataGridView
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                // Obtener el valor de la celda en la columna "Nombre"
                object valorCeldaNombre = fila.Cells["Nombre"].Value;

                // Verificar si el valor de la celda "Nombre" coincide con el nombre del producto que estamos buscando
                if (valorCeldaNombre != null && valorCeldaNombre.ToString() == nombreProducto)
                {
                    // Obtener el valor de la celda en la columna "Precio"
                    object valorCeldaPrecio = fila.Cells["ID"].Value;

                    // Verificar si el valor de la celda "Precio" no es nulo
                    if (valorCeldaPrecio != null)
                    {
                        // Convertir el valor a decimal (o al tipo de datos correspondiente)
                        int precio = (int)valorCeldaPrecio;
                        return precio;
                    }
                }

            }
            return -1; // Por ejemplo, devolver -1 si no se encuentra ninguna fila con el nombre especificado
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int id_venta;
            int id_cliente;
            FormVenta_Info Info = new FormVenta_Info();
            if (Info.ShowDialog(this) == DialogResult.OK)
            {
                if (Info.radioButtonContado.Checked == true)
                {

                    nombreCliente = (String)Info.comboBoxClientes.SelectedItem;
                    FormVentaPago Pago = new FormVentaPago(subtotal);
                    if (Pago.ShowDialog(this) == DialogResult.OK)
                    {
                        //
                        //Venta a contado
                        //

                        string query = "SELECT ID_Cliente from Clientes where Apellido = @Apellido;";
                        string estado;
                        using (connection = conexion.GetConnection())
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@Apellido", (string)Info.comboBoxClientes.SelectedItem);
                            object result = command.ExecuteScalar();
                            id_cliente = (int)result;

                        }
                        using (connection = conexion.GetConnection())
                        {
                            connection.Open();
                            SqlCommand aggCmd = new SqlCommand("insert into Ventas values (@Monto, @Fecha, @Comentario); SELECT SCOPE_IDENTITY();", connection);
                            DateTime fechaActual = DateTime.Now;
                            aggCmd.Parameters.AddWithValue("@Monto", subtotal);
                            aggCmd.Parameters.AddWithValue("@Fecha", fechaActual);
                            aggCmd.Parameters.AddWithValue("@Comentario", Pago.Comentario);
                            object result = aggCmd.ExecuteScalar();
                            id_venta = Convert.ToInt32(result);
                        }
                        using (connection = conexion.GetConnection())
                        {
                            connection.Open();
                            SqlCommand aggCmd = new SqlCommand("insert into Ventas_Contado values (@ID_Venta, @ID_Cliente, @Monto, @Metodo);", connection);

                            aggCmd.Parameters.AddWithValue("@ID_Venta", id_venta);
                            aggCmd.Parameters.AddWithValue("@ID_Cliente", id_cliente);
                            aggCmd.Parameters.AddWithValue("@Monto", subtotal);
                            aggCmd.Parameters.AddWithValue("@Metodo", "Efectivo");
                            aggCmd.ExecuteNonQuery();

                        }

                        foreach (DataGridViewRow fila in dataGridView2.Rows)
                        {
                            using (connection = conexion.GetConnection())
                            {
                                connection.Open();
                                SqlCommand aggCmd = new SqlCommand("insert into Venta_Detalle values (@ID_Venta, @ID_Producto, @Cantidad, @Subtotal)", connection);
                                aggCmd.Parameters.AddWithValue("@ID_Venta", id_venta);
                                object valorCeldaNombre = fila.Cells["Producto"].Value;
                                object valorCeldaCantidad = fila.Cells["Cantidad"].Value;
                                object valorCeldaSubtotal = fila.Cells["Precio"].Value;
                                /*
                                 * Obtener ID con funcion dependiendo el nombre fila.cells["Producto"].value
                                 * Insertar id_venta
                                 * Obtener cantidad y subtotal fila.cells["Cantidad"].value fila.cells["Precio"].value
                                 */
                                int id_producto = ObtenerIDPorNombre((string)valorCeldaNombre);

                                aggCmd.Parameters.AddWithValue("@ID_Producto", id_producto);
                                aggCmd.Parameters.AddWithValue("@Cantidad", (int)valorCeldaCantidad);
                                aggCmd.Parameters.AddWithValue("@Subtotal", (double)valorCeldaSubtotal);
                                aggCmd.ExecuteNonQuery();

                            }


                        }
                        dataGridView2.Rows.Clear();
                        MessageBox.Show("Venta agregada correctamente");
                        if (MessageBox.Show("¿Desea generar factura?", "Factura",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FormFactura factura = new FormFactura();
                            if (factura.ShowDialog(this) == DialogResult.OK)
                            {
                                MessageBox.Show("Generando factura");

                                string rutan = factura.ruta + id_venta.ToString() + ".pdf";
                                GenerarFactura(rutan, id_venta, id_cliente, Pago.Comentario);
                            }
                        }
                        subtotal = 0;
                        labelSubtotal.Text = "Subtotal: 0$";
                        textBox1.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error al realizar el pago");
                    }
                }
                else if (Info.radioButtonCredito.Checked == true)
                {
                    //
                    //Venta a credito
                    //
                    nombreCliente = (String)Info.comboBoxClientes.SelectedItem;
                    FormVentaCredito formVentaCredito = new FormVentaCredito(nombreCliente, subtotal);
                    if (formVentaCredito.ShowDialog(this) == DialogResult.OK)
                    {
                        double total = formVentaCredito.subfinal;
                        string query = "SELECT ID_Cliente from Clientes where Apellido = @Apellido;";
                        string estado;
                        using (connection = conexion.GetConnection())
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@Apellido", (string)Info.comboBoxClientes.SelectedItem);
                            object result = command.ExecuteScalar();
                            id_cliente = (int)result;

                        }
                        using (connection = conexion.GetConnection())
                        {
                            connection.Open();
                            SqlCommand aggCmd = new SqlCommand("insert into Ventas values (@Monto, @Fecha, @Comentario); SELECT SCOPE_IDENTITY();", connection);
                            DateTime fechaActual = DateTime.Now;
                            aggCmd.Parameters.AddWithValue("@Monto", total);
                            aggCmd.Parameters.AddWithValue("@Fecha", fechaActual);
                            aggCmd.Parameters.AddWithValue("@Comentario", formVentaCredito.Comentario);
                            object result = aggCmd.ExecuteScalar();
                            id_venta = Convert.ToInt32(result);
                        }
                        using (connection = conexion.GetConnection())
                        {
                            connection.Open();
                            SqlCommand aggCmd = new SqlCommand("insert into Ventas_Credito values (@ID_Venta, @ID_Cliente, @Monto);", connection);

                            aggCmd.Parameters.AddWithValue("@ID_Venta", id_venta);
                            aggCmd.Parameters.AddWithValue("@ID_Cliente", id_cliente);
                            aggCmd.Parameters.AddWithValue("@Monto", total);

                            aggCmd.ExecuteNonQuery();

                        }
                        double creditodisponible;
                        using (connection = conexion.GetConnection())
                        {
                            connection.Open();
                            SqlCommand aggCmd = new SqlCommand("SELECT monto_disp FROM Cliente_Deudor WHERE ID_Cliente = @ID", connection);

                            aggCmd.Parameters.AddWithValue("@ID", id_cliente);


                            creditodisponible = (double)aggCmd.ExecuteScalar();

                        }
                        creditodisponible -= total;
                        double pagoxmes = total / formVentaCredito.meses;
                        using (connection = conexion.GetConnection())
                        {
                            connection.Open();
                            SqlCommand aggCmd = new SqlCommand("UPDATE Cliente_Deudor SET Monto_Disp = @MontoNuevo, Monto_Prox = @pagoxmes  WHERE ID_Cliente = @ID", connection);


                            aggCmd.Parameters.AddWithValue("@ID", id_cliente);
                            aggCmd.Parameters.AddWithValue("@MontoNuevo", creditodisponible);
                            aggCmd.Parameters.AddWithValue("@pagoxmes", pagoxmes);

                            aggCmd.ExecuteNonQuery();

                        }

                        foreach (DataGridViewRow fila in dataGridView2.Rows)
                        {
                            using (connection = conexion.GetConnection())
                            {
                                connection.Open();
                                SqlCommand aggCmd = new SqlCommand("insert into Venta_Detalle values (@ID_Venta, @ID_Producto, @Cantidad, @Subtotal)", connection);
                                aggCmd.Parameters.AddWithValue("@ID_Venta", id_venta);
                                object valorCeldaNombre = fila.Cells["Producto"].Value;
                                object valorCeldaCantidad = fila.Cells["Cantidad"].Value;
                                object valorCeldaSubtotal = fila.Cells["Precio"].Value;
                                /*
                                 * Obtener ID con funcion dependiendo el nombre fila.cells["Producto"].value
                                 * Insertar id_venta
                                 * Obtener cantidad y subtotal fila.cells["Cantidad"].value fila.cells["Precio"].value
                                 */
                                int id_producto = ObtenerIDPorNombre((string)valorCeldaNombre);

                                aggCmd.Parameters.AddWithValue("@ID_Producto", id_producto);
                                aggCmd.Parameters.AddWithValue("@Cantidad", (int)valorCeldaCantidad);
                                aggCmd.Parameters.AddWithValue("@Subtotal", (double)valorCeldaSubtotal);
                                aggCmd.ExecuteNonQuery();

                            }


                        }
                        dataGridView2.Rows.Clear();
                        MessageBox.Show("Venta agregada correctamente");
                        if (MessageBox.Show("¿Desea generar factura?", "Factura",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FormFactura factura = new FormFactura();
                            if (factura.ShowDialog(this) == DialogResult.OK) {
                                MessageBox.Show("Generando factura");
                                string rutan = factura.ruta +id_venta.ToString()+".pdf";
                                GenerarFactura(rutan, id_venta, id_cliente, formVentaCredito.Comentario);
                            }
                        }
                            
                        subtotal = 0;
                        labelSubtotal.Text = "Subtotal: 0$";
                        textBox1.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error al realizar el pago");
                    }

                }
                else
                {
                    MessageBox.Show("Favor de seleccionar un cliente");
                    nombreCliente = null;
                }

            }
        }
        private void GenerarFactura(string nombreArchivo, int id_ventaa, int id_clientee, string comentarios)
        {

            // Escribe tu consulta SQL para obtener datos de ventas
            string consulta = "SELECT  * FROM Resumen_Venta WHERE folio = @Folio;";
            //Sacar la informacion del cliente


            using(connection = conexion.GetConnection())
            {
                connection.Open();
                string query = "SELECT Nombre, Apellido FROM Clientes where ID_Cliente = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id_clientee);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            nombre = reader.GetString(0);
                            apellido = reader.GetString(1);
                        }

                    }
                    reader.Close();
                }
            }
            using (connection = conexion.GetConnection())
            {
                connection.Open();
                string query = "SELECT Direccion, Telefono, Correo, RFC, Curp FROM Cliente_Detalles where ID_Cliente = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id_clientee);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            direccion = reader.GetString(0);
                            telefono = reader.GetString(1);
                            correo = reader.GetString(2);
                            rfc = reader.GetString(3);
                            curp = reader.GetString(4);
                        }

                    }
                    reader.Close();
                }
            }

            using (connection = conexion.GetConnection())
            {

                connection.Open();

                // Configura un comando SQL
                using (SqlCommand command = new SqlCommand(consulta, connection))
                {
                    command.Parameters.AddWithValue("@Folio", id_ventaa);
                    // Crea un lector de datos
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Crea un documento PDF
                        using (PdfWriter writer = new PdfWriter(nombreArchivo))
                        {
                            using (PdfDocument pdf = new PdfDocument(writer))
                            {
                                string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logo_letras.png");
                                Document document = new Document(pdf);
                                Paragraph container = new Paragraph();
                                iText.Layout.Element.Image logo = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create(rutaImagen));
                                logo.SetHeight(80); // Ajusta la altura según tus necesidades
                                logo.SetWidth(225);  // Ajusta el ancho según tus necesidades
                                container.Add(logo).SetTextAlignment(TextAlignment.LEFT);
                                container.Add(new Paragraph("\t\t\tSoftware de papeleria.\n\t\t\tDireccion:\n\t\t\tCorreo:\n").SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.RIGHT).SetTextAlignment(TextAlignment.RIGHT));
                                container.Add(new iText.Layout.Element.Tab());
                                
                                document.Add(container);
                                document.SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT);
                                // Agrega encabezado al documento
                                document.Add(new Paragraph("Factura").SetFontSize(18));
                                document.Add(new Paragraph("Cliente: " + nombre + " " + apellido));
                                document.Add(new Paragraph("Direccion: "+direccion+"\tTelefono: "+telefono));
                                document.Add(new Paragraph("Correo: "+correo+"\tRFC:"+rfc));
                                document.Add(new Paragraph("CURP: "+curp));

                                document.Add(new Paragraph("\n"));

                                document.Add(new Paragraph("Resumen de la venta"));
                                // Agrega una tabla al documento
                                iText.Layout.Element.Table table = new iText.Layout.Element.Table(6);

                                // Agrega encabezados de columna
                                table.AddHeaderCell("Folio");
                                table.AddHeaderCell("Producto");
                                table.AddHeaderCell("Precio unitario");
                                table.AddHeaderCell("Descripcion");
                                table.AddHeaderCell("Cantidad");
                                table.AddHeaderCell("Subtotal");

                                // Lee los datos y agrega filas a la tabla
                                while (reader.Read())
                                {
                                    table.AddCell(reader.GetInt32(0).ToString());
                                    table.AddCell(reader.GetString(1));
                                    table.AddCell(reader.GetDouble(2).ToString());
                                    table.AddCell(reader.GetString(3));
                                    table.AddCell(reader.GetInt32(4).ToString());
                                    table.AddCell(reader.GetDouble(5).ToString());

                                }

                                // Agrega la tabla al documento
                                document.Add(table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER));
                                document.Add(new Paragraph("Total: $" + subtotal + " MXN").SetTextAlignment(TextAlignment.RIGHT));
                                document.Add(new Paragraph("Comentarios adicionales: "+comentarios));
                            }
                        }
                    }
                }
            }

            MessageBox.Show($"La factura se ha generado en {nombreArchivo}");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
