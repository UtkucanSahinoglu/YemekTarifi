public class MealService : IMealService
{
    private readonly IMealRepository _mealRepository;
    public MealService(IMealRepository _mealRepository)
    {
        this._mealRepository = _mealRepository;
    }
    public async Task<Meal> AddMeal(Meal meal)
    {
        return await _mealRepository.AddMeal(meal);
    }

    public async Task DeleteMeal(Meal meal)
    {
        var DeleteMeal = _mealRepository.GetByMeal(meal);
        if (meal == null)
        {
            throw new Exception();
        }
        await _mealRepository.DeleteMeal(meal);
    }

    public async Task<IEnumerable<Category>> GetByCategoryName(string Name)
    {
        if ( Name == string.Empty)
        {
            throw new Exception();
        }
        return await _mealRepository.GetByCategoryName(Name);
    }

    public async Task<IEnumerable<Meal>> GetByCookTime(int MinCookTime, int MaxCookTime)
    {
        if ( MinCookTime == null && MaxCookTime == null )
        {
            throw new Exception();
        }
        return await _mealRepository.GetByCookTime(MinCookTime,MaxCookTime);
    }

    public async Task<IEnumerable<Meal>> GetByMeal(Meal meal)
    {
        if( meal == null)
        {
            throw new Exception();
        }
        return await _mealRepository.GetByMeal(meal);
    }

    public async Task<IEnumerable<Meal>> GetByMealName(string Name)
    {
        if( Name == string.Empty)
        {
            throw new Exception();
        }
        return await _mealRepository.GetByMealName(Name);
    }

    public async Task<IEnumerable<Meal>> GetByPersonQuantity(int MinPersonQuantity, int MaxPersonQuantity)
    {
        if ( MinPersonQuantity == null && MaxPersonQuantity == null)
        {
            throw new Exception();
        }
        return await _mealRepository.GetByPersonQuantity(MinPersonQuantity,MaxPersonQuantity);
    }

    public async Task<IEnumerable<Meal>> GetByPointRange(int MinPoint, int MaxPoint)
    {
        if ( MinPoint == null && MaxPoint == null)
        {
            throw new Exception();
        }
        return await _mealRepository.GetByPointRange(MinPoint,MaxPoint);
    }

    public async Task<IEnumerable<Meal>> GetByPreperationTime(int MinPreprerationTime, int MaxPreperationTime)
    {
        if ( MinPreprerationTime == null && MaxPreperationTime == null)
        {
            throw new Exception();
        }
        return await _mealRepository.GetByPreperationTime(MinPreprerationTime,MaxPreperationTime);
    }

    public async Task<Meal> UpdateMeal(Meal meal)
    {
        var UpdateMeal = _mealRepository.GetByMeal(meal);
        if (UpdateMeal == null)
        {
            throw new Exception();
        }
        await _mealRepository.UpdateMeal(meal);
        return meal;
    }
}