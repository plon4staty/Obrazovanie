﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Obrazovanie
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = db.edu.cchgeu.ru; Initial Catalog = 193_Meshcheryakov; User = 193_Meshcheryakov; Password = Itodor_23@");

        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }

        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }






    }
}
