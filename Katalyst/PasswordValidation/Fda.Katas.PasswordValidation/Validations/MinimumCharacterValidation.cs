namespace PasswordValidation.Validations;

public class MinimumCharacterValidation : IValidation
{
    private readonly int _minimumNumber;

    public MinimumCharacterValidation(int minimumNumber)
    {
        _minimumNumber = minimumNumber;
    }

    public bool IsValid(string input)
    {
        return input.Length >= 8;
    }
}