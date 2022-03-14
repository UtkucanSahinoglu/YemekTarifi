public class RoleRepository : IRoleRepository
{
    private readonly YemekTarifiDBContext _yemekTarifiDBContext;

    public RoleRepository(YemekTarifiDBContext _yemekTarifiDBContext)
    {
        this._yemekTarifiDBContext = _yemekTarifiDBContext;
    }

  
    public async Task<Role> AddRole(Role role)
    {
        await _yemekTarifiDBContext.roles.AddAsync(role);
        await _yemekTarifiDBContext.SaveChangesAsync();
        return role;
    }

    public async Task DeleteRole(Role role)
    {
        var DeleteRole =_yemekTarifiDBContext.Remove(role);
        await _yemekTarifiDBContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<Role>> GetByRole(Role roles)
    {
        return await _yemekTarifiDBContext.roles.Where(x => x.roles == roles).ToListAsync();
    }

    public async Task<IEnumerable<Role>> GetByRoleType(string RoleType)
    {
        return await _yemekTarifiDBContext.roles.Where(x => x.RoleType == RoleType).ToListAsync();
    }

    public async Task<Role> UpdateRole(Role role)
    {
        var UpdateRole = _yemekTarifiDBContext.Update(role);
        await _yemekTarifiDBContext.SaveChangesAsync();
        return role;
    }
}