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
    public partial class FormVentaPago : Form
    {
        private double pago;
        private double subt;
        public string Comentario = " ";
        public FormVentaPago(double Subtotal)
        {

            InitializeComponent();
            this.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.3);
            panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.1);
            this.textBoxSubtotal.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.1);
            this.textBoxPago.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.1);
            this.textBoxCambio.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.1);
            subt = Subtotal;
            textBoxSubtotal.Text = subt.ToString();
            textBox1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.1);
            textBox1.ForeColor = Color.White;
        }

        private void buttonRealizar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPago_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxPago.Text, out _))
            {
                pago = double.Parse(textBoxPago.Text);
                if ((pago - subt) < 0)
                {
                    textBoxCambio.Text = "0.00";
                }
                else
                {
                    textBoxCambio.Text = (pago - subt).ToString();
                }

                if (pago > subt)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Comentario = textBox1.Text;
        }
    }
}
