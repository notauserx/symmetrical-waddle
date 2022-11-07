using System.ComponentModel.DataAnnotations;

namespace Data;

public class User
{
    public Guid Id { get; set; }

    public string? DisplayName { get; set; }

    [Required]
    [MaxLength(60)]
    public string? FirstName { get; set; }

    [Required]
    [MaxLength(60)]
    public string? LastName { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

    public IList<CarListing>? Listings { get; set; }
}