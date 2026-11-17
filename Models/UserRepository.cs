using Project_KLP_12.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http.Headers;

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
                        s.class_name, s.poin_jiwa, s.poin_pelanggaran, s.ekskul, t.teacher_number, t.kompetensi
                    FROM users u
                    LEFT JOIN students s ON u.id = s.user_id
                    LEFT JOIN teachers t ON u.id = t.user_id
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

                                Ekskul = reader["ekskul"] != DBNull.Value ? reader.GetString("ekskul") : "-",
                                Kelas = reader["class_name"] != DBNull.Value ? reader.GetString("class_name") : "-",
                                Jiwa = reader["poin_jiwa"] != DBNull.Value ? Convert.ToInt32(reader["poin_jiwa"]) : 0,
                                Pelanggaran = reader["poin_pelanggaran"] != DBNull.Value ? Convert.ToInt32(reader["poin_pelanggaran"]) : 0,
                                teacherCode = reader["teacher_number"] != DBNull.Value ? reader.GetString("teacher_number") : "-",
                                Kompetensi = reader["kompetensi"] != DBNull.Value ? Convert.ToInt32(reader["kompetensi"]) : 0,
                                
                                
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
              WHERE teachers.user_id = @teacherId";

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


            }
            return UserJadwal;

        }
        public List<UserModel> GetNilai(int score, string mapel, string class_name, string role)
        {
            List<UserModel> DataNilai = new List<UserModel>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT subjects.subject_name, grades.score, students.class_name
                               FROM grades
                               JOIN teacher_subjects ON grades.teacher_subject_id = teacher_subjects.id
                               JOIN subjects ON teacher_subjects.subject_id = subjects.id 
                               JOIN students ON grades.student_id = students.id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@class_name", class_name);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataNilai.Add(new UserModel
                            {
                                SubjectName = reader["subject_name"] != DBNull.Value ? reader.GetString("subject_name") : "-",
                                Nilai = reader["score"] != DBNull.Value ? reader.GetInt32("score") : 0,
                                ClassName = reader["class_name"] != DBNull.Value ? reader.GetString("class_name") : "-"
                            });

                            
                        }
                    }
                }
                return DataNilai;
            }
        }
    }
}
