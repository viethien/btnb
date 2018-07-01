using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    class Repository
    {
        public SqlConnection Connection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Northwind1"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

    }
}
