using LearnBank.Domain.Entities;

namespace LearnBank.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    Task AddAsync(User user);

    Task<User?> GetByUserIdAsync(Guid id);

    Task<IReadOnlyList<User>> ListAsync();
}