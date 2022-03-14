public class Meal
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int CookTime { get; set; }
    public int PersonQuantity { get; set; }
    public int PreperationTime { get; set; }
    public int Point { get; set; }
    public string Image { get; set; }
    public IEnumerable <Meal>? Meals { get; set; }
    public Category category { get; set; }
    public User user { get; set; }
    public virtual IEnumerable <Category>? Categories { get; set; }
    
}