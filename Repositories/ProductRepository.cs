using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly SqlConnection _conn;
        private string tableName = "Products";
        private string primaryColumn = "ProductID";
        public ProductRepository()
        {
            Repository rep= new Repository();
            _conn = rep.Connection();
        }
        public List<Models.Product> GetAll()
        {
            List<Product> result = new List<Product>();
            string sqlQuery = string.Format("select ProductID, ProductName  from {0}", tableName);
            SqlCommand command = new SqlCommand(sqlQuery, _conn);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    var temp = new Product
                    {
                        ProductID = int.Parse(dataReader["ProductID"].ToString()),
                        ProductName = dataReader["ProductName"].ToString(),
                        QuantityPerUnit = dataReader["QuantityPerUnit"].ToString(),
                        ReorderLevel = int.Parse(dataReader["ReorderLevel"].ToString()),
                        SupplierID = int.Parse(dataReader["SupplierID"].ToString()),
                        UnitsInStock = int.Parse(dataReader["UnitsInStock"].ToString()),
                        CategoryID = int.Parse(dataReader["CategoryID"].ToString()),
                        Discontinued = bool.Parse(dataReader["Discontinued"].ToString()),
                        UnitPrice = decimal.Parse(dataReader["UnitPrice"].ToString()),
                        UnitsOnOrder = int.Parse(dataReader["Unit"].ToString()),
                    };
                    result.Add(temp);
                }
            }
            return result;
        }

        public Models.Product GetById(int productId)
        {
            Product result = new Product();
            string sqlQuery = string.Format("select * from {0} where ProductID={1}", tableName, productId);
            SqlCommand command = new SqlCommand(sqlQuery, _conn);
            SqlDataReader dataReader = command.ExecuteReader();
            //load into the result object the returned row from the database
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    result.ProductID = int.Parse(dataReader["ProductID"].ToString());
                    result.ProductName = dataReader["ProductName"].ToString();
                    result.QuantityPerUnit = dataReader["QuantityPerUnit"].ToString();
                    result.ReorderLevel = int.Parse(dataReader["ReorderLevel"].ToString());
                    result.SupplierID = int.Parse(dataReader["SupplierID"].ToString());
                    result.UnitsInStock = int.Parse(dataReader["UnitsInStock"].ToString());
                    result.CategoryID = int.Parse(dataReader["CategoryID"].ToString());
                    result.Discontinued = bool.Parse(dataReader["Discontinued"].ToString());
                    result.UnitPrice = decimal.Parse(dataReader["UnitPrice"].ToString());
                    result.UnitsOnOrder = int.Parse(dataReader["UnitsOnOrder"].ToString());
                }
            }
            dataReader.Close();
            //conn.Close();

            return result;
        }

        public int Add(Models.Product product)
        {
            var sqlCommand = new SqlCommand();
            sqlCommand.CommandText = string.Format("INSERT INTO {0} (ProductName, QuantityPerUnit,ReorderLevel,SupplierID,UnitsInStock,CategoryID,Discontinued,UnitPrice,UnitsOnOrder) OUTPUT INSERTED.{1} VALUES (@ProductName, @QuantityPerUnit,@ReorderLevel,@SupplierID,@UnitsInStock,@CategoryID,@Discontinued,@UnitPrice,@UnitsOnOrder)", tableName, primaryColumn);
            sqlCommand.Parameters.AddWithValue("@ProductName", product.ProductName);
            sqlCommand.Parameters.AddWithValue("@QuantityPerUnit", product.QuantityPerUnit);
            sqlCommand.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel);
            sqlCommand.Parameters.AddWithValue("@SupplierID", product.SupplierID);
            sqlCommand.Parameters.AddWithValue("@UnitsInStock", product.UnitsInStock);
            sqlCommand.Parameters.AddWithValue("@CategoryID", product.CategoryID);
            sqlCommand.Parameters.AddWithValue("@Discontinued", product.Discontinued);
            sqlCommand.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@UnitsOnOrder", product.UnitsOnOrder);
            sqlCommand.Connection = _conn;
            var id = sqlCommand.ExecuteScalar();
            return id != null ? (int)id : -1;
        }

        public bool Update(Models.Product product)
        {
            var sqlCommand = new SqlCommand();
            sqlCommand.CommandText = string.Format("UPDATE {0} SET ProductName = @ProductName, QuantityPerUnit = @QuantityPerUnit,ReorderLevel=@ReorderLevel,SupplierID=@SupplierID,UnitsInStock=@UnitsInStock,CategoryID=@CategoryID,Discontinued=@Discontinued,UnitPrice=@UnitPrice,UnitsOnOrder=@UnitsOnOrder WHERE {1} = @ProductID", tableName, primaryColumn);
            sqlCommand.Parameters.AddWithValue("@ProductID", product.ProductID);
            sqlCommand.Parameters.AddWithValue("@ProductName", product.ProductName);
            sqlCommand.Parameters.AddWithValue("@QuantityPerUnit", product.QuantityPerUnit);
            sqlCommand.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel);
            sqlCommand.Parameters.AddWithValue("@SupplierID", product.SupplierID);
            sqlCommand.Parameters.AddWithValue("@UnitsInStock", product.UnitsInStock);
            sqlCommand.Parameters.AddWithValue("@CategoryID", product.CategoryID);
            sqlCommand.Parameters.AddWithValue("@Discontinued", product.Discontinued);
            sqlCommand.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@UnitsOnOrder", product.UnitsOnOrder);
            sqlCommand.Connection = _conn;
            return sqlCommand.ExecuteNonQuery() > 0;
        }
        public bool Delete(int productId)
        {
            bool result = false;

            //Create the SQL Query for deleting an Category
            string sqlQuery = string.Format("delete from {0} where ProductID = {1}",tableName,productId);
            string sqlQuery1 = string.Format("delete from {0} where ProductID = {1}", "Order Details", productId);
            string sqlQuery2 = string.Format("delete from {0} where ProductID = {1}", "Orders", productId);
            //Create a Command object
            SqlCommand command2 = new SqlCommand(sqlQuery2, _conn);
            SqlCommand command = new SqlCommand(sqlQuery, _conn);
            SqlCommand command1 = new SqlCommand(sqlQuery1, _conn);
            // Execute the command
            int rowsDeletedCount2 = command2.ExecuteNonQuery();
            int rowsDeletedCount1 = command1.ExecuteNonQuery();
            int rowsDeletedCount = command.ExecuteNonQuery();
            if (rowsDeletedCount != 0)
                result = true;
            // Close and dispose
            command.Dispose();
            return result;
        }
    }
}
