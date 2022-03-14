public interface IRoleService
{
    Task <Role> AddRole(Role role);
    Task <Role> UpdateRole(Role roles,Role role);
    Task DeleteRole(Role roles,Role role);
    Task <IEnumerable<Role>> GetByRoleType(string RoleType);
}