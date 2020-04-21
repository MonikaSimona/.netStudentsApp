using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityApp.Data;

namespace UniversityApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UniversityAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<UniversityAppContext>>()))
            {

                if(context.Student.Any() || context.Professor.Any() || context.Courses.Any() || context.Enrollment.Any())
                {
                    return;
                }

                context.Student.AddRange(
                    new Student { StudentId = "25/2018", FirstName = "Stefan", LastName = "Simonovski", AcquiredCredits = 120, EducationLevel = "First Year", EnrollmentDate = DateTime.Parse("2018 - 9 - 3"), CurrentSemester = 3 },
                    new Student { StudentId = "56/2018", FirstName = "Mirko", LastName = "Mirkovski", AcquiredCredits = 100, EducationLevel = "First Year", EnrollmentDate = DateTime.Parse("2018 - 9 - 5"), CurrentSemester = 3 }
                    );
                context.SaveChanges();

                context.Professor.AddRange(
                    new Professor { FirstName = "Rob", LastName = "Bob", AcademicRank = "vonreden", Degree = "Magister", HireDate = DateTime.Parse("1961-11-19"), OfficeNumber = "12122" },
                    new Professor { FirstName = "Bobby", LastName = "Robert", AcademicRank = "vonreden", Degree = "Doktor na nauki", HireDate = DateTime.Parse("1970-11- 30"), OfficeNumber = "32323" }
                    );
                context.SaveChanges();

                context.Courses.AddRange(
                    new Course
                    {
                        Title = "Matematika",
                        Credits = 5,
                        Programme = "Programa",
                        EducationLevel = "Dificult",
                        Semester = 1,
                        FirstProfessorId = context.Professor.Single(d => d.FirstName == "Rob" && d.LastName == "Bob").Id,
                        SecondProfessorId = context.Professor.Single(d => d.FirstName == "Bobby" && d.LastName == "Robert").Id
                    }

                    );
                context.SaveChanges();

                context.Student.AddRange(

                    new Student { StudentId = "25/2018", FirstName = "Stefan", LastName = "Simonovski", AcquiredCredits = 120, EducationLevel = "First Year", EnrollmentDate = DateTime.Parse("2018 - 9 - 3"), CurrentSemester = 3 },
                    new Student { StudentId = "56/2018", FirstName = "Mirko", LastName = "Mirkovski", AcquiredCredits = 100, EducationLevel = "First Year", EnrollmentDate = DateTime.Parse("2018 - 9 - 5"), CurrentSemester = 3 }

                    );
                context.SaveChanges();

                context.Enrollment.AddRange(
                    new Enrollment { CourseId = 1, StudentId = 1,   ExamPoints = 56, AdditionalPoint = 15, ProjectPoints = 23, SeminarPoints = 15, Year = 2020, Grade = 7, FinishDate = DateTime.Parse("2020 - 5 - 26") },
                    new Enrollment { CourseId = 1, StudentId = 2,   ExamPoints = 70, AdditionalPoint = 15, ProjectPoints = 25, SeminarPoints = 15, Year = 2020, Grade = 8, FinishDate = DateTime.Parse("2020 - 5 - 26") }
                    );
                context.SaveChanges();

            }
        }
    }
}
