namespace PasswordValidation.Model;

public class ValidationResult
{
    public ValidationResult(List<string> errorMessages, bool isValid)
    {
        ErrorMessages = errorMessages;
        IsValid = isValid;
    }
    public bool IsValid { get; }
    public List<string> ErrorMessages { get; }
}