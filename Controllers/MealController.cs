using Microsoft.AspNetCore.Mvc;

namespace YemekTarifi.Controllers;

[ApiController]
[Route("[controller]")]
public class MealController : ControllerBase
{
    private readonly IMealService _mealService;
    public MealController(IMealService mealService)
    {
        this._mealService = mealService; 
    }
}