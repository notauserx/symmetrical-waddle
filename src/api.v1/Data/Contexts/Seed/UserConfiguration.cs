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
                    Id = Guid.NewGuid(),
                    DisplayName = "Admin",
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "admin@carrentalcorporation.com"
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    DisplayName = "Developer",
                    FirstName = "Jane",
                    LastName = "Doe",
                    Email = "janedoe@carrentalcorporation.com"
                }
            );
    }
}
