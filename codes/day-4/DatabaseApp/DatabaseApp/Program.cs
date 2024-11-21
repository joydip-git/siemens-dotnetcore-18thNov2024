using Microsoft.Data.SqlClient;

FetchData();
static void FetchData()
{
    //using sql server authentication connecting the server in the local machine
    SqlConnection connection = new SqlConnection(@"server=.\sqlexpress;user id=sa;password=;TrustServerCertificate=true");

    //using sql server authentication connecting the server in docker container
    //SqlConnection connection = new SqlConnection(@"server=localhost\sqlexpress,1433;user id=sa;password=;TrustServerCertificate=true");

    connection.Open();
    Console.WriteLine(connection.State.ToString());
    connection.Close();
}
