using System;
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
    public partial class FormDeudorPlanes : Form
    {
        public string opc;
        public DateTime prox, limite;
        public float credito;
        public FormDeudorPlanes()
        {
            InitializeComponent();
            comboBox1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            this.BackColor = ThemeColor.SecondaryColor;
            panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            textBoxCredito.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxLimite.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
            textBoxProximo.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            opc = comboBox1.SelectedItem.ToString();
            switch (opc)
            {
                case "Cliente Platino":
                    textBoxCredito.Text = "20,000";
                    textBoxLimite.Text = limite.ToString();
                    textBoxProximo.Text = prox.ToString();
                    credito = 20000;
                    break;
                case "Cliente Oro":
                    textBoxCredito.Text = "40,000";
                    textBoxLimite.Text = limite.ToString();
                    textBoxProximo.Text = prox.ToString();
                    credito = 40000;
                    break;
                case "Cliente Diamante":
                    textBoxCredito.Text = "75,000";
                    textBoxLimite.Text = limite.ToString();
                    textBoxProximo.Text = prox.ToString();
                    credito = 75000;
                    break;
                case "Cliente Netherita":
                    textBoxCredito.Text = "100,000";
                    textBoxLimite.Text = limite.ToString();
                    textBoxProximo.Text = prox.ToString();
                    credito = 100000;
                    break;
            }
            buttonAdd.Enabled = true;
        }

        private void FormDeudorPlanes_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            int mes = today.Month;
            if( today.Month == 12)
            {
                prox = new DateTime(today.Year+1, 1, 15);
            }
            else
            {
                prox = new DateTime(today.Year, mes + 1, 15);
            }
            
            limite = new DateTime(today.Year, mes, 30);
        }
    }
}
