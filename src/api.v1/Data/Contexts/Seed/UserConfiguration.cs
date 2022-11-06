using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasData
            (
                new User()
                {
                    Id = new Guid("874313be-3037-4fb6-be0b-285f1f5e9c3e"),
                    DisplayName = "Admin",
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "admin@carrentalcorporation.com"
                },
                new User()
                {
                    Id = new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33"),
                    DisplayName = "Developer",
                    FirstName = "Jane",
                    LastName = "Doe",
                    Email = "janedoe@carrentalcorporation.com"
                },
                new User()
                {
                    Id = new Guid("0aed55c3-b593-49da-b1ff-6532fc46b6c4"),
                    DisplayName = "Bill Autos",
                    FirstName = "Bill",
                    LastName = "Hayden",
                    Email = "billieHay@somedomain.com"
                },
                new User()
                {
                    Id = new Guid("ceae382c-70f8-46d1-8ec1-cb7d3b4abd9f"),
                    DisplayName = "Autos at High Park Blvd",
                    FirstName = "Cameron",
                    LastName = "Yo",
                    Email = "careronyo@autosathighpark.com"
                },
                new User()
                {
                    Id = new Guid("745ee7e0-d756-485f-8f1d-8b2bccc007fe"),
                    DisplayName = "Customer",
                    FirstName = "Olivia",
                    LastName = "Spencer",
                    Email = "oOliviaO@somedomain.com"
                },
                new User()
                {
                    Id = new Guid("50ec3410-bf52-4cc6-b7bf-61e306b92593"),
                    DisplayName = "Customer",
                    FirstName = "James",
                    LastName = "Bill",
                    Email = "jamiesGetsBilled@somedomain.com"
                }
            );
    }
}
