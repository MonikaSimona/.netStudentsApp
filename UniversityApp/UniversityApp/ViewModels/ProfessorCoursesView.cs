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
        public IEnumerable<Course> FirstProfCourses { get; set; }
        public IEnumerable<Course> SecondProfCourses { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}
