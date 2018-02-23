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
            SqlConnection _conn;
            var connectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            _conn = new SqlConnection(connectionString);
            if (_conn.State == ConnectionState.Closed || _conn.State == ConnectionState.Broken)
            {
                _conn.Open();
            }
            return _conn;
        }

    }
}
