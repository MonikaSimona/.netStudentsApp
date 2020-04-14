using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityApp.Models
{
    public class Course
    {
        [Required]
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Required]
        public int Credits { get; set; }

        [Required]
        public int Semester { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public string Programme { get; set; }

        [StringLength(25, MinimumLength = 3)]
        public string EducationLevel { get; set; }
        public int? FirstTeacherId { get; set; }
        public Professor FirstTeacher { get; set; }
        public int? SecondTeacherId { get; set; }
        public Professor SecondTeacher { get; set; }
        public ICollection<Enrollment> Students { get; set; }

    }
}
