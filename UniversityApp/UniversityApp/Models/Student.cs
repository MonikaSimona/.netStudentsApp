using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace UniversityApp.Models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }

        [StringLength(10, MinimumLength = 3)]
        [Required]
        public string StudentId { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int AcquiredCredits { get; set; }
        public int CurrentSemester { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string EducationLevel { get; set; }
        public string FullName
        {
            get { return String.Format("{0} {1}", FirstName, LastName); }
        }

        public ICollection<Enrollment> Courses { get; set; }
    }
}
