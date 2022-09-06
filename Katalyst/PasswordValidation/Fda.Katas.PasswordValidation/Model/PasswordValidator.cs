using PasswordValidation.Validations;

namespace PasswordValidation.Model;

public class PasswordValidator
{
    private readonly List<IValidation> _validations;

    public PasswordValidator(List<IValidation> validations)
    {
        _validations = validations;
    }

    public bool IsValid(string input)
    {
        return _validations.All(v => v.IsValid(input));
    }
}