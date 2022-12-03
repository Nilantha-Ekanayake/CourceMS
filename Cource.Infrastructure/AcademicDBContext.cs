using System;
using System.Reflection.Metadata;
using Cource.Domain;
using Microsoft.EntityFrameworkCore;

namespace Cource.Infrastructure
{
    public class AcademicDBContext : DbContext
    {
        public AcademicDBContext(DbContextOptions<AcademicDBContext> options)
        : base(options)
        { }

        public DbSet<AcademicCource> academicCource { get; set; }
        public DbSet<AcademicCourceOutLine> academicCourceOutLine { get; set; }

        public DbSet<Person> person { get; set; }
        public DbSet<Lecturer> lecture { get; set; }
        public DbSet<Student> student { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure StudentId as FK for StudentAddress
            //modelBuilder.Entity<AcademicCource>().
            //            .HasRequired(s => s.)
            //            .WithRequiredPrincipal(ad => ad.Student);
            modelBuilder.Entity<Lecturer>().HasBaseType<Person>();
            modelBuilder.Entity<Student>().HasBaseType<Person>();

        }
    }

       
}

