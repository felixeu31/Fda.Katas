namespace Fda.Katas.PasswordValidation;

public class PasswordValidator
{
    public bool IsValid(string input)
    {
        if (input.Length <= 8)
            return false;

        if (!input.Any(c => Char.IsUpper(c)))
            return false;

        return true;
    }
}