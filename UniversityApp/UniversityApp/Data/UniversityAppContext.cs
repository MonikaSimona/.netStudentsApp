using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversityApp.Models;

namespace UniversityApp.Data
{
    public class UniversityAppContext : DbContext
    {

        public UniversityAppContext (DbContextOptions<UniversityAppContext> options)
            : base(options)
        {
        }

        public DbSet<Professor> Professor { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }

        protected  override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Enrollment>()
                .HasOne<Student>(p => p.Student)
                .WithMany(p => p.Courses)
                .HasForeignKey(p => p.CourseId);

            builder.Entity<Enrollment>()
                .HasOne<Course>(p => p.Course)
                .WithMany(p => p.Students)
                .HasForeignKey(p => p.StudentId);

            builder.Entity<Course>()
                .HasOne<Professor>(p => p.FirstProfessor)
                .WithMany(p => p.FirstProfCourses)
                .HasForeignKey(p => p.FirstProfessorId);

            builder.Entity<Course>()
                .HasOne<Professor>(p => p.SecondProfessor)
                .WithMany(p => p.SecondProfCourses)
                .HasForeignKey(p => p.SecondProfessorId);
        }

    }
}
