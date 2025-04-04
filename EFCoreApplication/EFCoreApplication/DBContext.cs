using Microsoft.EntityFrameworkCore;

namespace EFCoreApplication
{
    public class DBContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=people.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasOne(p => p.City)
                .WithMany(c => c.People)
                .HasForeignKey(p => p.CityId) 
                .OnDelete(DeleteBehavior.Cascade); 
        }
    }
}