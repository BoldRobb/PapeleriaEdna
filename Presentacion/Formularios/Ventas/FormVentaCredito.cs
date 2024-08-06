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
    public partial class FormVentaCredito : Form
    {
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        string empl;
        public double subt, subfinal;
        public int meses;
        public string Comentario = " ";
        public FormVentaCredito(string empleado, double subtotal)
        {

            subt = subtotal;
            subfinal = subtotal * 1.05;
            empl = empleado;
            connection = conexion.GetConnection();
            connection.Open();
            InitializeComponent();
            this.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.3);
            panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.1);
            panel2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.1);
            panel3.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.1);
            textBoxApellidos.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxCreditoDisp.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxFechaPago.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxMontoProx.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxNombre.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxSubtotal.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxTotal.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
        }

        private void buttonRealizar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVentaCredito_Load(object sender, EventArgs e)
        {
            CargarInfoCliente();
        }

        private void CargarInfoCliente()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection = conexion.GetConnection();
                connection.Open();
            }

            int id_cliente;

            string query = "SELECT Nombre, Apellido FROM Clientes where Apellido = @Apellido";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Apellido", empl);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBoxNombre.Text = reader.GetString(0);
                        textBoxApellidos.Text = reader.GetString(1);
                    }

                }
                reader.Close();


            }
            query = "SELECT ID_Cliente from Clientes where Apellido = @Apellido;";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Apellido", empl);
                object result = command.ExecuteScalar();
                id_cliente = (int)result;

            }

            query = "SELECT monto_disp, prox_pago, monto_prox FROM Cliente_Deudor where ID_Cliente = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", id_cliente);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBoxCreditoDisp.Text = reader.GetDouble(0).ToString();
                        textBoxFechaPago.Text = reader.GetDateTime(1).ToString();
                        textBoxMontoProx.Text = reader.GetDouble(2).ToString();
                    }

                }
                reader.Close();
            }
            textBoxSubtotal.Text = subt.ToString();
            textBoxTotal.Text = subfinal.ToString();


        }

        private void radioButton1Mes_CheckedChanged(object sender, EventArgs e)
        {
            meses = 1;
            buttonRealizar.Enabled = true;
        }

        private void radioButton3Mes_CheckedChanged(object sender, EventArgs e)
        {
            meses = 3;
            buttonRealizar.Enabled = true;
        }

        private void radioButton6Mes_CheckedChanged(object sender, EventArgs e)
        {
            meses = 6;
            buttonRealizar.Enabled = true;
        }

        private void radioButton12Mes_CheckedChanged(object sender, EventArgs e)
        {
            meses = 12;
            buttonRealizar.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Comentario = textBox1.Text;
        }
    }
}
