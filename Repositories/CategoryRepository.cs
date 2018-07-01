﻿using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
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
            List<Category> result = new List<Category>();
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
            Category result = new Category();
            string sqlQuery = $"select * from {tableName} where CategoryID={categoryId}";
            SqlCommand command = new SqlCommand(sqlQuery, _conn);
            SqlDataReader dataReader = command.ExecuteReader();
            //load into the result object the returned row from the database
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    result.CategoryID = int.Parse(dataReader["CategoryID"].ToString());
                    result.Description = dataReader["Description"].ToString();

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
            sqlCommand.CommandText = string.Format("UPDATE {0} SET CategoryName = @CategoryName, Description = @Description WHERE {1} = @Id", tableName, primaryColumn);
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
            string sqlQuery = string.Format("delete from {0} where categoryId = {1}", tableName, categoryId);
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