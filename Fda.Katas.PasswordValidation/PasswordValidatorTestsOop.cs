using FluentAssertions;

namespace Fda.Katas.PasswordValidation;

public class PaswordValidatorTestsOop
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void PasswordValidatorOop_Invalid_WhenNotMinimumCharacters()
    {
        var passwordValidator = new PasswordValidatorOop();
        
        passwordValidator.IsValid("short").Should().BeFalse();
    }

    [Test]
    public void PasswordValidatorOop_Invalid_WhenMissingCapitalLetter()
    {
        var passwordValidator = new PasswordValidatorOop();
        
        passwordValidator.IsValid("passwordwithoutcapital").Should().BeFalse();
    }
    
    [Test]
    public void PasswordValidatorOop_Valid_WhenValidPassword()
    {
        var passwordValidator = new PasswordValidatorOop();
        
        passwordValidator.IsValid("Passwordwithcapital_1").Should().BeTrue();
    }
    
    
    [Test]
    public void PasswordValidatorOop_Invalid_WhenMissingLowecase()
    {
        var passwordValidator = new PasswordValidatorOop();
        
        passwordValidator.IsValid("PASSWORDMISSINGLOWERCASE").Should().BeFalse();
    }
    
    [Test]
    public void PasswordValidatorOop_Invalid_WhenMissingNumber()
    {
        var passwordValidator = new PasswordValidatorOop();
        
        passwordValidator.IsValid("Passwordmissingnumber").Should().BeFalse();
    }
    
    [Test]
    public void PasswordValidatorOop_Invalid_WhenMissingUnderscore()
    {
        var passwordValidator = new PasswordValidatorOop();
        
        passwordValidator.IsValid("Passwordmissingundescore9").Should().BeFalse();
    }
}