using Microsoft.EntityFrameworkCore;
using Dosaaf.Models;

namespace Dosaaf.Services
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Admin> Admins { get; set; } = null!;
        public DbSet<Education> Educations { get; set; } = null!;
        public DbSet<OnlineEducation> OnlineEducations { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(
                new Admin { Id = 1, Name = "kyfbtch", Password = "Z2FpZG9zYWFmYWRtaW56bXFw" }
                );
        }
    }
}
