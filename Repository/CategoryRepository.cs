public class CategoryRepository : ICategoryRepository
{
    private readonly YemekTarifiDBContext _yemekTarifiDBContext;

    public CategoryRepository()
    {
        
    }
    public CategoryRepository(YemekTarifiDBContext _yemekTarifiDBContext)
    {
        this._yemekTarifiDBContext = _yemekTarifiDBContext;
    }
    public async Task<Category> AddCategory(Category category)
    {
        var AddAccount = _yemekTarifiDBContext.AddAsync(category);
        await _yemekTarifiDBContext.SaveChangesAsync();
        return category;
    }

    public async Task DeleteCategory(Category category)
    {
        var DeleteCategory = _yemekTarifiDBContext.Remove(category);
        await _yemekTarifiDBContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<Category>> GetByName(string Name)
    {
        return await _yemekTarifiDBContext.categories.Where(x => x.Name == Name).ToListAsync();
    }

    public async Task<IEnumerable<Category>> GetByCategory(Category category)
    {
        return await _yemekTarifiDBContext.categories.Where(x => x.category == category).ToListAsync();
    }

    public async Task<Category> UpdateCategory(Category category)
    {
        var UpdateCategory = _yemekTarifiDBContext.Update(category);
        await _yemekTarifiDBContext.SaveChangesAsync();
        return category;
    }
}