﻿using Microsoft.Data.SqlClient;
namespace DataAccess
{

    public abstract class SqlConnectionDB
    {
        private readonly string connectionString;
        public SqlConnectionDB()
        {
            connectionString = "Server=DESKTOP-D6EMB4F\\SQLEXPRESS;DataBase= Papeleria; integrated security= true;Encrypt=False";
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}