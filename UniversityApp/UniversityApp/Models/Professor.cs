using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace UniversityApp.Models
{
    public class Professor
    {
        [Required]
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Degree { get; set; }

        [StringLength(25, MinimumLength = 3)]
        public string AcademicRank { get; set; }

        [StringLength(10, MinimumLength = 3)]
        public string OfficeNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }
        [Display(Name = "Professors Full Name")]
        public string FullName
        {
            get { return String.Format("{0} {1}", FirstName, LastName); }
        }
        public ICollection<Course> FirstProfCourses { get; set; }
        public ICollection<Course> SecondProfCourses { get; set; }

        //public ICollection<Course> FirstTeachersCourses { get; set; }
        //public ICollection<Course> SecondTeachersCourses { get; set; }
    }
}
