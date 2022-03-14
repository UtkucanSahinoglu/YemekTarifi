public interface ICategoryRepository
{
    Task <IEnumerable<Category>> GetByName(string Name);
    Task <Category> AddCategory(Category category);
    Task DeleteCategory(Category category);
    Task <Category> UpdateCategory(Category category);
    Task <IEnumerable<Category>> GetByCategory(Category category);

}