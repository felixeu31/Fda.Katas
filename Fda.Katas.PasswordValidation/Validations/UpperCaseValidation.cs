namespace Fda.Katas.PasswordValidation.Validations;

public class UpperCaseValidation : IValidation
{
    public UpperCaseValidation()
    {
    }
    
    public bool IsValid(string input)
    {
        return input.Any(c => Char.IsUpper(c));
    }
}