namespace LearnBank.Application.Features.Users.ListUsers;

public record ListUsersItem(
    Guid Id,
    string FullName,
    string Email,
    string TaxIdentificationNumber);
