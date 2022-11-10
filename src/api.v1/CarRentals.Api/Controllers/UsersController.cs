using Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarRentals.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : Controller
{
    private readonly CarRentalsContext carRentalsContext;

    public UsersController(CarRentalsContext carRentalsContext)
    {
        this.carRentalsContext = carRentalsContext;
    }

    [HttpGet]
    public IActionResult GetUsers()
    {
        return Ok(carRentalsContext.Users.ToList());
    }

    [HttpGet("/useruser"), Authorize]
    public IActionResult GetUsers(int size)
    {
        return Ok(carRentalsContext.Users.Take(size).ToList());
    }
}
