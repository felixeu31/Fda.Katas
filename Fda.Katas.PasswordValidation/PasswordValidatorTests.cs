using FluentAssertions;

namespace Fda.Katas.PasswordValidation;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Validate_Invalid_WhenNotMinimumCharacters()
    {
        var passwordValidator = new PasswordValidator();
        
        passwordValidator.IsValid("short").Should().BeFalse();
    }

    [Test]
    public void Validate_Invalid_WhenMissingCapitalLetter()
    {
        var passwordValidator = new PasswordValidator();
        
        passwordValidator.IsValid("passwordwithoutcapital").Should().BeFalse();
    }
    
    [Test]
    public void Validate_Valid_WhenValidPassword()
    {
        var passwordValidator = new PasswordValidator();
        
        passwordValidator.IsValid("Passwordwithcapital_1").Should().BeTrue();
    }
    
    
    [Test]
    public void Validate_Invalid_WhenMissingLowecase()
    {
        var passwordValidator = new PasswordValidator();
        
        passwordValidator.IsValid("PASSWORDMISSINGLOWERCASE").Should().BeFalse();
    }
    
    [Test]
    public void Validate_Invalid_WhenMissingNumber()
    {
        var passwordValidator = new PasswordValidator();
        
        passwordValidator.IsValid("Passwordmissingnumber").Should().BeFalse();
    }
    
    [Test]
    public void Validate_Invalid_WhenMissingUnderscore()
    {
        var passwordValidator = new PasswordValidator();
        
        passwordValidator.IsValid("Passwordmissingundescore9").Should().BeFalse();
    }
}