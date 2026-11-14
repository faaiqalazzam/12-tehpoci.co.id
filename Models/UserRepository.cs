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

        public List<UserModel> GetSchedules(int teacherId, string role, string class_name)
        {
            List<UserModel> UserJadwal = new List<UserModel>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = role == "Siswa" ?
              @"SELECT subjects.subject_name, teachers.name AS teacher_name, classes.class_name
              FROM teacher_subjects
              JOIN subjects ON teacher_subjects.subject_id = subjects.id
              JOIN teachers ON teacher_subjects.teacher_id = teachers.id
              JOIN classes ON teacher_subjects.class_id = classes.id
              WHERE classes.class_name = @class_name" :

              @"SELECT subjects.subject_name, teachers.name AS teacher_name, classes.class_name
              FROM teacher_subjects
              JOIN subjects ON teacher_subjects.subject_id = subjects.id
              JOIN teachers ON teacher_subjects.teacher_id = teachers.id
              JOIN classes ON teacher_subjects.class_id = classes.id
              WHERE teacher_subjects.teacher_id = @teacherId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (role == "Siswa")
                    {
                        cmd.Parameters.AddWithValue("@class_name", class_name);
                    }
                    else if (role == "Guru")
                    {
                        cmd.Parameters.AddWithValue("@teacherId", teacherId);
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserJadwal.Add(new UserModel
                            {
                                SubjectName = reader["subject_name"] != DBNull.Value ? reader.GetString("subject_name") : "-",
                                TeacherName = reader["teacher_name"] != DBNull.Value ? reader.GetString("teacher_name") : "-",
                                ClassName = reader["class_name"] != DBNull.Value ? reader.GetString("class_name") : "-"

                            });
                        }
                    }


                }


            } return UserJadwal;

        } 
    } 
}
