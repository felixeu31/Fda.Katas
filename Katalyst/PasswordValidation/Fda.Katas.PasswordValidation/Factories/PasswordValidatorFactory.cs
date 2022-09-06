using PasswordValidation.Model;
using PasswordValidation.Validations;

namespace PasswordValidation.Factories;

public class PasswordValidatorFactory
{
    public static PasswordValidator BuildValidation1()
    {
        return new PasswordValidator(new List<IValidation>()
        {
            new MinimumCharacterValidation(8),
            new UpperCaseValidation(),
            new LowerCaseValidation(),
            new NumberCaseValidation(),
            new UnderScoreCaseValidation()
        });
    }
    public static PasswordValidator BuildValidation2()
    {
        return new PasswordValidator(new List<IValidation>()
        {
            new MinimumCharacterValidation(6),
            new UpperCaseValidation(),
            new LowerCaseValidation(),
            new NumberCaseValidation()
        });
    }
    public static PasswordValidator BuildValidation3()
    {
        return new PasswordValidator(new List<IValidation>()
        {
            new MinimumCharacterValidation(16),
            new UpperCaseValidation(),
            new LowerCaseValidation(),
            new UnderScoreCaseValidation()
        });
    }
}