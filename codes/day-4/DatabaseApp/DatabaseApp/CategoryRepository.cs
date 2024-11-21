using Microsoft.Data.SqlClient;
using System.Data;
using static DatabaseApp.DbUtility;

namespace DatabaseApp
{
    public class CategoryRepository : IRepository<Category>
    {
        public CategoryRepository()
        {
            Console.WriteLine("repo created....");
        }
        public int DeleteData(int id)
        {
            IDbConnection connection = null;
            IDbCommand command = null;
            string query = "delete from categories where category_id=@id";
            try
            {
                connection = CreateConnection();

                command = CreateCommand(query, connection);
                SqlParameter idParam = new SqlParameter();
                idParam.ParameterName = "@id";
                idParam.Value = id;
                idParam.Direction = ParameterDirection.Input;
                idParam.SqlDbType = SqlDbType.Int;
                command.Parameters.Add(idParam);
                //command.Parameters.AddWithValue("@id", id);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection(connection);
            }
        }
        public int AddData(Category category)
        {
            IDbConnection connection = null;
            IDbCommand command = null;
            string query = "insert into categories(category_name) values(@name)";
            try
            {
                connection = CreateConnection();

                command = CreateCommand(query, connection);

                SqlParameter nameParam = new SqlParameter();
                nameParam.ParameterName = "@name";
                nameParam.Value = category.Name;
                nameParam.Direction = ParameterDirection.Input;
                nameParam.SqlDbType = SqlDbType.VarChar;

                command.Parameters.Add(nameParam);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection(connection);
            }
        }
        public List<Category> FetchData()
        {
            IDbConnection connection = null;
            IDbCommand command = null;
            string query = "select category_id as ID, category_name as NAME from categories";
            IDataReader reader = null;
            List<Category> categories = null;
            try
            {
                connection = CreateConnection();

                command = CreateCommand(query, connection);

                connection.Open();
                reader = command.ExecuteReader();
                if (((SqlDataReader)reader).HasRows)
                {
                    categories = new List<Category>();
                    while (reader.Read())
                    {
                        Category category = new Category
                        {
                            Id = (int)reader["ID"],
                            Name = (string)reader["NAME"]
                        };
                        categories.Add(category);
                    }
                }
                reader.Close();
                return categories;
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                CloseConnection(connection);
            }
        }
    }
}
