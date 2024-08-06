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

namespace Presentacion.Formularios.Clientes
{
    public partial class FormPagoDeudor : Form
    {
        int id;
        public double prox, disp, pago;
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        public FormPagoDeudor(int ID)
        {
            InitializeComponent();
            this.id = ID;
            this.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.3);
            panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.1);
            this.textBoxMinimo.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.1);
            this.textBoxPago.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.1);
            this.textBoxDisponible.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.1);
        }

        private void FormPagoDeudor_Load(object sender, EventArgs e)
        {
            string query = "SELECT Monto_Prox, Monto_disp FROM Cliente_Deudor where ID_Cliente = @ID";
            connection=conexion.GetConnection();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ID", id);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        prox = reader.GetDouble(0);
                        disp = reader.GetDouble(1);
                        textBoxMinimo.Text = prox.ToString();
                        textBoxDisponible.Text = disp.ToString();
                    }

                }
                reader.Close();
            }
        }

        private void textBoxPago_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxPago.Text, out _))
            {
                pago = double.Parse(textBoxPago.Text);
                if ((pago - prox) < 0)
                {

                }

                if (pago > prox)
                {
                    buttonRealizar.Enabled = true;
                }
                else
                {
                    buttonRealizar.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("Favor de ingresar una cantidad valida");
            }
        }

        private void buttonRealizar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
