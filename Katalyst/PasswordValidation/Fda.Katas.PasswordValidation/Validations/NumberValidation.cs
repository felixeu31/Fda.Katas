﻿namespace PasswordValidation.Validations;

public class NumberCaseValidation : IValidation
{
    public NumberCaseValidation()
    {
    }

    public bool IsValid(string input)
    {
        return input.Any(c => char.IsNumber(c));
    }

    public string Message => "Password must have at least one number";

}