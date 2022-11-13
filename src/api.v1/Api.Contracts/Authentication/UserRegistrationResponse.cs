namespace CarRentals.Api.Models;

public record UserRegistrationResponse
{
    public bool IsSuccess { get; set; }

    public Guid UserId { get; set; }

    public string[]? ErrorMessages { get; set; }
}
