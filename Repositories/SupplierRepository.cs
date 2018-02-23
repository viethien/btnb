using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
namespace Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly SqlConnection _conn;
        private string tableName = "Suppliers";
        private string primaryColumn = "SupplierID";
        public SupplierRepository()
        {
            Repository rep = new Repository();
            _conn = rep.Connection();
        }

        public List<Supplier> GetAll()
        {
            List<Supplier> result = new List<Supplier>();
            string sqlQuery = string.Format("select * from {0}", tableName);
            SqlCommand command = new SqlCommand(sqlQuery, _conn);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    var temp = new Supplier
                    {
                        SupplierID = int.Parse(dataReader["SupplierID"].ToString()),
                        PostalCode = dataReader["PostalCode"].ToString(),
                        Region = dataReader["Region"].ToString(),
                        Phone = dataReader["Phone"].ToString(),
                        HomePage = dataReader["HomePage"].ToString(),
                        Fax = dataReader["Fax"].ToString(),
                        Country = dataReader["Country"].ToString(),
                        ContactTitle = dataReader["ContactTitle"].ToString(),
                        ContactName = dataReader["ContactName"].ToString(),
                        CompanyName = dataReader["CompanyName"].ToString(),
                        City = dataReader["City"].ToString(),
                        Address = dataReader["Address"].ToString()

                    };
                    result.Add(temp);
                }
            }
            return result;
        }
        public Supplier GetById(int supplierId)
        {
            Supplier result = new Supplier();
            string sqlQuery = string.Format("select * from {0} where SupplierID={1}", tableName, supplierId);
            SqlCommand command = new SqlCommand(sqlQuery, _conn);
            SqlDataReader dataReader = command.ExecuteReader();
            //load into the result object the returned row from the database
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    result.SupplierID = int.Parse(dataReader["SupplierID"].ToString());
                    result.PostalCode = dataReader["PostalCode"].ToString();
                    result.Region = dataReader["Region"].ToString();
                    result.Phone = dataReader["Phone"].ToString();
                    result.HomePage = dataReader["HomePage"].ToString();
                    result.Fax = dataReader["Fax"].ToString();
                    result.Country = dataReader["Country"].ToString();
                    result.ContactTitle = dataReader["ContactTitle"].ToString();
                    result.ContactName = dataReader["ContactName"].ToString();
                    result.CompanyName = dataReader["CompanyName"].ToString();
                    result.City = dataReader["City"].ToString();
                    result.Address = dataReader["Address"].ToString();
                }
            }
            dataReader.Close();
            //conn.Close();
            return result;
        }

        public int Add(Supplier supplier)
        {
            var sqlCommand = new SqlCommand();
            sqlCommand.CommandText = string.Format("INSERT INTO {0} (PostalCode, Region,Phone,HomePage,Fax,Country,ContactTitle,CompanyName,ContactName,City,Address) OUTPUT INSERTED.{1} VALUES (@PostalCode, @Region,@Phone,@HomePage,@Fax,@Country,@ContactTitle,@CompanyName,@ContactName,@City,@Address)", tableName, primaryColumn);
            sqlCommand.Parameters.AddWithValue("@PostalCode", DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@Region", DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@Phone", DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@HomePage", DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@Fax", DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@Country", DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@ContactTitle", DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@CompanyName", DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@ContactName", supplier.ContactName);
            sqlCommand.Parameters.AddWithValue("@City", DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@Address", DBNull.Value);
            sqlCommand.Connection = _conn;
            var id = sqlCommand.ExecuteScalar();
            return id != null ? (int)id : -1;
        }
        public bool Update(Supplier supplier)
        {
            var sqlCommand = new SqlCommand();
            sqlCommand.CommandText = string.Format("UPDATE {0} SET PostalCode = @PostalCode, Region = @Region,Phone=@Phone,HomePage=@HomePage,Fax=@Fax,Country=@Country, ContactTitle=@ContactTitle,CompanyName=@CompanyName,City=@City,Address=@Address WHERE {1} = @SupplierID", tableName, primaryColumn);
            sqlCommand.Parameters.AddWithValue("@PostalCode", supplier.PostalCode);
            sqlCommand.Parameters.AddWithValue("@Region", supplier.Region);
            sqlCommand.Parameters.AddWithValue("@Phone", supplier.Phone);
            sqlCommand.Parameters.AddWithValue("@HomePage", supplier.HomePage);
            sqlCommand.Parameters.AddWithValue("@Fax", supplier.Fax);
            sqlCommand.Parameters.AddWithValue("@Country", supplier.Country);
            sqlCommand.Parameters.AddWithValue("@ContactTitle", supplier.ContactTitle);
            sqlCommand.Parameters.AddWithValue("@CompanyName", supplier.CompanyName);
            sqlCommand.Parameters.AddWithValue("@City", supplier.City);
            sqlCommand.Parameters.AddWithValue("@Address", supplier.Address);
            sqlCommand.Connection = _conn;
            return sqlCommand.ExecuteNonQuery() > 0;
        }

        public bool Delete(int supplierId)
        {
            bool result = false;
            //Create the SQL Query for deleting an Supplier
            string sqlQuery = string.Format("delete from {0} where SupplierID = {1}", tableName, supplierId);
            //Create a Command object
            SqlCommand command = new SqlCommand(sqlQuery, _conn);
            // Execute the command
            int rowsDeletedCount = command.ExecuteNonQuery();
            if (rowsDeletedCount != 0)
                result = true;
            // Close and dispose
            command.Dispose();
            return result;
        }
    }
}
