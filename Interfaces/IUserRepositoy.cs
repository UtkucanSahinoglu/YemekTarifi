public interface IUserRepository
{
    Task <User> AddAccount(User user);
    Task <User> UpdateAccount(User user);
    Task DeleteUser(User user);
    Task <IEnumerable<User>> GetByUser(User user);
    Task <IEnumerable<User>> GetUserByNameLastname(string name , string LastName);

}