public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public IEnumerable <Category>? category { get; set; }
    public virtual ICollection <Meal>? Meals { get; set;}
}