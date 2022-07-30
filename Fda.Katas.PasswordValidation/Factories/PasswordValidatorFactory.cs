using Fda.Katas.PasswordValidation.Validations;

namespace Fda.Katas.PasswordValidation.Factories;

public class PasswordValidatorFactory
{
    public static PasswordValidatorOop BuildValidation1()
    {
        return new PasswordValidatorOop(new List<IValidation>()
        {
            new MinimumCharacterValidation(8),
            new UpperCaseValidation(),
            new LowerCaseValidation(),
            new NumberCaseValidation(),
            new UnderScoreCaseValidation()
        });
    }
    public static PasswordValidatorOop BuildValidation2()
    {
        return new PasswordValidatorOop(new List<IValidation>()
        {
            new MinimumCharacterValidation(6),
            new UpperCaseValidation(),
            new LowerCaseValidation(),
            new NumberCaseValidation()
        });
    }
    public static PasswordValidatorOop BuildValidation3()
    {
        return new PasswordValidatorOop(new List<IValidation>()
        {
            new MinimumCharacterValidation(16),
            new UpperCaseValidation(),
            new LowerCaseValidation(),
            new UnderScoreCaseValidation()
        });
    }
}