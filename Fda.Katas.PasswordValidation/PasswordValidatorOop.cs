using Fda.Katas.PasswordValidation.Validations;

namespace Fda.Katas.PasswordValidation;

public class PasswordValidatorOop
{
    private readonly List<IValidation> _validations;
    
    public PasswordValidatorOop(List<IValidation> validations)
    {
        _validations = validations;
    }
    
    public bool IsValid(string input)
    {
        return _validations.All(v => v.IsValid(input));
    }
}