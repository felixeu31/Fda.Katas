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
}