using Project_KLP_12.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public DataTable GetNilaiSiswa(int userId)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                sub.name AS 'Mata Pelajaran',
                g.score AS 'Nilai',
                g.description AS 'Keterangan'
            FROM grades g
            JOIN students s ON g.student_id = s.id
            JOIN teacher_subjects ts ON g.teacher_subject_id = ts.id
            JOIN subjects sub ON ts.subject_id = sub.id
            WHERE s.user_id = @userId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}