using LearnBank.Domain.Enums;
using LearnBank.Domain.Exceptions;

namespace LearnBank.Domain.Entities;

public class User : Entity
{
    public string FullName { get; private set; }
    public string Email {get; private set; }
    public string TaxIdentificationNumber { get; private set; }
    public Gender Gender {get; private set; }

    public User(
        string fullName,
        string email,
        string taxIdentificationNumber,
        Gender gender
    )
    {
        if (string.IsNullOrWhiteSpace(fullName))
            throw new RequiredFieldException(nameof(fullName));

        if(string.IsNullOrWhiteSpace(email))
            throw new RequiredFieldException(nameof(email));

        if(string.IsNullOrWhiteSpace(taxIdentificationNumber))
            throw new RequiredFieldException(nameof(taxIdentificationNumber));

        FullName = fullName;
        Email = email;
        TaxIdentificationNumber = taxIdentificationNumber;
        Gender = gender;
    }
}