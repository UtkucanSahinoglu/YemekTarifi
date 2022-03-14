public class Role
{
    public int Id { get; set; }
    public string RoleType { get; set; }
    public IEnumerable<Role>? roles { get; set; }
    public virtual ICollection <User>? Users { get; set; }

}