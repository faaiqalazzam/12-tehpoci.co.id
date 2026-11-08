using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Project_KLP_12.Models
{
    public class StudentRepository 
    {
        private string connectionString = "server=localhost;database=project1;uid=root;pwd=";

        public List<StudentModel> GetAllStudents() 
        {
            var students = new List<StudentModel>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id, nis, nama, class_name, jurusan, email, nomor FROM students";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    using(var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new StudentModel
                            {
                                id = reader.GetInt32("id"),
                                name = reader.GetString("name"),
                                classes = reader.GetString("class_name"),
                                nisn = reader.GetString("nis"),
                                email = reader.GetString("email"),
                                jurusan = reader.GetString("jurusan"),
                                nomor = reader.GetString("nomor"),
                            });

                        }
                    }
                }
            }
            return students;
        }
    }
}
