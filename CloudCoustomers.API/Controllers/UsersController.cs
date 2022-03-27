using CloudCoustomers.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CloudCoustomers.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUsersService _userService;

    public UsersController(IUsersService usersService)
    {
        _userService = usersService;
    }

    [HttpGet(Name = "GetUsers")]
    public async Task<IActionResult> Get()
    {
        var users = await _userService.GetAllUsers();

        if (users.Any())
        {
            return Ok(users);
        }

        return NotFound();
    }
}
