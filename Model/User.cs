public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int RoleId { get; set; }
    public Role? role { get; set; }
    public virtual ICollection <Meal>? meal { get; set; }
    public IEnumerable<User>? users { get; set; }

}