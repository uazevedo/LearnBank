using LearnBank.Domain.Enums;

namespace LearnBank.Application.Features.Users.CreateUser;

public record CreateUserRequest(
    string FullName,
    string Email,
    string TaxIdentificationNumber,
    Gender Gender
);