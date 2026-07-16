using LearnBank.Domain.Enums;

namespace LearnBank.Application.Features.Users.CreateUser;

public record CreateUserResponse(
    Guid Id,
    string FullName,
    string Email,
    string TaxIdentificationNumber,
    Gender Gender,
    DateTime CreatedAt);