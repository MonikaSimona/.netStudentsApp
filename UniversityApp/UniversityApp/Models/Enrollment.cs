using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace UniversityApp.Models
{
    public class Enrollment
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [Required]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        [StringLength(10, MinimumLength = 3)]
        public string Semester { get; set; }
        public int Year { get; set; }
        public int Grade { get; set; }

        [StringLength(255, MinimumLength = 3)]
        public string SeminarUrl { get; set; }

        [StringLength(255, MinimumLength = 3)]
        public string ProjectUrl { get; set; }

        public int ExamPoints { get; set; }

        public int SeminarPoints { get; set; }

        public int ProjectPoints { get; set; }

        public int AdditionalPoint { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        
        public DateTime? FinishDate { get; set; }

        [NotMapped]
        [Display(Name = "Seminar File Url")]
        public IFormFile SeminarFile { get; set; }


    }
}
