using Microsoft.EntityFrameworkCore;

namespace ParksApi.Models
{
    public class ParksApiContext : DbContext
    {
        public ParksApiContext(DbContextOptions<ParksApiContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
                .HasData(
                new Park { ParkId = 1, Name = "Test Park", Code = "Test", City = "Seattle, WA" }
                );
        }


        public DbSet<Park> Parks { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}