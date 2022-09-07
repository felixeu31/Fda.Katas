namespace PasswordValidation.Validations;

public class UnderScoreCaseValidation : IValidation
{
    public UnderScoreCaseValidation()
    {
    }

    public bool IsValid(string input)
    {
        return input.Any(c => c.Equals('_'));
    }
    public string Message => "Password must have at least one underscore";

}