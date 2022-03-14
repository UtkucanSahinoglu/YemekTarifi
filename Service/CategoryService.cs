public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    public CategoryService(ICategoryRepository _categoryRepository)
    {
        this._categoryRepository = _categoryRepository;
    }
    public async Task<Category> AddCategory(Category category)
    {
        return await _categoryRepository.AddCategory(category);
    }

    public async Task DeleteCategory(Category category)
    {
        var DeleteCategory = _categoryRepository.GetByCategory(category);
        if (category == null)
        {
            throw new Exception();
        }
        await _categoryRepository.DeleteCategory(category);
        
    }

    public async Task<IEnumerable<Category>> GetByName(string Name)
    {
        if (Name == null)
        {
            throw new Exception();
        }
        return await _categoryRepository.GetByName(Name);
    }

    public async Task<IEnumerable<Category>> GetByCategory(Category category)
    {
        if(category == null)
        {
            throw new Exception();
        }
        return await _categoryRepository.GetByCategory(category);
    }

    public async Task<Category> UpdateCategory(Category category)
    {
        var UpdateCategory = _categoryRepository.GetByCategory(category);
        if ( UpdateCategory == null)
        {
            throw new Exception();
        }
        return await _categoryRepository.UpdateCategory(category);
    }
}