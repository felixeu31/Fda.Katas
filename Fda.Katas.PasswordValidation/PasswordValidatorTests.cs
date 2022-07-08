using FluentAssertions;

namespace Fda.Katas.PasswordValidation;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ValidateMinimunCharacters_Invalid_WhenShort()
    {
        var passwordValidator = new PasswordValidator();
        
        passwordValidator.IsValid("short").Should().BeFalse();
    }

    [Test]
    public void ValidateMinimunCharacters_Valid_WhenLarge()
    {
        var passwordValidator = new PasswordValidator();
        
        passwordValidator.IsValid("largepassword").Should().BeTrue();
    }
    

    [Test]
    public void ValidateCapital_Invalid_WhenMissing()
    {
        var passwordValidator = new PasswordValidator();
        
        passwordValidator.IsValid("passwordwithoutcapital").Should().BeFalse();
    }

    [Test]
    public void ValidateCapital_Valid_WhenHasIt()
    {
        var passwordValidator = new PasswordValidator();
        
        passwordValidator.IsValid("Passwordwithcapital").Should().BeTrue();
    }
}