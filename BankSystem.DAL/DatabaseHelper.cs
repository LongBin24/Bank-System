using Npgsql;

namespace BankSystem.DAL
{
    public class DatabaseHelper
    {
        public static string connString = "Host = localhost;Username=postgres;Password=12345;Database=BankSystemDB";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}
