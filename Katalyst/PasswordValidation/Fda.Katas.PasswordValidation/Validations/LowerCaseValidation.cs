namespace PasswordValidation.Validations;

public class LowerCaseValidation : IValidation
{
    public LowerCaseValidation()
    {
    }

    public bool IsValid(string input)
    {
        return input.Any(c => char.IsLower(c));
    }

    public string Message => "Password must have at least one lower case";
}