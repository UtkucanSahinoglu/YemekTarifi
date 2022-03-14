public interface IMealRepository
{
    Task <Meal> AddMeal(Meal meal);
    Task <Meal> UpdateMeal(Meal meal);
    Task DeleteMeal(Meal meal);
    Task <IEnumerable<Meal>> GetByMeal(Meal meal);
    Task <IEnumerable<Meal>> GetByMealName(string Name);
    Task <IEnumerable<Meal>> GetByPointRange(int MinPoint,int MaxPoint);
    Task <IEnumerable<Meal>> GetByPreperationTime(int MinPreprerationTime,int MaxPreperationTime);
    Task <IEnumerable<Meal>> GetByCookTime(int MinCookTime,int MaxCookTime);
    Task <IEnumerable<Meal>> GetByPersonQuantity(int MinPersonQuantity,int MaxPersonQuantity);
    Task <IEnumerable<Category>> GetByCategoryName(string Name);

}