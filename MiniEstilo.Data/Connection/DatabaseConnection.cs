using Npgsql;

namespace MiniEstilo.Data.Connection
{
    public static class DatabaseConnection
    {
        private static readonly string connectionString =
            "Host=localhost;Port=5432;Database=mini_estilo_db;Username=postgres;Password=2010";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}