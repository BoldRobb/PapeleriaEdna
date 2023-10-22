using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormBase : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public FormBase()
        {
            InitializeComponent();
            random = new Random();
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnsender)
        {
            DisableButton();
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(41, 32, 74);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonInventario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonProveedores_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonEgresos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}
