using System.Configuration;

namespace Project_KLP_12.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email{ get; set; }
        public string Password { get; set; }
        public string  Role { get; set; }
        public string Kelas { get; set; }
        public int Jiwa { get; set; }
        public int Pelanggaran { get; set; }
        public int Kehadiran { get; set; }

        public string SubjectName { get; set; }
        public string TeacherName { get; set;  }
        public string ClassName { get; set; }



    }
}   