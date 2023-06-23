using Microsoft.EntityFrameworkCore;

namespace Task1.Models
{
    public class StudentCourse_DBContext : DbContext
    {
        public StudentCourse_DBContext(DbContextOptions<StudentCourse_DBContext> options):base(options)
        {
                
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }

    }
}
