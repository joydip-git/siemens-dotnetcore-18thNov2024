using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DatabaseApp
{
    public static class DbUtility
    {
        public static IConfigurationRoot Configuration { get; set; }

        static string GetConnectionString()
        {
            return Configuration.GetConnectionString("SiemensConStr");
        }
        public static IDbConnection CreateConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
        public static IDbCommand CreateCommand(string query, IDbConnection connection)
        {
            var command = connection.CreateCommand();
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            return command;
        }
        public static void CloseConnection(IDbConnection connection)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
