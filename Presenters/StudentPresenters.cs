using Project_KLP_12.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_KLP_12.Presenters
{
    
    public class StudentPresenters  
    {
        private readonly StudentRepository _studentRepository;
        private readonly IStudentView _studentView;

        public StudentPresenters(IStudentView studentView)
        {
            _studentView = studentView;
            _studentRepository = new StudentRepository();
        }
        public void LoadStudentsData()
        {
            
            var students = _studentRepository.GetAllStudents();
            _studentView.DisplayStudentData(students);
        }

    }
    
}
