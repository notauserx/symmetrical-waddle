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
        modelBuilder.Entity<CarListing>()
            .HasOne(e => e.User)
            .WithMany(e => e.Listings)
            .HasForeignKey(u => u.UserId);

        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();

        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new CarListingsConfiguration());

    }

    public DbSet<User> Users { get; set; }
    public DbSet<CarListing> CarListings { get; set; }
}