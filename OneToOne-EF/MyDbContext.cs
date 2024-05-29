using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne_EF
{
    internal class MyDbContext : DbContext
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Student&Course;Integrated Security=True";
        public DbSet<Students> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // We tell the app to use the connectionstring.
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder ModelBuilder) 
        {
            ModelBuilder.Entity<Students>().HasData(new Students { Id = 1, FirstName = "Saad", LasttName = "Sabah"});
            ModelBuilder.Entity<Students>().HasData(new Students { Id = 2, FirstName = "Ali", LasttName = "Maseer"});
            ModelBuilder.Entity<Students>().HasData(new Students { Id = 3, FirstName = "Arai", LasttName = "Sayah"});
            ModelBuilder.Entity<Students>().HasData(new Students { Id = 4, FirstName = "Noor", LasttName = "Mohamad"});

            ModelBuilder.Entity<Courses>().HasData(new Courses {  Id = 1, CourseName = "Game Design", CourseKredit = 7.5, CourseGrade = 10, StudentId = 1 });
            ModelBuilder.Entity<Courses>().HasData(new Courses {  Id = 2, CourseName = "English", CourseKredit = 7.5, CourseGrade = 10, StudentId = 2 });
            ModelBuilder.Entity<Courses>().HasData(new Courses {  Id = 3, CourseName = "Math", CourseKredit = 7.5, CourseGrade = 10, StudentId = 3 });
            ModelBuilder.Entity<Courses>().HasData(new Courses {  Id = 4, CourseName = "Math", CourseKredit = 7.5, CourseGrade = 7, StudentId = 4 });
        }

    }
}
