using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data;

public class CarListingsConfiguration : IEntityTypeConfiguration<CarListing>
{
    public void Configure(EntityTypeBuilder<CarListing> builder)
    {
        builder.HasData
            (
                // Listings of user fab81e4b-89d8-43dd-9567-8ffadad4ea33
                new CarListing()
                {
                    Id = new Guid("0a87c369-0e77-497c-8af0-660cf0fafbf4"),
                    MaKe = "Toyota",
                    Model = "Camry",
                    Year = 2022,
                    UserId = new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33")
                },
                new CarListing()
                {
                    Id = new Guid("ffc9510d-4c6a-4a4d-8774-d6d647138d06"),
                    MaKe = "Toyota",
                    Model = "Camry",
                    Year = 2021,
                    UserId = new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33")
                },
                new CarListing()
                {
                    Id = new Guid("18c55c75-9ef4-4486-afc6-0facda23005d"),
                    MaKe = "Ford",
                    Model = "Focus",
                    Year = 2022,
                    UserId = new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33")
                },
                new CarListing()
                {
                    Id = new Guid("54c9131c-0392-4155-9565-49d1ebaf7379"),
                    MaKe = "Ford",
                    Model = "Mustang",
                    Year = 2022,
                    UserId = new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33")
                },
                new CarListing()
                {
                    Id = new Guid("7cfba5c5-e1ee-4ab4-a4d0-9bc3dd352187"),
                    MaKe = "Toyota",
                    Model = "Prius",
                    Year = 2022,
                    UserId = new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33")
                },
                new CarListing()
                {
                    Id = new Guid("ca5ed291-5b42-4276-a726-411f65900e58"),
                    MaKe = "Toyota",
                    Model = "Avalon",
                    Year = 2022,
                    UserId = new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33")
                },
                new CarListing()
                {
                    Id = new Guid("7587c496-5e9e-4cb0-896e-b5215dd3375b"),
                    MaKe = "Toyota",
                    Model = "Yaris",
                    Year = 2022,
                    UserId = new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33")
                },
                new CarListing()
                {
                    Id = new Guid("497fba56-227f-4a80-8e61-cf91e4aabc4e"),
                    MaKe = "Toyota",
                    Model = "C-HR",
                    Year = 2022,
                    UserId = new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33")
                },
                new CarListing()
                {
                    Id = new Guid("35798331-b5aa-4b40-92f5-36254888e62d"),
                    MaKe = "Hyundai",
                    Model = "Sonata",
                    Year = 2022,
                    UserId = new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33")
                },

                // Listing of user 
                new CarListing()
                {
                    Id = new Guid("ea619497-88c1-4886-8bc4-c63ab363f872"),
                    MaKe = "Toyota",
                    Model = "Camry",
                    Year = 2022,
                    UserId = new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33")
                },
                new CarListing()
                {
                    Id = new Guid("035bea3a-034a-41b4-8457-90fc4b0df2be"),
                    MaKe = "Toyota",
                    Model = "Camry",
                    Year = 2022,
                    UserId = new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33")
                }
            );
    }
}
