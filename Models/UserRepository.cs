using Project_KLP_12.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;

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
                string query = @"
                    SELECT 
                        u.id, u.name, u.email, u.role, 
                        s.class_name, s.poin_jiwa, s.poin_pelanggaran 
                    FROM users u
                    LEFT JOIN students s ON u.id = s.user_id
                    WHERE u.email = @email AND u.password_hash = @password AND u.role = @role";

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


                                Kelas = reader["class_name"] != DBNull.Value ? reader.GetString("class_name") : "-",
                                Jiwa = reader["poin_jiwa"] != DBNull.Value ? Convert.ToInt32(reader["poin_jiwa"]) : 0,
                                Pelanggaran = reader["poin_pelanggaran"] != DBNull.Value ? Convert.ToInt32(reader["poin_pelanggaran"]) : 0
                            };
                        }
                    }
                }
            }
            return user;
        }
        public List<UserModel> GetSchedules(int teacher_id, string class_name, string role) 
        { 
            List<UserModel> ListJadwal = new List<UserModel>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = role == "Siswa" ? 
                                     @"SELECT s.subject_name, t.name AS teacher_name, ts.class_name
                                        FROM teacher_subject ts
                                        JOIN subjects s ON ts.subject_id = s.id
                                        JOIN teacher t ON ts.teacher_id = t.id
                                        JOIN users u ON t.user_id
                                        WHERE ts.class_name = @class_name" :
                                        @"SELECT s.subject_name, t.name AS teacher_name, ts.class_name
                                        FROM teacher_subject ts
                                        JOIN subjects s ON ts.subject_id = s.id
                                        JOIN teachers t ON ts.teacher_id = t.id
                                        JOIN users u ON t.user_id
                                        WHERE ts.teacher_id = @teacherId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (role == "Siswa")
                    {
                        cmd.Parameters.AddWithValue("@class_name", class_name);
                    }
                    if (role == "Guru")
                    {
                        cmd.Parameters.AddWithValue("@teacherId", teacher_id);
                    }
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()){
                            ListJadwal.Add(new UserModel
                            {
                                SubjectName = reader["subject_name"] != DBNull.Value ? reader.GetString("subject_name") : "-",
                                Teacher_Id = reader["teacher_id"] != DBNull.Value ? reader.GetInt32("teacher_name") : 0,
                                ClassName = reader["class_name"] != DBNull.Value ? reader.GetString("subject_name") : "-"
                            });
                        }
                    }
                }

            }

            

            return ListJadwal;
        }
    };
}
