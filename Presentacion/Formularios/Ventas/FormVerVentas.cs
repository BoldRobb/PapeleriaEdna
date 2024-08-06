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
    public partial class FormVerVentas : Form
    {
        ConexionBD conexionBD = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        public FormVerVentas()
        {
            
            InitializeComponent();
            this.BackColor = ThemeColor.SecondaryColor;
            dataGridView1.BackgroundColor = ThemeColor.PrimaryColor;
            dataGridView1.DefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            dataGridView1.DefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.2);
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.25);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.1);
            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.15);
            dataGridView1.MinimumSize = new Size(1025, 458);
            dataGridView1.AutoSize = false;
        }

        private void FormVerVentas_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.ToString() == "Contado")
            {
                string sql = "SELECT * FROM Ventas_Info_Debito";
                connection = conexionBD.GetConnection();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter dataadapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "result");
                connection.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "result";
            }
            else if (comboBox1.SelectedItem.ToString() == "Credito")
            {
                string sql = "SELECT * FROM Ventas_Info_Credito";
                connection = conexionBD.GetConnection();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter dataadapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "result");
                connection.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "result";
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
