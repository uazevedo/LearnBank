using LearnBank.Domain.Enums;

namespace LearnBank.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string FullName { get; private set; }
    public string Email {get; private set; }
    public string TaxIdentificationNumber { get; private set; }
    public Gender Gender {get; private set; }
    public DateTime CreatedAt { get; private set; }

    public User(
        string fullName,
        string email,
        string taxIdentificationNumber,
        Gender gender
    )
    {
        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("Fullname is required");

        if(string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email is required");

        if(string.IsNullOrWhiteSpace(taxIdentificationNumber))
            throw new ArgumentException("TaxIdentificationNumber is required");

        Id = Guid.NewGuid();
        FullName = fullName;
        Email = email;
        TaxIdentificationNumber = taxIdentificationNumber;
        Gender = gender;
        CreatedAt = DateTime.UtcNow;
    }
}