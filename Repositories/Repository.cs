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
            var connectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

    }
}
