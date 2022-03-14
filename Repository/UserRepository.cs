public class UserRepository : IUserRepository
{
    private readonly YemekTarifiDBContext _yemekTarifiDBContext;
    public UserRepository()
    {
        
    }

    public UserRepository(YemekTarifiDBContext _yemekTarifiDBContext)
    {
        this._yemekTarifiDBContext = _yemekTarifiDBContext;
    }
    public async Task<User> AddAccount(User user)
    {
        var AddAccount = _yemekTarifiDBContext.AddAsync(user);
        await _yemekTarifiDBContext.SaveChangesAsync();
        return user;
    }

    public async Task DeleteUser(User user)
    {
        var DeleteUser = _yemekTarifiDBContext.Remove(user);
        await _yemekTarifiDBContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<User>> GetUserByNameLastname(string FirstName, string LastName)
    {
        return await _yemekTarifiDBContext.users.Where(x => x.FirstName == FirstName).
        Where(x => x.LastName == LastName).ToListAsync();
    }

    public async Task<User> UpdateAccount(User user)
    {
        var UpdateAccount = _yemekTarifiDBContext.Update(user);
        await _yemekTarifiDBContext.SaveChangesAsync();
        return user;
    }

    async Task  <IEnumerable<User>> IUserRepository.GetByUser(User user)
    {
        return await _yemekTarifiDBContext.users.Where(x => x.users == user).ToListAsync();
    }
}