using System;
using System.Collections.Generic;
using System.Text;

namespace Project_KLP_12.Models
{
    public interface IStudentModel
    {
        IEnumerable<StudentModel> GetAllStudents();
    }
}
