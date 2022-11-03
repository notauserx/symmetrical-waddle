using Microsoft.EntityFrameworkCore;

namespace Data;

public class CarRentalsContext : DbContext
{
    public CarRentalsContext(DbContextOptions options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasMany(u => u.Listings)
            .WithOne();

        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();

        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new CarListingsConfiguration());

    }

    public DbSet<User> Users { get; set; }
    public DbSet<CarListing> CarListings { get; set; }
}