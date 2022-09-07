using PasswordValidation.Validations;

namespace PasswordValidation.Model;

public class PasswordValidator
{
    private readonly List<IValidation> _validations;
    private readonly int _permittedErrors;

    public PasswordValidator(List<IValidation> validations, int permittedErrors = 0)
    {
        if (validations == null || validations.Count == 0)
            throw new ArgumentException("Must provide at least one validation");

        if (permittedErrors < 0) 
            throw new ArgumentOutOfRangeException(nameof(permittedErrors));
        
        this._validations = validations;
        this._permittedErrors = permittedErrors;
    }

    public ValidationResult Validate(string input)
    {
        var failedValidations = _validations.Where(v => !v.IsValid(input)).ToList();

        var isValid = failedValidations.Count() <= _permittedErrors;

        return new ValidationResult(failedValidations.Select(fail => fail.Message).ToList(), isValid);
    }
}