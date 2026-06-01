using MySql.Data.MySqlClient;

public class DBConnection
{
    private static string connectionString = "server=localhost;database=scheduler;uid=root;pwd=C0d3rp455w0rd;";
    public static MySqlConnection conn = new MySqlConnection(connectionString);

    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }
}