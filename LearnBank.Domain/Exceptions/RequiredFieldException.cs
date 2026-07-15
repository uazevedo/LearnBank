namespace LearnBank.Domain.Exceptions;

public class RequiredFieldException(string fieldName) 
    : DomainException($"The field '{fieldName}' is required");