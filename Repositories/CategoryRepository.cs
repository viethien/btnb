using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    /// <summary>
    /// Category repository
    /// Author: Nguyen Viet Hien
    /// Updated 01-07-2018
    /// </summary>
    public class CategoryRepository : ICategoryRepository
    {
        private readonly SqlConnection _conn;
        private string tableName = "Categories";
        private string primaryColumn = "CategoryId";
        public CategoryRepository()
        {
            Repository rep = new Repository();
            _conn = rep.Connection();
        }
        public List<Models.Category> GetAll()
        {
            var result = new List<Category>();
            string sqlQuery = $"select * from {tableName}";
            SqlCommand command = new SqlCommand(sqlQuery, _conn);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    var temp = new Category
                    {
                        CategoryID = int.Parse(dataReader["CategoryID"].ToString()),
                        Description = dataReader["Description"].ToString(),
                        CategoryName = dataReader["CategoryName"].ToString()
                    };
                    result.Add(temp);
                }
            }
            return result;
        }

        public Models.Category GetById(int categoryId)
        {
            var result = new Category();
            string sqlQuery = $"select * from {tableName} where CategoryID={categoryId}";
            var command = new SqlCommand(sqlQuery, _conn);
            var dataReader = command.ExecuteReader();
            //load into the result object the returned row from the database
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    result.CategoryID = int.Parse(dataReader["CategoryID"].ToString());
                    result.Description = dataReader["Description"].ToString();

                    result.Summary = dataReader["Summary"].ToString();
                    result.CategoryName = dataReader["CategoryName"].ToString();
                }
            }
            dataReader.Close();
            
            return result;
        }

        public int Add(Models.Category category)
        {
            var sqlCommand = new SqlCommand
            {
                CommandText =
                    $"INSERT INTO {tableName} (CategoryName, Description) OUTPUT INSERTED.{primaryColumn} VALUES (@CategoryName, @Description)"
            };
            sqlCommand.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            sqlCommand.Parameters.AddWithValue("@Description", category.Description);
            sqlCommand.Connection = _conn;
            var id = sqlCommand.ExecuteScalar();
            return (int?) id ?? -1;
        }

        public bool Update(Models.Category category)
        {
            var sqlCommand = new SqlCommand();
            sqlCommand.CommandText =
                $"UPDATE {tableName} SET CategoryName = @CategoryName, Description = @Description WHERE {primaryColumn} = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", category.CategoryID);
            sqlCommand.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            sqlCommand.Parameters.AddWithValue("@Description", category.Description);
            sqlCommand.Connection = _conn;
            return sqlCommand.ExecuteNonQuery() > 0;
        }

        public bool Delete(int categoryId)
        {
            bool result = false;

            //Create the SQL Query for deleting an Category
            var sqlQuery = $"delete from {tableName} where categoryId = {categoryId}";
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
