using Microsoft.Data.SqlClient;
using System.Data;

FetchData().ForEach(
    c => Console.WriteLine(c.Name + " " + c.Id)
    );
static List<Category> FetchData()
{
    SqlConnection connection = null;
    SqlCommand command = null;
    string query = "select category_id as ID, category_name as NAME from categories";
    SqlDataReader reader = null;
    List<Category> categories = null;
    try
    {
        connection = new SqlConnection(@"server=.\sqlexpress;database=siemensdatabase;user id=sa;password=sqlserver2024;TrustServerCertificate=true");

        //command = new SqlCommand("", connection);
        command = connection.CreateCommand();
        command.CommandText = query;
        command.CommandType = CommandType.Text;

        connection.Open();
        //Console.WriteLine(connection.State.ToString());
        reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            categories = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category
                {
                    Id = (int)reader["ID"],
                    Name = (string)reader.GetValue("NAME")
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
        if (connection != null && connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }
}

class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}
