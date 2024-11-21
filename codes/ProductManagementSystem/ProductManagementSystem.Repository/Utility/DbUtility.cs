using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ProductManagementSystem.Repository.Utility
{
    internal static class DbUtility
    {
        static string GetConnectionString()
        {
            var configBuilder = new ConfigurationBuilder();
            configBuilder
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            IConfigurationRoot configuration = configBuilder.Build();
            return configuration.GetConnectionString("SiemensConStr");
        }
        public static IDbConnection CreateConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
        public static IDbCommand CreateCommand(string query, IDbConnection connection, CommandType commandType = CommandType.Text)
        {
            var command = connection.CreateCommand();
            command.CommandText = query;
            command.CommandType = commandType;
            return command;
        }
        public static void CloseConnection(IDbConnection connection)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public static IDbDataParameter CreateParameter(string patamName, object paramValue, DbType dbType, ParameterDirection direction = ParameterDirection.Input)
        {
            var param = new SqlParameter();
            param.ParameterName = patamName;
            param.DbType = dbType;
            param.Direction = direction;
            param.Value = paramValue;
            return param;
        }
    }
}
