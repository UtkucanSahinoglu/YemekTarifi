public interface IRoleRepository
{
    Task <Role> AddRole(Role role);
    Task <Role> UpdateRole(Role role);
    Task DeleteRole(Role role);
    Task <IEnumerable<Role>> GetByRoleType(string RoleType);
    Task <IEnumerable<Role>> GetByRole(Role roles);
}