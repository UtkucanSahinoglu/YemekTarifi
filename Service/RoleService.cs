public class RoleService : IRoleService
{
    private readonly IRoleRepository _roleRepository;
    public RoleService(IRoleRepository _roleRepository)
    {
        this._roleRepository = _roleRepository;
    }
    public async Task<Role> AddRole(Role role)
    {
        return await _roleRepository.AddRole(role);
    }

    public async Task DeleteRole(Role roles,Role role)
    {
        var DeleteRole = _roleRepository.GetByRole(roles);
        if ( DeleteRole == null)
        {
            throw new Exception();
        }
        await _roleRepository.DeleteRole(role);
    }

    public async Task<IEnumerable<Role>> GetByRoleType(string RoleType)
    {
        if(RoleType == string.Empty)
        {
            throw new Exception();

        }
        return await _roleRepository.GetByRoleType(RoleType);
    }

    public async Task<Role> UpdateRole(Role roles,Role role)
    {
        var UpdateRole = _roleRepository.GetByRole(roles);
        if (UpdateRole == null)
        {
            throw new Exception();
        }
        return await _roleRepository.UpdateRole(role);
    }
}