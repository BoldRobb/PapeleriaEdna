using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Presentacion
{
    public partial class inicioSesion : Form
    {
        public inicioSesion()
        {
            InitializeComponent();

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "Usuario")
            {
                if (txtpass.Text != "Contraseña")
                {
                    UsuarioModel user = new UsuarioModel();
                    var validLogin = user.LoginUser(txtuser.Text, txtpass.Text);
                    if (validLogin == true)
                    {
                        FormBase mainMenu = new FormBase();
                        MessageBox.Show("Bienvenido");
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }

                    else
                    {
                        MsgError("Usuario o contraseña incorrecto \n   Favor de intentarlo nuevamente");
                    }
                }
                else
                {
                    MsgError("Por favor ingrese una Contraseña");
                    txtpass.Text = "";
                    txtuser.Focus();

                };
            }
            else MsgError("Por favor ingrese un Usuario");

        }
        private void MsgError(string msg)
        {
            labelmsgerror.Text = "   " + msg;
            labelmsgerror.Visible = true;
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
            else
            {
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtuser.ForeColor = Color.Black;
            }

        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Text = "Contraseña";
            txtpass.ForeColor = Color.Silver;
            txtpass.UseSystemPasswordChar = false;
            txtuser.Text = "Usuario";
            txtuser.ForeColor = Color.Silver;
            labelmsgerror.Visible = false;
            this.Show();
        }
    }
}
