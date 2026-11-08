using System;
using System.Collections.Generic;
using System.Text;

namespace Project_KLP_12.Models
{
    public interface IStudentView
    {
        void DisplayStudentData(List<StudentModel> studentList);
    }
}
