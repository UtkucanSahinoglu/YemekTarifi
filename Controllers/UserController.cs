using Microsoft.AspNetCore.Mvc;

namespace YemekTarifi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly UserService _userService;
    public UserController(UserService userService)
    {
        this._userService = userService;
    }
}