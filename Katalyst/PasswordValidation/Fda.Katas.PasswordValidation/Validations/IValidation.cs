namespace PasswordValidation.Validations;

public interface IValidation
{
    bool IsValid(string input);
}