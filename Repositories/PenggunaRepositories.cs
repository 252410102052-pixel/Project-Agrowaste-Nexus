using AgrowasteNexus.Database;
using AgroWasteNexus.Models;
using Npgsql;

namespace AgroWasteNexus.Repositories
{
    public class PenggunaRepository
    {
        public Pengguna Login(string username, string password)
        {
            using (var conn = DbConnectionHelper.GetConnection())
            {
                conn.Open();

                string query = @"SELECT id_pengguna, username, password, role
                                 FROM pengguna
                                 WHERE username = @username
                                 AND password = @password";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Pengguna
                            {
                                IdPengguna = reader.GetInt32(0),
                                Username = reader.GetString(1),
                                Password = reader.GetString(2),
                                Role = reader.GetString(3)
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}