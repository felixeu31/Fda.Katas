namespace PasswordValidation.Validations;

public class UpperCaseValidation : IValidation
{
    public UpperCaseValidation()
    {
    }

    public bool IsValid(string input)
    {
        return input.Any(c => char.IsUpper(c));
    }
    public string Message => "Password must have at least one upper case";

}