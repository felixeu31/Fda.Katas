using Fda.Katas.PasswordValidation.Validations;

namespace Fda.Katas.PasswordValidation;

public class PasswordValidatorOop
{
    private readonly List<IValidation> _validations;
    
    public PasswordValidatorOop()
    {
        _validations = new List<IValidation>()
        {
            new MinimumCharacterValidation(8),
            new UpperCaseValidation(),
            new LowerCaseValidation(),
            new NumberCaseValidation(),
            new UnderScoreCaseValidation()
        };
    }
    
    public bool IsValid(string input)
    {
        return _validations.All(v => v.IsValid(input));
    }
}