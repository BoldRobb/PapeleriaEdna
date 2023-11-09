using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        private Form activeForm;
        public FormBase()
        {
            InitializeComponent();
            random = new Random();
            random = new Random();
            buttonCloseChild.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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
        private void FormBase_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }
        private void LoadUserData()
        {
            labelUser.Text = UserCache.LoginName;
            labelPosition.Text = UserCache.Position;
            labelMail.Text = UserCache.Email;
        }
        private void ActivateButton(object btnsender)
        {

            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.4);
                    panelTitle.BackColor = color;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.6);
                    buttonCloseChild.Visible = true;
                }

            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(46, 71, 86);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChilds.Controls.Add(childForm);
            this.panelChilds.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;


        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Clientes.FormClientesBase(), sender);
        }

        private void buttonInventario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Inventario.FormInventarioBase(), sender);
        }

        private void buttonProveedores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Proveedores.FormProveedoresBase(), sender);
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Ventas.FormVentasBase(), sender);
        }

        private void buttonEgresos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Egresos.FormEgresosBase(), sender);
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formularios.Empleados.FormEmpleadosBase(), sender);
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesion?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void buttonMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonTamaño_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonCerrar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicacion?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
        private void buttonCloseChild_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "Bienvenido";
            panelTitle.BackColor = Color.FromArgb(60, 122, 137);
            panelLogo.BackColor = Color.FromArgb(22, 38, 46);
            currentButton = null;
            buttonCloseChild.Visible = false;
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
