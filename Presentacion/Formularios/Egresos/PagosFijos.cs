using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Presentacion.Formularios.Egresos
{
    public partial class PagosFijos : Form
    {
        public string payOptionCad;
        public float monto;
        public string description;
        public int optionPay;
        public string fechaCadena;
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        public PagosFijos()
        {
            InitializeComponent();
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

        private void PagosFijos_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Renta");
            comboBox1.Items.Add("Luz");
            comboBox1.Items.Add("Agua");
            comboBox1.Items.Add("Internet");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            payOptionCad = comboBox1.SelectedItem.ToString();

        }

        private void textBoxFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            monto = float.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            description = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (connection = conexion.GetConnection())
            {
                connection.Open();
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO PagosFijos (Monto, Descripcion, Tipo, Fecha) VALUES (@Monto, @Descripcion, @OpcionPago, @Fecha)", connection);
                    command.Parameters.AddWithValue("@Monto", monto);
                    command.Parameters.AddWithValue("@Descripcion", description);
                    command.Parameters.AddWithValue("@OpcionPago", payOptionCad);
                    command.Parameters.AddWithValue("@Fecha", fechaCadena);
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = monthCalendar1.SelectionRange.Start;
            fechaCadena = fechaSeleccionada.ToString("yyyy-MM-dd");
        }


    }
}
