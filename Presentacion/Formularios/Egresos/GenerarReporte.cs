using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.Data.SqlClient;

namespace Presentacion.Formularios.Egresos
{
    public partial class GenerarReporte : Form
    {
        ConexionBD conexionBD = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        public string ruta;
        DateTime fechaInicio, fechaFin;
        public GenerarReporte()
        {
            InitializeComponent();
            this.BackColor = ThemeColor.SecondaryColor;
            panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            textBox1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            fechaInicio = monthCalendar1.SelectionStart;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            fechaFin = monthCalendar2.SelectionStart;
        }

        private void GenerarReporte_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    // El usuario seleccionó una carpeta, puedes usar dialog.SelectedPath para obtener la ruta seleccionada
                    ruta = dialog.SelectedPath;
                    textBox1.Text = ruta;
                    buttonRealizar.Enabled = true;
                    button2.Enabled = true;

                    ruta += "\\Reporte_" + fechaInicio.Day.ToString() + "_" + fechaInicio.Month.ToString() + "_" + fechaInicio.Year.ToString() + "_" + fechaFin.Day.ToString() + "_" + fechaFin.Month.ToString() + "_" + fechaFin.Year.ToString() + ".pdf";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRealizar_Click(object sender, EventArgs e)
        {
            GenerarReportePagosFijos(ruta, fechaInicio, fechaFin);
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerarReportePagosFijos(string nombreArchivo, DateTime tiempomin, DateTime tiempofin)
        {
            string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logo_letras.png");
            // Escribe tu consulta SQL para obtener datos de ventas
            string consulta = "SELECT * FROM PagosFijos WHERE Fecha >= @FechaInicio AND Fecha < DATEADD(DAY, 1, @FechaFin);";

            using (connection = conexionBD.GetConnection())
            {

                connection.Open();

                // Configura un comando SQL
                using (SqlCommand command = new SqlCommand(consulta, connection))
                {
                    command.Parameters.AddWithValue("@FechaInicio", tiempomin);
                    command.Parameters.AddWithValue("@FechaFin", tiempofin);
                    // Crea un lector de datos
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Crea un documento PDF
                        using (PdfWriter writer = new PdfWriter(nombreArchivo))
                        {
                            using (PdfDocument pdf = new PdfDocument(writer))
                            {
                                Document document = new Document(pdf);
                                Paragraph container = new Paragraph();
                                iText.Layout.Element.Image logo = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create(rutaImagen));
                                logo.SetHeight(80); // Ajusta la altura según tus necesidades
                                logo.SetWidth(225);  // Ajusta el ancho según tus necesidades
                                container.Add(logo).SetTextAlignment(TextAlignment.CENTER);
                                container.Add(new iText.Layout.Element.Tab());

                                document.Add(container);
                                document.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                                // Agrega encabezado al documento
                                document.Add(new Paragraph("Reporte de pagos fijos\n"));

                                document.Add(new Paragraph("Periodo del: \n" + tiempomin + " al " + tiempofin)).SetTextAlignment(TextAlignment.LEFT);
                                document.Add(new Paragraph("\n"));
                                // Agrega una tabla al documento
                                iText.Layout.Element.Table table = new iText.Layout.Element.Table(4);

                                // Agrega encabezados de columna
                                table.AddHeaderCell("Tipo de pago");
                                table.AddHeaderCell("Fecha de pago");
                                table.AddHeaderCell("Monto");
                                table.AddHeaderCell("Descripcion");


                                // Lee los datos y agrega filas a la tabla
                                while (reader.Read())
                                {
                                    table.AddCell(reader.GetString(0));
                                    table.AddCell(reader.GetDateTime(1).ToString("yyyy-MM-dd"));
                                    table.AddCell(reader.GetDouble(2).ToString());
                                    table.AddCell(reader.GetString(3));


                                }

                                // Agrega la tabla al documento
                                document.Add(table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER));
                            }
                        }
                    }
                }
            }

            MessageBox.Show($"El reporte de pagos fijos se ha generado en {nombreArchivo}");
        }

        private void GenerarReportePagosEmpleados(string nombreArchivo, DateTime tiempomin, DateTime tiempofin)
        {
            string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logo_letras.png");
            // Escribe tu consulta SQL para obtener datos de ventas
            string consulta = "SELECT  * FROM VistaPagoEmpleados WHERE Fecha >= @FechaInicio AND Fecha < DATEADD(DAY, 1, @FechaFin);";

            using (connection = conexionBD.GetConnection())
            {

                connection.Open();

                // Configura un comando SQL
                using (SqlCommand command = new SqlCommand(consulta, connection))
                {
                    command.Parameters.AddWithValue("@FechaInicio", tiempomin);
                    command.Parameters.AddWithValue("@FechaFin", tiempofin);
                    // Crea un lector de datos
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Crea un documento PDF
                        using (PdfWriter writer = new PdfWriter(nombreArchivo))
                        {
                            using (PdfDocument pdf = new PdfDocument(writer))
                            {
                                Document document = new Document(pdf);
                                Paragraph container = new Paragraph();
                                iText.Layout.Element.Image logo = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create(rutaImagen));
                                logo.SetHeight(80); // Ajusta la altura según tus necesidades
                                logo.SetWidth(225);  // Ajusta el ancho según tus necesidades
                                container.Add(logo).SetTextAlignment(TextAlignment.CENTER);
                                container.Add(new iText.Layout.Element.Tab());

                                document.Add(container);
                                document.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                                // Agrega encabezado al documento
                                document.Add(new Paragraph("Reporte de pago a empleados\n"));

                                document.Add(new Paragraph("Periodo del: \n" + tiempomin + " al " + tiempofin)).SetTextAlignment(TextAlignment.LEFT);
                                document.Add(new Paragraph("\n"));
                                // Agrega una tabla al documento
                                iText.Layout.Element.Table table = new iText.Layout.Element.Table(6);

                                // Agrega encabezados de columna
                                table.AddHeaderCell("ID Empleado");
                                table.AddHeaderCell("Nombre");
                                table.AddHeaderCell("Apellido");
                                table.AddHeaderCell("Monto");
                                table.AddHeaderCell("Fecha de pago");
                                table.AddHeaderCell("Descripcion");


                                // Lee los datos y agrega filas a la tabla
                                while (reader.Read())
                                {
                                    table.AddCell(reader.GetInt32(0).ToString());
                                    table.AddCell(reader.GetString(1));
                                    table.AddCell(reader.GetString(2));
                                    table.AddCell(reader.GetDouble(3).ToString());
                                    table.AddCell(reader.GetDateTime(4).ToString("yyyy-MM-dd"));
                                    table.AddCell(reader.GetString(5));



                                }

                                // Agrega la tabla al documento
                                document.Add(table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER));
                            }
                        }
                    }
                }
            }

            MessageBox.Show($"El reporte de pagos a empleados se ha generado en {nombreArchivo}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerarReportePagosEmpleados(ruta, fechaInicio, fechaFin);
        }
    }
}
