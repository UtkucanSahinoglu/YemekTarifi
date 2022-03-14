public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository _userRepository)
    {
        this._userRepository = _userRepository;
    }
    public async Task<User> AddAccount(User user)
    {
        return await _userRepository.AddAccount(user);
    }

    public async Task DeleteUser(User user)
    {
        var DeleteUser = _userRepository.GetByUser(user);
        if ( user == null)
        {
            throw new Exception();
        }
        await _userRepository.DeleteUser(user);
    }

    public async Task<IEnumerable<User>> GetUserByNameLastname(string FirstName, string LastName)
    {
        if ( FirstName == string.Empty || LastName ==string.Empty)
        {
            throw new Exception();
        }
        return await _userRepository.GetUserByNameLastname(FirstName,LastName);
    }

    public async Task<User> UpdateAccount(User user)
    {
        var UpdateAccount = _userRepository.GetByUser(user);
        if (UpdateAccount == null)
        {
            throw new Exception();
        }
        await _userRepository.UpdateAccount(user);
        return user;
    }
}