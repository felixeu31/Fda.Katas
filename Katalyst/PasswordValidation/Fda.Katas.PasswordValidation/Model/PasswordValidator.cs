using PasswordValidation.Validations;

namespace PasswordValidation.Model;

public class PasswordValidator
{
    private readonly List<IValidation> _validations;

    public PasswordValidator(List<IValidation> validations)
    {
        _validations = validations;
    }

    public ValidationResult Validate(string input)
    {
        return new ValidationResult()
        {
            ErrorMessages = _validations.Where(v => !v.IsValid(input)).Select(x => x.Message).ToList()
        };
    }
}

public class ValidationResult
{
    public ValidationResult()
    {
        ErrorMessages = new List<string>();
    }
    public bool IsValid => ErrorMessages.Count == 0;
    public List<string> ErrorMessages { get; set; }
}