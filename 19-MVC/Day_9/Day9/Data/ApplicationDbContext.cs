using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrainingCenter.Models;

namespace TrainingCenter.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TrainingCenter.Models.Trainee> Trainee { get; set; } = default!;
        public DbSet<TrainingCenter.Models.Course> Course { get; set; } = default!;
        public DbSet<TrainingCenter.Models.Track> Track { get; set; } = default!;
    }
}