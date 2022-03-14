public class MealRepository : IMealRepository
{
    private readonly YemekTarifiDBContext _yemekTarifiDBContext;

    public MealRepository()
    {
        
    }

    public MealRepository(YemekTarifiDBContext _yemekTarifiDBContext)
    {
        this._yemekTarifiDBContext = _yemekTarifiDBContext;
    }
    public async Task<Meal> AddMeal(Meal meal)
    {
        var AddMeal = _yemekTarifiDBContext.AddAsync(meal);
        await _yemekTarifiDBContext.SaveChangesAsync();
        return meal;
    }

    public async Task DeleteMeal(Meal meal)
    {
        var DeleteMeal = _yemekTarifiDBContext.Remove(meal);
        await _yemekTarifiDBContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<Category>> GetByCategoryName(string Name)
    {
        return await _yemekTarifiDBContext.categories.Where(x =>x.Name == Name).ToListAsync();
    }

    public async Task<IEnumerable<Meal>> GetByCookTime(int MinCookTime, int MaxCookTime)
    {
        return await _yemekTarifiDBContext.Set<Meal>().Where(x =>x.CookTime >= MinCookTime && x.CookTime <= MaxCookTime).ToListAsync();
    }

    public async Task<IEnumerable<Meal>> GetByMeal(Meal meal)
    {
        return await _yemekTarifiDBContext.meals.Where(x => x.Meals == meal).ToListAsync();
    }

    public async Task<IEnumerable<Meal>> GetByMealName(string Name)
    {
        return await _yemekTarifiDBContext.Set<Meal>().Where(x =>x.Name ==Name).ToListAsync();
    }

    public async Task<IEnumerable<Meal>> GetByPersonQuantity(int MinPersonQuantity, int MaxPersonQuantity)
    {
        return await _yemekTarifiDBContext.Set<Meal>().Where(x =>x.PersonQuantity >= MinPersonQuantity && x.PersonQuantity <= MaxPersonQuantity).ToListAsync();
    }

    public async Task<IEnumerable<Meal>> GetByPointRange(int MinPoint, int MaxPoint)
    {
        return await _yemekTarifiDBContext.Set<Meal>().Where(x =>x.Point >=MinPoint && x.Point <= MaxPoint).ToListAsync();
    }

    public async Task<IEnumerable<Meal>> GetByPreperationTime(int MinPreprerationTime, int MaxPreperationTime)
    {
        return await _yemekTarifiDBContext.Set<Meal>().Where(x =>x.PreperationTime >=MinPreprerationTime && x.PreperationTime <= MaxPreperationTime).ToListAsync();
    }

    public async Task<Meal> UpdateMeal(Meal meal)
    {
        var UpdateMeal = _yemekTarifiDBContext.Update(meal);
        await _yemekTarifiDBContext.SaveChangesAsync();
        return meal;
    }
}