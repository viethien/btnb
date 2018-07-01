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
            var connection = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            SqlConnection conn = new SqlConnection(connection);
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken || conn.State == ConnectionState.Executing)
            {
                conn.Open();
            }
            return conn;
        }

    }
}
