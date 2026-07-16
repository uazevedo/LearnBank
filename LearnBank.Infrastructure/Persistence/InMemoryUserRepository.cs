using LearnBank.Application.Common.Interfaces.Persistence;
using LearnBank.Domain.Entities;

namespace LearnBank.Persistence;

public class InMemoryUserRepository : IUserRepository
{
    private static readonly List<User> Users = [];
    public Task AddAsync(User user)
    {
        Users.Add(user);
        return Task.CompletedTask;
    }

    public Task<User?> GetByUserIdAsync(Guid id)
    {
        var user = Users.FirstOrDefault(User => User.Id == id);
        return Task.FromResult(user);
    }

    public Task<IReadOnlyList<User>> ListAsync()
    {
        return Task.FromResult<IReadOnlyList<User>>(Users);
    }
}