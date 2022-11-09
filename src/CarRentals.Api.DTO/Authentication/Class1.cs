namespace CarRentals.Api.DTO
{
    public record UserRegistrationRequest
    {

    }

    public record LoginRequest
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }

    public record AuthenticatedResponse
    {
        public string? Token { get; set; }
    }
}