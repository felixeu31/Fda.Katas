namespace Fda.Katas.PasswordValidation.Validations;

public class NumberCaseValidation : IValidation
{
    public NumberCaseValidation()
    {
    }
    
    public bool IsValid(string input)
    {
        return input.Any(c => Char.IsNumber(c));
    }
}