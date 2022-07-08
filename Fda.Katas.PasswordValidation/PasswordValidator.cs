namespace Fda.Katas.PasswordValidation;

public class PasswordValidator
{
    public bool IsValid(string input)
    {
        if (input.Length <= 8)
            return false;

        if (!input.Any(c => Char.IsUpper(c)))
            return false;
        
        if (!input.Any(c => Char.IsLower(c)))
            return false;
        
        if (!input.Any(c => Char.IsNumber(c)))
            return false;

        if (!input.Any(c => c.Equals('_')))
            return false;

        return true;
    }
}