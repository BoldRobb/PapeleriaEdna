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
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion.Formularios.Ventas
{
    public partial class FormReporte : Form
    {
        bool v1, v2;
        string ruta;
        DateTime fechainicio, fechafin;
        ConexionBD conexionBD = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        public FormReporte()
        {
            InitializeComponent();
            this.BackColor = ThemeColor.SecondaryColor;
            panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            textBox1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.1);
            textBox1.ForeColor = Color.White;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            fechainicio = monthCalendar1.SelectionStart;
            label6.Text = fechainicio.ToString();
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            fechafin = monthCalendar2.SelectionStart;
            label7.Text = fechafin.ToString();
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

                    ruta += "\\Reporte_Ventas_" + fechainicio.Day.ToString() + "_" + fechainicio.Month.ToString() + "_" + fechainicio.Year.ToString() + "_" + fechafin.Day.ToString() + "_" + fechafin.Month.ToString() + "_" + fechafin.Year.ToString() + ".pdf";
                }
            }
        }
        private void GenerarReporteVentas(string nombreArchivo, DateTime tiempomin, DateTime tiempofin)
        {
            string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logo_letras.png");
            // Escribe tu consulta SQL para obtener datos de ventas
            string consulta = "SELECT  * FROM VistaVentasConClienteYNombre WHERE FechaVenta >= @FechaInicio AND FechaVenta < DATEADD(DAY, 1, @FechaFin);";

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
                                document.Add(new Paragraph("Reporte de ventas\n"));

                                document.Add(new Paragraph("Periodo del: \n" + tiempomin + " al " + tiempofin)).SetTextAlignment(TextAlignment.LEFT);
                                document.Add(new Paragraph("\n"));
                                // Agrega una tabla al documento
                                iText.Layout.Element.Table table = new iText.Layout.Element.Table(7);

                                // Agrega encabezados de columna
                                table.AddHeaderCell("Folio");
                                table.AddHeaderCell("Monto total");
                                table.AddHeaderCell("Fecha de la venta");
                                table.AddHeaderCell("Comentarios");
                                table.AddHeaderCell("ID cliente");
                                table.AddHeaderCell("Nombres");
                                table.AddHeaderCell("Apellidos");

                                // Lee los datos y agrega filas a la tabla
                                while (reader.Read())
                                {
                                    table.AddCell(reader.GetInt32(0).ToString());
                                    table.AddCell(reader.GetDouble(1).ToString());
                                    table.AddCell(reader.GetDateTime(2).ToString("yyyy-MM-dd"));
                                    table.AddCell(reader.GetString(3));
                                    table.AddCell(reader.GetInt32(4).ToString());
                                    table.AddCell(reader.GetString(5));
                                    table.AddCell(reader.GetString(6));

                                }

                                // Agrega la tabla al documento
                                document.Add(table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER));
                            }
                        }
                    }
                }
            }

            MessageBox.Show($"El reporte de ventas se ha generado en {nombreArchivo}");
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRealizar_Click(object sender, EventArgs e)
        {
            GenerarReporteVentas(ruta, fechainicio, fechafin);
        }
    }
}
