namespace CarRentals.Api.Models;

public record UserRegistrationRequest
{
    public string? FirstNmae { get; set; }
    public string? LastNmae { get; set; } 
    public string? Email { get; set; }
    public string? Password { get; set; }
}
