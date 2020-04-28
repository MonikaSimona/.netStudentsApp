using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityApp.Models;

namespace UniversityApp.ViewModels
{
    public class ProfessorCoursesView
    {
        public IList<Professor> Professors { get; set; }
        public IList<Course> FirstProfCourses { get; set; }
        public IList<Course> SecondProfCourses { get; set; }
        public IList<Student> Students { get; set; }
    }
}
