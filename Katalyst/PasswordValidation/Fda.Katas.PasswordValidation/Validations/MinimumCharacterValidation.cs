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
        return input.Length >= _minimumNumber;
    }
    public string Message => $"Password must have at least {_minimumNumber} characters";

}