using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityApp.Models;

namespace UniversityApp.ViewModels
{
    public class ProfessorFilterViewModel
    {
        public IList<Professor> Professors { get; set; }
        public string NameSearch { get; set; }
       
        public SelectList Degrees { get; set; }
        public string ProfessorDegree { get; set; }
        public SelectList AcademicRanks { get; set; }
        public string ProfessorAcademicRank { get; set; }
        
    }
}
