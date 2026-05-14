using GYM.Models;
using Microsoft.EntityFrameworkCore;

namespace GYM.GymDbContext
{
    public class GYMDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GymDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GYMDbContext).Assembly);
        }
       public DbSet<Plan> Plans { get; set; } 

    }
}
