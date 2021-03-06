﻿using System;
using System.Data.SqlClient;

namespace Test.DataAccess
{
    public class MyConnection
    {
        public void OpenConnection(SqlConnection connection)
        {
            if (connection == null) throw new ArgumentNullException(nameof(connection));
            try
            {
                connection.Open();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
