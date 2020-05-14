using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityApp.Models;

namespace UniversityApp.ViewModels
{
    public class EnrollmentViewModel
    {
        public Course Course { get; set; }
        public IEnumerable<int> SelectedStudents { get; set; }
        public IEnumerable<SelectListItem> StudentList { get; set; }
        public Enrollment Enrollment { get; set; }

    }
}
