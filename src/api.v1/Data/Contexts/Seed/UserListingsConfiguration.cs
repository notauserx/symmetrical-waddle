using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data;

public class CarListingsConfiguration : IEntityTypeConfiguration<CarListing>
{
    public void Configure(EntityTypeBuilder<CarListing> builder)
    {
        builder.HasData
            (
                new CarListing()
                {
                    Id = Guid.NewGuid(),
                    MaKe = "Toyota",
                    Model = "Camry",
                    Year = 2022
                }
            );
    }
}
