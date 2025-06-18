using user_service.Models;

public class UserRepository : IUserRepository
{
    private readonly List<User> _users = new() { new User { Id = 1, Name = "Chandana", Email = "chandana@example.com" } };

    public User GetUserById(int id) => _users.FirstOrDefault(u => u.Id == id);
}
