using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Project_KLP_12.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly string connectionString = "server=localhost;database=project1;uid=root;pwd=";

        public UserModel Authenticate(string email, string password, string role)
        {
            UserModel user = null;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE email = @email AND password_hash = @password AND role = @role";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new UserModel()
                            {
                                Id = reader.GetInt32("id"),
                                Name = reader.GetString("name"),
                                Email = reader.GetString("email"),
                                Role = reader.GetString("role"),
                                Jiwa = reader.GetInt32("jiwa"),
                                Kelas = reader.GetString("kelas"),
                                Pelanggaran = reader.GetInt32("pelanggaran"),
                                Kehadiran = reader.GetInt32("kehadiran")
                            };
                        }
                    }
                }
            }
            return user;
        }
    }
}