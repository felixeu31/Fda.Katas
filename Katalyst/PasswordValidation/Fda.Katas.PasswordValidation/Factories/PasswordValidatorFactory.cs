using PasswordValidation.Model;
using PasswordValidation.Validations;

namespace PasswordValidation.Factories;

public class PasswordValidatorFactory
{
    public static PasswordValidator BuildValidation1()
    {
        return new PasswordValidatorBuilder()
            .WithMinimumCharacterValidation(8)
            .WithUpperCaseValidation()
            .WithLowerCaseValidation()
            .WithNumberCaseValidation()
            .WithUnderScoreCaseValidation()
            .Build();
    }
    public static PasswordValidator BuildValidation2()
    {
        return new PasswordValidatorBuilder()
            .WithMinimumCharacterValidation(6)
            .WithUpperCaseValidation()
            .WithLowerCaseValidation()
            .WithNumberCaseValidation()
            .Build();
    }
    public static PasswordValidator BuildValidation3()
    {
        return new PasswordValidatorBuilder()
            .WithMinimumCharacterValidation(16)
            .WithUpperCaseValidation()
            .WithLowerCaseValidation()
            .WithUnderScoreCaseValidation()
            .Build();
    }
}