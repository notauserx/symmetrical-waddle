namespace CarRentals.Api.Models;

public record LoginResponse
{
    public string? Token { get; set; }

    public bool IsSuccess { get; set; }

    public string? ErrorMessage { get; set; }

    public static LoginResponse CreateWithToken(string token) =>
        new() { IsSuccess = true, Token = token };
}
