using Microsoft.AspNetCore.Mvc;

namespace YemekTarifi.Controllers;

[ApiController]
[Route("[controller]")]
public class RoleController : ControllerBase
{
    private readonly RoleService _roleService;
    public RoleController(RoleService roleService)
    {
        this._roleService = roleService; 
    }
}