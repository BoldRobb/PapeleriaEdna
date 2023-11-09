﻿using Microsoft.Data.SqlClient;
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
    public partial class FormVerClientes : Form
    {
        ConexionBD conexion = new ConexionBD();
        SqlConnection connection = new SqlConnection();
        public FormVerClientes()
        {
            this.BackColor = ThemeColor.SecondaryColor;
            InitializeComponent();
            dataGridView1.BackgroundColor = ThemeColor.SecondaryColor;
            dataGridView1.DefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.1);
            dataGridView1.DefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.2);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.1);
            dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, -0.1);
        }

        private void FormVerClientes_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Clientes_Info";
            connection = conexion.GetConnection();
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
}
