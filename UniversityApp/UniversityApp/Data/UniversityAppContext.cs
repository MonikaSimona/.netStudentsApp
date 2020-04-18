using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversityApp.Models;

namespace UniversityApp.Data
{
    public class UniversityAppContext : DbContext
    {
        public UniversityAppContext (DbContextOptions<UniversityAppContext> options)
            : base(options)
        {
        }

        public DbSet<UniversityApp.Models.Course> Course { get; set; }

        public DbSet<UniversityApp.Models.Professor> Professor { get; set; }

        public DbSet<UniversityApp.Models.Student> Student { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Enrollment>()
                .HasOne<Student>(p => p.Student)
                .WithMany(p => p.Courses)
                .HasForeignKey(p => p.Id);

            builder.Entity<Enrollment>()
                .HasOne<Course>(p => p.Course)
                .WithMany(p => p.Students)
                .HasForeignKey(p => p.Id);

            builder.Entity<Course>()
                .HasOne<Professor>(p => p.Professor)
                .WithMany(p => p.Courses)
                .HasForeignKey(p => p.FirstProfessorId);

            builder.Entity<Course>()
                .HasOne<Professor>(p => p.Professor)
                .WithMany(p => p.Courses)
                .HasForeignKey(p => p.SecondProfessorId);

        }




    }
}
