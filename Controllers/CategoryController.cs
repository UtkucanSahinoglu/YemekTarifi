using Microsoft.AspNetCore.Mvc;

namespace YemekTarifi.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    public CategoryController(ICategoryService categoryService)
    {
        this._categoryService = categoryService; 
    }
    
}