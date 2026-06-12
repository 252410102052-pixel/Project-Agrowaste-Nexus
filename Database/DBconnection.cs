using Npgsql;

namespace AgrowasteNexus.Database
{
    public static class DbConnectionHelper
    {
        private static readonly string ConnectionString =
            "Host=localhost;Port=5432;Username=postgres;Password=SuperPower07;Database=nexus";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(ConnectionString);
        }
    }
}