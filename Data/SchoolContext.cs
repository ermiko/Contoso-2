using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }
        //tinfo200:[2021-03-11-egetahun-dykstra1]- these entities tell the entity framework to relate Courses,Enrollments, and Students
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        //tinfo200:[2021-03-11-egetahun-dykstra1]- This allows us to tell the entity framework what specific name we want to give to the Tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)  
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
