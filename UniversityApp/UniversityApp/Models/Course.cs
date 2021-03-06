﻿using System;
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

        public int? FirstProfessorId { get; set; }
        public int? SecondProfessorId { get; set; }
        [Display(Name = "First Professor")]
        public Professor FirstProfessor { get; set; }
        [Display(Name = "Second Professor")]
        public Professor SecondProfessor { get; set; }


        //public ICollection<CourseProfessor> Professors { get; set; }

        public ICollection<Enrollment> Students { get; set; }

    }
}
