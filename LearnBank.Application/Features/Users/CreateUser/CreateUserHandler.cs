using LearnBank.Application.Common.Interfaces.Persistence;
using LearnBank.Domain.Entities;

namespace LearnBank.Application.Features.Users.CreateUser;

// Basic invariants are enforced by the User entity.
// This handler validates application-level rules only.
public class CreateUserHandler(IUserRepository userRepository)
{
    public async Task<CreateUserResponse> HandleAsync(CreateUserCommand command)
    {
        var user = new User(
            command.FullName,
            command.Email,
            command.TaxIdentificationNumber,
            command.Gender
        );

        await userRepository.AddAsync(user);

        return new CreateUserResponse(
            user.Id,
            user.FullName,
            user.Email,
            user.TaxIdentificationNumber,
            user.Gender,
            user.CreatedAt
        );
    }
}