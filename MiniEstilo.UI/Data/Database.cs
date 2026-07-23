using Npgsql;

namespace MiniEstilo.UI.Data
{
    public class Database
    {
        private const string ConnectionString =
            "Host=localhost;Port=5432;Database=mini_estilo_db;Username=postgres;Password=2010";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(ConnectionString);
        }
    }
}