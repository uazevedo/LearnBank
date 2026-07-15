using LearnBank.Domain.Enums;

namespace LearnBank.Application.Features.Users.CreateUser;

public record CreateUserCommand(
    string FullName,
    string Email,
    string TaxIdentificationNumber,
    Gender Gender);