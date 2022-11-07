using System.ComponentModel.DataAnnotations;

namespace Data;
public class CarListing
{
    public Guid Id { get; set; }

    [Required]
    [MaxLength(60)]
    public string? MaKe { get; set; }

    [Required]
    [MaxLength(60)]
    public string? Model { get; set; }

    [Required]
    public int Year { get; set; }

    public bool IsDeactivated { get; set; }

    public Guid? UserId { get; set; }

    public User? User { get; set; }

    // TDOD :: make rate as a separate entity
}
