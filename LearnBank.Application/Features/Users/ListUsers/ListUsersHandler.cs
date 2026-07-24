using LearnBank.Application.Common.Interfaces.Persistence;

namespace LearnBank.Application.Features.Users.ListUsers;

public class ListUsersHandler(IUserRepository userRepository)
{
    public async Task<ListUsersResponse> HandleAsync(ListUsersQuery query)
    {
        var users = await userRepository.ListAsync();

        var items = users.Select(user => new ListUsersItem(
            user.Id,
            user.FullName,
            user.Email,
            user.TaxIdentificationNumber)).ToList();

        return new ListUsersResponse(items);
    }
}