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

    // [Test]
    // public void ValidateMinimunCharacters_Valid_WhenLarge()
    // {
    //     var passwordValidator = new PasswordValidator();
    //     
    //     passwordValidator.IsValid("largepassword").Should().BeTrue();
    // }
    

    [Test]
    public void Validate_Invalid_WhenMissingCapitalLetter()
    {
        var passwordValidator = new PasswordValidator();
        
        passwordValidator.IsValid("passwordwithoutcapital").Should().BeFalse();
    }

    // [Test]
    // public void ValidateCapital_Valid_WhenHasIt()
    // {
    //     var passwordValidator = new PasswordValidator();
    //     
    //     passwordValidator.IsValid("Passwordwithcapital").Should().BeTrue();
    // }
    
    [Test]
    public void Validate_Valid_WhenValidPassword()
    {
        var passwordValidator = new PasswordValidator();
        
        passwordValidator.IsValid("Passwordwithcapital_1").Should().BeTrue();
    }
}